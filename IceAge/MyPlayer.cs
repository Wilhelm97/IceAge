using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace IceAge
{
    public class MyPlayer : ModPlayer
    {
        public bool tutorialPet = false;
        public bool summonSpiritMinion = false;

        public bool zoneBiome = false;

        public override void ResetEffects()
        {
            tutorialPet = false;
            summonSpiritMinion = false;

        }

        public override void SetupStartInventory(IList<Item> items)
        {
            items.Clear();

            Item item = new Item();
            item.SetDefaults(ItemID.Wood);
            item.stack = 25;
            items.Add(item);
            Item i = new Item();
            i.SetDefaults(mod.ItemType("BrokenSword"));
            i.stack = 1;
            items.Add(i);
            Item o = new Item();
            o.SetDefaults(ItemID.IronPickaxe);
            o.stack = 1;
            items.Add(o);
            Item p = new Item();
            p.SetDefaults(ItemID.IronAxe);
            p.stack = 1;
            items.Add(p);
            Item s = new Item();
            s.SetDefaults(ItemID.ReinforcedFishingPole);
            s.stack = 1;
            items.Add(s);
            Item sd = new Item();
            sd.SetDefaults(ItemID.Grasshopper);
            sd.stack = 25;
            items.Add(sd);
            Item g = new Item();
            g.SetDefaults(ItemID.Gel);
            g.stack = 15;
            items.Add(g);

        }

        public override void UpdateBiomes()
        {
            zoneBiome = (ModdedWorld.biomeTiles > 50); // Chance 50 to the minimum number of tiles that need to be counted before it is classed as a biome
        }

        public override bool CustomBiomesMatch(Player other)
        {
            MyPlayer otherPlayer = other.GetModPlayer<MyPlayer>(mod); // This will get other players using the TutorialPlayerClass
            return zoneBiome == otherPlayer.zoneBiome; // This will return true or false depending on other player
        }

        public override void CopyCustomBiomesTo(Player other)
        {
           MyPlayer otherPlayer = other.GetModPlayer<MyPlayer>(mod);
            otherPlayer.zoneBiome = zoneBiome; // This will set other player's biome to the same as thisPlayer
        }

        public override void SendCustomBiomes(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = zoneBiome;
            writer.Write(flags);
        }

        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            zoneBiome = flags[0];
        }

        public override void UpdateBiomeVisuals()
        {
            
        }

        public override Texture2D GetMapBackgroundImage()
        {
            return null;
        }


    }
}
