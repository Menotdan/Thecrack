using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class AcornPancake : ModItem
    {
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;//this is how the item is holded when used
			item.potion = true;
			item.healLife += 100;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 1;
            item.buffType = mod.BuffType("ContentedBuff");    //this is where you put your Buff name
            item.buffTime = 70000;    //this is the buff duration        20000 = 6 min
            return;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acorn Pancake");
            Tooltip.SetDefault("Tasty Acorn Pancakes");
        }

        public override void AddRecipes()  //How to craft this sword
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(mod.ItemType("SmashedAcorn"), 3);   //you need 1 DirtBlock
            recipe.AddIngredient(ItemID.BottledWater, 1);   //you need 1 DirtBlock
            recipe.AddTile(TileID.Furnaces);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
