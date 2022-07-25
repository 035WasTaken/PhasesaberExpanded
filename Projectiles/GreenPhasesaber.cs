using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhasesaberExpanded.Projectiles
{
    public class GreenPhasesaber : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.EnchantedBoomerang);
            Projectile.timeLeft = 1000;
        }

        public override void PostAI() {
            Lighting.AddLight(Projectile.VisualPosition, new Vector3(0f, 1f, 0f));
        }
    }
}