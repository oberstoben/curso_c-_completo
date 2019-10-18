using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVagas
{
    class Quarto
    {
        private Estudante estudante;
        private int numero;

        public Estudante getEstudante()
        {
            return estudante;
        }

        public void setEstudante(Estudante estudante)
        {
            this.estudante = estudante;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public Quarto()
        {

        }

        public Quarto(Estudante estudante, int numero)
        {
            this.estudante = estudante;
            this.numero = numero;
        }
        
    }
}
