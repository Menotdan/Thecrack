using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items.Armor
{   [AutoloadEquip(EquipType.Leggings)]
    public class LunarLeggings : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10;
            item.rare = 2;
            item.defense = 7;
        }

	   public override void SetStaticDefaults()
       {
        DisplayName.SetDefault("Lunar Leggings");
         Tooltip.SetDefault("Darkness Swarms around your legs...");
       }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.38f;  //player movement speed incresed 0.05f = 5%
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 10);   //you need 10 Wood
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}