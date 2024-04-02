using Proj_3_Camadas_Imovel.DAL;
using Proj_3_Camadas_Imovel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Proj_3_Camadas_Imovel.BLL
{
    internal class BLL_Aluguel
    {
        Conexao bd = new Conexao();
        public void Inserir(DTO_Aluguel Aluguel)
        {
            try
            {
                string comando = "INSERT INTO Alugueis (ImovelID, ClienteID, ValorMensal) VALUES ('" + Aluguel.Id_Imovel + "','"
                                                                           + Aluguel.Id_Cliente + "','"
                                                                           + Aluguel.Valor + "');";


                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(DTO_Aluguel Aluguel)
        {
            try
            {
                string comando = "UPDATE Alugueis SET  ImovelID = '" + Aluguel.Id_Imovel +
                                                    "', ClienteID = '" + Aluguel.Id_Cliente +
                                                    "', ValorMensal = '" + Aluguel.Valor +

                                                    "' WHERE AluguelID = " + Aluguel.Id + ";";
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
                string comando = "DELETE FROM Alugueis WHERE AluguelID = " + id + ";";
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
                string comando = "SELECT * FROM Alugueis;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
