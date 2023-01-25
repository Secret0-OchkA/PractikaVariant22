using Domain;
using Infrastructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaVariant22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button_Add_Click(object sender, EventArgs e)
        {
            await DbContext.Employees.CreateAsync(new Employee { DepartmentId = 1, Month = 2, Name = "test", Position = "position", Price = 200, Salary = 100});
   
            dataGridView_Books.DataSource = await DbContext.Employees.GetAllAsync();
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            await DbContext.Employees.DeleteAsync(2);

            dataGridView_Books.DataSource = await DbContext.Employees.GetAllAsync();
        }

        private async void button_Update_Click(object sender, EventArgs e)
        {
            await DbContext.Employees.UpdateAsync(2, new Employee { DepartmentId = 1, Month = 8, Name = "jjjj", Position = ",,,,,,,", Price = 322, Salary = 377 });

            dataGridView_Books.DataSource = await DbContext.Employees.GetAllAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_Books.DataSource = await DbContext.Employees.GetAllAsync();
        }
    }
}
