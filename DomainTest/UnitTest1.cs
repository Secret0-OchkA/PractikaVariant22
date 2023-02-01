using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DomainTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ValidateEmployee1()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = -1,
                Name = "name",
                Position = "position",
                Salary = 10,
                Price = 10,
                Month = 1
            }.Validate());
        }
        [TestMethod]
        public void ValidateEmployee2()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = 1,
                Name = null,
                Position = "position",
                Salary = 10,
                Price = 10,
                Month = 1
            }.Validate());
        }
        [TestMethod]
        public void ValidateEmployee3()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = 1,
                Name = "name",
                Position = null,
                Salary = 10,
                Price = 10,
                Month = 1
            }.Validate());
        }
        [TestMethod]
        public void ValidateEmployee4()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = 1,
                Name = "name",
                Position = "position",
                Salary = -10,
                Price = 10,
                Month = 1
            }.Validate());
        }
        [TestMethod]
        public void ValidateEmployee5()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = 1,
                Name = "name",
                Position = "position",
                Salary = 10,
                Price = -10,
                Month = 1
            }.Validate());
        }
        [TestMethod]
        public void ValidateEmployee6()
        {
            Assert.ThrowsException<ValidateException>(() => new Employee()
            {
                DepartmentId = 1,
                Name = "name",
                Position = "position",
                Salary = 10,
                Price = 10,
                Month = -1
            }.Validate());
        }
    }
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ValidateUser1()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = null,
                Email = "email",
                Password = "password",
            }.Validate());
        }
        [TestMethod]
        public void ValidateUser2()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = "name",
                Email = null,
                Password = "password",
            }.Validate());
        }
        [TestMethod]
        public void ValidateUser3()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = "name",
                Email = "email",
                Password = null,
            }.Validate());
        }
        [TestMethod]
        public void ValidateUser4()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = "",
                Email = "email",
                Password = "password",
            }.Validate());
        }
        [TestMethod]
        public void ValidateUser5()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = "name",
                Email = "",
                Password = "password",
            }.Validate());
        }
        [TestMethod]
        public void ValidateUser6()
        {
            Assert.ThrowsException<ValidateException>(() => new User()
            {
                Name = "name",
                Email = "email",
                Password = "",
            }.Validate());
        }
    }
}
