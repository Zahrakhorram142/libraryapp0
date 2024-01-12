using BaseBackend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BaseBakend.Repository;

public class BookRepository : IGenericBaseRepository<Book>
{
    // const string connectionstring = "Data Source=.;Initial Catalog=Library;Integrated Security=True;";
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDataBase"].ToString();
    public bool AddItem(Book item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Book";

                string query = $"INSERT INTO {tableName}(Name,Subject,Writer,Publishers,YearOfPublication,Edition,CreationDate,IsActive)" +
                "VALUES(@Name,@Subject,@Writer,@Publishers,@YearOfPublication,@Edition,@CreationDate,@IsActive)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Subject", item.Writer);
                command.Parameters.AddWithValue("@Writer", item.Subject);
                command.Parameters.AddWithValue("@Publishers", item.Publishers);
                command.Parameters.AddWithValue("@YearOfPublication", item.YearOfPublication);
                command.Parameters.AddWithValue("@Edition", item.Edition);
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
                string query = $"delete dbo.Book where Id =@Id";
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

    public List<Book> GetAll()
    {

        List<Book> books = new List<Book>();
        string tableName = "dbo.Book";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string query = $"SELECT Id,Name,Subject,Writer,Publishers,YearOfPublication,Edition,CreationDate,IsActive FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Writer = reader["Writer"].ToString(),
                        Subject = reader["Subject"].ToString(),
                        Publishers = reader["Publishers"].ToString(),
                        YearOfPublication = (int)reader["YearOfPublication"],
                        Edition = reader["Edition"].ToString(),
                        CreationDate = (DateTime)reader["CreationDate"],
                        IsActive = reader["IsActive"].Equals(true),


                    };
                    books.Add(book);
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
            return books;
        }
    }

    public Book GetById(int id)
    {
        Book book = null;
        string tableName = "dbo.Book";
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
                    book = new Book()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Writer = reader["Writer"].ToString(),
                        Subject = reader["Subject"].ToString(),
                        Publishers = reader["Publishers"].ToString(),
                        YearOfPublication = (int)reader["YearOfPublication"],
                        Edition = reader["Edition"].ToString(),
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
            return book;
        }
    }

    public bool UpdateItem(Book item)
    {
        string tableName = "dbo.Book";
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            string query = $"UPDATE {tableName}" +
                $"SET Name = @Name," +
                $"Writer = @Writer," +
                $"Subject = @Subject," +
                $"Publishers = @Publishers," +
                $"YearOfPublication = @YearOfPublication," +
                $"Edition = @Edition," +
                $"WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Id", item.Id);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Writer", item.Writer);
            command.Parameters.AddWithValue("@Subject", item.Subject);
            command.Parameters.AddWithValue("@Publishers", item.Publishers);
            command.Parameters.AddWithValue("@YearOfPublication", item.YearOfPublication);
            command.Parameters.AddWithValue("@Edition", item.Edition);
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
   



