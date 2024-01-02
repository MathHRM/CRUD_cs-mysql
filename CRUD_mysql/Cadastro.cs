using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD_mysql
{
    internal class Cadastro
    {
        private const string _server = "localhost";
        private const string _uid = "root";
        private const string _pwd = "senhasql";
        private const string _database = "mydb";
        private MySqlConnection conxSql = new MySqlConnection($"server={_server};uid={_uid};pwd={_pwd};database={_database};");

        public void Adicionar(string nome,string email, string telefone, string cidade, string bairro, string estado)
        {
            try
            {
                conxSql.Open();
                var comando = new MySqlCommand(
                    $"INSET INTO mytable (nome, email, telefone, cidade, bairro, estado) " +
                        $"values ({nome}, {email}, {telefone}, {cidade}, {bairro}, {estado})", conxSql);
                comando.ExecuteNonQuery();
                conxSql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ao BD" + ex.Message);
            }
            
        }

        public bool TestaConexao()
        {
            try
            {
                conxSql.Open();
                Console.WriteLine("Conexão ao DB concluida");
                conxSql.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao BD" + ex.Message);
                return false;
            }
        }
    }
}
