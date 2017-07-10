using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items   //where is located
{
    public class RustyKnife : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 4;            //Sword damage
            item.melee = true;            //if it's melee
            item.width = 90;              //Sword width
            item.height = 90;             //Sword height
            item.useTime = 3;          //how fast 
            item.useAnimation = 25;
            item.useStyle = 1;        //Style is how this item is used, 1 is the style of the sword
            item.knockBack = 5;      //Sword knockback
            item.value = 100;
            item.rare = 10;
            item.UseSound = SoundID.Item1;       //1 is the sound of the sword
            item.autoReuse = true;   //if it's capable of autoswing.
            item.useTurn = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rusty Knife");
            Tooltip.SetDefault("A Rusty Knife, Infected with germs and poison.");
        }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 2);   //you need 1 DirtBlock
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)  //how to add a buff to a melee weapon.
        {
            target.AddBuff(mod.BuffType("CustomDebuff"), 600);      //this adds the buff to the npc that got hit by this sword , 600 is the time the buff lasts
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
