﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proj_3_Camadas_Imovel.DAL
{
   
        internal class Conexao
        {

            private string string_conexao = "persist security info=false; server=localHost; " +
            "database=software_moveis; uid=root; pwd=;"; 
            public MySqlConnection conexao;

            public void Conectar()
            {
                try
                {
                    conexao = new MySqlConnection(string_conexao);
                    conexao.Open();
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public void ExecutarComandos(string sql)
            {
                try
                {
                    Conectar();
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

            public object ExecutarComandosComFuncao(string sql)
            {
                try
                {
                    Conectar();
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    return comando.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

            public DataTable ExecutarConsulta(string sql)
            {
                try
                {
                    Conectar();
                    MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                    DataTable dados = new DataTable();
                    consulta.Fill(dados);

                    return dados;
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }

