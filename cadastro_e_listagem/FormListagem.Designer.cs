using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsCadastro
{
    public partial class FormListagem : Form
    {
        private List<Produto> produtos;

        public FormListagem()
        {
            produtos = new List<Produto>();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(360, 200);
            this.dgvProdutos.TabIndex = 0;
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.Location = new System.Drawing.Point(12, 220);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(120, 23);
            this.btnCadastrarNovo.TabIndex = 1;
            this.btnCadastrarNovo.Text = "Cadastrar Novo Produto";
            this.btnCadastrarNovo.UseVisualStyleBackColor = true;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.BtnCadastrarNovo_Click);
            // 
            // FormListagem
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCadastrarNovo);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormListagem";
            this.Text = "Listagem de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.FormListagem_Load);
        }

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCadastrarNovo;

        private void FormListagem_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BtnCadastrarNovo_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(produtos, this);
            formCadastro.Show();
            this.Hide();
        }

        public void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos.Select(p => new { p.Nome, p.Valor }).ToList();


        }
    }
}