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
    public partial class ConsultaDevolucao : Form
    {
        public int codigo;

        public ConsultaDevolucao()
        {
            InitializeComponent();
        }

        private void dtp_dataInicio_ValueChanged(object sender, EventArgs e)
        {
            buscaPeriodo();
        }

        private void dtp_dataFim_ValueChanged(object sender, EventArgs e)
        {
            buscaPeriodo();
        }

        private void dgv_consultaDevolucao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaDevolucao.Rows[e.RowIndex].Cells["devolucao_codigo"].Value;
            this.Close();
        }

        private void buscaPeriodo()
        {
            List<vw_devolucoes> lista = (new devolucaoRepositorio()).selecionarView(dtp_dataInicio.Value, dtp_dataFim.Value);
            dgv_consultaDevolucao.DataSource = lista;
            if (lista.Count > 0)
            {
                dgv_consultaDevolucao.Columns["devolucao_codigo"].HeaderText = "Código";
                dgv_consultaDevolucao.Columns["devolucao_dataEfetiva"].HeaderText = "Data Dev. Efetiva";
                dgv_consultaDevolucao.Columns["locacao_codigo"].HeaderText = "Cód. Locação";
                dgv_consultaDevolucao.Columns["locacao_dataDevolucaoPrevista"].HeaderText = "Data Dev. Prevista";
                dgv_consultaDevolucao.Columns["cliente_codigo"].HeaderText = "Cód. Cliente";
                dgv_consultaDevolucao.Columns["cliente_nome"].HeaderText = "Cliente";
                dgv_consultaDevolucao.Columns["carro_codigo"].HeaderText = "Cód. Carro";
                dgv_consultaDevolucao.Columns["carro_nome"].HeaderText = "Carro";
                dgv_consultaDevolucao.Columns["devolucao_km"].HeaderText = "KM";
                dgv_consultaDevolucao.Columns["devolucao_multa"].HeaderText = "Multa";
                dgv_consultaDevolucao.Columns["devolucao_diferencaDias"].HeaderText = "Diferença Dias";
                dgv_consultaDevolucao.Columns["status_codigo"].HeaderText = "Cód. Status";
            }
        }
    }
}
