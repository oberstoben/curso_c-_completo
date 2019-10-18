using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula86
{
    class Var
    {
        /*
         *O c# consegue inferir o tipo da variaveis, através da palavra chave 'var', que só pode ser utilizada dentro
         * de métodos.
         */

        public void testaVar()
        {
            var x = 10;
            var y = 20.0;
            var z = "sbc";
            var w = z;
          

            Console.WriteLine("o tipo da variavel x é:{0} ", x.GetType());
            Console.WriteLine("o tipo da variavel y é:{0}", y.GetType());
            Console.WriteLine("o tipo da variavel z é:{0}", z.GetType());
            Console.WriteLine("o tipo da variavel w é:{0}", w.GetType());

            Console.ReadLine();

        }
        
        
    }
}
