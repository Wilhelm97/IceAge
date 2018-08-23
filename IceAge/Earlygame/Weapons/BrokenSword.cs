using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Earlygame.Weapons
{
	public class BrokenSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BrokenSword");
			Tooltip.SetDefault("You found this Sword under a tree. It seems like you should Revive it some how.");
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 7);
            recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
