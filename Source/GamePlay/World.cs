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

namespace SEKU_Games
{
    public class World
    
    {
        public Hero hero;

        public World()
        {
            hero = new Hero("2d\\AnimationSheet_Character", new Vector2(300, 300), new Vector2(48, 48)); ;
        }

        public virtual void update()
        {
            hero.update();
        }

        public virtual void Draw()
        {
            hero.Draw();
        }
    }
}