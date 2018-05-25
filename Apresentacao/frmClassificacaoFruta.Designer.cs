namespace Apresentacao
{
    partial class frmClassificacaoFruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassificacaoFruta));
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cpoIDFruta = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgwClassificFruta = new System.Windows.Forms.DataGridView();
            this.iDClassificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClassificacaoFrutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetClassificFruta = new Apresentacao.midasDataSetClassificFruta();
            this.cpoClassificacao = new System.Windows.Forms.TextBox();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblClassificacaoFrutaTableAdapter = new Apresentacao.midasDataSetClassificFrutaTableAdapters.tblClassificacaoFrutaTableAdapter();
            this.cpoIDClassificacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClassificFruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificacaoFrutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetClassificFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Image = global::Apresentacao.Properties.Resources.restart_back_left_arrow_6022;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetornar.Location = new System.Drawing.Point(21, 352);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(89, 44);
            this.btnRetornar.TabIndex = 4;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click_1);
            // 
            // cpoIDFruta
            // 
            this.cpoIDFruta.Location = new System.Drawing.Point(132, -23);
            this.cpoIDFruta.Name = "cpoIDFruta";
            this.cpoIDFruta.Size = new System.Drawing.Size(42, 20);
            this.cpoIDFruta.TabIndex = 100011;
            this.cpoIDFruta.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(256, 352);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(472, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(363, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 7;
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
            this.btnAlterar.Location = new System.Drawing.Point(145, 352);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgwClassificFruta
            // 
            this.dgwClassificFruta.AllowUserToAddRows = false;
            this.dgwClassificFruta.AllowUserToDeleteRows = false;
            this.dgwClassificFruta.AllowUserToResizeRows = false;
            this.dgwClassificFruta.AutoGenerateColumns = false;
            this.dgwClassificFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClassificFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClassificacaoDataGridViewTextBoxColumn,
            this.classificacaoDataGridViewTextBoxColumn});
            this.dgwClassificFruta.DataSource = this.tblClassificacaoFrutaBindingSource;
            this.dgwClassificFruta.Location = new System.Drawing.Point(21, 58);
            this.dgwClassificFruta.MultiSelect = false;
            this.dgwClassificFruta.Name = "dgwClassificFruta";
            this.dgwClassificFruta.ReadOnly = true;
            this.dgwClassificFruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClassificFruta.Size = new System.Drawing.Size(542, 220);
            this.dgwClassificFruta.TabIndex = 100012;
            this.dgwClassificFruta.DoubleClick += new System.EventHandler(this.dgwClassificFruta_DoubleClick);
            // 
            // iDClassificacaoDataGridViewTextBoxColumn
            // 
            this.iDClassificacaoDataGridViewTextBoxColumn.DataPropertyName = "IDClassificacao";
            this.iDClassificacaoDataGridViewTextBoxColumn.HeaderText = "Cod. Classificacao";
            this.iDClassificacaoDataGridViewTextBoxColumn.Name = "iDClassificacaoDataGridViewTextBoxColumn";
            this.iDClassificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClassificacaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // classificacaoDataGridViewTextBoxColumn
            // 
            this.classificacaoDataGridViewTextBoxColumn.DataPropertyName = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.HeaderText = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.Name = "classificacaoDataGridViewTextBoxColumn";
            this.classificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.classificacaoDataGridViewTextBoxColumn.Width = 380;
            // 
            // tblClassificacaoFrutaBindingSource
            // 
            this.tblClassificacaoFrutaBindingSource.DataMember = "tblClassificacaoFruta";
            this.tblClassificacaoFrutaBindingSource.DataSource = this.midasDataSetClassificFruta;
            // 
            // midasDataSetClassificFruta
            // 
            this.midasDataSetClassificFruta.DataSetName = "midasDataSetClassificFruta";
            this.midasDataSetClassificFruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoClassificacao
            // 
            this.cpoClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpoClassificacao.Location = new System.Drawing.Point(93, 299);
            this.cpoClassificacao.MaxLength = 50;
            this.cpoClassificacao.Name = "cpoClassificacao";
            this.cpoClassificacao.Size = new System.Drawing.Size(470, 20);
            this.cpoClassificacao.TabIndex = 3;
            this.cpoClassificacao.TextChanged += new System.EventHandler(this.cpoClassificacao_TextChanged);
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(21, 21);
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(403, 20);
            this.cpoCaixaPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(439, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 100009;
            this.label1.Text = "Classificação";
            // 
            // tblClassificacaoFrutaTableAdapter
            // 
            this.tblClassificacaoFrutaTableAdapter.ClearBeforeFill = true;
            // 
            // cpoIDClassificacao
            // 
            this.cpoIDClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoIDClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpoIDClassificacao.Location = new System.Drawing.Point(32, 317);
            this.cpoIDClassificacao.MaxLength = 50;
            this.cpoIDClassificacao.Name = "cpoIDClassificacao";
            this.cpoIDClassificacao.Size = new System.Drawing.Size(30, 20);
            this.cpoIDClassificacao.TabIndex = 100013;
            this.cpoIDClassificacao.Visible = false;
            // 
            // frmClassificacaoFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 412);
            this.Controls.Add(this.cpoIDClassificacao);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cpoIDFruta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwClassificFruta);
            this.Controls.Add(this.cpoClassificacao);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClassificacaoFruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLASSIFICAÇÃO DE FRUTA";
            this.Load += new System.EventHandler(this.frmClassificacaoFruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClassificFruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificacaoFrutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetClassificFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.TextBox cpoIDFruta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgwClassificFruta;
        private System.Windows.Forms.TextBox cpoClassificacao;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private midasDataSetClassificFruta midasDataSetClassificFruta;
        private System.Windows.Forms.BindingSource tblClassificacaoFrutaBindingSource;
        private midasDataSetClassificFrutaTableAdapters.tblClassificacaoFrutaTableAdapter tblClassificacaoFrutaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClassificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cpoIDClassificacao;
    }
}