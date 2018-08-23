using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Items.Weapons
{
	public class BrokenIce : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BrokenIce");
			Tooltip.SetDefault("They say this sword is broken, but it looks brand new.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 5 * 60);
            target.AddBuff(BuffID.Frozen, 5 * 60);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 45);
            recipe.AddIngredient(null, "IceBar" , 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
