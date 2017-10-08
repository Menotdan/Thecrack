using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheCrack.Buffs
{
    public class ElchieBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Elchie");
            Description.SetDefault("A great Buff");
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.statDefense += 5;  //
            player.statLifeMax2 += 50;  //

        }
    }
}