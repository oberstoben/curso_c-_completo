using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula88
{
    class Ternario
    {
        /*
         * Estrutura opcional ao if-else quando se deseja deidir um valor com base em uma condição.
         * Sintaxe:
         * (condição) ? valor_se_verdadeiro : valor_se_falso.
         * */

        public string testaTernario(bool x)
        {

            return x ? "A condição é verdadeira !":"A condição é false !"; 
        }
    }
}
