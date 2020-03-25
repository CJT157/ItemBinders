using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class BladeOfTheUndead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blade of the Undead");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = true;
            item.width = 50;
            item.height = 46;
            item.useTime = 22;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = 2000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ZombieArm, 1);
            recipe.AddIngredient(ItemID.BoneSword, 1);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.Shackle, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
