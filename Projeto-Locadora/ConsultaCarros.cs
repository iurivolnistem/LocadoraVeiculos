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
    public partial class ConsultaCarros : Form
    {
        public int codigo;

        public ConsultaCarros()
        {
            InitializeComponent();
        }

        private void dgv_consultaCarro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaCarro.Rows[e.RowIndex].Cells["carro_codigo"].Value;
            this.Close();
        }

        private void tbox_nome_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_carro> lista = (new carroRepositorio()).selecionarView(tbox_nome.Text);
            dgv_consultaCarro.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaCarro.Columns["carro_nome"].Width = 300;
                dgv_consultaCarro.Columns["carro_codigo"].HeaderText = "Código";
                dgv_consultaCarro.Columns["carro_nome"].HeaderText = "Nome";
                dgv_consultaCarro.Columns["carro_marca"].HeaderText = "Marca";
                dgv_consultaCarro.Columns["carro_modelo"].HeaderText = "Modelo";
                dgv_consultaCarro.Columns["carro_ano"].HeaderText = "Ano";
                dgv_consultaCarro.Columns["carro_placa"].HeaderText = "Placa";
                dgv_consultaCarro.Columns["carro_km"].HeaderText = "Km";
                dgv_consultaCarro.Columns["carro_cor"].HeaderText = "Cor";
                dgv_consultaCarro.Columns["carro_valorDiaria"].HeaderText = "Valor Diária";
                dgv_consultaCarro.Columns["tipocarro_tipo"].HeaderText = "Categoria";
                dgv_consultaCarro.Columns["status_nome"].HeaderText = "Status";
            }
        }
    }
}
