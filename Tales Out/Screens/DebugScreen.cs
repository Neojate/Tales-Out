using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tales_Out.ScreenManager;

namespace Tales_Out.Screens
{
    public class DebugScreen : BaseScreen
    {
        public override void Draw()
        {
            Canvas.Begin();
            Canvas.DrawString(Fonts.Arial12, "Hola mundo", new Vector2(100, 100), Color.Black);
            Canvas.End();
        }

        public override void Update()
        {
            
        }
    }
}
