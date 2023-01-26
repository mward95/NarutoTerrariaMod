using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NarutoTerraria.Items.WeaponsJutsu
{
    public class Amaterasu : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Amaterasu"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Amaterasu");
        }

        public override void SetDefaults()
        {
            Item.damage = 30;
            Item.value = 10000;
            Item.rare = 8;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.DamageType = DamageClass.Magic;
            Item.mana = 6;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            
            Item.knockBack = 3;            
            Item.UseSound = SoundID.Item34;
            Item.autoReuse = true;
            Item.noMelee = true;
            //Item.useAmmo = AmmoID.Gel;
            Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 8f;

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