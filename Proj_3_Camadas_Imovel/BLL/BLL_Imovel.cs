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
    internal class BLL_Imovel
    {
        Conexao bd = new Conexao();
        public void Inserir(DTO_Imovel Imovel)
        {
            try
            {
                string comando = "INSERT INTO Imoveis (TipoImovel, Endereco, ValorAluguel) VALUES ('" + Imovel.Tipo + "','"
                                                                           + Imovel.Endereco + "','"
                                                                           + Imovel.Valor + "');";


                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(DTO_Imovel Imovel)
        {
            try
            {
                string comando = "UPDATE Imoveis SET  TipoImovel = '" + Imovel.Tipo +
                                                    "', Endereco = '" + Imovel.Endereco +
                                                    "', ValorAluguel = '" + Imovel.Valor +

                                                    "' WHERE ImovelID = " + Imovel.Id + ";";
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
                string comando = "DELETE FROM Imoveis WHERE ImovelID = " + id + ";";
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
                string comando = "SELECT * FROM Imoveis;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
