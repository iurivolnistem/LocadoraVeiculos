namespace Projeto_Locadora
{
    partial class ConsultaLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaLocacao));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_consultaLocacao = new System.Windows.Forms.DataGridView();
            this.dtp_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Início";
            // 
            // dgv_consultaLocacao
            // 
            this.dgv_consultaLocacao.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consultaLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_consultaLocacao.Location = new System.Drawing.Point(12, 51);
            this.dgv_consultaLocacao.Name = "dgv_consultaLocacao";
            this.dgv_consultaLocacao.Size = new System.Drawing.Size(405, 218);
            this.dgv_consultaLocacao.TabIndex = 2;
            this.dgv_consultaLocacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultaLocacao_CellDoubleClick);
            // 
            // dtp_dataInicio
            // 
            this.dtp_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataInicio.Location = new System.Drawing.Point(12, 25);
            this.dtp_dataInicio.Name = "dtp_dataInicio";
            this.dtp_dataInicio.Size = new System.Drawing.Size(104, 20);
            this.dtp_dataInicio.TabIndex = 0;
            this.dtp_dataInicio.ValueChanged += new System.EventHandler(this.dtp_dataInicio_ValueChanged);
            // 
            // dtp_dataFim
            // 
            this.dtp_dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataFim.Location = new System.Drawing.Point(122, 25);
            this.dtp_dataFim.Name = "dtp_dataFim";
            this.dtp_dataFim.Size = new System.Drawing.Size(104, 20);
            this.dtp_dataFim.TabIndex = 1;
            this.dtp_dataFim.ValueChanged += new System.EventHandler(this.dtp_dataFim_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Fim";
            // 
            // ConsultaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.dtp_dataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_dataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_consultaLocacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Locação";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_consultaLocacao;
        private System.Windows.Forms.DateTimePicker dtp_dataInicio;
        private System.Windows.Forms.DateTimePicker dtp_dataFim;
        private System.Windows.Forms.Label label2;
    }
}