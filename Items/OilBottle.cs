using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class OilBottle : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 128;
            item.height = 205;
            item.maxStack = 20;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oil Bottle");
            Tooltip.SetDefault("For destiffning stiff items.");
        }
        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bottle, 1);   //you need 1 DirtBlock
            recipe.AddIngredient(ItemID.BottledHoney, 1);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
