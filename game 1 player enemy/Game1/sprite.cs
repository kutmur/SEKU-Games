using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace SEKUGames

    

{
    internal class Sprite
    {
        private static readonly float SCALE = 1f;
        public Texture2D texture;
        public Vector2 position;
        public Rectangle Rect
        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y,
                    texture.Width * (int)SCALE,
                    texture.Height * (int)SCALE
                );
            }
        }
        public Sprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
    
}