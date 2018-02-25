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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarFruta));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cpoIDFruta = new System.Windows.Forms.TextBox();
            this.cpoNomeFruta = new System.Windows.Forms.TextBox();
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
            this.lblAjuda = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.btnCancelar.Location = new System.Drawing.Point(483, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cpoIDFruta
            // 
            this.cpoIDFruta.Enabled = false;
            this.cpoIDFruta.Location = new System.Drawing.Point(27, 291);
            this.cpoIDFruta.Name = "cpoIDFruta";
            this.cpoIDFruta.ReadOnly = true;
            this.cpoIDFruta.Size = new System.Drawing.Size(32, 20);
            this.cpoIDFruta.TabIndex = 29;
            this.cpoIDFruta.Visible = false;
            // 
            // cpoNomeFruta
            // 
            this.cpoNomeFruta.Enabled = false;
            this.cpoNomeFruta.Location = new System.Drawing.Point(67, 291);
            this.cpoNomeFruta.Name = "cpoNomeFruta";
            this.cpoNomeFruta.ReadOnly = true;
            this.cpoNomeFruta.Size = new System.Drawing.Size(276, 20);
            this.cpoNomeFruta.TabIndex = 28;
            this.cpoNomeFruta.Visible = false;
            // 
            // dgwSelecionarFruta
            // 
            this.dgwSelecionarFruta.AllowUserToAddRows = false;
            this.dgwSelecionarFruta.AllowUserToDeleteRows = false;
            this.dgwSelecionarFruta.AllowUserToResizeRows = false;
            this.dgwSelecionarFruta.AutoGenerateColumns = false;
            this.dgwSelecionarFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFrutaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidMedidaDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwSelecionarFruta.DataSource = this.tblFrutaBindingSource;
            this.dgwSelecionarFruta.Location = new System.Drawing.Point(28, 65);
            this.dgwSelecionarFruta.MultiSelect = false;
            this.dgwSelecionarFruta.Name = "dgwSelecionarFruta";
            this.dgwSelecionarFruta.ReadOnly = true;
            this.dgwSelecionarFruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarFruta.Size = new System.Drawing.Size(551, 220);
            this.dgwSelecionarFruta.TabIndex = 99999;
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
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(28, 28);
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(399, 20);
            this.cpoCaixaPesquisa.TabIndex = 3;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            this.cpoCaixaPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCaixaPesquisa_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(448, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(25, 314);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(58, 13);
            this.lblAjuda.TabIndex = 4;
            this.lblAjuda.Text = "Ajuda (?)";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.lblAjuda, "Selecione o registro desejado clicando duas vezes sobre o mesmo no Grid.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmSelecionarFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 342);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cpoIDFruta);
            this.Controls.Add(this.cpoNomeFruta);
            this.Controls.Add(this.dgwSelecionarFruta);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox cpoIDFruta;
        private System.Windows.Forms.TextBox cpoNomeFruta;
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
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}