using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_Out.ScreenManager
{
    public class ScreenManager
    {
        private static List<BaseScreen> screens = new List<BaseScreen>();

        public void Update()
        {
            //borramos todas las pantallas no activas
            screens.RemoveAll(screen => screen.State != ScreenState.Active);

            //activamos el update y el handleinput de todas las pantallas activas
            foreach (BaseScreen screen in screens.Where(screen => screen.State == ScreenState.Active))
            {
                screen.HandleInput();
                screen.Update();
            }
        }

        public void Draw()
        {
            //activamos el draw para cada pantalla activa
            foreach (BaseScreen screen in screens)
                if (screen.State == ScreenState.Active)
                    screen.Draw();
        }

        public static void LoadScreen(BaseScreen screen)
        {
            screens.Add(screen);
        }

        public static void UnloaadScreen(string screenName)
        {
            screens.FirstOrDefault(screen => screen.Name.Equals(screenName)).Unload();
        }

        public static List<BaseScreen> CurrentActiveScreens()
        {
            return screens;
        }

    }
}
