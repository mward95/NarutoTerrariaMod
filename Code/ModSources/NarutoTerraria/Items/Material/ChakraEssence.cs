using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace NarutoTerraria.Items.Material
{
    public class ChakraEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chakra Essence");
            Tooltip.SetDefault("Chakra Energy");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 100;
            Item.rare = 4;
            Item.value = 100;
            Item.width = 40;
            Item.height = 40;

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
