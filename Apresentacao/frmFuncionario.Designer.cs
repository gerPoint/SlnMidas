namespace Apresentacao
{
    partial class frmFuncionario
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
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.cpoUf = new System.Windows.Forms.TextBox();
            this.cpoCidade = new System.Windows.Forms.TextBox();
            this.cpoEndereco = new System.Windows.Forms.TextBox();
            this.cpoEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwFuncionario = new System.Windows.Forms.DataGridView();
            this.iDFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFuncionario = new Apresentacao.midasDataSetFuncionario1();
            this.cpoNome = new System.Windows.Forms.TextBox();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblFuncionarioTableAdapter = new Apresentacao.MidasDataSetFuncionarioTableAdapters.tblFuncionarioTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cpoIDFuncionario = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cpoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cpoCpf = new System.Windows.Forms.MaskedTextBox();
            this.cpoRg = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(-11, 448);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(0, 13);
            this.lblIDCliente.TabIndex = 107;
            // 
            // cpoUf
            // 
            this.cpoUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoUf.Location = new System.Drawing.Point(323, 347);
            this.cpoUf.MaxLength = 2;
            this.cpoUf.Name = "cpoUf";
            this.cpoUf.Size = new System.Drawing.Size(42, 20);
            this.cpoUf.TabIndex = 7;
            this.cpoUf.TextChanged += new System.EventHandler(this.cpoUf_TextChanged);
            // 
            // cpoCidade
            // 
            this.cpoCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCidade.Location = new System.Drawing.Point(97, 347);
            this.cpoCidade.MaxLength = 50;
            this.cpoCidade.Name = "cpoCidade";
            this.cpoCidade.Size = new System.Drawing.Size(193, 20);
            this.cpoCidade.TabIndex = 6;
            this.cpoCidade.TextChanged += new System.EventHandler(this.cpoCidade_TextChanged);
            // 
            // cpoEndereco
            // 
            this.cpoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEndereco.Location = new System.Drawing.Point(475, 313);
            this.cpoEndereco.MaxLength = 50;
            this.cpoEndereco.Name = "cpoEndereco";
            this.cpoEndereco.Size = new System.Drawing.Size(293, 20);
            this.cpoEndereco.TabIndex = 5;
            this.cpoEndereco.TextChanged += new System.EventHandler(this.cpoEndereco_TextChanged);
            // 
            // cpoEmail
            // 
            this.cpoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEmail.Location = new System.Drawing.Point(475, 349);
            this.cpoEmail.MaxLength = 50;
            this.cpoEmail.Name = "cpoEmail";
            this.cpoEmail.Size = new System.Drawing.Size(293, 20);
            this.cpoEmail.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "UF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Cidade";
            // 
            // dgwFuncionario
            // 
            this.dgwFuncionario.AllowUserToAddRows = false;
            this.dgwFuncionario.AllowUserToDeleteRows = false;
            this.dgwFuncionario.AllowUserToResizeColumns = false;
            this.dgwFuncionario.AllowUserToResizeRows = false;
            this.dgwFuncionario.AutoGenerateColumns = false;
            this.dgwFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFuncionarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwFuncionario.DataSource = this.tblFuncionarioBindingSource;
            this.dgwFuncionario.Location = new System.Drawing.Point(40, 72);
            this.dgwFuncionario.MultiSelect = false;
            this.dgwFuncionario.Name = "dgwFuncionario";
            this.dgwFuncionario.ReadOnly = true;
            this.dgwFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFuncionario.Size = new System.Drawing.Size(728, 211);
            this.dgwFuncionario.TabIndex = 99999;
            this.dgwFuncionario.DoubleClick += new System.EventHandler(this.dgwFuncionario_DoubleClick);
            // 
            // iDFuncionarioDataGridViewTextBoxColumn
            // 
            this.iDFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "IDFuncionario";
            this.iDFuncionarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDFuncionarioDataGridViewTextBoxColumn.Name = "iDFuncionarioDataGridViewTextBoxColumn";
            this.iDFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFuncionarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 200;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 200;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Width = 50;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblFuncionarioBindingSource
            // 
            this.tblFuncionarioBindingSource.DataMember = "tblFuncionario";
            this.tblFuncionarioBindingSource.DataSource = this.midasDataSetFuncionario;
            // 
            // midasDataSetFuncionario
            // 
            this.midasDataSetFuncionario.DataSetName = "MidasDataSetFuncionario";
            this.midasDataSetFuncionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoNome
            // 
            this.cpoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoNome.Location = new System.Drawing.Point(96, 311);
            this.cpoNome.MaxLength = 50;
            this.cpoNome.Name = "cpoNome";
            this.cpoNome.Size = new System.Drawing.Size(269, 20);
            this.cpoNome.TabIndex = 4;
            this.cpoNome.TextChanged += new System.EventHandler(this.cpoNome_TextChanged);
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(179, 26);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(589, 23);
            this.cpoCaixaPesquisa.TabIndex = 3;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            this.cpoCaixaPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCaixaPesquisa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nome";
            // 
            // tblFuncionarioTableAdapter
            // 
            this.tblFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(680, 432);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(463, 432);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(571, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 15;
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
            this.btnAlterar.Location = new System.Drawing.Point(352, 432);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(40, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cpoIDFuncionario
            // 
            this.cpoIDFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoIDFuncionario.Location = new System.Drawing.Point(179, 0);
            this.cpoIDFuncionario.Name = "cpoIDFuncionario";
            this.cpoIDFuncionario.Size = new System.Drawing.Size(42, 20);
            this.cpoIDFuncionario.TabIndex = 109;
            this.cpoIDFuncionario.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Image = global::Apresentacao.Properties.Resources.restart_back_left_arrow_6022;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetornar.Location = new System.Drawing.Point(40, 432);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(89, 44);
            this.btnRetornar.TabIndex = 12;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // cpoTelefone
            // 
            this.cpoTelefone.Location = new System.Drawing.Point(97, 382);
            this.cpoTelefone.Mask = "(99) 0000-0000";
            this.cpoTelefone.Name = "cpoTelefone";
            this.cpoTelefone.Size = new System.Drawing.Size(116, 20);
            this.cpoTelefone.TabIndex = 9;
            this.cpoTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoTelefone_KeyPress_1);
            // 
            // cpoCpf
            // 
            this.cpoCpf.Location = new System.Drawing.Point(665, 382);
            this.cpoCpf.Mask = "000.000.000-00";
            this.cpoCpf.Name = "cpoCpf";
            this.cpoCpf.Size = new System.Drawing.Size(103, 20);
            this.cpoCpf.TabIndex = 11;
            this.cpoCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCpf_KeyPress_1);
            // 
            // cpoRg
            // 
            this.cpoRg.Location = new System.Drawing.Point(475, 382);
            this.cpoRg.Mask = "00.000.000-0";
            this.cpoRg.Name = "cpoRg";
            this.cpoRg.Size = new System.Drawing.Size(103, 20);
            this.cpoRg.TabIndex = 10;
            this.cpoRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoRg_KeyPress_1);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.cpoRg);
            this.Controls.Add(this.cpoCpf);
            this.Controls.Add(this.cpoTelefone);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cpoIDFuncionario);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cpoUf);
            this.Controls.Add(this.cpoCidade);
            this.Controls.Add(this.cpoEndereco);
            this.Controls.Add(this.cpoEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwFuncionario);
            this.Controls.Add(this.cpoNome);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox cpoUf;
        private System.Windows.Forms.TextBox cpoCidade;
        private System.Windows.Forms.TextBox cpoEndereco;
        private System.Windows.Forms.TextBox cpoEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgwFuncionario;
        private System.Windows.Forms.TextBox cpoNome;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private midasDataSetFuncionario1 midasDataSetFuncionario;
        private System.Windows.Forms.BindingSource tblFuncionarioBindingSource;
        private MidasDataSetFuncionarioTableAdapters.tblFuncionarioTableAdapter tblFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cpoIDFuncionario;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.MaskedTextBox cpoTelefone;
        private System.Windows.Forms.MaskedTextBox cpoCpf;
        private System.Windows.Forms.MaskedTextBox cpoRg;
    }
}