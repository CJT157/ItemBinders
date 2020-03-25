using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class Light_sButcherer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Light's Butcherer");
            Tooltip.SetDefault("'Two combined evils'");
        }

        public override void SetDefaults()
        {
            item.damage = 38;
            item.melee = true;
            item.width = 48;
            item.height = 54;
            item.useTime = 25;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddIngredient(ItemID.BloodButcherer, 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddTile(null, "GoldenBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}