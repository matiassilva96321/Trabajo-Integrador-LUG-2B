using Entitys;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class VehiculoMapper
    {
        public static Vehiculo Map(SqlDataReader sqlDataReader,Plaza plaza, Turno turno)
        {
            Vehiculo Vehiculo = new Vehiculo();
            Vehiculo.Id = Convert.ToInt32(sqlDataReader["ID"]);
            Vehiculo.Plaza= plaza;
            Vehiculo.Turno = turno;
            Vehiculo.Patente = Convert.ToInt32(sqlDataReader["PATENTE"]);
            Vehiculo.Entrada = Convert.ToDateTime(sqlDataReader["FECHA_HORA_ENTRADA"]);
            Vehiculo.TipoVehiculo = sqlDataReader["TIPO_VEHICULO"].ToString();
            Vehiculo.Marca= sqlDataReader["MARCA"].ToString();
            Vehiculo.Modelo= sqlDataReader["MODELO"].ToString();
            Vehiculo.Color= sqlDataReader["COLOR"].ToString();

            return Vehiculo;
        }
    }
}
