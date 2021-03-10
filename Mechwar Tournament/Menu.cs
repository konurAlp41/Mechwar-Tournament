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
    class Menu
    {
        public static void MainMenu()
        {
            KeyboardState klavye = Keyboard.GetState();
            Game1.timer++;
            if (Game1.timer >= 2)
            {
                Game1.timer = 0;
                Game1.selecteranimasyon++;
                if (Game1.selecteranimasyon >= 12)
                    Game1.selecteranimasyon = 0;
            }

            if (klavye.IsKeyDown(Keys.Up) || klavye.IsKeyDown(Keys.W))
            {
                if (Game1.basildi)
                {
                    Game1.basildi = false;
                    if (Game1.secilisecenek > 0)
                        Game1.secilisecenek--;
                }
            }
            else if (klavye.IsKeyDown(Keys.Down) || klavye.IsKeyDown(Keys.S))
            {
                if (Game1.basildi)
                {
                    Game1.basildi = false;
                    if (Game1.secilisecenek < 2)
                        Game1.secilisecenek++;
                }
            }
            else if (klavye.IsKeyDown(Keys.Enter))
            {
                Game1.basildi = false;
                if (Game1.secilisecenek == 0)
                    Game1.menu = 1;
                else if (Game1.secilisecenek == 1)
                    Game1.menu = 4;
                else
                    Game1.closer = true;
            }
            else
                Game1.basildi = true;
        }

        public static void CharacterSelectionMenu()
        {
            Game1.timer++;
            if (Game1.timer >= 7)
            {
                Game1.timer = 0;
                Game1.selecteranimasyon++;
                if (Game1.selecteranimasyon >= 4)
                    Game1.selecteranimasyon = 0;
            }
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.Left))
            {
                if (Game1.oyuncubasildi[1])
                {
                    Game1.oyuncubasildi[1] = false;
                    Game1.secilikarakter[1]--;
                    if (Game1.secilikarakter[1] == -1)
                        Game1.secilikarakter[1] = 7;
                    if (Game1.secilikarakter[1] == Game1.secilikarakter[0])
                    {
                        Game1.secilikarakter[1]--;
                        if (Game1.secilikarakter[1] == -1)
                            Game1.secilikarakter[1] = 7;
                    }
                }
            }
            else if (klavye.IsKeyDown(Keys.Right))
            {
                if (Game1.oyuncubasildi[1])
                {
                    Game1.oyuncubasildi[1] = false;
                    Game1.secilikarakter[1]++;
                    if (Game1.secilikarakter[1] == 8)
                        Game1.secilikarakter[1] = 0;
                    if (Game1.secilikarakter[1] == Game1.secilikarakter[0])
                    {
                        Game1.secilikarakter[1]++;
                        if (Game1.secilikarakter[1] == 8)
                            Game1.secilikarakter[1] = 0;
                    }
                }
            }
            else
                Game1.oyuncubasildi[1] = true;
            if (klavye.IsKeyDown(Keys.A))
            {
                if (Game1.oyuncubasildi[0])
                {
                    Game1.oyuncubasildi[0] = false;
                    Game1.secilikarakter[0]--;
                    if (Game1.secilikarakter[0] == -1)
                        Game1.secilikarakter[0] = 7;
                    if (Game1.secilikarakter[0] == Game1.secilikarakter[1])
                    {
                        Game1.secilikarakter[0]--;
                        if (Game1.secilikarakter[0] == -1)
                            Game1.secilikarakter[0] = 7;
                    }
                }
            }
            else if (klavye.IsKeyDown(Keys.D))
            {
                if (Game1.oyuncubasildi[0])
                {
                    Game1.oyuncubasildi[0] = false;
                    Game1.secilikarakter[0]++;
                    if (Game1.secilikarakter[0] == 8)
                        Game1.secilikarakter[0] = 0;
                    if (Game1.secilikarakter[0] == Game1.secilikarakter[1])
                    {
                        Game1.secilikarakter[0]++;
                        if (Game1.secilikarakter[0] == 8)
                            Game1.secilikarakter[0] = 0;
                    }
                }
            }
            else
                Game1.oyuncubasildi[0] = true;
            if (klavye.IsKeyDown(Keys.Enter))
            {
                if (Game1.basildi)
                {
                    Game1.basildi = false;
                    Game1.menu = 2;
                    TextCreator.CreateManual();
                }
            }
            else
                Game1.basildi = true;
        }

        public static void HowtoplayMenu()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.Escape))
                Game1.menu = 0;
        }

        public static void BeforeGameMenu()
        {
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.Enter))
            {
                if (Game1.basildi)
                {
                    Game1.basildi = false;
                    Game1.menu = 3;
                }
            }
            else
                Game1.basildi = true;
        }

        public static void Game()
        {
            if (Game1.durum[0] == 0)
                CharacterMoves.Player1();
            if (Game1.durum[1] == 0)
                CharacterMoves.Player2();
            Missile.Normal();
            HitDetection.Normal();
            HealthIssues.Hasar();
            HealthIssues.Donma();
            HealthIssues.Olum();
            Animation.CreateAnimation();
            CharacterMoves.Fullspeed();
            CharacterMoves.Roboghost();
            CharacterMoves.BigGuy();
            CharacterMoves.MetalHawk();
            CharacterMoves.Firebot();
            CharacterMoves.Icebot();
            CharacterMoves.Runo();
            CharacterMoves.Electro();
            HitDetection.MegaDayakYemis();
            HitDetection.RuzgarYuzumeVuruyor();
            HitDetection.Tutulma();
        }
    }
}
