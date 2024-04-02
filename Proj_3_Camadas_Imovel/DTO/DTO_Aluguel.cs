using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_3_Camadas_Imovel.DTO
{
    internal class DTO_Aluguel
    {

        private int id, id_cliente, id_imovel, valor_mensal;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public int Id_Imovel
        {
            get { return id_imovel; }
            set { id_imovel = value; }
        }

        public int Valor
        {
            get { return valor_mensal; }
            set { valor_mensal = value; }
        }
    }
}
