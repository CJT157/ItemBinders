using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class CopironBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copiron Broadsword");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.width = 32;
            item.height = 32;
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
            recipe.AddIngredient(ItemID.CopperBroadsword, 1);
            recipe.AddIngredient(ItemID.IronBroadsword, 1);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
