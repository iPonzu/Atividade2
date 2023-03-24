namespace Controller
{
    public class User
    {
        public static void CadastrarUser(
            string id_User,
            string name, 
            string email,
            string password
        ){
            int idConvert = 0;
            try{
                idConvert = int.Parse(id_User);
            }catch(Exception ) {
                throw new Exception("Este Id não é válido");
            }
            Model.User user = new Model.User(idConvert, name, email, password);
            
        }
        
        public static void AlterarUser(
            string id_User,
            string name,
            string email,
            string password
        ){
            int idConvert = 0;
            try{
                idConvert = int.Parse(id_User);
            }catch(Exception) {
                throw new Exception("Este Id não é válido");
            }
            Model.User.AlterarUser(idConvert, name, email, password);
        }
        
        public static void ExcluirUser(string id)
        {
            
            int idConvert = 0;
            try{
                idConvert = int.Parse(id);
            }catch(Exception) {
                throw new Exception("Este Id não é válido");
            }
            Model.User.ExcluirUser(idConvert);
        }
                  
        public static List<Model.User> ListarUsers()
        {
            return Model.User.Users;
        }
    }   
}