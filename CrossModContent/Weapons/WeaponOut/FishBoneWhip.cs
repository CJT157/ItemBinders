
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.CrossModContent.Weapons.WeaponOut

{
    public class FishBoneWhip : ModItem

    {
        private bool increaseDamage;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fishbone Whip");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 44;
            item.useStyle = 5;
            item.useAnimation = 22;
            item.useTime = 22;
            item.UseSound = SoundID.Item19;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.melee = true;
            item.damage = 28;
            item.crit = 60;
            item.knockBack = 4f;
            item.shoot = mod.ProjectileType("FishBoneWhip");
            item.shootSpeed = 9f; //projectile length
            item.rare = 2;
            item.value = Item.sellPrice(0, 1, 0, 0);
        }

        public override void AddRecipes()
        {
            Mod weaponOut = ModLoader.GetMod("WeaponOut");
            if (weaponOut != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(weaponOut.ItemType("EelWhip"));
                recipe.AddIngredient(weaponOut.ItemType("BoneWhip"));
                recipe.AddIngredient(ItemID.Bone, 50);
                recipe.AddTile(null, "GoldenBinder");
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {

            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0,

                Main.rand.Next(-200, 200) * 0.001f * player.gravDir);

            return false;

        }

    }

}