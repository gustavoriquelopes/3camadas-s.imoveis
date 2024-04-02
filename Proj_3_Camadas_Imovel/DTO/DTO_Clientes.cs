using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_3_Camadas_Imovel.DTO
{
    internal class DTO_Clientes
    {

        private string nome, email, telefone;
        private int id; 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
