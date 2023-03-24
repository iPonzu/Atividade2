namespace View 
{
    public class Sessao
    {
        public static void CadastrarSessao()
        {
            Console.WriteLine("Cadastrar perfil");
            Console.WriteLine("Digite o ID da sessão: ");
            string idSessao = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o Token: ");
            string token = Console.ReadLine();  
            Console.WriteLine("Digite a Data da Criação: ");
            string data_criacao = Console.ReadLine();
            Console.WriteLine("Digite a Data da Expiração: ");
            string data_expiracao = Console.ReadLine();
            try{
                Controller.Sessao.CadastrarSessao(idSessao, user_id, token, data_criacao, data_expiracao);
                Console.WriteLine("Sessão cadastrada com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao cadastrar a sessão: {e.Message}");
            }
        }

        public static void AlterarSessao()
        {
            Console.WriteLine("Digite o ID da Sessão: ");
            string idSessao = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o Token ");
            string token = Console.ReadLine();
            Console.WriteLine("Digite a Data da Criação: ");
            string data_criacao = Console.ReadLine();
            Console.WriteLine("Digite a Data da Expiração: ");
            string data_expiracao = Console.ReadLine();
            try{
                Controller.Sessao.AlterarSessao(idSessao, user_id, token, data_criacao, data_expiracao); 
                Console.WriteLine("Sessão alterada com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar o perfil: {e.Message}");
            }
        }

        public static void ExcluirSessao()
        {
            Console.WriteLine("Digite o ID da Sessão: ");
            string idSessao = Console.ReadLine();
            try{
                Controller.Perfil.ExcluirPerfil(idSessao);
                Console.WriteLine("Sessão excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir a sessão: {e.Message}");
            }
        }

        public static void ListarSessoes(){
            Console.WriteLine("Listar Sessões");
            foreach (Model.Sessao sessao in Controller.Sessao.ListarSessoes()) {
                Console.WriteLine(sessao);
            }
        }
    }           
}