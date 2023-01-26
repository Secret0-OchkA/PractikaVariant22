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
    public class EmployeeContractsRepository : IRepository<EmployeeContracts>
    {
        private readonly SqlConnection dbConnection;

        public EmployeeContractsRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(EmployeeContracts entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[EmployeesContracts] " +
                "(" +
                $"[{nameof(EmployeeContracts.EmployeeId)}]," +
                $"[{nameof(EmployeeContracts.ContractId)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(EmployeeContracts.EmployeeId)}," +
                $"@{nameof(EmployeeContracts.ContractId)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(EmployeeContracts.EmployeeId), entity.EmployeeId));
            command.Parameters.Add(new SqlParameter(nameof(EmployeeContracts.ContractId), entity.ContractId));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[EmployeesContracts] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, EmployeeContracts entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[EmployeesContracts]" +
                " SET" +
                $" [{nameof(EmployeeContracts.EmployeeId)}] = @{nameof(EmployeeContracts.EmployeeId)}," +
                $" [{nameof(EmployeeContracts.ContractId)}] = @{nameof(EmployeeContracts.ContractId)}" +

                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(EmployeeContracts.EmployeeId), entity.EmployeeId));
            command.Parameters.Add(new SqlParameter(nameof(EmployeeContracts.ContractId), entity.ContractId));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<EmployeeContracts>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[EmployeesContracts]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<EmployeeContracts> result = new List<EmployeeContracts>();

            while (await reader.ReadAsync())
            {
                var value = new EmployeeContracts();

                value.Id = reader.GetInt32(0);
                value.EmployeeId = reader.GetInt32(1);
                value.ContractId = reader.GetInt32(2);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<EmployeeContracts> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[EmployeesContracts] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            EmployeeContracts result = new EmployeeContracts();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.EmployeeId = reader.GetInt32(1);
            result.ContractId = reader.GetInt32(2);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
