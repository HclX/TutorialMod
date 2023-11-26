using Microsoft.Xna.Framework;
using Microsoft.CodeAnalysis;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles
{
    public class SnowflakeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Snowflake"); // Name of the projectile
        }

        public override void SetDefaults()
        {
            Projectile.width = 64; // Width of the projectile
            Projectile.height = 64; // Height of the projectile
            Projectile.Center = new Vector2(Projectile.width/2, Projectile.height/2);
            Projectile.aiStyle = 0; // The ai style of the projectile
            Projectile.friendly = true; // Can damage enemies
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.tileCollide = false; // Will collide with tiles
            Projectile.penetrate = 1; // How many times it can penetrate enemies
            Projectile.timeLeft = 600; // Duration before the projectile disappears
            Projectile.scale = 0.5f;
        }

        public override void AI()
        {
            // Scale up the projectile over time
            if (Projectile.scale < 2.0f)
            {
                Projectile.scale += 0.01f; // Adjust scaling speed as needed
            }
            Projectile.rotation += 0.1f;
        }
    }
}
