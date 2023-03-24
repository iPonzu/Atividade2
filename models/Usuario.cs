using System;
using System.Collections.Generic;

namespace Model
{
    public class User
    {
        public int id_User { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public static List<User> Users { get; set; } = new List<User>();

        public User(
            int id_User,
            string Name,
            string Email,
            string Password
        ){
            Id_User = id_User;
            name = Name;
            email = Email;
            password = Password;

            Users.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {id_User}, Name: {name}, Email: {email}, Password: {password}";
        }

        public static void AlterarUser(int id_User, string name, string email, string password){
            User user = BuscarUser(id_User);
            user.name = name;
            user.email = email;
            user.password = password;
        }

        public static void ExcluirUser(int id_User){
            User user = BuscarUser(id_User);
            Users.Remove(user);
        }

        public static User BuscarUser(int id_User){
            User? user = Users.Find(c => c.id_User == id_User);
            if(user == null){
                throw new Exception("User not found!");
            }

            return user;
        }
    }
}