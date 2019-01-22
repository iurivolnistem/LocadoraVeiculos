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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
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
            tbox_nome.Text = "";
            tbox_cpf.Text = "";
            tbox_rg.Text = "";
            tbox_cnh.Text = "";
            tbox_celular.Text = "";
            tbox_endereco.Text = "";
            tbox_telefoneFixo.Text = "";
            dtp_dataNascimento.Value = DateTime.Now;
            cbox_cidade.SelectedIndex = -1;
            gbox_cadastroFuncionario.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastroFuncionario.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastroFuncionario.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastroFuncionario.Enabled = true;
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
                    funcionario fun = (new funcionarioRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new funcionarioRepositorio()).excluir(fun);

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
                if (tbox_nome.Text != "" && tbox_cpf.Text != "" && tbox_endereco.Text != "" && tbox_rg.Text != "" && cbox_cidade.Text != "")
                {
                    funcionario fun = new funcionario()
                    {
                        funcionario_nome = tbox_nome.Text,
                        funcionario_cnh = tbox_cnh.Text,
                        funcionario_cpf = tbox_cpf.Text,
                        funcionario_dataNascimento = dtp_dataNascimento.Value,
                        funcionario_endereco = tbox_endereco.Text,
                        funcionario_telefoneCelular = tbox_celular.Text,
                        funcionario_rg = tbox_rg.Text,
                        funcionario_telefoneFixo = tbox_telefoneFixo.Text,
                        cidade_codigo = (int)cbox_cidade.SelectedValue
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new funcionarioRepositorio()).inserir(fun);
                    }
                    else
                    {
                        //alterar
                        fun.funcionario_codigo = int.Parse(tbox_codigo.Text);
                        (new funcionarioRepositorio()).alterar(fun);
                    }


                    MessageBox.Show("Dados salvos! Código: " + fun.funcionario_codigo);
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
                ConsultaFuncionarios frm = new ConsultaFuncionarios();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    funcionario fun = (new funcionarioRepositorio()).selecionar(codigo);
                    if (fun != null)
                    {
                        tbox_codigo.Text = fun.funcionario_codigo.ToString();
                        tbox_cpf.Text = fun.funcionario_cpf.ToString();
                        tbox_celular.Text = fun.funcionario_telefoneCelular.ToString();
                        tbox_endereco.Text = fun.funcionario_endereco.ToString();
                        tbox_nome.Text = fun.funcionario_nome.ToString();
                        cbox_cidade.SelectedValue = fun.cidade_codigo;
                        tbox_cnh.Text = fun.funcionario_cnh.ToString();
                        tbox_rg.Text = fun.funcionario_rg.ToString();
                        tbox_telefoneFixo.Text = fun.funcionario_telefoneFixo.ToString();
                        dtp_dataNascimento.Value = fun.funcionario_dataNascimento;
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
