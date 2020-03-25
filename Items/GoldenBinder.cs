using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items
{
	public class GoldenBinder : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Binder");
			Tooltip.SetDefault("TIER 1: To bind together forgotten pieces");
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
            item.createTile = mod.TileType("GoldenBinder");
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.ManaCrystal, 1);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.Diamond, 5);
            recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
