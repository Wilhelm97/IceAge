using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Earlygame.Weapons
{
	public class RevivedSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("RevivedSword");
			Tooltip.SetDefault("You have taken that BrokeSword and made it better, but it seems like the Sword can be better");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 0025;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 7);
            recipe.AddIngredient(null, "BrokenSword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
