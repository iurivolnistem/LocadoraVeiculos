namespace Projeto_Locadora
{
    partial class CadastroCliente
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
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.gbox_cadastrocliente = new System.Windows.Forms.GroupBox();
            this.cbox_cidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_telefoneFixo = new System.Windows.Forms.TextBox();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_celular = new System.Windows.Forms.TextBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_endereco = new System.Windows.Forms.TextBox();
            this.tbox_cpf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_cnh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_rg = new System.Windows.Forms.TextBox();
            this.dtp_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gbox_cadastrocliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(355, 288);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(62, 23);
            this.btn_localizar.TabIndex = 5;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(287, 288);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(219, 288);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(62, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(151, 288);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(62, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(83, 288);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // gbox_cadastrocliente
            // 
            this.gbox_cadastrocliente.Controls.Add(this.cbox_cidade);
            this.gbox_cadastrocliente.Controls.Add(this.label1);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_telefoneFixo);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_codigo);
            this.gbox_cadastrocliente.Controls.Add(this.label10);
            this.gbox_cadastrocliente.Controls.Add(this.label2);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_celular);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_nome);
            this.gbox_cadastrocliente.Controls.Add(this.label11);
            this.gbox_cadastrocliente.Controls.Add(this.label3);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_endereco);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_cpf);
            this.gbox_cadastrocliente.Controls.Add(this.label9);
            this.gbox_cadastrocliente.Controls.Add(this.label4);
            this.gbox_cadastrocliente.Controls.Add(this.label8);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_cnh);
            this.gbox_cadastrocliente.Controls.Add(this.label5);
            this.gbox_cadastrocliente.Controls.Add(this.tbox_rg);
            this.gbox_cadastrocliente.Controls.Add(this.dtp_dataNascimento);
            this.gbox_cadastrocliente.Controls.Add(this.label6);
            this.gbox_cadastrocliente.Location = new System.Drawing.Point(12, 12);
            this.gbox_cadastrocliente.Name = "gbox_cadastrocliente";
            this.gbox_cadastrocliente.Size = new System.Drawing.Size(411, 265);
            this.gbox_cadastrocliente.TabIndex = 30;
            this.gbox_cadastrocliente.TabStop = false;
            // 
            // cbox_cidade
            // 
            this.cbox_cidade.FormattingEnabled = true;
            this.cbox_cidade.Location = new System.Drawing.Point(6, 227);
            this.cbox_cidade.Name = "cbox_cidade";
            this.cbox_cidade.Size = new System.Drawing.Size(388, 21);
            this.cbox_cidade.TabIndex = 9;
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
            // tbox_telefoneFixo
            // 
            this.tbox_telefoneFixo.Location = new System.Drawing.Point(138, 149);
            this.tbox_telefoneFixo.Name = "tbox_telefoneFixo";
            this.tbox_telefoneFixo.Size = new System.Drawing.Size(126, 20);
            this.tbox_telefoneFixo.TabIndex = 6;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(6, 32);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefone Fixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(268, 149);
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.Size = new System.Drawing.Size(126, 20);
            this.tbox_celular.TabIndex = 7;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(6, 71);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(388, 20);
            this.tbox_nome.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Telefone Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // tbox_endereco
            // 
            this.tbox_endereco.Location = new System.Drawing.Point(6, 188);
            this.tbox_endereco.Name = "tbox_endereco";
            this.tbox_endereco.Size = new System.Drawing.Size(388, 20);
            this.tbox_endereco.TabIndex = 8;
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.Location = new System.Drawing.Point(6, 110);
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(126, 20);
            this.tbox_cpf.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CNH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade";
            // 
            // tbox_cnh
            // 
            this.tbox_cnh.Location = new System.Drawing.Point(268, 110);
            this.tbox_cnh.Name = "tbox_cnh";
            this.tbox_cnh.Size = new System.Drawing.Size(126, 20);
            this.tbox_cnh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RG";
            // 
            // tbox_rg
            // 
            this.tbox_rg.Location = new System.Drawing.Point(138, 110);
            this.tbox_rg.Name = "tbox_rg";
            this.tbox_rg.Size = new System.Drawing.Size(126, 20);
            this.tbox_rg.TabIndex = 3;
            // 
            // dtp_dataNascimento
            // 
            this.dtp_dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataNascimento.Location = new System.Drawing.Point(6, 149);
            this.dtp_dataNascimento.Name = "dtp_dataNascimento";
            this.dtp_dataNascimento.Size = new System.Drawing.Size(126, 20);
            this.dtp_dataNascimento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de nascimento";
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(15, 288);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(62, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(440, 322);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.gbox_cadastrocliente);
            this.Controls.Add(this.btn_incluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.gbox_cadastrocliente.ResumeLayout(false);
            this.gbox_cadastrocliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.GroupBox gbox_cadastrocliente;
        private System.Windows.Forms.ComboBox cbox_cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_telefoneFixo;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_celular;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_endereco;
        private System.Windows.Forms.TextBox tbox_cpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_cnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_rg;
        private System.Windows.Forms.DateTimePicker dtp_dataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_incluir;
    }
}