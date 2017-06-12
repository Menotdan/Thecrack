using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.YoungSlimePrince
{   [AutoloadBossHead]
    public class YoungSlimePrince : ModNPC
    {
        public override void SetDefaults()
        {
            npc.aiStyle = 15; //Not moving target
            npc.lifeMax = 1500; //Boss Hp - life
            npc.damage = 8; //Boss damage
            npc.defense = 5; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 200;
            npc.height = 200;
            // animationType = NPCID.KingSlime; // this boss will behavior like demonEye
            Main.npcFrameCount[npc.type] = 2; //boss frame/animation
            npc.value = Item.buyPrice(0, 0, 90, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            music = MusicID.Boss1;
            npc.netAlways = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glorbo, The Young Slime Prince");
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.LesserHealingPotion; // drop z bosse
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheSlimesCrown"));
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale); // boss life bude v "ExpertMódu"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert módu"
        }
    }
}
