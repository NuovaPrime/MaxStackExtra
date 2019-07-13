using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace MaxStackExtra
{
    public class MaxStackExtraConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Maximum stack for items")]
        [Tooltip("Configure the maximum stack size for items.")]
        [ReloadRequired]
        [Range(0, int.MaxValue)]
        [DefaultValue(9999)]
        public int ItemStackValue { get; set; }

        [Label("Maximum stack for tiles")]
        [Tooltip("Configure the maximum stack size for tiles.")]
        [ReloadRequired]
        [Range(0, int.MaxValue)]
        [DefaultValue(9999)]
        public int TileStackValue { get; set; }

        [Header("[c/ff0000:WARNING: May break prefixes and internal item data.]")]
        [Label("Maximum stack for weapons")]
        [Tooltip("Configure the maximum stack size for weapons.")]
        [ReloadRequired]
        [Range(0, int.MaxValue)]
        [DefaultValue(1)]
        public int WeaponStackValue { get; set; }

        [Label("Maximum stack for equippables")]
        [Tooltip("Configure the maximum stack size for armor and accessories.")]
        [ReloadRequired]
        [Range(0, int.MaxValue)]
        [DefaultValue(1)]
        public int EquipStackValue { get; set; }
    }
}
