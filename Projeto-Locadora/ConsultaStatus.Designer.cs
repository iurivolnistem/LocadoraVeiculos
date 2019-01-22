namespace Projeto_Locadora
{
    partial class ConsultaStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_consultaStatus = new System.Windows.Forms.DataGridView();
            this.tbox_status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // dgv_consultaStatus
            // 
            this.dgv_consultaStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaStatus.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaStatus.Name = "dgv_consultaStatus";
            this.dgv_consultaStatus.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaStatus.TabIndex = 1;
            this.dgv_consultaStatus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaCliente_CellContentDoubleClick);
            // 
            // tbox_status
            // 
            this.tbox_status.Location = new System.Drawing.Point(12, 25);
            this.tbox_status.Name = "tbox_status";
            this.tbox_status.Size = new System.Drawing.Size(312, 20);
            this.tbox_status.TabIndex = 0;
            this.tbox_status.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_nome_KeyUp);
            // 
            // ConsultaStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_status);
            this.Controls.Add(this.dgv_consultaStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_consultaStatus;
        private System.Windows.Forms.TextBox tbox_status;
    }
}