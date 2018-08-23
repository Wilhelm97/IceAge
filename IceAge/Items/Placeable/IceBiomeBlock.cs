using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Placeable
{
    public class IceBiomeBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Biome Block");
        }

        public override void SetDefaults()
        {
            item.width = 12; 
            item.height = 12;
            item.useTime = 20; 
            item.useAnimation = 20;
            item.useStyle = 1; 
            item.value = 50; 
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true; 
            item.consumable = true; 
            item.createTile = mod.TileType("IceBiomeTile");
            item.maxStack = 999; 
        }
    }
}
