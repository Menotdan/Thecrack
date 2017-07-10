using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.Master
{   [AutoloadBossHead]
    public class Master : ModNPC
    {
        public override void SetDefaults()
        {
            npc.aiStyle = 30; //Not moving target
            npc.lifeMax = 4000; //Boss Hp - life
            npc.damage = 34; //Boss damage
            npc.defense = 23; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 200;
            npc.height = 200;
            // animationType = NPCID.DemonEye; // this boss will behavior like demonEye
            Main.npcFrameCount[npc.type] = 2; //boss frame/animation
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            music = MusicID.LunarBoss;
            npc.netAlways = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Master");
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.HealingPotion; // drop z bosse
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MastersBadge"));
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale); // boss life bude v "ExpertM�du"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert m�du"
        }
    }
}
