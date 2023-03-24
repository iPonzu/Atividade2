using System;

namespace Model
{
    public class Sessao
    {
        public int id_Sessao { get; set; }
        public int user_id { get; set; }
        public string token { get; set;}
        public DateTime data_criacao { get; set; }
        public DateTime data_expiracao { get; set; }

        public static List<Sessao> Sessoes { get; set; } = new List<Sessao>();

        public Sessao(
            int Id_Sessao,
            int User_id,
            string Token,
            DateTime Data_criacao,
            DateTime Data_expiracao
        ){
            id_Sessao = Id_Sessao;
            user_id = User_id;
            token = Token;
            data_criacao = Data_criacao;
            data_expiracao = Data_expiracao;

            Sessoes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {id_Sessao}, User_Id: {user_id}, Token: {token}, Data_Criação: {data_criacao}, Data_Expiração: {data_expiracao} ";
        }

        public static void AlterarSessao(int id_Sessao, int User_id, string Token, DateTime Data_criacao, DateTime Data_expiracao){
            Sessao sessao = BuscarSessao(idSessao);
            sessao.user_id = User_id;
            sessao.token = Token;
            sessao.data_criacao = Data_criacao;
            sessao.data_expiracao = Data_expiracao;
        }

        public static void ExcluirSessao(int id_Sessao){
            Sessao sessao = BuscarSessao(idSessao);
            Sessoes.Remove(sessao);
        }

        public static Sessao BuscarSessao(int id_Sessao){
            Sessao? sessao = Sessoes.Find(c => c.idSessao == id_Sessao);
            if(sessao == null){
                throw new Exception("Sessão not found!");
            }
            return sessao;
        }
    } 
}