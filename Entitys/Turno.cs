using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Turno
    {
        public int Id { get; set; }
        public string EncargadoTurno { get; set; }
        public DateTime FechaHoraApertura { get; set; }
        public double MontoApertura { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public double? MontoCierre { get; set; }
        public double? TotalGenerado { get; set; }
        public bool Estado {  get; set; }

        public double? CalcularTotal()
        {
            return Convert.ToDouble(MontoCierre-MontoApertura);
        }
    }
}
