using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IceAge.Tiles
{
    public class OreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = true; // Emits Light
            
            drop = mod.ItemType("IceOre"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("IceOre");
            AddMapEntry(new Color(187, 78, 181), name); // Colour of Tile on Map
            minPick = 40; // What power pick minimum is needed to mine this block.
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.75f;
            g = 0.25f;
            b = 0.5f;
        }
    }
}
