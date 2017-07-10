using Terraria.ModLoader;

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

    }
}