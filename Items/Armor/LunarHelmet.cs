using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class LunarHelmet : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 8;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Helmet");
            Tooltip.SetDefault("This is a dark helmet.");
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LunarBreastplate") && legs.type == mod.ItemType("LunarLeggings");  //put your Breastplate name and Leggings name
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "See Like An Owl"; // the armor set bonus
            player.rangedDamage *= 0.54f;  // 8% magic damage
            player.AddBuff(BuffID.NightOwl, 2);  //shine potion buff
            player.AddBuff(BuffID.Spelunker, 2);  //shine potion buff
            player.AddBuff(BuffID.Shine, 2);  //shine potion buff
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 15);   //you need 10 Wood
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}