using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace SEKU_Games
{
    public class McKey
    {
        public int state;
        public string key, print, display;

        public McKey(string KEY, int STATE)
        {
            key = KEY;
            state = STATE;
            MakePrint(KEY);
        }

        private void MakePrint(string KEY)
        {
            display = KEY;
            string tempStr = "";

            if (KEY.Length == 1 && char.IsLetterOrDigit(KEY[0]))
            {
                tempStr = KEY;
            }
            else if (KEY.StartsWith("D") && KEY.Length == 2 && char.IsDigit(KEY[1]))
            {
                tempStr = KEY.Substring(1);
            }
            else if (KEY.StartsWith("NumPad") && KEY.Length == 7)
            {
                tempStr = KEY.Substring(6);
            }
            else if (KEY == "Space") tempStr = " ";
            else if (KEY == "OemOpenBrackets") { tempStr = "["; display = tempStr; }
            else if (KEY == "OemCloseBrackets") { tempStr = "]"; display = tempStr; }
            else if (KEY == "OemMinus") { tempStr = "-"; display = tempStr; }
            else if (KEY == "OemPeriod" || KEY == "Decimal") tempStr = ".";

            print = tempStr;
        }
    }
}
