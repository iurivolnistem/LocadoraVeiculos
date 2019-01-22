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
    public partial class CadastroDevolucao : Form
    {
        public CadastroDevolucao()
        {
            InitializeComponent();
        }

        private void CadastroDevolucao_Load(object sender, EventArgs e)
        {
            //local, pagto, status
            cbox_localDevolucao.DataSource = (new filialRepositorio()).selecionar("");
            cbox_localDevolucao.ValueMember = "filial_codigo";
            cbox_localDevolucao.DisplayMember = "filial_nome";
            cbox_localDevolucao.SelectedIndex = -1;

            cbox_tipoPagamento.DataSource = (new tipopagamentoRepositorio()).selecionar("");
            cbox_tipoPagamento.ValueMember = "tipopagamento_codigo";
            cbox_tipoPagamento.DisplayMember = "tipopagamento_nome";
            cbox_tipoPagamento.SelectedIndex = -1;

            cbox_statusDevolucao.DataSource = (new statusRepositorio()).selecionar("");
            cbox_statusDevolucao.ValueMember = "status_codigo";
            cbox_statusDevolucao.DisplayMember = "status_nome";
            cbox_statusDevolucao.SelectedIndex = -1;

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
            tbox_codLoc.Text = "";
            dtp_devolucaoEfetiva.Value = DateTime.Now;
            dtp_previsaoDevolucao.Value = DateTime.Now;
            tbox_diferencaDias.Text = "";
            tbox_kmDevolucao.Text = "";
            tbox_cliente.Text = "";
            tbox_carro.Text = "";
            cbox_localDevolucao.SelectedIndex = -1;
            tbox_multaDevolucao.Text = "";
            cbox_tipoPagamento.SelectedIndex = -1;
            cbox_statusDevolucao.SelectedIndex = -1;
            gbox_cadastroDevolucao.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastroDevolucao.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastroDevolucao.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastroDevolucao.Enabled = true;
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
                    devolucao dev = (new devolucaoRepositorio()).selecionar(int.Parse(tbox_codigo.Text));

                    (new devolucaoRepositorio()).excluir(dev);

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
                if (tbox_codLoc.Text != "" && tbox_cliente.Text != "" && tbox_carro.Text != "" && tbox_kmDevolucao.Text != "" && tbox_diferencaDias.Text != "" && cbox_localDevolucao.Text != "" && cbox_statusDevolucao.Text != "" && cbox_tipoPagamento.Text != "")
                {
                    devolucao dev = new devolucao()
                    {
                        devolucao_dataEfetiva = dtp_devolucaoEfetiva.Value,
                        filial_codigo = (int)cbox_localDevolucao.SelectedValue,
                        devolucao_km = (int.Parse(tbox_kmDevolucao.Text)),
                        devolucao_multa = (decimal.Parse(tbox_multaDevolucao.Text)),
                        tipopagamento_codigo = (int)cbox_tipoPagamento.SelectedValue,
                        locacao_codigo = (int.Parse(tbox_codLoc.Text)),
                        status_codigo = (int)cbox_statusDevolucao.SelectedValue,
                        devolucao_diferencaDias = (int.Parse(tbox_diferencaDias.Text))
                    };

                    if (tbox_codigo.Text == "")
                    {
                        (new devolucaoRepositorio()).inserir(dev);
                    }
                    else
                    {
                        //alterar
                        dev.devolucao_codigo = int.Parse(tbox_codigo.Text);
                        (new devolucaoRepositorio()).alterar(dev);
                    }


                    MessageBox.Show("Dados salvos! Código: " + dev.devolucao_codigo);
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
                ConsultaDevolucao frm = new ConsultaDevolucao();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    devolucao dev = (new devolucaoRepositorio()).selecionar(codigo);
                    if (dev != null)
                    {
                        tbox_codigo.Text = dev.devolucao_codigo.ToString();
                        tbox_codLoc.Text = dev.locacao_codigo.ToString();
                        //trazer o cliente correspondente ao código da locação
                        //trazer o carro correspondente ao código da locação
                        //trazer a data de devolução prevista correspondente ao código da locação
                        tbox_kmDevolucao.Text = dev.devolucao_km.ToString();
                        cbox_localDevolucao.SelectedValue = dev.filial_codigo;
                        dtp_devolucaoEfetiva.Value = dev.devolucao_dataEfetiva;
                        tbox_diferencaDias.Text = dev.devolucao_diferencaDias.ToString();
                        tbox_multaDevolucao.Text = dev.devolucao_multa.ToString();
                        cbox_tipoPagamento.SelectedValue = dev.tipopagamento_codigo;
                        cbox_statusDevolucao.SelectedValue = dev.status_codigo;
                        
                        //validação para trazer o nome do cliente, carro e data devolução prevista.
                        if (tbox_codLoc.Text != "")
                        {
                            int codLoc = (int.Parse(tbox_codLoc.Text));
                            locacao loc = (new locacaoRepositorio()).selecionar(codLoc);
                            if (loc != null)
                            {
                                int codCli = loc.cliente_codigo;
                                int codCar = loc.carro_codigo;
                                dtp_previsaoDevolucao.Value = loc.locacao_dataDevolucaoPrevista;
                                cliente cli = (new clienteRepositorio()).selecionar(codCli);
                                if(cli != null)
                                {
                                    tbox_cliente.Text = cli.cliente_nome;
                                }
                                carro car = (new carroRepositorio()).selecionar(codCar);
                                if(car != null)
                                {
                                    tbox_carro.Text = car.carro_nome;
                                }
                            }
                        }
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

        private decimal calcularMulta()
        {
            decimal total = 0;
            if (tbox_codLoc.Text != "")
            {
                DateTime dataInicio = dtp_previsaoDevolucao.Value.Date;
                DateTime dataFim = dtp_devolucaoEfetiva.Value.Date;
                int dias = Convert.ToInt32(dataFim.Subtract(dataInicio).TotalDays);
                tbox_diferencaDias.Text = dias.ToString();
                int codLoc = (int.Parse(tbox_codLoc.Text));
                locacao loc = (new locacaoRepositorio()).selecionar(codLoc);
                if (loc != null)
                {
                    int codCar = loc.carro_codigo;
                    carro car = (new carroRepositorio()).selecionar(codCar);
                    if(car != null)
                    {
                        decimal valorCarro = car.carro_valorDiaria.Value;
                        int tipoCarro = (int)car.tipocarro_codigo;
                        tipocarro tpc = (new tipocarroRepositorio()).selecionar(tipoCarro);
                        if(tpc != null)
                        {
                            decimal valorTpCarro = (decimal)tpc.tipocarro_valor;
                            total = (valorCarro + valorTpCarro) * dias * 2;
                        }
                    }
                }
            }
            return total;
        }

        private void btn_buscarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaLocacao frm = new ConsultaLocacao();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    locacao loc = (new locacaoRepositorio()).selecionar(codigo);
                    if (loc != null)
                    {
                        int codCli = loc.cliente_codigo;
                        int codCar = loc.carro_codigo;
                        tbox_codLoc.Text = loc.locacao_codigo.ToString();
                        dtp_previsaoDevolucao.Value = loc.locacao_dataDevolucaoPrevista;
                        cliente cli = (new clienteRepositorio()).selecionar(codCli);
                        if(cli != null)
                        {
                            tbox_cliente.Text = cli.cliente_nome;
                        }
                        carro car = (new carroRepositorio()).selecionar(codCar);
                        if(car != null)
                        {
                            tbox_carro.Text = car.carro_nome;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar! " + ex.Message);
            }
        }

        private void dtp_devolucaoEfetiva_ValueChanged(object sender, EventArgs e)
        {
            tbox_multaDevolucao.Text = calcularMulta().ToString("#.00");
        }
    }
}
