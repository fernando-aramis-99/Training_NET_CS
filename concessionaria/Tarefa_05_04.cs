using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaria
{
    class Tarefa_05_04
    {
        //Montar uma lista dos 10 carros mais vendidos em 2021
        //Tendo uma lista de carros (Nome do carro, Mome da Marca, TotalVendidos )
        //Listar todos os carros da marca FIAT
        //Agrupar os carros por marca e agrupar os mais vendidos em resultado; Ordenar por mais vendidos em resultado 
        static void Main(string[] args)
        {
            var carros = new List<Carro>();
            carros.Add(new Carro { Modelo = "Creta Confort", NomeMarca = "Hyundai", Preco = 109990, TotalVendidos = 64759 }); /*{10}*/
            carros.Add(new Carro { Modelo = "Mobi Trekking", NomeMarca = "Fiat", Preco = 47390, TotalVendidos = 65847 }); /*{9}*/
            carros.Add(new Carro { Modelo = "Gol 1.6 MSI Flex", NomeMarca = "Volkswagen", Preco = 60051, TotalVendidos = 66228 }); /*{8}*/
            carros.Add(new Carro { Modelo = "Toro 2.0 TDI Volcano", NomeMarca = "Fiat", Preco = 175392, TotalVendidos = 70890 }); /*{7}*/
            carros.Add(new Carro { Modelo = "Compass 2.0 Flex", NomeMarca = "Jeep", Preco = 165007, TotalVendidos = 70906 }); /*{6}*/
            carros.Add(new Carro { Modelo = "Onix Hatch 1.0", NomeMarca = "Chevrolet", Preco = 72854, TotalVendidos = 73623 }); /*{5}*/
            carros.Add(new Carro { Modelo = "Renegade Longitude 1.8", NomeMarca = "Jeep", Preco = 123983, TotalVendidos = 73913 }); /*{4}*/
            carros.Add(new Carro { Modelo = "Argo Trekking 1.8", NomeMarca = "Fiat", Preco = 91280, TotalVendidos = 84644 }); /*{3}*/
            carros.Add(new Carro { Modelo = "HB20 Sport 1.0", NomeMarca = "Hyundai", Preco = 88277, TotalVendidos = 86455 }); /*{2}*/
            carros.Add(new Carro { Modelo = "Strada Endurance 1.4", NomeMarca = "Fiat", Preco = 95028, TotalVendidos = 109107 }); /*{1}*/

            var marcas = new List<Marca>();
            marcas.Add(new Marca { MarcaId = 100, NomeMarca = "Fiat" });
            marcas.Add(new Marca { MarcaId = 110, NomeMarca = "Hyundai" });
            marcas.Add(new Marca { MarcaId = 120, NomeMarca = "Volkswagen" });
            marcas.Add(new Marca { MarcaId = 130, NomeMarca = "Jeep" });
            marcas.Add(new Marca { MarcaId = 140, NomeMarca = "Chevrolet" });

            foreach (var marca in marcas)
            {
                Console.WriteLine("\nMarca: " + marca.NomeMarca);
                foreach (var modelo in carros)
                {
                    if (marca.NomeMarca == modelo.NomeMarca)
                        Console.WriteLine("\nModelo: " + modelo.Modelo);
                }
                Console.WriteLine("\n=============================");
            }

            var ConsultaVenda =
                from Carro in carros
                orderby Carro.TotalVendidos
                select new { quantidade = Carro.TotalVendidos, modelo = Carro.Modelo };

            Console.WriteLine("Ranking de vendas de 2021");

            foreach (var venda in ConsultaVenda)
            {
                Console.WriteLine("\nModelo : {0} Quantidade de Vendas: {1}", venda.modelo, venda.quantidade);
            }

            Console.ReadKey();
        }
    }
}
