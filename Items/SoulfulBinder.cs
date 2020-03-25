using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
    public class SoulfulBinder : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soulful Binder");
            Tooltip.SetDefault("TIER 3: Uses the power of the soul to forge new bonds");
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
            item.createTile = mod.TileType("SoulfulBinder");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFlight, 5);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddTile(null, "CobaltBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

