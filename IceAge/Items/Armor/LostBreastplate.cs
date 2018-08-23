using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class LostBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Example Breastplate");
			Tooltip.SetDefault("This is a modded body armor."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
            player.AddBuff(BuffID.RapidHealing, 400);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceBar", 60);
            recipe.AddIngredient(null, "Breastplate" , 1);
			recipe.AddTile(null, "IWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}