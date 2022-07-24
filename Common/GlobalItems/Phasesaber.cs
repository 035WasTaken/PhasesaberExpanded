using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

using PhasesaberExpanded.Projectiles;

namespace PhasesaberExpanded.Common.GlobalItems {
    public class NewPhasesaber : GlobalItem {
        // set which items this class applies to
        // pattern matching ...
        public override bool AppliesToEntity(Item entity, bool lateInstantiation) => entity.type switch
        {
            ItemID.RedPhasesaber => true,
            ItemID.GreenPhasesaber => true,
            ItemID.BluePhasesaber => true,
            ItemID.WhitePhasesaber => true,
            ItemID.PurplePhasesaber => true,
            ItemID.OrangePhasesaber => true,
            ItemID.YellowPhasesaber => true,
            _ => false,
        };

        // now we can right click for different functionality
        public override bool AltFunctionUse(Item item, Player player) => true;

        public override bool CanUseItem(Item item, Player player)
        {
            if(player.altFunctionUse == 2) {
                item.shoot = item.type switch {
                    ItemID.BluePhasesaber => ModContent.ProjectileType<BluePhasesaber>(),
                    _ => ProjectileID.EnchantedBoomerang
                };
            }

            return true;
        }
    }
}