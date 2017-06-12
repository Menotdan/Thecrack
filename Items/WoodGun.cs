using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class WoodGun : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Wood Gun";  //Gun name  
            item.damage = 10;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 32;     //gun image width
            item.height = 32;   //gun image  height
            item.toolTip = "This gun feels like it's cool.";   //gun description
            item.useTime = 5;  //how fast 
            item.useAnimation = 20;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 15);   //you need 1 DirtBlock
			recipe.AddIngredient(mod.ItemType("DirtGun"), 1);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}