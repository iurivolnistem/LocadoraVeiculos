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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
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
            gbox_cadastrocliente.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastrocliente.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastrocliente.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastrocliente.Enabled = true;
                    habilitarBotoes(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar! " + ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text != "")
                {
                    cliente cli = (new clienteRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new clienteRepositorio()).excluir(cli);

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
                    cliente cli = new cliente()
                    {
                        cliente_nome = tbox_nome.Text,
                        cliente_cnh = tbox_cnh.Text,
                        cliente_cpf = tbox_cpf.Text,
                        cliente_dataNascimento = dtp_dataNascimento.Value,
                        cliente_endereco = tbox_endereco.Text,
                        cliente_telefoneCelular = tbox_celular.Text,
                        cliente_rg = tbox_rg.Text,
                        cliente_telefoneFixo = tbox_telefoneFixo.Text,
                        cidade_codigo = (int)cbox_cidade.SelectedValue
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new clienteRepositorio()).inserir(cli);
                    }
                    else
                    {
                        //alterar
                        cli.cliente_codigo = int.Parse(tbox_codigo.Text);
                        (new clienteRepositorio()).alterar(cli);
                    }


                    MessageBox.Show("Dados salvos! Código: " + cli.cliente_codigo);
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
                ConsultaClientes frm = new ConsultaClientes();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    cliente cli = (new clienteRepositorio()).selecionar(codigo);
                    if (cli != null)
                    {
                        tbox_codigo.Text = cli.cliente_codigo.ToString();
                        tbox_cpf.Text = cli.cliente_cpf.ToString();
                        tbox_celular.Text = cli.cliente_telefoneCelular.ToString();
                        tbox_endereco.Text = cli.cliente_endereco.ToString();
                        tbox_nome.Text = cli.cliente_nome.ToString();
                        cbox_cidade.SelectedValue = cli.cidade_codigo;
                        tbox_cnh.Text = cli.cliente_cnh.ToString();
                        tbox_rg.Text = cli.cliente_rg.ToString();
                        tbox_telefoneFixo.Text = cli.cliente_telefoneFixo.ToString();
                        dtp_dataNascimento.Value = cli.cliente_dataNascimento;
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
