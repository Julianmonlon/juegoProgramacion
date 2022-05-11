using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace juegoLenguajes
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Player hansel;
        Sprite background;
        string kbrState;
        Witch muriel;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            hansel = new Player();
            background = new Sprite();
            muriel = new Witch();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            background = new Sprite("Sprites/bg", new Point(0, 0), new Point(1200, 630));
            background.LoadContent(Content);
            hansel.LoadContent(Content);
            muriel.LoadContent(Content);
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState myKeyboard = Microsoft.Xna.Framework.Input.Keyboard.GetState();

            if (myKeyboard.IsKeyDown(Keys.A))
            {
                hansel.Move(kbrState = "m");
            }
            else if (myKeyboard.IsKeyDown(Keys.D))
            {
                hansel.Move(kbrState = "j");
            }
            else if (Keyboard.HasBeenPressed(Keys.Space) == true)
            {
                hansel.Shoot(Content, hansel.Location);
            }
            foreach (var item in hansel.breads)
            {
                item.MoveUp();

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DeepSkyBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            background.Draw(_spriteBatch, Color.White);

            foreach (var item in hansel.breads)
            {
                item.Draw(_spriteBatch, Color.White);
            }

            hansel.Draw(_spriteBatch, Color.White);

            muriel.Draw(_spriteBatch, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
