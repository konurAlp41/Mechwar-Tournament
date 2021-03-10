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
    class HealthIssues
    {
        public static void Hasar()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Game1.durum[i] == 1)
                {
                    Game1.hasarsayac[i]++;
                    if (Game1.hasarsayac[i] >= 20)
                    {
                        Game1.hasarsayac[i] = 0;
                        Game1.durum[i] = 0;
                    }
                }
            }
        }

        public static void Donma()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Game1.durum[i] == 2)
                {
                    Game1.animasyon[i] = 15;
                    Game1.ziplama[i] = 0;
                    if (Game1.koordinat[i].Y < 406)
                        Game1.koordinat[i].Y += 12;
                    if (Game1.koordinat[i].Y > 406)
                        Game1.koordinat[i].Y = 406;
                }
            }
        }

        public static void Olum()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Game1.saglik[i] <= 0)
                    Game1.durum[i] = 3;
                if (Game1.durum[i] == 3)
                {
                    if (Game1.parcacikzamanlayici == 0)
                    {
                        if (i == 0)
                            Game1.text = "    " + Game1.karaktername[Game1.secilikarakter[1]] + " Wins\nPress ESC to restart";
                        else
                            Game1.text = "    " + Game1.karaktername[Game1.secilikarakter[0]] + " Wins\nPress ESC to restart";
                    }
                    if (Game1.parcacikzamanlayici == 0)
                    {
                        Game1.ilkkimoldu = i;
                        for (int a = 0; a < 5; a++)
                            Game1.parcacikkoordinat[a] = new Vector2(Game1.koordinat[i].X + 17, Game1.koordinat[i].Y + 19);
                    }
                    else
                    {
                        if (Game1.parcacikzamanlayici <= 6)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 3;
                            Game1.parcacikkoordinat[1].Y += 1;
                            Game1.parcacikkoordinat[2].X -= 3;
                            Game1.parcacikkoordinat[2].Y += 1;
                            Game1.parcacikkoordinat[3].X += 1;
                            Game1.parcacikkoordinat[3].Y -= 2;
                            Game1.parcacikkoordinat[4].X -= 1;
                            Game1.parcacikkoordinat[4].Y -= 2;
                        }
                        else if (Game1.parcacikzamanlayici <= 12)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 2;
                            Game1.parcacikkoordinat[1].Y += 2;
                            Game1.parcacikkoordinat[2].X -= 2;
                            Game1.parcacikkoordinat[2].Y += 2;
                            Game1.parcacikkoordinat[3].X += 2;
                            Game1.parcacikkoordinat[3].Y -= 1;
                            Game1.parcacikkoordinat[4].X -= 2;
                            Game1.parcacikkoordinat[4].Y -= 1;
                        }
                        else if (Game1.parcacikzamanlayici <= 18)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 1;
                            Game1.parcacikkoordinat[1].Y += 3;
                            Game1.parcacikkoordinat[2].X -= 1;
                            Game1.parcacikkoordinat[2].Y += 3;
                            Game1.parcacikkoordinat[3].X += 3;
                            Game1.parcacikkoordinat[3].Y -= 0;
                            Game1.parcacikkoordinat[4].X -= 3;
                            Game1.parcacikkoordinat[4].Y -= 0;
                        }
                        else if (Game1.parcacikzamanlayici <= 24)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 0;
                            Game1.parcacikkoordinat[1].Y += 4;
                            Game1.parcacikkoordinat[2].X -= 0;
                            Game1.parcacikkoordinat[2].Y += 4;
                            Game1.parcacikkoordinat[3].X += 3;
                            Game1.parcacikkoordinat[3].Y += 1;
                            Game1.parcacikkoordinat[4].X -= 3;
                            Game1.parcacikkoordinat[4].Y += 1;
                        }
                        else if (Game1.parcacikzamanlayici <= 30)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 0;
                            Game1.parcacikkoordinat[1].Y += 5;
                            Game1.parcacikkoordinat[2].X -= 0;
                            Game1.parcacikkoordinat[2].Y += 5;
                            Game1.parcacikkoordinat[3].X += 3;
                            Game1.parcacikkoordinat[3].Y += 2;
                            Game1.parcacikkoordinat[4].X -= 3;
                            Game1.parcacikkoordinat[4].Y += 2;
                        }
                        else if (Game1.parcacikzamanlayici <= 36)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 0;
                            Game1.parcacikkoordinat[1].Y += 5;
                            Game1.parcacikkoordinat[2].X -= 0;
                            Game1.parcacikkoordinat[2].Y += 5;
                            Game1.parcacikkoordinat[3].X += 3;
                            Game1.parcacikkoordinat[3].Y += 3;
                            Game1.parcacikkoordinat[4].X -= 3;
                            Game1.parcacikkoordinat[4].Y += 3;
                        }
                        else if (Game1.parcacikzamanlayici <= 42)
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 0;
                            Game1.parcacikkoordinat[1].Y += 5;
                            Game1.parcacikkoordinat[2].X -= 0;
                            Game1.parcacikkoordinat[2].Y += 5;
                            Game1.parcacikkoordinat[3].X += 2;
                            Game1.parcacikkoordinat[3].Y += 4;
                            Game1.parcacikkoordinat[4].X -= 2;
                            Game1.parcacikkoordinat[4].Y += 4;
                        }
                        else
                        {
                            Game1.parcacikkoordinat[0].Y += 5;
                            Game1.parcacikkoordinat[1].X += 0;
                            Game1.parcacikkoordinat[1].Y += 5;
                            Game1.parcacikkoordinat[2].X -= 0;
                            Game1.parcacikkoordinat[2].Y += 5;
                            Game1.parcacikkoordinat[3].X += 0;
                            Game1.parcacikkoordinat[3].Y += 5;
                            Game1.parcacikkoordinat[4].X -= 0;
                            Game1.parcacikkoordinat[4].Y += 5;
                        }
                    }
                    if (Game1.parcacikzamanlayici < 45)
                        Game1.parcacikzamanlayici++;
                    for (int a = 0; a < 5; a++)
                    {
                        if (Game1.parcacikkoordinat[a].Y > 460)
                            Game1.parcacikkoordinat[a].Y = 460;
                        if (Game1.parcacikkoordinat[a].X < 10)
                            Game1.parcacikkoordinat[a].X = 10;
                        else if (Game1.parcacikkoordinat[a].X > 620)
                            Game1.parcacikkoordinat[a].X = 620;
                    }
                }
            }
        }
    }
}
