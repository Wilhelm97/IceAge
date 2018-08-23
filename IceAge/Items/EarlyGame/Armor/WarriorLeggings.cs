using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace IceAge.Items.EarlyGame.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class WarriorLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Warrior Leggings");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 4; 
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("WarriorBreastplate") && head.type == mod.ItemType("WarriorHelmet");
        }
        

        public override void UpdateArmorSet(Player player)
        {
            player.statDefense += 2;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Wood, 15);
            r.AddIngredient(ItemID.IronBar, 25);
            r.AddTile(TileID.Anvils); 
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
