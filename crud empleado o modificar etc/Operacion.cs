using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;



namespace crud_empleado_o_modificar_etc
{
   public  class Operacion
    {
        public string Conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SISTEMAS\\nomina.s3db; Version=3;");
            try
            {
                cnx.Open();
                return "conexion exitosa";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Clone();
            }
        }

        public string ConsultasSinResultados(string sql)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SISTEMAS\\nomina.s3db; Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }


        public DataTable ConsultaConResultado(string  sql)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SISTEMAS\\nomina.s3db; Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {

            }
            cnx.Close();
            return dt;
        }

    }
}
