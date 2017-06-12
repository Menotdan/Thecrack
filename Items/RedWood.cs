using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items{
    public class RedWood : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Red Wood";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            AddTooltip("From the biggest trees!");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("RedWoodTile"); //put your CustomBlock Tile name
        }
    }
}
