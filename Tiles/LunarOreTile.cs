using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheCrack.Tiles
{
    public class LunarOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("LunarOre");   //put your CustomBlock name
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Lunar Ore");
            AddMapEntry(new Color(48, 51, 56), name);
        }
      
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}