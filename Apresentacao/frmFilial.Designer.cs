namespace Apresentacao
{
    partial class frmFilial
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
            this.cpoRazaoSocial = new System.Windows.Forms.TextBox();
            this.cpoUf = new System.Windows.Forms.TextBox();
            this.cpoCidade = new System.Windows.Forms.TextBox();
            this.cpoEndereco = new System.Windows.Forms.TextBox();
            this.cpoEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwFilial = new System.Windows.Forms.DataGridView();
            this.tblFilialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetFilial2 = new Apresentacao.midasDataSetFilial2();
            this.midasDataSetFilial = new Apresentacao.midasDataSetFilial();
            this.cpoFilial = new System.Windows.Forms.TextBox();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpoChaveSistema = new System.Windows.Forms.TextBox();
            this.tblFilialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFilialTableAdapter = new Apresentacao.midasDataSetFilialTableAdapters.tblFilialTableAdapter();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.tblFilialTableAdapter1 = new Apresentacao.midasDataSetFilial2TableAdapters.tblFilialTableAdapter();
            this.cpoIDFilial = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cpoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cpoCnpj = new System.Windows.Forms.MaskedTextBox();
            this.iDFilialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chaveSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFilial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cpoRazaoSocial
            // 
            this.cpoRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoRazaoSocial.Location = new System.Drawing.Point(419, 322);
            this.cpoRazaoSocial.MaxLength = 50;
            this.cpoRazaoSocial.Name = "cpoRazaoSocial";
            this.cpoRazaoSocial.Size = new System.Drawing.Size(246, 20);
            this.cpoRazaoSocial.TabIndex = 5;
            this.cpoRazaoSocial.TextChanged += new System.EventHandler(this.cpoRazaoSocial_TextChanged);
            // 
            // cpoUf
            // 
            this.cpoUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoUf.Location = new System.Drawing.Point(622, 358);
            this.cpoUf.MaxLength = 2;
            this.cpoUf.Name = "cpoUf";
            this.cpoUf.Size = new System.Drawing.Size(42, 20);
            this.cpoUf.TabIndex = 9;
            this.cpoUf.TextChanged += new System.EventHandler(this.cpoUf_TextChanged);
            // 
            // cpoCidade
            // 
            this.cpoCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCidade.Location = new System.Drawing.Point(419, 358);
            this.cpoCidade.MaxLength = 50;
            this.cpoCidade.Name = "cpoCidade";
            this.cpoCidade.Size = new System.Drawing.Size(170, 20);
            this.cpoCidade.TabIndex = 8;
            this.cpoCidade.TextChanged += new System.EventHandler(this.cpoCidade_TextChanged);
            // 
            // cpoEndereco
            // 
            this.cpoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEndereco.Location = new System.Drawing.Point(86, 358);
            this.cpoEndereco.MaxLength = 50;
            this.cpoEndereco.Name = "cpoEndereco";
            this.cpoEndereco.Size = new System.Drawing.Size(247, 20);
            this.cpoEndereco.TabIndex = 7;
            this.cpoEndereco.TextChanged += new System.EventHandler(this.cpoEndereco_TextChanged);
            // 
            // cpoEmail
            // 
            this.cpoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEmail.Location = new System.Drawing.Point(419, 391);
            this.cpoEmail.MaxLength = 50;
            this.cpoEmail.Name = "cpoEmail";
            this.cpoEmail.Size = new System.Drawing.Size(245, 20);
            this.cpoEmail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "CNPJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "UF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Razão Social";
            // 
            // dgwFilial
            // 
            this.dgwFilial.AllowUserToAddRows = false;
            this.dgwFilial.AllowUserToDeleteRows = false;
            this.dgwFilial.AllowUserToResizeRows = false;
            this.dgwFilial.AutoGenerateColumns = false;
            this.dgwFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFilialDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.chaveSistemaDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwFilial.DataSource = this.tblFilialBindingSource1;
            this.dgwFilial.Location = new System.Drawing.Point(30, 80);
            this.dgwFilial.MultiSelect = false;
            this.dgwFilial.Name = "dgwFilial";
            this.dgwFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFilial.Size = new System.Drawing.Size(782, 211);
            this.dgwFilial.TabIndex = 99999;
            this.dgwFilial.DoubleClick += new System.EventHandler(this.dgwFilial_DoubleClick);
            // 
            // tblFilialBindingSource1
            // 
            this.tblFilialBindingSource1.DataMember = "tblFilial";
            this.tblFilialBindingSource1.DataSource = this.midasDataSetFilial2;
            // 
            // midasDataSetFilial2
            // 
            this.midasDataSetFilial2.DataSetName = "midasDataSetFilial2";
            this.midasDataSetFilial2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // midasDataSetFilial
            // 
            this.midasDataSetFilial.DataSetName = "midasDataSetFilial";
            this.midasDataSetFilial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpoFilial
            // 
            this.cpoFilial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoFilial.Location = new System.Drawing.Point(86, 322);
            this.cpoFilial.MaxLength = 50;
            this.cpoFilial.Name = "cpoFilial";
            this.cpoFilial.Size = new System.Drawing.Size(247, 20);
            this.cpoFilial.TabIndex = 4;
            this.cpoFilial.TextChanged += new System.EventHandler(this.cpoFilial_TextChanged);
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(169, 37);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(643, 23);
            this.cpoCaixaPesquisa.TabIndex = 3;
            this.cpoCaixaPesquisa.TextChanged += new System.EventHandler(this.cpoCaixaPesquisa_TextChanged);
            this.cpoCaixaPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCaixaPesquisa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Filial";
            // 
            // cpoChaveSistema
            // 
            this.cpoChaveSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoChaveSistema.Location = new System.Drawing.Point(362, 431);
            this.cpoChaveSistema.Name = "cpoChaveSistema";
            this.cpoChaveSistema.Size = new System.Drawing.Size(303, 20);
            this.cpoChaveSistema.TabIndex = 130;
            this.cpoChaveSistema.Visible = false;
            // 
            // tblFilialBindingSource
            // 
            this.tblFilialBindingSource.DataMember = "tblFilial";
            this.tblFilialBindingSource.DataSource = this.midasDataSetFilial;
            // 
            // tblFilialTableAdapter
            // 
            this.tblFilialTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(504, 457);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(721, 457);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(612, 457);
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
            this.btnAlterar.Location = new System.Drawing.Point(393, 457);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(30, 23);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // tblFilialTableAdapter1
            // 
            this.tblFilialTableAdapter1.ClearBeforeFill = true;
            // 
            // cpoIDFilial
            // 
            this.cpoIDFilial.Location = new System.Drawing.Point(169, 11);
            this.cpoIDFilial.Name = "cpoIDFilial";
            this.cpoIDFilial.Size = new System.Drawing.Size(100, 20);
            this.cpoIDFilial.TabIndex = 131;
            this.cpoIDFilial.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Image = global::Apresentacao.Properties.Resources.restart_back_left_arrow_6022;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetornar.Location = new System.Drawing.Point(30, 457);
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
            this.cpoTelefone.Location = new System.Drawing.Point(86, 390);
            this.cpoTelefone.Mask = "(99) 0000-0000";
            this.cpoTelefone.Name = "cpoTelefone";
            this.cpoTelefone.Size = new System.Drawing.Size(116, 20);
            this.cpoTelefone.TabIndex = 100000;
            this.cpoTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoTelefone_KeyPress_1);
            // 
            // cpoCnpj
            // 
            this.cpoCnpj.Location = new System.Drawing.Point(709, 322);
            this.cpoCnpj.Mask = "00.000.000.0000-00";
            this.cpoCnpj.Name = "cpoCnpj";
            this.cpoCnpj.Size = new System.Drawing.Size(103, 20);
            this.cpoCnpj.TabIndex = 100001;
            this.cpoCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpoCnpj_KeyPress_1);
            // 
            // iDFilialDataGridViewTextBoxColumn
            // 
            this.iDFilialDataGridViewTextBoxColumn.DataPropertyName = "IDFilial";
            this.iDFilialDataGridViewTextBoxColumn.HeaderText = "Código";
            this.iDFilialDataGridViewTextBoxColumn.Name = "iDFilialDataGridViewTextBoxColumn";
            this.iDFilialDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFilialDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn.Width = 200;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnpjDataGridViewTextBoxColumn.Width = 120;
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
            // chaveSistemaDataGridViewTextBoxColumn
            // 
            this.chaveSistemaDataGridViewTextBoxColumn.DataPropertyName = "ChaveSistema";
            this.chaveSistemaDataGridViewTextBoxColumn.HeaderText = "ChaveSistema";
            this.chaveSistemaDataGridViewTextBoxColumn.Name = "chaveSistemaDataGridViewTextBoxColumn";
            this.chaveSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.chaveSistemaDataGridViewTextBoxColumn.Width = 200;
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
            // frmFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.cpoCnpj);
            this.Controls.Add(this.cpoTelefone);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cpoIDFilial);
            this.Controls.Add(this.cpoChaveSistema);
            this.Controls.Add(this.cpoRazaoSocial);
            this.Controls.Add(this.cpoUf);
            this.Controls.Add(this.cpoCidade);
            this.Controls.Add(this.cpoEndereco);
            this.Controls.Add(this.cpoEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwFilial);
            this.Controls.Add(this.cpoFilial);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FILIAIS";
            this.Load += new System.EventHandler(this.frmFilial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFilial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cpoRazaoSocial;
        private System.Windows.Forms.TextBox cpoUf;
        private System.Windows.Forms.TextBox cpoCidade;
        private System.Windows.Forms.TextBox cpoEndereco;
        private System.Windows.Forms.TextBox cpoEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgwFilial;
        private System.Windows.Forms.TextBox cpoFilial;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox cpoChaveSistema;
        private midasDataSetFilial midasDataSetFilial;
        private System.Windows.Forms.BindingSource tblFilialBindingSource;
        private midasDataSetFilialTableAdapters.tblFilialTableAdapter tblFilialTableAdapter;
        private midasDataSetFilial2 midasDataSetFilial2;
        private System.Windows.Forms.BindingSource tblFilialBindingSource1;
        private midasDataSetFilial2TableAdapters.tblFilialTableAdapter tblFilialTableAdapter1;
        private System.Windows.Forms.TextBox cpoIDFilial;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.MaskedTextBox cpoTelefone;
        private System.Windows.Forms.MaskedTextBox cpoCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFilialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chaveSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}