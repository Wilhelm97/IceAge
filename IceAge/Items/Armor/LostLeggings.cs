using Terraria;
using Terraria.ModLoader;

namespace IceAge.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class LostLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded leg armor."
				+ "\n150% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceBar", 45);
            recipe.AddIngredient(null, "Leggings", 1);
			recipe.AddTile(null, "IWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}