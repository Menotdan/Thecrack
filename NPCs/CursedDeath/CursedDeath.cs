using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.NPCs.CursedDeath
{   [AutoloadBossHead]
    public class CursedDeath : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Cursed Death";
            npc.displayName = "Cursed Death";
            npc.lifeMax = 50000; //Boss Hp - life
            npc.damage = 34; //Boss damage
            npc.defense = 23; //Boss armor / defense
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
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

        public override void AI() //this is where you program your AI
        {
            Player P = Main.player[npc.target];
            npc.ai[1]++;
            if (npc.ai[1] >= 2)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 35;  //projectile damage
                int type = mod.ProjectileType("DeathBeam");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
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
