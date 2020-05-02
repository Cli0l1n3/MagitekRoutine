﻿using System.Collections.Generic;

namespace Magitek.Utilities
{
    internal static class Auras
    {
        public const int
            Raise = 148,
            BattleVoice = 141,
            Swiftcast = 167,
            Aero = 143,
            Aero2 = 144,
            Medica2 = 150,
            Freecure = 155,
            Regen = 158,
            Regen2 = 627,
            DivineSeal = 159,
            ShroudOfSaints = 154,
            PresenceOfMind = 157,
            Bio2 = 189,
            Miasma = 180,
            Bio = 179,
            Aetherflow = 304,
            AetherialAttunement = 807,
            EmergencyTactics = 792,
            Dissipation = 791,
            Galvanize = 297,
            Catalyze = 1918,
            Combust = 838,
            Combust2 = 843,
            Combust3 = 1881,
            EnhancedBenefic2 = 815,
            AspectedBenefic = 835,
            AspectedHelios = 836,
            DiurnalSect = 839,
            NocturnalSect = 840,
            EyesOpen = 1252,
            NocturnalField = 837,
            SynastrySource = 845,
            LeyLines = 737,
            SynastryDestination = 846,
            Lightspeed = 841,
            WheelOfFortune = 956,
            DiurnalIntersection = 1888,
            Horoscope = 1890,
            HoroscopeHelios = 1891,
            TheBalance = 829,
            TheBalance2 = 1338,
            TheBalance3 = 1882,
            TheBole = 830,
            TheBole2 = 1339,
            TheBole3 = 1883,
            TheArrow = 831,
            TheArrow2 = 1884,
            TheSpear = 832,
            TheSpear2 = 1885,
            TheEwer = 833,
            TheEwer2 = 1340,
            TheEwer3 = 1886,
            TheSpire = 834,
            TheSpire2 = 1341,
            TheSpire3 = 1887,
            LordofCrowns = 1451,
            LordofCrowns2 = 1876,
            LadyofCrowns = 1452,
            LadyofCrowns2 = 1877,
            SleeveDraw = 1926,
            Disembowel = 1914,
            SharperFangandClaw = 802,
            EnhancedWheelingThrust = 803,
            RightEye = 1453,
            LeftEye = 1454,
            Medicated = 49,
            StraighterShot = 122,
            VenomousBite = 124,
            RagingStrikes = 125,
            Barrage = 128,
            Windbite = 129,
            Foresight = 83,
            HallowedGround = 82,
            IronWill = 79,
            Rampart = 1191,
            Sentinel = 74,
            GoringBlade = 725,
            Shadowskin = 740,
            BloodWeapon = 742,
            Grit = 743,
            DarkDance = 744,
            DarkMind = 746,
            ShadowWall = 747,
            SaltedEarth = 749,
            Darkside = 751,
            Reprisal = 753,
            LivingDead = 810,
            DragonKick = 98,
            TwinSnakes = 101,
            FistsofFire = 103,
            FistsofEarth = 104,
            FistsofWind = 105,
            OpoOpoForm = 107,
            RaptorForm = 108,
            CoeurlForm = 109,
            PerfectBalance = 110,
            Demolish = 246,
            Brotherhood = 1185,
            MeikyoShisui = 1233,
            Jinpu = 1298,
            Shifu = 1299,
            Requiescat = 1368,
            Higanbana = 1228,
            EnhancedEnpi = 1236,
            ThinAir = 1217,
            CausticBite = 1200,
            StormBite = 1201,
            Bio3 = 1214,
            Miasma3 = 1215,
            Confession = 1219,
            VerfireReady = 1234,
            VerstoneReady = 1235,
            Dualcast = 1249,
            Manafication = 1971,
            StormsEye = 90,
            Deliverance = 729,
            Defiance = 91,
            InnerRelease = 1177,
            RawIntuition = 735,
            Vengeance = 89,
            Holmgang = 409,
            Suiton = 507,
            ShadowFang = 508,
            Duality = 790,
            TenChiJin = 1186,
            Thunder = 161,
            Thunder2 = 162,
            Thunder3 = 163,
            FireStarter = 165,
            ThunderCloud = 164,
            Sharpcast = 867,
            Thunder4 = 1210,
            FeyUnion = 1222,
            FeyUnion2 = 1223,
            SeraphicVeil = 1917,
            DiveReady = 1243,
            BlackestNight = 1178,
            Exogitation = 1220,
            DivineBenison = 1218,
            DivineBenison2 = 1404,
            Peloton = 1199,
            Kaiten = 1229,
            Triplecast = 1211,
            LucidDreaming = 1204,
            EarthlyDominance = 1224,
            GiantDominance = 1248,
            HotShot = 855,
            Wildfire = 861,
            Flamethrower = 1205,
            TrueNorth = 1250,
            Doton = 501,
            FurtherRuin = 1212,
            MountedPvp = 1420,
            RegenPvp = 1330,
            DivineBenisonPvp = 1404,
            MagicResistance = 942,
            VulnerabilityTrickAttack = 638,
            FlourshingCascade = 1814,
            FlourshingFountain = 1815,
            FlourshingWindmill = 1816,
            FlourshingShower = 1817,
            StandardStep = 1818,
            TechnicalStep = 1819,
            FlourishingFanDance = 1820,
            StandardFinish = 1821,
            RaidenReady = 1863,
            TechnicalFinish = 1822,
            ClosedPosition = 1823,
            DancePartner = 1824,
            Devilment = 1825,
            ShieldSamba = 1826,
            SwordOath = 1902,
            FightOrFight = 76,
            Ruination = 1291,
            Dia = 1871,
            Biolysis = 1895,
            Bioblaster = 1866,
            HellishConduit = 1867,
            Troubadour = 1934,
            WildfireBuff = 1946,
            Mudra = 496,
            Recitation = 1896,
            LeadenFist = 1861,
            Kassatsu = 497,
            AssassinateReady = 1955,
            Camouflage = 1832,
            Nebula = 1834,
            Aurora = 1835,
            Superbolide = 1836,
            HeartofLight = 1839,
            HeartofStone = 1840,
            NoMercy = 1831,
            ReadytoRip = 1842,
            ReadytoTear = 1843,
            ReadytoGouge = 1844,
            Reassembled = 851,
            NascentChaos = 1897,
            RoyalGuard = 1833,
            DarkMissionary = 1894,
            Delirium = 1972,
            PassageOfArms = 1175,
            RiddleOfEarth = 2008,
            Anatman = 1862,
            EverlastingFlight = 2030,
            Acceleration = 1238,
            Divination = 2034,
            Embolden = 2282,
            MeditationSAM = 2176,
            OffGuard = 1717,
            Bleeding = 1714,
            Boost = 1716;

        private const int
            Invincibility0 = 981,
            Invincibility1 = 969,
            Invincibility2 = 895,
            Invincibility3 = 776,
            Invincibility4 = 775,
            Invincibility5 = 671,
            Invincibility6 = 656,
            Invincibility7 = 529,
            Invincibility8 = 325;

        public const int

        #region PVP Specific

            PvpSynastrySource = 1336,
            PvpSynastryDestination = 1337,
            Abridged = 1335,
            PvpLightspeed = 1403;

        #endregion

        public static readonly List<uint> Invincibility = new List<uint>
        {
            Invincibility0,
            Invincibility1,
            Invincibility2,
            Invincibility3,
            Invincibility4,
            Invincibility5,
            Invincibility6,
            Invincibility7,
            Invincibility8
        };
    }
}
