using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheCrack.NPCs;

namespace TheCrack.Buffs
{
    public class CustomDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Poison Flames");
            Description.SetDefault("The Flames lick your soul");      
            Main.debuff[Type] = true;   //Tells the game if this is a buf or not.
            Main.pvpBuff[Type] = true;  //Tells the game if pvp buff or not. 
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<ModGlobalNPC>(mod).customdebuff = true;    //this tells the game to use the public bool customdebuff from NPCsINFO.cs
            int num1 = Dust.NewDust(npc.position, npc.width, npc.height, DustID.PinkFlame);    //this is the dust/flame effect that will apear on npc or player if is hit by this buff   
            Main.dust[num1].scale = 2.9f; //the dust scale , the higher is the value the large is the dust
            Main.dust[num1].velocity *= 3f; //the dust velocity
            Main.dust[num1].noGravity = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MyPlayer>(mod).customdebuff = true;  //this tells the game to use the public bool customdebuff from MyPlayer.cs
            int num1 = Dust.NewDust(player.position, player.width, player.height, DustID.PinkFlame);    //this is the dust/flame effect that will apear on npc or player if is hit by this buff   
            Main.dust[num1].scale = 2.9f; //the dust scale , the higher is the value the large is the dust
            Main.dust[num1].velocity *= 3f; //the dust velocity
            Main.dust[num1].noGravity = true;
        }

    }
}
