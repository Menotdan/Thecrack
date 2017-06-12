using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class TheDestroyer : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 31;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 6;
            item.mana = 1;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("RedLaser");  //this make the item shoot your projectile
            item.shootSpeed = 10f;    //projectile speed when shoot
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Destroyer");
            Tooltip.SetDefault("Shoots rapid lasers, catching your enemies by surprise.");
        }
    }
}
