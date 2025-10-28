using Entitys;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TurnoMapper
    {
        public static Turno Map(SqlDataReader sqlDataReader)
        {
            Turno Turno = new Turno();
            Turno.Id = Convert.ToInt32(sqlDataReader["ID"]);
            Turno.EncargadoTurno = sqlDataReader["ENCARGADO_TURNO"].ToString();
            Turno.FechaHoraApertura = Convert.ToDateTime(sqlDataReader["FECHA_HORA_APERTURA"]);
            Turno.MontoApertura = (double)sqlDataReader["MONTO_APERTURA"];
            Turno.FechaHoraCierre = sqlDataReader["FECHA_HORA_CIERRE"] as DateTime?;
            Turno.MontoCierre = sqlDataReader["MONTO_CIERRE"] as double?;
            Turno.TotalGenerado = sqlDataReader["TOTAL_GENERADO"] as double?;
            Turno.Estado = (bool)sqlDataReader["ESTADO"];
            
            return Turno;
        }
    }
}
