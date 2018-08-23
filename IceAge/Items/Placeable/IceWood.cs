using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Placeable
{
    public class IceWood : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Wood");
        }


        public override void SetDefaults()
        {
            
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 15; // Speed before reuse
            item.useAnimation = 10; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("WoodTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "IceWoodWall", 4);
            r.SetResult(this); // 4 = number of this item you get.
            r.AddRecipe();
        }

        
    }
}
