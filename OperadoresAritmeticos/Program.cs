using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            //recebe o valor de multiplicado por 3
            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            int c = 10;

            Console.WriteLine(++b);
            Console.WriteLine(c++);

            Console.WriteLine("Digite uma fruta");
            string fruta = Console.ReadLine();
            Console.WriteLine(fruta);



        }
    }
}
