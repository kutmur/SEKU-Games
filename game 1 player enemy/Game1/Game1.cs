using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SEKUGames;



public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    List<Sprite> sprites;



    
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();

       
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

         sprites = new();

        Texture2D playerTexture = Content.Load<Texture2D>("imorr");
        Texture2D enemyTexture = Content.Load<Texture2D>("xanti");

        sprites.Add(new Sprite(enemyTexture, new Vector2(50, 50)));
        

        sprites.Add(new Player(playerTexture, new Vector2(200, 200)));
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        foreach (var sprite in sprites)
        {
            sprite.Update(gameTime);
                }



        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
{
    GraphicsDevice.Clear(Color.CornflowerBlue);

    _spriteBatch.Begin();

    foreach (var sprite in sprites)
    {
        sprite.Draw(_spriteBatch);
    }

    _spriteBatch.End();

    base.Draw(gameTime);
}

}
