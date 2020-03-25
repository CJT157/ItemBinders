using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
    public class SuperRestorationPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Restoration Potion");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.healLife = 240;
            item.healMana = 240;
            item.useAnimation = 7;
            item.useStyle = 2;
            item.value = 5000;
            item.useTurn = true;
            item.consumable = true;
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.potion = true;
            item.maxStack = 99;
            item.buffType = BuffID.PotionSickness;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuperHealingPotion, 2);
            recipe.AddIngredient(ItemID.SuperManaPotion, 2);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddIngredient(ItemID.PinkGel, 1);
            recipe.AddTile(null, "CelestialBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
