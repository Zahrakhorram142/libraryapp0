
using BaseBackend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public class ShelfRepository : IGenericBaseRepository<Shelf>
{
    // const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();

    public bool AddItem(Shelf item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Shelf";

                string query = $"INSERT INTO {tableName}(Floor,Title)" +
                "VALUES(@Floor,@Title)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Floor", item.Floor);
                command.Parameters.AddWithValue("@Title", item.Title);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(message: "error");
            }
            finally
            {
                connection.Close();
            }
        }

    }

    public bool DeleteItem(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"delete dbo.Shelf where Id =@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue($"Id", id);
                int rowaffected = command.ExecuteNonQuery();
                return rowaffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(message: "error");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public List<Shelf> GetAll()
    {
        List<Shelf> shelfs = new List<Shelf>();
        string tableName = "dbo.Shelf";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                
                string query = $"SELECT Id,Floor,Title FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Shelf shelf = new Shelf()
                    {
                        Id = (int)reader["Id"],
                        Floor = reader["Floor"].ToString(),
                        Title = reader["Title"].ToString(),
                       
                    };
                    shelfs.Add(shelf);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(message: "error");
            }
            finally
            {
                connection.Close();
            }
            return shelfs;
        }

    }

    public Shelf GetById(int id)
    {
        Shelf shelf = null;
        string tableName = "dbo.Shelf";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName} where Id = @Id";
                SqlCommand Command = new SqlCommand(query, connection);
                Command.Parameters.AddWithValue($"Id", id);
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    shelf = new Shelf()
                    {
                        Id = (int)reader["Id"],
                        Floor = reader["Floor"].ToString(),
                        Title = reader["Title"].ToString(),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(message: "error");
            }
            finally
            {
                connection.Close();
            }
            return shelf;
        }
    }

    public bool UpdateItem(Shelf item)
    {
        string tableName = "dbo.Shelf";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName} " +
                    $"SET Floor = @Floor," +
                    $"Title = @Title," +
                   $" WHERE Id = @Id ";

            SqlCommand command = new SqlCommand(query, Connection);

            // Add parameters to the SQL command
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@Floor", item.Floor);
            command.Parameters.AddWithValue("@Title", item.Title);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception(message: "error");
            return false;
        }
        finally
        {
            Connection.Close();
        }


    }
}

