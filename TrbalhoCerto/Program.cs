using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string opcao = "1";

            while (opcao == "1")

            {
                Console.WriteLine("Digite o produto desejado");
                string ProdutoParaAdicionar = Console.ReadLine();
                lista.Add(ProdutoParaAdicionar);

                Console.WriteLine("Senhor(a), se ainda quer adicionar produtos a sua lista apete [1], caso não querira, aperte [2]");

                opcao = Console.ReadLine();



                lista.Sort();
                Console.WriteLine("A lista contém" + lista.Count + "itens:");

                for
                    (int i = 0; i < lista.Count; i++)

                {
                    Console.WriteLine(lista[i]);
                }

                {
                    Console.WriteLine("Deseja remover algo senhor(a)?  SIM [3]  NAO [4]");
                    opcao = Console.ReadLine();
                    if (opcao == "3")
                    {
                        Console.WriteLine("Qual produto deseja retirar senhor(a)?");

                        string ProdutoParaAdicionar = Console.ReadLine();
                        lista.Remove(ProdutoParaAdicionar);
                        Console.WriteLine("O produto foi retirado com sucesso!");
                    }
                    else
                    {
                        lista.Sort();
                        {
                            Console.WriteLine("A lista contém" + lista.Count + "itens:");
                        }

                        for
                            (int i = 0; i < lista.Count; i++) ;
                    }

                    Console.WriteLine(lista[i]);
                }

            }



            Console.ReadKey();
        }
    }
}