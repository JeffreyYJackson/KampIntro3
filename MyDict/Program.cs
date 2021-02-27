using System;
using System.Collections.Generic;

namespace MyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("Hello", "Merhaba");

            MyDictionary<string, string> sozluk2 = new MyDictionary<string, string>();
            sozluk2.Add("Hello", "Merhaba");
            Console.WriteLine(sozluk2._keys[0]);
            Console.WriteLine(sozluk2._values[0]);

        }
    }
}