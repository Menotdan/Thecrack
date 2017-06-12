using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items{
    public class LunarOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Lunar Ore";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            AddTooltip("It's very dark.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("LunarOreTile"); //put your CustomBlock Tile name
        }
    }
}
