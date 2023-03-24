namespace View 
{
    public class User
    {
        public static void CadastrarUser()
        {
            Console.WriteLine("Cadastrar usuário");
            Console.WriteLine("Digite o ID do usuário: ");
            string idUser = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuário: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o E-mail: ");
            string email = Console.ReadLine();  
            Console.WriteLine("Digite a senha: ");
            string password = Console.ReadLine();
            try{
                Controller.User.CadastrarUser(idUser, name, email, password);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao cadastrar o usuário: {e.Message}");
            }
        }

        public static void AlterarUser()
        {
            Console.WriteLine("Digite o ID do usuáro: ");
            string idUser = Console.ReadLine();
            Console.WriteLine("Digite o Nome do usuário: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o E-mail: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string password = Console.ReadLine();
            try{
                Controller.User.AlterarUser(idUser, name, email, password);
                Console.WriteLine("Usuário alterado com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao alterar o usuário: {e.Message}");
            }
        }

        public static void ExcluirUser()
        {
            Console.WriteLine("Digite o ID do usuário: ");
            string idUser = Console.ReadLine();
            try{
                Controller.User.ExcluirUser(idUser);
                Console.WriteLine("Usuário excluido com sucesso!");
            }catch(Exception e) {
                Console.WriteLine($"Erro ao excluir o usuário: {e.Message}");
            }
        }

        public static void ListarUsers(){
            Console.WriteLine("Listar Usuários");
            foreach (Model.User user in Controller.User.ListarUsers()) {
                Console.WriteLine(user);
            }
        }
    }           
}