using Entitys;
using Mapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PlazaDal
    {
        public List<Plaza> TraerPlazas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT ID, ESTADO FROM PLAZA";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            List<Plaza> Plazas = new List<Plaza>();
                            while (sqlDataReader.Read())
                            {
                                Plaza Plaza = PlazaMapper.Map(sqlDataReader);
                                Plazas.Add(Plaza);
                            }
                            return Plazas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Plaza GetById(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();
                    Plaza plaza = new Plaza();

                    string sql = "SELECT ID, ESTADO FROM PLAZA WHERE ID = @Id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", Id);
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                plaza= PlazaMapper.Map(sqlDataReader);
                            }
                            return plaza;
                        }
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EstacionamientoBD"].ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE PLAZA SET ESTADO = @estado WHERE ID = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", plaza.Id);
                        sqlCommand.Parameters.AddWithValue("@estado", plaza.Estado);
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
