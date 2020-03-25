using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
    public class GreaterRestorationPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greater Restoration Potion");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.healLife = 120;
            item.healMana = 120;
            item.useAnimation = 7;
            item.useStyle = 2;
            item.value = 2000;
            item.useTurn = true;
            item.consumable = true;
            item.rare = 2;
            item.UseSound = SoundID.Item3;
            item.potion = true;
            item.maxStack = 99;
            item.buffType = BuffID.PotionSickness;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 2);
            recipe.AddIngredient(ItemID.GreaterManaPotion, 2);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddIngredient(ItemID.PinkGel, 1);
            recipe.AddTile(null, "SoulfulBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
