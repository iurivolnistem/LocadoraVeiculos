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
    public partial class CadastroStatus : Form
    {
        public CadastroStatus()
        {
            InitializeComponent();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastrostatus.Enabled = true;
            habilitarBotoes(false);
        }

        private void CadastroStatus_Load(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
        }

        public void habilitarBotoes(bool status)
        {
            btn_incluir.Enabled = status;
            btn_alterar.Enabled = status;
            btn_salvar.Enabled = !status;
            btn_cancelar.Enabled = !status;
            btn_excluir.Enabled = status;
            btn_localizar.Enabled = status;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbox_codigo.Text = "";
            tbox_status.Text = "";
            gbox_cadastrostatus.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastrostatus.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastrostatus.Enabled = true;
                    habilitarBotoes(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir! " + ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text != "")
                {
                    status sta = (new statusRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new statusRepositorio()).excluir(sta);

                    btn_cancelar_Click(sender, e);
                    MessageBox.Show("Dados excluidos!");
                }
                else
                {
                    MessageBox.Show("Informar o código!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir! " + ex.Message);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_status.Text != "")
                {
                    status sta = new status()
                    {
                        status_nome = tbox_status.Text,
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new statusRepositorio()).inserir(sta);
                    }
                    else
                    {
                        //alterar
                        sta.status_codigo = int.Parse(tbox_codigo.Text);
                        (new statusRepositorio()).alterar(sta);
                    }


                    MessageBox.Show("Dados salvos! Código: " + sta.status_codigo);
                    btn_cancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Informar o nome!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar! " + ex.Message);
            }
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaStatus frm = new ConsultaStatus();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    status sta = (new statusRepositorio()).selecionar(codigo);
                    if (sta != null)
                    {
                        tbox_codigo.Text = sta.status_codigo.ToString();
                        tbox_status.Text = sta.status_nome.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Dados não localizados!");
                        btn_cancelar_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar! " + ex.Message);
            }
        }
    }
}
