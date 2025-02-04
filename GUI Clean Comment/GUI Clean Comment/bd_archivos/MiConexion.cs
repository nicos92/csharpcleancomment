using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace clean_comment
{
    public class MiConexion
    {
        // https://www.youtube.com/watch?v=l_HysfACS4o
        private static MiConexion MiConex = null;

        private MiConexion() {
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