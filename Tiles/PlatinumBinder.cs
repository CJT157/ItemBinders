using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace thespatiummod.Tiles
{
    public class PlatinumBinder : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 18 };
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            adjTiles = new int[] { mod.TileType("GoldenBinder") };
            name.SetDefault("Platinum Binder");
            AddMapEntry(new Color(100, 112, 149), name);
            disableSmartCursor = true;
            drop = mod.ItemType("PlatinumBinder");
        }
    }
}