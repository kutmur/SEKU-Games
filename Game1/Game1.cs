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

    Player player;




    
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

        Texture2D playerTexture = Content.Load<Texture2D>("AnimationSheet_Character");
        Texture2D enemyTexture = Content.Load<Texture2D>("github-octopuss");

        sprites.Add(new Sprite(enemyTexture, new Vector2(500, 50)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(100, 50)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(200, 70)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(600, 50)));
        sprites.Add(new Sprite(enemyTexture, new Vector2(400, 50)));
    

        player = new Player(playerTexture, new Vector2(600, 200));

        sprites.Add(player);
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        List<Sprite> killList = new();

        foreach (var sprite in sprites)
        {
            sprite.Update(gameTime);

            if (sprite != player && sprite.Rect.Intersects(player.Rect))
            {
                killList.Add(sprite);
            }

        }
        foreach (var sprite in killList)
        {
            sprites.Remove(sprite);
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
