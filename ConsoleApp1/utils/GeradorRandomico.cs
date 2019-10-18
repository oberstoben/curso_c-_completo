using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVagas
{
    class GeradorRandomico
    {
        public int numeroRandomico(int inicio, int fim)
        {
            Random rnd = new Random();
            return rnd.Next(inicio, fim);
        }
    }
}
