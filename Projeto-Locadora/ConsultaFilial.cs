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
    public partial class ConsultaFilial : Form
    {
        public int codigo;

        public ConsultaFilial()
        {
            InitializeComponent();
        }

        private void dgv_consultaFilial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaFilial.Rows[e.RowIndex].Cells["filial_codigo"].Value;
            this.Close();
        }

        private void tbox_filial_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_filial> lista = (new filialRepositorio()).selecionarView(tbox_filial.Text);
            dgv_consultaFilial.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaFilial.Columns["filial_nome"].Width = 300;
                dgv_consultaFilial.Columns["filial_codigo"].HeaderText = "Código";
                dgv_consultaFilial.Columns["filial_nome"].HeaderText = "Filial";
                dgv_consultaFilial.Columns["cidade_nome"].HeaderText = "Cidade";
            }
        }
    }
}
