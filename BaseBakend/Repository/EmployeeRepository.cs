
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

public class EmployeeRepository : IGenericBaseRepository<Employee>
{
    //const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();
    struct t
    {
        public int Id;
    }
    public bool AddItem(Employee item)
    {
        // var cs=ConfigurationManager.ConnectionStrings["ConnectionString"];
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Employee";

                string query = $"INSERT INTO {tableName}(NationalCode,FirstName,LastName,PhoneNumber,JobTitle,EmployeementDate,CreationDate,IsActive,BirthDate)" +
                "VALUES(@NationalCode,@FirstName,@LastName,@PhoneNumber,@JobTitle,@EmployeementDate,@CreationDate,@IsActive,@BirthDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@JobTitle", item.JobTitle);
                command.Parameters.AddWithValue("@EmployeementDate", item.EmployeementDate);
                command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
                command.Parameters.AddWithValue("@IsActive", item.IsActive);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
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
                string query = $"delete dbo.Employee where Id =@Id";
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

    public List<Employee> GetAll()
    {
        List<Employee> employees = new List<Employee>();
        string tableName = "dbo.Employee";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                //string query = $"SELECT Id,FirstName,LastName,PhoneNumber FROM{tableName}";
                string query = $"SELECT Id,NationalCode,FirstName,LastName,PhoneNumber,BirthDate,JobTitle,EmployeementDate,CreationDate,IsActive FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        BirthDate = (DateTime)reader["BirthDate"],
                        JobTitle = reader["JobTitle"].ToString(),
                        EmployeementDate = (DateTime)reader["EmployeementDate"],
                        CreationDate = (DateTime)reader["CreationDate"],
                        IsActive = reader["IsActive"].Equals(true),
                                                
                    };
                    employees.Add(employee);
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
            return employees;
        }

    }

    public Employee GetById(int id)
    {
        Employee employee = null;
        string tableName = "dbo.Employee";
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
                    employee = new Employee()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        JobTitle = reader["JobTitle"].ToString(),
                        EmployeementDate = (DateTime)reader["EmployeementDate"],
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
            return employee;
        }
    }

    public bool UpdateItem(Employee item)
    {
        string tableName = "dbo.Employee";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName}" +
                $"SET NationalCode = @NationalCode, " +
                $"FirstName = @FirstName," +
                $"LastName=@LastName," +
                $"PhoneNumber = @PhoneNumber," +
                $"BirthDate = @BirthDate," +
                $"JobTitle = @JobTitle," +
                $"EmployeementDate = @EmployeementDate," +
                $"CreationDate = @CreationDate," +
                $"GenderId = @GenderId," +
                $"WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@LastName", item.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
            command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
            command.Parameters.AddWithValue("@JobTitle", item.JobTitle);
            command.Parameters.AddWithValue("@EmployeementDate", item.EmployeementDate);
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

