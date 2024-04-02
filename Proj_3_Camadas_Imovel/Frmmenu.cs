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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void btnImovel_Click(object sender, EventArgs e)
        {
            FrmImovel tela = new FrmImovel();
            tela.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente tela = new FrmCliente();
            tela.ShowDialog();
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            FrmAluguel tela = new FrmAluguel();
            tela.ShowDialog();
        }
    }
}
