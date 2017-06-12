using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs
{
    public class NPCsGLOBAL : GlobalNPC
    {
        public override void ResetEffects(NPC npc)
        {
            npc.GetGlobalNPC<ModGlobalNPC>(mod).customdebuff = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.GetGlobalNPC<ModGlobalNPC>(mod).customdebuff)  //this tells the game to use the public bool customdebuff from NPCsINFO.cs
            {
                npc.lifeRegen -= 30;      //this make so the npc lose life, the highter is the value the faster the npc lose life
                if (damage < 2)
                {
                    damage = 4;  // this is the damage dealt when the npc lose health
                }
            }
        }
    }
}