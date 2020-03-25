using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
    public class PalladiumBinder : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Binder");
            Tooltip.SetDefault("TIER 2: Extends the reaches of binding");
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
            item.createTile = mod.TileType("PalladiumBinder");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 15);
            recipe.AddIngredient(ItemID.CrystalShard, 50);
            recipe.AddIngredient(ItemID.CrystalBall, 1);
            recipe.AddIngredient(ItemID.LightShard, 1);
            recipe.AddIngredient(ItemID.DarkShard, 1);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}