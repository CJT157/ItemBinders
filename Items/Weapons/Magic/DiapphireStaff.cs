using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Magic
{
    public class DiapphireStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diapphire Staff");
            Tooltip.SetDefault("With the combined effort of Diamond and Sapphire");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.magic = true;
            item.mana = 12;
            item.width = 42;
            item.height = 40;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = ProjectileID.DiamondBolt;
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DiamondStaff, 1);
            recipe.AddIngredient(ItemID.SapphireStaff, 1);
            recipe.AddIngredient(ItemID.Diamond, 5);
            recipe.AddIngredient(ItemID.Sapphire, 5);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
