using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.TinyDeath
{
    [AutoloadBossHead]
    public class TinyDeath : ModNPC
    {
        public override void SetDefaults()
        {
            npc.aiStyle = 5; //Not moving target
            npc.lifeMax = 100000; //Boss Hp - life
            npc.damage = 250; //Boss damage
            npc.defense = 100; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 32;
            npc.height = 32;
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

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tiny Death");
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.875F; // Determines the animation speed. Higher value = faster animation.
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion; // drop z bosse
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.75f * bossLifeScale); // boss life bude v "ExpertMódu"
            npc.damage = (int)(npc.damage * 0.78f); //Boss damage v "Expert módu"
        }
    }
}
