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
    public partial class ConsultaLocacao : Form
    {
        public int codigo;

        public ConsultaLocacao()
        {
            InitializeComponent();
        }

        private void dgv_consultaLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int)dgv_consultaLocacao.Rows[e.RowIndex].Cells["locacao_codigo"].Value;
            this.Close();
        }

        private void dtp_dataFim_ValueChanged(object sender, EventArgs e)
        {
            buscaPeriodo();
        }

        private void buscaPeriodo()
        {
            List<vw_locacoes> lista = (new locacaoRepositorio()).selecionarView(dtp_dataInicio.Value, dtp_dataFim.Value);
            dgv_consultaLocacao.DataSource = lista;
            if (lista.Count > 0)
            {
                dgv_consultaLocacao.Columns["locacao_codigo"].HeaderText = "Código";
                dgv_consultaLocacao.Columns["locacao_dataLocacao"].HeaderText = "Data Locação";
                dgv_consultaLocacao.Columns["locacao_dataDevolucaoPrevista"].HeaderText = "Previs Devolução";
                dgv_consultaLocacao.Columns["locacao_qtdeDias"].HeaderText = "Qtde Dias";
                dgv_consultaLocacao.Columns["locacao_totalLocacao"].HeaderText = "Total";
                dgv_consultaLocacao.Columns["status_codigo"].HeaderText = "Status";
                dgv_consultaLocacao.Columns["funcionario_codigo"].HeaderText = "Cód. Funcionário";
                dgv_consultaLocacao.Columns["funcionario_nome"].HeaderText = "Funcionário";
                dgv_consultaLocacao.Columns["cliente_codigo"].HeaderText = "Cód. Cliente";
                dgv_consultaLocacao.Columns["cliente_nome"].HeaderText = "Cliente";
                dgv_consultaLocacao.Columns["carro_codigo"].HeaderText = "Cód. Carro";
                dgv_consultaLocacao.Columns["carro_nome"].HeaderText = "Carro";
            }
        }

        private void dtp_dataInicio_ValueChanged(object sender, EventArgs e)
        {
            buscaPeriodo();
        }
    }
}
