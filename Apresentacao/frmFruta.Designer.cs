﻿namespace Apresentacao
{
    partial class frmFruta
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
            this.cpoUnidMedida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgwFruta = new System.Windows.Forms.DataGridView();
            this.tblFrutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSet1 = new Apresentacao.midasDataSetFruta();
            this.cpoNome = new System.Windows.Forms.TextBox();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tblFrutaTableAdapter = new Apresentacao.midasDataSet1TableAdapters.tblFrutaTableAdapter();
            this.cpoIDFruta = new System.Windows.Forms.TextBox();
            this.iDFrutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFrutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cpoUnidMedida
            // 
            this.cpoUnidMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoUnidMedida.Location = new System.Drawing.Point(389, 301);
            this.cpoUnidMedida.Name = "cpoUnidMedida";
            this.cpoUnidMedida.Size = new System.Drawing.Size(63, 20);
            this.cpoUnidMedida.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Unid. Medida";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(145, 339);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(362, 339);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(253, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Apresentacao.Properties.Resources.document_write_22637;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(34, 339);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgwFruta
            // 
            this.dgwFruta.AutoGenerateColumns = false;
            this.dgwFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFrutaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidMedidaDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwFruta.DataSource = this.tblFrutaBindingSource;
            this.dgwFruta.Location = new System.Drawing.Point(34, 72);
            this.dgwFruta.Name = "dgwFruta";
            this.dgwFruta.ReadOnly = true;
            this.dgwFruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFruta.Size = new System.Drawing.Size(418, 211);
            this.dgwFruta.TabIndex = 83;
            this.dgwFruta.DoubleClick += new System.EventHandler(this.dgwFruta_DoubleClick);
            // 
            // tblFrutaBindingSource
            // 
            this.tblFrutaBindingSource.DataMember = "tblFruta";
            this.tblFrutaBindingSource.DataSource = this.midasDataSet1;
            // 
            // midasDataSet1
            // 
            this.midasDataSet1.DataSetName = "midasDataSet1";
            this.midasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoNome
            // 
            this.cpoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoNome.Location = new System.Drawing.Point(74, 301);
            this.cpoNome.Name = "cpoNome";
            this.cpoNome.Size = new System.Drawing.Size(233, 20);
            this.cpoNome.TabIndex = 4;
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(173, 26);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(279, 23);
            this.cpoCaixaPesquisa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(34, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tblFrutaTableAdapter
            // 
            this.tblFrutaTableAdapter.ClearBeforeFill = true;
            // 
            // cpoIDFruta
            // 
            this.cpoIDFruta.Location = new System.Drawing.Point(173, 0);
            this.cpoIDFruta.Name = "cpoIDFruta";
            this.cpoIDFruta.Size = new System.Drawing.Size(42, 20);
            this.cpoIDFruta.TabIndex = 94;
            this.cpoIDFruta.Visible = false;
            // 
            // iDFrutaDataGridViewTextBoxColumn
            // 
            this.iDFrutaDataGridViewTextBoxColumn.DataPropertyName = "IDFruta";
            this.iDFrutaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDFrutaDataGridViewTextBoxColumn.Name = "iDFrutaDataGridViewTextBoxColumn";
            this.iDFrutaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFrutaDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // unidMedidaDataGridViewTextBoxColumn
            // 
            this.unidMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidMedida";
            this.unidMedidaDataGridViewTextBoxColumn.HeaderText = "UnidMedida";
            this.unidMedidaDataGridViewTextBoxColumn.Name = "unidMedidaDataGridViewTextBoxColumn";
            this.unidMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 401);
            this.Controls.Add(this.cpoIDFruta);
            this.Controls.Add(this.cpoUnidMedida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwFruta);
            this.Controls.Add(this.cpoNome);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRUTA";
            this.Load += new System.EventHandler(this.frmFruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFrutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cpoUnidMedida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgwFruta;
        private System.Windows.Forms.TextBox cpoNome;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private midasDataSetFruta midasDataSet1;
        private System.Windows.Forms.BindingSource tblFrutaBindingSource;
        private midasDataSet1TableAdapters.tblFrutaTableAdapter tblFrutaTableAdapter;
        private System.Windows.Forms.TextBox cpoIDFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFrutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}