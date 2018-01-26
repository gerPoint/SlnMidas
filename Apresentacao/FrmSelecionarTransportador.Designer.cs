namespace Apresentacao
{
    partial class frmSelecionarTransportador
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
            this.cpoIDTransportador = new System.Windows.Forms.TextBox();
            this.cpoNomeTransportador = new System.Windows.Forms.TextBox();
            this.dgwSelTransportador = new System.Windows.Forms.DataGridView();
            this.iDTransportadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTransportadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetTransportador = new Apresentacao.midasDataSetTransportador();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelTransportador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransportadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetTransportador)).BeginInit();
            this.SuspendLayout();
            // 
            // cpoIDTransportador
            // 
            this.cpoIDTransportador.Enabled = false;
            this.cpoIDTransportador.Location = new System.Drawing.Point(26, 289);
            this.cpoIDTransportador.Name = "cpoIDTransportador";
            this.cpoIDTransportador.ReadOnly = true;
            this.cpoIDTransportador.Size = new System.Drawing.Size(28, 20);
            this.cpoIDTransportador.TabIndex = 37;
            this.cpoIDTransportador.Visible = false;
            // 
            // cpoNomeTransportador
            // 
            this.cpoNomeTransportador.Enabled = false;
            this.cpoNomeTransportador.Location = new System.Drawing.Point(60, 289);
            this.cpoNomeTransportador.Name = "cpoNomeTransportador";
            this.cpoNomeTransportador.ReadOnly = true;
            this.cpoNomeTransportador.Size = new System.Drawing.Size(243, 20);
            this.cpoNomeTransportador.TabIndex = 36;
            this.cpoNomeTransportador.Visible = false;
            // 
            // dgwSelTransportador
            // 
            this.dgwSelTransportador.AllowUserToAddRows = false;
            this.dgwSelTransportador.AllowUserToDeleteRows = false;
            this.dgwSelTransportador.AllowUserToResizeColumns = false;
            this.dgwSelTransportador.AllowUserToResizeRows = false;
            this.dgwSelTransportador.AutoGenerateColumns = false;
            this.dgwSelTransportador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelTransportador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTransportadorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn});
            this.dgwSelTransportador.DataSource = this.tblTransportadorBindingSource;
            this.dgwSelTransportador.Location = new System.Drawing.Point(26, 72);
            this.dgwSelTransportador.MultiSelect = false;
            this.dgwSelTransportador.Name = "dgwSelTransportador";
            this.dgwSelTransportador.ReadOnly = true;
            this.dgwSelTransportador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelTransportador.Size = new System.Drawing.Size(739, 211);
            this.dgwSelTransportador.TabIndex = 99999;
            this.dgwSelTransportador.DoubleClick += new System.EventHandler(this.dgwSelTransportador_DoubleClick);
            // 
            // iDTransportadorDataGridViewTextBoxColumn
            // 
            this.iDTransportadorDataGridViewTextBoxColumn.DataPropertyName = "IDTransportador";
            this.iDTransportadorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDTransportadorDataGridViewTextBoxColumn.Name = "iDTransportadorDataGridViewTextBoxColumn";
            this.iDTransportadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTransportadorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 350;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.veiculoDataGridViewTextBoxColumn.Width = 300;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Visible = false;
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
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblTransportadorBindingSource
            // 
            this.tblTransportadorBindingSource.DataMember = "tblTransportador";
            this.tblTransportadorBindingSource.DataSource = this.midasDataSetTransportador;
            // 
            // midasDataSetTransportador
            // 
            this.midasDataSetTransportador.DataSetName = "midasDataSet2";
            this.midasDataSetTransportador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(165, 26);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(600, 23);
            this.cpoCaixaPesquisa.TabIndex = 3;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            this.cpoCaixaPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCaixaPesquisa_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(676, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(26, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(23, 312);
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
            // frmSelecionarTransportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 346);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cpoIDTransportador);
            this.Controls.Add(this.cpoNomeTransportador);
            this.Controls.Add(this.dgwSelTransportador);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarTransportador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Transportador";
            this.Load += new System.EventHandler(this.frmSelecionarTransportador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelTransportador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransportadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetTransportador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox cpoIDTransportador;
        private System.Windows.Forms.TextBox cpoNomeTransportador;
        private System.Windows.Forms.DataGridView dgwSelTransportador;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTransportadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblTransportadorBindingSource;
        private midasDataSetTransportador midasDataSetTransportador;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}