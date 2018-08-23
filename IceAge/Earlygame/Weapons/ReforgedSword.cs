using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Earlygame.Weapons
{
	public class ReforgedSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ReforgedSword");
			Tooltip.SetDefault("Reforging that Sword you revived seemed to be a good idea, but it still seems to need and up grade. Maybe the demons know.");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 01000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 12);
            recipe.AddIngredient(null, "RevivedSword");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
