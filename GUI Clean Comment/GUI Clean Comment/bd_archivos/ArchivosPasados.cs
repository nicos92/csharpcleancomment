using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SQLite;
using clean_comment.modelo;

namespace clean_comment
{
    public class ArchivosPasados
    {
        public DataTable ListArchivos()
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();  
            SQLiteConnection SqlCon = new SQLiteConnection();

            try
            {
                SqlCon = MiConexion.GetInstancia().CrearConexion();
                string query = "select id, fecha, archivo, ruta from archivosPasados order by id desc";
                SQLiteCommand Comando = new SQLiteCommand(query, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }catch (Exception ex)
            {
                throw ex;
            }finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
               
            }
        }
        
        
        public string GuardarArchivo( MiArchivo Miarchivo)
        {
            
            SQLiteConnection SqlCon = new SQLiteConnection();

            try
            {
                SqlCon = MiConexion.GetInstancia().CrearConexion();

                string query = "insert into archivosPasados ( archivo, ruta, fecha)" +
                    " values ( '"+ Miarchivo.Archivo+"', '"+ Miarchivo.Ruta+"', '"+Miarchivo.Fecha+"');";

                SQLiteCommand Comando = new SQLiteCommand(query, SqlCon);
                SqlCon.Open();

                return Comando.ExecuteNonQuery() >= 1 ? "OK":"No se Completo el proceso de registro";
                
                
            }catch (Exception ex)
            {
                throw ex;
            }finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
               
            }
        }
    }
}
