using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong {
    public class Game1 : Game {
        private GraphicsDeviceManager _graphics;

        public Game1() {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Globals.WIDTH;
            _graphics.PreferredBackBufferHeight = Globals.HEIGHT;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize() {
            base.Initialize();
        }

        protected override void LoadContent() {
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.pixel = new Texture2D(GraphicsDevice, 1, 1);
            Globals.pixel.SetData<Color>(new Color[] { Color.White });
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.Black);

            Globals.spriteBatch.Begin();
            // Drawing will go here
            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
