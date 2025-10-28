using Entitys;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class EstadiaDal
    {
        PlazaDal PlazaDal = new PlazaDal();
        TurnoDal TurnoDal = new TurnoDal();
        VehiculoDal VehiculoDal = new VehiculoDal();
        public List<Estadia> TraerEstadias()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT ID, ID_PLAZA, ID_TURNO_ENTRADA, ID_TURNO_SALIDA, FECHA_HORA_ENTRADA, FECHA_HORA_SALIDA, PRECIO_HORA, IMPORTE_A_PAGAR FROM ESTADIA";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            List<Estadia> Estadias = new List<Estadia>();
                            while (sqlDataReader.Read())
                            {
                                Plaza plaza = PlazaDal.GetById(Convert.ToInt32(sqlDataReader["ID_PLAZA"]));
                                Turno turnoE = TurnoDal.GetById(Convert.ToInt32(sqlDataReader["ID_TURNO_ENTRADA"]));
                                Turno turnoS = TurnoDal.GetById(Convert.ToInt32(sqlDataReader["ID_TURNO_SALIDA"]));
                                Estadia Estadia = EstadiaMapper.Map(sqlDataReader,plaza,turnoE,turnoS);
                                Estadias.Add(Estadia);
                            }
                            return Estadias;
                        }
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO ESTADIA (ID_PLAZA, ID_TURNO_ENTRADA, ID_TURNO_SALIDA, FECHA_HORA_ENTRADA, FECHA_HORA_SALIDA, PRECIO_HORA, IMPORTE_A_PAGAR) VALUES (@idplaza, @idturnoentrada, @idturnosalida, @entrada, @salida, @precio, @total)";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idplaza", estadia.Plaza.Id);
                        sqlCommand.Parameters.AddWithValue("@idturnoentrada", estadia.TurnoEntrada.Id);
                        sqlCommand.Parameters.AddWithValue("@idturnosalida", estadia.TurnoSalida.Id);
                        sqlCommand.Parameters.AddWithValue("@entrada", estadia.Entrada);
                        sqlCommand.Parameters.AddWithValue("@salida", estadia.Salida);
                        sqlCommand.Parameters.AddWithValue("@precio", estadia.PrecioHora);
                        sqlCommand.Parameters.AddWithValue("@total", estadia.ImporteTotal);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
