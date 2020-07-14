using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tales_Out;
using Tales_Out.ScreenManager;
using Tales_Out.Screens;

namespace Farinya
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private ScreenManager screenManager;

        public Game1()
        {
            Globals.Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;

            Window.AllowUserResizing = true;

            Globals.GameSize = new Vector2(800, 600);
            Globals.Graphics.PreferredBackBufferWidth = (int)Globals.GameSize.X;
            Globals.Graphics.PreferredBackBufferHeight = (int)Globals.GameSize.Y;

            Globals.Graphics.ApplyChanges();

            Globals.BackBuffer = new RenderTarget2D(Globals.Graphics.GraphicsDevice, (int)Globals.GameSize.X, (int)Globals.GameSize.Y, false, SurfaceFormat.Color, DepthFormat.None, 0, RenderTargetUsage.PreserveContents);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.SpriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.Content = Content;

            //cargar todos los elementos del juego
            loadAllAssets();

            screenManager = new ScreenManager();
            ScreenManager.LoadScreen(new DebugScreen());
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            Globals.GameTime = gameTime;

            screenManager.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            Globals.Graphics.GraphicsDevice.SetRenderTarget(Globals.BackBuffer);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);

            screenManager.Draw();

            Globals.Graphics.GraphicsDevice.SetRenderTarget(null);

            Viewport viewport = Globals.Graphics.GraphicsDevice.Viewport;

            //Dibuja backbuffer en pantalla
            Globals.SpriteBatch.Begin();

            Globals.SpriteBatch.Draw(Globals.BackBuffer, new Rectangle(0, 0, viewport.Width, viewport.Height), Color.White);

            Globals.SpriteBatch.End();
        }

        private void loadAllAssets()
        {
            //carga de las fuentes
            Fonts.Load();

            //carga de las texturas
            
            //carga de la musica

            //carga de los sonidos

            //carga de los efectos
        }
    }
}