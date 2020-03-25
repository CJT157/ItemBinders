using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Ranged
{
    public class CopironBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copiron Bow");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.noMelee = true;
            item.ranged = true;
            item.width = 16;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 0;
            item.rare = 2;
            item.UseSound = SoundID.Item10;
            item.autoReuse = false;
            item.shootSpeed = 9f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBow, 1);
            recipe.AddIngredient(ItemID.IronBow, 1);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
