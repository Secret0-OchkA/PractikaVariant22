using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Text.RegularExpressions;

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
            if (DepartmentId <= 0) throw new ValidateException("Invalid department");
            if (Name == null) throw new ValidateException("Invalid Name");
            if (Name.Equals(string.Empty)) throw new ValidateException("Emppty name");
            if (Position == null) throw new ValidateException("null Position");
            if (Position.Equals(string.Empty)) throw new ValidateException("Empty Position");
            if (Salary <= 0) throw new ValidateException("Salary <= 0");
            if (Price <= 0) throw new ValidateException("Price <= 0");
            if (Month <= 0) throw new ValidateException("Month <= 0");
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
            Regex emailReg = new Regex(@"^\w.\@\w.\.\w.");

            if (!emailReg.IsMatch(Email)) throw new ValidateException("invalid email");
        }
    }

    public class Contract : IHaveId, IValidateObject
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        public bool Valid { get; set; }
        public int EmployeeId { get; set; }

        public void Validate()
        {
            if (CompanyId <= 0) throw new ValidateException("Invalid Company");
            if (EmployeeId <= 0) throw new ValidateException("Invalid Employee");
            if (Price <= 0) throw new ValidateException("Price <= 0");
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
        public int Role { get; set; }

        public void Validate()
        {
            if (Name == null) throw new ValidateException("empty name");
            if (Name.Equals(string.Empty)) throw new ValidateException("empty name");

            if (Email == null) throw new ValidateException("empty email");
            if (Email.Equals(string.Empty)) throw new ValidateException("empty email");

            if (Password == null) throw new ValidateException("empty password");
            if (Password.Equals(string.Empty)) throw new ValidateException("empty password");
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
