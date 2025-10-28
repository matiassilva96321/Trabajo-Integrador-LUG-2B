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
    public class VehiculoDal
    {
        PlazaDal PlazaDal= new PlazaDal();
        TurnoDal TurnoDal= new TurnoDal();
        public List<Vehiculo> TraerVehiculos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT ID, ID_PLAZA, ID_TURNO, PATENTE, FECHA_HORA_ENTRADA, TIPO_VEHICULO, MARCA, MODELO, COLOR FROM VEHICULO";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            List<Vehiculo> Vehiculos = new List<Vehiculo>();
                            while (sqlDataReader.Read())
                            {
                                Plaza plaza = PlazaDal.GetById(Convert.ToInt32(sqlDataReader["ID_PLAZA"]));
                                Turno turno = TurnoDal.GetById(Convert.ToInt32(sqlDataReader["ID_TURNO"]));
                                Vehiculo Vehiculo = VehiculoMapper.Map(sqlDataReader,plaza,turno);
                                Vehiculos.Add(Vehiculo);
                            }
                            return Vehiculos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Vehiculo GetById(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();
                    Vehiculo vehiculo = new Vehiculo();

                    string sql = "SELECT ID, ID_PLAZA, PATENTE, FECHA_HORA_ENTRADA, TIPO_VEHICULO, MARCA, MODELO, COLOR FROM VEHICULO WHERE ID = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", Id);
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Plaza plaza = PlazaDal.GetById(Convert.ToInt32(sqlDataReader["ID_PLAZA"]));
                                Turno turno = TurnoDal.GetById(Convert.ToInt32(sqlDataReader["ID_TURNO"]));
                                Vehiculo Vehiculo = VehiculoMapper.Map(sqlDataReader, plaza, turno);
                            }

                            return vehiculo;
                        }
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO VEHICULO (ID_PLAZA, ID_TURNO, PATENTE, FECHA_HORA_ENTRADA, TIPO_VEHICULO, MARCA, MODELO, COLOR) VALUES (@idplaza, @idturno, @patente, @entrada, @tipo, @marca, @modelo, @color)";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idplaza", vehiculo.Plaza.Id);
                        sqlCommand.Parameters.AddWithValue("@idturno", vehiculo.Turno.Id);
                        sqlCommand.Parameters.AddWithValue("@patente", vehiculo.Patente);
                        sqlCommand.Parameters.AddWithValue("@entrada", vehiculo.Entrada);
                        sqlCommand.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculo);
                        sqlCommand.Parameters.AddWithValue("@marca", vehiculo.Marca);
                        sqlCommand.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                        sqlCommand.Parameters.AddWithValue("@color", vehiculo.Color);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM VEHICULO WHERE ID = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", vehiculo.Id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ModificarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE VEHICULO SET PATENTE = @patente, TIPO_VEHICULO=@tipo, MARCA=@marca, MODELO=@modelo, COLOR=@color WHERE ID = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", vehiculo.Id);
                        sqlCommand.Parameters.AddWithValue("@patente", vehiculo.Patente);
                        sqlCommand.Parameters.AddWithValue("@tipo", vehiculo.TipoVehiculo);
                        sqlCommand.Parameters.AddWithValue("@marca", vehiculo.Marca);
                        sqlCommand.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                        sqlCommand.Parameters.AddWithValue("@color", vehiculo.Color);
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
