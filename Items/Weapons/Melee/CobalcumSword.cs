﻿using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class CobalcumSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalcum Sword");
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.melee = true;
            item.width = 44;
            item.height = 44;
            item.useTime = 23;
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
            recipe.AddIngredient(ItemID.CobaltSword, 1);
            recipe.AddIngredient(ItemID.OrichalcumSword, 1);
            recipe.AddIngredient(ItemID.CobaltBar, 10);
            recipe.AddIngredient(ItemID.OrichalcumBar, 10);
            recipe.AddTile(null, "CobaltBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

