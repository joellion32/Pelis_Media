using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pelis_Media.Config
{
	class ConnectionDB
	{
        public static SqlConnection getSqlConnection()
        {
            try
            {
                String connection = "SERVER=DESKTOP-1S42R35\\SQLEXPRESS; DATABASE=pelismedia; integrated security=true";
                SqlConnection cn = new SqlConnection(connection);
                cn.Open();
                return cn; 
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ha ocurrido un error al conectar", ex);
            }
        }

    }

}

