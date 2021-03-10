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
    class TextCreator
    {
        public static void CreateName()
        {
            Game1.karaktername[0] = "Icebot";
            Game1.karaktername[1] = "Firebot";
            Game1.karaktername[2] = "Fullspeed";
            Game1.karaktername[3] = "Big Guy";
            Game1.karaktername[4] = "Metal Hawk";
            Game1.karaktername[5] = "Electro";
            Game1.karaktername[6] = "Roboghost";
            Game1.karaktername[7] = "Runo";
        }

        public static void CreateStory()
        {
            Game1.karakterstory[0] = "Made by Dr Connor Staria\nGot power of ice\nHeight: 2.4m\nIcebot and Firebot are the only\nrobots that have consciousness.\nThey both join the tournament\nthemselves for proving to Connor\nwhich of these robots is the best.\nSo they are enemy now.";
            Game1.karakterstory[1] = "Made by Dr Connor Staria\nGot power of fire\nHeight: 2.4m\nIcebot and Firebot are the only\nrobots that have consciousness.\nThey both join the tournament\nthemselves for proving to Connor\nwhich of these robots is the best.\nSo they are enemy now.";
            Game1.karakterstory[2] = "Made by Tim Brown\nGot power of speed\nHeight: 2.1m\nBefore Wolfgang, Dr Mechwar tried\nto have Tim make robots for\nMechwar. Tim did not do that. So\nMechwar killed him. Tim's brother\nis using Fullspeed for revenge from\nMechwar and Wolfgang. Big Guy is\nFullspeed's only enemy.";
            Game1.karakterstory[3] = "Made by Wolfgang\nGot power of stone and strength\nHeight: 3.2m\nAfter killing Tim Brown,\nDr Mechwar found Wolfgang and\nmade him make Big Guy. It\nrepresents the tournament.\nMechwar thinks that nobody can\nwin Big Guy. He already knows\nBig Guy will be champion.";
            Game1.karakterstory[4] = "Made by Wolfgang\nGot power of wind\nHeight: 2.7m\nAfter making Big Guy for Mechwar,\nWolfgang also wanted to join\nthe tournament. For this he\ncreated Metal Hawk. Metal Hawk\nhas not any purpose. It joins\nthe tournament just for fun.";
            Game1.karakterstory[5] = "Made by Sir Dave\nGot power of electricity\nHeight: 2.6m\nAfter creating Electro, mad scientist\nDave heard about the tournament\nand thought if Electro win the\ntournament, he can be famous\nand rich. This is the only reason\nwhy Electro is in the tournament.";
            Game1.karakterstory[6] = "Made by government agents\nCan be invisible\nHeight: 2.6m\nPolice could not stop Mechwar's\nand Wolfgang's crimes. When\nthey heard about the tournament,\ngoverment agents created Roboghost.\nRoboghost's purpose is catching\nMechwar, Wolfgang and their\nrobots Big Guy and Metal Hawk.";
            Game1.karakterstory[7] = "Creator is unknown\nGot power of sound\nHeight: 2.8m\nCreater is unknown. Why is\nhe here unknown. When these\nquestions are asked, it just\nsays: 'I am not programmed\nfor answering this question.'";
        }

        public static void CreateRobot()
        {
            Game1.robotgenislik[0] = 11;
            Game1.robotboy[0] = 48;
            Game1.robotduckboy[0] = 38;
            Game1.robotkalkanboy[0] = 26;
            Game1.robotattack[0] = new Vector2(46, 34);
            
            Game1.robotgenislik[1] = 11;
            Game1.robotboy[1] = 48;
            Game1.robotduckboy[1] = 38;
            Game1.robotkalkanboy[1] = 24;
            Game1.robotattack[1] = new Vector2(46, 34);
            
            Game1.robotgenislik[2] = 8;
            Game1.robotboy[2] = 42;
            Game1.robotduckboy[2] = 36;
            Game1.robotkalkanboy[2] = 26;
            Game1.robotattack[2] = new Vector2(42, 34);
            
            Game1.robotgenislik[3] = 16;
            Game1.robotboy[3] = 64;
            Game1.robotduckboy[3] = 28;
            Game1.robotkalkanboy[3] = 32;
            Game1.robotattack[3] = new Vector2(38, 24);
            
            Game1.robotgenislik[4] = 7;
            Game1.robotboy[4] = 54;
            Game1.robotduckboy[4] = 38;
            Game1.robotkalkanboy[4] = 24;
            Game1.robotattack[4] = new Vector2(24, 30);
            
            Game1.robotgenislik[5] = 7;
            Game1.robotboy[5] = 52;
            Game1.robotduckboy[5] = 34;
            Game1.robotkalkanboy[5] = 30;
            Game1.robotattack[5] = new Vector2(40, 24);
            
            Game1.robotgenislik[6] = 8;
            Game1.robotboy[6] = 52;
            Game1.robotduckboy[6] = 36;
            Game1.robotkalkanboy[6] = 32;
            Game1.robotattack[6] = new Vector2(42, 26);
            
            Game1.robotgenislik[7] = 6;
            Game1.robotboy[7] = 56;
            Game1.robotduckboy[7] = 38;
            Game1.robotkalkanboy[7] = 56;
            Game1.robotattack[7] = new Vector2(24, 14);
        }

        public static void CreateManual()
        {
            if (Game1.secilikarakter[0] == 0)
            {
                Game1.karakterrenk[0] = new Color(200, 200, 255);
                Game1.karakterkılavuz[0] = "ICEBOT\nUse WASD to move\nPress E for blocking\nPress H for shooting\nHold H for charging energy\nPress G for ice throwing\nPress Y for becoming\n  an ice ball\nPress T for making arena\n  icier\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "H";
                Game1.special3[0] = "Y";
                Game1.special4[0] = "T";
            }
            else if (Game1.secilikarakter[0] == 1)
            {
                Game1.karakterrenk[0] = new Color(255, 100, 100);
                Game1.karakterkılavuz[0] = "FIREBOT\nUse WASD to move\nPress E for blocking\nPress H for shooting\nHold H for charging energy\nPress G for fire ground\nHold T for flying\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "H";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 2)
            {
                Game1.karakterrenk[0] = new Color(255, 255, 255);
                Game1.karakterkılavuz[0] = "FULLSPEED\nUse WASD to move\nPress E for blocking\nPress H for shooting\nPress G for quick shooting\nPress Y for sliding\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "Y";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 3)
            {
                Game1.karakterrenk[0] = new Color(127, 127, 60);
                Game1.karakterkılavuz[0] = "BIG GUY\nUse WASD to move\nPress E for blocking\nPress H for shooting\nPress G for deadly punch\nPress Y for becoming\n  wrecking ball\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "Y";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 4)
            {
                Game1.karakterrenk[0] = new Color(100, 100, 200);
                Game1.karakterkılavuz[0] = "METAL HAWK\nUse WASD to move\nPress E for blocking\nPress H for shooting\nPress W for flying\nPress G for wing attack\nPress Y for wind attack\nHold T for holding opponent\nYou can do your wind/wing\n  attacks just on the ground\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "Y";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 5)
            {
                Game1.karakterrenk[0] = new Color(127, 127, 0);
                Game1.karakterkılavuz[0] = "ELECTRO\nUse WASD to move\nPress E for blocking\nPress H for shooting\nPress G for\n  making electrowave\nPress Y for electro ground\nPress T for charge yourself\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "Y";
                Game1.special3[0] = "T";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 6)
            {
                Game1.karakterrenk[0] = new Color(200, 200, 200);
                Game1.karakterkılavuz[0] = "ROBOGHOST\nUse WASD to move\nPress E for blocking\nPress H for shooting\nPress G for becoming\n  invisible\nWatch your energymeter";
                Game1.special1[0] = "G";
                Game1.special2[0] = "";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }
            else if (Game1.secilikarakter[0] == 7)
            {
                Game1.karakterrenk[0] = new Color(80, 80, 80);
                Game1.karakterkılavuz[0] = "RUNO\nUse WASD to move\nPress E for sound shield\nPress H for shooting\nPress G for echo attack\nWhen you hold E,\n  press T for releasing\n  sound shield for\n  making soundwave\nWatch your energymeters";
                Game1.special1[0] = "G";
                Game1.special2[0] = "T";
                Game1.special3[0] = "";
                Game1.special4[0] = "";
            }

            if (Game1.secilikarakter[1] == 0)
            {
                Game1.karakterrenk[1] = new Color(200, 200, 255);
                Game1.karakterkılavuz[1] = "ICEBOT\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nHold 3 for charging energy\nPress 2 for ice throwing\nPress 6 for becoming\n  an ice ball\nPress 5 for making arena\n  icier\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "3";
                Game1.special3[1] = "6";
                Game1.special4[1] = "5";
            }
            else if (Game1.secilikarakter[1] == 1)
            {
                Game1.karakterrenk[1] = new Color(255, 100, 100);
                Game1.karakterkılavuz[1] = "FIREBOT\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nHold 3 for charging energy\nPress 2 for fire ground\nHold 5 for flying\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "3";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }
            else if (Game1.secilikarakter[1] == 2)
            {
                Game1.karakterrenk[1] = new Color(255, 255, 255);
                Game1.karakterkılavuz[1] = "FULLSPEED\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress 2 for quick shooting\nPress 6 for sliding\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "6";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }    
            else if (Game1.secilikarakter[1] == 3)
            {
                Game1.karakterrenk[1] = new Color(127, 127, 60);
                Game1.karakterkılavuz[1] = "BIG GUY\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress 2 for deadly punch\nPress 6 for becoming\n  wrecking ball\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "6";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }
            else if (Game1.secilikarakter[1] == 4)
            {
                Game1.karakterrenk[1] = new Color(100, 100, 200);
                Game1.karakterkılavuz[1] = "METAL HAWK\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress up for flying\nPress 2 for wing attack\nPress 6 for wind attack\nHold 5 for holding opponent\nYou can do your wind/wing\n  attacks just on the ground\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "6";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }
            else if (Game1.secilikarakter[1] == 5)
            {
                Game1.karakterrenk[1] = new Color(127, 127, 0);
                Game1.karakterkılavuz[1] = "ELECTRO\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress 2 for\n  making electrowave\nPress 6 for electro ground\nPress 5 for charge yourself\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "6";
                Game1.special3[1] = "5";
                Game1.special4[1] = "";
            }
            else if (Game1.secilikarakter[1] == 6)
            {
                Game1.karakterrenk[1] = new Color(200, 200, 200);
                Game1.karakterkılavuz[1] = "ROBOGHOST\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress 2 for becoming\n  invisible\nWatch your energymeter";
                Game1.special1[1] = "2";
                Game1.special2[1] = "";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }
            else if (Game1.secilikarakter[1] == 7)
            {
                Game1.karakterrenk[1] = new Color(80, 80, 80);
                Game1.karakterkılavuz[1] = "RUNO\nUse arrow keys to move\nPress 1 for blocking\nPress 3 for shooting\nPress 2 for echo attack\nWhen you hold 1,\n  press 5 for releasing\n  sound shield for\n  making soundwave\nWatch your energymeters";
                Game1.special1[1] = "2";
                Game1.special2[1] = "5";
                Game1.special3[1] = "";
                Game1.special4[1] = "";
            }
        }
    }
}
