using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula94
{
    /// <summary>
    /// Classe que usa o basico do DateTimeKind. 
    /// Tipo enumerado especial que define três valores possiveis para a localidade data:
    /// Local, utc, unspecified
    /// </summary>
    class MeuDatetimeKind
    {
        //local, fuso horario do sistema.

        //Para converter um DateTime para Local ou Utc, você deve usar:
        //myDate.ToLocalTime()
        //myDate.ToUniversalTime()

        //instanciando dateTime com dateTimeKind local
        DateTime d1 = new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Local);
        DateTime d2 = new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Utc);
        DateTime d3 = new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Unspecified);

        public void imprimeTudo()
        {
            
            
            

            Console.WriteLine("Imprimindo new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Local): {0}", d1);
            Console.WriteLine("d1.ToUniversalTime: {0}", d1.ToUniversalTime());
            Console.WriteLine("d1.Kind: {0}", d1.Kind);
            Console.WriteLine("d1.ToLocal: {0}\n", d1.ToLocalTime());

            Console.WriteLine("Imprimindo new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Utc): {0}", d2);
            Console.WriteLine("d2.ToUniversalTime: {0}", d2.ToUniversalTime());
            Console.WriteLine("d2.Kind: {0}", d2.Kind);
            Console.WriteLine("d2.ToLocal: {0}\n", d2.ToLocalTime());

            Console.WriteLine("Imprimindo new DateTime(2019, 10, 17, 17,43,50, DateTimeKind.Unspecified): {0}\n", d3);
            Console.WriteLine("d3.ToUniversalTime: {0}", d3.ToUniversalTime());
            Console.WriteLine("d3.Kind: {0}", d3.Kind);
            Console.WriteLine("d3.ToLocal: {0}\n", d3.ToLocalTime());
            
            
            Console.ReadKey();
        }
    }
}
