using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.Monstrosity
{
    [AutoloadBossHead]
    public class Monstrosity : ModNPC
    {
        public override void SetDefaults()
        {
            npc.lifeMax = 50000; //Boss Hp - life
            npc.aiStyle = 32;
            npc.damage = 34; //Boss damage
            npc.defense = 23; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 320;
            npc.height = 320;
            // animationType = NPCID.DemonEye; // this boss will behavior like demonEye
            Main.npcFrameCount[npc.type] = 1; //boss frame/animation
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.velocity.X *= 10000f;
            npc.velocity.Y *= 10000f;
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
            DisplayName.SetDefault("The Monstrosity");
        }

        public override void OnHitPlayer(Player player, int damage, bool crit)  //this make so when this npc hit he player it will give to the player this debuff
        {
            player.AddBuff(mod.BuffType("CustomDebuff"), 550, true);
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
