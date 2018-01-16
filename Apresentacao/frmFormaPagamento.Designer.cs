namespace Apresentacao
{
    partial class frmFormaPagamento
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cpoIDFormaPagamento = new System.Windows.Forms.TextBox();
            this.cpoParcelamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgwFormaPagamento = new System.Windows.Forms.DataGridView();
            this.iDFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFormaPgto = new Apresentacao.midasDataSetFormaPgto();
            this.cpoDescricao = new System.Windows.Forms.TextBox();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tblFormaPagamentoTableAdapter = new Apresentacao.midasDataSetFormaPgtoTableAdapters.tblFormaPagamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormaPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFormaPgto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Image = global::Apresentacao.Properties.Resources.restart_back_left_arrow_6022;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetornar.Location = new System.Drawing.Point(29, 362);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(89, 44);
            this.btnRetornar.TabIndex = 108;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // cpoIDFormaPagamento
            // 
            this.cpoIDFormaPagamento.Location = new System.Drawing.Point(168, 5);
            this.cpoIDFormaPagamento.Name = "cpoIDFormaPagamento";
            this.cpoIDFormaPagamento.Size = new System.Drawing.Size(42, 20);
            this.cpoIDFormaPagamento.TabIndex = 107;
            this.cpoIDFormaPagamento.Visible = false;
            // 
            // cpoParcelamento
            // 
            this.cpoParcelamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoParcelamento.Location = new System.Drawing.Point(480, 309);
            this.cpoParcelamento.MaxLength = 50;
            this.cpoParcelamento.Name = "cpoParcelamento";
            this.cpoParcelamento.Size = new System.Drawing.Size(91, 20);
            this.cpoParcelamento.TabIndex = 99;
            this.cpoParcelamento.TextChanged += new System.EventHandler(this.cpoParcelamento_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Parcelamento";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(263, 362);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 101;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(480, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(371, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = global::Apresentacao.Properties.Resources.document_write_22637;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(153, 362);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 100;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgwFormaPagamento
            // 
            this.dgwFormaPagamento.AutoGenerateColumns = false;
            this.dgwFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFormaPagamentoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.parcelamentoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn,
            this.dataExclusaoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwFormaPagamento.DataSource = this.tblFormaPagamentoBindingSource;
            this.dgwFormaPagamento.Location = new System.Drawing.Point(29, 77);
            this.dgwFormaPagamento.Name = "dgwFormaPagamento";
            this.dgwFormaPagamento.ReadOnly = true;
            this.dgwFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFormaPagamento.Size = new System.Drawing.Size(542, 211);
            this.dgwFormaPagamento.TabIndex = 105;
            // 
            // iDFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.iDFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "IDFormaPagamento";
            this.iDFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDFormaPagamentoDataGridViewTextBoxColumn.Name = "iDFormaPagamentoDataGridViewTextBoxColumn";
            this.iDFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFormaPagamentoDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // parcelamentoDataGridViewTextBoxColumn
            // 
            this.parcelamentoDataGridViewTextBoxColumn.DataPropertyName = "Parcelamento";
            this.parcelamentoDataGridViewTextBoxColumn.HeaderText = "Parcelamento";
            this.parcelamentoDataGridViewTextBoxColumn.Name = "parcelamentoDataGridViewTextBoxColumn";
            this.parcelamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataExclusaoDataGridViewTextBoxColumn
            // 
            this.dataExclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataExclusao";
            this.dataExclusaoDataGridViewTextBoxColumn.HeaderText = "DataExclusao";
            this.dataExclusaoDataGridViewTextBoxColumn.Name = "dataExclusaoDataGridViewTextBoxColumn";
            this.dataExclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataExclusaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 50;
            // 
            // tblFormaPagamentoBindingSource
            // 
            this.tblFormaPagamentoBindingSource.DataMember = "tblFormaPagamento";
            this.tblFormaPagamentoBindingSource.DataSource = this.midasDataSetFormaPgto;
            // 
            // midasDataSetFormaPgto
            // 
            this.midasDataSetFormaPgto.DataSetName = "midasDataSetFormaPgto";
            this.midasDataSetFormaPgto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoDescricao
            // 
            this.cpoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoDescricao.Location = new System.Drawing.Point(87, 309);
            this.cpoDescricao.MaxLength = 50;
            this.cpoDescricao.Name = "cpoDescricao";
            this.cpoDescricao.Size = new System.Drawing.Size(281, 20);
            this.cpoDescricao.TabIndex = 98;
            this.cpoDescricao.TextChanged += new System.EventHandler(this.cpoDescricao_TextChanged);
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(168, 31);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(403, 23);
            this.cpoCaixaPesquisa.TabIndex = 97;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Descrição";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(29, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 96;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tblFormaPagamentoTableAdapter
            // 
            this.tblFormaPagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 428);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cpoIDFormaPagamento);
            this.Controls.Add(this.cpoParcelamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwFormaPagamento);
            this.Controls.Add(this.cpoDescricao);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.frmFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFormaPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFormaPgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.TextBox cpoIDFormaPagamento;
        private System.Windows.Forms.TextBox cpoParcelamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgwFormaPagamento;
        private System.Windows.Forms.TextBox cpoDescricao;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private midasDataSetFormaPgto midasDataSetFormaPgto;
        private System.Windows.Forms.BindingSource tblFormaPagamentoBindingSource;
        private midasDataSetFormaPgtoTableAdapters.tblFormaPagamentoTableAdapter tblFormaPagamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}