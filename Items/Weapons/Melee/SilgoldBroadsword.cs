﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class SilgoldBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silgold Broadsword");
            Tooltip.SetDefault("With the combined effort of Gold and Silver");
        }
        public override void SetDefaults()
        {
            item.damage = 24;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBroadsword, 1);
            recipe.AddIngredient(ItemID.GoldBroadsword, 1);
            recipe.AddIngredient(ItemID.SilverBar, 10);
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
