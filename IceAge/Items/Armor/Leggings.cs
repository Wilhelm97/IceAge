using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace IceAge.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class Leggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LifeLeggings");
            Tooltip.SetDefault("There is said to be a full set of The Life armour set.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 5;
            item.defense = 25; // The Defence value for this piece of armour.
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("Breastplate") && head.type == mod.ItemType("Helmet");
        }
        

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
            player.AddBuff(BuffID.RapidHealing, 400);
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.SilverGreaves, 1);
            r.AddIngredient(ItemID.PlatinumGreaves, 1);
            r.AddIngredient(ItemID.LifeCrystal, 1);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
