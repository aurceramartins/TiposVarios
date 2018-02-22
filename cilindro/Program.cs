using System;

namespace cilindro
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";
            string s1 = "Hola sou uma string";

            Console.WriteLine(s + s1);

            s += "uaaaaaaaaa";
            Console.WriteLine(s);


            Console.ReadKey();



        }
    }
}
