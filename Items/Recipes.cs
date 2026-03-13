using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace CalMurasama.Items
{
	public class Recipes : ModSystem
	{
        public static void DontConsumeSword(Recipe recipe, int type, ref int amount)
        {
            if (type == ItemID.CopperShortsword)
            {
                amount = 0;
            }
            else if (type == ItemID.IronShortsword)
            {
                amount = 0;
            }
            else if (type == ItemID.TinShortsword)
            {
                amount = 0;
            }

        }
        public override void AddRecipes() {
            Recipe.Create(ModContent.ItemType<Items.Murasama>())
                .AddIngredient(ItemID.CopperShortsword)
                .AddConsumeItemCallback(DontConsumeSword)
                .Register();
            Recipe.Create(ModContent.ItemType<Items.Murasama>())
                .AddIngredient(ItemID.IronShortsword)
                .AddConsumeItemCallback(DontConsumeSword)
                .Register();
            Recipe.Create(ModContent.ItemType<Items.Murasama>())
                .AddIngredient(ItemID.TinShortsword)
                .AddConsumeItemCallback(DontConsumeSword)
                .Register();
        }

	}
}
