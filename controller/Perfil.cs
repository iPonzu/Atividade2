namespace Controller
{
    public class Perfil
    {
        public static void CadastrarPerfil(
            string id_Perfil,
            string name, 
            string email,
            string password
        ){
            int id_Perfil = 0;
            try{
                idConvert = int.Parse(id_Perfil);
        }catch(Exception) {
            throw new Exception("Este ID é inválido!");
        }

        Model.Perfil perfil = new Model.Perfil(id_Perfil, name, email, password);
        }
    }
}