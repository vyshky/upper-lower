using System;

//using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {  
        public static void Main()
        {
            string word;
            word = Console.ReadLine();
            
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());
            ///////////////////////////////////
            Console.WriteLine(Toupper(word));
            Console.WriteLine(Tolower(word));
            
        }
        public static string Toupper(string word)
        {
            string TempUpperchar;
            char[] WordTemp = word.ToCharArray();
            for (int it = 0; it < WordTemp.Length; it++)
            {
                TempUpperchar = WordTemp[it].ToString().ToUpper();
                if (WordTemp[it] != TempUpperchar[0])
                {
                    WordTemp[it] = TempUpperchar[0];
                }
            }
            return string.Concat(WordTemp);
        }
        
        public static string Tolower(string word)
        {
            string Templowerchar;
            char[] WordTemp = word.ToCharArray();
            for (int it = 0; it < WordTemp.Length; it++)
            {
                Templowerchar = WordTemp[it].ToString().ToLower();
                if (WordTemp[it] != Templowerchar[0])
                {
                    WordTemp[it] = Templowerchar[0];
                }
            }
            return string.Concat(WordTemp);
        }
    }
}