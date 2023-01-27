
using Domain;
using Infrastructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaVariant22.RoleWindows
{
    public partial class UserWindow : Form
    {
        private readonly Form parent;
        IRepository<Department> departmentRepository = DbContext.Departments;
        public UserWindow(Form parent)
        {
            InitializeComponent();
            this.parent = parent;

            comboBox_Employee_Department.DisplayMember = nameof(Department.Name);
            comboBox_Employee_Department.ValueMember = nameof(IHaveId.Id);

            comboBox_Company.DisplayMember = nameof(Company.Address);
            comboBox_Company.ValueMember = nameof(IHaveId.Id);

            comboBox_Contract.DisplayMember = nameof(Contract.DateCreate);
            comboBox_Contract.ValueMember = nameof(IHaveId.Id);

            comboBox_Employees.DisplayMember = nameof(Employee.Name);
            comboBox_Employees.ValueMember = nameof(IHaveId.Id);
        }

        private void UserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private async void button_Create_Department_Click(object sender, EventArgs e)
        {
            await departmentRepository.CreateAsync(new Department() { Name = textBox_DepartmentName.Text });
        }

        private async void button_Create_Employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Name = textBox_Employee_Name.Text,
                DepartmentId = (int)comboBox_Employee_Department.SelectedValue,
                Position = textBox_Employee_Position.Text,
                Price = numericUpDown_Emp_Price.Value,
                Month = (int)numericUpDown_Emp_Month.Value,
                Salary = numericUpDown_Emp_Salary.Value,
            };

            await DbContext.Employees.CreateAsync(employee);
        }

        private async void UserWindow_Load(object sender, EventArgs e)
        {
            IEnumerable<Employee> employees = await DbContext.Employees.GetAllAsync();
            dataGridView_Emp.DataSource = employees;
            comboBox_Employees.DataSource = employees;

            IEnumerable<Department> list = await departmentRepository.GetAllAsync();
            comboBox_Employee_Department.DataSource = list;

            IEnumerable<Company> companies = await DbContext.Companyes.GetAllAsync();
            comboBox_Company.DataSource = companies;

            dataGridView_Company.DataSource = companies;

            IEnumerable<Contract> contracts = await DbContext.Contracts.GetAllAsync();
            dataGridView_Contracts.DataSource = contracts;
            comboBox_Contract.DataSource = contracts;

            IEnumerable<Deliverie> deliveries = await DbContext.Deliveries.GetAllAsync();
            dataGridView_Deliveries.DataSource = deliveries;
        }

        private async void button_CreateContract_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract()
            {
                CompanyId = (int)comboBox_Company.SelectedValue,
                DateCreate = dateTimePicker_DateCreate.Value,
                Price = numericUpDown_Emp_Price.Value,
                Valid = false,
                EmployeeId = (int)comboBox_Employees.SelectedValue
            };
            await DbContext.Contracts.CreateAsync(contract);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private async void button_Create_Company_Click(object sender, EventArgs e)
        {
            Company company = new Company()
            {
                Address = textBox_Address.Text,
                City = textBox_City.Text,
                Phone = maskedTextBox_Phone.Text,
                CountryCode = (int)numericUpDown_CoutryCode.Value,
                Email = textBox_Email.Text,
                Site = textBox_Site.Text,
            };
            await DbContext.Companyes.CreateAsync(company);
        }

        private async void button_Create_Delivery_Click(object sender, EventArgs e)
        {
            Deliverie deliverie = new Deliverie()
            {
                ContractId = (int)comboBox_Contract.SelectedValue,
                Description = textBox_Description.Text,
                EquipmentType = textBox_Equipment.Text,
                EmployeeId = AuthContext.curUser.Id,
            };
            await DbContext.Deliveries.CreateAsync(deliverie);
        }
    }
}
