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
    class Animation
    {
        public static void CreateAnimation()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.durum[0] == 0)
            {
                if (klavye.IsKeyDown(Keys.A))
                    Game1.yon[0] = SpriteEffects.FlipHorizontally;
                else if (klavye.IsKeyDown(Keys.D))
                    Game1.yon[0] = SpriteEffects.None;
            }
            if (Game1.durum[1] == 0)
            {
                if (klavye.IsKeyDown(Keys.Left))
                    Game1.yon[1] = SpriteEffects.FlipHorizontally;
                else if (klavye.IsKeyDown(Keys.Right))
                    Game1.yon[1] = SpriteEffects.None;
            }
            Game1.timer++;
            if (Game1.durum[0] == 0)
            {
                if (klavye.IsKeyDown(Keys.E) && klavye.IsKeyDown(Keys.S))
                {
                    if (Game1.koordinat[0].Y == 406)
                        Game1.animasyon[0] = 13;
                    else
                        Game1.animasyon[0] = 12;
                }
                else if (klavye.IsKeyDown(Keys.E))
                    Game1.animasyon[0] = 12;
                else if (klavye.IsKeyDown(Keys.H) && klavye.IsKeyDown(Keys.S))
                {
                    if (Game1.koordinat[0].Y == 406)
                        Game1.animasyon[0] = 11;
                    else
                        Game1.animasyon[0] = 10;
                }
                else if (klavye.IsKeyDown(Keys.H))
                    Game1.animasyon[0] = 10;
                else if (klavye.IsKeyDown(Keys.S))
                {
                    if (Game1.secilikarakter[0] == 4 && Game1.koordinat[0].Y < 406 && klavye.IsKeyDown(Keys.T))
                        Game1.animasyon[0] = 18;
                    else if (Game1.koordinat[0].Y == 406)
                        Game1.animasyon[0] = 9;
                    else
                        Game1.animasyon[0] = 8;
                }
            }
            if (Game1.durum[1] == 0)
            {
                if (klavye.IsKeyDown(Keys.NumPad1) && klavye.IsKeyDown(Keys.Down))
                {
                    if (Game1.koordinat[1].Y == 406)
                        Game1.animasyon[1] = 13;
                    else
                        Game1.animasyon[1] = 12;
                }
                else if (klavye.IsKeyDown(Keys.NumPad1))
                    Game1.animasyon[1] = 12;
                else if (klavye.IsKeyDown(Keys.NumPad3) && klavye.IsKeyDown(Keys.Down))
                {
                    if (Game1.koordinat[1].Y == 406)
                        Game1.animasyon[1] = 11;
                    else
                        Game1.animasyon[1] = 10;
                }
                else if (klavye.IsKeyDown(Keys.NumPad3))
                    Game1.animasyon[1] = 10;
                else if (klavye.IsKeyDown(Keys.Down))
                {
                    if (Game1.secilikarakter[1] == 4 && Game1.koordinat[1].Y < 406 && klavye.IsKeyDown(Keys.NumPad5))
                        Game1.animasyon[1] = 18;
                    else if (Game1.koordinat[1].Y == 406)
                        Game1.animasyon[1] = 9;
                    else
                        Game1.animasyon[1] = 8;
                }
            }
            if (Game1.timer >= 7)
            {
                Game1.selecteranimasyon++;
                if (Game1.selecteranimasyon >= 6)
                    Game1.selecteranimasyon = 0;
                Game1.timer = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (Game1.durum[i] == 0)
                    {
                        if (i == 0)
                        {
                            if (klavye.IsKeyDown(Keys.E) && klavye.IsKeyDown(Keys.S))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.E))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.H) && klavye.IsKeyDown(Keys.S))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.H))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.S))
                            {
                            }
                            else if (Game1.koordinat[0].Y < 406)
                            {
                                if (Game1.secilikarakter[0] == 4)
                                {
                                    if (klavye.IsKeyDown(Keys.T))
                                    {
                                        if (Game1.animasyon[0] < 16 || Game1.animasyon[0] > 19)
                                            Game1.animasyon[0] = 16;
                                        else
                                        {
                                            Game1.animasyon[0]++;
                                            if (Game1.animasyon[0] >= 20)
                                                Game1.animasyon[0] = 16;
                                        }
                                    }
                                    else
                                    {
                                        if (Game1.animasyon[0] < 4 || Game1.animasyon[0] > 7)
                                            Game1.animasyon[0] = 4;
                                        else
                                        {
                                            Game1.animasyon[0]++;
                                            if (Game1.animasyon[0] >= 8)
                                            {
                                                if (Game1.secilikarakter[0] == 5)
                                                    Game1.animasyon[0] = 6;
                                                else
                                                    Game1.animasyon[0] = 4;
                                            }
                                        }
                                    }
                                }
                                else
                                    Game1.animasyon[0] = 8;
                            }
                            else if (klavye.IsKeyDown(Keys.A) || klavye.IsKeyDown(Keys.D))
                            {
                                if (Game1.animasyon[0] < 4 || Game1.animasyon[0] > 7)
                                    Game1.animasyon[0] = 4;
                                else
                                {
                                    Game1.animasyon[0]++;
                                    if (Game1.animasyon[0] >= 8)
                                    {
                                        if (Game1.secilikarakter[0] == 5)
                                            Game1.animasyon[0] = 6;
                                        else
                                            Game1.animasyon[0] = 4;
                                    }
                                }
                            }
                            else
                            {
                                if (Game1.animasyon[0] > 3)
                                    Game1.animasyon[0] = 0;
                                else
                                {
                                    Game1.animasyon[0]++;
                                    if (Game1.animasyon[0] >= 4)
                                        Game1.animasyon[0] = 0;
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            if (klavye.IsKeyDown(Keys.NumPad1) && klavye.IsKeyDown(Keys.Down))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.NumPad1))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.NumPad3) && klavye.IsKeyDown(Keys.Down))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.NumPad3))
                            {
                            }
                            else if (klavye.IsKeyDown(Keys.Down))
                            {
                            }
                            else if (Game1.koordinat[1].Y < 406)
                            {
                                if (Game1.secilikarakter[1] == 4)
                                {
                                    if (klavye.IsKeyDown(Keys.NumPad5))
                                    {
                                        if (Game1.animasyon[1] < 16 || Game1.animasyon[1] > 19)
                                            Game1.animasyon[1] = 16;
                                        else
                                        {
                                            Game1.animasyon[1]++;
                                            if (Game1.animasyon[1] >= 20)
                                                Game1.animasyon[1] = 16;
                                        }
                                    }
                                    else
                                    {
                                        if (Game1.secilikarakter[1] == 4)
                                        {
                                            if (Game1.animasyon[1] < 4 || Game1.animasyon[1] > 7)
                                                Game1.animasyon[1] = 4;
                                            else
                                            {
                                                Game1.animasyon[1]++;
                                                if (Game1.animasyon[1] >= 8)
                                                {
                                                    if (Game1.secilikarakter[1] == 5)
                                                        Game1.animasyon[1] = 6;
                                                    else
                                                        Game1.animasyon[1] = 4;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                    Game1.animasyon[1] = 8;
                            }
                            else if (klavye.IsKeyDown(Keys.Left) || klavye.IsKeyDown(Keys.Right))
                            {
                                if (Game1.animasyon[1] < 4 || Game1.animasyon[1] > 7)
                                    Game1.animasyon[1] = 4;
                                else
                                {
                                    Game1.animasyon[1]++;
                                    if (Game1.animasyon[1] >= 8)
                                    {
                                        if (Game1.secilikarakter[1] == 5)
                                            Game1.animasyon[1] = 6;
                                        else
                                            Game1.animasyon[1] = 4;
                                    }
                                }
                            }
                            else
                            {
                                if (Game1.animasyon[1] > 3)
                                    Game1.animasyon[1] = 0;
                                else
                                {
                                    Game1.animasyon[1]++;
                                    if (Game1.animasyon[1] >= 4)
                                        Game1.animasyon[1] = 0;
                                }
                            }
                        }
                    }
                    else if (Game1.durum[i] == 1)
                        Game1.animasyon[i] = 14;
                    else if (Game1.durum[i] == 2)
                        Game1.animasyon[i] = 15;
                }
            }
        }
    }
}
