﻿using System;
using System.Collections.Generic;

namespace BeepProgram
{
    class Program
    {

        public static Dictionary<char, string> MorseAlphabet;

        static void Main(string[] args)
        {
            const int dot = 250;
            const int dash = dot * 3;

            MorseAlphabet = new Dictionary<char, string>()
            {
                {'A', ".-"},{'B', "-..."},{'C', "-.-."},{'D', "-.."},{'E', "."},{'F', "..-."},{'G', "--."},{'H', "...."},{'I', ".."},
                {'J', ".----"},{'K', "-.-"},{'L', ".-.."},{'M', "--"},{'N', "-."},{'O', "---"},{'P', ".--."},{'Q', "--.-"},{'R', ".-."},
                {'S', "..."},{'T', "-"},{'U', "..-"},{'V', "...-"},{'X', "-..-"},{'Y', "-.--"},{'Z', "--.."},{'0', "-----"},{'1', ".----"},
                {'2', "..---"},{'3', "...--"},{'4', "....-"},{'5', "....."},{'6', "-...."},{'7', "--..."},{'8', "---.."},{'9', "----."},
            };
            String Words;
            char letters;

            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Words = args[i].ToUpper();
                    Console.WriteLine(Words);
                    for (int j = 0; j < Words.Length; j++)
                    {
                        try
                        {
                            letters = Words[j];
                            Console.WriteLine(MorseAlphabet[letters]);

                            foreach (var character in MorseAlphabet[letters])
                            {
                                if (character == '.')
                                {
                                    Console.Beep(600, dot);
                                }
                                else
                                {
                                    Console.Beep(600, dash);
                                }
                                System.Threading.Thread.Sleep(dot * 3);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    System.Threading.Thread.Sleep(dot * 7);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}