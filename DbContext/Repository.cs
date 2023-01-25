
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace Infrastructura
{
    public interface IRepository<T> 
        where T : class, IHaveId
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }

    //public class BookRepository : IRepository<Book>
    //{
    //    private readonly SqlConnection dbConnection;

    //    public BookRepository(SqlConnection dbConnection)
    //    {
    //        this.dbConnection = dbConnection;
    //    }

    //    public async Task CreateAsync(Book entity)
    //    {
    //        await dbConnection.OpenAsync();

    //        SqlParameter nameParam = new SqlParameter(nameof(Book.Name), entity.Name);
    //        SqlParameter authorParam = new SqlParameter(nameof(Book.Author), entity.Author);

    //        var command = new SqlCommand("INSERT INTO [dbo].[Books] ([Name],[Author])" +
    //            "VALUES (@Name,@Author)", dbConnection);

    //        command.Parameters.Add(nameParam);
    //        command.Parameters.Add(authorParam);

    //        await command.ExecuteNonQueryAsync();
    //        dbConnection.Close();
    //    }

    //    public async Task DeleteAsync(int id)
    //    {
    //        await dbConnection.OpenAsync();

    //        SqlParameter idParam = new SqlParameter(nameof(Book.Id), id);

    //        var command = new SqlCommand($"DELETE FROM [dbo].[Books] WHERE [Id] = @Id", dbConnection);

    //        command.Parameters.Add(idParam);

    //        await command.ExecuteNonQueryAsync();

    //        dbConnection.Close();
    //    }

    //    public async Task UpdateAsync(int id, Book entity)
    //    {
    //        await dbConnection.OpenAsync();

    //        var command = new SqlCommand($"UPDATE [dbo].[Books]" +
    //            $" SET [Name] = @Name, [Author] = @Author" +
    //            $" WHERE [Id] = @Id", dbConnection);

    //        command.Parameters.Add(new SqlParameter(nameof(Book.Id), id));
    //        command.Parameters.Add(new SqlParameter(nameof(Book.Name), entity.Name));
    //        command.Parameters.Add(new SqlParameter(nameof(Book.Author), entity.Author));

    //        await command.ExecuteNonQueryAsync();

    //        dbConnection.Close();
    //    }

    //    public async Task<IEnumerable<Book>> GetAllAsync()
    //    {
    //        await dbConnection.OpenAsync();

    //        var command = new SqlCommand("SELECT * FROM [dbo].[Books]",dbConnection);
    //        SqlDataReader reader = await command.ExecuteReaderAsync();
            
    //        List<Book> result = new List<Book>();
 
    //        while (await reader.ReadAsync())
    //        {
    //            var value = new Book();

    //            value.Id = reader.GetInt32(0);
    //            value.Name = reader.GetString(1);
    //            value.Author = reader.GetString(2);

    //            result.Add(value);
    //        }
           
    //        reader.Close();
    //        dbConnection.Close();

    //        return result;
    //    }

    //    public async Task<Book> GetAsync(int id)
    //    {
    //        await dbConnection.OpenAsync();

    //        var command = new SqlCommand($"SELECT * FROM [dbo].[Books] WHERE Id = @Id", dbConnection);

    //        command.Parameters.Add(new SqlParameter(nameof(Book.Id), id));

    //        SqlDataReader reader = await command.ExecuteReaderAsync();

    //        Book result = new Book();

    //        await reader.ReadAsync();

    //        result.Id = reader.GetInt32(0);
    //        result.Name = reader.GetString(1);
    //        result.Author = reader.GetString(2);
            
    //        reader.Close();
    //        dbConnection.Close();

    //        return result;
    //    }
    //}
}