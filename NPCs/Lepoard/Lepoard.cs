using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.Lepoard
{   [AutoloadBossHead]
    public class Lepoard : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Lepoard";
            npc.displayName = "The Puny Lepoard";
            npc.aiStyle = 31; //Not moving target
            npc.lifeMax = 1000; //Boss Hp - life
            npc.damage = 20; //Boss damage
            npc.defense = 10; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 200;
            npc.height = 200;
            // animationType = NPCID.DemonEye; // this boss will behavior like demonEye
            Main.npcFrameCount[npc.type] = 2; //boss frame/animation
            npc.value = Item.buyPrice(0, 2, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit3;
            npc.DeathSound = SoundID.NPCDeath4;
            npc.buffImmune[24] = true;
            music = MusicID.LunarBoss;
            npc.netAlways = true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.HealingPotion; // drop z bosse
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale); // boss life bude v "ExpertMódu"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert módu"
        }
    }
}
