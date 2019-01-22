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
    public partial class CadastroLocacao : Form
    {
        public CadastroLocacao()
        {
            InitializeComponent();
        }

        private void CadastroLocacao_Load(object sender, EventArgs e)
        {
            //local, pagto, status
            cbox_localLocacao.DataSource = (new filialRepositorio()).selecionar("");
            cbox_localLocacao.ValueMember = "filial_codigo";
            cbox_localLocacao.DisplayMember = "filial_nome";
            cbox_localLocacao.SelectedIndex = -1;

            cbox_tipoPagamento.DataSource = (new tipopagamentoRepositorio()).selecionar("");
            cbox_tipoPagamento.ValueMember = "tipopagamento_codigo";
            cbox_tipoPagamento.DisplayMember = "tipopagamento_nome";
            cbox_tipoPagamento.SelectedIndex = -1;

            cbox_statusLocacao.DataSource = (new statusRepositorio()).selecionar("");
            cbox_statusLocacao.ValueMember = "status_codigo";
            cbox_statusLocacao.DisplayMember = "status_nome";
            cbox_statusLocacao.SelectedIndex = -1;

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
            dtp_locacao.Value = DateTime.Now;
            dtp_previsaoDevolucao.Value = DateTime.Now;
            tbox_totalDias.Text = "";
            tbox_funcionario.Text = "";
            tbox_cliente.Text = "";
            tbox_carro.Text = "";
            cbox_localLocacao.SelectedIndex = -1;
            tbox_totalLocacao.Text = "";
            cbox_tipoPagamento.SelectedIndex = -1;
            cbox_statusLocacao.SelectedIndex = -1;
            gbox_cadastroLocacao.Enabled = false;
            habilitarBotoes(true);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            btn_cancelar_Click(sender, e);
            gbox_cadastroLocacao.Enabled = true;
            habilitarBotoes(false);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbox_codigo.Text == "")
                {
                    gbox_cadastroLocacao.Enabled = false;
                    habilitarBotoes(true);
                    MessageBox.Show("Nenhum cadastro selecionado para alterar!");
                }
                else
                {
                    gbox_cadastroLocacao.Enabled = true;
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
                if (tbox_codigo.Text != "" && cbox_statusLocacao.Text == "Alugado")
                {
                    locacao loc = new locacao()
                    {
                        locacao_dataLocacao = dtp_locacao.Value,
                        locacao_dataDevolucaoPrevista = dtp_previsaoDevolucao.Value,
                        locacao_qtdeDias = (int.Parse(tbox_totalDias.Text)),
                        funcionario_codigo = (int.Parse(tbox_codFunc.Text)),
                        cliente_codigo = (int.Parse(tbox_codCli.Text)),
                        carro_codigo = (int.Parse(tbox_codCar.Text)),
                        locacao_totalLocacao = (decimal.Parse(tbox_totalLocacao.Text)),
                        status_codigo = 6,
                        tipopagamento_codigo = (int)cbox_tipoPagamento.SelectedValue,
                        filial_codigo = (int)cbox_localLocacao.SelectedValue
                    };
                    loc.locacao_codigo = int.Parse(tbox_codigo.Text);
                    (new locacaoRepositorio()).alterar(loc);

                    int codigo = loc.carro_codigo;
                    carro car = (new carroRepositorio()).selecionar(codigo);
                    if (car != null)
                    {
                        car.status_codigo = 1;
                    }

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
                if (tbox_totalDias.Text != "" && tbox_carro.Text != "" && tbox_cliente.Text != "" && tbox_funcionario.Text != "" && tbox_totalLocacao.Text != "" && cbox_localLocacao.Text != "" && cbox_statusLocacao.Text != "" && cbox_tipoPagamento.Text != "")
                {
                    locacao loc = new locacao()
                    {
                        locacao_dataLocacao = dtp_locacao.Value,
                        locacao_dataDevolucaoPrevista = dtp_previsaoDevolucao.Value,
                        locacao_qtdeDias = (int.Parse(tbox_totalDias.Text)),
                        funcionario_codigo = (int.Parse(tbox_codFunc.Text)),
                        cliente_codigo = (int.Parse(tbox_codCli.Text)),
                        carro_codigo = (int.Parse(tbox_codCar.Text)),
                        locacao_totalLocacao = (decimal.Parse(tbox_totalLocacao.Text)),
                        status_codigo = (int)cbox_statusLocacao.SelectedValue,
                        tipopagamento_codigo = (int)cbox_tipoPagamento.SelectedValue,
                        filial_codigo = (int)cbox_localLocacao.SelectedValue
                    };
                    if (tbox_codigo.Text == "")
                    {
                        (new locacaoRepositorio()).inserir(loc);
                    }
                    else
                    {
                        //alterar
                        loc.locacao_codigo = int.Parse(tbox_codigo.Text);
                        (new locacaoRepositorio()).alterar(loc);
                    }
                    MessageBox.Show("Dados salvos! Código: " + loc.locacao_codigo);
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
                ConsultaLocacao frm = new ConsultaLocacao();
                frm.ShowDialog();
                //codigo selecionado
                int codigo = frm.codigo;
                frm = null;
                if (codigo != 0)
                {
                    locacao loc = (new locacaoRepositorio()).selecionar(codigo);
                    if (loc != null && loc.status_codigo != 6)
                    {
                        tbox_codigo.Text = loc.locacao_codigo.ToString();
                        dtp_locacao.Value = loc.locacao_dataLocacao;
                        dtp_previsaoDevolucao.Value = loc.locacao_dataDevolucaoPrevista;
                        tbox_totalDias.Text = loc.locacao_qtdeDias.ToString();
                        tbox_codFunc.Text = loc.funcionario_codigo.ToString();
                        //trazer no tbox_funcionario o nome do funcionário correspondente ao código.
                        tbox_codCli.Text = loc.cliente_codigo.ToString();
                        //trazer no tbox_cliente o nome do cliente correspondente ao código.
                        tbox_codCar.Text = loc.carro_codigo.ToString();
                        //trazer no tbox_carro o nome do carro correspondente ao código.
                        cbox_localLocacao.SelectedValue = loc.filial_codigo;
                        tbox_totalLocacao.Text = loc.locacao_totalLocacao.ToString("#.00");
                        cbox_tipoPagamento.SelectedValue = loc.tipopagamento_codigo;
                        cbox_statusLocacao.SelectedValue = loc.status_codigo;
                        //validação para trazer o nome do funcionário.
                        if(tbox_codFunc.Text != "")
                        {
                            codigo = (int.Parse(tbox_codFunc.Text));
                            funcionario fun = (new funcionarioRepositorio()).selecionar(codigo);
                            if (fun != null)
                            {
                                tbox_funcionario.Text = fun.funcionario_nome;
                            }
                        }
                        //validação para trazer o nome do cliente.
                        if (tbox_codCli.Text != "")
                        {
                            codigo = (int.Parse(tbox_codCli.Text));
                            cliente cli = (new clienteRepositorio()).selecionar(codigo);
                            if (cli != null)
                            {
                                tbox_cliente.Text = cli.cliente_nome;
                            }
                        }
                        //validação para trazer o nome do carro.
                        if (tbox_codCar.Text != "")
                        {
                            codigo = (int.Parse(tbox_codCar.Text));
                            carro car = (new carroRepositorio()).selecionar(codigo);
                            if (car != null)
                            {
                                tbox_carro.Text = car.carro_nome;
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

        private decimal atualizarTotal()
        {
            decimal total = 0;
            if (tbox_codCar.Text != "")
            {
                DateTime dataInicio = dtp_locacao.Value.Date;
                DateTime dataFim = dtp_previsaoDevolucao.Value.Date;
                int dias = Convert.ToInt32(dataFim.Subtract(dataInicio).TotalDays);
                if (dias == 0)
                {
                    dias++;
                }
                tbox_totalDias.Text = dias.ToString();

                carro car = (new carroRepositorio()).selecionar(int.Parse(tbox_codCar.Text));
                decimal valorCarro = car.carro_valorDiaria.Value;
                int tipoCarro = car.tipocarro_codigo.Value;
                tipocarro tpc = (new tipocarroRepositorio()).selecionar(tipoCarro);
                decimal valorTpCarro = tpc.tipocarro_valor.Value;
                total = (valorCarro + valorTpCarro) * dias;
            }
            tbox_totalLocacao.Text = total.ToString("#.00");
            return total;
        }
        
        private void btn_buscarFuncionario_Click(object sender, EventArgs e)
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
                        tbox_codFunc.Text = fun.funcionario_codigo.ToString();
                        tbox_funcionario.Text = fun.funcionario_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar! " + ex.Message);
            }
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
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
                        tbox_codCli.Text = cli.cliente_codigo.ToString();
                        tbox_cliente.Text = cli.cliente_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar! " + ex.Message);
            }
        }

        private void btn_buscarCarro_Click(object sender, EventArgs e)
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
                    if (car != null && car.status_codigo == 1)
                    {
                        tbox_codCar.Text = car.carro_codigo.ToString();
                        tbox_carro.Text = car.carro_nome;
                    }
                    else
                    {
                        MessageBox.Show("Carro não disponível!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar! " + ex.Message);
            }
        }

        private void dtp_previsaoDevolucao_ValueChanged(object sender, EventArgs e)
        {
            atualizarTotal();
        }

        private void dtp_locacao_ValueChanged(object sender, EventArgs e)
        {
            atualizarTotal();
        }
    }
}
