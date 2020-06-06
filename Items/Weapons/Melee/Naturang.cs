using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class Naturang : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Naturang");
            Tooltip.SetDefault("Throws three at once\n" +
                "'Mother Nature said she wantred her boomerangs back'");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.thrown = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 5;
            item.shootSpeed = 16f;
            item.useAnimation = 14;
            item.useStyle = 1;
            item.knockBack = 3.5f;
            item.shoot = mod.ProjectileType("Naturang");
            item.value = 27600;
            item.rare = 4;
            item.noUseGraphic = false;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBoomerang, 1);
            recipe.AddIngredient(ItemID.Shroomerang, 1);
            recipe.AddIngredient(ItemID.Flamarang, 1);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
