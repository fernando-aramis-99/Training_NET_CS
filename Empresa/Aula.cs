using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Aula
    {
        public string _Materia { set; get; }
        public string _Aluno { set; get; }
        public DateTime _DataAula { set; get; }

        public Aula(string materia, string aluno, DateTime dataAula)
        {
            _Materia = materia;
            _Aluno = aluno;
            _DataAula = dataAula;
        }
    }
}