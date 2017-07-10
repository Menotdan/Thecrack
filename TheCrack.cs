using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack
{
    public class TheCrack : Mod
    {
        
        public TheCrack()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void UpdateMusic(ref int music)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<MyPlayer>(this).ZoneCustomBiome) //this makes the music play only in Custom Biome
                {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Music/RedWoodMusic");  //add where is the custom music is located
                }
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.SetResult(ItemID.IronAnvil);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadBar, 1);
            recipe.SetResult(ItemID.IronBar);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.SetResult(ItemID.LeadBar);
            recipe.AddRecipe();
        }
    }
}



