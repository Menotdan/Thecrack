using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class DirtBullet : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dirt Bullet"; 
            item.damage = 2;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.toolTip = "Don't Complain about dirty hands.";
            item.consumable = true;
            item.knockBack = 0.75f;
            item.value = 10;
            item.rare = 4;
            item.shoot = mod.ProjectileType("DirtBulletProj");
            item.shootSpeed = 15f;
            item.ammo = ProjectileID.Bullet;
        }
        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);   //you need 1 DirtBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this, 20);  //20 means how many bullets you craft from 1 dirt block
            recipe.AddRecipe();

        }
    }
}