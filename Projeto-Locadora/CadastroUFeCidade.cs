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
    public partial class CadastroUFeCidade : Form
    {
        public CadastroUFeCidade()
        {
            InitializeComponent();
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbox_cidade.Text != "" && tbox_uf.Text != "")
                {
                    cidade cid = new cidade()
                    {
                        cidade_nome = tbox_cidade.Text,
                        cidade_uf = tbox_uf.Text
                    };
                    //salva elemento que está sendo inserido
                    if(tbox_codigo.Text == "")
                    {
                        (new cidadeRepositorio()).inserir(cid);
                    }
                    else
                    {
                        //salva a alteração
                        cid.cidade_codigo = int.Parse(tbox_codigo.Text);
                        (new cidadeRepositorio()).alterar(cid);
                    }
                    MessageBox.Show("Dados salvos! Código: " + cid.cidade_codigo);
                    btn_cancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Informar todos os dados!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar! " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbox_codigo.Text = "";
            tbox_cidade.Text = "";
            tbox_uf.Text = "";
            gbox_cadastroUFeCidade.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastroUFeCidade.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastroUFeCidade.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastroUFeCidade.Enabled = true;
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
                if(tbox_codigo.Text != "")
                {
                    cidade cid = (new cidadeRepositorio()).selecionar(int.Parse(tbox_codigo.Text));
                    (new cidadeRepositorio()).excluir(cid);
                    btn_cancelar_Click(sender, e);
                    MessageBox.Show("Dados excluídos!");
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

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaUFeCidade frm = new ConsultaUFeCidade();
                frm.ShowDialog();
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    cidade cid = (new cidadeRepositorio()).selecionar(codigo);
                    if(cid != null)
                    {
                        tbox_codigo.Text = cid.cidade_codigo.ToString();
                        tbox_cidade.Text = cid.cidade_nome.ToString();
                        tbox_uf.Text = cid.cidade_uf.ToString();
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

        private void CadastroUFeCidade_Load(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
        }
    }
}
