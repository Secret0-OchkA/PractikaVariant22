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
    public class DeliverieRepository : IRepository<Deliverie>
    {
        private readonly SqlConnection dbConnection;

        public DeliverieRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(Deliverie entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Deliveries] " +
                "(" +
                $"[{nameof(Deliverie.ContractId)}]," +
                $"[{nameof(Deliverie.EquipmentType)}]," +
                $"[{nameof(Deliverie.Description)}]," +
                $"[{nameof(Deliverie.EmployeeId)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(Deliverie.ContractId)}," +
                $"@{nameof(Deliverie.EquipmentType)}," +
                $"@{nameof(Deliverie.Description)}," +
                $"@{nameof(Deliverie.EmployeeId)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(Deliverie.ContractId), entity.ContractId));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.EquipmentType), entity.EquipmentType));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.Description), entity.Description));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.EmployeeId), entity.EmployeeId));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Deliveries] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, Deliverie entity)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Deliveries]" +
                " SET" +
                $" [{nameof(Deliverie.ContractId)}] = @{nameof(Deliverie.ContractId)}," +
                $" [{nameof(Deliverie.EquipmentType)}] = @{nameof(Deliverie.EquipmentType)}," +
                $" [{nameof(Deliverie.Description)}] = @{nameof(Deliverie.Description)}," +
                $" [{nameof(Deliverie.EmployeeId)}] = @{nameof(Deliverie.EmployeeId)}" +
                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.ContractId), entity.ContractId));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.EquipmentType), entity.EquipmentType));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.Description), entity.Description));
            command.Parameters.Add(new SqlParameter(nameof(Deliverie.EmployeeId), entity.EmployeeId));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<Deliverie>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Deliveries]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Deliverie> result = new List<Deliverie>();

            while (await reader.ReadAsync())
            {
                var value = new Deliverie();

                value.Id = reader.GetInt32(0);
                value.ContractId = reader.GetInt32(1);
                value.EquipmentType = reader.GetString(2);
                value.Description = reader.GetString(3);
                value.EmployeeId = reader.GetInt32(4);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<Deliverie> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Deliveries] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            Deliverie result = new Deliverie();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.ContractId = reader.GetInt32(1);
            result.EquipmentType = reader.GetString(2);
            result.Description = reader.GetString(3);
            result.EmployeeId = reader.GetInt32(4);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
