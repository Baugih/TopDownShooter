﻿using System;
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
    public class Mob : Unit

    {
        
        public Mob(string path, Vector2 pos, Vector2 dims) : base(path, pos, dims)
        {
            speed = 2.0f;
        }

        public virtual void Update(Vector2 offset, Hero hero)
        {
            AI(hero);
            base.Update(offset);
        }

        public virtual void AI(Hero hero)
        {
            this.pos += Globals.RadialMovement(hero.pos, pos, speed);
            rot = Globals.RotateTowards(pos, hero.pos);
        }



        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }

    }
}
