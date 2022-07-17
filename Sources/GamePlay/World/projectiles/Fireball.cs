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
    class Fireball : Projectile2d
    {
      
        public Fireball( Vector2 pos, Unit owner, Vector2 target) : base("2d\\Fireball", pos, new Vector2(20,20), owner, target)
        {
            
        }

        public override void Update(Vector2 offset, List<Unit> units)
        {
            base.Update(offset, units);
        }
   
        public override void Draw(Vector2 offset)
        {
            base.Draw(offset);
        }
    }
}
