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
    public class McKeyboard
    {
        public KeyboardState newKeyboard, oldKeyboard;
        public List<McKey> pressedKeys = new List<McKey>();
        public List<McKey> previousPressedKeys = new List<McKey>();

        public void Update()
        {
            newKeyboard = Keyboard.GetState();
            GetPressedKeys();
        }

        public void UpdateOld()
        {
            oldKeyboard = newKeyboard;

            previousPressedKeys.Clear();
            foreach (var key in pressedKeys)
                previousPressedKeys.Add(key);
        }

        public bool GetPress(string KEY)
        {
            foreach (var key in pressedKeys)
            {
                if (key.key == KEY)
                    return true;
            }
            return false;
        }

        private void GetPressedKeys()
        {
            pressedKeys.Clear();
            foreach (var key in newKeyboard.GetPressedKeys())
            {
                pressedKeys.Add(new McKey(key.ToString(), 1));
            }
        }
    }
}
