using System;
using View;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("1 - Cadastrar Usuário");
            System.Console.WriteLine("2 - Alterar Usuário");
            System.Console.WriteLine("3 - Excluir Usuário");
            System.Console.WriteLine("4 - Listar Usuários");
            System.Console.WriteLine("5 - Cadastrar Perfil");
            System.Console.WriteLine("6 - Alterar Perfil");
            System.Console.WriteLine("7 - Excluir Perfil");
            System.Console.WriteLine("8 - Listar Perfis");
            System.Console.WriteLine("9 - Cadastrar Sessão");
            System.Console.WriteLine("10 - Alterar Sessão");
            System.Console.WriteLine("11 - Excluir Sessão");
            System.Console.WriteLine("12 - Listar Sessões");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("Digite a opção desejada: ");
        }

        public static void Menu(){
            int op = 0;
            do{
                Menu();
                op = int.Parse(Console.ReadLine());
                switch (op) {
                    case 1:
                        View.User.CadastrarUser();
                        break;
                    case 2:
                        View.User.AlterarUser();
                        break;
                    case 3:
                        View.User.ExcluirUser();
                        break;
                    case 4:
                        View.User.ListarUsers();
                        break; 
                    case 5:
                        View.Perfil.CadastrarPerfil();
                        break;
                    case 6:
                        View.Perfil.AlterarPerfil();
                        break;
                    case 7:
                        View.Perfil.ExcluirPerfil();
                        break;
                    case 8:
                        View.Perfil.ListarPerfis();
                        break;
                    case 9:
                        View.Sessao.CadastrarSessao();
                        break;
                    case 10:
                        View.Sessao.AlterarSessao();
                        break;
                    case 11:
                        View.Sessao.ExcluirSessao();
                        break;
                    case 12:
                        View.Sessao.ListarSessoes();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado e boa noite!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }while (op != 0);
        }
    }
}