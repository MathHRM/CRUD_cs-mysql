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
        private void Form1_Load(object sender, EventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.TestaConexao();
            ShowAll();
            activateInputs();
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = inptName.Text,
                email = inptEmail.Text,
                telefone = inptTelefone.Text,
                cidade = inptCidade.Text,
                bairro = inptBairro.Text,
                estado = inptEstado.Text,
                cpf = inptCpf.Text; ;

            if (nome.Equals("") ||
                email.Equals("") ||
                telefone.Equals("") ||
                bairro.Equals("") ||
                estado.Equals("") ||
                cpf.Equals("") ||
                cidade.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Cadastro adicionar = new Cadastro();
            bool adicionado = adicionar.Adicionar(nome, email, telefone, cidade, bairro, estado, cpf);

            if (!adicionado)
            {
                MessageBox.Show("Funcionario não adicionado, verifique os dados ou tente novamente");
                return;
            }

            Limpar();
            ShowAll();
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            desactivateButtons();
            desactivateInputs();

            btnCancelar.Visible = true;
            btnConfirmarPesquisa.Visible = true;
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
            ShowAll();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            // caso clicado antes de uma pesquisa irá direcioanr a uma
            if (inptID.Text.Equals(""))
            {
                desactivateButtons();
                desactivateInputs();

                btnCancelar.Visible = true;
                btnConfirmarPesquisa.Visible = true;
                return;
            }

            // caso clicado após uma pesquisa irá editar o resultado
            desactivateButtons();
            activateInputs();

            btnCancelar.Visible = true;
            btnConfirmarExcluir.Visible = false;
            btnConfirmarEdicao.Visible = true;
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            string nome = inptName.Text,
                email = inptEmail.Text,
                telefone = inptTelefone.Text,
                cidade = inptCidade.Text,
                bairro = inptBairro.Text,
                estado = inptEstado.Text,
                cpf = inptCpf.Text;


            int id = int.Parse(inptID.Text);

            if (nome.Equals("") ||
                email.Equals("") ||
                telefone.Equals("") ||
                bairro.Equals("") ||
                estado.Equals("") ||
                cidade.Equals("") ||
                cpf.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Cadastro update = new Cadastro();
            update.Update(nome, email, telefone, cidade, bairro, estado, cpf, id);


            btnConfirmarEdicao.Visible = false;
            btnCancelar.Visible = false;

            activateButtons();
            Limpar();
            ShowAll();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            desactivateButtons();
            desactivateInputs();

            btnCancelar.Visible = true;
            btnConfirmarPesquisa.Visible = true;
        }

        private void btnConfirmarPesquisa_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            int id = int.Parse(inptID.Text);
            Cadastro pesquisar = new Cadastro();
            var funcionario = pesquisar.Pesquisar(id);

            if (funcionario == null)
            {
                MessageBox.Show("Funcionario não encontrado: não existe");
                return;
            }

            if (!funcionario.HasRows)
            {
                MessageBox.Show("Funcionario não encontrado: sem dados");
                return;
            }

            funcionario.Read();

            inptName.Text = funcionario["nome"].ToString();
            inptEmail.Text = funcionario["email"].ToString();
            inptTelefone.Text = funcionario["telefone"].ToString();
            inptCidade.Text = funcionario["cidade"].ToString();
            inptBairro.Text = funcionario["bairro"].ToString();
            inptEstado.Text = funcionario["estado"].ToString();

            desactivateInputs();
            desactivateButtons();

            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnConfirmarExcluir.Visible = true;
            btnConfirmarPesquisa.Visible = false;

            inptID.ReadOnly = true;
            inptID.BackColor = Color.LightGray;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activateButtons();
            activateInputs();
            Limpar();

            btnConfirmarEdicao.Visible = false;
            btnConfirmarPesquisa.Visible = false;
            btnConfirmarExcluir.Visible = false;
            btnCancelar.Visible = false;
        }



        private void ShowAll()
        {
            Cadastro pesquisar = new Cadastro();
            var tabela = pesquisar.PesquisarTodos();

            DataTable dt = new DataTable();
            dt.Load(tabela);

            dataGridTable.DataSource = dt;
            dataGridTable.AutoResizeColumns();
        }



        private void dataGridTable_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.Rows.Count;
            string idSelecionado;

            if (contLinhas > 0)
            {
                bool rowSelecionado = dataGridTable.SelectedRows.Count > 0;
                if (rowSelecionado)
                {
                    idSelecionado = dataGridTable.Rows[dataGridTable.SelectedRows[0].Index].Cells[0].Value.ToString();
                    inptID.Text = idSelecionado;
                    pesquisar();
                }
            }
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
            inptCpf.ReadOnly = false;
            inptCpf.BackColor = Color.White;
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
            inptCpf.ReadOnly = true;
            inptCpf.BackColor = Color.LightGray;
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
            inptCpf.Clear();
        }
    }
}
