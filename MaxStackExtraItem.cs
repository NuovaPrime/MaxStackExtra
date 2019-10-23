using Terraria;
using Terraria.ModLoader;
using System;
using Terraria.ID;

namespace MaxStackExtra
{
    public class MaxStackExtraItem : GlobalItem
    {

        public override bool CloneNewInstances => true;

        public override void SetDefaults(Item item)
        {
            if (!(item.type == ItemID.CopperCoin || item.type == ItemID.SilverCoin || item.type == ItemID.GoldCoin || item.type == ItemID.PlatinumCoin))
            {
                if (item.maxStack > 1)
                {
                    if (item.createTile > 0)
                        item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().TileStackValue;
                    else
                        item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().ItemStackValue;
                }
                else if (item.accessory || item.defense > 0)
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().EquipStackValue;
                else if (item.damage > 0)
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().WeaponStackValue;
                else
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().SpecialStackValue;
            }
            else
                base.SetDefaults(item);
        }
    }
}
