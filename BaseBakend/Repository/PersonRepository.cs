using BaseBackend.Contract;
using BaseBackend.Enums;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BaseBakend.Repository;

public class PersonRepository : IGenericBaseRepository<Person>
{
    //const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();

    public bool AddItem(Person item)

    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();


                string tableName = "dbo.Person";

                string query = $"INSERT INTO {tableName}(GenderId,NationalCode,FirstName,LastName,PhoneNumber,BirthDate,CreationDate,IsAdmin,IsActive)" +
                "VALUES(@GenderId,@NationalCode,@FirstName,@LastName,@PhoneNumber,@BirthDate,@CreationDate,@IsAdmin,@IsActive)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GenderId", (short)item.Gender);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
                command.Parameters.AddWithValue("@IsAdmin", item.IsAdmin);
                command.Parameters.AddWithValue("@IsActive", item.IsActive);
              
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
                string query = $"delete dbo.Person where Id =@Id";
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
    public List<Person> GetAll()
    {
        List<Person> persons = new List<Person>();
        string tableName = "dbo.Person";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string query = $"SELECT Id,NationalCode,FirstName,LastName,PhoneNumber,CreationDate,BirthDate,IsActive,IsAdmin FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new Person()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        CreationDate = (DateTime)reader["CreationDate"],
                        BirthDate = (DateTime)reader["BirthDate"],
                        IsActive = reader["IsActive"].Equals(true),
                        IsAdmin = reader["IsAdmin"].Equals(true),
                       // Gender = ()reader["Gender"],
                    };
                    persons.Add(person);
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
            return persons;
        }

    }



    public Person GetById(int id)
    {
        Person person = null;
        string tableName = "dbo.Person";
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
                    person = new Person()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
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
            return person;
        }
    }

    public bool UpdateItem(Person item)
    {
        string tableName = "dbo.Person";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE dbo.Person " +
                    $"SET NationalCode = @NationalCode," +
                    $"FirstName = @FirstName," +
                    $"LastName=@LastName," +
                    $"PhoneNumber = @PhoneNumber," +
                     $"BirthDate = @BirthDate," +
                     $"CreationDate = @CreationDate," +
                    $"GenderId = @GenderId" +
                    $" WHERE Id = @Id ";
            SqlCommand command = new SqlCommand(query, Connection);

            // Add parameters to the SQL command
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@LastName", item.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
            command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
            command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
            command.Parameters.AddWithValue("@GenderId", (short)item.Gender);
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








