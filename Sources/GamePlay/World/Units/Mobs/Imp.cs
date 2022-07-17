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
    public class Imp : Mob

    {

        public Imp(Vector2 pos) : base("2d\\Imp", pos, new Vector2(40,40))
        {
            speed = 2.0f;
        }

        public override void Update(Vector2 offset, Hero hero)
        {
         
            base.Update(offset, hero);
        }

        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }

    }
}
