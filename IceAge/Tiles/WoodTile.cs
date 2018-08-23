using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IceAge.Tiles
{
    public class WoodTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            drop = mod.ItemType("IceWood"); // What item drops after destorying the tile
            AddMapEntry(new Color(110, 160, 190)); // Colour of Tile on Map
        }
        
    }
}
