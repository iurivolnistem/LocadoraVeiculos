namespace Projeto_Locadora
{
    partial class CadastroTipoCarro
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
            this.gbox_cadastroTipoCarro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_tipoCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_valor = new System.Windows.Forms.TextBox();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gbox_cadastroTipoCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(356, 124);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(62, 23);
            this.btn_localizar.TabIndex = 5;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(288, 124);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 124);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(62, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(152, 124);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(62, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(84, 124);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // gbox_cadastroTipoCarro
            // 
            this.gbox_cadastroTipoCarro.Controls.Add(this.label1);
            this.gbox_cadastroTipoCarro.Controls.Add(this.tbox_codigo);
            this.gbox_cadastroTipoCarro.Controls.Add(this.label2);
            this.gbox_cadastroTipoCarro.Controls.Add(this.tbox_tipoCarro);
            this.gbox_cadastroTipoCarro.Controls.Add(this.label4);
            this.gbox_cadastroTipoCarro.Controls.Add(this.tbox_valor);
            this.gbox_cadastroTipoCarro.Location = new System.Drawing.Point(12, 12);
            this.gbox_cadastroTipoCarro.Name = "gbox_cadastroTipoCarro";
            this.gbox_cadastroTipoCarro.Size = new System.Drawing.Size(411, 106);
            this.gbox_cadastroTipoCarro.TabIndex = 37;
            this.gbox_cadastroTipoCarro.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo do Carro";
            // 
            // tbox_tipoCarro
            // 
            this.tbox_tipoCarro.Location = new System.Drawing.Point(6, 71);
            this.tbox_tipoCarro.Name = "tbox_tipoCarro";
            this.tbox_tipoCarro.Size = new System.Drawing.Size(258, 20);
            this.tbox_tipoCarro.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor (R$)";
            // 
            // tbox_valor
            // 
            this.tbox_valor.Location = new System.Drawing.Point(268, 71);
            this.tbox_valor.Name = "tbox_valor";
            this.tbox_valor.Size = new System.Drawing.Size(126, 20);
            this.tbox_valor.TabIndex = 2;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(16, 124);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(62, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // CadastroTipoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(436, 163);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.gbox_cadastroTipoCarro);
            this.Controls.Add(this.btn_incluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroTipoCarro";
            this.Text = "CadastroTipoCarro";
            this.Load += new System.EventHandler(this.CadastroTipoCarro_Load);
            this.gbox_cadastroTipoCarro.ResumeLayout(false);
            this.gbox_cadastroTipoCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.GroupBox gbox_cadastroTipoCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_tipoCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_valor;
        private System.Windows.Forms.Button btn_incluir;
    }
}