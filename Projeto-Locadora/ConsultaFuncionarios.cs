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
    public partial class ConsultaFuncionarios : Form
    {
        //guarda o código do cliente selecionado
        public int codigo;

        public ConsultaFuncionarios()
        {
            InitializeComponent();
        }

        private void tbox_nome_KeyUp(object sender, KeyEventArgs e)
        {
            List<vw_funcionario> lista = (new funcionarioRepositorio()).selecionarView(tbox_nome.Text);
            dgv_consultaFuncionarios.DataSource = lista;

            if (lista.Count > 0)
            {
                dgv_consultaFuncionarios.Columns["funcionario_nome"].Width = 300;
                dgv_consultaFuncionarios.Columns["funcionario_codigo"].HeaderText = "Código";
                dgv_consultaFuncionarios.Columns["funcionario_nome"].HeaderText = "Nome";
                dgv_consultaFuncionarios.Columns["funcionario_cpf"].HeaderText = "CPF";
                dgv_consultaFuncionarios.Columns["funcionario_rg"].HeaderText = "RG";
                dgv_consultaFuncionarios.Columns["funcionario_cnh"].HeaderText = "CNH";
                dgv_consultaFuncionarios.Columns["funcionario_dataNascimento"].HeaderText = "Data de Nascimento";
                dgv_consultaFuncionarios.Columns["funcionario_telefoneFixo"].HeaderText = "Telefone";
                dgv_consultaFuncionarios.Columns["funcionario_telefoneCelular"].HeaderText = "Celular";
                dgv_consultaFuncionarios.Columns["funcionario_endereco"].HeaderText = "Endereço";
                dgv_consultaFuncionarios.Columns["cidade_nome"].HeaderText = "Cidade";
            }
        }

        private void dgv_consultaFuncionarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //código selecionado
            codigo = (int)dgv_consultaFuncionarios.Rows[e.RowIndex].Cells["funcionario_codigo"].Value;
            //fechar o formulário
            this.Close();
        }
    }
}
