using System;
using System.Collections.Concurrent;

namespace Model
{
    public class Perfil
    {
        public int id_Perfil{ get; set; }
        public int user_id{ get; set; }
        public string admin{ get; set; }
        public string user{ get; set;}

        public static List<Perfil> Perfis { get; set; } = new List<Perfil>();

        public Perfil(
            int Id_Perfil,
            int User_id,
            string Admin,
            string User
        ){
            Id_Perfil = id_Perfil;
            user_id = User_id;
            admin = Admin;
            user = User;

            Perfis.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {id_Perfil}, User_id: {user_id}, Admin: {admin}, User: {user}";
        }

        public static void AlterarPerfil(int id_Perfil, int User_id, string Admin, string User){
            Perfil perfil = BuscarPerfil(id_Perfil);
            perfil.user_id = User_id;
            perfil.admin = Admin;
            perfil.user = User;
        }

        public static void ExcluirPerfil(int id_Perfil){
            Perfil perfil = BuscarPerfil(id_Perfil);
            Perfis.Remove(perfil);
        }

        public static Perfil BuscarPerfil(int id_Perfil){
            Perfil? perfil = Perfis.Find(c=> c.id_Perfil == id_Perfil);
            if(perfil == null){
                throw new Exception("Perfil não encontrado!");
            }
            return perfil;
        }
    }
}