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
    public partial class ConsultaClientes : Form
    {
        public int codigo;

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void dgv_consultaCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = (int) dgv_consultaCliente.Rows[e.RowIndex].Cells["cliente_codigo"].Value;
            this.Close();
        }

        private void tbox_nome_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_cliente> lista = (new clienteRepositorio()).selecionarView(tbox_nome.Text);
            dgv_consultaCliente.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaCliente.Columns["cliente_nome"].Width = 300;
                dgv_consultaCliente.Columns["cliente_codigo"].HeaderText = "Código";
                dgv_consultaCliente.Columns["cliente_nome"].HeaderText = "Nome";
                dgv_consultaCliente.Columns["cliente_cpf"].HeaderText = "CPF";
                dgv_consultaCliente.Columns["cliente_rg"].HeaderText = "RG";
                dgv_consultaCliente.Columns["cliente_cnh"].HeaderText = "CNH";
                dgv_consultaCliente.Columns["cliente_dataNascimento"].HeaderText = "Data de Nascimento";
                dgv_consultaCliente.Columns["cliente_telefoneFixo"].HeaderText = "Telefone";
                dgv_consultaCliente.Columns["cliente_telefoneCelular"].HeaderText = "Celular";
                dgv_consultaCliente.Columns["cliente_endereco"].HeaderText = "Endereço";
                dgv_consultaCliente.Columns["cidade_nome"].HeaderText = "Cidade";
            }
        }
    }
}
