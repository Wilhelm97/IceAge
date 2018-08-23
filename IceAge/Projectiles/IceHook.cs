using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace IceAge.Projectiles
{
    public class IceHook : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.GemHookRuby);
        }

        public override bool? CanUseGrapple(Player player)
        {
            int hooksOut = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == projectile.type)
                {
                    hooksOut++;
                }
            }
            if(hooksOut > 3)
            {
                return false;
            }
            return true;
        }

        public override float GrappleRange()
        {
            return 350f;
        }

        public override void NumGrappleHooks(Player player, ref int numHooks)
        {
            numHooks = 3;
        }

        public override void GrappleRetreatSpeed(Player player, ref float speed)
        {
            speed = 15f;
        }

        public override void GrapplePullSpeed(Player player, ref float speed)
        {
            speed = 5f;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 playerCenter = Main.player[projectile.owner].MountedCenter;
            Vector2 center = projectile.Center;
            Vector2 distToProj = playerCenter - projectile.Center;
            float projRotation = distToProj.ToRotation() - 1.57f;
            float distance = distToProj.Length();
            while(distance > 30f && !float.IsNaN(distance))
            {
                distToProj.Normalize();
                distToProj *= 24f;
                center += distToProj;
                distToProj = playerCenter - center;
                distance = distToProj.Length();
                Color drawColor = lightColor;

                spriteBatch.Draw(mod.GetTexture("Projectiles/TutorialHookChain"), new Vector2(center.X - Main.screenPosition.X, center.Y - Main.screenPosition.Y),
                    new Rectangle(0, 0, Main.chain30Texture.Width, Main.chain30Texture.Height), drawColor, projRotation,
                    new Vector2(Main.chain30Texture.Width * 0.5f, Main.chain30Texture.Height * 0.5f), 1f, SpriteEffects.None, 0f);
            }
            return true;
        }


    }
}
