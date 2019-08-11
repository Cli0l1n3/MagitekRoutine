﻿using System.Linq;
using System.Threading.Tasks;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Managers;
using Magitek.Extensions;
using Magitek.Models.Astrologian;
using Magitek.Utilities;
using static ff14bot.Managers.ActionResourceManager.Astrologian;

namespace Magitek.Logic.Astrologian
{
    internal static class Cards
    {

        public static async Task<bool> PlayCards()
        {
            if (!AstrologianSettings.Instance.UseDraw)
                return false;

            var cardDrawn = Arcana != AstrologianCard.None;
            
            if (!cardDrawn)
                if (await Spells.Draw.Cast(Core.Me))
                    await Coroutine.Wait(750, () => Core.Me.HasAnyCardAura());
                
            if (DivinationSeals.Any(c => c == 0))
                if (Spells.Redraw.Charges > 1)
                    switch (Arcana)
                    {
                        //Solar Seal
                        case AstrologianCard.Balance:
                        case AstrologianCard.Bole:
                            if (DivinationSeals.Any(c => c == AstrologianSeal.Solar_Seal))
                                return await Spells.Redraw.Cast(Core.Me);
                            break;

                        //Lunar Seal
                        case AstrologianCard.Arrow:
                        case AstrologianCard.Ewer:
                            if (DivinationSeals.Any(c => c == AstrologianSeal.Lunar_Seal))
                                return await Spells.Redraw.Cast(Core.Me);
                            break;

                        //Celestial Seal
                        case AstrologianCard.Spear:
                        case AstrologianCard.Spire:
                            if (DivinationSeals.Any(c => c == AstrologianSeal.Celestial_Seal))
                                return await Spells.Redraw.Cast(Core.Me);
                            break;
                    }

            if (DivinationSeals.All(c => c != 0))
                await Spells.Divination.Cast(Core.Me);

            if (DivinationSeals.Any(c => c == AstrologianSeal.Solar_Seal || c == AstrologianSeal.Lunar_Seal || c == AstrologianSeal.Celestial_Seal))
                switch (Arcana)
                {
                    //Solar Seal
                    case AstrologianCard.Balance:
                    case AstrologianCard.Bole:
                        if (DivinationSeals.Any(c => c == AstrologianSeal.Solar_Seal))
                            await Spells.MinorArcana.Cast(Core.Me);
                        break;

                    //Lunar Seal
                    case AstrologianCard.Arrow:
                    case AstrologianCard.Ewer:
                        if (DivinationSeals.Any(c => c == AstrologianSeal.Lunar_Seal))
                            await Spells.MinorArcana.Cast(Core.Me);
                        break;

                    //Celestial Seal
                    case AstrologianCard.Spear:
                    case AstrologianCard.Spire:
                        if (DivinationSeals.Any(c => c == AstrologianSeal.Celestial_Seal))
                            await Spells.MinorArcana.Cast(Core.Me);
                        break;
                }
            
            if (PartyManager.IsInParty)
                switch (Arcana)
                {
                    case AstrologianCard.Balance:
                    case AstrologianCard.Arrow:
                    case AstrologianCard.Spear:
                    case AstrologianCard.LordofCrowns:
                        return await MeleeDpsOrTank();

                    case AstrologianCard.Bole:
                    case AstrologianCard.Ewer:
                    case AstrologianCard.Spire:
                    case AstrologianCard.LadyofCrowns:
                        return await RangedDpsOrHealer();
                }

            return await Spells.Play.Cast(Core.Me);
        }

        private static async Task<bool> MeleeDpsOrTank()
        {
            foreach (var ally in Group.CastableAlliesWithin30)
            {
                if (ally.HasAnyCardAura() || ally.IsHealer() || ally.IsRangedDps() || ally.IsDead)
                    continue;

                return await Spells.Play.Cast(ally);
            }

            return false;
        }

        private static async Task<bool> RangedDpsOrHealer()
        {
            foreach (var ally in Group.CastableAlliesWithin30)
            {
                if (ally.HasAnyCardAura() || ally.IsTank() || !ally.IsRangedDps() || ally.IsDead)
                    continue;

                return await Spells.Play.Cast(ally);
            }

            return false;
        }
    }
}