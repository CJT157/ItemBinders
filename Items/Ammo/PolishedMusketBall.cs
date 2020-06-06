using thespatiummod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Ammo
{
    class PolishedMusketBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Polished Musket Ball");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 3f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("PolishedMusketBall");
            item.shootSpeed = 16f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBullet, 50);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }
}
