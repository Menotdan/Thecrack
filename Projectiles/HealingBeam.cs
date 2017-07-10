using System;
using Terraria;
using Terraria.ModLoader;

namespace TheCrack.Projectiles
{

    public class HealingBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 20;       //projectile width
            projectile.height = 28;  //projectile height
            projectile.friendly = true;      //make that the projectile will not damage you
            projectile.melee = true;         // 
            projectile.tileCollide = true;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = 2;      //how many npc will penetrate
            projectile.timeLeft = 200;   //how many time this projectile has before disepire
            projectile.light = 0.75f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Healing Beam");
        }

        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }

        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            Player player = Main.player[projectile.owner]; //Player who spawned the projectile will get healed
            int heal = 1;
            player.statLife += heal;
            if (player.statLife > player.statLifeMax2)
            {
                player.statLife = player.statLifeMax2;
            }
            player.HealEffect(heal, true);
        }
    }
}