namespace GerenciaVasco.View
{
    partial class GerenciaJogador
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaPosicao = new System.Windows.Forms.Button();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.dateContrato = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCamisa = new System.Windows.Forms.TextBox();
            this.comboPerna = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPosicao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idjogadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocamisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pernaboaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimcontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaVascoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaVascoDataSet1 = new GerenciaVasco.GerenciaVascoDataSet1();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaVascoDataSet = new GerenciaVasco.GerenciaVascoDataSet();
            this.jogadorTableAdapter = new GerenciaVasco.GerenciaVascoDataSetTableAdapters.jogadorTableAdapter();
            this.gerenciaVascoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorTableAdapter1 = new GerenciaVasco.GerenciaVascoDataSet1TableAdapters.jogadorTableAdapter();
            this.jogadorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaVascoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(21, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click_1);
            // 
            // btAterar
            // 
            this.btAterar.Location = new System.Drawing.Point(113, 12);
            this.btAterar.Name = "btAterar";
            this.btAterar.Size = new System.Drawing.Size(75, 23);
            this.btAterar.TabIndex = 1;
            this.btAterar.Text = "Alterar";
            this.btAterar.UseVisualStyleBackColor = true;
            this.btAterar.Click += new System.EventHandler(this.btAterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(204, 12);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 41);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(413, 20);
            this.tbNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Jogador";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::GerenciaVasco.Properties.Resources.ribagol;
            this.groupBox1.Controls.Add(this.btnPesquisaPosicao);
            this.groupBox1.Controls.Add(this.btnPesquisaNome);
            this.groupBox1.Controls.Add(this.dateContrato);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCamisa);
            this.groupBox1.Controls.Add(this.comboPerna);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboPosicao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Location = new System.Drawing.Point(21, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados jogador";
            // 
            // btnPesquisaPosicao
            // 
            this.btnPesquisaPosicao.Location = new System.Drawing.Point(516, 68);
            this.btnPesquisaPosicao.Name = "btnPesquisaPosicao";
            this.btnPesquisaPosicao.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaPosicao.TabIndex = 27;
            this.btnPesquisaPosicao.Text = "Pesquisar";
            this.btnPesquisaPosicao.UseVisualStyleBackColor = true;
            this.btnPesquisaPosicao.Click += new System.EventHandler(this.btnPesquisaPosicao_Click);
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.Location = new System.Drawing.Point(347, 68);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaNome.TabIndex = 26;
            this.btnPesquisaNome.Text = "Pesquisar";
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // dateContrato
            // 
            this.dateContrato.Location = new System.Drawing.Point(9, 105);
            this.dateContrato.Name = "dateContrato";
            this.dateContrato.Size = new System.Drawing.Size(263, 20);
            this.dateContrato.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Termino do contrato";
            // 
            // tbCamisa
            // 
            this.tbCamisa.Location = new System.Drawing.Point(600, 40);
            this.tbCamisa.Name = "tbCamisa";
            this.tbCamisa.Size = new System.Drawing.Size(153, 20);
            this.tbCamisa.TabIndex = 12;
            // 
            // comboPerna
            // 
            this.comboPerna.FormattingEnabled = true;
            this.comboPerna.Items.AddRange(new object[] {
            "Perna esquerda",
            "Perna direita",
            "Ambidestro"});
            this.comboPerna.Location = new System.Drawing.Point(769, 39);
            this.comboPerna.Name = "comboPerna";
            this.comboPerna.Size = new System.Drawing.Size(152, 21);
            this.comboPerna.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Perna boa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nº Camisa";
            // 
            // comboPosicao
            // 
            this.comboPosicao.FormattingEnabled = true;
            this.comboPosicao.Items.AddRange(new object[] {
            "Goleiro",
            "Zagueiro",
            "Lateral Direito",
            "Lateral Esquerdo",
            "Volante",
            "Meio-campo",
            "Atacante",
            "Centro avante"});
            this.comboPosicao.Location = new System.Drawing.Point(439, 40);
            this.comboPosicao.Name = "comboPosicao";
            this.comboPosicao.Size = new System.Drawing.Size(152, 21);
            this.comboPosicao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Posição do Jogador";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::GerenciaVasco.Properties.Resources.ribagol;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbEstado);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbBairro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbComplemento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbEndereco);
            this.groupBox2.Controls.Add(this.lbCep);
            this.groupBox2.Controls.Add(this.tbCep);
            this.groupBox2.Location = new System.Drawing.Point(21, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço do jogador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(183, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Estado";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(616, 74);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(137, 20);
            this.tbEstado.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bairro";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(616, 35);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(137, 20);
            this.tbBairro.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(319, 74);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(137, 20);
            this.tbCidade.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Complemento";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(319, 35);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(137, 20);
            this.tbComplemento.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Endereco";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(35, 74);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(157, 20);
            this.tbEndereco.TabIndex = 16;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(17, 19);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(31, 13);
            this.lbCep.TabIndex = 15;
            this.lbCep.Text = "CEP:";
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(35, 35);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(114, 20);
            this.tbCep.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lista de jogadores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjogadorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.posicaoDataGridViewTextBoxColumn,
            this.numerocamisaDataGridViewTextBoxColumn,
            this.pernaboaDataGridViewTextBoxColumn,
            this.fimcontratoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.endereco1DataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jogadorBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 178);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mouse);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idjogadorDataGridViewTextBoxColumn
            // 
            this.idjogadorDataGridViewTextBoxColumn.DataPropertyName = "id_jogador";
            this.idjogadorDataGridViewTextBoxColumn.HeaderText = "id_jogador";
            this.idjogadorDataGridViewTextBoxColumn.Name = "idjogadorDataGridViewTextBoxColumn";
            this.idjogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // posicaoDataGridViewTextBoxColumn
            // 
            this.posicaoDataGridViewTextBoxColumn.DataPropertyName = "posicao";
            this.posicaoDataGridViewTextBoxColumn.HeaderText = "posicao";
            this.posicaoDataGridViewTextBoxColumn.Name = "posicaoDataGridViewTextBoxColumn";
            // 
            // numerocamisaDataGridViewTextBoxColumn
            // 
            this.numerocamisaDataGridViewTextBoxColumn.DataPropertyName = "numero_camisa";
            this.numerocamisaDataGridViewTextBoxColumn.HeaderText = "numero_camisa";
            this.numerocamisaDataGridViewTextBoxColumn.Name = "numerocamisaDataGridViewTextBoxColumn";
            // 
            // pernaboaDataGridViewTextBoxColumn
            // 
            this.pernaboaDataGridViewTextBoxColumn.DataPropertyName = "perna_boa";
            this.pernaboaDataGridViewTextBoxColumn.HeaderText = "perna_boa";
            this.pernaboaDataGridViewTextBoxColumn.Name = "pernaboaDataGridViewTextBoxColumn";
            // 
            // fimcontratoDataGridViewTextBoxColumn
            // 
            this.fimcontratoDataGridViewTextBoxColumn.DataPropertyName = "fim_contrato";
            this.fimcontratoDataGridViewTextBoxColumn.HeaderText = "fim_contrato";
            this.fimcontratoDataGridViewTextBoxColumn.Name = "fimcontratoDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // endereco1DataGridViewTextBoxColumn
            // 
            this.endereco1DataGridViewTextBoxColumn.DataPropertyName = "endereco1";
            this.endereco1DataGridViewTextBoxColumn.HeaderText = "endereco1";
            this.endereco1DataGridViewTextBoxColumn.Name = "endereco1DataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // jogadorBindingSource2
            // 
            this.jogadorBindingSource2.DataMember = "jogador";
            this.jogadorBindingSource2.DataSource = this.gerenciaVascoDataSet1BindingSource;
            // 
            // gerenciaVascoDataSet1BindingSource
            // 
            this.gerenciaVascoDataSet1BindingSource.DataSource = this.gerenciaVascoDataSet1;
            this.gerenciaVascoDataSet1BindingSource.Position = 0;
            // 
            // gerenciaVascoDataSet1
            // 
            this.gerenciaVascoDataSet1.DataSetName = "GerenciaVascoDataSet1";
            this.gerenciaVascoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataMember = "jogador";
            this.jogadorBindingSource.DataSource = this.gerenciaVascoDataSet;
            // 
            // gerenciaVascoDataSet
            // 
            this.gerenciaVascoDataSet.DataSetName = "GerenciaVascoDataSet";
            this.gerenciaVascoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadorTableAdapter
            // 
            this.jogadorTableAdapter.ClearBeforeFill = true;
            // 
            // gerenciaVascoDataSetBindingSource
            // 
            this.gerenciaVascoDataSetBindingSource.DataSource = this.gerenciaVascoDataSet;
            this.gerenciaVascoDataSetBindingSource.Position = 0;
            // 
            // jogadorBindingSource1
            // 
            this.jogadorBindingSource1.DataMember = "jogador";
            this.jogadorBindingSource1.DataSource = this.gerenciaVascoDataSetBindingSource;
            // 
            // jogadorTableAdapter1
            // 
            this.jogadorTableAdapter1.ClearBeforeFill = true;
            // 
            // jogadorBindingSource3
            // 
            this.jogadorBindingSource3.DataMember = "jogador";
            this.jogadorBindingSource3.DataSource = this.gerenciaVascoDataSet1BindingSource;
            // 
            // gerenciaVascoDataSetBindingSource1
            // 
            this.gerenciaVascoDataSetBindingSource1.DataSource = this.gerenciaVascoDataSet;
            this.gerenciaVascoDataSetBindingSource1.Position = 0;
            // 
            // GerenciaJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciaVasco.Properties.Resources.vasco_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAterar);
            this.Controls.Add(this.btAdicionar);
            this.Name = "GerenciaJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciaJogador";
            this.Load += new System.EventHandler(this.GerenciaJogador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaVascoDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboPosicao;
        private System.Windows.Forms.ComboBox comboPerna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCamisa;
        private System.Windows.Forms.DateTimePicker dateContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GerenciaVascoDataSet gerenciaVascoDataSet;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private GerenciaVascoDataSetTableAdapters.jogadorTableAdapter jogadorTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Button btnPesquisaPosicao;
        private System.Windows.Forms.BindingSource gerenciaVascoDataSetBindingSource;
        private System.Windows.Forms.BindingSource gerenciaVascoDataSet1BindingSource;
        private GerenciaVascoDataSet1 gerenciaVascoDataSet1;
        private System.Windows.Forms.BindingSource jogadorBindingSource1;
        private System.Windows.Forms.BindingSource jogadorBindingSource2;
        private GerenciaVascoDataSet1TableAdapters.jogadorTableAdapter jogadorTableAdapter1;
        private System.Windows.Forms.BindingSource jogadorBindingSource3;
        private System.Windows.Forms.BindingSource gerenciaVascoDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjogadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocamisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pernaboaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimcontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}