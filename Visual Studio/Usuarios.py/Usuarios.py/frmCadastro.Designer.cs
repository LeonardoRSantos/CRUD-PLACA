namespace Usuarios
{
    partial class frmCadastro
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
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label lblPlaca;
            System.Windows.Forms.Label lblEndereco;
            System.Windows.Forms.Label lblTelefone;
            System.Windows.Forms.Label lblLogin;
            System.Windows.Forms.Label lblSenha;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new Usuarios.Py.bancoDataSet();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDeletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Usuarios.Py.bancoDataSetTableAdapters.usuarioTableAdapter();
            this.dtgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblNome = new System.Windows.Forms.Label();
            lblPlaca = new System.Windows.Forms.Label();
            lblEndereco = new System.Windows.Forms.Label();
            lblTelefone = new System.Windows.Forms.Label();
            lblLogin = new System.Windows.Forms.Label();
            lblSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNome.Location = new System.Drawing.Point(12, 91);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(130, 16);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome Completo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPlaca.Location = new System.Drawing.Point(12, 114);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new System.Drawing.Size(55, 16);
            lblPlaca.TabIndex = 13;
            lblPlaca.Text = "placa:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEndereco.Location = new System.Drawing.Point(12, 143);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new System.Drawing.Size(84, 16);
            lblEndereco.TabIndex = 15;
            lblEndereco.Text = "Endereco:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefone.Location = new System.Drawing.Point(651, 88);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new System.Drawing.Size(80, 16);
            lblTelefone.TabIndex = 17;
            lblTelefone.Text = "Telefone:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLogin.Location = new System.Drawing.Point(655, 115);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(54, 16);
            lblLogin.TabIndex = 21;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSenha.Location = new System.Drawing.Point(655, 144);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(61, 16);
            lblSenha.TabIndex = 21;
            lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "nome_usuario", true));
            this.txtNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 23);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextChanged += new System.EventHandler(this.Apenas_texto);
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "usuario";
            this.usuarioBindingSource2.DataSource = this.bancoDataSet;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPlaca
            // 
            this.txtPlaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "placa", true));
            this.txtPlaca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(148, 114);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(355, 23);
            this.txtPlaca.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "endereco", true));
            this.txtEndereco.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(148, 140);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(355, 23);
            this.txtEndereco.TabIndex = 16;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "telefone", true));
            this.mtbTelefone.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(787, 85);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(120, 21);
            this.mtbTelefone.TabIndex = 18;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.toolStripSeparator1,
            this.tsbtnCancelar,
            this.toolStripSeparator2,
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 55);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGravar.Image")));
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(129, 52);
            this.tsbtnGravar.Text = "Gravar Dados";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(155, 52);
            this.tsbtnCancelar.Text = "Cancelar Cadastro";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = global::Usuarios.Py.Properties.Resources.botao_voltar3;
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(74, 52);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair,
            this.toolStripSeparator3,
            this.tsbtnAtualizar,
            this.toolStripSeparator4,
            this.tsbtnDeletar,
            this.toolStripSeparator5,
            this.tsbtnEditar,
            this.toolStripSeparator6,
            this.tsbtnRefresh,
            this.toolStripSeparator7});
            this.toolStrip2.Location = new System.Drawing.Point(0, 432);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1119, 39);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSair.Image = global::Usuarios.Py.Properties.Resources.sair;
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(62, 36);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnAtualizar
            // 
            this.tsbtnAtualizar.Image = global::Usuarios.Py.Properties.Resources.troca;
            this.tsbtnAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAtualizar.Name = "tsbtnAtualizar";
            this.tsbtnAtualizar.Size = new System.Drawing.Size(89, 36);
            this.tsbtnAtualizar.Text = "Atualizar";
            this.tsbtnAtualizar.Click += new System.EventHandler(this.tsbtnAtualizar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnDeletar
            // 
            this.tsbtnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDeletar.Image")));
            this.tsbtnDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeletar.Name = "tsbtnDeletar";
            this.tsbtnDeletar.Size = new System.Drawing.Size(80, 36);
            this.tsbtnDeletar.Text = "Deletar";
            this.tsbtnDeletar.Click += new System.EventHandler(this.tsbtnDeletar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnEditar
            // 
            this.tsbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditar.Image")));
            this.tsbtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditar.Name = "tsbtnEditar";
            this.tsbtnEditar.Size = new System.Drawing.Size(73, 36);
            this.tsbtnEditar.Text = "Editar";
            this.tsbtnEditar.Click += new System.EventHandler(this.tsbtnEditar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(124, 36);
            this.tsbtnRefresh.Text = "Carregar Dados";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "login", true));
            this.txtLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(787, 112);
            this.txtLogin.MaxLength = 12;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(120, 23);
            this.txtLogin.TabIndex = 22;
            // 
            // txtSenha
            // 
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "senha", true));
            this.txtSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(787, 141);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(120, 23);
            this.txtSenha.TabIndex = 22;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource2, "id_usuario", true));
            this.txtID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(148, 61);
            this.txtID.MaxLength = 11;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 23);
            this.txtID.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Procurar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(148, 184);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(137, 23);
            this.txtProcurar.TabIndex = 49;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoGenerateColumns = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgID,
            this.dtgNome,
            this.dtgPlaca,
            this.dtgEndereco,
            this.dtgTelefone,
            this.dtgLogin});
            this.dgvDados.DataSource = this.usuarioBindingSource2;
            this.dgvDados.Location = new System.Drawing.Point(15, 215);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1084, 197);
            this.dgvDados.TabIndex = 51;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Image = global::Usuarios.Py.Properties.Resources.lupa;
            this.btnProcurar.Location = new System.Drawing.Point(304, 169);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(41, 34);
            this.btnProcurar.TabIndex = 52;
            this.btnProcurar.TabStop = false;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.bancoDataSetBindingSource;
            // 
            // bancoDataSetBindingSource
            // 
            this.bancoDataSetBindingSource.DataSource = this.bancoDataSet;
            this.bancoDataSetBindingSource.Position = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.bancoDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // dtgID
            // 
            this.dtgID.DataPropertyName = "id_usuario";
            this.dtgID.FillWeight = 60F;
            this.dtgID.HeaderText = "ID";
            this.dtgID.Name = "dtgID";
            this.dtgID.ReadOnly = true;
            // 
            // dtgNome
            // 
            this.dtgNome.DataPropertyName = "nome_usuario";
            this.dtgNome.FillWeight = 150F;
            this.dtgNome.HeaderText = "Nome";
            this.dtgNome.Name = "dtgNome";
            this.dtgNome.ReadOnly = true;
            // 
            // dtgPlaca
            // 
            this.dtgPlaca.DataPropertyName = "placa";
            this.dtgPlaca.HeaderText = "Placa";
            this.dtgPlaca.Name = "dtgPlaca";
            this.dtgPlaca.ReadOnly = true;
            // 
            // dtgEndereco
            // 
            this.dtgEndereco.DataPropertyName = "endereco";
            this.dtgEndereco.HeaderText = "Endereço";
            this.dtgEndereco.Name = "dtgEndereco";
            this.dtgEndereco.ReadOnly = true;
            // 
            // dtgTelefone
            // 
            this.dtgTelefone.DataPropertyName = "telefone";
            this.dtgTelefone.HeaderText = "Telefone";
            this.dtgTelefone.Name = "dtgTelefone";
            this.dtgTelefone.ReadOnly = true;
            // 
            // dtgLogin
            // 
            this.dtgLogin.DataPropertyName = "login";
            this.dtgLogin.HeaderText = "Login";
            this.dtgLogin.Name = "dtgLogin";
            this.dtgLogin.ReadOnly = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1119, 471);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(lblSenha);
            this.Controls.Add(lblLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(lblTelefone);
            this.Controls.Add(this.mtbTelefone);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_tab);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnAtualizar;
        private System.Windows.Forms.ToolStripButton tsbtnDeletar;
        private System.Windows.Forms.ErrorProvider epErro;
        private Py.bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private Py.bancoDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.BindingSource bancoDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private System.Windows.Forms.ToolStripButton tsbtnEditar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLogin;
    }
}