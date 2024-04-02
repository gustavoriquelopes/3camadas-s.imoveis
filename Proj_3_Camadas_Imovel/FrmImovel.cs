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
    public partial class FrmImovel : Form
    {
        public FrmImovel()
        {
            InitializeComponent();
        }

        DTO_Imovel objDTOImovel = new DTO_Imovel();
        BLL_Imovel objBLLImovel = new BLL_Imovel();

        public void Limpar()
        {
            txtTipo.Clear();
            txtEnd.Clear();
            txtValor.Clear();
            txtID.Clear();
        }

        public void CarregarGrid()
        {
            try
            {
                dtgImovel.DataSource = objBLLImovel.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    objDTOImovel.Tipo = txtTipo.Text;
                    objDTOImovel.Endereco = txtEnd.Text;
                    objDTOImovel.Valor = int.Parse(txtValor.Text);

                    objBLLImovel.Inserir(objDTOImovel);
                    MessageBox.Show("Imovel Cadastrado");
                }
                else
                {
                    objDTOImovel.Id = int.Parse(txtID.Text);
                    objDTOImovel.Tipo = txtTipo.Text;
                    objDTOImovel.Endereco = txtEnd.Text;
                    objDTOImovel.Valor = int.Parse(txtValor.Text);

                    objBLLImovel.Alterar(objDTOImovel);
                    MessageBox.Show("Imovel Alterado");
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
                    objDTOImovel.Id = int.Parse(txtID.Text);

                    objBLLImovel.Excluir(objDTOImovel.Id);
                    MessageBox.Show("Imovel Excluido");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();

        }
    }
}
