using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class LifeBand : ModItem
    {


        public override void SetDefaults()
        {
            item.name = "Life Band";
            item.width = 10;
            item.height = 14;
            item.toolTip = "More Life! Yay!";
            item.value = 10;
            item.rare = 3;
            item.accessory = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 200);   //you need 10 Wood
            recipe.AddIngredient(ItemID.LifeCrystal, 20);   //you need 10 Wood
            recipe.AddIngredient(mod.ItemType("LunarBar"), 5  );
            recipe.AddIngredient(mod.ItemType("MastersBadge"));
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            
         player.statLifeMax2 += 200;
        }
    }
}