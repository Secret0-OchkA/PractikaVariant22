using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Domain
{
    public class Department : IHaveId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee : IHaveId
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public decimal Price { get; set; }
        public int Month { get; set; }
    }

    public class Company : IHaveId
    {
        public int Id { get; set; }
        public int CoutnryCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }//NULL
    }

    public class Contract : IHaveId
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        public bool Valid { get; set; }
    }

    public class Deliverie : IHaveId
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string EquipmentType { get; set; }
        public string Description { get; set; }// NULL
        public int EmployeeId { get; set; }
    }

    public class User : IHaveId
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class EmployeeContracts : IHaveId
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ContractId { get; set; }
    }
}
