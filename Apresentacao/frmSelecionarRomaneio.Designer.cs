namespace Apresentacao
{
    partial class frmSelecionarRomaneio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cpoDtFinal = new System.Windows.Forms.DateTimePicker();
            this.cpoDtInicial = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.cpoCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxTpoPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgwSelRomaneio = new System.Windows.Forms.DataGridView();
            this.iDRomaneioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdFrutasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFreteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoCarregamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorComissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiantFretMotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaNfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalRomaneioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRomaneioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTransportadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFrutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRomaneioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midasDataSetRomaneioCorreto = new Apresentacao.midasDataSetRomaneioCorreto();
            this.tblRomaneioTableAdapter = new Apresentacao.midasDataSetRomaneioCorretoTableAdapters.tblRomaneioTableAdapter();
            this.cpoIDRomaneio = new System.Windows.Forms.TextBox();
            this.cpoNomeCliente = new System.Windows.Forms.TextBox();
            this.cpoNomeTransportador = new System.Windows.Forms.TextBox();
            this.cpoNomeFornecedor = new System.Windows.Forms.TextBox();
            this.cpoQtdGeral = new System.Windows.Forms.TextBox();
            this.cpoUnidMedida = new System.Windows.Forms.TextBox();
            this.cpoFormaPagamento = new System.Windows.Forms.TextBox();
            this.cpoNomeFruta = new System.Windows.Forms.TextBox();
            this.cpoValorTotalRomaneio = new System.Windows.Forms.TextBox();
            this.cpoTaxaNf = new System.Windows.Forms.TextBox();
            this.cpoSeguro = new System.Windows.Forms.TextBox();
            this.cpoAdiantFretMot = new System.Windows.Forms.TextBox();
            this.cpoValorComissao = new System.Windows.Forms.TextBox();
            this.cpoCustoCarreg = new System.Windows.Forms.TextBox();
            this.cpoValorFrete = new System.Windows.Forms.TextBox();
            this.cpoIDFruta = new System.Windows.Forms.TextBox();
            this.cpoIDTransportador = new System.Windows.Forms.TextBox();
            this.cpoIDFornecedor = new System.Windows.Forms.TextBox();
            this.cpoIDCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelRomaneio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRomaneioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetRomaneioCorreto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpoDtFinal
            // 
            this.cpoDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cpoDtFinal.Location = new System.Drawing.Point(212, 52);
            this.cpoDtFinal.Name = "cpoDtFinal";
            this.cpoDtFinal.Size = new System.Drawing.Size(79, 20);
            this.cpoDtFinal.TabIndex = 100008;
            // 
            // cpoDtInicial
            // 
            this.cpoDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cpoDtInicial.Location = new System.Drawing.Point(110, 52);
            this.cpoDtInicial.Name = "cpoDtInicial";
            this.cpoDtInicial.Size = new System.Drawing.Size(79, 20);
            this.cpoDtInicial.TabIndex = 100009;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 100007;
            this.label20.Text = "Período Entre :";
            // 
            // cpoCodigo
            // 
            this.cpoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpoCodigo.Location = new System.Drawing.Point(110, 78);
            this.cpoCodigo.MaxLength = 20;
            this.cpoCodigo.Name = "cpoCodigo";
            this.cpoCodigo.Size = new System.Drawing.Size(75, 20);
            this.cpoCodigo.TabIndex = 100002;
            // 
            // comboBoxTpoPesquisa
            // 
            this.comboBoxTpoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTpoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTpoPesquisa.FormattingEnabled = true;
            this.comboBoxTpoPesquisa.Items.AddRange(new object[] {
            "Data",
            "Código"});
            this.comboBoxTpoPesquisa.Location = new System.Drawing.Point(110, 12);
            this.comboBoxTpoPesquisa.Name = "comboBoxTpoPesquisa";
            this.comboBoxTpoPesquisa.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTpoPesquisa.TabIndex = 100001;
            this.comboBoxTpoPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboBoxTpoPesquisa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 100004;
            this.label1.Text = "Tipo de Pesquisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 100005;
            this.label2.Text = "e";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 100006;
            this.label3.Text = "Código :";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(346, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 59);
            this.btnPesquisar.TabIndex = 100003;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgwSelRomaneio
            // 
            this.dgwSelRomaneio.AllowUserToAddRows = false;
            this.dgwSelRomaneio.AllowUserToDeleteRows = false;
            this.dgwSelRomaneio.AllowUserToResizeRows = false;
            this.dgwSelRomaneio.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelRomaneio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgwSelRomaneio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelRomaneio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRomaneioDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.transportadorDataGridViewTextBoxColumn,
            this.frutaDataGridViewTextBoxColumn,
            this.formaPagamentoDataGridViewTextBoxColumn,
            this.unidMedidaDataGridViewTextBoxColumn,
            this.qtdFrutasDataGridViewTextBoxColumn,
            this.valorFreteDataGridViewTextBoxColumn,
            this.custoCarregamentoDataGridViewTextBoxColumn,
            this.valorComissaoDataGridViewTextBoxColumn,
            this.adiantFretMotDataGridViewTextBoxColumn,
            this.seguroDataGridViewTextBoxColumn,
            this.taxaNfDataGridViewTextBoxColumn,
            this.valorTotalRomaneioDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataRomaneioDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn,
            this.dataExclusaoDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDTransportadorDataGridViewTextBoxColumn,
            this.iDFornecedorDataGridViewTextBoxColumn,
            this.iDFrutaDataGridViewTextBoxColumn});
            this.dgwSelRomaneio.DataSource = this.tblRomaneioBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelRomaneio.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgwSelRomaneio.Location = new System.Drawing.Point(12, 114);
            this.dgwSelRomaneio.MultiSelect = false;
            this.dgwSelRomaneio.Name = "dgwSelRomaneio";
            this.dgwSelRomaneio.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelRomaneio.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgwSelRomaneio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelRomaneio.Size = new System.Drawing.Size(430, 138);
            this.dgwSelRomaneio.TabIndex = 100010;
            this.dgwSelRomaneio.DoubleClick += new System.EventHandler(this.dgwRomaneio_DoubleClick);
            // 
            // iDRomaneioDataGridViewTextBoxColumn
            // 
            this.iDRomaneioDataGridViewTextBoxColumn.DataPropertyName = "IDRomaneio";
            this.iDRomaneioDataGridViewTextBoxColumn.HeaderText = "Cód. Romaneio";
            this.iDRomaneioDataGridViewTextBoxColumn.Name = "iDRomaneioDataGridViewTextBoxColumn";
            this.iDRomaneioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportadorDataGridViewTextBoxColumn
            // 
            this.transportadorDataGridViewTextBoxColumn.DataPropertyName = "Transportador";
            this.transportadorDataGridViewTextBoxColumn.HeaderText = "Transportador";
            this.transportadorDataGridViewTextBoxColumn.Name = "transportadorDataGridViewTextBoxColumn";
            this.transportadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frutaDataGridViewTextBoxColumn
            // 
            this.frutaDataGridViewTextBoxColumn.DataPropertyName = "Fruta";
            this.frutaDataGridViewTextBoxColumn.HeaderText = "Fruta";
            this.frutaDataGridViewTextBoxColumn.Name = "frutaDataGridViewTextBoxColumn";
            this.frutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.HeaderText = "Forma de Pagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            this.formaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidMedidaDataGridViewTextBoxColumn
            // 
            this.unidMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidMedida";
            this.unidMedidaDataGridViewTextBoxColumn.HeaderText = "Unid. de Medida";
            this.unidMedidaDataGridViewTextBoxColumn.Name = "unidMedidaDataGridViewTextBoxColumn";
            this.unidMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdFrutasDataGridViewTextBoxColumn
            // 
            this.qtdFrutasDataGridViewTextBoxColumn.DataPropertyName = "QtdFrutas";
            this.qtdFrutasDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qtdFrutasDataGridViewTextBoxColumn.Name = "qtdFrutasDataGridViewTextBoxColumn";
            this.qtdFrutasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorFreteDataGridViewTextBoxColumn
            // 
            this.valorFreteDataGridViewTextBoxColumn.DataPropertyName = "ValorFrete";
            this.valorFreteDataGridViewTextBoxColumn.HeaderText = "Valor Frete";
            this.valorFreteDataGridViewTextBoxColumn.Name = "valorFreteDataGridViewTextBoxColumn";
            this.valorFreteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoCarregamentoDataGridViewTextBoxColumn
            // 
            this.custoCarregamentoDataGridViewTextBoxColumn.DataPropertyName = "CustoCarregamento";
            this.custoCarregamentoDataGridViewTextBoxColumn.HeaderText = "Custo Carregamento";
            this.custoCarregamentoDataGridViewTextBoxColumn.Name = "custoCarregamentoDataGridViewTextBoxColumn";
            this.custoCarregamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorComissaoDataGridViewTextBoxColumn
            // 
            this.valorComissaoDataGridViewTextBoxColumn.DataPropertyName = "ValorComissao";
            this.valorComissaoDataGridViewTextBoxColumn.HeaderText = "Comissao";
            this.valorComissaoDataGridViewTextBoxColumn.Name = "valorComissaoDataGridViewTextBoxColumn";
            this.valorComissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiantFretMotDataGridViewTextBoxColumn
            // 
            this.adiantFretMotDataGridViewTextBoxColumn.DataPropertyName = "AdiantFretMot";
            this.adiantFretMotDataGridViewTextBoxColumn.HeaderText = "Adiant. de Frete";
            this.adiantFretMotDataGridViewTextBoxColumn.Name = "adiantFretMotDataGridViewTextBoxColumn";
            this.adiantFretMotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seguroDataGridViewTextBoxColumn
            // 
            this.seguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro";
            this.seguroDataGridViewTextBoxColumn.HeaderText = "Seguro";
            this.seguroDataGridViewTextBoxColumn.Name = "seguroDataGridViewTextBoxColumn";
            this.seguroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxaNfDataGridViewTextBoxColumn
            // 
            this.taxaNfDataGridViewTextBoxColumn.DataPropertyName = "TaxaNf";
            this.taxaNfDataGridViewTextBoxColumn.HeaderText = "Taxa Nf";
            this.taxaNfDataGridViewTextBoxColumn.Name = "taxaNfDataGridViewTextBoxColumn";
            this.taxaNfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalRomaneioDataGridViewTextBoxColumn
            // 
            this.valorTotalRomaneioDataGridViewTextBoxColumn.DataPropertyName = "ValorTotalRomaneio";
            this.valorTotalRomaneioDataGridViewTextBoxColumn.HeaderText = "Valor Total Romaneio";
            this.valorTotalRomaneioDataGridViewTextBoxColumn.Name = "valorTotalRomaneioDataGridViewTextBoxColumn";
            this.valorTotalRomaneioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRomaneioDataGridViewTextBoxColumn
            // 
            this.dataRomaneioDataGridViewTextBoxColumn.DataPropertyName = "DataRomaneio";
            this.dataRomaneioDataGridViewTextBoxColumn.HeaderText = "DataRomaneio";
            this.dataRomaneioDataGridViewTextBoxColumn.Name = "dataRomaneioDataGridViewTextBoxColumn";
            this.dataRomaneioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataExclusaoDataGridViewTextBoxColumn
            // 
            this.dataExclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataExclusao";
            this.dataExclusaoDataGridViewTextBoxColumn.HeaderText = "DataExclusao";
            this.dataExclusaoDataGridViewTextBoxColumn.Name = "dataExclusaoDataGridViewTextBoxColumn";
            this.dataExclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataExclusaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTransportadorDataGridViewTextBoxColumn
            // 
            this.iDTransportadorDataGridViewTextBoxColumn.DataPropertyName = "IDTransportador";
            this.iDTransportadorDataGridViewTextBoxColumn.HeaderText = "IDTransportador";
            this.iDTransportadorDataGridViewTextBoxColumn.Name = "iDTransportadorDataGridViewTextBoxColumn";
            this.iDTransportadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTransportadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDFornecedorDataGridViewTextBoxColumn
            // 
            this.iDFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IDFornecedor";
            this.iDFornecedorDataGridViewTextBoxColumn.HeaderText = "IDFornecedor";
            this.iDFornecedorDataGridViewTextBoxColumn.Name = "iDFornecedorDataGridViewTextBoxColumn";
            this.iDFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDFrutaDataGridViewTextBoxColumn
            // 
            this.iDFrutaDataGridViewTextBoxColumn.DataPropertyName = "IDFruta";
            this.iDFrutaDataGridViewTextBoxColumn.HeaderText = "IDFruta";
            this.iDFrutaDataGridViewTextBoxColumn.Name = "iDFrutaDataGridViewTextBoxColumn";
            this.iDFrutaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFrutaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblRomaneioBindingSource
            // 
            this.tblRomaneioBindingSource.DataMember = "tblRomaneio";
            this.tblRomaneioBindingSource.DataSource = this.midasDataSetRomaneioCorreto;
            // 
            // midasDataSetRomaneioCorreto
            // 
            this.midasDataSetRomaneioCorreto.DataSetName = "midasDataSetRomaneioCorreto";
            this.midasDataSetRomaneioCorreto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRomaneioTableAdapter
            // 
            this.tblRomaneioTableAdapter.ClearBeforeFill = true;
            // 
            // cpoIDRomaneio
            // 
            this.cpoIDRomaneio.Location = new System.Drawing.Point(11, 280);
            this.cpoIDRomaneio.Name = "cpoIDRomaneio";
            this.cpoIDRomaneio.Size = new System.Drawing.Size(14, 20);
            this.cpoIDRomaneio.TabIndex = 100011;
            this.cpoIDRomaneio.Visible = false;
            // 
            // cpoNomeCliente
            // 
            this.cpoNomeCliente.Location = new System.Drawing.Point(32, 280);
            this.cpoNomeCliente.Name = "cpoNomeCliente";
            this.cpoNomeCliente.Size = new System.Drawing.Size(14, 20);
            this.cpoNomeCliente.TabIndex = 100012;
            this.cpoNomeCliente.Visible = false;
            // 
            // cpoNomeTransportador
            // 
            this.cpoNomeTransportador.Location = new System.Drawing.Point(73, 280);
            this.cpoNomeTransportador.Name = "cpoNomeTransportador";
            this.cpoNomeTransportador.Size = new System.Drawing.Size(14, 20);
            this.cpoNomeTransportador.TabIndex = 100014;
            this.cpoNomeTransportador.Visible = false;
            // 
            // cpoNomeFornecedor
            // 
            this.cpoNomeFornecedor.Location = new System.Drawing.Point(52, 280);
            this.cpoNomeFornecedor.Name = "cpoNomeFornecedor";
            this.cpoNomeFornecedor.Size = new System.Drawing.Size(14, 20);
            this.cpoNomeFornecedor.TabIndex = 100013;
            this.cpoNomeFornecedor.Visible = false;
            // 
            // cpoQtdGeral
            // 
            this.cpoQtdGeral.Location = new System.Drawing.Point(156, 280);
            this.cpoQtdGeral.Name = "cpoQtdGeral";
            this.cpoQtdGeral.Size = new System.Drawing.Size(14, 20);
            this.cpoQtdGeral.TabIndex = 100018;
            this.cpoQtdGeral.Visible = false;
            // 
            // cpoUnidMedida
            // 
            this.cpoUnidMedida.Location = new System.Drawing.Point(135, 280);
            this.cpoUnidMedida.Name = "cpoUnidMedida";
            this.cpoUnidMedida.Size = new System.Drawing.Size(14, 20);
            this.cpoUnidMedida.TabIndex = 100017;
            this.cpoUnidMedida.Visible = false;
            // 
            // cpoFormaPagamento
            // 
            this.cpoFormaPagamento.Location = new System.Drawing.Point(115, 280);
            this.cpoFormaPagamento.Name = "cpoFormaPagamento";
            this.cpoFormaPagamento.Size = new System.Drawing.Size(14, 20);
            this.cpoFormaPagamento.TabIndex = 100016;
            this.cpoFormaPagamento.Visible = false;
            // 
            // cpoNomeFruta
            // 
            this.cpoNomeFruta.Location = new System.Drawing.Point(94, 280);
            this.cpoNomeFruta.Name = "cpoNomeFruta";
            this.cpoNomeFruta.Size = new System.Drawing.Size(14, 20);
            this.cpoNomeFruta.TabIndex = 100015;
            this.cpoNomeFruta.Visible = false;
            // 
            // cpoValorTotalRomaneio
            // 
            this.cpoValorTotalRomaneio.Location = new System.Drawing.Point(305, 280);
            this.cpoValorTotalRomaneio.Name = "cpoValorTotalRomaneio";
            this.cpoValorTotalRomaneio.Size = new System.Drawing.Size(14, 20);
            this.cpoValorTotalRomaneio.TabIndex = 100025;
            this.cpoValorTotalRomaneio.Visible = false;
            // 
            // cpoTaxaNf
            // 
            this.cpoTaxaNf.Location = new System.Drawing.Point(285, 280);
            this.cpoTaxaNf.Name = "cpoTaxaNf";
            this.cpoTaxaNf.Size = new System.Drawing.Size(14, 20);
            this.cpoTaxaNf.TabIndex = 100024;
            this.cpoTaxaNf.Visible = false;
            // 
            // cpoSeguro
            // 
            this.cpoSeguro.Location = new System.Drawing.Point(264, 280);
            this.cpoSeguro.Name = "cpoSeguro";
            this.cpoSeguro.Size = new System.Drawing.Size(14, 20);
            this.cpoSeguro.TabIndex = 100023;
            this.cpoSeguro.Visible = false;
            // 
            // cpoAdiantFretMot
            // 
            this.cpoAdiantFretMot.Location = new System.Drawing.Point(243, 280);
            this.cpoAdiantFretMot.Name = "cpoAdiantFretMot";
            this.cpoAdiantFretMot.Size = new System.Drawing.Size(14, 20);
            this.cpoAdiantFretMot.TabIndex = 100022;
            this.cpoAdiantFretMot.Visible = false;
            // 
            // cpoValorComissao
            // 
            this.cpoValorComissao.Location = new System.Drawing.Point(222, 280);
            this.cpoValorComissao.Name = "cpoValorComissao";
            this.cpoValorComissao.Size = new System.Drawing.Size(14, 20);
            this.cpoValorComissao.TabIndex = 100021;
            this.cpoValorComissao.Visible = false;
            // 
            // cpoCustoCarreg
            // 
            this.cpoCustoCarreg.Location = new System.Drawing.Point(202, 280);
            this.cpoCustoCarreg.Name = "cpoCustoCarreg";
            this.cpoCustoCarreg.Size = new System.Drawing.Size(14, 20);
            this.cpoCustoCarreg.TabIndex = 100020;
            this.cpoCustoCarreg.Visible = false;
            // 
            // cpoValorFrete
            // 
            this.cpoValorFrete.Location = new System.Drawing.Point(181, 280);
            this.cpoValorFrete.Name = "cpoValorFrete";
            this.cpoValorFrete.Size = new System.Drawing.Size(14, 20);
            this.cpoValorFrete.TabIndex = 100019;
            this.cpoValorFrete.Visible = false;
            // 
            // cpoIDFruta
            // 
            this.cpoIDFruta.Location = new System.Drawing.Point(416, 280);
            this.cpoIDFruta.Name = "cpoIDFruta";
            this.cpoIDFruta.Size = new System.Drawing.Size(14, 20);
            this.cpoIDFruta.TabIndex = 100029;
            this.cpoIDFruta.Visible = false;
            // 
            // cpoIDTransportador
            // 
            this.cpoIDTransportador.Location = new System.Drawing.Point(396, 280);
            this.cpoIDTransportador.Name = "cpoIDTransportador";
            this.cpoIDTransportador.Size = new System.Drawing.Size(14, 20);
            this.cpoIDTransportador.TabIndex = 100028;
            this.cpoIDTransportador.Visible = false;
            // 
            // cpoIDFornecedor
            // 
            this.cpoIDFornecedor.Location = new System.Drawing.Point(375, 280);
            this.cpoIDFornecedor.Name = "cpoIDFornecedor";
            this.cpoIDFornecedor.Size = new System.Drawing.Size(14, 20);
            this.cpoIDFornecedor.TabIndex = 100027;
            this.cpoIDFornecedor.Visible = false;
            // 
            // cpoIDCliente
            // 
            this.cpoIDCliente.Location = new System.Drawing.Point(354, 280);
            this.cpoIDCliente.Name = "cpoIDCliente";
            this.cpoIDCliente.Size = new System.Drawing.Size(14, 20);
            this.cpoIDCliente.TabIndex = 100026;
            this.cpoIDCliente.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(110, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 56);
            this.panel1.TabIndex = 100031;
            this.panel1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmSelecionarRomaneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cpoIDFruta);
            this.Controls.Add(this.cpoIDTransportador);
            this.Controls.Add(this.cpoIDFornecedor);
            this.Controls.Add(this.cpoIDCliente);
            this.Controls.Add(this.cpoValorTotalRomaneio);
            this.Controls.Add(this.cpoTaxaNf);
            this.Controls.Add(this.cpoSeguro);
            this.Controls.Add(this.cpoAdiantFretMot);
            this.Controls.Add(this.cpoValorComissao);
            this.Controls.Add(this.cpoCustoCarreg);
            this.Controls.Add(this.cpoValorFrete);
            this.Controls.Add(this.cpoQtdGeral);
            this.Controls.Add(this.cpoUnidMedida);
            this.Controls.Add(this.cpoFormaPagamento);
            this.Controls.Add(this.cpoNomeFruta);
            this.Controls.Add(this.cpoNomeTransportador);
            this.Controls.Add(this.cpoNomeFornecedor);
            this.Controls.Add(this.cpoNomeCliente);
            this.Controls.Add(this.cpoIDRomaneio);
            this.Controls.Add(this.dgwSelRomaneio);
            this.Controls.Add(this.cpoDtFinal);
            this.Controls.Add(this.cpoDtInicial);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cpoCodigo);
            this.Controls.Add(this.comboBoxTpoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarRomaneio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Romaneio";
            this.Load += new System.EventHandler(this.frmSelecionarRomaneio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelRomaneio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRomaneioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midasDataSetRomaneioCorreto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cpoDtFinal;
        private System.Windows.Forms.DateTimePicker cpoDtInicial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox cpoCodigo;
        private System.Windows.Forms.ComboBox comboBoxTpoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwSelRomaneio;
        private midasDataSetRomaneioCorreto midasDataSetRomaneioCorreto;
        private System.Windows.Forms.BindingSource tblRomaneioBindingSource;
        private midasDataSetRomaneioCorretoTableAdapters.tblRomaneioTableAdapter tblRomaneioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRomaneioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdFrutasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFreteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoCarregamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorComissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiantFretMotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaNfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalRomaneioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRomaneioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTransportadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFrutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cpoIDRomaneio;
        private System.Windows.Forms.TextBox cpoNomeCliente;
        private System.Windows.Forms.TextBox cpoNomeTransportador;
        private System.Windows.Forms.TextBox cpoNomeFornecedor;
        private System.Windows.Forms.TextBox cpoQtdGeral;
        private System.Windows.Forms.TextBox cpoUnidMedida;
        private System.Windows.Forms.TextBox cpoFormaPagamento;
        private System.Windows.Forms.TextBox cpoNomeFruta;
        private System.Windows.Forms.TextBox cpoValorTotalRomaneio;
        private System.Windows.Forms.TextBox cpoTaxaNf;
        private System.Windows.Forms.TextBox cpoSeguro;
        private System.Windows.Forms.TextBox cpoAdiantFretMot;
        private System.Windows.Forms.TextBox cpoValorComissao;
        private System.Windows.Forms.TextBox cpoCustoCarreg;
        private System.Windows.Forms.TextBox cpoValorFrete;
        private System.Windows.Forms.TextBox cpoIDFruta;
        private System.Windows.Forms.TextBox cpoIDTransportador;
        private System.Windows.Forms.TextBox cpoIDFornecedor;
        private System.Windows.Forms.TextBox cpoIDCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}