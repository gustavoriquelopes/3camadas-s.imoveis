using Proj_3_Camadas_Imovel.BLL;
using Proj_3_Camadas_Imovel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_3_Camadas_Imovel
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        DTO_Clientes objDTOCliente = new DTO_Clientes();
        BLL_Clientes objBLLCliente= new BLL_Clientes();
        public void CarregarGrid()
        {
            try
            {
                dtgImovel.DataSource = objBLLCliente.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtID.Clear();
        }

        private void bntListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == string.Empty)
                {

                    objDTOCliente.Nome = txtNome.Text;
                    objDTOCliente.Email = txtEmail.Text;
                    objDTOCliente.Telefone = txtTel.Text;

                    objBLLCliente.Inserir(objDTOCliente);
                    MessageBox.Show("Cliente Cadastrado");
                }
                else
                {
                    objDTOCliente.Id = int.Parse(txtID.Text);

                    objDTOCliente.Nome = txtNome.Text;
                    objDTOCliente.Email = txtEmail.Text;
                    objDTOCliente.Telefone = txtTel.Text;

                    objBLLCliente.Alterar(objDTOCliente);
                    MessageBox.Show("Cliente Alterado");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() != string.Empty)
                {
                    objDTOCliente.Id = int.Parse(txtID.Text);

                    objBLLCliente.Excluir(objDTOCliente.Id);
                    MessageBox.Show("Cliente Excluido");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
