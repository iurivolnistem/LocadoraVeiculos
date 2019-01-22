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
    public partial class ConsultaUFeCidade : Form
    {
        public int codigo;


        public ConsultaUFeCidade()
        {
            InitializeComponent();
        }

        private void dgv_consultaCidade_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigo = (int)dgv_consultaCidade.Rows[e.RowIndex].Cells["cidade_codigo"].Value;
            this.Close();
        }

        private void tbox_cidade_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_cidades> lista = (new cidadeRepositorio()).selecionarView(tbox_cidade.Text);
            dgv_consultaCidade.DataSource = lista;
            if(lista.Count > 0)
            {
                dgv_consultaCidade.Columns["cidade_nome"].Width = 300;
                dgv_consultaCidade.Columns["cidade_codigo"].HeaderText = "Código";
                dgv_consultaCidade.Columns["cidade_nome"].HeaderText = "Cidade";
                dgv_consultaCidade.Columns["cidade_uf"].HeaderText = "UF";
            }
        }
    }
}
