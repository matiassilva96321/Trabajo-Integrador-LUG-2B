using Dal;
using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VehiculoBss
    {
        public VehiculoDal VehiculoDal = new VehiculoDal();
        public List<Vehiculo> TraerVehiculos()
        {
            try
            {
                return VehiculoDal.TraerVehiculos();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo.Patente.ToString().Length != 3)
                {
                    throw new Exception("Patente invalida");
                }
                if (vehiculo.Marca.ToString().Length < 2)
                {
                    throw new Exception("Marca invalida");
                }
                if (vehiculo.Modelo.ToString().Length < 2)
                {
                    throw new Exception("Modelo invalido");
                }
                if (vehiculo.Plaza == null)
                {
                    throw new Exception("No hay cochera disponible");
                }
                vehiculo.Entrada=DateTime.Now;
                vehiculo.Plaza.Estado = true;

                VehiculoDal.CargarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void BorrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                VehiculoDal.BorrarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ModificarVehiculo (Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo.Patente.ToString().Length != 3)
                {
                    throw new Exception("Patente invalida");
                }
                if (vehiculo.Marca.ToString().Length < 2)
                {
                    throw new Exception("Marca invalida");
                }
                if (vehiculo.Modelo.ToString().Length < 2)
                {
                    throw new Exception("Modelo invalido");
                }
                VehiculoDal.ModificarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
