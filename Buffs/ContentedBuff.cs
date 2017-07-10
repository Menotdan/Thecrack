using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheCrack.Buffs
{
    public class ContentedBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Contented");
            Description.SetDefault("Tasty Acorn Pancakes!");
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.statDefense += 5;  //
            player.statLifeMax2 += 80;  //

        }
    }
}