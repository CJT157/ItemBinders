using thespatiummod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Ammo
{
    class BulletThatKilledCorruption : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bullet That Killed All");
            Tooltip.SetDefault("Inflicts many debuffs\n" +
                "Endless use\n" +
                "'Also works well on the past, present, or future!'");
        }

        public override void SetDefaults()
        {
            item.damage = 24;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = false;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 10;
            item.shoot = mod.ProjectileType("TheBulletThatKilledCorruption");
            item.shootSpeed = 16f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MoonlordBullet, 80);
            recipe.AddIngredient(ItemID.ChlorophyteBullet, 80);
            recipe.AddIngredient(null, "CursedVelocityBullet", 80);
            recipe.AddIngredient(null, "HighTechExplosiveBullet", 80);
            recipe.AddIngredient(null, "SadPartyBullet", 80);
            recipe.AddIngredient(null, "ShinyCrystalBullet", 80);
            recipe.AddIngredient(null, "PolishedMeteorShot", 80);
            recipe.AddIngredient(null, "PolishedMusketBall", 80);
            recipe.AddIngredient(ItemID.MeteorShot, 80);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddTile(null, "CelestialBinder");
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
