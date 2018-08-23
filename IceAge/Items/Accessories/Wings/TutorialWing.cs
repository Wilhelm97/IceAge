using Terraria;
using Terraria.ID; 
using Terraria.ModLoader;

namespace IceAge.Items.Accessories.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class TutorialWing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SNOW WINGS");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 150;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.9f;
            ascentWhenRising = 0.1f;
            maxCanAscendMultiplier = 1.2f;
            maxAscentMultiplier = 3.5f;
            constantAscend = 0.125f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 2.75f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceFeather, 2);
            recipe.AddIngredient(ItemID.SoulofFlight, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }


}
