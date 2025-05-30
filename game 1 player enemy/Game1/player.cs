using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SEKUGames
{
    internal class Player : Sprite
    {
        public Player(Texture2D texture, Vector2 position) : base(texture, position) { }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += 10;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= 10;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                position.Y -= 10;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                position.Y += 10;
            }
            
        }
    }
}