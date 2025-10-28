using Dal;
using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EstadiaBss
    {
        public EstadiaDal EstadiaDal= new EstadiaDal();
        public List<Estadia> TraerEstadias()
        {
            try
            {
                return EstadiaDal.TraerEstadias();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarEstadia(Estadia estadia) 
        {
            try
            {
                EstadiaDal.CargarEstadia(estadia);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
