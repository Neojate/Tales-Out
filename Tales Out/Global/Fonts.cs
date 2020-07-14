﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tales_Out
{
    public class Fonts
    {
        public static SpriteFont Arial12 { get; set; }

        public static void Load()
        {
            Arial12 = Globals.Content.Load<SpriteFont>("fonts/arial12");
        }
    }
}
