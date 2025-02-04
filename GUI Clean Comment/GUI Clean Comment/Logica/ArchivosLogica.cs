using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Clean_Comment.Logica
{
    public class ArchivosLogica
    {
        private static readonly string cadena = ConfigurationManager.ConnectionStrings["CadenaConSqlite"].ConnectionString;
        private static ArchivosLogica _instancia = null;

        public ArchivosLogica() { }
    }
}
