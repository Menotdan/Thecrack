using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//By Al0n37
namespace TheCrack.NPCs
{
    public class ShadowMinion : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.damage = 50;
            npc.defense = 20;
            npc.lifeMax = 400;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.noGravity = true;
            npc.knockBackResist = 0.87f;
            npc.aiStyle = 2;
            Main.npcFrameCount[npc.type] = 1;
            aiType = NPCID.DemonEye;  //npc behavior
            animationType = NPCID.DemonEye;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Minion");
        }

        public override void OnHitPlayer(Player player, int damage, bool crit)  //this make so when this npc hit he player it will give to the player this debuff
        {
            player.AddBuff(mod.BuffType("CustomDebuff"), 550, true);
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.875F; // Determines the animation speed. Higher value = faster animation.
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 3f * bossLifeScale); // boss life bude v "ExpertMódu"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert módu"
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"), 2); //Item spawn
            }
        }
    }
}