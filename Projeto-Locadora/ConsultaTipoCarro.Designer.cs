namespace Projeto_Locadora
{
    partial class ConsultaTipoCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTipoCarro));
            this.tbox_tipoCarro = new System.Windows.Forms.TextBox();
            this.dgv_consultaTipoCarro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaTipoCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_tipoCarro
            // 
            this.tbox_tipoCarro.Location = new System.Drawing.Point(12, 25);
            this.tbox_tipoCarro.Name = "tbox_tipoCarro";
            this.tbox_tipoCarro.Size = new System.Drawing.Size(312, 20);
            this.tbox_tipoCarro.TabIndex = 0;
            this.tbox_tipoCarro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_tipoCarro_KeyUp);
            // 
            // dgv_consultaTipoCarro
            // 
            this.dgv_consultaTipoCarro.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaTipoCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaTipoCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaTipoCarro.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaTipoCarro.Name = "dgv_consultaTipoCarro";
            this.dgv_consultaTipoCarro.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaTipoCarro.TabIndex = 1;
            this.dgv_consultaTipoCarro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaTipoCarro_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo do Carro";
            // 
            // ConsultaTipoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_tipoCarro);
            this.Controls.Add(this.dgv_consultaTipoCarro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTipoCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Tipo do Carro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaTipoCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_tipoCarro;
        private System.Windows.Forms.DataGridView dgv_consultaTipoCarro;
        private System.Windows.Forms.Label label1;
    }
}