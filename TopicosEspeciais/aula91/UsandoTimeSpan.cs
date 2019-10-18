using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula91
{
    /// <summary>
    /// Essa classe faz uso básico do struct TimeSpan.
    /// Ele representa uma duração(um intervalo entre dois instantes).Armazena uma duração na forma de ticks(100 nanosegundos).
    /// 
    /// </summary>
    class UsandoTimeSpan
    {
        //instanciando um TimeSpan, com 1 minuto e 20 segundos.
        TimeSpan t1 = new TimeSpan(0, 1, 20);

        //instanciando um TimeSpan(um periodo) de 2 horas 1 minuto e 20 segundos
        TimeSpan t2 = new TimeSpan(2, 1, 20);
        
        //instanciando um TimeSpan(um periodo) de 1 dia 2 horas 1 minuto e 20 segundos
        TimeSpan t3 = new TimeSpan(1,2, 1, 20);

        //instanciando um TimeSpan(um periodo) de 1 dia 2 horas 1 minuto e 20 segundos e 300 milisegundos
        TimeSpan t4 = new TimeSpan(1, 2, 1, 20, 300);

        //instanciando a partir do From
        //Nesse caso cria um TimeSpan de 1 dia e meio.
        TimeSpan t5 = TimeSpan.FromDays(1.5);

        //Um TimeSpan de 1 hora e meia.
        TimeSpan t6 = TimeSpan.FromHours(1.5);

        public void imprimeTudo()
        {
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.ReadKey();
        }


    }
}
