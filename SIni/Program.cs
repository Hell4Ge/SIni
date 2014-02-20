using System;
using System.Collections.Generic;
using System.Text;
using SharpFile;

namespace SIni
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpIni.Section sec = new SharpIni.Section("troll");
            for (int i = 0; i < 5; i++)
                sec.CreateKey("foo" + i.ToString(), i.ToString());

            Console.Write(sec.ToString());
            Console.ReadKey();
        }
    }
}
