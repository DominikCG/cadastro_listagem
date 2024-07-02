using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsCadastro
{
    public partial class FormCadastro : Form
    {
        private List<Produto> produtos;
        private FormListagem formListagem;

        public FormCadastro(List<Produto> produtos, FormListagem formListagem)
        {
            this.produtos = produtos;
            this.formListagem = formListagem;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.numValorProduto = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValorProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(120, 12);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(200, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição do produto:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(120, 42);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(200, 20);
            this.txtDescricaoProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor do produto:";
            // 
            // numValorProduto
            // 
            this.numValorProduto.Location = new System.Drawing.Point(120, 73);
            this.numValorProduto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValorProduto.Name = "numValorProduto";
            this.numValorProduto.Size = new System.Drawing.Size(200, 20);
            this.numValorProduto.TabIndex = 5;
            this.numValorProduto.DecimalPlaces = 2;
            this.numValorProduto.ThousandsSeparator = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(120, 110);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormCadastro
            // 
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numValorProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.numValorProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.NumericUpDown numValorProduto;
        private System.Windows.Forms.Button btnSalvar;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeProduto.Text;
            string descricaoProduto = txtDescricaoProduto.Text;
            decimal valorProduto = numValorProduto.Value;

            Produto novoProduto = new Produto(nomeProduto, descricaoProduto, valorProduto);
            produtos.Add(novoProduto);
            produtos = produtos.OrderBy(p => p.Valor).ToList();

            formListagem.AtualizarGrid();
            formListagem.Show();
            this.Close();
        }
    }
}
