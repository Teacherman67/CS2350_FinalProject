﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Reliability
    {

        private int reliabilityRating;
        private static string inValue;

        public Reliability()
        {
            this.reliabilityRating = getReliabilityRating();
        }

        public int ReliabilityRating
        {
            get
            {
                return reliabilityRating;
            }

            set
            {
                reliabilityRating = value;
            }
        }

        //get characteristic rating from user
        public static int getReliabilityRating()
        {
            int charRate = 3;
            int userInput;

            Graphics.ReliableFont();

            Console.SetCursorPosition(0, 18);
            Console.Write("   You're at work, trying to beat a deadline. Your friend calls you.\n" +
                "   He/She is stuck in the middle of nowhere with a flat tire. You:");
            Console.SetCursorPosition(10, 22);
            Console.Write("(1) go pick them up. A friend in need is a friend indeed.");
            Console.SetCursorPosition(14, 24);
            Console.Write("OR");
            Console.SetCursorPosition(10, 26);
            Console.Write("(2) ignore the call. They know how to dial a tow truck!\n");
            Console.SetCursorPosition(35, 30);
            inValue = Console.ReadLine();
            //send input to error check before assigning
            userInput = Client.intCheck(inValue, 1);
            Console.Clear();

            switch (userInput)
            {
                case 1: //no
                    charRate = 1;

                    break;
                case 2: //yes
                    charRate = 2;

                    break;
            }
            return charRate;
        }   //close getReliabilityRating

    }   //close CLass

}   //close Namespace
