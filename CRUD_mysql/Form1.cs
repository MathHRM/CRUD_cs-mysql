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
            activateInputs();
        }

        private void activateInputs()
        {
            inptID.ReadOnly = true;
            inptID.BackColor = Color.LightGray;

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
        }
        private void desactivateInputs()
        {
            inptID.ReadOnly = false;
            inptID.BackColor = Color.White;

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
        }


        private void activateButtons()
        {
            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnRemover.Visible = true;
            btnEditar.Visible = true;
            btnPesquisar.Visible = true;
        }
        private void desactivateButtons()
        {
            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnRemover.Visible = false;
            btnPesquisar.Visible = false;
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
            desactivateButtons();
            desactivateInputs();
            btnCancelar.Visible = true;
            btnConfirmarExcluir.Visible = true;
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
            activateButtons();
            activateInputs();
            btnConfirmarExcluir.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activateButtons();
            activateInputs();
            btnConfirmarEdicao.Visible = false;
            btnConfirmarPesquisa.Visible = false;
            btnConfirmarExcluir.Visible = false;
            btnCancelar.Visible = false;
            Limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (inptID.Text.Equals(""))
            {
                desactivateButtons();
                desactivateInputs();
                btnCancelar.Visible = true;
                btnConfirmarPesquisa.Visible = true;
                return;
            }

            desactivateButtons();
            activateInputs();
            btnCancelar.Visible = true;
            btnConfirmarExcluir.Visible = false;
            btnConfirmarEdicao.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            desactivateButtons();
            desactivateInputs();
            btnCancelar.Visible = true;
            btnConfirmarPesquisa.Visible = true;
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            string nome = inptName.Text,
                email = inptEmail.Text,
                telefone = inptTelefone.Text,
                cidade = inptCidade.Text,
                bairro = inptBairro.Text,
                estado = inptEstado.Text;

            int id = int.Parse(inptID.Text);

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

            Cadastro update = new Cadastro();
            update.Update(nome, email, telefone, cidade, bairro, estado, id);
            activateButtons();
            btnConfirmarEdicao.Visible = false;
            btnCancelar.Visible = false;
            Limpar();
        }

        private void btnConfirmarPesquisa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(inptID.Text);
            Cadastro pesquisar = new Cadastro();
            var funcionario = pesquisar.Pesquisar(id);

            if (funcionario == null)
            {
                MessageBox.Show("Funcionario não encontrado null");
                return;
            }

            if (!funcionario.HasRows)
            {
                MessageBox.Show("Funcionario não encontrado sem dados");
                return;
            }

            funcionario.Read();

            inptName.Text = funcionario["nome"].ToString();
            inptEmail.Text = funcionario["email"].ToString();
            inptTelefone.Text = funcionario["telefone"].ToString();
            inptCidade.Text = funcionario["cidade"].ToString();
            inptBairro.Text = funcionario["bairro"].ToString();
            inptEstado.Text = funcionario["estado"].ToString();

            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnConfirmarExcluir.Visible = true;
            inptID.ReadOnly = true;
            inptID.BackColor = Color.LightGray;
            btnConfirmarPesquisa.Visible = false;
        }
    }
}
