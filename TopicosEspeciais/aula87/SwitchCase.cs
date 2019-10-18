using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula87
{
    class SwitchCase
    {
        /*
         * Estrutura de decisão opcional ao if-else.
         */ 
         
        public void diaAtual()
        {
          int diaDaSemana=(int) DateTime.Now.DayOfWeek;
            string dia;
          switch(diaDaSemana)
            {
                case 0:
                    dia = "domingueira";
                    break;
                case 1:
                    dia = "segunda-feira";
                    break;
                case 2:
                    dia = "terça-feira";
                    break;
                case 3:
                    dia = "quarta-feira";
                    break;
                case 4:
                    dia = "quinta-feira";
                    break;
                case 5:
                    dia = "sexta-feira";
                    break;
                case 6:
                    dia = "sabado";
                    break;
                default:
                    dia = "Yuri é monstro.";
                    break;

            }

            Console.WriteLine("hoje é {0}!",dia);
            Console.ReadLine();
        }
        
    }
}
