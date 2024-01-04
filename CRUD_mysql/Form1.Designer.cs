namespace CRUD_mysql
{
    partial class selectEstado
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.inptNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inptEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inptBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inptCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inptID = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.btnConfirmarExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEdicao = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnConfirmarPesquisa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inptCpf = new System.Windows.Forms.MaskedTextBox();
            this.inptEstado = new System.Windows.Forms.ComboBox();
            this.inptTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(17, 169);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // inptNome
            // 
            this.inptNome.Location = new System.Drawing.Point(80, 17);
            this.inptNome.Name = "inptNome";
            this.inptNome.Size = new System.Drawing.Size(543, 20);
            this.inptNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // inptEmail
            // 
            this.inptEmail.Location = new System.Drawing.Point(80, 43);
            this.inptEmail.Name = "inptEmail";
            this.inptEmail.Size = new System.Drawing.Size(364, 20);
            this.inptEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            // 
            // inptBairro
            // 
            this.inptBairro.Location = new System.Drawing.Point(80, 95);
            this.inptBairro.Name = "inptBairro";
            this.inptBairro.Size = new System.Drawing.Size(364, 20);
            this.inptBairro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade";
            // 
            // inptCidade
            // 
            this.inptCidade.Location = new System.Drawing.Point(80, 69);
            this.inptCidade.Name = "inptCidade";
            this.inptCidade.Size = new System.Drawing.Size(543, 20);
            this.inptCidade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // inptID
            // 
            this.inptID.BackColor = System.Drawing.SystemColors.Window;
            this.inptID.Location = new System.Drawing.Point(558, 123);
            this.inptID.Name = "inptID";
            this.inptID.Size = new System.Drawing.Size(65, 20);
            this.inptID.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(179, 169);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(98, 169);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.Location = new System.Drawing.Point(12, 213);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            this.dataGridTable.Size = new System.Drawing.Size(611, 225);
            this.dataGridTable.TabIndex = 18;
            this.dataGridTable.SelectionChanged += new System.EventHandler(this.dataGridTable_SelectionChanged);
            // 
            // btnConfirmarExcluir
            // 
            this.btnConfirmarExcluir.Location = new System.Drawing.Point(548, 184);
            this.btnConfirmarExcluir.Name = "btnConfirmarExcluir";
            this.btnConfirmarExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarExcluir.TabIndex = 19;
            this.btnConfirmarExcluir.Text = "Excluir";
            this.btnConfirmarExcluir.UseVisualStyleBackColor = true;
            this.btnConfirmarExcluir.Visible = false;
            this.btnConfirmarExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarEdicao
            // 
            this.btnConfirmarEdicao.Location = new System.Drawing.Point(548, 155);
            this.btnConfirmarEdicao.Name = "btnConfirmarEdicao";
            this.btnConfirmarEdicao.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEdicao.TabIndex = 21;
            this.btnConfirmarEdicao.Text = "Confirmar";
            this.btnConfirmarEdicao.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicao.Visible = false;
            this.btnConfirmarEdicao.Click += new System.EventHandler(this.btnConfirmarEdicao_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(260, 169);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnConfirmarPesquisa
            // 
            this.btnConfirmarPesquisa.Location = new System.Drawing.Point(467, 169);
            this.btnConfirmarPesquisa.Name = "btnConfirmarPesquisa";
            this.btnConfirmarPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarPesquisa.TabIndex = 23;
            this.btnConfirmarPesquisa.Text = "Pesquisar";
            this.btnConfirmarPesquisa.UseVisualStyleBackColor = true;
            this.btnConfirmarPesquisa.Visible = false;
            this.btnConfirmarPesquisa.Click += new System.EventHandler(this.btnConfirmarPesquisa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "CPF";
            // 
            // inptCpf
            // 
            this.inptCpf.Location = new System.Drawing.Point(80, 121);
            this.inptCpf.Mask = "000.000.000-00";
            this.inptCpf.Name = "inptCpf";
            this.inptCpf.Size = new System.Drawing.Size(82, 20);
            this.inptCpf.TabIndex = 25;
            // 
            // inptEstado
            // 
            this.inptEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inptEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inptEstado.FormattingEnabled = true;
            this.inptEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.inptEstado.Location = new System.Drawing.Point(558, 95);
            this.inptEstado.Name = "inptEstado";
            this.inptEstado.Size = new System.Drawing.Size(65, 21);
            this.inptEstado.TabIndex = 26;
            // 
            // inptTelefone
            // 
            this.inptTelefone.Location = new System.Drawing.Point(532, 43);
            this.inptTelefone.Mask = "(00) 0 0000-0000";
            this.inptTelefone.Name = "inptTelefone";
            this.inptTelefone.Size = new System.Drawing.Size(91, 20);
            this.inptTelefone.TabIndex = 27;
            // 
            // selectEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.inptTelefone);
            this.Controls.Add(this.inptEstado);
            this.Controls.Add(this.inptCpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirmarPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnConfirmarEdicao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarExcluir);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inptID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inptCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inptBairro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inptEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inptNome);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "selectEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox inptNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inptEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inptBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inptCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inptID;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Button btnConfirmarExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEdicao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnConfirmarPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox inptCpf;
        private System.Windows.Forms.ComboBox inptEstado;
        private System.Windows.Forms.MaskedTextBox inptTelefone;
    }
}

