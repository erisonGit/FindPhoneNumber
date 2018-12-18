using System;

namespace FindPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Informe o caminho completo do arquivo: ");
            string caminho = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(caminho);

            System.Console.WriteLine("Resultado: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + Phone.GetNumber(line));
            }

            Console.Write("\nPressione qualquer tecla para finalizar... ");
            Console.ReadLine();
        }
    }

    public class Phone
    {
        public static string GetNumber(string word)
        {
            var number = string.Empty;

            foreach(char c in word.ToLower().ToCharArray())
            {
                number += CharToPhoneNumber(c);
            }

            return number;
        }

        private static char CharToPhoneNumber(char c)
        {
            char result = c;

            var num = (int)c;

            if (num >= 97 && num < 100) c = '2';
            if (num >= 100 && num < 103) c = '3';
            if (num >= 103 && num < 106) c = '4';
            if (num >= 106 && num < 109) c = '5';
            if (num >= 109 && num < 112) c = '6';
            if (num >= 112 && num < 116) c = '7';
            if (num >= 116 && num < 119) c = '8';
            if (num >= 119 && num < 123) c = '9';

            return c;

        }
    }
}
