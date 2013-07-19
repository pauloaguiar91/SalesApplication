namespace NorthWind
{
    partial class FrmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAddEmployee = new System.Windows.Forms.TabControl();
            this.tabPageAddEmployee = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbReportsTo = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblTitleOfCourtesy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.tabPageUpdateEmployee = new System.Windows.Forms.TabPage();
            this.btnUpdateClear = new System.Windows.Forms.Button();
            this.cmbUpdateReportsTo = new System.Windows.Forms.ComboBox();
            this.txtUpdateHireDate = new System.Windows.Forms.TextBox();
            this.txtUpdateBirthDate = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.rtbUpdateNote = new System.Windows.Forms.RichTextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateEmployee = new System.Windows.Forms.Label();
            this.lblUpdateFName = new System.Windows.Forms.Label();
            this.lblUpdateLName = new System.Windows.Forms.Label();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateReportsTo = new System.Windows.Forms.Label();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.lblUpdateExtension = new System.Windows.Forms.Label();
            this.lblUpdateHomePhone = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostalCode = new System.Windows.Forms.Label();
            this.lblUpdateRegion = new System.Windows.Forms.Label();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.lblUpdateHireDate = new System.Windows.Forms.Label();
            this.lblUpdateBirthDate = new System.Windows.Forms.Label();
            this.lblUpdateTOC = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.txtUpdateExtension = new System.Windows.Forms.TextBox();
            this.txtUpdateHomePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePostalCode = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateRegion = new System.Windows.Forms.TextBox();
            this.txtUpdateTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlAddEmployee.SuspendLayout();
            this.tabPageAddEmployee.SuspendLayout();
            this.tabPageUpdateEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAddEmployee
            // 
            this.tabControlAddEmployee.Controls.Add(this.tabPageAddEmployee);
            this.tabControlAddEmployee.Controls.Add(this.tabPageUpdateEmployee);
            this.tabControlAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddEmployee.Name = "tabControlAddEmployee";
            this.tabControlAddEmployee.SelectedIndex = 0;
            this.tabControlAddEmployee.Size = new System.Drawing.Size(624, 441);
            this.tabControlAddEmployee.TabIndex = 0;
            // 
            // tabPageAddEmployee
            // 
            this.tabPageAddEmployee.Controls.Add(this.btnClear);
            this.tabPageAddEmployee.Controls.Add(this.cmbReportsTo);
            this.tabPageAddEmployee.Controls.Add(this.dtpHireDate);
            this.tabPageAddEmployee.Controls.Add(this.dtpBirthDate);
            this.tabPageAddEmployee.Controls.Add(this.btnSubmit);
            this.tabPageAddEmployee.Controls.Add(this.btnCancel);
            this.tabPageAddEmployee.Controls.Add(this.rtbNotes);
            this.tabPageAddEmployee.Controls.Add(this.txtAddress);
            this.tabPageAddEmployee.Controls.Add(this.lblAddress);
            this.tabPageAddEmployee.Controls.Add(this.label1);
            this.tabPageAddEmployee.Controls.Add(this.lblFirstName);
            this.tabPageAddEmployee.Controls.Add(this.lblLastName);
            this.tabPageAddEmployee.Controls.Add(this.txtLastName);
            this.tabPageAddEmployee.Controls.Add(this.txtFirstName);
            this.tabPageAddEmployee.Controls.Add(this.txtTitle);
            this.tabPageAddEmployee.Controls.Add(this.lblReportsTo);
            this.tabPageAddEmployee.Controls.Add(this.lblNotes);
            this.tabPageAddEmployee.Controls.Add(this.lblExtension);
            this.tabPageAddEmployee.Controls.Add(this.lblPhone);
            this.tabPageAddEmployee.Controls.Add(this.lblCountry);
            this.tabPageAddEmployee.Controls.Add(this.lblPostalCode);
            this.tabPageAddEmployee.Controls.Add(this.lblRegion);
            this.tabPageAddEmployee.Controls.Add(this.lblCity);
            this.tabPageAddEmployee.Controls.Add(this.lblHireDate);
            this.tabPageAddEmployee.Controls.Add(this.lblBirthDate);
            this.tabPageAddEmployee.Controls.Add(this.lblTitleOfCourtesy);
            this.tabPageAddEmployee.Controls.Add(this.lblTitle);
            this.tabPageAddEmployee.Controls.Add(this.txtExtension);
            this.tabPageAddEmployee.Controls.Add(this.txtHomePhone);
            this.tabPageAddEmployee.Controls.Add(this.txtCountry);
            this.tabPageAddEmployee.Controls.Add(this.txtPostalCode);
            this.tabPageAddEmployee.Controls.Add(this.txtCity);
            this.tabPageAddEmployee.Controls.Add(this.txtRegion);
            this.tabPageAddEmployee.Controls.Add(this.txtTitleOfCourtesy);
            this.tabPageAddEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddEmployee.Name = "tabPageAddEmployee";
            this.tabPageAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEmployee.Size = new System.Drawing.Size(616, 415);
            this.tabPageAddEmployee.TabIndex = 0;
            this.tabPageAddEmployee.Text = "Add Employee";
            this.tabPageAddEmployee.UseVisualStyleBackColor = true;
            this.tabPageAddEmployee.Enter += new System.EventHandler(this.tabPageAddEmployee_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbReportsTo
            // 
            this.cmbReportsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportsTo.FormattingEnabled = true;
            this.cmbReportsTo.Location = new System.Drawing.Point(16, 255);
            this.cmbReportsTo.Name = "cmbReportsTo";
            this.cmbReportsTo.Size = new System.Drawing.Size(121, 21);
            this.cmbReportsTo.TabIndex = 14;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(277, 96);
            this.dtpHireDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(100, 20);
            this.dtpHireDate.TabIndex = 6;
            this.dtpHireDate.Value = new System.DateTime(2012, 12, 7, 0, 0, 0, 0);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(159, 97);
            this.dtpBirthDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(452, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(16, 294);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(243, 96);
            this.rtbNotes.TabIndex = 15;
            this.rtbNotes.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(361, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 122);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add Employee";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(157, 42);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(159, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(277, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(43, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(14, 239);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(60, 13);
            this.lblReportsTo.TabIndex = 24;
            this.lblReportsTo.Text = "Reports To";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(14, 278);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "Notes";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(274, 200);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 21;
            this.lblExtension.Text = "Extension";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(157, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 13);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Home Phone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(14, 200);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(274, 161);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 18;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(156, 161);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 17;
            this.lblRegion.Text = "Region";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(14, 161);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(275, 81);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 15;
            this.lblHireDate.Text = "Hire Date";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(157, 81);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 14;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblTitleOfCourtesy
            // 
            this.lblTitleOfCourtesy.AutoSize = true;
            this.lblTitleOfCourtesy.Location = new System.Drawing.Point(13, 81);
            this.lblTitleOfCourtesy.Name = "lblTitleOfCourtesy";
            this.lblTitleOfCourtesy.Size = new System.Drawing.Size(83, 13);
            this.lblTitleOfCourtesy.TabIndex = 13;
            this.lblTitleOfCourtesy.Text = "Title of Courtesy";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(274, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(277, 216);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 20);
            this.txtExtension.TabIndex = 13;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(159, 216);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(100, 20);
            this.txtHomePhone.TabIndex = 12;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(16, 216);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(125, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(277, 177);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(16, 177);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(159, 177);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // txtTitleOfCourtesy
            // 
            this.txtTitleOfCourtesy.Location = new System.Drawing.Point(16, 97);
            this.txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            this.txtTitleOfCourtesy.Size = new System.Drawing.Size(125, 20);
            this.txtTitleOfCourtesy.TabIndex = 4;
            // 
            // tabPageUpdateEmployee
            // 
            this.tabPageUpdateEmployee.Controls.Add(this.btnUpdateClear);
            this.tabPageUpdateEmployee.Controls.Add(this.cmbUpdateReportsTo);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateHireDate);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateBirthDate);
            this.tabPageUpdateEmployee.Controls.Add(this.lblEmployeeID);
            this.tabPageUpdateEmployee.Controls.Add(this.cmbEmployees);
            this.tabPageUpdateEmployee.Controls.Add(this.btnUpdateSubmit);
            this.tabPageUpdateEmployee.Controls.Add(this.btnUpdateCancel);
            this.tabPageUpdateEmployee.Controls.Add(this.rtbUpdateNote);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateAddress);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateAddress);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateEmployee);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateFName);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateLName);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateLName);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateFName);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateTitle);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateReportsTo);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateNotes);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateExtension);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateHomePhone);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateCountry);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdatePostalCode);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateRegion);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateCity);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateHireDate);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateBirthDate);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateTOC);
            this.tabPageUpdateEmployee.Controls.Add(this.lblUpdateTitle);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateExtension);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateHomePhone);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateCountry);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdatePostalCode);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateCity);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateRegion);
            this.tabPageUpdateEmployee.Controls.Add(this.txtUpdateTitleOfCourtesy);
            this.tabPageUpdateEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateEmployee.Name = "tabPageUpdateEmployee";
            this.tabPageUpdateEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateEmployee.Size = new System.Drawing.Size(616, 415);
            this.tabPageUpdateEmployee.TabIndex = 1;
            this.tabPageUpdateEmployee.Text = "Update Employee";
            this.tabPageUpdateEmployee.UseVisualStyleBackColor = true;
            this.tabPageUpdateEmployee.Enter += new System.EventHandler(this.tabPageUpdateEmployee_Enter);
            // 
            // btnUpdateClear
            // 
            this.btnUpdateClear.Location = new System.Drawing.Point(371, 367);
            this.btnUpdateClear.Name = "btnUpdateClear";
            this.btnUpdateClear.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateClear.TabIndex = 17;
            this.btnUpdateClear.Text = "Clear";
            this.btnUpdateClear.UseVisualStyleBackColor = true;
            this.btnUpdateClear.Click += new System.EventHandler(this.btnUpdateClear_Click);
            // 
            // cmbUpdateReportsTo
            // 
            this.cmbUpdateReportsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateReportsTo.FormattingEnabled = true;
            this.cmbUpdateReportsTo.Location = new System.Drawing.Point(15, 253);
            this.cmbUpdateReportsTo.Name = "cmbUpdateReportsTo";
            this.cmbUpdateReportsTo.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateReportsTo.TabIndex = 15;
            // 
            // txtUpdateHireDate
            // 
            this.txtUpdateHireDate.Location = new System.Drawing.Point(275, 94);
            this.txtUpdateHireDate.Name = "txtUpdateHireDate";
            this.txtUpdateHireDate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateHireDate.TabIndex = 7;
            // 
            // txtUpdateBirthDate
            // 
            this.txtUpdateBirthDate.Location = new System.Drawing.Point(157, 94);
            this.txtUpdateBirthDate.Name = "txtUpdateBirthDate";
            this.txtUpdateBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBirthDate.TabIndex = 6;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(356, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(61, 13);
            this.lblEmployeeID.TabIndex = 72;
            this.lblEmployeeID.Text = "Employees:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(359, 31);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployees.TabIndex = 1;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.Location = new System.Drawing.Point(452, 367);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSubmit.TabIndex = 18;
            this.btnUpdateSubmit.Text = "Submit";
            this.btnUpdateSubmit.UseVisualStyleBackColor = true;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(533, 367);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 19;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // rtbUpdateNote
            // 
            this.rtbUpdateNote.Location = new System.Drawing.Point(14, 291);
            this.rtbUpdateNote.Name = "rtbUpdateNote";
            this.rtbUpdateNote.Size = new System.Drawing.Size(243, 96);
            this.rtbUpdateNote.TabIndex = 16;
            this.rtbUpdateNote.Text = "";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(14, 135);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(361, 20);
            this.txtUpdateAddress.TabIndex = 8;
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(12, 119);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateAddress.TabIndex = 64;
            this.lblUpdateAddress.Text = "Address";
            // 
            // lblUpdateEmployee
            // 
            this.lblUpdateEmployee.AutoSize = true;
            this.lblUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateEmployee.Location = new System.Drawing.Point(11, 11);
            this.lblUpdateEmployee.Name = "lblUpdateEmployee";
            this.lblUpdateEmployee.Size = new System.Drawing.Size(136, 20);
            this.lblUpdateEmployee.TabIndex = 63;
            this.lblUpdateEmployee.Text = "Update Employee";
            // 
            // lblUpdateFName
            // 
            this.lblUpdateFName.AutoSize = true;
            this.lblUpdateFName.Location = new System.Drawing.Point(11, 39);
            this.lblUpdateFName.Name = "lblUpdateFName";
            this.lblUpdateFName.Size = new System.Drawing.Size(57, 13);
            this.lblUpdateFName.TabIndex = 62;
            this.lblUpdateFName.Text = "First Name";
            // 
            // lblUpdateLName
            // 
            this.lblUpdateLName.AutoSize = true;
            this.lblUpdateLName.Location = new System.Drawing.Point(155, 39);
            this.lblUpdateLName.Name = "lblUpdateLName";
            this.lblUpdateLName.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateLName.TabIndex = 61;
            this.lblUpdateLName.Text = "Last Name";
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(157, 55);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLName.TabIndex = 3;
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(14, 55);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateFName.TabIndex = 2;
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(275, 54);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(43, 20);
            this.txtUpdateTitle.TabIndex = 4;
            // 
            // lblUpdateReportsTo
            // 
            this.lblUpdateReportsTo.AutoSize = true;
            this.lblUpdateReportsTo.Location = new System.Drawing.Point(12, 236);
            this.lblUpdateReportsTo.Name = "lblUpdateReportsTo";
            this.lblUpdateReportsTo.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateReportsTo.TabIndex = 57;
            this.lblUpdateReportsTo.Text = "Reports To";
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Location = new System.Drawing.Point(12, 275);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateNotes.TabIndex = 56;
            this.lblUpdateNotes.Text = "Notes";
            // 
            // lblUpdateExtension
            // 
            this.lblUpdateExtension.AutoSize = true;
            this.lblUpdateExtension.Location = new System.Drawing.Point(272, 197);
            this.lblUpdateExtension.Name = "lblUpdateExtension";
            this.lblUpdateExtension.Size = new System.Drawing.Size(53, 13);
            this.lblUpdateExtension.TabIndex = 55;
            this.lblUpdateExtension.Text = "Extension";
            // 
            // lblUpdateHomePhone
            // 
            this.lblUpdateHomePhone.AutoSize = true;
            this.lblUpdateHomePhone.Location = new System.Drawing.Point(155, 197);
            this.lblUpdateHomePhone.Name = "lblUpdateHomePhone";
            this.lblUpdateHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblUpdateHomePhone.TabIndex = 54;
            this.lblUpdateHomePhone.Text = "Home Phone";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(12, 197);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(43, 13);
            this.lblUpdateCountry.TabIndex = 53;
            this.lblUpdateCountry.Text = "Country";
            // 
            // lblUpdatePostalCode
            // 
            this.lblUpdatePostalCode.AutoSize = true;
            this.lblUpdatePostalCode.Location = new System.Drawing.Point(272, 158);
            this.lblUpdatePostalCode.Name = "lblUpdatePostalCode";
            this.lblUpdatePostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblUpdatePostalCode.TabIndex = 52;
            this.lblUpdatePostalCode.Text = "Postal Code";
            // 
            // lblUpdateRegion
            // 
            this.lblUpdateRegion.AutoSize = true;
            this.lblUpdateRegion.Location = new System.Drawing.Point(154, 158);
            this.lblUpdateRegion.Name = "lblUpdateRegion";
            this.lblUpdateRegion.Size = new System.Drawing.Size(41, 13);
            this.lblUpdateRegion.TabIndex = 51;
            this.lblUpdateRegion.Text = "Region";
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(12, 158);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(24, 13);
            this.lblUpdateCity.TabIndex = 50;
            this.lblUpdateCity.Text = "City";
            // 
            // lblUpdateHireDate
            // 
            this.lblUpdateHireDate.AutoSize = true;
            this.lblUpdateHireDate.Location = new System.Drawing.Point(273, 78);
            this.lblUpdateHireDate.Name = "lblUpdateHireDate";
            this.lblUpdateHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateHireDate.TabIndex = 49;
            this.lblUpdateHireDate.Text = "Hire Date";
            // 
            // lblUpdateBirthDate
            // 
            this.lblUpdateBirthDate.AutoSize = true;
            this.lblUpdateBirthDate.Location = new System.Drawing.Point(155, 78);
            this.lblUpdateBirthDate.Name = "lblUpdateBirthDate";
            this.lblUpdateBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblUpdateBirthDate.TabIndex = 48;
            this.lblUpdateBirthDate.Text = "Birth Date";
            // 
            // lblUpdateTOC
            // 
            this.lblUpdateTOC.AutoSize = true;
            this.lblUpdateTOC.Location = new System.Drawing.Point(11, 78);
            this.lblUpdateTOC.Name = "lblUpdateTOC";
            this.lblUpdateTOC.Size = new System.Drawing.Size(83, 13);
            this.lblUpdateTOC.TabIndex = 47;
            this.lblUpdateTOC.Text = "Title of Courtesy";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(272, 39);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(27, 13);
            this.lblUpdateTitle.TabIndex = 46;
            this.lblUpdateTitle.Text = "Title";
            // 
            // txtUpdateExtension
            // 
            this.txtUpdateExtension.Location = new System.Drawing.Point(275, 213);
            this.txtUpdateExtension.Name = "txtUpdateExtension";
            this.txtUpdateExtension.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateExtension.TabIndex = 14;
            // 
            // txtUpdateHomePhone
            // 
            this.txtUpdateHomePhone.Location = new System.Drawing.Point(157, 213);
            this.txtUpdateHomePhone.Name = "txtUpdateHomePhone";
            this.txtUpdateHomePhone.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateHomePhone.TabIndex = 13;
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(14, 213);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateCountry.TabIndex = 12;
            // 
            // txtUpdatePostalCode
            // 
            this.txtUpdatePostalCode.Location = new System.Drawing.Point(275, 174);
            this.txtUpdatePostalCode.Name = "txtUpdatePostalCode";
            this.txtUpdatePostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePostalCode.TabIndex = 11;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(14, 174);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateCity.TabIndex = 9;
            // 
            // txtUpdateRegion
            // 
            this.txtUpdateRegion.Location = new System.Drawing.Point(157, 174);
            this.txtUpdateRegion.Name = "txtUpdateRegion";
            this.txtUpdateRegion.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRegion.TabIndex = 10;
            // 
            // txtUpdateTitleOfCourtesy
            // 
            this.txtUpdateTitleOfCourtesy.Location = new System.Drawing.Point(14, 94);
            this.txtUpdateTitleOfCourtesy.Name = "txtUpdateTitleOfCourtesy";
            this.txtUpdateTitleOfCourtesy.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateTitleOfCourtesy.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControlAddEmployee);
            this.Name = "FrmAddEmployee";
            this.Text = "FrmAddEmployee";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            this.tabControlAddEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.PerformLayout();
            this.tabPageUpdateEmployee.ResumeLayout(false);
            this.tabPageUpdateEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddEmployee;
        private System.Windows.Forms.TabPage tabPageAddEmployee;
        private System.Windows.Forms.TabPage tabPageUpdateEmployee;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblTitleOfCourtesy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtTitleOfCourtesy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.RichTextBox rtbUpdateNote;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateEmployee;
        private System.Windows.Forms.Label lblUpdateFName;
        private System.Windows.Forms.Label lblUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblUpdateReportsTo;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Label lblUpdateExtension;
        private System.Windows.Forms.Label lblUpdateHomePhone;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostalCode;
        private System.Windows.Forms.Label lblUpdateRegion;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblUpdateHireDate;
        private System.Windows.Forms.Label lblUpdateBirthDate;
        private System.Windows.Forms.Label lblUpdateTOC;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateExtension;
        private System.Windows.Forms.TextBox txtUpdateHomePhone;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdatePostalCode;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateRegion;
        private System.Windows.Forms.TextBox txtUpdateTitleOfCourtesy;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.TextBox txtUpdateHireDate;
        private System.Windows.Forms.TextBox txtUpdateBirthDate;
        private System.Windows.Forms.ComboBox cmbReportsTo;
        private System.Windows.Forms.ComboBox cmbUpdateReportsTo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateClear;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}