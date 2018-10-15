using Terraria;
using Terraria.ModLoader;
using System;

namespace MaxStackExtra
{
    public class MaxStackExtraItem : GlobalItem
    {
        
        public override bool CloneNewInstances
        {
            get
            {
                return true;
            }
        }
        public override void SetDefaults(Item item)
        {
            item.maxStack = 9999;
            item.uniqueStack = false;
        }
        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {

            item.maxStack = 9999;
            if(item.accessory)
            {
                item.maxStack = 9999;
            }
        }
    }
}