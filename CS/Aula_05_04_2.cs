using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Aula_05_04_2
    {
        class Municipio
        {
            public string Nome { get; set; }
            public int Populacao { get; set; }
        }
        public class Aluno
        {
            public string Nome { get; set; }
            public string Curso { get; set; }
            public int Nota { get; set; }
        }
        static void NotMain(string[] args)
        {
            var municipios = new List<Municipio>();
            municipios.Add(new Municipio { Nome = "João Pessoa", Populacao = 100 });
            municipios.Add(new Municipio { Nome = "Santos", Populacao = 200 });
            municipios.Add(new Municipio { Nome = "Aracajú", Populacao = 300 });
            municipios.Add(new Municipio { Nome = "Curitiba", Populacao = 400 });
            municipios.Add(new Municipio { Nome = "Sorocaba", Populacao = 500 });
            municipios.Add(new Municipio { Nome = "Sinop", Populacao = 600 });

            var alunos = new List<Aluno>();
            alunos.Add(new Aluno { Nome = "Aluno 1", Curso = "Ciência da Computação" });
            alunos.Add(new Aluno { Nome = "Aluno 2", Curso = "Estatística" });
            alunos.Add(new Aluno { Nome = "Aluno 3", Curso = "Matemática" });
            alunos.Add(new Aluno { Nome = "Aluno 4", Curso = "Estatística" });
            alunos.Add(new Aluno { Nome = "Aluno 5", Curso = "Ciência da Computação" });
            alunos.Add(new Aluno { Nome = "Aluno 6", Curso = "Ciência da Computação" });

            //var consultaMunicipios =
            //    (from municipio in municipios
            //    where municipio.Nome.StartsWith("S")
            //    select municipio).Count();
            //count = contar, average = media, max...= maximo valor

            //foreach (var a in consultaMunicipios)
            //{
            //    Console.WriteLine(a.Nome);
            //}
            //Console.WriteLine(consultaMunicipios);

            var consultaAlunosPorCurso =
                from aluno in alunos
                group aluno by aluno.Curso;
            foreach (var groupCurso in consultaAlunosPorCurso)
            {
                Console.WriteLine("Nome do curso: {0}", groupCurso.Key);
                foreach (var nome in groupCurso)
                {
                    Console.WriteLine("Ingressantes: {0}", nome.Nome);
                }
            }
            Console.ReadKey();
        }
    }

}
