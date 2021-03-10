using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Texture2D texture;
        SpriteFont font;
        public static int menu = 0; //0 = Ana Menü, 1 = Karakter Seçim Menüsü, 2 = Oyun Öncesi Menü, 3 = Oyun, 4 = Nasýl Oynanýr
        public static bool red = false;
        Song song;

        //ANA MENÜ
        public static int secilisecenek = 0;
        public static int selecteranimasyon = 0;
        public static bool basildi = true;
        public static bool closer = false;
        int gosteristimer = 0;
        int gosterisanimasyon = 4;
        int gosterisx = 0;
        int gosterisrobotu = 0;

        //KARAKTER SEÇÝM MENÜSÜ
        public static int[] secilikarakter = new int[2];
        public static string[] karaktername = new string[8];
        public static string[] karakterstory = new string[8];
        public static bool[] oyuncubasildi = new bool[2];
        public static int acilirim = 0;

        //OYUN ÖNCESÝ MENÜ
        public static string[] karakterkýlavuz = new string[2];
        public static Color[] karakterrenk = new Color[2];
        public static string[] special1 = new string[2];
        public static string[] special2 = new string[2];
        public static string[] special3 = new string[2];
        public static string[] special4 = new string[2];

        //OYUN
        public static int arenacil = 0;
        public static bool pause = false;
        public static Vector2[] koordinat = new Vector2[2];
        public static int[] saglik = new int[2];
        public static int[] ziplama = new int[2];
        public static int[] animasyon = new int[2];
        public static int[] hasarsayac = new int[2];
        public static SpriteEffects[] yon = new SpriteEffects[2];
        public static int[] durum = new int[2]; //0 = Normal, 1 = Hasar Almýþ, 2 = Donmuþ, 3 = Ölmüþ, 4 = Mega Yumruk Yemiþ, 21 = Rüzgara Yakalanmýþ, 22 = Kuþ Kapmýþ, 5+ Özel Hareketler
        public static int[] parametre1 = new int[2];
        public static int[] parametre2 = new int[2];
        public static int[] parametre3 = new int[2];
        public static int[] parametre4 = new int[2];
        public static bool icearena = false;
        public static int timer = 0;
        public static Vector2[] missilekoordinat = new Vector2[6];
        public static bool[] missileleft = new bool[6];
        public static int[] robotgenislik = new int[8];
        public static int[] robotboy = new int[8];
        public static int[] robotduckboy = new int[8];
        public static int[] robotkalkanboy = new int[8];
        public static Vector2[] robotattack = new Vector2[8];
        public static Vector2[] parcacikkoordinat = new Vector2[5];
        public static int parcacikzamanlayici = 0;
        public static Color[] olumcolor = new Color[8];
        public static int[] olumanimasyon = { 25, 25, 17, 20, 22, 31, 16, 17 };
        public static string text = "";
        bool pausebasildi = true;
        public static int ilkkimoldu = 0;

        //ICEBOT (IB)
        public static Vector2 IBchargekoordinat = new Vector2(-1000, -1000);
        public static SpriteEffects IBchargeyon = SpriteEffects.None;
        public static Vector2 IBicekoordinat = new Vector2(-1000, -1000);
        public static bool IBiceleft = true;
        public static Color IBsahne = new Color(255, 255, 255);

        //FIREBOT (FB)
        public static Vector2 FBchargekoordinat = new Vector2(-1000, -1000);
        public static SpriteEffects FBchargeyon = SpriteEffects.None;
        public static int FBanimasyon = 0;

        //FULLSPEED (FS)
        public static Vector2 FSquickkoordinat = new Vector2(-1000, -1000);
        public static bool FSquickleft = true;
        
        //BIG GUY (BG)
        public static int BGtimer = 0;
        public static int BGziplama = 0;
        
        //METAL HAWK (MH)
        public static int MHtimer = 0;
        public static int MHruzgaranimasyon = 0;
        public static bool MHtutucu = false;
        public static int MHbiraktigimyukseklik = 0;
        
        //ELECTRO (EL)
        public static bool ELcharge = false;
        public static SpriteEffects ELwaveyon = SpriteEffects.None;
        public static Vector2 ELwavekoordinat = new Vector2(-1000, -1000);
        public static int ELwaveanimasyon = 0;
        
        //ROBOGHOST (RG)
        public static bool RGgorunmez = false;
        
        //RUNO (RU)
        public static Vector2 RUechokoordinat = new Vector2(-1000, -1000);
        public static SpriteEffects RUyon = SpriteEffects.None;
        public static int RUechocarpismiktari = 0;
        public static int RUsoundwavegenislik = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 640;
            graphics.PreferredBackBufferHeight = 480;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Random rnd = new Random();
            gosterisrobotu = rnd.Next(0, 8);
            if (gosterisrobotu == 5)
                gosterisrobotu = 2;
            secilikarakter[0] = rnd.Next(0, 8);
            secilikarakter[1] = rnd.Next(0, 8);
            if (secilikarakter[0] == secilikarakter[1])
                secilikarakter[1]++;
            if (secilikarakter[1] == 8)
                secilikarakter[1] = 0;
            koordinat[0] = new Vector2(50, 406);
            yon[0] = SpriteEffects.None;
            koordinat[1] = new Vector2(590 - 48, 406);
            yon[1] = SpriteEffects.FlipHorizontally;
            font = Content.Load<SpriteFont>("font");
            TextCreator.CreateName();
            TextCreator.CreateStory();
            TextCreator.CreateRobot();
            saglik[0] = 100;
            saglik[1] = 100;
            for (int i = 0; i < 6; i++)
                missilekoordinat[i] = new Vector2(-1000, -1000);
            olumcolor[0] = new Color(153, 217, 234);
            olumcolor[1] = new Color(255, 127, 39);
            olumcolor[2] = new Color(136, 0, 21);
            olumcolor[3] = new Color(146, 124, 39);
            olumcolor[4] = new Color(63, 72, 204);
            olumcolor[5] = new Color(112, 143, 16);
            olumcolor[6] = new Color(127, 127, 127);
            olumcolor[7] = new Color(44, 44, 44);
        }

        protected override void UnloadContent()
        {
            MediaPlayer.Stop();
        }

        protected override void Update(GameTime gameTime)
        {
            texture = Content.Load<Texture2D>("Electrowave");
            KeyboardState klavye = Keyboard.GetState();
            if (klavye.IsKeyDown(Keys.R) && klavye.IsKeyDown(Keys.E) && klavye.IsKeyDown(Keys.D))
                red = true;
            if (menu == 0)
            {
                Menu.MainMenu();
                gosteristimer++;
                if (gosteristimer >= 7)
                {
                    gosteristimer = 0;
                    gosterisanimasyon++;
                    if (gosterisanimasyon >= 8)
                        gosterisanimasyon = 4;
                }
                if (gosterisrobotu == 2)
                    gosterisx += 6;
                else if (gosterisrobotu == 3)
                    gosterisx += 3;
                else
                    gosterisx += 4;
                if (gosterisx >= 650)
                {
                    gosterisx = -60;
                    Random rnd = new Random();
                    gosterisrobotu = rnd.Next(0, 8);
                    if (gosterisrobotu == 5)
                        gosterisrobotu = 1;
                }
            }
            else if (menu == 1)
            {
                Menu.CharacterSelectionMenu();
                acilirim++;
                if (klavye.IsKeyDown(Keys.Escape) && acilirim > 20)
                    menu = 0;
            }
            else if (menu == 2)
                Menu.BeforeGameMenu();
            else if (menu == 3 && !pause)
            {
                if (klavye.IsKeyDown(Keys.Escape))
                {
                    red = false;
                    icearena = false;
                    parcacikzamanlayici = 0;
                    text = "";
                    menu = 1;
                    koordinat[0] = new Vector2(50, 406);
                    yon[0] = SpriteEffects.None;
                    koordinat[1] = new Vector2(590 - 48, 406);
                    yon[1] = SpriteEffects.FlipHorizontally;
                    saglik[0] = 100;
                    saglik[1] = 100;
                    durum[0] = 0;
                    durum[1] = 0;
                    parametre1[0] = 0;
                    parametre1[1] = 0;
                    parametre2[0] = 0;
                    parametre2[1] = 0;
                    parametre3[0] = 0;
                    parametre3[1] = 0;
                    parametre4[0] = 0;
                    parametre4[1] = 0;
                    ziplama[0] = 0;
                    ziplama[1] = 0;
                    missilekoordinat[0] = new Vector2(-1000, -1000);
                    missilekoordinat[1] = new Vector2(-1000, -1000);
                    missilekoordinat[2] = new Vector2(-1000, -1000);
                    missilekoordinat[3] = new Vector2(-1000, -1000);
                    missilekoordinat[4] = new Vector2(-1000, -1000);
                    missilekoordinat[5] = new Vector2(-1000, -1000);
                    IBchargekoordinat = new Vector2(-1000, -1000);
                    IBicekoordinat = new Vector2(-1000, -1000);
                    FBchargekoordinat = new Vector2(-1000, -1000);
                    FSquickkoordinat = new Vector2(-1000, -1000);
                    BGziplama = 0;
                    BGtimer = 0;
                    MHbiraktigimyukseklik = 0;
                    MHruzgaranimasyon = 0;
                    MHtimer = 0;
                    MHtutucu = false;
                    ELcharge = false;
                    ELwaveanimasyon = 0;
                    ELwavekoordinat = new Vector2(-1000, -1000);
                    RGgorunmez = false;
                    RUechocarpismiktari = 0;
                    RUechokoordinat = new Vector2(-1000, -1000);
                    RUsoundwavegenislik = 0;
                    HitDetection.animasyon = 0;
                    HitDetection.C[0] = 0;
                    HitDetection.C[1] = 0;
                    HitDetection.ccc = 0;
                    HitDetection.chargertimer = 0;
                    HitDetection.timer = 0;
                    HitDetection.wawer = 0;
                    pause = false;
                }
                Menu.Game();
                arenacil -= 5;
                if (arenacil <= -480)
                    arenacil = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (saglik[i] < 0)
                        saglik[i] = 0;
                    if (icearena && secilikarakter[i] != 0 && koordinat[i].Y == 406)
                    {
                        if (yon[i] == SpriteEffects.None)
                        {
                            if ((durum[i] == 0 && i == 0 && !klavye.IsKeyDown(Keys.D)) || (durum[i] == 0 && i == 1 && !klavye.IsKeyDown(Keys.Right)))
                            {
                                koordinat[i].X += 2;
                                if (koordinat[i].X > 630 - 48)
                                    koordinat[i].X = 630 - 48;
                            }
                        }
                        else
                        {
                            if ((durum[i] == 0 && i == 0 && !klavye.IsKeyDown(Keys.A)) || (durum[i] == 0 && i == 1 && !klavye.IsKeyDown(Keys.Left)))
                            {
                                koordinat[i].X -= 2;
                                if (koordinat[i].X < 10)
                                    koordinat[i].X = 10;
                            }
                        }
                    }
                }
            }
            else
                Menu.HowtoplayMenu();
            if (closer)
                Exit();
            if (menu == 3 && klavye.IsKeyDown(Keys.P))
            {
                if (pausebasildi)
                {
                    pausebasildi = false;
                    if (pause)
                        pause = false;
                    else
                        pause = true;
                }
            }
            else
                pausebasildi = true;
            if (menu != 1)
                acilirim = 0;
            if (menu == 0 && song != Content.Load<Song>("Mechwar Theme"))
            {
                song = Content.Load<Song>("Mechwar Theme");
                MediaPlayer.Play(song);
                MediaPlayer.IsRepeating = true;
            }
            else if (menu == 1 && song != Content.Load<Song>("Character Selection"))
            {
                song = Content.Load<Song>("Character Selection");
                MediaPlayer.Play(song);
                MediaPlayer.IsRepeating = true;
            }
            else if (menu == 3 && song != Content.Load<Song>("Tournament Theme"))
            {
                song = Content.Load<Song>("Tournament Theme");
                MediaPlayer.Play(song);
                MediaPlayer.IsRepeating = true;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(95, 95, 95));
            spriteBatch.Begin();
            if (menu == 0)
            {
                texture = Content.Load<Texture2D>("mainmenu");
                spriteBatch.Draw(texture, new Rectangle(0, 0, 640, 480), Color.White);
                texture = Content.Load<Texture2D>("selecter");
                spriteBatch.Draw(texture, new Rectangle(130, 100 + (75 * secilisecenek), 37, 37), new Rectangle(selecteranimasyon * 37, 0, 37, 37), Color.White);
                texture = Content.Load<Texture2D>(gosterisrobotu.ToString());
                spriteBatch.Draw(texture, new Rectangle(gosterisx, 432 - 64, 48, 64), new Rectangle(gosterisanimasyon * 48, 0, 48, 64), Color.White);
            }
            else if (menu == 1)
            {
                texture = Content.Load<Texture2D>("mainmenu");
                spriteBatch.Draw(texture, new Rectangle(0, 0, 640, 90), new Rectangle(0, 0, 640, 90), new Color(125, 125, 125));
                texture = Content.Load<Texture2D>("ozelliktablosu");
                spriteBatch.Draw(texture, new Rectangle(20 - 8, 199, texture.Width, texture.Height), Color.White);
                spriteBatch.Draw(texture, new Rectangle(340 - 8, 199, texture.Width, texture.Height), Color.White);
                spriteBatch.DrawString(font, "Player 1 Chooses " + karaktername[secilikarakter[0]], new Vector2(20, 20), Color.Red);
                spriteBatch.DrawString(font, "Player 2 Chooses " + karaktername[secilikarakter[1]], new Vector2(340, 20), Color.Red);
                spriteBatch.DrawString(font, karakterstory[secilikarakter[0]], new Vector2(20 - 5, 200), Color.Black);
                spriteBatch.DrawString(font, karakterstory[secilikarakter[1]], new Vector2(340 - 5, 200), Color.Black);
                if (secilikarakter[0] == 7 && red)
                    texture = Content.Load<Texture2D>("8");
                else
                    texture = Content.Load<Texture2D>(secilikarakter[0].ToString());
                spriteBatch.Draw(texture, new Rectangle(100, 100, 48, 64), new Rectangle(selecteranimasyon * 48, 0, 48, 64), Color.White, 0, Vector2.Zero, SpriteEffects.None, 0);
                if (secilikarakter[1] == 7 && red)
                    texture = Content.Load<Texture2D>("8");
                else
                    texture = Content.Load<Texture2D>(secilikarakter[1].ToString());
                spriteBatch.Draw(texture, new Rectangle(442, 100, 48, 64), new Rectangle(selecteranimasyon * 48, 0, 48, 64), Color.White, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                texture = Content.Load<Texture2D>("pressenter");
                spriteBatch.Draw(texture, new Rectangle(220, 440, 200, 40), Color.White);
                spriteBatch.Draw(texture, new Rectangle(319, 0, 2, 440), new Rectangle(0, 20, 1, 1), Color.White);
            }
            else if (menu == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    texture = Content.Load<Texture2D>("arenacil");
                    spriteBatch.Draw(texture, new Rectangle(0, arenacil + (i * 480), 640, 480), Color.White);
                    texture = Content.Load<Texture2D>("Fight");
                    spriteBatch.Draw(texture, new Rectangle(320 - 35, arenacil + 480, 75, 22), new Rectangle(0, selecteranimasyon * 22, 70, 22), Color.White);
                }
                texture = Content.Load<Texture2D>("Arena");
                spriteBatch.Draw(texture, new Rectangle(0, 0, 640, 480), Color.White);
                for (int i = 0; i < 2; i++)
                {
                    texture = Content.Load<Texture2D>("parsoman");
                    spriteBatch.Draw(texture, new Rectangle(320 * i, 60, 320, 360), karakterrenk[i]);
                    spriteBatch.DrawString(font, karakterkýlavuz[i], new Vector2((320 * i) + 45, 80), Color.Black);
                }
            }
            else if (menu == 3)
            {
                if (icearena)
                {
                    texture = Content.Load<Texture2D>("Arenaice");
                    spriteBatch.Draw(texture, new Rectangle(0, 0, 640, 480), IBsahne);
                    texture = Content.Load<Texture2D>("Fight");
                    spriteBatch.Draw(texture, new Rectangle(320 - 35, 300, 75, 22), new Rectangle(0, selecteranimasyon * 22, 70, 22), IBsahne);
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        texture = Content.Load<Texture2D>("arenacil");
                        spriteBatch.Draw(texture, new Rectangle(0, arenacil + (i * 480), 640, 480), IBsahne);
                        texture = Content.Load<Texture2D>("Fight");
                        spriteBatch.Draw(texture, new Rectangle(320 - 35, arenacil + 480, 75, 22), new Rectangle(0, selecteranimasyon * 22, 70, 22), IBsahne);
                    }
                    texture = Content.Load<Texture2D>("Arena");
                    spriteBatch.Draw(texture, new Rectangle(0, 0, 640, 480), IBsahne);
                }
                if (RUsoundwavegenislik > 0)
                {
                    texture = Content.Load<Texture2D>("7");
                    for (int i = 0; i < 2; i++)
                    {
                        if (secilikarakter[i] == 7)
                            spriteBatch.Draw(texture, new Rectangle((int)koordinat[i].X + 24 - RUsoundwavegenislik, (int)koordinat[i].Y + 32 - RUsoundwavegenislik, RUsoundwavegenislik * 2, RUsoundwavegenislik * 2), new Rectangle(576, 10, 48, 56), Color.White);
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    if (durum[i] != 3)
                    {
                        if (secilikarakter[i] == 6 && RGgorunmez)
                        {
                        }
                        else
                        {
                            if (secilikarakter[i] == 7 && red)
                                texture = Content.Load<Texture2D>("8");
                            else
                                texture = Content.Load<Texture2D>(secilikarakter[i].ToString());
                            spriteBatch.Draw(texture, new Rectangle((int)koordinat[i].X, (int)koordinat[i].Y, 48, 64), new Rectangle(animasyon[i] * 48, 0, 48, 64), Color.White, 0, Vector2.Zero, yon[i], 0);
                            if (secilikarakter[i] == 4 && durum[i] == 6)
                            {
                                texture = Content.Load<Texture2D>("wind");
                                if (yon[i] == SpriteEffects.None)
                                    spriteBatch.Draw(texture, new Rectangle((int)koordinat[i].X + 36, (int)koordinat[i].Y + 4, 150, 30), new Rectangle(0, MHruzgaranimasyon * 30, 150, 30), Color.White);
                                else
                                    spriteBatch.Draw(texture, new Rectangle((int)koordinat[i].X + 48 - 36 - 150, (int)koordinat[i].Y + 4, 150, 30), new Rectangle(0, MHruzgaranimasyon * 30, 150, 30), Color.White, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                            }
                        }
                    }
                    else
                    {
                        texture = Content.Load<Texture2D>(secilikarakter[i].ToString());
                        spriteBatch.Draw(texture, new Rectangle((int)koordinat[i].X, (int)koordinat[i].Y, 48, 64), new Rectangle(olumanimasyon[secilikarakter[i]] * 48, 0, 48, 64), Color.White, 0, Vector2.Zero, yon[i], 0);
                        if (koordinat[i].Y < 406)
                        {
                            koordinat[i].Y += 12;
                            if (koordinat[i].Y > 406)
                                koordinat[i].Y = 406;
                        }
                        texture = Content.Load<Texture2D>("parcacik");
                        for (int a = 0; a < 5; a++)
                        {
                            if (ilkkimoldu == i)
                                spriteBatch.Draw(texture, new Rectangle((int)parcacikkoordinat[a].X, (int)parcacikkoordinat[a].Y, 10, 10), olumcolor[secilikarakter[i]]);
                        }
                    }
                    texture = Content.Load<Texture2D>("kalp");
                    spriteBatch.Draw(texture, new Rectangle((i * 596) + 12, 12, 20, 162), new Rectangle((saglik[i] / 5) * 20, 0, 20, 162), Color.Red);
                }
                for (int i = 0; i < 6; i++)
                {
                    if ((secilikarakter[0] == 6 && i < 3 && RGgorunmez) || (secilikarakter[1] == 6 && i >= 3 && RGgorunmez))
                    {
                    }
                    else
                    {
                        texture = Content.Load<Texture2D>("missile");
                        spriteBatch.Draw(texture, new Rectangle((int)missilekoordinat[i].X, (int)missilekoordinat[i].Y, 8, 8), new Rectangle(secilikarakter[i / 3] * 8, 0, 8, 8), Color.White);
                    }
                }
                texture = Content.Load<Texture2D>("missile");
                spriteBatch.Draw(texture, new Rectangle((int)FSquickkoordinat.X, (int)FSquickkoordinat.Y, 8, 8), new Rectangle(0, 0, 8, 8), Color.White);
                texture = Content.Load<Texture2D>("iceball");
                spriteBatch.Draw(texture, new Rectangle((int)IBicekoordinat.X, (int)IBicekoordinat.Y, 8, 8), Color.White);
                texture = Content.Load<Texture2D>("echo");
                spriteBatch.Draw(texture, new Rectangle((int)RUechokoordinat.X, (int)RUechokoordinat.Y, 20, 20), new Rectangle(0, 0, 20, 20), Color.White, 0, Vector2.Zero, RUyon, 0);
                texture = Content.Load<Texture2D>("Electrowave");
                spriteBatch.Draw(texture, new Rectangle((int)ELwavekoordinat.X, (int)ELwavekoordinat.Y, 60, 60), new Rectangle(ELwaveanimasyon * 60, 0, 60, 60), Color.White, 0, Vector2.Zero, ELwaveyon, 0);
                texture = Content.Load<Texture2D>("Charges");
                spriteBatch.Draw(texture, new Rectangle((int)FBchargekoordinat.X, (int)FBchargekoordinat.Y, 32, 32), new Rectangle(FBanimasyon * 32, 0, 32, 32), Color.White, 0, Vector2.Zero, FBchargeyon, 0);
                spriteBatch.Draw(texture, new Rectangle((int)IBchargekoordinat.X, (int)IBchargekoordinat.Y, 32, 32), new Rectangle(4 * 32, 0, 32, 32), Color.White, 0, Vector2.Zero, IBchargeyon, 0);
                if ((secilikarakter[0] == 1 && durum[0] == 5) || (secilikarakter[1] == 1 && durum[1] == 5))
                {
                    texture = Content.Load<Texture2D>("fireground");
                    for (int i = 1; i < 640 / 24; i++)
                        spriteBatch.Draw(texture, new Rectangle(i * 24, 406 + 64 - 48, 24, 48), new Rectangle(HitDetection.animasyon * 24, 0, 24, 48), Color.White);
                }
                if ((secilikarakter[0] == 5 && durum[0] == 5) || (secilikarakter[1] == 5 && durum[1] == 5))
                {
                    texture = Content.Load<Texture2D>("electroground");
                    for (int i = 1; i < 640 / 24; i++)
                        spriteBatch.Draw(texture, new Rectangle(i * 24, 406 + 64 - 10, 24, 22), new Rectangle(HitDetection.animasyon * 24, 0, 24, 22), Color.White);
                }
                for (int i = 0; i < 2; i++)
                {
                    texture = Content.Load<Texture2D>("Parameter");
                    if (parametre1[i] == 100)
                        spriteBatch.Draw(texture, new Rectangle((i * 536) + 42, 12, 20, 82), new Rectangle((parametre1[i] / 10) * 20, 0, 20, 82), Color.Yellow);
                    else
                        spriteBatch.Draw(texture, new Rectangle((i * 536) + 42, 12, 20, 82), new Rectangle((parametre1[i] / 10) * 20, 0, 20, 82), Color.Gray);
                    spriteBatch.DrawString(font, special1[i], new Vector2((i * 540) + 45, 90), Color.Red);
                    if (secilikarakter[i] == 5 || secilikarakter[i] == 7 || secilikarakter[i] == 1 || secilikarakter[i] == 2 || secilikarakter[i] == 0 || secilikarakter[i] == 3 || secilikarakter[i] == 4)
                    {
                        if (parametre2[i] == 100)
                            spriteBatch.Draw(texture, new Rectangle((i * 476) + 72, 12, 20, 82), new Rectangle((parametre2[i] / 10) * 20, 0, 20, 82), Color.Yellow);
                        else
                            spriteBatch.Draw(texture, new Rectangle((i * 476) + 72, 12, 20, 82), new Rectangle((parametre2[i] / 10) * 20, 0, 20, 82), Color.Gray);
                        spriteBatch.DrawString(font, special2[i], new Vector2((i * 480) + 75, 90), Color.Red);
                    }
                    if (secilikarakter[i] == 5 || secilikarakter[i] == 0)
                    {
                        if (parametre3[i] == 100)
                            spriteBatch.Draw(texture, new Rectangle((i * 416) + 102, 12, 20, 82), new Rectangle((parametre3[i] / 10) * 20, 0, 20, 82), Color.Yellow);
                        else
                            spriteBatch.Draw(texture, new Rectangle((i * 416) + 102, 12, 20, 82), new Rectangle((parametre3[i] / 10) * 20, 0, 20, 82), Color.Gray);
                        spriteBatch.DrawString(font, special3[i], new Vector2((i * 420) + 105, 90), Color.Red);
                    }
                    if (secilikarakter[i] == 0 && !icearena)
                    {
                        if (parametre4[i] == 100)
                            spriteBatch.Draw(texture, new Rectangle((i * 356) + 132, 12, 20, 82), new Rectangle((parametre4[i] / 10) * 20, 0, 20, 82), Color.Yellow);
                        else
                            spriteBatch.Draw(texture, new Rectangle((i * 356) + 132, 12, 20, 82), new Rectangle((parametre4[i] / 10) * 20, 0, 20, 82), Color.Gray);
                        spriteBatch.DrawString(font, special4[i], new Vector2((i * 360) + 135, 90), Color.Red);
                    }
                }
                spriteBatch.DrawString(font, text, new Vector2(250, 240), Color.Red);
            }
            else
            {
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
