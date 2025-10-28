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
    public class TurnoDal
    {
        public List<Turno> TraerTurnos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT ID, ENCARGADO_TURNO, FECHA_HORA_APERTURA, MONTO_APERTURA, FECHA_HORA_CIERRE, MONTO_CIERRE, TOTAL_GENERADO, ESTADO FROM TURNO";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            List<Turno> Turnos = new List<Turno>();
                            while (sqlDataReader.Read())
                            {
                                Turno Turno = TurnoMapper.Map(sqlDataReader);
                                Turnos.Add(Turno);
                            }
                            return Turnos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Turno GetById(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();
                    Turno turno = new Turno();

                    string sql = "SELECT ID, ENCARGADO_TURNO, FECHA_HORA_APERTURA, MONTO_APERTURA, FECHA_HORA_CIERRE, MONTO_CIERRE, TOTAL_GENERADO, ESTADO FROM TURNO WHERE ID = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", Id);
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                turno = TurnoMapper.Map(sqlDataReader);
                            }
                            
                            return turno;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarTurno(Turno turno)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO TURNO (ENCARGADO_TURNO, FECHA_HORA_APERTURA, MONTO_APERTURA, FECHA_HORA_CIERRE, MONTO_CIERRE, TOTAL_GENERADO, ESTADO) VALUES (@Nombre, @Fechaapertura, @Montoapertura, @Fechacierre, @Montocierre, @Totalgenerado, @Estado)";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", turno.EncargadoTurno);
                        sqlCommand.Parameters.AddWithValue("@Fechaapertura", turno.FechaHoraApertura);
                        sqlCommand.Parameters.AddWithValue("@Montoapertura", turno.MontoApertura);
                        sqlCommand.Parameters.AddWithValue("@Fechacierre", (Object)turno.FechaHoraCierre ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Montocierre", (Object)turno.MontoCierre ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Totalgenerado", (Object)turno.TotalGenerado ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Estado", turno.Estado);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarTurno(Turno turno)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE TURNO SET ENCARGADO_TURNO = @Nombre, FECHA_HORA_APERTURA = @Fechaapertura, MONTO_APERTURA=@Montoapertura, FECHA_HORA_CIERRE=@Fechacierre,MONTO_CIERRE=@Montocierre, TOTAL_GENERADO=@Totalgenerado, ESTADO=@Estado WHERE ID = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", turno.Id);
                        sqlCommand.Parameters.AddWithValue("@Nombre", turno.EncargadoTurno);
                        sqlCommand.Parameters.AddWithValue("@Fechaapertura", turno.FechaHoraApertura);
                        sqlCommand.Parameters.AddWithValue("@Montoapertura", turno.MontoApertura);
                        sqlCommand.Parameters.AddWithValue("@Fechacierre", (Object)turno.FechaHoraCierre ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Montocierre", (Object)turno.MontoCierre ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Totalgenerado", (Object)turno.TotalGenerado ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@Estado", turno.Estado);
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
