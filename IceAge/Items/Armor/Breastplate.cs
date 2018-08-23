using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System;

namespace IceAge.Items.Armor
{
    // Added instread of AutoLoad
    [AutoloadEquip(EquipType.Body)]
    public class Breastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life ChestPlate"); // Set the name
            Tooltip.SetDefault("There is said to be a full set of The Life armour set."); // Set the tooltop
        }

        public override void SetDefaults()
        {
            /* Removed in 0.10
            item.name = "Tutorial Breastplate";
            item.toolTip = "This is the Tutorial Breastplate";
            */
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 5;
            item.defense = 30; // The Defence value for this piece of armour.
         
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("Helmet") && legs.type == mod.ItemType("Leggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
            player.AddBuff(BuffID.RapidHealing, 400);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 40;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.SilverChainmail, 1);
            r.AddIngredient(ItemID.PlatinumChainmail, 1);
            r.AddIngredient(ItemID.LifeCrystal, 1);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
