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
    public class Department : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Validate()
        {
             
        }
    }

    public class Employee : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public decimal Price { get; set; }
        public int Month { get; set; }

        public void Validate()
        {
             
        }
    }

    public class Company : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }//NULL

        public void Validate()
        {
             
        }
    }

    public class Contract : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        public bool Valid { get; set; }

        public void Validate()
        {
             
        }
    }

    public class Deliverie : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string EquipmentType { get; set; }
        public string Description { get; set; }// NULL
        public int EmployeeId { get; set; }

        public void Validate()
        {
             
        }
    }

    public class User : IHaveId, IValidateObject
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
             
        }
    }

    public class EmployeeContracts : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ContractId { get; set; }

        public void Validate()
        {
             
        }
    }
}
