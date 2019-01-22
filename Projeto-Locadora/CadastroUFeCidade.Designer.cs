namespace Projeto_Locadora
{
    partial class CadastroUFeCidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_cidade = new System.Windows.Forms.TextBox();
            this.gbox_cadastroUFeCidade = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_uf = new System.Windows.Forms.TextBox();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gbox_cadastroUFeCidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(6, 35);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.ReadOnly = true;
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidade";
            // 
            // tbox_cidade
            // 
            this.tbox_cidade.Location = new System.Drawing.Point(6, 74);
            this.tbox_cidade.Name = "tbox_cidade";
            this.tbox_cidade.Size = new System.Drawing.Size(388, 20);
            this.tbox_cidade.TabIndex = 1;
            // 
            // gbox_cadastroUFeCidade
            // 
            this.gbox_cadastroUFeCidade.Controls.Add(this.label3);
            this.gbox_cadastroUFeCidade.Controls.Add(this.tbox_uf);
            this.gbox_cadastroUFeCidade.Controls.Add(this.tbox_cidade);
            this.gbox_cadastroUFeCidade.Controls.Add(this.label1);
            this.gbox_cadastroUFeCidade.Controls.Add(this.label2);
            this.gbox_cadastroUFeCidade.Controls.Add(this.tbox_codigo);
            this.gbox_cadastroUFeCidade.Location = new System.Drawing.Point(12, 12);
            this.gbox_cadastroUFeCidade.Name = "gbox_cadastroUFeCidade";
            this.gbox_cadastroUFeCidade.Size = new System.Drawing.Size(408, 145);
            this.gbox_cadastroUFeCidade.TabIndex = 8;
            this.gbox_cadastroUFeCidade.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UF";
            // 
            // tbox_uf
            // 
            this.tbox_uf.Location = new System.Drawing.Point(6, 113);
            this.tbox_uf.Name = "tbox_uf";
            this.tbox_uf.Size = new System.Drawing.Size(100, 20);
            this.tbox_uf.TabIndex = 2;
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(356, 163);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(62, 23);
            this.btn_localizar.TabIndex = 5;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(288, 163);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(220, 163);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(62, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(152, 163);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(62, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(84, 163);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(16, 163);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(62, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // CadastroUFeCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(438, 199);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.gbox_cadastroUFeCidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroUFeCidade";
            this.Text = "CadastroUFeCidade";
            this.Load += new System.EventHandler(this.CadastroUFeCidade_Load);
            this.gbox_cadastroUFeCidade.ResumeLayout(false);
            this.gbox_cadastroUFeCidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_cidade;
        private System.Windows.Forms.GroupBox gbox_cadastroUFeCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_uf;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
    }
}