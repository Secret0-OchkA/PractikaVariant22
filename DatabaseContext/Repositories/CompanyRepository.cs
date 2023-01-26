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
    public class CompanyRepository : IRepository<Company>
    {
        private readonly SqlConnection dbConnection;

        public CompanyRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(Company entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Companyes] " +
                "(" +
                $"[{nameof(Company.CountryCode)}]," +
                $"[{nameof(Company.City)}]," +
                $"[{nameof(Company.Address)}]," +
                $"[{nameof(Company.Phone)}]," +
                $"[{nameof(Company.Email)}]," +
                $"[{nameof(Company.Site)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(Company.CountryCode)}," +
                $"@{nameof(Company.City)}," +
                $"@{nameof(Company.Address)}," +
                $"@{nameof(Company.Phone)}," +
                $"@{nameof(Company.Email)}," +
                $"@{nameof(Company.Site)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(Company.CountryCode), entity.CountryCode));
            command.Parameters.Add(new SqlParameter(nameof(Company.City), entity.City));
            command.Parameters.Add(new SqlParameter(nameof(Company.Address), entity.Address));
            command.Parameters.Add(new SqlParameter(nameof(Company.Phone), entity.Phone));
            command.Parameters.Add(new SqlParameter(nameof(Company.Email), entity.Email));
            command.Parameters.Add(new SqlParameter(nameof(Company.Site), entity.Site));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Companyes] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, Company entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Companyes]" +
                " SET" +
                $" [{nameof(Company.CountryCode)}] = @{nameof(Company.CountryCode)}," +
                $" [{nameof(Company.City)}] = @{nameof(Company.City)}," +
                $" [{nameof(Company.Address)}] = @{nameof(Company.Address)}," +
                $" [{nameof(Company.Phone)}] = @{nameof(Company.Phone)}," +
                $" [{nameof(Company.Email)}] = @{nameof(Company.Email)}," +
                $" [{nameof(Company.Site)}] = @{nameof(Company.Site)}" +

                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(Company.CountryCode), entity.CountryCode));
            command.Parameters.Add(new SqlParameter(nameof(Company.City), entity.City));
            command.Parameters.Add(new SqlParameter(nameof(Company.Address), entity.Address));
            command.Parameters.Add(new SqlParameter(nameof(Company.Phone), entity.Phone));
            command.Parameters.Add(new SqlParameter(nameof(Company.Email), entity.Email));
            command.Parameters.Add(new SqlParameter(nameof(Company.Site), entity.Site));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Companyes]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Company> result = new List<Company>();

            while (await reader.ReadAsync())
            {
                var value = new Company();

                value.Id = reader.GetInt32(0);
                value.CountryCode = reader.GetInt32(1);
                value.City = reader.GetString(2);
                value.Address = reader.GetString(3);
                value.Phone = reader.GetString(4);
                value.Email = reader.GetString(5);
                value.Site = reader.GetString(6);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<Company> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Companyes] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            Company result = new Company();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.CountryCode = reader.GetInt32(1);
            result.City = reader.GetString(2);
            result.Address = reader.GetString(3);
            result.Phone = reader.GetString(4);
            result.Email = reader.GetString(5);
            result.Site = reader.GetString(6);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
