using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System;

namespace IceAge.Items.EarlyGame.Armor
{
    // Added instread of AutoLoad
    [AutoloadEquip(EquipType.Body)]
    public class WarriorBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Warrior Chestplate"); 
            Tooltip.SetDefault("Increases maxium health by 20" +
                "immune to debuff OnFire"); 
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 6; 
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("WarriorHelmet") && legs.type == mod.ItemType("WarriorLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statLifeMax2 += 20;
            
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Wood, 20);
            r.AddIngredient(ItemID.IronBar, 30);
            r.AddTile(TileID.Anvils); 
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
