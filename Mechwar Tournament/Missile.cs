using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Mechwar_Tournament
{
    class Missile
    {
        public static void Normal()
        {
            for (int i = 0; i < 6; i++)
            {
                if (Game1.missilekoordinat[i] != new Vector2(-1000, -1000))
                {
                    if (Game1.missileleft[i])
                        Game1.missilekoordinat[i].X -= 6;
                    else
                        Game1.missilekoordinat[i].X += 6;
                    if (Game1.missilekoordinat[i].X <= -8 || Game1.missilekoordinat[i].X >= 640)
                        Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                }
            }
        }
    }
}
