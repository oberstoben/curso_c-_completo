using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicosEspeciais.aula89
{
    /// <summary>
    /// Esta classe mostra algumas funções das strings.
    /// ToUpper()
    /// ToLower()
    /// Trim()
    /// SubString(int index)
    /// SubString(int inicial, int final)
    /// IsNullOrEmpty(string x)
    /// IsNullOrWhiteSpace(string x)
    /// </summary>
    class FuncoesString
    {
        private string original = "Eu sou a mensagem original !";

        public void aumentaTudo()
        {
            Console.WriteLine("Eu sou a mensagem aumentada através do toUPPER(): "+this.original.ToUpper());
        }

        public void diminuiTudo()
        {
            Console.WriteLine("Eu sou a mensagem aumentada através do toUPPER(): " + this.original.ToLower());
        }

        public void apagaEspacosEmBranco()
        {
            Console.WriteLine("Eu sou a mensagem usando a trim(): " + this.original.Trim());
        }

        public void procurando()
        {
            Console.WriteLine("Eu sou a mensagem aumentada através do toUPPER(): " + this.original.ToUpper());
        }

        public void parteDaString(int index)
        {
            Console.WriteLine("Eu sou parte da string, a partir do indice{0}:{1} ",index,this.original.Substring(index));
        }

        public void parteDaString(int indexInicial, int indexFinal)
        {
            Console.WriteLine("Eu sou parte da string, a partir do indice{0}:{1} ", indexInicial, this.original.Substring(indexInicial,indexFinal));
        }

        public void verificaNuloOuVazio()
        {
            Console.WriteLine("A mensagem é:", String.IsNullOrEmpty(this.original).ToString());
        }

        public void verificaNuloOuEspacoEmBranco()
        {
            Console.WriteLine("A mensagem é:", String.IsNullOrWhiteSpace(this.original).ToString());
        }
    }
}
