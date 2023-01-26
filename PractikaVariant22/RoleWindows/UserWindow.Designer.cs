namespace PractikaVariant22.RoleWindows
{
    public partial class UserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Create_Company = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_Emp = new System.Windows.Forms.DataGridView();
            this.numericUpDown_Emp_Salary = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Emp_Price = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Emp_Month = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Employee_Department = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Employee_Position = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Employee_Name = new System.Windows.Forms.TextBox();
            this.button_Create_Employee = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_DepartmentName = new System.Windows.Forms.TextBox();
            this.button_Create_Department = new System.Windows.Forms.Button();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateCreate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_ContractPrice = new System.Windows.Forms.NumericUpDown();
            this.button_CreateContract = new System.Windows.Forms.Button();
            this.dataGridView_Company = new System.Windows.Forms.DataGridView();
            this.numericUpDown_CoutryCode = new System.Windows.Forms.NumericUpDown();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Site = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView_Contracts = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Equipment = new System.Windows.Forms.TextBox();
            this.comboBox_Contract = new System.Windows.Forms.ComboBox();
            this.button_Create_Delivery = new System.Windows.Forms.Button();
            this.dataGridView_Deliveries = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Month)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ContractPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoutryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Deliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maskedTextBox_Phone);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox_Site);
            this.tabPage1.Controls.Add(this.textBox_Email);
            this.tabPage1.Controls.Add(this.textBox_Address);
            this.tabPage1.Controls.Add(this.textBox_City);
            this.tabPage1.Controls.Add(this.numericUpDown_CoutryCode);
            this.tabPage1.Controls.Add(this.dataGridView_Company);
            this.tabPage1.Controls.Add(this.button_Create_Company);
            this.tabPage1.Controls.Add(this.button_Exit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Companyes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Create_Company
            // 
            this.button_Create_Company.Location = new System.Drawing.Point(22, 322);
            this.button_Create_Company.Name = "button_Create_Company";
            this.button_Create_Company.Size = new System.Drawing.Size(167, 23);
            this.button_Create_Company.TabIndex = 2;
            this.button_Create_Company.Text = "Create";
            this.button_Create_Company.UseVisualStyleBackColor = true;
            this.button_Create_Company.Click += new System.EventHandler(this.button_Create_Company_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(8, 395);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Deliveries);
            this.tabPage2.Controls.Add(this.button_Create_Delivery);
            this.tabPage2.Controls.Add(this.comboBox_Contract);
            this.tabPage2.Controls.Add(this.textBox_Equipment);
            this.tabPage2.Controls.Add(this.textBox_Description);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.dataGridView_Contracts);
            this.tabPage2.Controls.Add(this.button_CreateContract);
            this.tabPage2.Controls.Add(this.numericUpDown_ContractPrice);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dateTimePicker_DateCreate);
            this.tabPage2.Controls.Add(this.Label7);
            this.tabPage2.Controls.Add(this.comboBox_Company);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contracts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_Emp);
            this.tabPage3.Controls.Add(this.numericUpDown_Emp_Salary);
            this.tabPage3.Controls.Add(this.numericUpDown_Emp_Price);
            this.tabPage3.Controls.Add(this.numericUpDown_Emp_Month);
            this.tabPage3.Controls.Add(this.comboBox_Employee_Department);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox_Employee_Position);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBox_Employee_Name);
            this.tabPage3.Controls.Add(this.button_Create_Employee);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Epmloyees";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Emp
            // 
            this.dataGridView_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Emp.Location = new System.Drawing.Point(212, 13);
            this.dataGridView_Emp.Name = "dataGridView_Emp";
            this.dataGridView_Emp.Size = new System.Drawing.Size(572, 150);
            this.dataGridView_Emp.TabIndex = 18;
            // 
            // numericUpDown_Emp_Salary
            // 
            this.numericUpDown_Emp_Salary.Location = new System.Drawing.Point(76, 91);
            this.numericUpDown_Emp_Salary.Name = "numericUpDown_Emp_Salary";
            this.numericUpDown_Emp_Salary.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Emp_Salary.TabIndex = 17;
            // 
            // numericUpDown_Emp_Price
            // 
            this.numericUpDown_Emp_Price.Location = new System.Drawing.Point(77, 117);
            this.numericUpDown_Emp_Price.Name = "numericUpDown_Emp_Price";
            this.numericUpDown_Emp_Price.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Emp_Price.TabIndex = 16;
            // 
            // numericUpDown_Emp_Month
            // 
            this.numericUpDown_Emp_Month.Location = new System.Drawing.Point(76, 143);
            this.numericUpDown_Emp_Month.Name = "numericUpDown_Emp_Month";
            this.numericUpDown_Emp_Month.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Emp_Month.TabIndex = 15;
            // 
            // comboBox_Employee_Department
            // 
            this.comboBox_Employee_Department.DisplayMember = "Departments.Id";
            this.comboBox_Employee_Department.FormattingEnabled = true;
            this.comboBox_Employee_Department.Location = new System.Drawing.Point(76, 38);
            this.comboBox_Employee_Department.Name = "comboBox_Employee_Department";
            this.comboBox_Employee_Department.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Employee_Department.TabIndex = 13;
            this.comboBox_Employee_Department.ValueMember = "Departments.Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Position";
            // 
            // textBox_Employee_Position
            // 
            this.textBox_Employee_Position.Location = new System.Drawing.Point(76, 65);
            this.textBox_Employee_Position.Name = "textBox_Employee_Position";
            this.textBox_Employee_Position.Size = new System.Drawing.Size(120, 20);
            this.textBox_Employee_Position.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBox_Employee_Name
            // 
            this.textBox_Employee_Name.Location = new System.Drawing.Point(76, 13);
            this.textBox_Employee_Name.Name = "textBox_Employee_Name";
            this.textBox_Employee_Name.Size = new System.Drawing.Size(121, 20);
            this.textBox_Employee_Name.TabIndex = 1;
            // 
            // button_Create_Employee
            // 
            this.button_Create_Employee.Location = new System.Drawing.Point(11, 169);
            this.button_Create_Employee.Name = "button_Create_Employee";
            this.button_Create_Employee.Size = new System.Drawing.Size(94, 23);
            this.button_Create_Employee.TabIndex = 0;
            this.button_Create_Employee.Text = "Create employee";
            this.button_Create_Employee.UseVisualStyleBackColor = true;
            this.button_Create_Employee.Click += new System.EventHandler(this.button_Create_Employee_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox_DepartmentName);
            this.tabPage4.Controls.Add(this.button_Create_Department);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dpartment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox_DepartmentName
            // 
            this.textBox_DepartmentName.Location = new System.Drawing.Point(114, 3);
            this.textBox_DepartmentName.Name = "textBox_DepartmentName";
            this.textBox_DepartmentName.Size = new System.Drawing.Size(100, 20);
            this.textBox_DepartmentName.TabIndex = 2;
            // 
            // button_Create_Department
            // 
            this.button_Create_Department.Location = new System.Drawing.Point(5, 3);
            this.button_Create_Department.Name = "button_Create_Department";
            this.button_Create_Department.Size = new System.Drawing.Size(103, 23);
            this.button_Create_Department.TabIndex = 1;
            this.button_Create_Department.Text = "Create department";
            this.button_Create_Department.UseVisualStyleBackColor = true;
            this.button_Create_Department.Click += new System.EventHandler(this.button_Create_Department_Click);
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(66, 27);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(136, 21);
            this.comboBox_Company.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 30);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(51, 13);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Company";
            // 
            // dateTimePicker_DateCreate
            // 
            this.dateTimePicker_DateCreate.Location = new System.Drawing.Point(66, 54);
            this.dateTimePicker_DateCreate.Name = "dateTimePicker_DateCreate";
            this.dateTimePicker_DateCreate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker_DateCreate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Price";
            // 
            // numericUpDown_ContractPrice
            // 
            this.numericUpDown_ContractPrice.Location = new System.Drawing.Point(66, 78);
            this.numericUpDown_ContractPrice.Name = "numericUpDown_ContractPrice";
            this.numericUpDown_ContractPrice.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown_ContractPrice.TabIndex = 5;
            // 
            // button_CreateContract
            // 
            this.button_CreateContract.Location = new System.Drawing.Point(12, 104);
            this.button_CreateContract.Name = "button_CreateContract";
            this.button_CreateContract.Size = new System.Drawing.Size(190, 23);
            this.button_CreateContract.TabIndex = 6;
            this.button_CreateContract.Text = "Create contract";
            this.button_CreateContract.UseVisualStyleBackColor = true;
            this.button_CreateContract.Click += new System.EventHandler(this.button_CreateContract_Click);
            // 
            // dataGridView_Company
            // 
            this.dataGridView_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Company.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_Company.Name = "dataGridView_Company";
            this.dataGridView_Company.Size = new System.Drawing.Size(776, 150);
            this.dataGridView_Company.TabIndex = 3;
            // 
            // numericUpDown_CoutryCode
            // 
            this.numericUpDown_CoutryCode.Location = new System.Drawing.Point(89, 165);
            this.numericUpDown_CoutryCode.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_CoutryCode.Name = "numericUpDown_CoutryCode";
            this.numericUpDown_CoutryCode.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_CoutryCode.TabIndex = 4;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(89, 192);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 20);
            this.textBox_City.TabIndex = 5;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(89, 218);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(100, 20);
            this.textBox_Address.TabIndex = 6;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(89, 270);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 8;
            // 
            // textBox_Site
            // 
            this.textBox_Site.Location = new System.Drawing.Point(89, 296);
            this.textBox_Site.Name = "textBox_Site";
            this.textBox_Site.Size = new System.Drawing.Size(100, 20);
            this.textBox_Site.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Coutry code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Site";
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(90, 245);
            this.maskedTextBox_Phone.Mask = "(999) 000-0000";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Phone.TabIndex = 16;
            // 
            // dataGridView_Contracts
            // 
            this.dataGridView_Contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Contracts.Location = new System.Drawing.Point(12, 134);
            this.dataGridView_Contracts.Name = "dataGridView_Contracts";
            this.dataGridView_Contracts.Size = new System.Drawing.Size(240, 282);
            this.dataGridView_Contracts.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Equipment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Description";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Contract";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(328, 51);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(100, 20);
            this.textBox_Description.TabIndex = 11;
            // 
            // textBox_Equipment
            // 
            this.textBox_Equipment.Location = new System.Drawing.Point(328, 25);
            this.textBox_Equipment.Name = "textBox_Equipment";
            this.textBox_Equipment.Size = new System.Drawing.Size(100, 20);
            this.textBox_Equipment.TabIndex = 12;
            // 
            // comboBox_Contract
            // 
            this.comboBox_Contract.FormattingEnabled = true;
            this.comboBox_Contract.Location = new System.Drawing.Point(328, 77);
            this.comboBox_Contract.Name = "comboBox_Contract";
            this.comboBox_Contract.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Contract.TabIndex = 13;
            // 
            // button_Create_Delivery
            // 
            this.button_Create_Delivery.Location = new System.Drawing.Point(284, 104);
            this.button_Create_Delivery.Name = "button_Create_Delivery";
            this.button_Create_Delivery.Size = new System.Drawing.Size(190, 23);
            this.button_Create_Delivery.TabIndex = 14;
            this.button_Create_Delivery.Text = "Create delivery";
            this.button_Create_Delivery.UseVisualStyleBackColor = true;
            this.button_Create_Delivery.Click += new System.EventHandler(this.button_Create_Delivery_Click);
            // 
            // dataGridView_Deliveries
            // 
            this.dataGridView_Deliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Deliveries.Location = new System.Drawing.Point(268, 134);
            this.dataGridView_Deliveries.Name = "dataGridView_Deliveries";
            this.dataGridView_Deliveries.Size = new System.Drawing.Size(240, 282);
            this.dataGridView_Deliveries.TabIndex = 15;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserWindow_FormClosing);
            this.Load += new System.EventHandler(this.UserWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Emp_Month)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ContractPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoutryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Deliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Create_Company;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_DepartmentName;
        private System.Windows.Forms.Button button_Create_Department;
        private System.Windows.Forms.ComboBox comboBox_Employee_Department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Employee_Position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Employee_Name;
        private System.Windows.Forms.Button button_Create_Employee;
        private System.Windows.Forms.NumericUpDown numericUpDown_Emp_Salary;
        private System.Windows.Forms.NumericUpDown numericUpDown_Emp_Price;
        private System.Windows.Forms.NumericUpDown numericUpDown_Emp_Month;
        private System.Windows.Forms.DataGridView dataGridView_Emp;
        private System.Windows.Forms.Button button_CreateContract;
        private System.Windows.Forms.NumericUpDown numericUpDown_ContractPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateCreate;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.DataGridView dataGridView_Company;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Site;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.NumericUpDown numericUpDown_CoutryCode;
        private System.Windows.Forms.DataGridView dataGridView_Contracts;
        private System.Windows.Forms.Button button_Create_Delivery;
        private System.Windows.Forms.ComboBox comboBox_Contract;
        private System.Windows.Forms.TextBox textBox_Equipment;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView_Deliveries;
        private System.Windows.Forms.TabPage tabPage5;
    }
}