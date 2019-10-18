using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVagas
{
    class Listas
    {

        public static void Main()
        {
            List<String> lista = new List<string>();
            lista.Add("yurizera");
            lista.Add("cesar");
            lista.Add("monstro");
            lista.Add("chaves ");
            lista.Insert(1, "rapha");

            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            string s1 = lista.Find(x => x[0] == 'c');
            Console.WriteLine("First 'A': " + s1);
            int pos1 = lista.FindIndex(x => x[0] == 'c');
            Console.WriteLine("First 'A' at position: " + pos1);
            string s2 = lista.FindLast(x => x[0] == 'c');
            
            int pos2 = lista.FindLastIndex(x => x[0] == 'c');
            Console.WriteLine("Last 'A' at position: " + pos2);
            Console.WriteLine("Last 'A' at position: " + pos2);

            Console.WriteLine("First 'A': " + s2);
            
            Console.ReadLine();

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(5);
            A.Add(8);
            A.Add(2);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach(int x in A)
            {
                Console.WriteLine(x);
            }



        }      
    }
}
