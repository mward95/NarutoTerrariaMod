using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace NarutoTerraria.Items.Potions
{
    public class Poison : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Poison");
            Tooltip.SetDefault("Will Kill U for 5 Seconds");
        }

        public override void SetDefaults()
        {
            Item.height = 50;
            Item.width = 50;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useTime = 15;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.rare = 4;
            Item.value = 100;
            Item.UseSound = SoundID.Item3;
            Item.buffType = BuffID.Poisoned;
            //Time in ticks not seconds 60 ticks = 1 second
            Item.buffTime = 300;
        }
    }
}
