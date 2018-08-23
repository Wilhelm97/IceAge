using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Accessories.Hooks
{
    public class IceHook : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RubyHook);
            item.shootSpeed = 18f;
            item.shoot = mod.ProjectileType("IceHook");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBrick, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
