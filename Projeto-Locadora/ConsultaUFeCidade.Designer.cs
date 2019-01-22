namespace Projeto_Locadora
{
    partial class ConsultaUFeCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUFeCidade));
            this.dgv_consultaCidade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_cidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_consultaCidade
            // 
            this.dgv_consultaCidade.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaCidade.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaCidade.Name = "dgv_consultaCidade";
            this.dgv_consultaCidade.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaCidade.TabIndex = 1;
            this.dgv_consultaCidade.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_consultaCidade_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cidade";
            // 
            // tbox_cidade
            // 
            this.tbox_cidade.Location = new System.Drawing.Point(12, 25);
            this.tbox_cidade.Name = "tbox_cidade";
            this.tbox_cidade.Size = new System.Drawing.Size(312, 20);
            this.tbox_cidade.TabIndex = 0;
            this.tbox_cidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_cidade_KeyUp);
            // 
            // ConsultaUFeCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.tbox_cidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_consultaCidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaUFeCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Cidade e UF";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultaCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_cidade;
    }
}