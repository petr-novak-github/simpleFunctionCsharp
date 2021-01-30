using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2]Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.
//peno - staci hodnotu char ulozit do integer a dojde k prevodu an asci kod

namespace simpleFunctionCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak;
            int AsciiKod;

            Console.WriteLine("Zadej znak a program vrati ASCII hodnotu.");
            znak = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Zadany znak je: " + znak + "\n");
            //Volani funkce
            AsciiKod = PrevodNaAscii(znak);

            Console.WriteLine("Prevdedeno na Asci to je: " + AsciiKod);
            Console.ReadLine();
        }
        //Vytvoreni funkce
        static int PrevodNaAscii(char znakF)
        {
            return Convert.ToInt32(znakF);
        }
    }
}
