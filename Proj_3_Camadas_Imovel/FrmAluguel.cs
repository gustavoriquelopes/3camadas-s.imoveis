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
    public partial class FrmAluguel : Form
    {
        public FrmAluguel()
        {
            InitializeComponent();
        }
        DTO_Aluguel objDTOAluguel = new DTO_Aluguel();
        BLL_Aluguel objBLLAluguel = new BLL_Aluguel();
        public void CarregarGrid()
        {
            try
            {
                dtgImovel.DataSource = objBLLAluguel.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Limpar()
        {
            txtIDimovel.Clear();
            txtIDcliente.Clear();
            txtValor.Clear();
            txtID.Clear();
        }
        private void bntListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == string.Empty)
                {

                    objDTOAluguel.Id_Imovel = int.Parse(txtIDimovel.Text);
                    objDTOAluguel.Id_Cliente= int.Parse(txtIDcliente.Text);
                    objDTOAluguel.Valor = int.Parse(txtValor.Text);

                    objBLLAluguel.Inserir(objDTOAluguel);
                    MessageBox.Show("Aluguel Cadastrado");
                }
                else
                {
                    objDTOAluguel.Id = int.Parse(txtID.Text);


                    objDTOAluguel.Id_Imovel = int.Parse(txtIDimovel.Text);
                    objDTOAluguel.Id_Cliente = int.Parse(txtIDcliente.Text);
                    objDTOAluguel.Valor = int.Parse(txtValor.Text);

                    objBLLAluguel.Alterar(objDTOAluguel);
                    MessageBox.Show("Aluguel Alterado");
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
                    objDTOAluguel.Id = int.Parse(txtID.Text);

                    objBLLAluguel.Excluir(objDTOAluguel.Id);
                    MessageBox.Show("Aluguel Excluido");
                }
                Limpar();
                CarregarGrid();
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
    }
}
