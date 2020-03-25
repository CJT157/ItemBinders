using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Items.Weapons.Melee
{
    public class Excalanium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Excalanium");
        }

        public override void SetDefaults()
        {
            item.damage = 78;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 26;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Excalibur, 1);
            recipe.AddIngredient(ItemID.AdamantiteSword, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.AdamantiteBar, 10);
            recipe.AddTile(null, "SoulfulBinder");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}