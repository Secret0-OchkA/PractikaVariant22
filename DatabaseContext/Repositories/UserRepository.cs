using Domain;
using Infrastructura;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly SqlConnection dbConnection;

        public UserRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(User entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Users] " +
                "(" +
                $"[{nameof(User.Name)}]," +
                $"[{nameof(User.Email)}]," +
                $"[{nameof(User.Password)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(User.Name)}," +
                $"@{nameof(User.Email)}," +
                $"@{nameof(User.Password)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(User.Name), entity.Name));
            command.Parameters.Add(new SqlParameter(nameof(User.Email), entity.Email));
            command.Parameters.Add(new SqlParameter(nameof(User.Password), entity.Password));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Users] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, User entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Users]" +
                " SET" +
                $" [{nameof(User.Name)}] = @{nameof(User.Name)}," +
                $" [{nameof(User.Email)}] = @{nameof(User.Email)}," +
                $" [{nameof(User.Password)}] = @{nameof(User.Password)}" +

                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(User.Name), entity.Name));
            command.Parameters.Add(new SqlParameter(nameof(User.Email), entity.Email));
            command.Parameters.Add(new SqlParameter(nameof(User.Password), entity.Password));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Users]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<User> result = new List<User>();

            while (await reader.ReadAsync())
            {
                var value = new User();

                value.Id = reader.GetInt32(0);
                value.Name = reader.GetString(1);
                value.Email = reader.GetString(2);
                value.Password = reader.GetString(3);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<User> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Users] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            User result = new User();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.Name = reader.GetString(1);
            result.Email = reader.GetString(2);
            result.Password = reader.GetString(3);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
