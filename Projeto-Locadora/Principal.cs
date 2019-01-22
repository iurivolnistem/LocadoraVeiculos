using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Locadora.Relatorios;

namespace Projeto_Locadora
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroFuncionario frm = new CadastroFuncionario();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroCliente frm = new CadastroCliente();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroCarro frm = new CadastroCarro();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void tipoDoCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroTipoCarro frm = new CadastroTipoCarro();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void cidadeEUFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroUFeCidade frm = new CadastroUFeCidade();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void filialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroFilial frm = new CadastroFilial();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void statusDoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroStatus frm = new CadastroStatus();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picture_filial_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroFilial frm = new CadastroFilial();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void picture_funcionario_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroFuncionario frm = new CadastroFuncionario();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void picture_cliente_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroCliente frm = new CadastroCliente();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void picture_carro_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroCarro frm = new CadastroCarro();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void picture_home_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
        }

        private void picture_locacao_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroLocacao frm = new CadastroLocacao();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void locaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroLocacao frm = new CadastroLocacao();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroDevolucao frm = new CadastroDevolucao();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void picture_devolução_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            CadastroDevolucao frm = new CadastroDevolucao();
            frm.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(frm);
            frm.Show();
            frm = null;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            Relatorio rel = new Relatorio();
            RPT_clientes rpt = new RPT_clientes();
            rel.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(rel);
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.crystalReportViewer1.Refresh();
            rel.Show();
            rel = null;
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            Relatorio rel = new Relatorio();
            RPT_carros rpt = new RPT_carros();
            rel.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(rel);
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.crystalReportViewer1.Refresh();
            rel.Show();
            rel = null;
        }

        private void locaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelJanelas.Panel2.Controls.Clear();
            PainelJanelas.Panel2.Controls.Add(gbox_gerarRelatorio);
            gbox_gerarRelatorio.Visible = true;
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            RPT_locacoes rpt = new RPT_locacoes();
            rpt.SetParameterValue(0, dtp_inicio.Value.Date);
            rpt.SetParameterValue(1, dtp_fim.Value.Date);
            rel.TopLevel = false;
            PainelJanelas.Panel2.Controls.Add(rel);
            rel.crystalReportViewer1.ReportSource = rpt;
            rel.crystalReportViewer1.Refresh();
            rel.Show();
            rel = null;
            gbox_gerarRelatorio.Visible = false;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            gbox_gerarRelatorio.Visible = false;
        }
    }
}
