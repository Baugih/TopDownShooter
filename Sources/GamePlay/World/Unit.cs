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
    public class Unit : Basic2d

    {
        public bool dead;
        public float speed, hitDist;
        public Unit(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims)
        {
            dead = false;
            speed = 2.0f;

            hitDist = 35.0f;
        }

        public override void Update(Vector2 offset)
        {
            base.Update(offset);
        }

        public virtual void getHit()
        {
            dead = true;
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }

    }
}
