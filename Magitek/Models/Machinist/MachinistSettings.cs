using System;
using System.ComponentModel;
using System.Configuration;
using Magitek.Enumerations;
using Magitek.Models.Roles;
using PropertyChanged;

namespace Magitek.Models.Machinist
{
    [AddINotifyPropertyChangedInterface]
    public class MachinistSettings : PhysicalDpsSettings, IRoutineSettings
    {
        public MachinistSettings() : base(CharacterSettingsDirectory + "/Magitek/Machinist/MachinistSettings.json") { }

        public static MachinistSettings Instance { get; set; } = new MachinistSettings();

        [Setting]
        [DefaultValue(0)]
        public int UserLatencyOffset { get; set; }

        #region SingleTarget

        [Setting]
        [DefaultValue(true)]
        public bool UseSplitShotCombo { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseDrill { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseHotAirAnchor { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseHeatBlast { get; set; }

        #endregion


    }
}