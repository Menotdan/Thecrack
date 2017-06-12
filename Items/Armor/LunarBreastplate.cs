using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items.Armor
{   [AutoloadEquip(EquipType.Breastplate)]
    public class LunarBreastplate : ModItem
    {   

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10;
            item.rare = 2;
            item.defense = 15;
        }
	    public override void SetStaticDefaults()
        {
         DisplayName.SetDefault("Lunar Breastplate");
          Tooltip.SetDefault("These are dark times...");
        } 

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 100;   //20 max mana
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 20);   //you need 10 Wood
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}