namespace Apresentacao
{
    partial class frmSelecionarFruta
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
            this.cpoIDFruta = new System.Windows.Forms.TextBox();
            this.cpoNomeFruta = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgwSelecionarFruta = new System.Windows.Forms.DataGridView();
            this.iDFrutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFrutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFrutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFruta = new Apresentacao.midasDataSetFruta();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarFruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFrutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFrutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(371, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 44);
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
            this.label1.Location = new System.Drawing.Point(28, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fruta Selecionada:";
            // 
            // cpoIDFruta
            // 
            this.cpoIDFruta.Enabled = false;
            this.cpoIDFruta.Location = new System.Drawing.Point(29, 320);
            this.cpoIDFruta.Name = "cpoIDFruta";
            this.cpoIDFruta.ReadOnly = true;
            this.cpoIDFruta.Size = new System.Drawing.Size(32, 20);
            this.cpoIDFruta.TabIndex = 29;
            // 
            // cpoNomeFruta
            // 
            this.cpoNomeFruta.Enabled = false;
            this.cpoNomeFruta.Location = new System.Drawing.Point(69, 320);
            this.cpoNomeFruta.Name = "cpoNomeFruta";
            this.cpoNomeFruta.ReadOnly = true;
            this.cpoNomeFruta.Size = new System.Drawing.Size(276, 20);
            this.cpoNomeFruta.TabIndex = 28;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::Apresentacao.Properties.Resources.advice_accept_ok_theaction_10829;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.Location = new System.Drawing.Point(478, 307);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(101, 45);
            this.btnSelecionar.TabIndex = 27;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgwSelecionarFruta
            // 
            this.dgwSelecionarFruta.AllowUserToDeleteRows = false;
            this.dgwSelecionarFruta.AutoGenerateColumns = false;
            this.dgwSelecionarFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFrutaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidMedidaDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwSelecionarFruta.DataSource = this.tblFrutaBindingSource;
            this.dgwSelecionarFruta.Location = new System.Drawing.Point(28, 74);
            this.dgwSelecionarFruta.Name = "dgwSelecionarFruta";
            this.dgwSelecionarFruta.ReadOnly = true;
            this.dgwSelecionarFruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarFruta.Size = new System.Drawing.Size(551, 211);
            this.dgwSelecionarFruta.TabIndex = 26;
            this.dgwSelecionarFruta.DoubleClick += new System.EventHandler(this.dgwSelecionarFruta_DoubleClick);
            // 
            // iDFrutaDataGridViewTextBoxColumn
            // 
            this.iDFrutaDataGridViewTextBoxColumn.DataPropertyName = "IDFruta";
            this.iDFrutaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDFrutaDataGridViewTextBoxColumn.Name = "iDFrutaDataGridViewTextBoxColumn";
            this.iDFrutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 420;
            // 
            // unidMedidaDataGridViewTextBoxColumn
            // 
            this.unidMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidMedida";
            this.unidMedidaDataGridViewTextBoxColumn.HeaderText = "UnidMedida";
            this.unidMedidaDataGridViewTextBoxColumn.Name = "unidMedidaDataGridViewTextBoxColumn";
            this.unidMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidMedidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblFrutaBindingSource
            // 
            this.tblFrutaBindingSource.DataMember = "tblFruta";
            this.tblFrutaBindingSource.DataSource = this.midasDataSetFrutaBindingSource;
            // 
            // midasDataSetFrutaBindingSource
            // 
            this.midasDataSetFrutaBindingSource.DataSource = this.midasDataSetFruta;
            this.midasDataSetFrutaBindingSource.Position = 0;
            // 
            // midasDataSetFruta
            // 
            this.midasDataSetFruta.DataSetName = "midasDataSet1";
            this.midasDataSetFruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(167, 28);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(412, 23);
            this.cpoCaixaPesquisa.TabIndex = 25;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(28, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 45);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmSelecionarFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpoIDFruta);
            this.Controls.Add(this.cpoNomeFruta);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgwSelecionarFruta);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarFruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Fruta";
            this.Load += new System.EventHandler(this.frmSelecionarFruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarFruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFrutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFrutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpoIDFruta;
        private System.Windows.Forms.TextBox cpoNomeFruta;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgwSelecionarFruta;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFrutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblFrutaBindingSource;
        private System.Windows.Forms.BindingSource midasDataSetFrutaBindingSource;
        private midasDataSetFruta midasDataSetFruta;
    }
}