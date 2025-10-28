using Dal;
using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PlazaBss
    {
        public PlazaDal PlazaDal = new PlazaDal();
        public List<Plaza> TraerPlazas()
        {
            try
            {
                return PlazaDal.TraerPlazas();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarEstadoPlaza(Plaza plaza)
        {
            try
            {
                PlazaDal.ModificarEstadoPlaza(plaza);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
