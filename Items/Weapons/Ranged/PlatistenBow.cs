using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Ranged
{
    public class PlatistenBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plastisten Bow");
        }

        public override void SetDefaults()
        {
            item.damage = 23;
            item.noMelee = true;
            item.ranged = true;
            item.width = 18;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 2;
            item.rare = 3;
            item.UseSound = SoundID.Item10;
            item.autoReuse = false;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBow, 1);
            recipe.AddIngredient(ItemID.PlatinumBow, 1);
            recipe.AddIngredient(ItemID.TungstenBar, 10);
            recipe.AddIngredient(ItemID.PlatinumBar, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
