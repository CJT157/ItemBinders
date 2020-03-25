using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
    public class CelestialBinder : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Binder");
            Tooltip.SetDefault("TIER 4: No more powerful bond than that of a celestial, use wisely.");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CelestialBinder");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 5);
            recipe.AddIngredient(ItemID.FragmentStardust, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddTile(null, "SoulfulBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
