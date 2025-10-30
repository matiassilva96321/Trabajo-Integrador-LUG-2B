using Dal;
using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class TurnoBss
    {
        public TurnoDal TurnoDal = new TurnoDal();
        public List<Turno> TraerTurnos()
        {
            try
            {
                return TurnoDal.TraerTurnos();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ChequearTurno()
        {
            try
            {
                var UltimoTurno = TurnoDal.TraerTurnos().LastOrDefault();

                if (UltimoTurno == null)
                {
                    return false;
                }
                else if (UltimoTurno.Estado == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AbrirTurno(Turno turno)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (turno.EncargadoTurno.Length < 3)
                    {
                        throw new Exception("Nombre muy corto");
                    }
                    if (turno.MontoApertura < 0)
                    {
                        throw new Exception("El monto de apentura no puede ser negativo");
                    }
                    turno.FechaHoraApertura = DateTime.Now;
                    turno.FechaHoraCierre = null;
                    turno.MontoCierre = 0;
                    turno.TotalGenerado = 0;
                    turno.Estado = true;

                    TurnoDal.CargarTurno(turno);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CerrarTurno(Turno turno)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    turno.FechaHoraCierre = DateTime.Now;
                turno.Estado = false;
                TurnoDal.ModificarTurno(turno);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
