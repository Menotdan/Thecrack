using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class LepoardFur : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lepoard Fur");
            Tooltip.SetDefault("Furry to the touch!");
        }

        public override bool CanUseItem(Player player)
        {
            // you can't spawn this boss multiple times or during daytime
            return !(NPC.AnyNPCs(mod.NPCType("Master")) || NPC.AnyNPCs(mod.NPCType("Lepoard"))) && !Main.dayTime;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Master"));   //boss spawn
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Lepoard"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
