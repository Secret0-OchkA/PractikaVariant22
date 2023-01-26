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
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly SqlConnection dbConnection;

        public EmployeeRepository(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task CreateAsync(Employee entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand("INSERT INTO" +
                $" [dbo].[Employees] " +
                "(" +
                $"[{nameof(Employee.DepartmentId)}]," +
                $"[{nameof(Employee.Name)}]," +
                $"[{nameof(Employee.Position)}]," +
                $"[{nameof(Employee.Salary)}]," +
                $"[{nameof(Employee.Price)}]," +
                $"[{nameof(Employee.Month)}]" +
                ")" +
                "VALUES " +
                "(" +
                $"@{nameof(Employee.DepartmentId)}," +
                $"@{nameof(Employee.Name)}," +
                $"@{nameof(Employee.Position)}," +
                $"@{nameof(Employee.Salary)}," +
                $"@{nameof(Employee.Price)}," +
                $"@{nameof(Employee.Month)}" +
                ")", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(Employee.DepartmentId), entity.DepartmentId));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Name), entity.Name));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Position), entity.Position));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Salary), entity.Salary));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Price), entity.Price));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Month), entity.Month));

            await command.ExecuteNonQueryAsync();
            dbConnection.Close();
        }

        public async Task DeleteAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"DELETE FROM [dbo].[Employees] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task UpdateAsync(int id, Employee entity)
        {
            entity.Validate();
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"UPDATE [dbo].[Employees]" +
                " SET" +
                $" [{nameof(Employee.DepartmentId)}] = @{nameof(Employee.DepartmentId)}," +
                $" [{nameof(Employee.Name)}] = @{nameof(Employee.Name)}," +
                $" [{nameof(Employee.Position)}] = @{nameof(Employee.Position)}," +
                $" [{nameof(Employee.Salary)}] = @{nameof(Employee.Salary)}," +
                $" [{nameof(Employee.Price)}] = @{nameof(Employee.Price)}," +
                $" [{nameof(Employee.Month)}] = @{nameof(Employee.Month)}" +

                $" WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));
            command.Parameters.Add(new SqlParameter(nameof(Employee.DepartmentId), entity.DepartmentId));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Name), entity.Name));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Position), entity.Position));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Salary), entity.Salary));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Price), entity.Price));
            command.Parameters.Add(new SqlParameter(nameof(Employee.Month), entity.Month));

            await command.ExecuteNonQueryAsync();

            dbConnection.Close();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand("SELECT * FROM [dbo].[Employees]", dbConnection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Employee> result = new List<Employee>();

            while (await reader.ReadAsync())
            {
                var value = new Employee();

                value.Id = reader.GetInt32(0);
                value.DepartmentId = reader.GetInt32(1);
                value.Name = reader.GetString(2);
                value.Position = reader.GetString(3);
                value.Salary = reader.GetDecimal(4);
                value.Price = reader.GetDecimal(5);
                value.Month = reader.GetInt32(6);

                result.Add(value);
            }

            reader.Close();
            dbConnection.Close();

            return result;
        }

        public async Task<Employee> GetAsync(int id)
        {
            await dbConnection.OpenAsync();

            var command = new SqlCommand($"SELECT * FROM [dbo].[Employees] WHERE [{nameof(IHaveId.Id)}] = @{nameof(IHaveId.Id)}", dbConnection);

            command.Parameters.Add(new SqlParameter(nameof(IHaveId.Id), id));

            SqlDataReader reader = await command.ExecuteReaderAsync();

            Employee result = new Employee();

            await reader.ReadAsync();

            result.Id = reader.GetInt32(0);
            result.DepartmentId = reader.GetInt32(1);
            result.Name = reader.GetString(2);
            result.Position = reader.GetString(3);
            result.Salary = reader.GetDecimal(4);
            result.Price = reader.GetDecimal(5);
            result.Month = reader.GetInt32(6);

            reader.Close();
            dbConnection.Close();

            return result;
        }
    }
}
