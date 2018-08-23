using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Tools
{
    public class Allknowing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Allknowing Pickaxe");
            Tooltip.SetDefault("Who..... Did this Pickaxe just say something?");
        }

        public override void SetDefaults()
        {
            
            item.damage = 40; // Base Damage of the Weapon
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            
            item.useTime = 6; // Speed before reuse
            item.useAnimation = 6; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 1.5f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 15500; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 4; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.pick = 115; // Pick Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.ReaverShark, 1);
            recipe.AddIngredient(null, "WillsPickAxe", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
