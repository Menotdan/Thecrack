using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.SpazReborn
{   [AutoloadBossHead]
    public class SpazReborn : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "SpazReborn";
            npc.displayName = "Spazmatism Reborn";
            npc.aiStyle = 31; //Not moving target
            npc.lifeMax = 40000; //Boss Hp - life
            npc.damage = 80; //Boss damage
            npc.defense = 42; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 110;
            npc.height = 110;
            // animationType = NPCID.DemonEye; // this boss will behavior like demonEye
            Main.npcFrameCount[npc.type] = 6; //boss frame/animation
            npc.value = Item.buyPrice(0, 20, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit3;
            npc.DeathSound = SoundID.NPCDeath4;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion; // drop z bosse
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale); // boss life bude v "ExpertMódu"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert módu"
        }
    }
}
