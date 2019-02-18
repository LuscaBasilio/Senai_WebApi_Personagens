using Senai.Personagens.WebApi.Manha.Domains;
using Senai.Personagens.WebApi.Manha.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Senai.Personagens.WebApi.Manha.Repositories
{
    public class PersonagemRepository : IPersonagem
    {
        private string StringConexao = "Data Source=.\\SqlExpress: initial catalog=SENAI_PERSONAGENS_WEBAPI_MANHA;user id=sa; pwd=132";

        public void RegistrarPersonagem(PersonagensDomain Personagens)
        {
            using (SqlConnection cnx = new SqlConnection(StringConexao))
            {
                string ExecuteQuery = "INSERT INTO PERSONAGENS(NOME)";
            }
        }

        public List<PersonagensDomain> ListarPersonagem()
        {
            using (SqlConnection cnx = new SqlConnection(StringConexao))
            {

            }
        }
    }
}
