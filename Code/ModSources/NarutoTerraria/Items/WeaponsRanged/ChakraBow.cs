using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NarutoTerraria.Items.Material;


namespace NarutoTerraria.Items.WeaponsRanged
{
    public class ChakraBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chakra Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Shoots Arrows");
            
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.value = 10000;
            Item.rare = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = ItemUseStyleID.Shoot;            
           //Item.scale = 2f; Doubles Item Size
            Item.width = 40;
            Item.height = 40;
            //Generally useTime and useAnimation should be the same
            Item.useTime = 20;
            Item.useAnimation = 20;            
            Item.knockBack = 6;

            //Item.shoot = ProjectileID.Flames;
            Item.ammo = AmmoID.Arrow;
            //Friendly ensures projectile cant hurt player
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 5f;
            Item.useAmmo = AmmoID.Arrow;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item1;
            
        }        

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<ChakraEssence>(), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}