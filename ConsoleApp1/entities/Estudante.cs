using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVagas
{
    class Estudante
    {
        public int MyProperty;
        private string nome;
        private string email;

        public Estudante()
        {
        }

        public Estudante(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string  getEmail()
        { 
            return this.email;  
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}
