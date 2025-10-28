using Entitys;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PlazaMapper
    {
        public static Plaza Map(SqlDataReader sqlDataReader)
        {
            Plaza Plaza = new Plaza();
            Plaza.Id = Convert.ToInt32(sqlDataReader["ID"]);
            Plaza.Estado = (bool)sqlDataReader["ESTADO"];

            return Plaza;
        }
    }
}
