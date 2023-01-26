﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NarutoTerraria.Items.Weapons
{
    public class OrochimaruKisanagi : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("OrochimaruKisanagi"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Orochimaru's Kisanagi Sword");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 6;
            //Item.shoot = ProjectileID.Flames;
            Item.shootSpeed = 5f;
            Item.value = 10000;
            Item.rare = 8;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}