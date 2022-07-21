using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

using System.Text;

namespace TopDownShooter
{
    public class Basic2d
    {
        public float rot;
        public Vector2 pos, dims, frameSize;
        public Texture2D myModel;

        public Basic2d(string path, Vector2 pos, Vector2 dims)
        {
            this.pos = pos;
            this.dims = dims;
           
            myModel = Globals.content.Load<Texture2D>(path);

        }
        public virtual void Update(Vector2 offset)
        {

        }
        public virtual void Draw(Vector2 offset)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X + offset.X), (int)(pos.Y+offset.Y), (int)(dims.X), (int)(dims.Y)), null, Color.White, rot, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2), new SpriteEffects(), 0);
            }

        }

        public virtual void Draw(Vector2 offset, Vector2 origin)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X + offset.X), (int)(pos.Y + offset.Y), (int)(dims.X), (int)(dims.Y)), null, Color.White, rot, new Vector2(origin.X, origin.Y), new SpriteEffects(), 0);
            }

        }
    }
}
