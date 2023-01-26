using Domain;
using Infrastructura.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura
{
    public static class DbContext
    {
        public static IRepository<Employee> Employees { get; }
        public static IRepository<Department> Departments { get; }
        public static IRepository<Company> Companyes { get; }
        public static IRepository<User> Users { get; }
        public static IRepository<Contract> Contracts { get; }
        public static IRepository<Deliverie> Deliveries { get; }

        const string connectionString = "Server=localhost,1433;Database=practikaVar22;User Id=sa;Password=Secretochka2442;Encrypt=false;TrustServerCertificate=true";
        readonly static SqlConnection dbConnection;

        static DbContext()
        {
            dbConnection = new SqlConnection(connectionString);

            Employees = new EmployeeRepository(dbConnection);
            Departments = new DepartmentRepository(dbConnection);
            Companyes = new CompanyRepository(dbConnection);
            Users = new UserRepository(dbConnection);
            Contracts = new ContractRepository(dbConnection);
            Deliveries = new DeliverieRepository(dbConnection);
        }


    }
}
