namespace Apresentacao
{
    partial class frmSelecionarFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cpoIDCliente = new System.Windows.Forms.TextBox();
            this.cpoNomeCliente = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgwSelFornecedor = new System.Windows.Forms.DataGridView();
            this.iDFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFornecedor = new Apresentacao.midasDataSetFornecedor();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tblFornecedorTableAdapter = new Apresentacao.midasDataSetFornecedorTableAdapters.tblFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(541, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fornecedor Selecionado:";
            // 
            // cpoIDCliente
            // 
            this.cpoIDCliente.Enabled = false;
            this.cpoIDCliente.Location = new System.Drawing.Point(227, 334);
            this.cpoIDCliente.Name = "cpoIDCliente";
            this.cpoIDCliente.ReadOnly = true;
            this.cpoIDCliente.Size = new System.Drawing.Size(28, 20);
            this.cpoIDCliente.TabIndex = 29;
            // 
            // cpoNomeCliente
            // 
            this.cpoNomeCliente.Enabled = false;
            this.cpoNomeCliente.Location = new System.Drawing.Point(272, 334);
            this.cpoNomeCliente.Name = "cpoNomeCliente";
            this.cpoNomeCliente.ReadOnly = true;
            this.cpoNomeCliente.Size = new System.Drawing.Size(243, 20);
            this.cpoNomeCliente.TabIndex = 28;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::Apresentacao.Properties.Resources.advice_accept_ok_theaction_10829;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.Location = new System.Drawing.Point(651, 320);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(94, 45);
            this.btnSelecionar.TabIndex = 27;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // dgwSelFornecedor
            // 
            this.dgwSelFornecedor.AllowUserToDeleteRows = false;
            this.dgwSelFornecedor.AutoGenerateColumns = false;
            this.dgwSelFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFornecedorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn});
            this.dgwSelFornecedor.DataSource = this.tblFornecedorBindingSource;
            this.dgwSelFornecedor.Location = new System.Drawing.Point(36, 77);
            this.dgwSelFornecedor.Name = "dgwSelFornecedor";
            this.dgwSelFornecedor.ReadOnly = true;
            this.dgwSelFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelFornecedor.Size = new System.Drawing.Size(709, 211);
            this.dgwSelFornecedor.TabIndex = 26;
            // 
            // iDFornecedorDataGridViewTextBoxColumn
            // 
            this.iDFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IDFornecedor";
            this.iDFornecedorDataGridViewTextBoxColumn.HeaderText = "Código ";
            this.iDFornecedorDataGridViewTextBoxColumn.Name = "iDFornecedorDataGridViewTextBoxColumn";
            this.iDFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFornecedorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 650;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnpjDataGridViewTextBoxColumn.Visible = false;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblFornecedorBindingSource
            // 
            this.tblFornecedorBindingSource.DataMember = "tblFornecedor";
            this.tblFornecedorBindingSource.DataSource = this.midasDataSetFornecedorBindingSource;
            // 
            // midasDataSetFornecedorBindingSource
            // 
            this.midasDataSetFornecedorBindingSource.DataSource = this.midasDataSetFornecedor;
            this.midasDataSetFornecedorBindingSource.Position = 0;
            // 
            // midasDataSetFornecedor
            // 
            this.midasDataSetFornecedor.DataSetName = "midasDataSetFornecedor";
            this.midasDataSetFornecedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(175, 31);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(570, 23);
            this.cpoCaixaPesquisa.TabIndex = 25;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(36, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tblFornecedorTableAdapter
            // 
            this.tblFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmSelecionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 381);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpoIDCliente);
            this.Controls.Add(this.cpoNomeCliente);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgwSelFornecedor);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Fornecedor";
            this.Load += new System.EventHandler(this.frmSelecionarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpoIDCliente;
        private System.Windows.Forms.TextBox cpoNomeCliente;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgwSelFornecedor;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource midasDataSetFornecedorBindingSource;
        private midasDataSetFornecedor midasDataSetFornecedor;
        private System.Windows.Forms.BindingSource tblFornecedorBindingSource;
        private midasDataSetFornecedorTableAdapters.tblFornecedorTableAdapter tblFornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
    }
}