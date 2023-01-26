using Terraria;
using Terraria.ID;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using NarutoTerraria.Items.Material;


namespace NarutoTerraria.Items.Changes
{
    public class NPCLOOT : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {

            if (Main.rand.NextBool(100) && npc.type == NPCID.GreenSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ChakraEssence>(), 2, 1, 1));
            }
        
            //if (npc.netID == NPCID.GreenSlime)
            //{
               //(ItemDropRule.Common(ModContent.ItemType<ChakraEssence>(), 2, 1, 1));
            //}                
        }
    }
}