using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items{
    public class RedDirt : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Red Dirt";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("RedDirtTile"); //put your CustomBlock Tile name
        }
    }
}
