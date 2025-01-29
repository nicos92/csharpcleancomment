using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace clean_comment
{
    public class MiConexion
    {

        private readonly string BasedeDatos;
        private static MiConexion MiConex = null;

        private MiConexion() {
            this.BasedeDatos = "db_cleanCommentFiles.db";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection sQLiteConnection;
            try
            {

                 sQLiteConnection = new SQLiteConnection("Data Source = db_cleanCommentFiles.db; Version = 3; New = false; Read Only = false");

               //sQLiteConnection = new SQLiteConnection("Data Source=" + this.BasedeDatos);
            }catch (Exception ex) {
                throw ex;
            }

            return sQLiteConnection;
        }
        public static MiConexion GetInstancia()
        {
          if (MiConex == null)
            {
                MiConex = new MiConexion();
            }
          return MiConex;
        }
    }
}