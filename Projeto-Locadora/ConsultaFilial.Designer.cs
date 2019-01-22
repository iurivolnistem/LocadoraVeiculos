namespace Projeto_Locadora
{
    partial class ConsultaFilial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFilial));
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_filial = new System.Windows.Forms.TextBox();
            this.dgv_consultaFilial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaFilial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filial";
            // 
            // tbox_filial
            // 
            this.tbox_filial.Location = new System.Drawing.Point(12, 25);
            this.tbox_filial.Name = "tbox_filial";
            this.tbox_filial.Size = new System.Drawing.Size(312, 20);
            this.tbox_filial.TabIndex = 0;
            this.tbox_filial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_filial_KeyUp);
            // 
            // dgv_consultaFilial
            // 
            this.dgv_consultaFilial.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaFilial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaFilial.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaFilial.Name = "dgv_consultaFilial";
            this.dgv_consultaFilial.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaFilial.TabIndex = 1;
            this.dgv_consultaFilial.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaFilial_CellContentDoubleClick);
            // 
            // ConsultaFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_filial);
            this.Controls.Add(this.dgv_consultaFilial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Filial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaFilial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_filial;
        private System.Windows.Forms.DataGridView dgv_consultaFilial;
    }
}