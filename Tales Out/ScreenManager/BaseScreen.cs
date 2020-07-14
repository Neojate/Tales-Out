using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_Out.ScreenManager
{
    public enum ScreenState
    {
        Active,
        Shutdown,
        Hidden
    }

    public abstract class BaseScreen
    {
     
        public string Name { get { return GetType().Name; } }

        public ScreenState State { get; set; }

        public bool Focused { get; set; }
        public bool GrabFocus { get; set; }

        protected SpriteBatch Canvas;


        public BaseScreen()
        {
            State = ScreenState.Active;
            Canvas = Globals.SpriteBatch;
        }

        public virtual void HandleInput() { }

        public abstract void Update();

        public abstract void Draw();

        public virtual void Unload() { }
        
    }
}
