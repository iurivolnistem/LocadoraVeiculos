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
    public partial class CadastroFilial : Form
    {
        public CadastroFilial()
        {
            InitializeComponent();
        }

        private void CadastroFilial_Load(object sender, EventArgs e)
        {
            cbox_cidade.DataSource = (new cidadeRepositorio()).selecionar("");
            cbox_cidade.ValueMember = "cidade_codigo";
            cbox_cidade.DisplayMember = "cidade_nome";
            cbox_cidade.SelectedIndex = -1;

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
            tbox_filial.Text = "";
            cbox_cidade.SelectedIndex = -1;
            gbox_cadastrofilial.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastrofilial.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastrofilial.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastrofilial.Enabled = true;
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
                    filial fil = (new filialRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new filialRepositorio()).excluir(fil);

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
                if (tbox_filial.Text != "" && cbox_cidade.Text != "")
                {
                    filial fil = new filial()
                    {
                        filial_nome = tbox_filial.Text,
                        cidade_codigo = (int)cbox_cidade.SelectedValue
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new filialRepositorio()).inserir(fil);
                    }
                    else
                    {
                        //alterar
                        fil.filial_codigo = int.Parse(tbox_codigo.Text);
                        (new filialRepositorio()).alterar(fil);
                    }


                    MessageBox.Show("Dados salvos! Código: " + fil.filial_codigo);
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
                ConsultaFilial frm = new ConsultaFilial();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    filial fil = (new filialRepositorio()).selecionar(codigo);
                    if (fil != null)
                    {
                        tbox_codigo.Text = fil.filial_codigo.ToString();
                        tbox_filial.Text = fil.filial_nome.ToString();
                        cbox_cidade.SelectedValue = fil.cidade_codigo;
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
