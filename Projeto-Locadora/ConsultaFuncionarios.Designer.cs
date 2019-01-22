namespace Projeto_Locadora
{
    partial class ConsultaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFuncionarios));
            this.dgv_consultaFuncionarios = new System.Windows.Forms.DataGridView();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_consultaFuncionarios
            // 
            this.dgv_consultaFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaFuncionarios.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaFuncionarios.Name = "dgv_consultaFuncionarios";
            this.dgv_consultaFuncionarios.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaFuncionarios.TabIndex = 1;
            this.dgv_consultaFuncionarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaFuncionarios_CellContentDoubleClick);
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(12, 25);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(312, 20);
            this.tbox_nome.TabIndex = 0;
            this.tbox_nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_nome_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // ConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.dgv_consultaFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultaFuncionarios;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.Label label1;
    }
}