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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            if (nome.Equals("") ||
                email.Equals("") ||
                telefone.Equals("") ||
                bairro.Equals("") ||
                estado.Equals("") ||
                cidade.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Cadastro adicionar = new Cadastro();
            adicionar.Adicionar(nome, email, telefone, cidade, bairro, estado);
            Limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.TestaConexao();
            swipeInputs();
        }

        private void swipeInputs()
        {
            if(inptID.ReadOnly)
            {
                inptID.ReadOnly = false;
                inptID.BackColor = Color.White;

                btnCancelar.Visible = true;
                btnExcluir.Visible = true;

                btnAdicionar.Visible = false;
                btnEditar.Visible = false;

                inptName.ReadOnly = true;
                inptName.BackColor = Color.LightGray;
                inptEmail.ReadOnly = true;
                inptEmail.BackColor = Color.LightGray;
                inptTelefone.ReadOnly = true;
                inptTelefone.BackColor = Color.LightGray;
                inptCidade.ReadOnly = true;
                inptCidade.BackColor = Color.LightGray;
                inptBairro.ReadOnly = true;
                inptBairro.BackColor = Color.LightGray;
                inptEstado.ReadOnly = true;
                inptEstado.BackColor = Color.LightGray;
                return;
            }

            inptID.ReadOnly = true;
            inptID.BackColor = Color.LightGray;

            btnCancelar.Visible = false;
            btnExcluir.Visible = false;

            btnAdicionar.Visible = true;
            btnEditar.Visible = true;

            inptName.ReadOnly = false;
            inptName.BackColor = Color.White;
            inptEmail.ReadOnly = false;
            inptEmail.BackColor = Color.White;
            inptTelefone.ReadOnly = false;
            inptTelefone.BackColor = Color.White;
            inptCidade.ReadOnly = false;
            inptCidade.BackColor = Color.White;
            inptBairro.ReadOnly = false;
            inptBairro.BackColor = Color.White;
            inptEstado.ReadOnly = false;
            inptEstado.BackColor = Color.White;
            return;
        }

        private void Limpar()
        {
            inptName.Clear();
            inptEmail.Clear();
            inptTelefone.Clear();
            inptCidade.Clear();
            inptBairro.Clear();
            inptEstado.Clear();
            inptID.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            swipeInputs();
            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (inptID.Equals(""))
            {
                MessageBox.Show("Digite um ID");
                return;
            }

            int id = int.Parse(inptID.Text);

            Cadastro excluir = new Cadastro();
            excluir.Remover(id);
            Limpar();

            inptID.Clear();
            swipeInputs();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            swipeInputs();
            Limpar();
            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            swipeInputs();
            btnAdicionar.Visible = false;
            btnExcluir.Visible = false;
        }
    }
}
