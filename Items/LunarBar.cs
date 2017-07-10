using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items   //where is located
{
    public class LunarBar : ModItem
    {
        public override void SetDefaults()
        {
            item.maxStack = 999;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Bar");
            Tooltip.SetDefault("");
        }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarOre"), 3);   //you need 1 DirtBlock
            recipe.AddTile(TileID.Furnaces);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
