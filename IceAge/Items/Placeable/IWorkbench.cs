using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Placeable
{
    public class IWorkbench : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("IceWorkbench");
        }


        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 14;
            item.useAnimation = 17;
            item.useTurn = true;
            item.autoReuse = true;
            item.useStyle = 1;
            item.createTile = mod.TileType("IWorkbench");
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "IceBar" ,10); 
            r.SetResult(this); // 4 = number of this item you get.
            r.AddRecipe();
        }

    }
}
