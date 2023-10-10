using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame___1_
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _dino;
        private Texture2D _dino2;
        private Texture2D _dino3;
        private Texture2D _dino4;
        private Texture2D _dino5;
        private SpriteFont _text;
        private Texture2D _window;
        Random generator = new Random();
        private Vector2 random;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 700;
            _graphics.ApplyChanges();
            this.Window.Title = "Peepee";
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _dino = Content.Load<Texture2D>("Dinosaur (1)");
            _dino2 = Content.Load<Texture2D>("Dinosaur2 (1)");
            _dino3 = Content.Load<Texture2D>("Dinosaur3 (1)");
            _dino4 = Content.Load<Texture2D>("Dinosaur4 (1)");
            _text = Content.Load<SpriteFont>("TextFont");
            _window = Content.Load<Texture2D>("4PanelWindow (1)");
            random = new Vector2(generator.Next(60, 61), generator.Next(35, 36));
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                random = new Vector2(generator.Next(0, 500), generator.Next(0, 400));
            }

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {            
            GraphicsDevice.Clear(Color.White);
            _spriteBatch.Begin();
            _spriteBatch.Draw(_window, new Vector2(-1,0), Color.White);          
            _spriteBatch.Draw(_dino2, new Vector2(440, 370), Color.White);
            _spriteBatch.Draw(_dino3, new Vector2(440, 40), Color.White);
            _spriteBatch.Draw(_dino4, new Vector2(46, 375), Color.White);
            _spriteBatch.Draw(_dino, random, Color.White);
            _text = Content.Load<SpriteFont>("TextFont");
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}