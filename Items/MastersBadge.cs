using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class MastersBadge : ModItem
    {


        public override void SetDefaults()
        {
            item.name = "Master's Badge";
            item.width = 10;
            item.height = 14;
            item.toolTip = "Who's the master now?!";
            item.value = 10;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            
            player.noFallDmg = true; 
            player.canRocket = true;
            player.rocketTime = 2;
            player.rocketBoots = 1;
            player.rocketTimeMax = 2;
            player.aggro += 300;
            player.meleeCrit += 10;
            player.meleeDamage += 0.32f;
            player.meleeSpeed += 0.23f;
            player.moveSpeed += 0.74f;
            player.rangedCrit += 7;
            player.rangedDamage += 0.43f;
            player.maxMinions++;
            player.minionDamage += 0.25f;
            player.statManaMax2 += 80;
            player.manaCost -= 0.7f;
            player.magicCrit += 7;
            player.magicDamage += 0.54f;
        }
    }
}