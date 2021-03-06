using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class CursedImprint : ModItem
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
            DisplayName.SetDefault("Cursed Imprint");
            Tooltip.SetDefault("Summons the Cursed Projectile launcher.");
        }

        public override bool CanUseItem(Player player)
        {
            //you can't spawn this boss multiple times or during day
            return !NPC.AnyNPCs(mod.NPCType("CursedDeath")) && !Main.dayTime;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CursedDeath"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarBar"), 20);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 6);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
