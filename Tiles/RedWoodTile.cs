using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheCrack.Tiles
{
    public class RedWoodTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("RedWood");   //put your CustomBlock name
        }
      
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 1f;
            g = 0f;
            b = 0f;
        }
    }
}