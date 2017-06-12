using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class DeathFood : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Death Food";
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Dosn't seem like somthing to eat...");
            AddTooltip2("Summons The tiny murderer...");
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {           
            return !NPC.AnyNPCs(mod.NPCType("Master"));  //you can't spawn this boss multiple times
            return !NPC.AnyNPCs(mod.NPCType("TinyDeath"));  //you can't spawn this boss multiple times
            return !Main.dayTime;   //can use only at night
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("TinyDeath"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 20);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
