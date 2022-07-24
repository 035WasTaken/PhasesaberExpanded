using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PhasesaberExpanded.Util;

namespace PhasesaberExpanded.Projectiles
{
    public class BluePhasesaber : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.EnchantedBoomerang);
            Projectile.penetrate = 10;

            AIType = ProjectileID.EnchantedBoomerang;
        }
    }
}