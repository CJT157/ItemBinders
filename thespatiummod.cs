using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace thespatiummod
{
	class thespatiummod : Mod
	{
		public thespatiummod()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
			};
		}
    }
}
