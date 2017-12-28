namespace Apresentacao
{
    partial class frmCliente
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
            this.lbl_data_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpoCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.cpoNome = new System.Windows.Forms.TextBox();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSet9 = new Apresentacao.midasDataSet9();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSet = new Apresentacao.midasDataSetCliente();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cpoCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpoCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cpoTelefone = new System.Windows.Forms.TextBox();
            this.cpoEmail = new System.Windows.Forms.TextBox();
            this.cpoEndereco = new System.Windows.Forms.TextBox();
            this.cpoCidade = new System.Windows.Forms.TextBox();
            this.cpoUf = new System.Windows.Forms.TextBox();
            this.cpoRazaoSocial = new System.Windows.Forms.TextBox();
            this.tblClienteTableAdapter = new Apresentacao.midasDataSetTableAdapters.tblClienteTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.cpoIDCliente = new System.Windows.Forms.TextBox();
            this.tblClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblClienteTableAdapter1 = new Apresentacao.midasDataSet9TableAdapters.tblClienteTableAdapter();
            this.checkBoxCpf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.AutoSize = true;
            this.lbl_data_hora.Location = new System.Drawing.Point(49, 478);
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(0, 13);
            this.lbl_data_hora.TabIndex = 78;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(44, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Email";
            // 
            // cpoCaixaPesquisa
            // 
            this.cpoCaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCaixaPesquisa.Location = new System.Drawing.Point(183, 27);
            this.cpoCaixaPesquisa.Multiline = true;
            this.cpoCaixaPesquisa.Name = "cpoCaixaPesquisa";
            this.cpoCaixaPesquisa.Size = new System.Drawing.Size(643, 23);
            this.cpoCaixaPesquisa.TabIndex = 2;
            // 
            // cpoNome
            // 
            this.cpoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoNome.Location = new System.Drawing.Point(100, 312);
            this.cpoNome.Name = "cpoNome";
            this.cpoNome.Size = new System.Drawing.Size(247, 20);
            this.cpoNome.TabIndex = 3;
            // 
            // dgwCliente
            // 
            this.dgwCliente.AllowUserToDeleteRows = false;
            this.dgwCliente.AutoGenerateColumns = false;
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgwCliente.DataSource = this.tblClienteBindingSource3;
            this.dgwCliente.Location = new System.Drawing.Point(44, 73);
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.ReadOnly = true;
            this.dgwCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCliente.Size = new System.Drawing.Size(782, 211);
            this.dgwCliente.TabIndex = 15;
            this.dgwCliente.DoubleClick += new System.EventHandler(this.dgwCliente_DoubleClick);
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
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razao Social";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn.Width = 200;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.ufDataGridViewTextBoxColumn.HeaderText = "UF";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Width = 50;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data Cadastro";
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
            // tblClienteBindingSource3
            // 
            this.tblClienteBindingSource3.DataMember = "tblCliente";
            this.tblClienteBindingSource3.DataSource = this.midasDataSet9;
            // 
            // midasDataSet9
            // 
            this.midasDataSet9.DataSetName = "midasDataSet9";
            this.midasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "tblCliente";
            this.tblClienteBindingSource.DataSource = this.midasDataSet;
            // 
            // midasDataSet
            // 
            this.midasDataSet.DataSetName = "midasDataSet";
            this.midasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Apresentacao.Properties.Resources.document_write_22637;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(407, 447);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 44);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(626, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 44);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(518, 447);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cpoCpf
            // 
            this.cpoCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCpf.Enabled = false;
            this.cpoCpf.Location = new System.Drawing.Point(723, 381);
            this.cpoCpf.Name = "cpoCpf";
            this.cpoCpf.Size = new System.Drawing.Size(103, 20);
            this.cpoCpf.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Razão Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "CPF";
            // 
            // cpoCnpj
            // 
            this.cpoCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCnpj.Location = new System.Drawing.Point(723, 312);
            this.cpoCnpj.Name = "cpoCnpj";
            this.cpoCnpj.Size = new System.Drawing.Size(103, 20);
            this.cpoCnpj.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "CNPJ";
            // 
            // cpoTelefone
            // 
            this.cpoTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoTelefone.Location = new System.Drawing.Point(100, 381);
            this.cpoTelefone.Name = "cpoTelefone";
            this.cpoTelefone.Size = new System.Drawing.Size(247, 20);
            this.cpoTelefone.TabIndex = 10;
            // 
            // cpoEmail
            // 
            this.cpoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEmail.Location = new System.Drawing.Point(433, 381);
            this.cpoEmail.Name = "cpoEmail";
            this.cpoEmail.Size = new System.Drawing.Size(245, 20);
            this.cpoEmail.TabIndex = 11;
            // 
            // cpoEndereco
            // 
            this.cpoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEndereco.Location = new System.Drawing.Point(100, 348);
            this.cpoEndereco.Name = "cpoEndereco";
            this.cpoEndereco.Size = new System.Drawing.Size(247, 20);
            this.cpoEndereco.TabIndex = 6;
            // 
            // cpoCidade
            // 
            this.cpoCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCidade.Location = new System.Drawing.Point(433, 348);
            this.cpoCidade.Name = "cpoCidade";
            this.cpoCidade.Size = new System.Drawing.Size(170, 20);
            this.cpoCidade.TabIndex = 7;
            // 
            // cpoUf
            // 
            this.cpoUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoUf.Location = new System.Drawing.Point(636, 348);
            this.cpoUf.Name = "cpoUf";
            this.cpoUf.Size = new System.Drawing.Size(42, 20);
            this.cpoUf.TabIndex = 8;
            // 
            // cpoRazaoSocial
            // 
            this.cpoRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoRazaoSocial.Location = new System.Drawing.Point(433, 312);
            this.cpoRazaoSocial.Name = "cpoRazaoSocial";
            this.cpoRazaoSocial.Size = new System.Drawing.Size(246, 20);
            this.cpoRazaoSocial.TabIndex = 4;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(735, 447);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(49, 463);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(0, 13);
            this.lblIDCliente.TabIndex = 79;
            // 
            // cpoIDCliente
            // 
            this.cpoIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoIDCliente.Location = new System.Drawing.Point(100, 447);
            this.cpoIDCliente.Name = "cpoIDCliente";
            this.cpoIDCliente.Size = new System.Drawing.Size(100, 20);
            this.cpoIDCliente.TabIndex = 80;
            this.cpoIDCliente.Visible = false;
            // 
            // tblClienteBindingSource1
            // 
            this.tblClienteBindingSource1.DataMember = "tblCliente";
            this.tblClienteBindingSource1.DataSource = this.midasDataSet;
            // 
            // tblClienteBindingSource2
            // 
            this.tblClienteBindingSource2.DataMember = "tblCliente";
            this.tblClienteBindingSource2.DataSource = this.midasDataSet;
            // 
            // tblClienteTableAdapter1
            // 
            this.tblClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBoxCpf
            // 
            this.checkBoxCpf.AutoSize = true;
            this.checkBoxCpf.Location = new System.Drawing.Point(723, 351);
            this.checkBoxCpf.Name = "checkBoxCpf";
            this.checkBoxCpf.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCpf.TabIndex = 81;
            this.checkBoxCpf.Text = "Pessoa Física";
            this.checkBoxCpf.UseVisualStyleBackColor = true;
            this.checkBoxCpf.CheckedChanged += new System.EventHandler(this.checkBoxCpf_CheckedChanged);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.checkBoxCpf);
            this.Controls.Add(this.cpoIDCliente);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbl_data_hora);
            this.Controls.Add(this.cpoRazaoSocial);
            this.Controls.Add(this.cpoUf);
            this.Controls.Add(this.cpoCidade);
            this.Controls.Add(this.cpoEndereco);
            this.Controls.Add(this.cpoEmail);
            this.Controls.Add(this.cpoTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cpoCnpj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpoCpf);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgwCliente);
            this.Controls.Add(this.cpoNome);
            this.Controls.Add(this.cpoCaixaPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_data_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpoCaixaPesquisa;
        private System.Windows.Forms.TextBox cpoNome;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox cpoCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpoCnpj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpoTelefone;
        private System.Windows.Forms.TextBox cpoEmail;
        private System.Windows.Forms.TextBox cpoEndereco;
        private System.Windows.Forms.TextBox cpoCidade;
        private System.Windows.Forms.TextBox cpoUf;
        private System.Windows.Forms.TextBox cpoRazaoSocial;
        private midasDataSetCliente midasDataSet;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private midasDataSetTableAdapters.tblClienteTableAdapter tblClienteTableAdapter;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox cpoIDCliente;
        private System.Windows.Forms.BindingSource tblClienteBindingSource2;
        private System.Windows.Forms.BindingSource tblClienteBindingSource1;
        private midasDataSet9 midasDataSet9;
        private System.Windows.Forms.BindingSource tblClienteBindingSource3;
        private midasDataSet9TableAdapters.tblClienteTableAdapter tblClienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxCpf;
    }
}