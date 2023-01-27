﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace NarutoTerraria.Items.Weapons
{
    public class ExecutionerBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ExecutionerBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("ExecutionerBlade");
        }

        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 50;
            Item.useAnimation = 50;
            Item.useStyle = 1;
            Item.knockBack = 6;
            //Item.shoot = ProjectileID.Flames;
            //Item.shootSpeed = 5f;
            Item.value = 10000;
            Item.rare = 8;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override bool? UseItem(Player player) //Edit Dust ID for a different Effect
        {
            if (Main.rand.Next(3) == 0)
                Dust.NewDust(new Vector2(player.position.X, player.position.Y), player.Hitbox.Width, player.Hitbox.Height, DustID.GrassBlades);
            return base.UseItem(player);
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