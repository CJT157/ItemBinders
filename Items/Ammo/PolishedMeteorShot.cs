using thespatiummod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Ammo
{
    class PolishedMeteorShot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Polished Meteor Shot");
            Tooltip.SetDefault("");
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
            item.rare = 2;
            item.shoot = mod.ProjectileType("PolishedMeteorShot");
            item.shootSpeed = 16f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBullet, 50);
            recipe.AddIngredient(ItemID.MeteorShot, 50);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }
}
