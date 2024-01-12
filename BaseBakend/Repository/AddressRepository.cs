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

public class AddressRepository : IGenericBaseRepository<Address>
{
    //const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();
    public bool AddItem(Address item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {

                connection.Open();
                string tableName = "dbo.Address";
                
                string query = $"INSERT INTO {tableName}(PersonId,City,Street,FullAddress,Pelak,PostalCode,IsActive,CreationDate)" +
                "VALUES(@PersonId,@City,@Street,@FullAddress,@Pelak,@PostalCode,@IsActive,@CreationDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonId", item.PersonId);
                command.Parameters.AddWithValue("@City", item.City);
                command.Parameters.AddWithValue("@Street", item.Street);
                command.Parameters.AddWithValue("@FullAddress", item.FullAddress);
                command.Parameters.AddWithValue("@Pelak", item.Pelak);
                command.Parameters.AddWithValue("@PostalCode", item.PostalCode);
                command.Parameters.AddWithValue("@IsActive", item.IsActive);
                command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(message: "error",ex);
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
                string query = $"delete dbo.Address where Id =@Id";
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

    public List<Address> GetAll()
    {
        List<Address> addresses = new List<Address>();
        string tableName = "dbo.Address";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                //string query = $"SELECT Id,FirstName,LastName,PhoneNumber FROM{tableName}";
                string query = $"SELECT Id,PersonId,City,Street,FullAddress,Pelak,PostalCode,IsActive,CreationDate FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Address address = new Address()
                    {
                        Id = (int)reader["Id"],
                        PersonId = (int)reader["PersonId"],
                        City = reader["City"].ToString(),
                        Street = reader["Street"].ToString(),
                        FullAddress = reader["FullAddress"].ToString(),
                        Pelak = reader["Pelak"].ToString(),
                        PostalCode = reader["PostalCode"].ToString(),
                        IsActive = reader["IsActive"].Equals(true),
                        CreationDate = (DateTime)reader["CreationDate"],


                    };
                    addresses.Add(address);
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
            return addresses;
        }

    }

    public Address GetById(int id)
    {
        Address address = null;
        string tableName = "dbo.Address";
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
                    address = new Address()
                    {
                        Id = (int)reader["Id"],
                        PersonId = (int)reader["PersonId"],
                        City = reader["City"].ToString(),
                        Street = reader["Street"].ToString(),
                        FullAddress = reader["FullAddress"].ToString(),
                        Pelak = reader["Pelak"].ToString(),
                        PostalCode = reader["PostalCode"].ToString(),
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
            return address;
        }
    }

    public bool UpdateItem(Address item)
    {
        string tableName = "dbo.Address";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName} " +
                    $"SET PersonId = @PersonId," +
                    $"City = @City," +
                    $"Street=@Street," +
                    $"FullAddress = @FullAddress," +
                     $"Pelak = @Pelak," +
                     $"PostalCode = @PostalCode," +
                     $"CreationDate = @CreationDate," +
                     $" WHERE Id = @Id ";
            SqlCommand command = new SqlCommand(query, Connection);

            // Add parameters to the SQL command
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@PersonId", item.PersonId);
            command.Parameters.AddWithValue("@City", item.City);
            command.Parameters.AddWithValue("@Street", item.Street);
            command.Parameters.AddWithValue("@FullAddress", item.FullAddress);
            command.Parameters.AddWithValue("@Pelak", item.Pelak);
            command.Parameters.AddWithValue("@PostalCode", item.PostalCode);
            command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
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

