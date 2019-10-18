using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace TopicosEspeciais.aula90
{
    /// <summary>
    /// Uma STRUCT que representa um instante.
    /// Um objeto DateTime internamente armazena:
    /// o numero de 'ticks' (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum.
    /// </summary>
    class UsandoData
    {
        
        
        //Construtores mais utilizados
        DateTime d1 = new DateTime(2019, 10, 17);
        DateTime d2 = new DateTime(2019, 10, 17,15,46,20);

        //Builders mais utilizados
        //instanciando um DateTime e lhe atribuindo o valor atual do sistema.
        DateTime dateTime = DateTime.Now;
        //instanciando uma data que usa o horario de GreenWitch.
        DateTime d3 = DateTime.UtcNow;
        //instanciando uma data que usa o horario da maquina, mas sem as horas.
        DateTime d4 = DateTime.Today;

        //Parses
        DateTime data = DateTime.Parse("2019-10-17");
        DateTime dataComHorario = DateTime.Parse("2019-10-17 15:52");

        //data no formato brasileiro
        DateTime formatoBrasileiro = DateTime.Parse("17/10/2019");

        DateTime exact = DateTime.ParseExact("2019-10-17", "yyyy-MM-dd", CultureInfo.InvariantCulture);

        public void imprimeTudo()
        {

            Console.WriteLine("Utilizando o construtor (ano,mes,dia): "+d1);
            Console.WriteLine("Utilizando o construtor (ano,mes,dia,hora,minuto,segundo): "+d2);
            Console.WriteLine("Utilizando os Builder DateTime.Now: "+dateTime);
            Console.WriteLine("Utilizando o construtor DateTime.UtcNow: " + d3);
            Console.WriteLine("Utilizando o construtor DateTime.Today: " + d4);

            Console.ReadKey();
        }





    }
}
