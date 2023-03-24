namespace View 
{
    public class Perfil
    {
        public static void CadastrarPerfil()
        {
            Console.WriteLine("Cadastrar perfil");
            Console.WriteLine("Digite o ID do perfil: ");
            string idPerfil = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o tipo do perfil: ");
            string tipo = Console.ReadLine();
          
            try{
                Controller.Perfil.CadastrarPerfil(idPerfil, user_id, tipo);
                Console.WriteLine("Perfil cadastrado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao cadastrar o perfil: {e.Message}");
            }
        }

        public static void AlterarPerfil()
        {
            Console.WriteLine("Digite o ID do perfil: ");
            string idPerfil = Console.ReadLine();
            Console.WriteLine("Digite o ID do usuário: ");
            string user_id = Console.ReadLine();
            Console.WriteLine("Digite o tipo do perfil: ");
            string tipo = Console.ReadLine();
            try{
                Controller.Perfil.AlterarPerfil(idPerfil, user_id, tipo);
                Console.WriteLine("Perfil alterado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar o perfil: {e.Message}");
            }
        }

        public static void ExcluirPerfil()
        {
            Console.WriteLine("Digite o ID do perfil: ");
            string idPerfil = Console.ReadLine();
            try{
                Controller.Perfil.ExcluirPerfil(idPerfil);
                Console.WriteLine("Perfil excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir o perfil: {e.Message}");
            }
        }

        public static void ListarPerfis(){
            Console.WriteLine("Listar Perfis");
            foreach (Model.Perfil perfil in Controller.Perfil.ListarPerfis()) {
                Console.WriteLine(perfil);
            }
        }
    }           
}