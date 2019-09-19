using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continua = true;
            
            List<Dados> listaJogos = new List<Dados>();
            do
            {
                Console.WriteLine("Quantidade de Jogos Cadastrados {0}", listaJogos.Count);
                Console.WriteLine("Menu Cadastro de Jogos:");
                Console.WriteLine("1-Incluir Um Novo Jogo");
                Console.WriteLine("2-Alterar Um Jogo");
                Console.WriteLine("3-Excluir Um Jogo");
                Console.WriteLine("4-Listar Todos os Jogos");
                Console.WriteLine("5-Pesquisa Jogo por Gênero");
                Console.WriteLine("6-Sair Do Programa :/");
                Console.WriteLine("Digite sua Opção:");
                String opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.Clear();
                        listaJogos.Add(incluirJogo());
                        Console.WriteLine("Jogo Inserido Com Sucesso !!");
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Insira o ID do Jogo a ser Alterado:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        listaJogos[id] = alterarJogo();
                        Console.WriteLine("Alteração Feita com Sucesso!");

                        break;
                    case "3":
                        
                        Console.WriteLine("Insira o ID do Jogo a ser Excluido:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tem Certeza que Deseja Excluir este jogo ? s ou n");
                        string resposta = Console.ReadLine();
                        if (resposta == "s")
                        {
                            listaJogos.RemoveAt(id2);
                            Console.WriteLine("Exclusão Feita com Sucesso!");
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Listagem de Itens:");
                        foreach (Dados jogos in listaJogos)
                        {
                            Console.WriteLine($"Nome:{jogos.Nome}");
                            Console.WriteLine($"Gênero:{jogos.Genero}");
                            Console.WriteLine($"Preço:{jogos.Preco}");
                            Console.WriteLine($"Nota:{jogos.Nota}");
                            Console.WriteLine($"Data:{jogos.Data}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Insira o Gênero do Jogo para Fazer a Pesquisa:");
                        string genero = (Console.ReadLine());
                        Console.WriteLine($"Nome:{listaJogos.Find(x => x.Genero == genero).Nome}");
                        Console.WriteLine($"Gênero:{listaJogos.Find(x => x.Genero == genero).Genero}");
                        Console.WriteLine($"Preço:{listaJogos.Find(x => x.Genero == genero).Preco}");
                        break;
                    case "6":
                        Console.Clear();
                         Console.WriteLine("Saindo do Programa, Obrigado Por Usar");
                            System.Threading.Thread.Sleep(500);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(500);
                            Console.Write(".");
                            System.Threading.Thread.Sleep(500);
                            Console.Write(".");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Opção Não Existente");
                        break;
                }
            } while (continua);
        }
        private static Dados incluirJogo()
        {
            Dados jogo = new Dados();
            Console.WriteLine("Incluir Novo Jogo");
            Console.Write("Nome:");
            jogo.Nome = Console.ReadLine();

            Console.Write("Gênero:");
            jogo.Genero = Console.ReadLine();

            Console.Write("Preço: ");
            jogo.Preco = Console.ReadLine();

            Console.Write("Nota do Jogo: ");
            jogo.Nota = float.Parse(Console.ReadLine());

            Console.Write("Data de Lançamento: ");
            jogo.Data = Console.ReadLine();
            
            

            return jogo;
        }
        private static Dados alterarJogo()
        {
            Dados jogo = new Dados();
            Console.Write("Novo Jogo: ");
            jogo.Nome = Console.ReadLine();

            Console.Write("Novo Gênero: ");
            jogo.Genero = Console.ReadLine();

            Console.Write("Novo Preço: ");
            jogo.Preco = Console.ReadLine();

            Console.Write("Nota do Jogo: ");
            jogo.Nota = float.Parse(Console.ReadLine());

            Console.Write("Data: ");
            jogo.Data = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Novos Dados:");
            Console.WriteLine("Jogo: " + jogo.Nome);
            Console.WriteLine("Gênero: " + jogo.Genero);
            Console.WriteLine("Preço: " + jogo.Preco);
            Console.WriteLine("Nota: " + jogo.Nota);
            Console.WriteLine("Data: " + jogo.Data);


            return jogo;
        }
    }
}
