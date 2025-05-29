using Microsoft.Xna.Framework;

namespace Pong {
    public class Ball {
        Rectangle rect;
        int right = 1, top = 1, moveSpeed = 200;

        public Ball() {
            rect = new Rectangle(Globals.WIDTH / 2 - 20, Globals.HEIGHT / 2 - 20, 40, 40);
        }

        public void Update(GameTime gameTime, Paddle player1, Paddle player2) {
            int delta = (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            rect.X += right * delta;
            rect.Y += top * delta;

            // Collision with player1
            if (player1.rect.Right > rect.Left && rect.Top > player1.rect.Top && rect.Bottom < player1.rect.Bottom)
                right = 1;

            // Collision with player2
            if (player2.rect.Left < rect.Right && rect.Top > player2.rect.Top && rect.Bottom < player2.rect.Bottom)
                right = -1;

            // Top and bottom bounce
            if (rect.Y < 0 || rect.Y > Globals.HEIGHT - rect.Height)
                top *= -1;

            // Left wall (player2 scores)
            if (rect.X < 0) {
                Globals.player2_score += 1;
                resetGame();
            }

            // Right wall (player1 scores)
            if (rect.X > Globals.WIDTH - rect.Width) {
                Globals.player1_score += 1;
                resetGame();
            }
        }

        public void Draw() {
            Globals.spriteBatch.Draw(Globals.pixel, rect, Color.White);
        }

        public void resetGame() {
            rect.X = Globals.WIDTH / 2 - 20;
            rect.Y = Globals.HEIGHT / 2 - 20;
        }
    }
}
