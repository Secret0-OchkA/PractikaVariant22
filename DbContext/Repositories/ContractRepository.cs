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
    public class ContractRepository : IRepository<Contract>
    {
        private readonly SqlConnection dbConnection;

        public ContractRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(Contract entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Contacts] " +
                "(" +
                $"[{nameof(Contract.CompanyId)}]," +
                $"[{nameof(Contract.DateCreate)}]," +
                $"[{nameof(Contract.Price)}]," +
                $"[{nameof(Contract.Valid)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(Contract.CompanyId)}," +
                $"@{nameof(Contract.DateCreate)}," +
                $"@{nameof(Contract.Price)}," +
                $"@{nameof(Contract.Valid)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(Contract.CompanyId), entity.CompanyId));
            command.Parameters.Add(new SqlParameter(nameof(Contract.DateCreate), entity.DateCreate);
            command.Parameters.Add(new SqlParameter(nameof(Contract.Price), entity.Price));
            command.Parameters.Add(new SqlParameter(nameof(Contract.Valid), entity.Valid));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Contacts] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, Contract entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Contacts]" +
                " SET" +
                $" [{nameof(Contract.CompanyId)}] = @{nameof(Contract.CompanyId)}," +
                $" [{nameof(Contract.DateCreate)}] = @{nameof(Contract.DateCreate)}," +
                $" [{nameof(Contract.Price)}] = @{nameof(Contract.Price)}," +
                $" [{nameof(Contract.Valid)}] = @{nameof(Contract.Valid)}" +
                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(Contract.CompanyId), entity.CompanyId));
            command.Parameters.Add(new SqlParameter(nameof(Contract.DateCreate), entity.DateCreate);
            command.Parameters.Add(new SqlParameter(nameof(Contract.Price), entity.Price));
            command.Parameters.Add(new SqlParameter(nameof(Contract.Valid), entity.Valid));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<Contract>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Contacts]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Contract> result = new List<Contract>();

            while (await reader.ReadAsync())
            {
                var value = new Contract();

                value.Id = reader.GetInt32(0);
                value.CompanyId = reader.GetInt32(1);
                value.DateCreate = reader.GetDateTime(2);
                value.Price = reader.GetDecimal(3);
                value.Valid = reader.GetBoolean(4);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<Contract> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Contacts] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            Contract result = new Contract();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.CompanyId = reader.GetInt32(1);
            result.DateCreate = reader.GetDateTime(2);
            result.Price = reader.GetDecimal(3);
            result.Valid = reader.GetBoolean(4);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
