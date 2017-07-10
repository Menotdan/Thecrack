using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public bool customdebuff = false;
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(3) == 0)   //item rarity
            {
                if (npc.type == NPCID.TheDestroyer)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheDestroyer"));
                }

                if (npc.type == NPCID.Spazmatism)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LieSpawner"));
                }
            }
        }
    }
}