using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVagas
{
    class GeradorDeHospedes
    {
        public Estudante[] geraEstudantes()
        {
            Estudante[] estudantes = new Estudante[10];
            Estudante marcela = new Estudante("marcela", "marcela@email.com");
            Estudante vicky = new Estudante("vicky", "vicky@email.com");
            Estudante cristina = new Estudante("cristina", "cristina@email.com");
            Estudante aline = new Estudante("aline", "aline@email.com");
            Estudante cesar = new Estudante("cesar", "cesar@email.com"); 
            Estudante yuri = new Estudante("yuri", "yuri@email.com");
            Estudante marcelo = new Estudante("marcelo", "marcelo@email.com");
            Estudante cristiane = new Estudante("cristiane", "cristiane@email.com");
            Estudante matheus = new Estudante("matheus", "matheus@email.com");
            Estudante gabriel = new Estudante("gabriel", "gabriel@email.com");

            estudantes[0] = marcela;
            estudantes[1] = vicky;
            estudantes[2] = cristina;
            estudantes[3] = aline;
            estudantes[4] = cesar;
            estudantes[5] = yuri;
            estudantes[6] = marcelo;
            estudantes[7] = cristiane;
            estudantes[8] = matheus;
            estudantes[9] = gabriel;

            return estudantes;
        }
    }
}
