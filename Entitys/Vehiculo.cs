using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public Plaza Plaza { get; set; }
        public Turno Turno { get; set; }
        public int Patente {  get; set; }
        public DateTime Entrada { get; set; }
        public string TipoVehiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo {  get; set; }
        public string? Color { get; set; }
    }
}
