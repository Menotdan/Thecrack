using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class ShadowEssence : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 920;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Essence");
            Tooltip.SetDefault("Furry to the touch!");
        }

        public override bool CanUseItem(Player player)
        {
            // you can't spawn this boss multiple times
            return !(NPC.AnyNPCs(mod.NPCType("ShadowEye")) || NPC.AnyNPCs(mod.NPCType("ShadowWormHead"))) && !Main.dayTime;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("ShadowWormHead"));   //boss spawn
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("ShadowEye"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(ItemID.SoulofFlight, 10);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 10);
            recipe.AddIngredient(ItemID.IronBar, 6);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
