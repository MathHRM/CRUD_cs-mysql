using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = inptName.Text,
                email = inptEmail.Text,
                telefone = inptTelefone.Text,
                cidade = inptCidade.Text,
                bairro = inptBairro.Text,
                estado = inptEstado.Text;

            if (nome.Equals("") &&
                email.Equals("") &&
                telefone.Equals("") &&
                bairro.Equals("") &&
                estado.Equals("") &&
                cidade.Equals(""))
            {
                Console.WriteLine("Preencha todos os campos");
                return;
            }

            Console.WriteLine("valeu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.TestaConexao();
        }
    }
}
