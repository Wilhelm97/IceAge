using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Items.Weapons
{
	public class KatiesLostStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("The Designer Some how lost her Staff.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 120;
			item.magic = true;
			item.mana = 15;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("AnimatedPierce");
			item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LivingWoodWand);
            recipe.AddIngredient(ItemID.Amber, 1);
			recipe.AddTile(ItemID.WorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}