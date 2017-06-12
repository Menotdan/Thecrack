using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class DirtGun : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 2;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 32;     //gun image width
            item.height = 32;   //gun image  height
            item.useTime = 15;  //how fast 
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

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dirt Gun");
            Tooltip.SetDefault("This gun feels like it could crumble at any second.");
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);   //you need 1 DirtBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
