using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
 
namespace TheCrack.Tiles
{
    public class RedWoodTree : ModTree
    {
        private Mod mod
        {
            get
            {
                return ModLoader.GetMod("TheCrack");
            }
        }
        public override int DropWood()
        {
            return mod.ItemType("RedWood");     //this is what the tree will drop
        }
 
        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/RedWoodTree");        //add where is u'r tree tile
        }
 
        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            return mod.GetTexture("Tiles/RedWoodTree_Tops");       //add where is u'r tree tops tile
        }
 
        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/RedWood_Branches");    //add where is u'r tree branches tile
        }
    }
}