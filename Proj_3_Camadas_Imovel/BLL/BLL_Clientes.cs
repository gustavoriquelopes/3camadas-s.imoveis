using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proj_3_Camadas_Imovel.DAL;
using Proj_3_Camadas_Imovel.DTO;

namespace Proj_3_Camadas_Imovel.BLL
{
    internal class BLL_Clientes
    {
        Conexao bd = new Conexao();
        public void Inserir(DTO_Clientes Clientes)
        {
            try
            {
                string comando = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES ('" + Clientes.Nome + "','"
                                                                           + Clientes.Email + "','"
                                                                           + Clientes.Telefone + "');";


                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(DTO_Clientes Clientes)
        {
            try
            {
                string comando = "UPDATE Clientes SET  Nome = '" + Clientes.Nome +
                                                    "', Email = '" + Clientes.Email +
                                                    "', Telefone = '" + Clientes.Telefone +

                                                    "' WHERE ClienteID = " + Clientes.Id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                string comando = "DELETE FROM Clientes WHERE ClienteID = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            try
            {
                string comando = "SELECT * FROM Clientes;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
