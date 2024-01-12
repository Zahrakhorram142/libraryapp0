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

public class MemberRepository : IGenericBaseRepository<Member>
{
    // const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();
    public bool AddItem(Member item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Member";

                string query = $"INSERT INTO {tableName}(NationalCode,FirstName,LastName,PhoneNumber,BirthDate,MembershipDate,CreationDate,IsActive)" +
                "VALUES(@NationalCode,@FirstName,@LastName,@PhoneNumber,BirthDate,@MembershipDate,@CreationDate,@IsActive)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@MembershipDate", item.MembershipDate);
                command.Parameters.AddWithValue("@CreationDate", item.CreationDate);
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
                string query = $"delete dbo.Member where Id =@Id";
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

    public List<Member> GetAll()
    {
        List<Member> members = new List<Member>();
        string tableName = "dbo.Member";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                
                string query = $"SELECT Id,NationalCode,FirstName,LastName,PhoneNumber,BirthDate,MembershipDate,IsActive,CreationDate FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new Member()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        BirthDate = (DateTime)reader["BirthDate"],
                        MembershipDate = (DateTime)reader["MembershipDate"],
                        IsActive = reader["IsActive"].Equals(true),
                        CreationDate = (DateTime)reader["CreationDate"],

                    };
                    members.Add(member);
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
            return members;
        }

    }

public Member GetById(int id)
    {
        Member member = null;
        string tableName = "dbo.Member";
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
                    member = new Member()
                    {
                        Id = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        MembershipDate = (DateTime)reader["MembershipDate"],
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
            return member;
        }
    }

    public bool UpdateItem(Member item)
    {
        string tableName = "dbo.Member";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName}" +
                $"SET NationalCode = @NationalCode," +
                $"FirstName = @FirstName," +
                $"LastName = @LastName," +
                $"PhoneNumber = @PhoneNumber," +
                $"BirthDate = @BirthDate," +
                $"MembershipDate = @MembershipDate," +
                $"WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@LastName", item.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
            command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
            command.Parameters.AddWithValue("@MembershipDate", item.MembershipDate);
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

