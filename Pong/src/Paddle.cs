using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Pong {
    public class Paddle {
        public Rectangle rect;
        float moveSpeed = 500f;

        public Paddle(bool isSecondPlayer) {
            int x = isSecondPlayer ? Globals.WIDTH - 40 : 0;
            rect = new Rectangle(x, 140, 40, 200);
            this.isSecondPlayer = isSecondPlayer;
        }

        bool isSecondPlayer;

        public void Update(GameTime gameTime) {
            KeyboardState kstate = Keyboard.GetState();
            if ((isSecondPlayer ? kstate.IsKeyDown(Keys.Up) : kstate.IsKeyDown(Keys.W)) && rect.Y > 0)
                rect.Y -= (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);

            if ((isSecondPlayer ? kstate.IsKeyDown(Keys.Down) : kstate.IsKeyDown(Keys.S)) && rect.Y < Globals.HEIGHT - rect.Height)
                rect.Y += (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
        }

        public void Draw() {
            Globals.spriteBatch.Draw(Globals.pixel, rect, Color.White);
        }
    }
}
