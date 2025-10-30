using Entitys;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EstadiaMapper
    {
        public static Estadia Map(SqlDataReader sqlDataReader, Plaza Plaza, Turno TurnoEntrada, Turno TurnoSalida)
        {
            Estadia Estadia = new Estadia();
            Estadia.Id = Convert.ToInt32(sqlDataReader["ID"]);
            Estadia.Entrada= Convert.ToDateTime(sqlDataReader["FECHA_HORA_ENTRADA"]);
            Estadia.Salida = sqlDataReader["FECHA_HORA_SALIDA"] as DateTime?;
            Estadia.PrecioHora= Convert.ToDouble(sqlDataReader["PRECIO_HORA"]);
            Estadia.ImporteTotal= (double)sqlDataReader["IMPORTE_A_PAGAR"];
            Estadia.Plaza= Plaza;
            Estadia.TurnoEntrada= TurnoEntrada;
            Estadia.TurnoSalida= TurnoSalida;

            return Estadia;
        }
    }
}
