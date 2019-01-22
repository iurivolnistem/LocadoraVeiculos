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
    public partial class ConsultaTipoCarro : Form
    {
        public int codigo;

        public ConsultaTipoCarro()
        {
            InitializeComponent();
        }

        private void dgv_consultaTipoCarro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaTipoCarro.Rows[e.RowIndex].Cells["tipocarro_codigo"].Value;
            this.Close();
        }

        private void tbox_tipoCarro_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_tipocarro> lista = (new tipocarroRepositorio()).selecionarView(tbox_tipoCarro.Text);
            dgv_consultaTipoCarro.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaTipoCarro.Columns["tipocarro_tipo"].Width = 300;
                dgv_consultaTipoCarro.Columns["tipocarro_codigo"].HeaderText = "Código";
                dgv_consultaTipoCarro.Columns["tipocarro_tipo"].HeaderText = "Tipo";
                dgv_consultaTipoCarro.Columns["tipocarro_valor"].HeaderText = "Valor";
            }
        }
    }
}
