using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;


namespace Fixacao
{
    class Repetidor
    {
        bool verdadeiro = true;
        
        public void metodo()
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i=0;i<n;i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
               
            }
            Console.WriteLine("O tamanho do vetor é: "+vect.Length);
            Console.ReadLine();

        }
    }
}
