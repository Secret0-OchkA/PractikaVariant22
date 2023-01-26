using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        private readonly SqlConnection dbConnection;

        public DepartmentRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(Department entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Departments] " +
                "(" +
                $"[{nameof(Department.Name)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(Department.Name)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(Department.Name), entity.Name));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Departments] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, Department entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Departments]" +
                " SET" +
                $" [{nameof(Department.Name)}] = @{nameof(Department.Name)}" +

                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(Department.Name), entity.Name));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Departments]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Department> result = new List<Department>();

            while (await reader.ReadAsync())
            {
                var value = new Department();

                value.Id = reader.GetInt32(0);
                value.Name = reader.GetString(1);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<Department> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Departments] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            Department result = new Department();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.Name = reader.GetString(1);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
