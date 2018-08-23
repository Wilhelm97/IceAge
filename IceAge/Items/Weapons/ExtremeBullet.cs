using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Items.Weapons
{
	public class ExtremeBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bang Bang");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("ExampleBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(null, "IceBar", 1);
			recipe.AddTile(ItemID.WorkBench);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
