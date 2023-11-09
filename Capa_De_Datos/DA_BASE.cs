using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Capa_De_Datos
{
    public class DA_BASE
    {
        public static String CadenaConexion = "SERVER=localhost;" +
           "  DATABASE=minimarket;UID=root; PASSWORD= ";

        //SENTENCIA INSERT, UPDATE Y DELETE
        public static bool RealizarTransaccion(String strSQL)
        {
            bool resultado = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlTransaction tr = conn.BeginTransaction())
                    {
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                            {
                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                            tr.Commit();
                            resultado = true;
                        }
                        catch (Exception)
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;
                        }
                    }

                }

            }
            catch (Exception)
            {
                resultado = false;
                throw;

            }
            return resultado;

        }
        //consulta de dstos sentencia select
        public static DataTable ConsultarDatos(String strSQL) 
        {
            try 
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion)) { 
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader()) 
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
