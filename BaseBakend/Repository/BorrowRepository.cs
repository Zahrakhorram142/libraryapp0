
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

public class BorrowRepository : IGenericBaseRepository<Borrow>
{
    //const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();
    public bool AddItem(Borrow item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Borrow";

                string query = $"INSERT INTO {tableName}(BorrowedBookName,BorrowingDate,ReturnDate)" +
                "VALUES(@BorrowedBookName,@BorrowingDate,@ReturnDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowedBookName", item.BorrowedBookName);
                command.Parameters.AddWithValue("@BorrowingDate", item.BorrowingDate);
                command.Parameters.AddWithValue("@ReturnDate", item.ReturnDate);
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
                string query = $"delete dbo.Borrow where Id =@Id";
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

    public List<Borrow> GetAll()
    {

        List<Borrow> borrows = new List<Borrow>();
        string tableName = "dbo.Borrow";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"SELECT Id,BorrowedBookName,BorrowingDate,ReturnDate FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Borrow borrow = new Borrow()
                    {
                        Id = (int)reader["Id"],
                        BorrowedBookName = reader["BorrowedBookName"].ToString(),
                        BorrowingDate = (DateTime)reader["BorrowingDate"],
                        ReturnDate = (DateTime)reader["ReturnDate"],
                    };
                    borrows.Add(borrow);
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
            return borrows;
        }

    }

    public Borrow GetById(int id)
    {
        Borrow borrow = null;
        string tableName = "dbo.Borrow";
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
                    borrow = new Borrow()
                    {
                        Id = (int)reader["Id"],
                        BorrowedBookName = reader["BorrowedBookName"].ToString(),
                        BorrowingDate = (DateTime)reader["BorrowingDate"],
                        ReturnDate = (DateTime)reader["ReturnDate"],
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
            return borrow;
        }
    }

    public bool UpdateItem(Borrow item)
    {
        string tableName = "dbo.Borrow";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName}" +
                $"SET BorrowedBookName = @BorrowedBookName," +
                $"BorrowingDate = @BorrowingDate," +
                $"ReturnDate = @ReturnDate," +
                $"WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@BorrowedBookName", item.BorrowedBookName);
            command.Parameters.AddWithValue("@BorrowingDate", item.BorrowingDate);
            command.Parameters.AddWithValue("@ReturnDate", item.ReturnDate);
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

