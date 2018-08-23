using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IceAge.Items.Weapons
{
	public class WinterDualblade : ModItem
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("WinterDualBlade");
            Tooltip.SetDefault("It beloned to a giant of the ages, hence it being bigger then yuor body and hitting harder then anything else in the world!.");
        }

        public override void SetDefaults()
		{
			
			item.damage = 300; // Base Damage of the Weapon
			item.melee = true; // Weapon Class Type
			item.width = 60; // Hitbox Width
			item.height = 60; // Hitbox Height
			item.useTime = 20; // Speed before reuse
			item.useAnimation = 20; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword 
			item.knockBack = 4.5f; // Weapon Knockbase: Higher means greater "launch" distance
			item.value = 6500000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
			item.rare = -11; // Item Tier 
			item.UseSound = SoundID.Item1; // Sound effect of item on use 
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false 
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60);
            player.AddBuff(BuffID.Regeneration, 5 * 60);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.MythrilBar, 20); // Ingredient for crafing
            recipe.AddIngredient(ItemID.FallenStar, 20);
            recipe.AddIngredient(ItemID.MeteoriteBar, 40);
            recipe.AddIngredient(null, "BrokenIce", 1);
            recipe.AddTile(TileID.MythrilAnvil); // Tile / Workstation
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

   
    }
}
