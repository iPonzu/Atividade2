using System.Collections.Generic;
using System;

namespace Controller
{
    public class Sessao
    {
          public static void CadastrarSessao(
              string id_Sessao,
              string user_id,
              string token,
              string data_criacao,
              string data_expiracao
          ){

              int idConvert = 0;
              try{
                  idConvert = int.Parse(id_Sessao);
              }catch(Exception){
                  throw new Exception("Este ID não é válido");
              }

              int user_idConvert = 0;
              try{
                  idConvert = int.Parse(user_id);
              }catch(Exception){
                  throw new Exception("Este ID não é válido");
              }
              DateTime dataConvert = DateTime.Parse(data_criacao);
              DateTime dateConvert = DateTime.Parse(data_expiracao);
              Model.Sessao sessao = new Model.Sessao(idConvert, user_idConvert, token, dataConvert, dateConvert);
          }
    
        public static void AlterarSessao(
            string id_Sessao,
            string user_id,
            string token,
            string data_criacao,
            string data_expiracao
          ){

              int idConvert = 0;
              try{
                  idConvert = int.Parse(id_Sessao);
              }catch(Exception){
                  throw new Exception("Este ID não é válido");
              }
              
              int user_idConvert = 0;
              try{
                    idConvert = int.Parse(user_id);
              }catch(Exception) {
                    throw new Exception("Este ID não é válido");
              }
              DateTime dataConvert = DateTime.Parse(data_criacao);
              DateTime dateConvert = DateTime.Parse(data_expiracao);
              Model.Sessao.AlterarSessao(idConvert, user_idConvert, token, dataConvert, dateConvert);
          }
     
          public static void ExcluirSessao(string id)
          {
              int idConvert = 0;
              try{
                  idConvert = int.Parse(id);
              }catch(Exception){
                  throw new Exception("Este ID não é válido");
              }
              Model.Sessao.ExcluirSessao(idConvert);
          }
          
          public static List<Model.Sessao> ListarSessoes()
          {
               return Model.Sessao.Sessoes;
          }
      }
 }