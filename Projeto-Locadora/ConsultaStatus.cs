using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace Projeto_Locadora
{
    public partial class ConsultaStatus : Form
    {
        public int codigo;

        public ConsultaStatus()
        {
            InitializeComponent();
        }

        private void dgv_consultaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaStatus.Rows[e.RowIndex].Cells["status_codigo"].Value;
            this.Close();
        }

        private void tbox_nome_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_status> lista = (new statusRepositorio()).selecionarView(tbox_status.Text);
            dgv_consultaStatus.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaStatus.Columns["status_nome"].Width = 300;
                dgv_consultaStatus.Columns["status_codigo"].HeaderText = "Código";
                dgv_consultaStatus.Columns["status_nome"].HeaderText = "Status";;
            }
        }
    }
}
