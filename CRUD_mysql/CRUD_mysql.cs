using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CRUD_mysql
{
    internal class Cadastro
    {
        private MySqlConnection _conxSql = new MySqlConnection(BDInfo.Server);

        public bool Adicionar(string nome, string email, string telefone, string cidade, string bairro, string estado, string cpf)
        {
            try
            {
                _conxSql.Open();
                var comando = new MySqlCommand(
                    $"INSERT INTO {BDInfo.Table} (nome, email, telefone, cidade, bairro, estado, cpf) values (@nome, @email, @telefone, @cidade, @bairro, @estado, @cpf);", _conxSql);

                SetParametros(comando, nome, email, telefone, cidade, bairro, estado, cpf);

                comando.ExecuteNonQuery();
                _conxSql.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ao BD\n" + ex.Message);
                return false;
            }
        }



        public void Update(string nome, string email, string telefone, string cidade, string bairro, string estado, string cpf, int id)
        {
            try
            {
                _conxSql.Open();
                var comando = new MySqlCommand(
                    $"UPDATE {BDInfo.Table} SET nome = @nome, email = @email, telefone = @telefone, cidade = @cidade, bairro = @bairro, estado = @estado, cpf = @cpf WHERE id = {id};", _conxSql);

                SetParametros(comando, nome, email, telefone, cidade, bairro, estado, cpf);

                comando.ExecuteNonQuery();
                _conxSql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar ao BD\n" + ex.Message);
            }
        }


        private void SetParametros(MySqlCommand comando, string nome, string email, string telefone, string cidade, string bairro, string estado, string cpf)
        {
            comando.Parameters.Add("@nome", MySqlDbType.VarChar, 50);
            comando.Parameters.Add("@email", MySqlDbType.VarChar, 100);
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar, 20);
            comando.Parameters.Add("@cidade", MySqlDbType.VarChar, 50);
            comando.Parameters.Add("@bairro", MySqlDbType.VarChar, 50);
            comando.Parameters.Add("@estado", MySqlDbType.VarChar, 50);
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar, 14);

            comando.Parameters["@nome"].Value = nome;
            comando.Parameters["@email"].Value = email;
            comando.Parameters["@telefone"].Value = telefone;
            comando.Parameters["@cidade"].Value = cidade;
            comando.Parameters["@bairro"].Value = bairro;
            comando.Parameters["@estado"].Value = estado;
            comando.Parameters["@cpf"].Value = cpf;
        }



        public void Remover(int ID)
        {
            try
            {
                _conxSql.Open();
                var comando = new MySqlCommand(
                    $"DELETE FROM {BDInfo.Table} WHERE id={ID}", _conxSql);
                comando.ExecuteNonQuery();
                _conxSql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aoremover do BD" + ex.Message);
            }
        }



        public MySqlDataReader Pesquisar(int ID)
        {
            try
            {
                _conxSql.Open();
                var comando = new MySqlCommand(
                    $"SELECT * FROM {BDInfo.Table} WHERE id = {ID};", _conxSql);

                var reader = comando.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aoremover do BD" + ex.Message);
                return null;
            }
        }



        public MySqlDataReader PesquisarTodos()
        {
            try
            {
                _conxSql.Open();
                var comando = new MySqlCommand(
                    $"SELECT * FROM {BDInfo.Table};", _conxSql);

                var reader = comando.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aoremover do BD" + ex.Message);
                return null;
            }
        }



        public bool TestaConexao()
        {
            try
            {
                _conxSql.Open();
                Console.WriteLine("Conexão ao DB concluida");
                _conxSql.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao BD" + ex.Message);
                return false;
            }
        }
    }
}
