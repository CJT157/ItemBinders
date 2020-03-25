using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.CrossModContent.Tools.TremorMod
{
    class IrteelAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Irteel Axe");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 34;
            item.height = 30;
            item.useTime = 15;
            item.useAnimation = 15;
            item.axe = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            Mod tremorMod = ModLoader.GetMod("Tremor");
            if (tremorMod != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(tremorMod.ItemType("SteelAxe"));
                recipe.AddIngredient(ItemID.IronAxe);
                recipe.AddIngredient(tremorMod.ItemType("SteelBar"), 5);
                recipe.AddIngredient(ItemID.IronBar, 5);
                recipe.AddTile(null, "GoldenBinder");
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
