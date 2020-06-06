using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod.Projectiles
{
	public class Naturang : ModProjectile
	{
        public override void SetStaticDefaults() => DisplayName.SetDefault("Naturang");

        public override void SetDefaults()
		{
            projectile.CloneDefaults(113);
            aiType = 113;
        }
	}
}
