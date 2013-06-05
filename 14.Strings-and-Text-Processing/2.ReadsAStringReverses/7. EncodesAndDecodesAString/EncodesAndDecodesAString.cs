﻿using System;
using System.Text;

class EncodesAndDecodesAString
{
    private static string stringWord;
    private static string key;
    private static StringBuilder encodes;
    private static int couterkey;
    private static StringBuilder decodes;
    private static string newString;


    static void Main()
    {
        EncodeString();

        DecodeString();
    }

    private static void DecodeString()
    {
        decodes = new StringBuilder();
        for (int j = 0; j < encodes.Length; j++)
        {

            decodes.Append((char)((int)newString[j] ^ (int)key[couterkey]));
            couterkey++;
            if (couterkey == key.Length)
            {
                couterkey = 0;
            }
        }
        decodes.ToString();
        Console.WriteLine("Decodes:" + decodes);
    }

    private static void EncodeString()
    {
        stringWord = "The Lord is my light and my salvation—whom shall I fear?The Lord is the stronghold of my life—of whom shall I be afraid?";
        key = "Zue";
        encodes = new StringBuilder();
        for (int i = 0; i < stringWord.Length; i++)
        {

            encodes.Append((char)((int)stringWord[i] ^ (int)key[couterkey]));
            couterkey++;
            if (couterkey == key.Length)
            {
                couterkey = 0;
            }
        }
        newString = encodes.ToString();
        Console.WriteLine("This is encodes:" + newString);
        Console.WriteLine();
        
    }
}