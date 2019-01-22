namespace Projeto_Locadora
{
    partial class frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDoCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeEUFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_funcionario = new System.Windows.Forms.PictureBox();
            this.picture_locacao = new System.Windows.Forms.PictureBox();
            this.picture_carro = new System.Windows.Forms.PictureBox();
            this.picture_cliente = new System.Windows.Forms.PictureBox();
            this.picture_devolução = new System.Windows.Forms.PictureBox();
            this.PainelJanelas = new System.Windows.Forms.SplitContainer();
            this.picture_home = new System.Windows.Forms.PictureBox();
            this.picture_filial = new System.Windows.Forms.PictureBox();
            this.gbox_gerarRelatorio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_locacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_carro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_devolução)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PainelJanelas)).BeginInit();
            this.PainelJanelas.Panel1.SuspendLayout();
            this.PainelJanelas.Panel2.SuspendLayout();
            this.PainelJanelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_filial)).BeginInit();
            this.gbox_gerarRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.carroToolStripMenuItem,
            this.tipoDoCarroToolStripMenuItem,
            this.cidadeEUFToolStripMenuItem,
            this.filialToolStripMenuItem,
            this.statusDoVeículoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // tipoDoCarroToolStripMenuItem
            // 
            this.tipoDoCarroToolStripMenuItem.Name = "tipoDoCarroToolStripMenuItem";
            this.tipoDoCarroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tipoDoCarroToolStripMenuItem.Text = "Tipo do carro";
            this.tipoDoCarroToolStripMenuItem.Click += new System.EventHandler(this.tipoDoCarroToolStripMenuItem_Click);
            // 
            // cidadeEUFToolStripMenuItem
            // 
            this.cidadeEUFToolStripMenuItem.Name = "cidadeEUFToolStripMenuItem";
            this.cidadeEUFToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cidadeEUFToolStripMenuItem.Text = "Cidade e UF";
            this.cidadeEUFToolStripMenuItem.Click += new System.EventHandler(this.cidadeEUFToolStripMenuItem_Click);
            // 
            // filialToolStripMenuItem
            // 
            this.filialToolStripMenuItem.Name = "filialToolStripMenuItem";
            this.filialToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.filialToolStripMenuItem.Text = "Filial";
            this.filialToolStripMenuItem.Click += new System.EventHandler(this.filialToolStripMenuItem_Click);
            // 
            // statusDoVeículoToolStripMenuItem
            // 
            this.statusDoVeículoToolStripMenuItem.Name = "statusDoVeículoToolStripMenuItem";
            this.statusDoVeículoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.statusDoVeículoToolStripMenuItem.Text = "Status do veículo";
            this.statusDoVeículoToolStripMenuItem.Click += new System.EventHandler(this.statusDoVeículoToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoToolStripMenuItem1,
            this.devoluçãoToolStripMenuItem});
            this.locaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.locaçãoToolStripMenuItem.Text = "Serviços";
            // 
            // locaçãoToolStripMenuItem1
            // 
            this.locaçãoToolStripMenuItem1.Name = "locaçãoToolStripMenuItem1";
            this.locaçãoToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.locaçãoToolStripMenuItem1.Text = "Locação";
            this.locaçãoToolStripMenuItem1.Click += new System.EventHandler(this.locaçãoToolStripMenuItem1_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.carrosToolStripMenuItem,
            this.locaçõesToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.carrosToolStripMenuItem.Text = "Carros";
            this.carrosToolStripMenuItem.Click += new System.EventHandler(this.carrosToolStripMenuItem_Click);
            // 
            // locaçõesToolStripMenuItem
            // 
            this.locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            this.locaçõesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.locaçõesToolStripMenuItem.Text = "Locações";
            this.locaçõesToolStripMenuItem.Click += new System.EventHandler(this.locaçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // picture_funcionario
            // 
            this.picture_funcionario.AccessibleDescription = "Cadastro de funcionário";
            this.picture_funcionario.AccessibleName = "Funcionários";
            this.picture_funcionario.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_funcionario.Image = ((System.Drawing.Image)(resources.GetObject("picture_funcionario.Image")));
            this.picture_funcionario.Location = new System.Drawing.Point(136, 4);
            this.picture_funcionario.Name = "picture_funcionario";
            this.picture_funcionario.Size = new System.Drawing.Size(50, 57);
            this.picture_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_funcionario.TabIndex = 11;
            this.picture_funcionario.TabStop = false;
            this.picture_funcionario.Click += new System.EventHandler(this.picture_funcionario_Click);
            // 
            // picture_locacao
            // 
            this.picture_locacao.AccessibleDescription = "Cadastro de locações";
            this.picture_locacao.AccessibleName = "Locações";
            this.picture_locacao.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_locacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_locacao.Image = ((System.Drawing.Image)(resources.GetObject("picture_locacao.Image")));
            this.picture_locacao.Location = new System.Drawing.Point(320, 4);
            this.picture_locacao.Name = "picture_locacao";
            this.picture_locacao.Size = new System.Drawing.Size(50, 57);
            this.picture_locacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_locacao.TabIndex = 13;
            this.picture_locacao.TabStop = false;
            this.picture_locacao.Click += new System.EventHandler(this.picture_locacao_Click);
            // 
            // picture_carro
            // 
            this.picture_carro.AccessibleDescription = "Cadastro de carros";
            this.picture_carro.AccessibleName = "Carros";
            this.picture_carro.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_carro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_carro.Image = ((System.Drawing.Image)(resources.GetObject("picture_carro.Image")));
            this.picture_carro.Location = new System.Drawing.Point(258, 4);
            this.picture_carro.Name = "picture_carro";
            this.picture_carro.Size = new System.Drawing.Size(50, 57);
            this.picture_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_carro.TabIndex = 11;
            this.picture_carro.TabStop = false;
            this.picture_carro.Click += new System.EventHandler(this.picture_carro_Click);
            // 
            // picture_cliente
            // 
            this.picture_cliente.AccessibleDescription = "Cadastro de clientes";
            this.picture_cliente.AccessibleName = "Clientes";
            this.picture_cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picture_cliente.Image")));
            this.picture_cliente.Location = new System.Drawing.Point(198, 4);
            this.picture_cliente.Name = "picture_cliente";
            this.picture_cliente.Size = new System.Drawing.Size(48, 57);
            this.picture_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_cliente.TabIndex = 11;
            this.picture_cliente.TabStop = false;
            this.picture_cliente.Click += new System.EventHandler(this.picture_cliente_Click);
            // 
            // picture_devolução
            // 
            this.picture_devolução.AccessibleDescription = "Cadastro de devolução";
            this.picture_devolução.AccessibleName = "Devolução";
            this.picture_devolução.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_devolução.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_devolução.Image = ((System.Drawing.Image)(resources.GetObject("picture_devolução.Image")));
            this.picture_devolução.Location = new System.Drawing.Point(382, 4);
            this.picture_devolução.Name = "picture_devolução";
            this.picture_devolução.Size = new System.Drawing.Size(50, 57);
            this.picture_devolução.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_devolução.TabIndex = 14;
            this.picture_devolução.TabStop = false;
            this.picture_devolução.Click += new System.EventHandler(this.picture_devolução_Click);
            // 
            // PainelJanelas
            // 
            this.PainelJanelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelJanelas.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PainelJanelas.IsSplitterFixed = true;
            this.PainelJanelas.Location = new System.Drawing.Point(0, 24);
            this.PainelJanelas.Name = "PainelJanelas";
            this.PainelJanelas.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PainelJanelas.Panel1
            // 
            this.PainelJanelas.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PainelJanelas.Panel1.Controls.Add(this.picture_home);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_funcionario);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_devolução);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_filial);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_locacao);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_cliente);
            this.PainelJanelas.Panel1.Controls.Add(this.picture_carro);
            // 
            // PainelJanelas.Panel2
            // 
            this.PainelJanelas.Panel2.Controls.Add(this.gbox_gerarRelatorio);
            this.PainelJanelas.Panel2.ForeColor = System.Drawing.Color.Black;
            this.PainelJanelas.Size = new System.Drawing.Size(537, 421);
            this.PainelJanelas.SplitterDistance = 64;
            this.PainelJanelas.SplitterWidth = 1;
            this.PainelJanelas.TabIndex = 15;
            // 
            // picture_home
            // 
            this.picture_home.AccessibleDescription = "Tela Inicial";
            this.picture_home.AccessibleName = "Home";
            this.picture_home.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_home.Image = ((System.Drawing.Image)(resources.GetObject("picture_home.Image")));
            this.picture_home.Location = new System.Drawing.Point(12, 4);
            this.picture_home.Name = "picture_home";
            this.picture_home.Size = new System.Drawing.Size(50, 57);
            this.picture_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_home.TabIndex = 16;
            this.picture_home.TabStop = false;
            this.picture_home.Click += new System.EventHandler(this.picture_home_Click);
            // 
            // picture_filial
            // 
            this.picture_filial.AccessibleDescription = "Cadastro de filial";
            this.picture_filial.AccessibleName = "Filial";
            this.picture_filial.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.picture_filial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_filial.Image = ((System.Drawing.Image)(resources.GetObject("picture_filial.Image")));
            this.picture_filial.Location = new System.Drawing.Point(74, 4);
            this.picture_filial.Name = "picture_filial";
            this.picture_filial.Size = new System.Drawing.Size(50, 57);
            this.picture_filial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_filial.TabIndex = 15;
            this.picture_filial.TabStop = false;
            this.picture_filial.Click += new System.EventHandler(this.filialToolStripMenuItem_Click);
            // 
            // gbox_gerarRelatorio
            // 
            this.gbox_gerarRelatorio.Controls.Add(this.label1);
            this.gbox_gerarRelatorio.Controls.Add(this.label2);
            this.gbox_gerarRelatorio.Controls.Add(this.btn_gerar);
            this.gbox_gerarRelatorio.Controls.Add(this.dtp_inicio);
            this.gbox_gerarRelatorio.Controls.Add(this.dtp_fim);
            this.gbox_gerarRelatorio.Location = new System.Drawing.Point(12, 20);
            this.gbox_gerarRelatorio.Name = "gbox_gerarRelatorio";
            this.gbox_gerarRelatorio.Size = new System.Drawing.Size(231, 111);
            this.gbox_gerarRelatorio.TabIndex = 7;
            this.gbox_gerarRelatorio.TabStop = false;
            this.gbox_gerarRelatorio.Text = "Relatório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fim";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(6, 75);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_gerar.TabIndex = 1;
            this.btn_gerar.Text = "Gerar Relatório";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(6, 49);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(105, 20);
            this.dtp_inicio.TabIndex = 2;
            // 
            // dtp_fim
            // 
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim.Location = new System.Drawing.Point(117, 49);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(105, 20);
            this.dtp_fim.TabIndex = 3;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(537, 445);
            this.Controls.Add(this.PainelJanelas);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_locacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_carro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_devolução)).EndInit();
            this.PainelJanelas.Panel1.ResumeLayout(false);
            this.PainelJanelas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PainelJanelas)).EndInit();
            this.PainelJanelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_filial)).EndInit();
            this.gbox_gerarRelatorio.ResumeLayout(false);
            this.gbox_gerarRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDoCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeEUFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusDoVeículoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture_funcionario;
        private System.Windows.Forms.PictureBox picture_locacao;
        private System.Windows.Forms.PictureBox picture_carro;
        private System.Windows.Forms.PictureBox picture_cliente;
        private System.Windows.Forms.PictureBox picture_devolução;
        private System.Windows.Forms.SplitContainer PainelJanelas;
        private System.Windows.Forms.PictureBox picture_filial;
        private System.Windows.Forms.PictureBox picture_home;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçõesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbox_gerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
    }
}

