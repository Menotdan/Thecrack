using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace TheCrack
{
    public class MyPlayer : ModPlayer
    {


        public bool ZoneCustomBiome = false;
        public bool customdebuff = false;

        public override void ResetEffects()
        {
            customdebuff = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (customdebuff)  // make sure you add the right bool 
            {
                player.lifeRegen -= 60; //this make so the player take damage, the highter is the value the more life losing.
            }
        }
        public override void UpdateBiomes()
        {
            ZoneCustomBiome = (Biome.customBiome > 0);
        }

    }
}