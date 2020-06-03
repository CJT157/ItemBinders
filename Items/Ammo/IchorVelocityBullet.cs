using thespatiummod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Ammo
{
    class IchorVelocityBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ichor Velocity Bullet");
            Tooltip.SetDefault("'Not to be confused with Ichor Velocity Bullets'");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 4;
            item.shoot = mod.ProjectileType("IchorVelocityBullet");
            item.shootSpeed = 16f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IchorBullet, 50);
            recipe.AddIngredient(ItemID.HighVelocityBullet, 50);
            recipe.AddTile(null, "SoulfulBinder");
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }
}
