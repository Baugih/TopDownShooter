using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace TopDownShooter
{
    public class Projectile2d : Basic2d
    {
        public bool done;

        public float speed;

        public Vector2 direction;

        public Unit owner;

        public McTimer timer;
        public Projectile2d(string path, Vector2 pos, Vector2 dims, Unit owner, Vector2 target) : base(path, pos, dims)
        {
            speed = 5.0f;
            done = false;
            this.direction = target - owner.pos;
            this.direction.Normalize();
            this.owner = owner;
            rot = Globals.RotateTowards(pos, new Vector2(target.X, target.Y));

            timer = new McTimer(3000);
        }

        public virtual void Update(Vector2 offset, List<Unit> units)
        {
            pos += direction * speed;


            timer.UpdateTimer();
            if (timer.Test())
            {
                done = true;
            }

            if (HitSomething(units))
            {
                done = true;
            }
        }

        public virtual bool HitSomething(List<Unit> units)
        {

            for(int i=0; i<units.Count; i++)
            {
                if (Globals.GetDistance(pos, units[i].pos) < units[i].hitDist)
                {
                    units[i].getHit();
                    return true;
                }
            }
            return false;
        }
        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
