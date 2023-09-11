using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWNTIME_MONITORE.classe
{
    internal class connection
    {
        public static string con()
        {
            return ("Data Source=MOHAMMED_REDA;Initial Catalog=downtime_db;Integrated Security=True");
            //return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("downtime_monitore_db.mdf") + ";Integrated Security=True");
        }
    }
}
