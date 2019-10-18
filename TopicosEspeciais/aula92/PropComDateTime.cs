using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula92
{
    /// <summary>
    /// Classe que demonstra propriedades do TimeSpan.
    /// </summary>
    class PropComDateTime
    {
        //instanciando um DateTime;
        DateTime dateTime = DateTime.Now;
    
        public void imprimeTudo()
        {

            Console.WriteLine("dateTime.Date:{0} ", dateTime.Date);
            Console.WriteLine("dateTime.Day:{0} ", dateTime.Day);
            Console.WriteLine("dateTime.DayOfWeek:{0} ", dateTime.DayOfWeek);
            Console.WriteLine("dateTime.DayOfYear:{0} ", dateTime.DayOfYear);
            Console.WriteLine("dateTime.Hour:{0} ", dateTime.Hour);
            Console.WriteLine("dateTime.Month:{0} ", dateTime.Month);
            Console.WriteLine("dateTime.ToLongDateString():{0} ", dateTime.ToLongDateString());
            Console.WriteLine("dateTime.ToShortDateString():{0} ", dateTime.ToShortDateString());
            Console.WriteLine("\nFormantando minhas datas:\n");
            Console.WriteLine("Data original: {0}", dateTime);
            Console.WriteLine("{0}", dateTime.ToString("yy/MM/dddd"));
            Console.WriteLine("{0}", dateTime.ToString("yyyy/MM/dddd"));
            Console.WriteLine("{0}", dateTime.ToString("yyyy/MMMM/dd"));
            Console.WriteLine("{0}", dateTime.ToString("yy/MM/dd"));
            Console.WriteLine("{0}", dateTime.ToString("dddd/MM/yyyy"));
            Console.WriteLine("\n Modificando as datas:\n");
            Console.WriteLine("{0}",dateTime.AddDays(1));
            Console.WriteLine("{0}",dateTime.AddDays(-1));
            Console.WriteLine("{0}", dateTime.Subtract(dateTime));
            

            Console.ReadKey();

        }
    }
}
