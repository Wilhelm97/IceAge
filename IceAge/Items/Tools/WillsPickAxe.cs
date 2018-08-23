using Terraria.ID;
using Terraria; 
using Terraria.ModLoader;

namespace IceAge.Items.Tools
    {
        public class WillsPickAxe : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Wills Over powered PickAxe");
                Tooltip.SetDefault("See ya later dirt.");
            }
            public override void SetDefaults()
            {
                item.damage = 150;
                item.melee = true;
                item.width = 40;
                item.height = 40;
                item.channel = true;
                item.useTime = 4;
                item.useAnimation = 20;
                item.noMelee = false;
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
                item.pick = 300;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MeteoriteBar, 200);
                recipe.AddIngredient(ItemID.StardustPickaxe, 1);
                recipe.AddIngredient(ItemID.FallenStar, 50);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

