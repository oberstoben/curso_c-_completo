using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula94
{
    /// <summary>
    /// Essa classe serve para mostrar um ISO8601.
    /// Formato: yyyy-MM-ddTHH:mm:ssZ (Z indica que a data/hora está em UTC.)
    /// </summary>
    class PadraoISO8601
    {
        public void imprimeTudo()
        {
            
            DateTime d1 = DateTime.Parse("2019-10-17 18:08:52");
            DateTime d2 = DateTime.Parse("2019-10-17T18:08:52Z");
            DateTime d3 = DateTime.UtcNow;

            Console.WriteLine("Imprimindo DateTime d1 = DateTime.Parse('2019 - 10 - 17 18:08:52'): {0}",d1);
            Console.WriteLine("d1.Kind: {0}",d1.Kind);
            
            Console.WriteLine("Imprimindo DateTime d2 = DateTime.Parse('2019 - 10 - 17T18: 08:52Z'): {0}", d2);
            Console.WriteLine("d2.Kind: {0}",d2.Kind);
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime());
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d3);
            Console.ReadKey();
        }
    }
}
