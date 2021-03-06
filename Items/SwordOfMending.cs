using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items   //where is located
{
    public class SwordOfMending : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 17;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 90;              //Sword width
            item.height = 90;             //Sword height
            item.useTime = 20;          //how fast 
            item.useAnimation = 25;
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 5;      //Sword knockback
            item.value = 100;
            item.rare = 10;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
            item.shoot = mod.ProjectileType("HealingBeam");
            item.shootSpeed = 11f;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Sword of Mending");
            Tooltip.SetDefault("Mends even the greatest wounds.");
        }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LesserHealingPotion, 5);   //you need 1 DirtBlock
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(mod.BuffType("BuffName"), 400);  //400 is the buff time
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("DustName"));
            }
        }
    }
}
