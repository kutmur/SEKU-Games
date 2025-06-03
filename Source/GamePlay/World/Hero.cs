using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Security.Cryptography;
using System.IO;

namespace SEKU_Games
{
    public class Hero : Basic2d
    {
        public Hero(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {

        }

        public override void update()
        {
            if (Globals.keyboard.GetPress("A") || Globals.keyboard.GetPress("Left"))
            {
                pos = new Vector2(pos.X - 5, pos.Y);
            }

            if (Globals.keyboard.GetPress("D") || Globals.keyboard.GetPress("Right"))
            {
                 pos = new Vector2(pos.X + 5, pos.Y);
            }

            if (Globals.keyboard.GetPress("W") || Globals.keyboard.GetPress("Up"))
            {
                  pos = new Vector2(pos.X, pos.Y - 5);
            }

            if (Globals.keyboard.GetPress("S") || Globals.keyboard.GetPress("Down"))
            {
                  pos = new Vector2(pos.X, pos.Y + 5);
            }



            
        
            base.update();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}