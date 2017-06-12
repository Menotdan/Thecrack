using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class TheSlimesCrown : ModItem
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
            DisplayName.SetDefault("The Slime's Crown");
            Tooltip.SetDefault("Feels Slimy.");
        }

        public override bool CanUseItem(Player player)
        {
            //you can't spawn this boss multiple times
            return !NPC.AnyNPCs(mod.NPCType("YoungSlimePrince"));
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("YoungSlimePrince"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
