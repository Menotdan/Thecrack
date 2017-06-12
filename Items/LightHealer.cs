using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items   //where is located
{
    public class LightHealer : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Light Healer";     //Sword name
            item.damage = 10;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 90;              //Sword width
            item.height = 90;             //Sword height
            item.toolTip = "Cool Modded Sword";  //Item Description
            item.useTime = 1;          //how fast 
            item.useAnimation = 25;     
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 1000;      //Sword knockback
            item.value = 10000;        
            item.rare = 10;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(ItemID.Wood, 10);   //you need 10000 AshBlock
            recipe.AddIngredient(ItemID.LesserHealingPotion, 1);   //you need 100 StoneBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.statLife += 1;
            player.HealEffect(1);
        }
    }
}