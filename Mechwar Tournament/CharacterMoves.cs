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
    class CharacterMoves
    {
        public static void Player1()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.H) && !klavye.IsKeyDown(Keys.E) && !(Game1.secilikarakter[0] == 5 && Game1.ELcharge))
            {
                if (Game1.oyuncubasildi[0])
                {
                    Game1.oyuncubasildi[0] = false;
                    for (int i = 0; i < 3; i++)
                    {
                        if (Game1.missilekoordinat[i] == new Vector2(-1000, -1000))
                        {
                            if (!klavye.IsKeyDown(Keys.S))
                            {
                                if (Game1.yon[0] == SpriteEffects.None)
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[0].X + Game1.robotattack[Game1.secilikarakter[0]].X, Game1.koordinat[0].Y + Game1.robotattack[Game1.secilikarakter[0]].Y);
                                    Game1.missileleft[i] = false;
                                }
                                else
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[0].X + 48 - Game1.robotattack[Game1.secilikarakter[0]].X, Game1.koordinat[0].Y + Game1.robotattack[Game1.secilikarakter[0]].Y);
                                    Game1.missileleft[i] = true;
                                }
                            }
                            else
                            {
                                if (Game1.yon[0] == SpriteEffects.None)
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[0].X + Game1.robotattack[Game1.secilikarakter[0]].X, Game1.robotboy[Game1.secilikarakter[0]] - Game1.robotduckboy[Game1.secilikarakter[0]] + Game1.koordinat[0].Y + Game1.robotattack[Game1.secilikarakter[0]].Y);
                                    Game1.missileleft[i] = false;
                                }
                                else
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[0].X + 48 - Game1.robotattack[Game1.secilikarakter[0]].X, Game1.robotboy[Game1.secilikarakter[0]] - Game1.robotduckboy[Game1.secilikarakter[0]] + Game1.koordinat[0].Y + Game1.robotattack[Game1.secilikarakter[0]].Y);
                                    Game1.missileleft[i] = true;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            else
                Game1.oyuncubasildi[0] = true;
            if (klavye.IsKeyDown(Keys.A) && (Game1.koordinat[0].Y < 406 || (!klavye.IsKeyDown(Keys.H) && !klavye.IsKeyDown(Keys.S) && !klavye.IsKeyDown(Keys.E))))
            {
                if (!((Game1.secilikarakter[0] == 0 || Game1.secilikarakter[0] == 1) && Game1.parametre2[0] > 10))
                {
                    if (Game1.secilikarakter[0] == 2)
                        Game1.koordinat[0].X -= 6;
                    else if (Game1.secilikarakter[0] == 3)
                        Game1.koordinat[0].X -= 3;
                    else
                        Game1.koordinat[0].X -= 4;
                    if (Game1.koordinat[0].X < 10)
                        Game1.koordinat[0].X = 10;
                }
            }
            else if (klavye.IsKeyDown(Keys.D) && (Game1.koordinat[0].Y < 406 || (!klavye.IsKeyDown(Keys.H) && !klavye.IsKeyDown(Keys.S) && !klavye.IsKeyDown(Keys.E))))
            {
                if (!((Game1.secilikarakter[0] == 0 || Game1.secilikarakter[0] == 1) && Game1.parametre2[0] > 10))
                {
                    if (Game1.secilikarakter[0] == 2)
                        Game1.koordinat[0].X += 6;
                    else if (Game1.secilikarakter[0] == 3)
                        Game1.koordinat[0].X += 3;
                    else
                        Game1.koordinat[0].X += 4;
                    if (Game1.koordinat[0].X > 630 - 48)
                        Game1.koordinat[0].X = 630 - 48;
                }
            }
            if (klavye.IsKeyDown(Keys.W))
            {
                if (Game1.secilikarakter[0] == 4)
                {
                    Game1.koordinat[0].Y -= 4;
                    if (Game1.koordinat[0].Y <= 2)
                        Game1.koordinat[0].Y = 2;
                }
                else if (Game1.koordinat[0].Y == 406)
                    Game1.ziplama[0] = 1;
            }
            else if (klavye.IsKeyDown(Keys.S) && Game1.secilikarakter[0] == 4)
            {
                Game1.koordinat[0].Y += 4;
                if (Game1.koordinat[0].Y >= 406)
                    Game1.koordinat[0].Y = 406;
            }
            if (Game1.ziplama[0] >= 1 && Game1.ziplama[0] <= 4)
                Game1.koordinat[0].Y -= 12;
            else if (Game1.ziplama[0] >= 5 && Game1.ziplama[0] <= 8)
                Game1.koordinat[0].Y -= 6;
            else if (Game1.ziplama[0] >= 9 && Game1.ziplama[0] <= 16)
                Game1.koordinat[0].Y -= 3;
            else if (Game1.ziplama[0] >= 17 && Game1.ziplama[0] <= 24)
                Game1.koordinat[0].Y += 3;
            else if (Game1.ziplama[0] >= 25 && Game1.ziplama[0] <= 28)
                Game1.koordinat[0].Y += 6;
            else if (Game1.ziplama[0] >= 29 && Game1.ziplama[0] <= 32)
                Game1.koordinat[0].Y += 12;
            else
                Game1.ziplama[0] = 0;
            if (Game1.ziplama[0] > 0)
                Game1.ziplama[0]++;
        }

        public static void Player2()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.NumPad3) && !klavye.IsKeyDown(Keys.NumPad1) && !(Game1.secilikarakter[1] == 5 && Game1.ELcharge))
            {
                if (Game1.oyuncubasildi[1])
                {
                    Game1.oyuncubasildi[1] = false;
                    for (int i = 3; i < 6; i++)
                    {
                        if (Game1.missilekoordinat[i] == new Vector2(-1000, -1000))
                        {
                            if (!klavye.IsKeyDown(Keys.Down))
                            {
                                if (Game1.yon[1] == SpriteEffects.None)
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[1].X + Game1.robotattack[Game1.secilikarakter[1]].X, Game1.koordinat[1].Y + Game1.robotattack[Game1.secilikarakter[1]].Y);
                                    Game1.missileleft[i] = false;
                                }
                                else
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[1].X + 48 - Game1.robotattack[Game1.secilikarakter[1]].X, Game1.koordinat[1].Y + Game1.robotattack[Game1.secilikarakter[1]].Y);
                                    Game1.missileleft[i] = true;
                                }
                            }
                            else
                            {
                                if (Game1.yon[1] == SpriteEffects.None)
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[1].X + Game1.robotattack[Game1.secilikarakter[1]].X, Game1.robotboy[Game1.secilikarakter[1]] - Game1.robotduckboy[Game1.secilikarakter[1]] + Game1.koordinat[1].Y + Game1.robotattack[Game1.secilikarakter[1]].Y);
                                    Game1.missileleft[i] = false;
                                }
                                else
                                {
                                    Game1.missilekoordinat[i] = new Vector2(Game1.koordinat[1].X + 48 - Game1.robotattack[Game1.secilikarakter[1]].X, Game1.robotboy[Game1.secilikarakter[1]] - Game1.robotduckboy[Game1.secilikarakter[1]] + Game1.koordinat[1].Y + Game1.robotattack[Game1.secilikarakter[1]].Y);
                                    Game1.missileleft[i] = true;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            else
                Game1.oyuncubasildi[1] = true;
            if (klavye.IsKeyDown(Keys.Left) && (Game1.koordinat[1].Y < 406 || (!klavye.IsKeyDown(Keys.NumPad3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.NumPad1))))
            {
                if (!((Game1.secilikarakter[1] == 0 || Game1.secilikarakter[1] == 1) && Game1.parametre2[1] > 10))
                {
                    if (Game1.secilikarakter[1] == 2)
                        Game1.koordinat[1].X -= 6;
                    else if (Game1.secilikarakter[1] == 3)
                        Game1.koordinat[1].X -= 3;
                    else
                        Game1.koordinat[1].X -= 4;
                    if (Game1.koordinat[1].X < 10)
                        Game1.koordinat[1].X = 10;
                }
            }
            else if (klavye.IsKeyDown(Keys.Right) && (Game1.koordinat[1].Y < 406 || (!klavye.IsKeyDown(Keys.NumPad3) && !klavye.IsKeyDown(Keys.Down) && !klavye.IsKeyDown(Keys.NumPad1))))
            {
                if (!((Game1.secilikarakter[1] == 0 || Game1.secilikarakter[1] == 1) && Game1.parametre2[1] > 10))
                {
                    if (Game1.secilikarakter[1] == 2)
                        Game1.koordinat[1].X += 6;
                    else if (Game1.secilikarakter[1] == 3)
                        Game1.koordinat[1].X += 3;
                    else
                        Game1.koordinat[1].X += 4;
                    if (Game1.koordinat[1].X > 630 - 48)
                        Game1.koordinat[1].X = 630 - 48;
                }
            }
            if (klavye.IsKeyDown(Keys.Up))
            {
                if (Game1.secilikarakter[1] == 4)
                {
                    Game1.koordinat[1].Y -= 4;
                    if (Game1.koordinat[1].Y <= 2)
                        Game1.koordinat[1].Y = 2;
                }
                else if (Game1.koordinat[1].Y == 406)
                    Game1.ziplama[1] = 1;
            }
            else if (klavye.IsKeyDown(Keys.Down) && Game1.secilikarakter[1] == 4)
            {
                Game1.koordinat[1].Y += 4;
                if (Game1.koordinat[1].Y >= 406)
                    Game1.koordinat[1].Y = 406;
            }
            if (Game1.ziplama[1] >= 1 && Game1.ziplama[1] <= 4)
                Game1.koordinat[1].Y -= 12;
            else if (Game1.ziplama[1] >= 5 && Game1.ziplama[1] <= 8)
                Game1.koordinat[1].Y -= 6;
            else if (Game1.ziplama[1] >= 9 && Game1.ziplama[1] <= 16)
                Game1.koordinat[1].Y -= 3;
            else if (Game1.ziplama[1] >= 17 && Game1.ziplama[1] <= 24)
                Game1.koordinat[1].Y += 3;
            else if (Game1.ziplama[1] >= 25 && Game1.ziplama[1] <= 28)
                Game1.koordinat[1].Y += 6;
            else if (Game1.ziplama[1] >= 29 && Game1.ziplama[1] <= 32)
                Game1.koordinat[1].Y += 12;
            else
                Game1.ziplama[1] = 0;
            if (Game1.ziplama[1] > 0)
                Game1.ziplama[1]++;
        }

        public static int i = 0;
        public static int[] C = new int[2];
        public static void Icebot()
        {
            KeyboardState klavye = Keyboard.GetState();
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 0)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        if (((i == 0 && klavye.IsKeyDown(Keys.H)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad3))) && Game1.durum[i] == 0 && !((klavye.IsKeyDown(Keys.T) && i == 0) || (klavye.IsKeyDown(Keys.NumPad5) && i == 1)))
                            Game1.parametre2[i] += 4;
                        else
                        {
                            if (Game1.parametre2[i] == 100)
                            {
                                Game1.animasyon[i] = 24;
                                if (Game1.yon[i] == SpriteEffects.None)
                                {
                                    Game1.IBchargeyon = SpriteEffects.None;
                                    Game1.IBchargekoordinat = new Vector2(Game1.koordinat[i].X + 44, Game1.koordinat[i].Y + 22);
                                }
                                else
                                {
                                    Game1.IBchargeyon = SpriteEffects.FlipHorizontally;
                                    Game1.IBchargekoordinat = new Vector2(Game1.koordinat[i].X - 12, Game1.koordinat[i].Y + 22);
                                }
                            }
                            Game1.parametre2[i] = 0;
                        }
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 3;
                            Game1.parametre3[i] += 2;
                            Game1.parametre4[i] += 1;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                            if (Game1.parametre3[i] >= 100)
                                Game1.parametre3[i] = 100;
                            if (Game1.parametre4[i] >= 100)
                                Game1.parametre4[i] = 100;
                        }
                    }
                    if (Game1.parametre2[i] > 30 && Game1.parametre2[i] % 8 <= 3)
                        Game1.animasyon[i] = 22;
                    else if (Game1.parametre2[i] > 30 && Game1.parametre2[i] % 8 >= 4)
                        Game1.animasyon[i] = 23;
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i] = 0;
                        Game1.parametre3[i]--;
                        Game1.parametre4[i] = 0;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre3[i] < 0)
                            Game1.parametre3[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                        Game1.parametre3[i] = 0;
                        Game1.parametre4[i] = 0;
                    }
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.animasyon[i] = 10;
                        if (Game1.yon[i] == SpriteEffects.None)
                        {
                            Game1.IBicekoordinat = new Vector2(Game1.koordinat[i].X + Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.IBiceleft = false;
                        }
                        else
                        {
                            Game1.IBicekoordinat = new Vector2(Game1.koordinat[i].X + 48 - Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.IBiceleft = true;
                        }
                    }
                    if (((i == 0 && klavye.IsKeyDown(Keys.Y)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad6))) && Game1.parametre3[i] == 100 && Game1.koordinat[i].Y == 406 && Game1.durum[i] == 0)
                    {
                        Game1.parametre3[i] = 0;
                        Game1.durum[i] = 5;
                    }
                    if (((i == 0 && klavye.IsKeyDown(Keys.T)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad5))) && Game1.parametre4[i] == 100 && Game1.koordinat[i].Y == 406 && Game1.durum[i] == 0 && !Game1.icearena)
                    {
                        Game1.parametre4[i] = 0;
                        Game1.durum[i] = 6;
                    }
                    if (Game1.durum[i] == 6)
                        HitDetection.SnowyPortal();
                    if (Game1.durum[i] == 5)
                        HitDetection.Iceball();
                    if (Game1.IBchargekoordinat != new Vector2(-1000, -1000))
                        HitDetection.ChargeIceFire();
                    if (Game1.IBicekoordinat != new Vector2(-1000, -1000))
                        HitDetection.Ice();
                }
            }
        }

        public static void Firebot()
        {
            KeyboardState klavye = Keyboard.GetState();
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 1)
                {
                    if (((klavye.IsKeyDown(Keys.NumPad5) && i == 1) || (klavye.IsKeyDown(Keys.T) && i == 0)) && Game1.koordinat[i].Y < 406 && Game1.durum[i] == 0)
                    {
                        if (Game1.animasyon[i] < 18)
                            Game1.animasyon[i] = 18;
                        Game1.ziplama[i] = 0;
                        Game1.koordinat[i].Y -= 4;
                        if (Game1.koordinat[i].Y < 10)
                            Game1.koordinat[i].Y = 10;
                    }
                    else
                    {
                        if (Game1.ziplama[i] == 0 && (Game1.durum[i] == 0 || Game1.durum[i] == 1) && Game1.koordinat[i].Y < 406)
                        {
                            Game1.koordinat[i].Y += 12;
                            if (Game1.koordinat[i].Y > 406)
                                Game1.koordinat[i].Y = 406;
                        }
                    }
                    C[i]++;
                    if (C[i] == 6)
                    {
                        if (((i == 0 && klavye.IsKeyDown(Keys.H)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad3))) && Game1.durum[i] == 0 && !((klavye.IsKeyDown(Keys.T) && i == 0) || (i == 1 && klavye.IsKeyDown(Keys.NumPad5) && i == 1)))
                            Game1.parametre2[i] += 4;
                        else
                        {
                            if (Game1.parametre2[i] == 100)
                            {
                                Game1.animasyon[i] = 24;
                                if (Game1.yon[i] == SpriteEffects.None)
                                {
                                    Game1.FBchargeyon = SpriteEffects.None;
                                    Game1.FBchargekoordinat = new Vector2(Game1.koordinat[i].X + 44, Game1.koordinat[i].Y + 22);
                                }
                                else
                                {
                                    Game1.FBchargeyon = SpriteEffects.FlipHorizontally;
                                    Game1.FBchargekoordinat = new Vector2(Game1.koordinat[i].X - 12, Game1.koordinat[i].Y + 22);
                                }
                            }
                            Game1.parametre2[i] = 0;
                        }
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 2;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                        }
                        if (((klavye.IsKeyDown(Keys.NumPad5) && i == 1) || (klavye.IsKeyDown(Keys.T) && i == 0)) && Game1.koordinat[i].Y < 406 && Game1.durum[i] == 0)
                        {
                            Game1.animasyon[i]++;
                            if (Game1.animasyon[i] >= 22)
                                Game1.animasyon[i] = 18;
                        }
                    }
                    if (Game1.parametre2[i] > 30 && Game1.parametre2[i] % 8 <= 3)
                        Game1.animasyon[i] = 22;
                    else if (Game1.parametre2[i] > 30 && Game1.parametre2[i] % 8 >= 4)
                        Game1.animasyon[i] = 23;
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i] = 0;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                    }
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.durum[i] = 5;
                        Game1.animasyon[i] = 16;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.Ground();
                    if (Game1.FBchargekoordinat != new Vector2(-1000, -1000))
                        HitDetection.ChargeIceFire();
                }
            }
        }
        //Parametre Süreleri:  ++: 10sn  += 2: 5sn  += 3: 3.33sn += 4: 2.5sn
        public static void Fullspeed()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 2)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 4;
                            Game1.parametre2[i] += 2;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i]--;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre2[i] < 0)
                            Game1.parametre2[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                    }
                    KeyboardState klavye = Keyboard.GetState();
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.animasyon[i] = 10;
                        if (Game1.yon[i] == SpriteEffects.None)
                        {
                            Game1.FSquickkoordinat = new Vector2(Game1.koordinat[i].X + Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.FSquickleft = false;
                        }
                        else
                        {
                            Game1.FSquickkoordinat = new Vector2(Game1.koordinat[i].X + 48 - Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.FSquickleft = true;
                        }
                    }
                    else if (((i == 0 && klavye.IsKeyDown(Keys.Y)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad6))) && Game1.parametre2[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre2[i] = 0;
                        Game1.durum[i] = 5;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.Slide();
                    if (Game1.FSquickkoordinat != new Vector2(-1000, -1000))
                        HitDetection.Quick();
                }
            }
        }

        public static void BigGuy()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 3)
                {
                    if (Game1.koordinat[i].Y < 406 && Game1.ziplama[i] == 0 && Game1.durum[i] != 6 && Game1.durum[i] != 22)
                    {
                        Game1.koordinat[i].Y += 12;
                        if (Game1.koordinat[i].Y > 406)
                            Game1.koordinat[i].Y = 406;
                    }
                    C[i]++;
                    if (C[i] == 6)
                    {
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 2;
                            Game1.parametre2[i] += 3;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i]--;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre2[i] < 0)
                            Game1.parametre2[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                    }
                    KeyboardState klavye = Keyboard.GetState();
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.durum[i] = 5;
                        Game1.animasyon[i] = 17;
                    }
                    else if (((i == 0 && klavye.IsKeyDown(Keys.Y)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad6))) && Game1.parametre2[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre2[i] = 0;
                        Game1.durum[i] = 6;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.MegaPunch();
                    else if (Game1.durum[i] == 6)
                        HitDetection.WreckingBall();
                }
            }
        }

        public static void MetalHawk()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 4)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 5;
                            Game1.parametre2[i] += 2;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i]--;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre2[i] < 0)
                            Game1.parametre2[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                    }
                    KeyboardState klavye = Keyboard.GetState();
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.durum[i] = 5;
                        Game1.animasyon[i] = 20;
                    }
                    else if (((i == 0 && klavye.IsKeyDown(Keys.Y)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad6))) && Game1.parametre2[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre2[i] = 0;
                        Game1.durum[i] = 6;
                        Game1.animasyon[i] = 20;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.Wing();
                    else if (Game1.durum[i] == 6)
                        HitDetection.Wind();
                }
            }
        }

        public static void Electro()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 5)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        if (Game1.ELcharge)
                        {
                            if (Game1.durum[i] == 1)
                                Game1.durum[i] = 0;
                            Game1.parametre3[i] -= 2;
                            if (Game1.parametre3[i] == 0)
                                Game1.ELcharge = false;
                            Random rnd = new Random();
                            if (Game1.animasyon[i] == 0 || Game1.animasyon[i] == 2)
                                Game1.animasyon[i] = 21;
                            else if (Game1.animasyon[i] == 1 || Game1.animasyon[i] == 3)
                                Game1.animasyon[i] = 22;
                            else if (Game1.animasyon[i] == 4)
                                Game1.animasyon[i] = 25;
                            else if (Game1.animasyon[i] == 5)
                                Game1.animasyon[i] = 24;
                            else if (Game1.animasyon[i] == 6)
                                Game1.animasyon[i] = 25;
                            else if (Game1.animasyon[i] == 7)
                                Game1.animasyon[i] = 26;
                            else if (Game1.animasyon[i] == 8)
                                Game1.animasyon[i] = rnd.Next(27, 29);
                            else if (Game1.animasyon[i] == 9)
                                Game1.animasyon[i] = rnd.Next(29, 31);
                            else
                                Game1.animasyon[i] = 22;
                            int j = 0;
                            if (i == 0)
                                j = 1;
                            if (Game1.koordinat[i].X + 40 > Game1.koordinat[j].X && Game1.koordinat[j].X + 40 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 40 > Game1.koordinat[j].Y && Game1.koordinat[j].Y + 40 > Game1.koordinat[i].Y)
                            {
                                Game1.animasyon[j] = 14;
                                Game1.saglik[j]--;
                            }
                        }
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 1;
                            Game1.parametre2[i] += 2;
                            if (!Game1.ELcharge)
                                Game1.parametre3[i] += 2;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                            if (Game1.parametre3[i] >= 100)
                                Game1.parametre3[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i]--;
                        Game1.parametre3[i] -= 2;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre2[i] < 0)
                            Game1.parametre2[i] = 0;
                        if (Game1.parametre3[i] < 0)
                            Game1.parametre3[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                        Game1.parametre3[i] = 0;
                    }
                    KeyboardState klavye = Keyboard.GetState();
                    if (Game1.ELwavekoordinat == new Vector2(-1000, -1000) && !Game1.ELcharge && ((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100 && Game1.durum[i] == 0)
                    {
                        Game1.animasyon[i] = 10;
                        Game1.parametre1[i] = 0;
                        if (Game1.yon[i] == SpriteEffects.None)
                        {
                            Game1.ELwavekoordinat = new Vector2(Game1.koordinat[i].X + Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.ELwaveyon = SpriteEffects.None;
                            Game1.ELwaveanimasyon = 0;
                        }
                        else
                        {
                            Game1.ELwavekoordinat = new Vector2(Game1.koordinat[i].X - 12 - Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.ELwaveyon = SpriteEffects.FlipHorizontally;
                            Game1.ELwaveanimasyon = 0;
                        }
                    }
                    else if (!Game1.ELcharge && ((i == 0 && klavye.IsKeyDown(Keys.Y)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad6))) && Game1.parametre2[i] == 100 && Game1.koordinat[i].Y == 406 && Game1.durum[i] == 0)
                    {
                        Game1.parametre2[i] = 0;
                        Game1.durum[i] = 5;
                        Game1.animasyon[i] = 16;
                    }
                    else if (((i == 0 && klavye.IsKeyDown(Keys.T)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad5))) && Game1.parametre3[i] == 100 && Game1.durum[i] == 0)
                    {
                        Game1.durum[i] = 6;
                        Game1.animasyon[i] = 18;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.Ground();
                    else if (Game1.durum[i] == 6)
                        HitDetection.ChargeElectric();
                    if (Game1.ELwavekoordinat != new Vector2(-1000, -1000))
                        HitDetection.Electrowave();
                }
            }
        }

        public static void Roboghost()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 6)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        C[i] = 0;
                        if (Game1.RGgorunmez)
                        {
                            Random rnd = new Random();
                            Game1.parametre1[i] -= rnd.Next(1, 3);
                            if (Game1.parametre1[i] <= 0)
                            {
                                Game1.parametre1[i] = 0;
                                Game1.RGgorunmez = false;
                            }
                        }
                        else if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i]++;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                        Game1.parametre1[i] = 0;
                    KeyboardState klavye = Keyboard.GetState();
                    if (((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100)
                    {
                        Game1.parametre2[i] = 99;
                        Game1.RGgorunmez = true;
                    }
                }
            }
        }

        public static void Runo()
        {
            for (i = 0; i < 2; i++)
            {
                if (Game1.secilikarakter[i] == 7)
                {
                    C[i]++;
                    if (C[i] == 6)
                    {
                        C[i] = 0;
                        if (Game1.durum[i] == 0)
                        {
                            Game1.parametre1[i] += 4;
                            Game1.parametre2[i] += 3;
                            if (Game1.parametre1[i] >= 100)
                                Game1.parametre1[i] = 100;
                            if (Game1.parametre2[i] >= 100)
                                Game1.parametre2[i] = 100;
                        }
                    }
                    if (Game1.durum[i] == 1 || Game1.durum[i] == 4 || Game1.durum[i] == 21)
                    {
                        Game1.parametre1[i]--;
                        Game1.parametre2[i]--;
                        if (Game1.parametre1[i] < 0)
                            Game1.parametre1[i] = 0;
                        if (Game1.parametre2[i] < 0)
                            Game1.parametre2[i] = 0;
                    }
                    else if (Game1.durum[i] == 2 || Game1.durum[i] == 3)
                    {
                        Game1.parametre1[i] = 0;
                        Game1.parametre2[i] = 0;
                    }
                    KeyboardState klavye = Keyboard.GetState();
                    if (Game1.durum[i] == 0 && ((i == 0 && klavye.IsKeyDown(Keys.G)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad2))) && Game1.parametre1[i] == 100 && Game1.RUechokoordinat == new Vector2(-1000, -1000))
                    {
                        Game1.parametre1[i] = 0;
                        Game1.animasyon[i] = 10;
                        if (Game1.yon[i] == SpriteEffects.None)
                        {
                            Game1.RUechokoordinat = new Vector2(Game1.koordinat[i].X + Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y - 6 + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.RUyon = SpriteEffects.None;
                        }
                        else
                        {
                            Game1.RUechokoordinat = new Vector2(Game1.koordinat[i].X + 28 - Game1.robotattack[Game1.secilikarakter[i]].X, Game1.koordinat[i].Y - 6 + Game1.robotattack[Game1.secilikarakter[i]].Y);
                            Game1.RUyon = SpriteEffects.FlipHorizontally;
                        }
                    }
                    else if (((i == 0 && klavye.IsKeyDown(Keys.T) && klavye.IsKeyDown(Keys.E)) || (i == 1 && klavye.IsKeyDown(Keys.NumPad5) && klavye.IsKeyDown(Keys.NumPad1))) && Game1.parametre2[i] == 100 && Game1.koordinat[i].Y == 406)
                    {
                        Game1.parametre2[i] = 0;
                        Game1.durum[i] = 5;
                    }
                    if (Game1.durum[i] == 5)
                        HitDetection.SoundWave();
                    else
                        Game1.RUsoundwavegenislik = 0;
                    if (Game1.RUechokoordinat != new Vector2(-1000, -1000))
                        HitDetection.Echo();
                }
            }
        }
    }
}
