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
    class HitDetection
    {
        public static void Normal()
        {
            KeyboardState klavye = Keyboard.GetState();
            for (int i = 3; i < 6; i++)
            {
                if ((Game1.durum[0] == 0 || Game1.durum[0] == 2) && !(Game1.secilikarakter[0] == 5 && Game1.ELcharge))
                {
                    if (klavye.IsKeyDown(Keys.E) && Game1.durum[0] == 0)
                    {
                        if (Game1.secilikarakter[0] == 7 || (Game1.missileleft[i] && Game1.yon[0] == SpriteEffects.None) || (!Game1.missileleft[i] && Game1.yon[0] == SpriteEffects.FlipHorizontally))
                        {
                            if (klavye.IsKeyDown(Keys.S))
                            {
                                if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[0].X + 32 - Game1.robotgenislik[Game1.secilikarakter[0]] && Game1.koordinat[0].X + 32 + Game1.robotgenislik[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[0].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[0]] && Game1.koordinat[0].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[0]] + Game1.robotkalkanboy[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].Y)
                                    Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            }
                            else
                            {
                                if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[0].X + 32 - Game1.robotgenislik[Game1.secilikarakter[0]] && Game1.koordinat[0].X + 32 + Game1.robotgenislik[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[0].Y + 64 - Game1.robotboy[Game1.secilikarakter[0]] && Game1.koordinat[0].Y + 64 - Game1.robotboy[Game1.secilikarakter[0]] + Game1.robotkalkanboy[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].Y)
                                    Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            }
                        }
                    }
                    if (klavye.IsKeyDown(Keys.S) && Game1.durum[0] == 0)
                    {
                        if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[0].X + 32 - Game1.robotgenislik[Game1.secilikarakter[0]] && Game1.koordinat[0].X + 32 + Game1.robotgenislik[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[0].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[0]] && Game1.koordinat[0].Y + 64 >= Game1.missilekoordinat[i].Y)
                        {
                            Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            Game1.durum[0] = 1;
                            Game1.saglik[0] -= 7;
                        }
                    }
                    else
                    {
                        if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[0].X + 32 - Game1.robotgenislik[Game1.secilikarakter[0]] && Game1.koordinat[0].X + 32 + Game1.robotgenislik[Game1.secilikarakter[0]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[0].Y + 64 - Game1.robotboy[Game1.secilikarakter[0]] && Game1.koordinat[0].Y + 64 >= Game1.missilekoordinat[i].Y)
                        {
                            Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            Game1.durum[0] = 1;
                            Game1.saglik[0] -= 7;
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if ((Game1.durum[1] == 0 || Game1.durum[1] == 2) && !(Game1.secilikarakter[0] == 5 && Game1.ELcharge))
                {
                    if (klavye.IsKeyDown(Keys.NumPad1) && Game1.durum[1] == 0)
                    {
                        if (Game1.secilikarakter[1] == 7 || (Game1.missileleft[i] && Game1.yon[1] == SpriteEffects.None) || (!Game1.missileleft[i] && Game1.yon[1] == SpriteEffects.FlipHorizontally))
                        {
                            if (klavye.IsKeyDown(Keys.Down))
                            {
                                if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[1].X + 32 - Game1.robotgenislik[Game1.secilikarakter[1]] && Game1.koordinat[1].X + 32 + Game1.robotgenislik[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 >= Game1.koordinat[1].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[1]] && Game1.koordinat[1].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[1]] + Game1.robotkalkanboy[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].Y)
                                    Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            }
                            else
                            {
                                if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[1].X + 32 - Game1.robotgenislik[Game1.secilikarakter[1]] && Game1.koordinat[1].X + 32 + Game1.robotgenislik[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 >= Game1.koordinat[1].Y + 64 - Game1.robotboy[Game1.secilikarakter[1]] && Game1.koordinat[1].Y + 64 - Game1.robotboy[Game1.secilikarakter[1]] + Game1.robotkalkanboy[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].Y)
                                    Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            }
                        }
                    }
                    if (klavye.IsKeyDown(Keys.Down) && Game1.durum[1] == 0)
                    {
                        if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[1].X + 32 - Game1.robotgenislik[Game1.secilikarakter[1]] && Game1.koordinat[1].X + 32 + Game1.robotgenislik[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[1].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[1]] && Game1.koordinat[1].Y + 64 >= Game1.missilekoordinat[i].Y)
                        {
                            Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            Game1.durum[1] = 1;
                            Game1.saglik[1] -= 7;
                        }
                    }
                    else
                    {
                        if (Game1.missilekoordinat[i].X + 8 >= Game1.koordinat[1].X + 32 - Game1.robotgenislik[Game1.secilikarakter[1]] && Game1.koordinat[1].X + 32 + Game1.robotgenislik[Game1.secilikarakter[1]] >= Game1.missilekoordinat[i].X && Game1.missilekoordinat[i].Y + 8 > Game1.koordinat[1].Y + 64 - Game1.robotboy[Game1.secilikarakter[1]] && Game1.koordinat[1].Y + 64 >= Game1.missilekoordinat[i].Y)
                        {
                            Game1.missilekoordinat[i] = new Vector2(-1000, -1000);
                            Game1.durum[1] = 1;
                            Game1.saglik[1] -= 7;
                        }
                    }
                }
            }
        }

        public static void Ice()
        {
            KeyboardState klavye = Keyboard.GetState();
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.IBiceleft)
            {
                Game1.IBicekoordinat.X -= 6;
                if (Game1.IBicekoordinat.X < 0)
                    Game1.IBicekoordinat = new Vector2(-1000, -1000);
            }
            else
            {
                Game1.IBicekoordinat.X += 6;
                if (Game1.IBicekoordinat.X < 0)
                    Game1.IBicekoordinat = new Vector2(-1000, -1000);
            }
            if (Game1.durum[i] != 1 && Game1.durum[i] != 3)
            {
                if ((klavye.IsKeyDown(Keys.S) && i == 0) || (klavye.IsKeyDown(Keys.Down) && i == 1))
                {
                    if (Game1.IBicekoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.IBicekoordinat.X && Game1.IBicekoordinat.Y + 8 > Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.IBicekoordinat.Y)
                    {
                        Game1.IBicekoordinat = new Vector2(-1000, -1000);
                        Game1.durum[i] = 2;
                    }
                }
                else
                {
                    if (Game1.IBicekoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.IBicekoordinat.X && Game1.IBicekoordinat.Y + 8 > Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.IBicekoordinat.Y)
                    {
                        Game1.IBicekoordinat = new Vector2(-1000, -1000);
                        Game1.durum[i] = 2;
                    }
                }
            }
        }

        public static void Quick()
        {
            KeyboardState klavye = Keyboard.GetState();
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.FSquickleft)
            {
                Game1.FSquickkoordinat.X -= 12;
                if (Game1.FSquickkoordinat.X < 0)
                    Game1.FSquickkoordinat = new Vector2(-1000, -1000);
            }
            else
            {
                Game1.FSquickkoordinat.X += 12;
                if (Game1.FSquickkoordinat.X < 0)
                    Game1.FSquickkoordinat = new Vector2(-1000, -1000);
            }
            if (Game1.durum[i] == 0)
            {
                if ((klavye.IsKeyDown(Keys.NumPad1) && i == 1) || (i == 0 && klavye.IsKeyDown(Keys.E)))
                {
                    if (Game1.secilikarakter[i] == 7 || (Game1.FSquickleft && Game1.yon[i] == SpriteEffects.None) || (!Game1.FSquickleft && Game1.yon[i] == SpriteEffects.FlipHorizontally))
                    {
                        if ((klavye.IsKeyDown(Keys.S) && i == 0) && (klavye.IsKeyDown(Keys.Down) && i == 1))
                        {
                            if (Game1.FSquickkoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.X && Game1.FSquickkoordinat.Y + 8 >= Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] + Game1.robotkalkanboy[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.Y)
                                Game1.FSquickkoordinat = new Vector2(-1000, -1000);
                        }
                        else
                        {
                            if (Game1.FSquickkoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.X && Game1.FSquickkoordinat.Y + 8 >= Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] + Game1.robotkalkanboy[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.Y)
                                Game1.FSquickkoordinat = new Vector2(-1000, -1000);
                        }
                    }
                }
                if ((klavye.IsKeyDown(Keys.S) && i == 0) || (klavye.IsKeyDown(Keys.Down) && i == 1))
                {
                    if (Game1.FSquickkoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.X && Game1.FSquickkoordinat.Y + 8 > Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.FSquickkoordinat.Y)
                    {
                        Game1.FSquickkoordinat = new Vector2(-1000, -1000);
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 7;
                    }
                }
                else
                {
                    if (Game1.FSquickkoordinat.X + 8 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FSquickkoordinat.X && Game1.FSquickkoordinat.Y + 8 > Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.FSquickkoordinat.Y)
                    {
                        Game1.FSquickkoordinat = new Vector2(-1000, -1000);
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 7;
                    }
                }
            }
        }

        public static int[] C = new int[2];
        public static void ChargeIceFire()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (Game1.secilikarakter[CharacterMoves.i] == 0)
            {
                if (Game1.IBchargeyon == SpriteEffects.None)
                {
                    Game1.IBchargekoordinat.X += 8;
                    if (Game1.IBchargekoordinat.X >= 700)
                        Game1.IBchargekoordinat = new Vector2(-1000, -1000);
                }
                else
                {
                    Game1.IBchargekoordinat.X -= 8;
                    if (Game1.IBchargekoordinat.X <= -100)
                        Game1.IBchargekoordinat = new Vector2(-1000, -1000);
                }
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.durum[i] != 1 && Game1.durum[i] != 3)
                {
                    if ((klavye.IsKeyDown(Keys.S) && i == 0) && (klavye.IsKeyDown(Keys.Down) && i == 1))
                    {
                        if (Game1.IBchargekoordinat.X + 32 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.IBchargekoordinat.X && Game1.IBchargekoordinat.Y + 32 > Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.IBchargekoordinat.Y)
                        {
                            Game1.IBchargekoordinat = new Vector2(-1000, -1000);
                            Game1.durum[i] = 1;
                            Game1.saglik[i] -= 17;
                        }
                    }
                    else
                    {
                        if (Game1.IBchargekoordinat.X + 32 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.IBchargekoordinat.X && Game1.IBchargekoordinat.Y + 32 > Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.IBchargekoordinat.Y)
                        {
                            Game1.IBchargekoordinat = new Vector2(-1000, -1000);
                            Game1.durum[i] = 1;
                            Game1.saglik[i] -= 17;
                        }
                    }
                }
            }
            else
            {
                C[CharacterMoves.i]++;
                if (C[CharacterMoves.i] >= 7)
                {
                    C[CharacterMoves.i] = 0;
                    Game1.FBanimasyon++;
                    if (Game1.FBanimasyon >= 4)
                        Game1.FBanimasyon = 0;
                }
                if (Game1.FBchargeyon == SpriteEffects.None)
                {
                    Game1.FBchargekoordinat.X += 8;
                    if (Game1.FBchargekoordinat.X >= 700)
                        Game1.FBchargekoordinat = new Vector2(-1000, -1000);
                }
                else
                {
                    Game1.FBchargekoordinat.X -= 8;
                    if (Game1.FBchargekoordinat.X <= -100)
                        Game1.FBchargekoordinat = new Vector2(-1000, -1000);
                }
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.durum[i] != 1 && Game1.durum[i] != 3)
                {
                    if ((klavye.IsKeyDown(Keys.S) && i == 0) || (klavye.IsKeyDown(Keys.Down) && i == 1))
                    {
                        if (Game1.FBchargekoordinat.X + 32 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FBchargekoordinat.X && Game1.FBchargekoordinat.Y + 32 > Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.FBchargekoordinat.Y)
                        {
                            Game1.FBchargekoordinat = new Vector2(-1000, -1000);
                            Game1.durum[i] = 1;
                            Game1.saglik[i] -= 21;
                        }
                    }
                    else
                    {
                        if (Game1.FBchargekoordinat.X + 32 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.FBchargekoordinat.X && Game1.FBchargekoordinat.Y + 32 > Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.FBchargekoordinat.Y)
                        {
                            Game1.FBchargekoordinat = new Vector2(-1000, -1000);
                            Game1.durum[i] = 1;
                            Game1.saglik[i] -= 21;
                        }
                    }
                }
            }
        }

        public static void Wind()
        {
            Game1.MHtimer++;
            if (Game1.MHtimer >= 7)
            {
                Game1.MHruzgaranimasyon++;
                if (Game1.MHruzgaranimasyon >= 6)
                {
                    Game1.MHruzgaranimasyon = 0;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (!(Game1.secilikarakter[i] == 5 && Game1.ELcharge) && Game1.MHruzgaranimasyon == 5 && Game1.durum[i] == 0)
            {
                if (Game1.yon[CharacterMoves.i] == SpriteEffects.None && Game1.koordinat[i].X - 200 <= Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X < Game1.koordinat[i].X)
                {
                    Game1.yon[i] = SpriteEffects.FlipHorizontally;
                    Game1.durum[i] = 21;
                }
                else if (Game1.yon[CharacterMoves.i] == SpriteEffects.FlipHorizontally && Game1.koordinat[CharacterMoves.i].X - 200 <= Game1.koordinat[i].X && Game1.koordinat[CharacterMoves.i].X > Game1.koordinat[i].X)
                {
                    Game1.yon[i] = SpriteEffects.None;
                    Game1.durum[i] = 21;
                }
            }
        }

        public static int chargertimer = 0;
        public static void ChargeElectric()
        {
            chargertimer++;
            if (chargertimer >= 10 && Game1.animasyon[CharacterMoves.i] == 19)
            {
                chargertimer = 0;
                Game1.animasyon[CharacterMoves.i] = 20;
            }
            else if (chargertimer >= 10 && Game1.animasyon[CharacterMoves.i] == 20)
            {
                chargertimer = 0;
                Game1.durum[CharacterMoves.i] = 0;
                Game1.ELcharge = true;
            }
            else if (chargertimer >= 30 && Game1.animasyon[CharacterMoves.i] == 18)
            {
                chargertimer = 0;
                Game1.animasyon[CharacterMoves.i] = 19;
            }
        }

        public static int timer = 0;
        public static int animasyon = 0;
        public static void Ground()
        {
            timer++;
            if (timer >= 3)
            {
                timer = 0;
                if (Game1.animasyon[CharacterMoves.i] == 17)
                    animasyon++;
                else
                    Game1.animasyon[CharacterMoves.i] = 17;
                if (animasyon >= 10)
                {
                    animasyon = 0;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            if (Game1.secilikarakter[CharacterMoves.i] == 5)
            {
                if (animasyon >= 2)
                {
                    int i = 0;
                    if (CharacterMoves.i == 0)
                        i = 1;
                    if (Game1.koordinat[i].Y == 406 && Game1.durum[i] != 1 && Game1.durum[i] != 3)
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 7;
                    }
                }
            }
            else if (animasyon >= 3 && animasyon <= 8)
            {
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.koordinat[i].Y > 360 && Game1.durum[i] != 1 && Game1.durum[i] != 3)
                {
                    Game1.durum[i] = 1;
                    Game1.saglik[i] -= 9;
                }
            }
        }

        public static void SnowyPortal()
        {
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.durum[i] != 3)
                Game1.durum[i] = 582;
            Game1.animasyon[CharacterMoves.i] = 16;
            if (!Game1.icearena)
            {
                if (Game1.IBsahne.R > 0)
                {
                    Game1.IBsahne.R -= 10;
                    Game1.IBsahne.G -= 10;
                    if (Game1.IBsahne.R == 5)
                    {
                        Game1.IBsahne.R = 0;
                        Game1.IBsahne.G = 0;
                    }
                }
                else if (Game1.IBsahne.B > 0)
                    Game1.IBsahne.B -= 5;
                else
                    Game1.icearena = true;
            }
            else
            {
                if (Game1.IBsahne.R == 255)
                {
                    Game1.durum[i] = 0;
                    Game1.durum[CharacterMoves.i] = 0;
                }
                else
                {
                    Game1.IBsahne.R += 5;
                    Game1.IBsahne.G += 5;
                    Game1.IBsahne.B += 5;
                }
            }   
        }

        public static void Echo()
        {
            if (Game1.RUyon == SpriteEffects.None)
            {
                Game1.RUechokoordinat.X += 7;
                if (Game1.RUechokoordinat.X >= 610)
                {
                    Game1.RUechocarpismiktari++;
                    Game1.RUyon = SpriteEffects.FlipHorizontally;
                }
            }
            else
            {
                Game1.RUechokoordinat.X -= 7;
                if (Game1.RUechokoordinat.X <= 10)
                {
                    Game1.RUechocarpismiktari++;
                    Game1.RUyon = SpriteEffects.None;
                }
            }
            if (Game1.red)
                Game1.RUechocarpismiktari = 0;
            if (Game1.RUechocarpismiktari >= 3)
            {
                Game1.RUechocarpismiktari = 0;
                Game1.RUechokoordinat = new Vector2(-1000, -1000);
            }
            KeyboardState klavye = Keyboard.GetState();
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.durum[i] == 0)
            {
                if ((klavye.IsKeyDown(Keys.NumPad1) && i == 1) || (i == 0 && klavye.IsKeyDown(Keys.E)))
                {
                    if ((Game1.RUyon == SpriteEffects.FlipHorizontally && Game1.yon[i] == SpriteEffects.None) || (Game1.RUyon == SpriteEffects.None && Game1.yon[i] == SpriteEffects.FlipHorizontally))
                    {
                        if ((klavye.IsKeyDown(Keys.S) && i == 0) || (klavye.IsKeyDown(Keys.Down) && i == 1))
                        {
                            if (Game1.RUechokoordinat.X + 20 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.X && Game1.RUechokoordinat.Y + 20 >= Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] + Game1.robotkalkanboy[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.Y)
                            {
                                Game1.RUechocarpismiktari++;
                                if (Game1.RUechocarpismiktari >= 3)
                                    Game1.RUechokoordinat = new Vector2(-1000, -1000);
                                if (Game1.RUyon == SpriteEffects.None)
                                {
                                    Game1.RUyon = SpriteEffects.FlipHorizontally;
                                    Game1.RUechokoordinat.X -= 7;
                                }
                                else
                                {
                                    Game1.RUyon = SpriteEffects.None;
                                    Game1.RUechokoordinat.X += 7;
                                }
                            }
                        }
                        else
                        {
                            if (Game1.RUechokoordinat.X + 20 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.X && Game1.RUechokoordinat.Y + 20 >= Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] + Game1.robotkalkanboy[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.Y)
                            {
                                Game1.RUechocarpismiktari++;
                                if (Game1.RUechocarpismiktari >= 3)
                                    Game1.RUechokoordinat = new Vector2(-1000, -1000);
                                if (Game1.RUyon == SpriteEffects.None)
                                {
                                    Game1.RUyon = SpriteEffects.FlipHorizontally;
                                    Game1.RUechokoordinat.X -= 7;
                                }
                                else
                                {
                                    Game1.RUyon = SpriteEffects.None;
                                    Game1.RUechokoordinat.X += 7;
                                }
                            }
                        }
                    }
                }
                if ((klavye.IsKeyDown(Keys.S) && i == 0) || (klavye.IsKeyDown(Keys.Down) && i == 1))
                {
                    if (Game1.RUechokoordinat.X + 20 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.X && Game1.RUechokoordinat.Y + 20 > Game1.koordinat[i].Y + 64 - Game1.robotduckboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.RUechokoordinat.Y)
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 9;
                    }
                }
                else
                {
                    if (Game1.RUechokoordinat.X + 20 >= Game1.koordinat[i].X + 32 - Game1.robotgenislik[Game1.secilikarakter[i]] && Game1.koordinat[i].X + 32 + Game1.robotgenislik[Game1.secilikarakter[i]] >= Game1.RUechokoordinat.X && Game1.RUechokoordinat.Y + 20 > Game1.koordinat[i].Y + 64 - Game1.robotboy[Game1.secilikarakter[i]] && Game1.koordinat[i].Y + 64 >= Game1.RUechokoordinat.Y)
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 9;
                    }
                }
            }
        }

        public static void SoundWave()
        {
            Game1.animasyon[CharacterMoves.i] = 16;
            Game1.RUsoundwavegenislik += 6;
            if (Game1.RUsoundwavegenislik > 640)
            {
                Game1.RUsoundwavegenislik = 0;
                Game1.durum[CharacterMoves.i] = 0;
            }
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (!(Game1.secilikarakter[i] == 5 && Game1.ELcharge) && Game1.koordinat[i].X > Game1.koordinat[CharacterMoves.i].X + 24 - Game1.RUsoundwavegenislik && Game1.koordinat[CharacterMoves.i].X + 24 + Game1.RUsoundwavegenislik > Game1.koordinat[i].X && Game1.koordinat[i].Y > Game1.koordinat[CharacterMoves.i].Y + 36 - Game1.RUsoundwavegenislik && Game1.koordinat[CharacterMoves.i].Y + 36 + Game1.RUsoundwavegenislik > Game1.koordinat[i].Y && Game1.durum[i] != 1 && Game1.durum[i] != 3)
            {
                if (Game1.animasyon[i] == 12 || Game1.animasyon[i] == 13)
                {
                    if (Game1.yon[i] == SpriteEffects.None && Game1.koordinat[i].X < Game1.koordinat[CharacterMoves.i].X)
                    {
                    }
                    else if (Game1.yon[i] == SpriteEffects.FlipHorizontally && Game1.koordinat[i].X > Game1.koordinat[CharacterMoves.i].X)
                    {
                    }
                    else
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 9;
                    }
                }
                else
                {
                    Game1.durum[i] = 1;
                    Game1.saglik[i] -= 9;
                }
            }
        }

        public static int wawer = 0;
        public static void Electrowave()
        {
            wawer++;
            if (wawer >= 7)
            {
                wawer = 0;
                if (Game1.ELwaveanimasyon == 0)
                {
                    Game1.ELwaveanimasyon = 1;
                    if (Game1.ELwaveyon == SpriteEffects.None)
                        Game1.ELwavekoordinat.X += 60;
                    else
                        Game1.ELwavekoordinat.X -= 60;
                }
                else if (Game1.ELwaveanimasyon == 1)
                {
                    Game1.ELwaveanimasyon = 2;
                    if (Game1.ELwaveyon == SpriteEffects.None)
                        Game1.ELwavekoordinat.X += 60;
                    else
                        Game1.ELwavekoordinat.X -= 60;
                    Game1.ELwavekoordinat.Y -= 60;
                }
                else if (Game1.ELwaveanimasyon == 2)
                {
                    Game1.ELwaveanimasyon = 3;
                    if (Game1.ELwaveyon == SpriteEffects.None)
                        Game1.ELwavekoordinat.X += 60;
                    else
                        Game1.ELwavekoordinat.X -= 60;
                }
                else if (Game1.ELwaveanimasyon == 3)
                {
                    Game1.ELwaveanimasyon = 0;
                    if (Game1.ELwaveyon == SpriteEffects.None)
                        Game1.ELwavekoordinat.X += 60;
                    else
                        Game1.ELwavekoordinat.X -= 60;
                    Game1.ELwavekoordinat.Y += 60;
                }
                if (Game1.ELwavekoordinat.X <= -60 || Game1.ELwavekoordinat.X >= 700)
                    Game1.ELwavekoordinat = new Vector2(-1000, -1000);
            }
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            Color[] arkaplanRAR = new Color[1];
            bool breaker = false;
            for (int a = 0; a < 900; a++)
            {
                Game1.texture.GetData<Color>(0, new Rectangle((Game1.ELwaveanimasyon * 60) + (2 * (a % 30)), 2 * (a / 30), 1, 1), arkaplanRAR, 0, 1);
                if (Game1.durum[i] != 1 && arkaplanRAR[0] != new Color(255, 0, 255) && arkaplanRAR[0] != new Color(255, 242, 0) && Game1.koordinat[i].X + 40 > Game1.ELwavekoordinat.X + (2 * (a % 30)) && Game1.ELwavekoordinat.X + (2 * (a % 30)) + 1 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 40 > Game1.ELwavekoordinat.Y + (2 * (a / 30)) && Game1.ELwavekoordinat.Y + (2 * (a / 30)) + 1 > Game1.koordinat[i].Y)
                {
                    Game1.durum[i] = 1;
                    Game1.saglik[i] -= 14;
                    breaker = true;
                }
            }
        }

        public static void Wing()
        {
            Game1.MHtimer++;
            if (Game1.MHtimer >= 7)
            {
                Game1.MHtimer = 0;
                Game1.animasyon[CharacterMoves.i]++;
                if (Game1.animasyon[CharacterMoves.i] >= 22)
                {
                    Game1.animasyon[CharacterMoves.i] = 0;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            if (Game1.animasyon[CharacterMoves.i] == 21)
            {
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.yon[CharacterMoves.i] == SpriteEffects.FlipHorizontally)
                {
                    if (Game1.durum[i] != 3 && Game1.koordinat[i].X + 74 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 48 > Game1.koordinat[i].X + 62 && Game1.koordinat[i].Y + 48 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 48 > Game1.koordinat[i].Y && Game1.durum[i] != 1)
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 12;
                    }
                }
                else
                {
                    if (Game1.durum[i] != 3 && Game1.koordinat[i].X + 2 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 48 > Game1.koordinat[i].X - 10 && Game1.koordinat[i].Y + 48 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 48 > Game1.koordinat[i].Y && Game1.durum[i] != 1)
                    {
                        Game1.durum[i] = 1;
                        Game1.saglik[i] -= 12;
                    }
                }
            }
        }

        public static void WreckingBall()
        {
            Game1.BGziplama++;
            Game1.animasyon[CharacterMoves.i] = 16;
            if (Game1.BGziplama <= 6)
                Game1.koordinat[CharacterMoves.i].Y -= 24;
            else if (Game1.BGziplama <= 12)
                Game1.koordinat[CharacterMoves.i].Y -= 12;
            else if (Game1.BGziplama <= 24)
                Game1.koordinat[CharacterMoves.i].Y -= 6;
            else if (Game1.BGziplama <= 36)
                Game1.koordinat[CharacterMoves.i].Y += 6;
            else if (Game1.BGziplama <= 42)
                Game1.koordinat[CharacterMoves.i].Y += 12;
            else if (Game1.BGziplama <= 48)
                Game1.koordinat[CharacterMoves.i].Y += 24;
            else
            {
                Game1.BGziplama = 0;
                Game1.durum[CharacterMoves.i] = 0;
            }
            if (Game1.yon[CharacterMoves.i] == SpriteEffects.None)
            {
                Game1.koordinat[CharacterMoves.i].X += 10;
                if (Game1.koordinat[CharacterMoves.i].X >= 630 - 48)
                    Game1.yon[CharacterMoves.i] = SpriteEffects.FlipHorizontally;
            }
            else
            {
                Game1.koordinat[CharacterMoves.i].X -= 10;
                if (Game1.koordinat[CharacterMoves.i].X <= 10)
                    Game1.yon[CharacterMoves.i] = SpriteEffects.None;
            }
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.koordinat[i].X + 48 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 48 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 48 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 48 > Game1.koordinat[i].Y && Game1.durum[i] != 1 && Game1.durum[i] != 3)
            {
                Game1.durum[i] = 1;
                Game1.saglik[i] -= 25;
            }
        }

        public static void MegaPunch()
        {
            Game1.BGtimer++;
            if (Game1.BGtimer == 3)
            {
                if (Game1.animasyon[CharacterMoves.i] < 19)
                {
                    Game1.BGtimer = 0;
                    Game1.animasyon[CharacterMoves.i]++;
                }
                else
                    Game1.animasyon[CharacterMoves.i] = 19;
            }
            else if (Game1.BGtimer == 10)
            {
                Game1.BGtimer = 0;
                if (Game1.animasyon[CharacterMoves.i] == 19)
                {
                    Game1.animasyon[CharacterMoves.i] = 0;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            if (Game1.animasyon[CharacterMoves.i] > 17)
            {
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.yon[CharacterMoves.i] == SpriteEffects.FlipHorizontally)
                {
                    if (Game1.durum[i] != 4 && Game1.koordinat[i].X + 74 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 48 > Game1.koordinat[i].X + 62 && Game1.koordinat[i].Y + 48 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 48 > Game1.koordinat[i].Y && Game1.durum[i] != 1)
                    {
                        if (Game1.secilikarakter[i] == 5 && Game1.ELcharge)
                        {
                            Game1.koordinat[i].X -= 20;
                            Game1.saglik[i] -= 15;
                        }
                        else if (Game1.durum[i] == 3)
                        {
                            Game1.koordinat[i].X -= 20;
                            if (Game1.koordinat[i].X < 10)
                                Game1.koordinat[i].X = 10;
                        }
                        else
                        {
                            Game1.durum[i] = 4;
                            Game1.saglik[i] -= 24;
                            Game1.yon[i] = SpriteEffects.None;
                        }
                    }
                }
                else
                {
                    if (Game1.durum[i] != 4 && Game1.koordinat[i].X + 2 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 48 > Game1.koordinat[i].X - 10 && Game1.koordinat[i].Y + 48 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 48 > Game1.koordinat[i].Y && Game1.durum[i] != 1)
                    {
                        if (Game1.secilikarakter[i] == 5 && Game1.ELcharge)
                        {
                            Game1.koordinat[i].X += 20;
                            Game1.saglik[i] -= 15;
                        }
                        else if (Game1.durum[i] == 3)
                        {
                            Game1.koordinat[i].X += 20;
                            if (Game1.koordinat[i].X > 630 - 48)
                                Game1.koordinat[i].X = 630 - 48;
                        }
                        else
                        {
                            Game1.durum[i] = 4;
                            Game1.saglik[i] -= 24;
                            Game1.yon[i] = SpriteEffects.FlipHorizontally;
                        }
                    }
                }
            }
        }

        public static void MegaDayakYemis()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Game1.durum[i] == 4)
                {
                    Game1.animasyon[i] = 14;
                    if (Game1.yon[i] == SpriteEffects.None)
                    {
                        Game1.koordinat[i].X -= 16;
                        if (Game1.koordinat[i].X <= 10)
                        {
                            Game1.saglik[i] -= 24;
                            Game1.durum[i] = 1;
                            Game1.koordinat[i].X = 10;
                        }
                    }
                    else
                    {
                        Game1.koordinat[i].X += 16;
                        if (Game1.koordinat[i].X >= 630 - 48)
                        {
                            Game1.saglik[i] -= 24;
                            Game1.durum[i] = 1;
                            Game1.koordinat[i].X = 630 - 48;
                        }
                    }
                }
            }
        }

        public static void RuzgarYuzumeVuruyor()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Game1.durum[i] == 21)
                {
                    Game1.animasyon[i] = 14;
                    if (Game1.yon[i] == SpriteEffects.None)
                    {
                        Game1.koordinat[i].X -= 10;
                        if (Game1.koordinat[i].X <= 10)
                        {
                            Game1.saglik[i] -= 11;
                            Game1.durum[i] = 1;
                            Game1.koordinat[i].X = 10;
                        }
                    }
                    else
                    {
                        Game1.koordinat[i].X += 10;
                        if (Game1.koordinat[i].X >= 630 - 48)
                        {
                            Game1.saglik[i] -= 11;
                            Game1.durum[i] = 1;
                            Game1.koordinat[i].X = 630 - 48;
                        }
                    }
                }
            }
        }

        public static void Tutulma()
        {
            for (int i = 0; i < 2; i++)
            {
                int j = 0;
                if (i == 0)
                    j = 1;
                if (!(Game1.secilikarakter[j] == 5 && Game1.ELcharge) && Game1.durum[j] != 3 && Game1.secilikarakter[i] == 4 && Game1.animasyon[i] >= 16 && Game1.animasyon[i] <= 19 && Game1.koordinat[i].X + 10 > Game1.koordinat[j].X && Game1.koordinat[j].X + 10 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 64 > Game1.koordinat[j].Y + 64 - Game1.robotboy[Game1.secilikarakter[j]] && Game1.koordinat[j].Y + 64 - Game1.robotboy[Game1.secilikarakter[j]] > Game1.koordinat[i].Y + 48)
                    Game1.durum[j] = 22;
                if (Game1.durum[i] == 22)
                {
                    if (Game1.animasyon[j] >= 16 && Game1.animasyon[j] <= 19)
                    {
                        Game1.koordinat[i] = new Vector2(Game1.koordinat[j].X, Game1.koordinat[j].Y - 10 + Game1.robotboy[Game1.secilikarakter[i]]);
                        Game1.animasyon[i] = 0;
                    }
                    else
                    {
                        Game1.ziplama[i] = 0;
                        Game1.koordinat[i].Y += 12;
                        Game1.MHbiraktigimyukseklik += 12;
                        if (Game1.koordinat[i].Y > 406)
                        {
                            Game1.koordinat[i].Y = 406;
                            Game1.durum[i] = 0;
                            if (Game1.MHbiraktigimyukseklik > 200)
                            {
                                Game1.durum[i] = 1;
                                Game1.saglik[i] -= 10;
                            }
                            Game1.MHbiraktigimyukseklik = 0;
                        }
                    }
                }
            }
        }

        public static void Slide()
        {
            Game1.animasyon[CharacterMoves.i] = 16;
            if (Game1.yon[CharacterMoves.i] == SpriteEffects.None)
            {
                Game1.koordinat[CharacterMoves.i].X += 12;
                if (Game1.koordinat[CharacterMoves.i].X >= 630 - 48)
                {
                    Game1.koordinat[CharacterMoves.i].X = 630 - 48;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            else
            {
                Game1.koordinat[CharacterMoves.i].X -= 12;
                if (Game1.koordinat[CharacterMoves.i].X <= 10)
                {
                    Game1.koordinat[CharacterMoves.i].X = 10;
                    Game1.durum[CharacterMoves.i] = 0;
                }
            }
            int i = 0;
            if (CharacterMoves.i == 0)
                i = 1;
            if (Game1.koordinat[i].X + 40 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 40 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 40 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 40 > Game1.koordinat[i].Y && Game1.durum[i] != 1 && Game1.durum[i] != 3)
            {
                Game1.durum[i] = 1;
                Game1.saglik[i] -= 13;
            }
        }

        public static int ccc = 0;
        public static void Iceball()
        {
            ccc++;
            if (ccc >= 7)
            {
                ccc = 0;
                if (Game1.animasyon[CharacterMoves.i] < 17 || Game1.animasyon[CharacterMoves.i] > 21)
                    Game1.animasyon[CharacterMoves.i] = 17;
                else if (Game1.animasyon[CharacterMoves.i] == 21)
                    Game1.animasyon[CharacterMoves.i] = 20;
                else
                    Game1.animasyon[CharacterMoves.i]++;
            }
            if (Game1.animasyon[CharacterMoves.i] == 20 || Game1.animasyon[CharacterMoves.i] == 21)
            {
                if (Game1.yon[CharacterMoves.i] == SpriteEffects.None)
                {
                    Game1.koordinat[CharacterMoves.i].X += 8;
                    if (Game1.koordinat[CharacterMoves.i].X >= 630 - 48)
                    {
                        Game1.koordinat[CharacterMoves.i].X = 630 - 48;
                        Game1.durum[CharacterMoves.i] = 0;
                    }
                }
                else
                {
                    Game1.koordinat[CharacterMoves.i].X -= 8;
                    if (Game1.koordinat[CharacterMoves.i].X <= 10)
                    {
                        Game1.koordinat[CharacterMoves.i].X = 10;
                        Game1.durum[CharacterMoves.i] = 0;
                    }
                }
                int i = 0;
                if (CharacterMoves.i == 0)
                    i = 1;
                if (Game1.koordinat[i].X + 40 > Game1.koordinat[CharacterMoves.i].X && Game1.koordinat[CharacterMoves.i].X + 40 > Game1.koordinat[i].X && Game1.koordinat[i].Y + 40 > Game1.koordinat[CharacterMoves.i].Y && Game1.koordinat[CharacterMoves.i].Y + 40 > Game1.koordinat[i].Y && Game1.durum[i] != 1 && Game1.durum[i] != 3)
                {
                    Game1.durum[i] = 1;
                    Game1.saglik[i] -= 16;
                }
            }
        }
    }
}
