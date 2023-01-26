using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace NarutoTerraria.Items.Accessories
{
    public class DefenseScroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Defense Scroll");
            Tooltip.SetDefault("Adds 5 Defense");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.rare = 4;
            Item.value = 100;
            Item.width = 20;
            Item.height = 20;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 5;
            hideVisual = true; //hides from showing up on player body, could potentially remove for cool looking accessories
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
