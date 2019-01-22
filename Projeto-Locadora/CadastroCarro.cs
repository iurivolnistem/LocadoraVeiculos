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
    public partial class CadastroCarro : Form
    {
        public CadastroCarro()
        {
            InitializeComponent();
        }

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            cbox_categoria.DataSource = (new tipocarroRepositorio()).selecionar("");
            cbox_categoria.ValueMember = "tipocarro_codigo";
            cbox_categoria.DisplayMember = "tipocarro_tipo";
            cbox_categoria.SelectedIndex = -1;

            cbox_status.DataSource = (new statusRepositorio()).selecionar("");
            cbox_status.ValueMember = "status_codigo";
            cbox_status.DisplayMember = "status_nome";
            cbox_status.SelectedIndex = -1;

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
            tbox_ano.Text = "";
            tbox_cor.Text = "";
            tbox_km.Text = "";
            tbox_marca.Text = "";
            tbox_modelo.Text = "";
            tbox_placa.Text = "";
            tbox_valorDiaria.Text = "";
            cbox_categoria.SelectedIndex = -1;
            cbox_status.SelectedIndex = -1;
            gbox_cadastrocarro.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastrocarro.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastrocarro.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastrocarro.Enabled = true;
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
                    carro car = (new carroRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new carroRepositorio()).excluir(car);

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
                if (tbox_nome.Text != "" && tbox_ano.Text != "" && tbox_cor.Text != "" && tbox_km.Text != "" && tbox_marca.Text != "" && tbox_modelo.Text != "" && tbox_placa.Text != "" && tbox_valorDiaria.Text != "" && cbox_categoria.Text != "" && cbox_status.Text != "")
                {
                    carro car = new carro()
                    {
                        carro_nome = tbox_nome.Text,
                        carro_ano = tbox_ano.Text,
                        carro_cor = tbox_cor.Text,
                        carro_km = (int.Parse(tbox_km.Text)),
                        carro_marca = tbox_marca.Text,
                        carro_modelo = tbox_modelo.Text,
                        carro_placa = tbox_placa.Text,
                        carro_valorDiaria = (decimal.Parse(tbox_valorDiaria.Text)),
                        tipocarro_codigo = (int)cbox_categoria.SelectedValue,
                        status_codigo = (int)cbox_status.SelectedValue
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new carroRepositorio()).inserir(car);
                    }
                    else
                    {
                        //alterar
                        car.carro_codigo = int.Parse(tbox_codigo.Text);
                        (new carroRepositorio()).alterar(car);
                    }


                    MessageBox.Show("Dados salvos! Código: " + car.carro_codigo);
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
                ConsultaCarros frm = new ConsultaCarros();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    carro car = (new carroRepositorio()).selecionar(codigo);
                    if (car != null)
                    {
                        tbox_codigo.Text = car.carro_codigo.ToString();
                        tbox_ano.Text = car.carro_ano.ToString();
                        tbox_cor.Text = car.carro_cor.ToString();
                        tbox_km.Text = car.carro_km.ToString();
                        tbox_nome.Text = car.carro_nome.ToString();
                        cbox_categoria.SelectedValue = car.tipocarro_codigo;
                        cbox_status.SelectedValue = car.status_codigo;
                        tbox_marca.Text = car.carro_marca.ToString();
                        tbox_modelo.Text = car.carro_modelo.ToString();
                        tbox_placa.Text = car.carro_placa.ToString();
                        tbox_valorDiaria.Text = car.carro_valorDiaria.ToString();
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
