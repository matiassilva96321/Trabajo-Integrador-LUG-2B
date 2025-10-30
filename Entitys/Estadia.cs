using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Estadia
    {
        public int Id { get; set; }
        public Plaza Plaza { get; set; }
        public Turno TurnoEntrada { get; set; }
        public Turno? TurnoSalida { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Salida { get; set; }
        public double PrecioHora { get; set; } = 60;
        public double? ImporteTotal { get; set; }

        public double CalcularImporte()
        {
            TimeSpan Diferencia = this.Salida.Value - this.Entrada;
            return (double)Diferencia.TotalMinutes * (this.PrecioHora / 60);
        }
    }
}
