using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class Conexao
    {
        private String connectionString;
        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Usuarios.Py.Properties.Settings.bancoConnectionString"].ConnectionString;
            return connectionString;
            
        }
    }
}
