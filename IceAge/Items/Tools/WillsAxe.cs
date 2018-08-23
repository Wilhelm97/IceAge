using Terraria.ID;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;

namespace IceAge.Items.Tools
{
	public class WillsAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wills Over powered Axe");
			Tooltip.SetDefault("Wait...Where did that tree go?? Super OP but can't hit an enemy .");
		}
		public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.channel = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noMelee = true;
            NewMethod();
            NewMethod1();
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        private void NewMethod1()
        {
            item.tileBoost++;
        }

        private void NewMethod()
        {
            item.axe = 165;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 100);
            recipe.AddIngredient(ItemID.StardustAxe, 1);
            recipe.AddIngredient(ItemID.FallenStar, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
