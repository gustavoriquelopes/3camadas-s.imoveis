using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_3_Camadas_Imovel.DTO
{
    internal class DTO_Imovel
    {
        private string endereco, tipo;
        private int id, valor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Endereco
        {
            get { return endereco; }

            set { endereco = value; }
        }

        public string Tipo
        {
            get { return tipo; }

            set { tipo = value; }
        }

    }
}
