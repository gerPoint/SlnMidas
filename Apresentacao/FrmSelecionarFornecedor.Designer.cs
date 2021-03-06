﻿namespace Apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarFornecedor));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cpoIDFornecedor = new System.Windows.Forms.TextBox();
            this.cpoNomeFornecedor = new System.Windows.Forms.TextBox();
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
            this.lblAjuda = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.btnCancelar.Location = new System.Drawing.Point(656, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cpoIDFornecedor
            // 
            this.cpoIDFornecedor.Enabled = false;
            this.cpoIDFornecedor.Location = new System.Drawing.Point(36, 287);
            this.cpoIDFornecedor.Name = "cpoIDFornecedor";
            this.cpoIDFornecedor.ReadOnly = true;
            this.cpoIDFornecedor.Size = new System.Drawing.Size(28, 20);
            this.cpoIDFornecedor.TabIndex = 29;
            this.cpoIDFornecedor.Visible = false;
            // 
            // cpoNomeFornecedor
            // 
            this.cpoNomeFornecedor.Enabled = false;
            this.cpoNomeFornecedor.Location = new System.Drawing.Point(81, 287);
            this.cpoNomeFornecedor.Name = "cpoNomeFornecedor";
            this.cpoNomeFornecedor.ReadOnly = true;
            this.cpoNomeFornecedor.Size = new System.Drawing.Size(243, 20);
            this.cpoNomeFornecedor.TabIndex = 28;
            this.cpoNomeFornecedor.Visible = false;
            // 
            // dgwSelFornecedor
            // 
            this.dgwSelFornecedor.AllowUserToAddRows = false;
            this.dgwSelFornecedor.AllowUserToDeleteRows = false;
            this.dgwSelFornecedor.AllowUserToResizeRows = false;
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
            this.dgwSelFornecedor.Location = new System.Drawing.Point(36, 68);
            this.dgwSelFornecedor.MultiSelect = false;
            this.dgwSelFornecedor.Name = "dgwSelFornecedor";
            this.dgwSelFornecedor.ReadOnly = true;
            this.dgwSelFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelFornecedor.Size = new System.Drawing.Size(709, 220);
            this.dgwSelFornecedor.TabIndex = 99999;
            this.dgwSelFornecedor.DoubleClick += new System.EventHandler(this.dgwSelFornecedor_DoubleClick);
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
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(36, 31);
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(570, 20);
            this.cpoCaixaPesquisa.TabIndex = 2;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            this.cpoCaixaPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCaixaPesquisa_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(621, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tblFornecedorTableAdapter
            // 
            this.tblFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(33, 310);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(58, 13);
            this.lblAjuda.TabIndex = 4;
            this.lblAjuda.Text = "Ajuda (?)";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.lblAjuda, "Selecione o registro desejado clicando duas vezes sobre o mesmo no Grid.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmSelecionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 345);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cpoIDFornecedor);
            this.Controls.Add(this.cpoNomeFornecedor);
            this.Controls.Add(this.dgwSelFornecedor);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox cpoIDFornecedor;
        private System.Windows.Forms.TextBox cpoNomeFornecedor;
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
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}