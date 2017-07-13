using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheCrack.Items
{
    public class RainbowDisk : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 11;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 5;
            item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 6;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("RainbowDiskProj");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rainbow Disk");
            Tooltip.SetDefault("Shiny!");
        }

        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 11);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}