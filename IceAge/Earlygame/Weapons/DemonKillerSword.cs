using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Earlygame.Weapons
{
	public class DemonKillerSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DemonKillerSword");
			Tooltip.SetDefault("Devil seems to be watching... He doesn't like lack of Demons..");
		}
		public override void SetDefaults()
		{
			item.damage = 31;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 01500;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("AnimatedPierce");
            item.shootSpeed = 16f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 16);
            recipe.AddIngredient(null, "ReforgedSword");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
