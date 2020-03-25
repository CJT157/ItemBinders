using thespatiummod.Projectiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace thespatiummod.Items.Weapons.Melee
{
    public class FormatG : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Format G");
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 17;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.width = 30;
            item.height = 26;
            item.noUseGraphic = true;
            item.UseSound = SoundID.Item1;
            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("FormatG");
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = 36;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.rare = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FormatC);
            recipe.AddIngredient(ItemID.Gradient);
            recipe.AddIngredient(ItemID.WhiteString);
            recipe.AddTile(null, "CobaltBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
