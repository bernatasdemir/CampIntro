 using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] isimler = new string[] {"Berna","Büşra","Emine","Sueda" };
             Console.WriteLine(isimler[0]);
            */
            //ctrl+k ctrl+c //ctrl+k ctrl u

            List<string> İsimler2 = new List<string> { "Berna", "Büşra", "Emine", "Sueda" };
            Console.WriteLine(İsimler2[0]);
            İsimler2.Add("Fethiye");
            Console.WriteLine(İsimler2[4]);

            

        }
    }
}
