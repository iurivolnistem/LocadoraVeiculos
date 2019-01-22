namespace Projeto_Locadora
{
    partial class CadastroLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLocacao));
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.gbox_cadastroLocacao = new System.Windows.Forms.GroupBox();
            this.cbox_statusLocacao = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbox_tipoPagamento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbox_totalLocacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_totalDias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_previsaoDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btn_buscarCarro = new System.Windows.Forms.Button();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_carro = new System.Windows.Forms.TextBox();
            this.tbox_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_locacao = new System.Windows.Forms.DateTimePicker();
            this.tbox_codCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_codCli = new System.Windows.Forms.TextBox();
            this.btn_buscarFuncionario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_funcionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_codFunc = new System.Windows.Forms.TextBox();
            this.cbox_localLocacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gbox_cadastroLocacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(356, 319);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(62, 23);
            this.btn_localizar.TabIndex = 5;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(288, 319);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 319);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(62, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(152, 319);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(62, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(84, 319);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // gbox_cadastroLocacao
            // 
            this.gbox_cadastroLocacao.Controls.Add(this.cbox_statusLocacao);
            this.gbox_cadastroLocacao.Controls.Add(this.label14);
            this.gbox_cadastroLocacao.Controls.Add(this.cbox_tipoPagamento);
            this.gbox_cadastroLocacao.Controls.Add(this.label13);
            this.gbox_cadastroLocacao.Controls.Add(this.label12);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_totalLocacao);
            this.gbox_cadastroLocacao.Controls.Add(this.label11);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_totalDias);
            this.gbox_cadastroLocacao.Controls.Add(this.label10);
            this.gbox_cadastroLocacao.Controls.Add(this.dtp_previsaoDevolucao);
            this.gbox_cadastroLocacao.Controls.Add(this.btn_buscarCarro);
            this.gbox_cadastroLocacao.Controls.Add(this.btn_buscarCliente);
            this.gbox_cadastroLocacao.Controls.Add(this.label5);
            this.gbox_cadastroLocacao.Controls.Add(this.label3);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_carro);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_cliente);
            this.gbox_cadastroLocacao.Controls.Add(this.label9);
            this.gbox_cadastroLocacao.Controls.Add(this.label6);
            this.gbox_cadastroLocacao.Controls.Add(this.dtp_locacao);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_codCar);
            this.gbox_cadastroLocacao.Controls.Add(this.label4);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_codCli);
            this.gbox_cadastroLocacao.Controls.Add(this.btn_buscarFuncionario);
            this.gbox_cadastroLocacao.Controls.Add(this.label7);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_funcionario);
            this.gbox_cadastroLocacao.Controls.Add(this.label2);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_codFunc);
            this.gbox_cadastroLocacao.Controls.Add(this.cbox_localLocacao);
            this.gbox_cadastroLocacao.Controls.Add(this.label1);
            this.gbox_cadastroLocacao.Controls.Add(this.tbox_codigo);
            this.gbox_cadastroLocacao.Controls.Add(this.label8);
            this.gbox_cadastroLocacao.Location = new System.Drawing.Point(13, 11);
            this.gbox_cadastroLocacao.Name = "gbox_cadastroLocacao";
            this.gbox_cadastroLocacao.Size = new System.Drawing.Size(411, 300);
            this.gbox_cadastroLocacao.TabIndex = 30;
            this.gbox_cadastroLocacao.TabStop = false;
            // 
            // cbox_statusLocacao
            // 
            this.cbox_statusLocacao.FormattingEnabled = true;
            this.cbox_statusLocacao.Location = new System.Drawing.Point(302, 267);
            this.cbox_statusLocacao.Name = "cbox_statusLocacao";
            this.cbox_statusLocacao.Size = new System.Drawing.Size(103, 21);
            this.cbox_statusLocacao.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Status Locação";
            // 
            // cbox_tipoPagamento
            // 
            this.cbox_tipoPagamento.FormattingEnabled = true;
            this.cbox_tipoPagamento.Location = new System.Drawing.Point(118, 267);
            this.cbox_tipoPagamento.Name = "cbox_tipoPagamento";
            this.cbox_tipoPagamento.Size = new System.Drawing.Size(178, 21);
            this.cbox_tipoPagamento.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Forma de Pagamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total Locação";
            // 
            // tbox_totalLocacao
            // 
            this.tbox_totalLocacao.Location = new System.Drawing.Point(6, 267);
            this.tbox_totalLocacao.Name = "tbox_totalLocacao";
            this.tbox_totalLocacao.ReadOnly = true;
            this.tbox_totalLocacao.Size = new System.Drawing.Size(106, 20);
            this.tbox_totalLocacao.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Qtde. Dias";
            // 
            // tbox_totalDias
            // 
            this.tbox_totalDias.Location = new System.Drawing.Point(302, 228);
            this.tbox_totalDias.Name = "tbox_totalDias";
            this.tbox_totalDias.ReadOnly = true;
            this.tbox_totalDias.Size = new System.Drawing.Size(103, 20);
            this.tbox_totalDias.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Data Devolução Prevista";
            // 
            // dtp_previsaoDevolucao
            // 
            this.dtp_previsaoDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_previsaoDevolucao.Location = new System.Drawing.Point(154, 228);
            this.dtp_previsaoDevolucao.Name = "dtp_previsaoDevolucao";
            this.dtp_previsaoDevolucao.Size = new System.Drawing.Size(142, 20);
            this.dtp_previsaoDevolucao.TabIndex = 5;
            this.dtp_previsaoDevolucao.ValueChanged += new System.EventHandler(this.dtp_previsaoDevolucao_ValueChanged);
            // 
            // btn_buscarCarro
            // 
            this.btn_buscarCarro.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarCarro.Image")));
            this.btn_buscarCarro.Location = new System.Drawing.Point(380, 147);
            this.btn_buscarCarro.Name = "btn_buscarCarro";
            this.btn_buscarCarro.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarCarro.TabIndex = 2;
            this.btn_buscarCarro.UseVisualStyleBackColor = true;
            this.btn_buscarCarro.Click += new System.EventHandler(this.btn_buscarCarro_Click);
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarCliente.Image")));
            this.btn_buscarCliente.Location = new System.Drawing.Point(380, 108);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarCliente.TabIndex = 1;
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cliente";
            // 
            // tbox_carro
            // 
            this.tbox_carro.Location = new System.Drawing.Point(112, 149);
            this.tbox_carro.Name = "tbox_carro";
            this.tbox_carro.ReadOnly = true;
            this.tbox_carro.Size = new System.Drawing.Size(262, 20);
            this.tbox_carro.TabIndex = 34;
            // 
            // tbox_cliente
            // 
            this.tbox_cliente.Location = new System.Drawing.Point(112, 110);
            this.tbox_cliente.Name = "tbox_cliente";
            this.tbox_cliente.ReadOnly = true;
            this.tbox_cliente.Size = new System.Drawing.Size(262, 20);
            this.tbox_cliente.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cód. Carro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Locação";
            // 
            // dtp_locacao
            // 
            this.dtp_locacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_locacao.Location = new System.Drawing.Point(6, 228);
            this.dtp_locacao.Name = "dtp_locacao";
            this.dtp_locacao.Size = new System.Drawing.Size(142, 20);
            this.dtp_locacao.TabIndex = 4;
            this.dtp_locacao.ValueChanged += new System.EventHandler(this.dtp_locacao_ValueChanged);
            // 
            // tbox_codCar
            // 
            this.tbox_codCar.Location = new System.Drawing.Point(6, 149);
            this.tbox_codCar.Name = "tbox_codCar";
            this.tbox_codCar.ReadOnly = true;
            this.tbox_codCar.Size = new System.Drawing.Size(100, 20);
            this.tbox_codCar.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cód. Cliente";
            // 
            // tbox_codCli
            // 
            this.tbox_codCli.Location = new System.Drawing.Point(6, 110);
            this.tbox_codCli.Name = "tbox_codCli";
            this.tbox_codCli.ReadOnly = true;
            this.tbox_codCli.Size = new System.Drawing.Size(100, 20);
            this.tbox_codCli.TabIndex = 27;
            // 
            // btn_buscarFuncionario
            // 
            this.btn_buscarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarFuncionario.Image")));
            this.btn_buscarFuncionario.Location = new System.Drawing.Point(380, 69);
            this.btn_buscarFuncionario.Name = "btn_buscarFuncionario";
            this.btn_buscarFuncionario.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarFuncionario.TabIndex = 0;
            this.btn_buscarFuncionario.UseVisualStyleBackColor = true;
            this.btn_buscarFuncionario.Click += new System.EventHandler(this.btn_buscarFuncionario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Funcionário";
            // 
            // tbox_funcionario
            // 
            this.tbox_funcionario.Location = new System.Drawing.Point(112, 71);
            this.tbox_funcionario.Name = "tbox_funcionario";
            this.tbox_funcionario.ReadOnly = true;
            this.tbox_funcionario.Size = new System.Drawing.Size(262, 20);
            this.tbox_funcionario.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cód. Funcionário";
            // 
            // tbox_codFunc
            // 
            this.tbox_codFunc.Location = new System.Drawing.Point(6, 71);
            this.tbox_codFunc.Name = "tbox_codFunc";
            this.tbox_codFunc.ReadOnly = true;
            this.tbox_codFunc.Size = new System.Drawing.Size(100, 20);
            this.tbox_codFunc.TabIndex = 22;
            // 
            // cbox_localLocacao
            // 
            this.cbox_localLocacao.FormattingEnabled = true;
            this.cbox_localLocacao.Location = new System.Drawing.Point(6, 188);
            this.cbox_localLocacao.Name = "cbox_localLocacao";
            this.cbox_localLocacao.Size = new System.Drawing.Size(399, 21);
            this.cbox_localLocacao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(6, 32);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Local Locação";
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(16, 319);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(62, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // CadastroLocacao
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(437, 353);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.gbox_cadastroLocacao);
            this.Controls.Add(this.btn_incluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroLocacao";
            this.Load += new System.EventHandler(this.CadastroLocacao_Load);
            this.gbox_cadastroLocacao.ResumeLayout(false);
            this.gbox_cadastroLocacao.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.GroupBox gbox_cadastroLocacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_codFunc;
        private System.Windows.Forms.ComboBox cbox_localLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_locacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_buscarFuncionario;
        private System.Windows.Forms.Button btn_buscarCarro;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_carro;
        private System.Windows.Forms.TextBox tbox_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_codCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_codCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbox_totalDias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_previsaoDevolucao;
        private System.Windows.Forms.ComboBox cbox_statusLocacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbox_tipoPagamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbox_totalLocacao;

        #endregion
    }
}