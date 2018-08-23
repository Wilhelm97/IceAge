using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace IceAge.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LostHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("LostBreastplate") && legs.type == mod.ItemType("LostLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Just alot of Stuff...";
			player.meleeDamage *= 1.8f;
			player.thrownDamage *= 1.8f;
			player.rangedDamage *= 1.8f;
			player.magicDamage *= 1.8f;
			player.minionDamage *= 1.8f;
            player.AddBuff(BuffID.RapidHealing, 400);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "IceBar", 30);
            recipe.AddIngredient(null, "Helmet", 1);
			recipe.AddTile(null, "IWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}