﻿namespace Apresentacao
{
    partial class frmSelecionarCliente
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
            this.dgwSelCliente = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetcliente = new Apresentacao.midasDataSetcliente();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.midasDataSetCliente1 = new Apresentacao.midasDataSetCliente();
            this.midasDataSetCliente1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteTableAdapter = new Apresentacao.midasDataSetclienteTableAdapters.tblClienteTableAdapter();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetCliente1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetCliente1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSelCliente
            // 
            this.dgwSelCliente.AllowUserToDeleteRows = false;
            this.dgwSelCliente.AutoGenerateColumns = false;
            this.dgwSelCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dgwSelCliente.DataSource = this.tblClienteBindingSource1;
            this.dgwSelCliente.Location = new System.Drawing.Point(38, 82);
            this.dgwSelCliente.Name = "dgwSelCliente";
            this.dgwSelCliente.ReadOnly = true;
            this.dgwSelCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelCliente.Size = new System.Drawing.Size(782, 211);
            this.dgwSelCliente.TabIndex = 18;
            this.dgwSelCliente.DoubleClick += new System.EventHandler(this.dgwSelCliente_DoubleClick);
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 700;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
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
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblClienteBindingSource1
            // 
            this.tblClienteBindingSource1.DataMember = "tblCliente";
            this.tblClienteBindingSource1.DataSource = this.midasDataSetclienteBindingSource;
            // 
            // midasDataSetclienteBindingSource
            // 
            this.midasDataSetclienteBindingSource.DataSource = this.midasDataSetcliente;
            this.midasDataSetclienteBindingSource.Position = 0;
            // 
            // midasDataSetcliente
            // 
            this.midasDataSetcliente.DataSetName = "midasDataSetcliente";
            this.midasDataSetcliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(177, 36);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(643, 23);
            this.cpoCaixaPesquisa.TabIndex = 17;
            // 
            // midasDataSetCliente1
            // 
            this.midasDataSetCliente1.DataSetName = "midasDataSet";
            this.midasDataSetCliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // midasDataSetCliente1BindingSource
            // 
            this.midasDataSetCliente1BindingSource.DataSource = this.midasDataSetCliente1;
            this.midasDataSetCliente1BindingSource.Position = 0;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "tblCliente";
            this.tblClienteBindingSource.DataSource = this.midasDataSetclienteBindingSource;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::Apresentacao.Properties.Resources.advice_accept_ok_theaction_10829;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.Location = new System.Drawing.Point(726, 313);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(94, 45);
            this.btnSelecionar.TabIndex = 19;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(38, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmSelecionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 372);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgwSelCliente);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmSelecionarCliente";
            this.Text = "Selecionar Cliente";
            this.Load += new System.EventHandler(this.FrmSelecionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetCliente1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetCliente1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSelCliente;
        private midasDataSetCliente midasDataSetCliente1;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private midasDataSetcliente midasDataSetcliente;
        private System.Windows.Forms.BindingSource midasDataSetclienteBindingSource;
        private System.Windows.Forms.BindingSource midasDataSetCliente1BindingSource;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private midasDataSetclienteTableAdapters.tblClienteTableAdapter tblClienteTableAdapter;
        private System.Windows.Forms.BindingSource tblClienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelecionar;
    }
}