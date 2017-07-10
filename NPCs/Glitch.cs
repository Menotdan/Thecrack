using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//By Al0n37
namespace TheCrack.NPCs
{
    public class Glitch : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 50;
            npc.height = 40;
            npc.damage = 1;
            npc.defense = 1;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
            npc.noGravity = true;
            npc.knockBackResist = 0.87f;
            npc.aiStyle = 12;
            Main.npcFrameCount[npc.type] = 3; 
            aiType = NPCID.GreenSlime;  //npc behavior
            animationType = NPCID.GreenSlime;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glitch");
        }

        public float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.01f : 0.01f; //spown at day
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
            npc.lifeMax = (int)(npc.lifeMax * 3f * bossLifeScale); // boss life bude v "ExpertM�du"
            npc.damage = (int)(npc.damage * 0.6f); //Boss damage v "Expert m�du"
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ItemName"), 2); //Item spawn
            }
        }
    }
}