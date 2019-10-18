using System;

namespace ConsoleApp2
{
    class Program
    {
       
        static void Main(string[] args)
        {
          sbyte sbyte1 = new sbyte();
          byte byte1 = new byte();
          short short1 = new short();
          long long1 = new long();
          int int1 = new int();
           bool bool1 = new bool();

            //concatenação
            Console.WriteLine("O valor maximo do sbyte é: "+ sbyte.MaxValue);
            Console.WriteLine("O valor minimo do sbyte é: "+ sbyte.MinValue);
            Console.WriteLine();

            //intepolação
            Console.WriteLine($"O valor maximo do short é: {short.MaxValue}");
            Console.WriteLine($"O valor minimo do short é: {short.MinValue}");
            Console.WriteLine();
            //placeholder
            Console.WriteLine("O valor minimo do long é: {0}", long.MinValue);
            Console.WriteLine("O valor máximo do long é: {0}", long.MaxValue);
            Console.WriteLine();
            Console.WriteLine($"O valor maximo do int é: {int.MaxValue}");
            Console.WriteLine($"O valor minimo do int é:`{int.MinValue}");
            
        }
    }
}
