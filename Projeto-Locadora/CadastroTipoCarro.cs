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
    public partial class CadastroTipoCarro : Form
    {
        public CadastroTipoCarro()
        {
            InitializeComponent();
        }

        private void CadastroTipoCarro_Load(object sender, EventArgs e)
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
            tbox_tipoCarro.Text = "";
            tbox_valor.Text = "";
            gbox_cadastroTipoCarro.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastroTipoCarro.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastroTipoCarro.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastroTipoCarro.Enabled = true;
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
                    tipocarro tpcar = (new tipocarroRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new tipocarroRepositorio()).excluir(tpcar);

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
                if (tbox_tipoCarro.Text != "" && tbox_valor.Text != "")
                {
                    tipocarro tpcar = new tipocarro()
                    {
                        tipocarro_tipo = tbox_tipoCarro.Text,
                        tipocarro_valor = (decimal.Parse(tbox_valor.Text))
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new tipocarroRepositorio()).inserir(tpcar);
                    }
                    else
                    {
                        //alterar
                        tpcar.tipocarro_codigo = int.Parse(tbox_codigo.Text);
                        (new tipocarroRepositorio()).alterar(tpcar);
                    }


                    MessageBox.Show("Dados salvos! Código: " + tpcar.tipocarro_codigo);
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
                ConsultaTipoCarro frm = new ConsultaTipoCarro();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    tipocarro tpcar = (new tipocarroRepositorio()).selecionar(codigo);
                    if (tpcar != null)
                    {
                        tbox_codigo.Text = tpcar.tipocarro_codigo.ToString();
                        tbox_tipoCarro.Text = tpcar.tipocarro_tipo.ToString();
                        tbox_valor.Text = tpcar.tipocarro_valor.ToString();
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
