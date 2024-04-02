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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, pwd;

            usuario = txtUsuario.Text;
            pwd = txtSenha.Text;

            if (usuario == "user1" & pwd == "123456")
            {
                Frmmenu tela = new Frmmenu();
                tela.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuário Errado");
            }
        }
    }
}
