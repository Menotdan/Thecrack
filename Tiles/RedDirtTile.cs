using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheCrack.Tiles
{
    public class RedDirtTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("RedDirt");   //put your CustomBlock name
            SetModTree(new RedWoodTree());  //this make the tree spawn on this block/tile.  change CustomTreeTile with u'r tree name
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Red Dirt");
            AddMapEntry(new Color(158, 15, 15), name);
        }

        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("RedWoodSapling");        //this make the spaling spawn the custom tree/sapling on this block/tile.    change CustomSaplingTile with u'r sapling name
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 1f;
            g = 0f;
            b = 0f;
        }
    }
}