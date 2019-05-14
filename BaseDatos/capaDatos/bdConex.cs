using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace capaDatos
{
    public class bdConex
    {
        String cadenaConex = "Data Source=.;Initial Catalog=FACTURASBD;Persist Security Info=True;User ID=jesus_vasquez2;Password=123";

        public bool conex()
        {
            bool correcto = false;
            try
            {
                correcto = true;
            }catch(Exception ex)
            {
                correcto = false;
            }

            return correcto;
        }
    }
}
