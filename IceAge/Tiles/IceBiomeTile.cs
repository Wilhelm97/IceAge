using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IceAge.Tiles
{
    public class IceBiomeTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            AddMapEntry(new Color(255, 255, 0));
            drop = mod.ItemType("IceBiomeBlock"); // What item drops after destorying the tile
        }
    }
}
