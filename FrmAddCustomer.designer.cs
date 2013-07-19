namespace NorthWind
{
    partial class FrmAddCustomer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNewCustomer = new System.Windows.Forms.TabPage();
            this.mtxtCustID = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.tabPageUpdateCustomer = new System.Windows.Forms.TabPage();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.btnUpdateClear = new System.Windows.Forms.Button();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdateFax = new System.Windows.Forms.Label();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostalCode = new System.Windows.Forms.Label();
            this.lblUpdateRegion = new System.Windows.Forms.Label();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateCustID = new System.Windows.Forms.Label();
            this.lblUpdateContactTitle = new System.Windows.Forms.Label();
            this.lblUpdateContactName = new System.Windows.Forms.Label();
            this.lblUpdateCompanyName = new System.Windows.Forms.Label();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtUpdateFax = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdatePostalCode = new System.Windows.Forms.TextBox();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateRegion = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateContactName = new System.Windows.Forms.TextBox();
            this.txtUpdateContactTitle = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageNewCustomer.SuspendLayout();
            this.tabPageUpdateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNewCustomer);
            this.tabControl1.Controls.Add(this.tabPageUpdateCustomer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNewCustomer
            // 
            this.tabPageNewCustomer.Controls.Add(this.mtxtCustID);
            this.tabPageNewCustomer.Controls.Add(this.btnClear);
            this.tabPageNewCustomer.Controls.Add(this.lblAddCustomer);
            this.tabPageNewCustomer.Controls.Add(this.lblFax);
            this.tabPageNewCustomer.Controls.Add(this.lblPhone);
            this.tabPageNewCustomer.Controls.Add(this.lblCountry);
            this.tabPageNewCustomer.Controls.Add(this.lblPostalCode);
            this.tabPageNewCustomer.Controls.Add(this.lblRegion);
            this.tabPageNewCustomer.Controls.Add(this.lblCity);
            this.tabPageNewCustomer.Controls.Add(this.lblAddress);
            this.tabPageNewCustomer.Controls.Add(this.lblCustID);
            this.tabPageNewCustomer.Controls.Add(this.lblContactTitle);
            this.tabPageNewCustomer.Controls.Add(this.lblContactName);
            this.tabPageNewCustomer.Controls.Add(this.lblCompanyName);
            this.tabPageNewCustomer.Controls.Add(this.btnSubmit);
            this.tabPageNewCustomer.Controls.Add(this.btnCancel);
            this.tabPageNewCustomer.Controls.Add(this.txtFax);
            this.tabPageNewCustomer.Controls.Add(this.txtPhone);
            this.tabPageNewCustomer.Controls.Add(this.txtPostalCode);
            this.tabPageNewCustomer.Controls.Add(this.txtCountry);
            this.tabPageNewCustomer.Controls.Add(this.txtCity);
            this.tabPageNewCustomer.Controls.Add(this.txtRegion);
            this.tabPageNewCustomer.Controls.Add(this.txtAddress);
            this.tabPageNewCustomer.Controls.Add(this.txtContactName);
            this.tabPageNewCustomer.Controls.Add(this.txtContactTitle);
            this.tabPageNewCustomer.Controls.Add(this.txtCompanyName);
            this.tabPageNewCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewCustomer.Name = "tabPageNewCustomer";
            this.tabPageNewCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewCustomer.Size = new System.Drawing.Size(616, 415);
            this.tabPageNewCustomer.TabIndex = 0;
            this.tabPageNewCustomer.Text = "Add New Customer";
            this.tabPageNewCustomer.UseVisualStyleBackColor = true;
            this.tabPageNewCustomer.Enter += new System.EventHandler(this.tabPageNewCustomer_Enter);
            // 
            // mtxtCustID
            // 
            this.mtxtCustID.Location = new System.Drawing.Point(31, 59);
            this.mtxtCustID.Mask = "LLLLL";
            this.mtxtCustID.Name = "mtxtCustID";
            this.mtxtCustID.Size = new System.Drawing.Size(97, 20);
            this.mtxtCustID.TabIndex = 1;
            this.mtxtCustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtCustID.Validated += new System.EventHandler(this.mtxtCustID_Validated);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(345, 359);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(27, 13);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(111, 20);
            this.lblAddCustomer.TabIndex = 49;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(201, 340);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 48;
            this.lblFax.Text = "Fax";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(28, 340);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Phone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(201, 294);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 46;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(28, 294);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 45;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(201, 250);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 44;
            this.lblRegion.Text = "Region";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 250);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 43;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 42;
            this.lblAddress.Text = "Address";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(28, 43);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(71, 13);
            this.lblCustID.TabIndex = 41;
            this.lblCustID.Text = "Customer I.D.";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(201, 149);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(67, 13);
            this.lblContactTitle.TabIndex = 40;
            this.lblContactTitle.Text = "Contact Title";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(25, 149);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(75, 13);
            this.lblContactName.TabIndex = 39;
            this.lblContactName.Text = "Contact Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(28, 93);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 38;
            this.lblCompanyName.Text = "Company Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(432, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(519, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(204, 362);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(117, 20);
            this.txtFax.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(28, 362);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(28, 310);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(141, 20);
            this.txtPostalCode.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(204, 310);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(117, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(28, 266);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(141, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(204, 266);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(117, 20);
            this.txtRegion.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(28, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(28, 165);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(141, 20);
            this.txtContactName.TabIndex = 3;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(204, 165);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(117, 20);
            this.txtContactTitle.TabIndex = 4;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(28, 109);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(290, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // tabPageUpdateCustomer
            // 
            this.tabPageUpdateCustomer.Controls.Add(this.cmbCustomerID);
            this.tabPageUpdateCustomer.Controls.Add(this.btnUpdateClear);
            this.tabPageUpdateCustomer.Controls.Add(this.cmbCompanyName);
            this.tabPageUpdateCustomer.Controls.Add(this.label1);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateFax);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdatePhone);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateCountry);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdatePostalCode);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateRegion);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateCity);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateAddress);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateCustID);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateContactTitle);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateContactName);
            this.tabPageUpdateCustomer.Controls.Add(this.lblUpdateCompanyName);
            this.tabPageUpdateCustomer.Controls.Add(this.btnUpdateSubmit);
            this.tabPageUpdateCustomer.Controls.Add(this.btnUpdateCancel);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateFax);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdatePhone);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdatePostalCode);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateCountry);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateCity);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateRegion);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateAddress);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateContactName);
            this.tabPageUpdateCustomer.Controls.Add(this.txtUpdateContactTitle);
            this.tabPageUpdateCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateCustomer.Name = "tabPageUpdateCustomer";
            this.tabPageUpdateCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateCustomer.Size = new System.Drawing.Size(616, 415);
            this.tabPageUpdateCustomer.TabIndex = 1;
            this.tabPageUpdateCustomer.Text = "Update Customer";
            this.tabPageUpdateCustomer.UseVisualStyleBackColor = true;
            this.tabPageUpdateCustomer.Enter += new System.EventHandler(this.tabPageUpdateCustomer_Enter);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(18, 65);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerID.TabIndex = 1;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerId_SelectedIndexChanged);
            // 
            // btnUpdateClear
            // 
            this.btnUpdateClear.Location = new System.Drawing.Point(351, 371);
            this.btnUpdateClear.Name = "btnUpdateClear";
            this.btnUpdateClear.Size = new System.Drawing.Size(81, 23);
            this.btnUpdateClear.TabIndex = 12;
            this.btnUpdateClear.Text = "Clear";
            this.btnUpdateClear.UseVisualStyleBackColor = true;
            this.btnUpdateClear.Click += new System.EventHandler(this.btnUpdateClear_Click);
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(18, 118);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(121, 21);
            this.cmbCompanyName.TabIndex = 2;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateCompanyName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Update Customer";
            // 
            // lblUpdateFax
            // 
            this.lblUpdateFax.AutoSize = true;
            this.lblUpdateFax.Location = new System.Drawing.Point(188, 349);
            this.lblUpdateFax.Name = "lblUpdateFax";
            this.lblUpdateFax.Size = new System.Drawing.Size(24, 13);
            this.lblUpdateFax.TabIndex = 73;
            this.lblUpdateFax.Text = "Fax";
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Location = new System.Drawing.Point(18, 349);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(38, 13);
            this.lblUpdatePhone.TabIndex = 72;
            this.lblUpdatePhone.Text = "Phone";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(188, 303);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(43, 13);
            this.lblUpdateCountry.TabIndex = 71;
            this.lblUpdateCountry.Text = "Country";
            // 
            // lblUpdatePostalCode
            // 
            this.lblUpdatePostalCode.AutoSize = true;
            this.lblUpdatePostalCode.Location = new System.Drawing.Point(18, 303);
            this.lblUpdatePostalCode.Name = "lblUpdatePostalCode";
            this.lblUpdatePostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblUpdatePostalCode.TabIndex = 70;
            this.lblUpdatePostalCode.Text = "Postal Code";
            // 
            // lblUpdateRegion
            // 
            this.lblUpdateRegion.AutoSize = true;
            this.lblUpdateRegion.Location = new System.Drawing.Point(188, 259);
            this.lblUpdateRegion.Name = "lblUpdateRegion";
            this.lblUpdateRegion.Size = new System.Drawing.Size(41, 13);
            this.lblUpdateRegion.TabIndex = 69;
            this.lblUpdateRegion.Text = "Region";
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(18, 259);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(24, 13);
            this.lblUpdateCity.TabIndex = 68;
            this.lblUpdateCity.Text = "City";
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(18, 206);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateAddress.TabIndex = 67;
            this.lblUpdateAddress.Text = "Address";
            // 
            // lblUpdateCustID
            // 
            this.lblUpdateCustID.AutoSize = true;
            this.lblUpdateCustID.Location = new System.Drawing.Point(18, 49);
            this.lblUpdateCustID.Name = "lblUpdateCustID";
            this.lblUpdateCustID.Size = new System.Drawing.Size(71, 13);
            this.lblUpdateCustID.TabIndex = 66;
            this.lblUpdateCustID.Text = "Customer I.D.";
            // 
            // lblUpdateContactTitle
            // 
            this.lblUpdateContactTitle.AutoSize = true;
            this.lblUpdateContactTitle.Location = new System.Drawing.Point(188, 149);
            this.lblUpdateContactTitle.Name = "lblUpdateContactTitle";
            this.lblUpdateContactTitle.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateContactTitle.TabIndex = 65;
            this.lblUpdateContactTitle.Text = "Contact Title";
            // 
            // lblUpdateContactName
            // 
            this.lblUpdateContactName.AutoSize = true;
            this.lblUpdateContactName.Location = new System.Drawing.Point(18, 149);
            this.lblUpdateContactName.Name = "lblUpdateContactName";
            this.lblUpdateContactName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateContactName.TabIndex = 64;
            this.lblUpdateContactName.Text = "Contact Name";
            // 
            // lblUpdateCompanyName
            // 
            this.lblUpdateCompanyName.AutoSize = true;
            this.lblUpdateCompanyName.Location = new System.Drawing.Point(18, 102);
            this.lblUpdateCompanyName.Name = "lblUpdateCompanyName";
            this.lblUpdateCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblUpdateCompanyName.TabIndex = 63;
            this.lblUpdateCompanyName.Text = "Company Name";
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.Location = new System.Drawing.Point(438, 371);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(81, 23);
            this.btnUpdateSubmit.TabIndex = 13;
            this.btnUpdateSubmit.Text = "Submit";
            this.btnUpdateSubmit.UseVisualStyleBackColor = true;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(525, 371);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(81, 23);
            this.btnUpdateCancel.TabIndex = 14;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateFax
            // 
            this.txtUpdateFax.Location = new System.Drawing.Point(191, 371);
            this.txtUpdateFax.Name = "txtUpdateFax";
            this.txtUpdateFax.Size = new System.Drawing.Size(117, 20);
            this.txtUpdateFax.TabIndex = 11;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(18, 371);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(141, 20);
            this.txtUpdatePhone.TabIndex = 10;
            // 
            // txtUpdatePostalCode
            // 
            this.txtUpdatePostalCode.Location = new System.Drawing.Point(18, 319);
            this.txtUpdatePostalCode.Name = "txtUpdatePostalCode";
            this.txtUpdatePostalCode.Size = new System.Drawing.Size(141, 20);
            this.txtUpdatePostalCode.TabIndex = 8;
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(191, 319);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(117, 20);
            this.txtUpdateCountry.TabIndex = 9;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(18, 275);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(141, 20);
            this.txtUpdateCity.TabIndex = 6;
            // 
            // txtUpdateRegion
            // 
            this.txtUpdateRegion.Location = new System.Drawing.Point(191, 275);
            this.txtUpdateRegion.Name = "txtUpdateRegion";
            this.txtUpdateRegion.Size = new System.Drawing.Size(117, 20);
            this.txtUpdateRegion.TabIndex = 7;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(18, 222);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(290, 20);
            this.txtUpdateAddress.TabIndex = 5;
            // 
            // txtUpdateContactName
            // 
            this.txtUpdateContactName.Location = new System.Drawing.Point(18, 165);
            this.txtUpdateContactName.Name = "txtUpdateContactName";
            this.txtUpdateContactName.Size = new System.Drawing.Size(141, 20);
            this.txtUpdateContactName.TabIndex = 3;
            // 
            // txtUpdateContactTitle
            // 
            this.txtUpdateContactTitle.Location = new System.Drawing.Point(191, 165);
            this.txtUpdateContactTitle.Name = "txtUpdateContactTitle";
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(117, 20);
            this.txtUpdateContactTitle.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddCustomer";
            this.Text = "FrmAddCustomer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNewCustomer.ResumeLayout(false);
            this.tabPageNewCustomer.PerformLayout();
            this.tabPageUpdateCustomer.ResumeLayout(false);
            this.tabPageUpdateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNewCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TabPage tabPageUpdateCustomer;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdateFax;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostalCode;
        private System.Windows.Forms.Label lblUpdateRegion;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateCustID;
        private System.Windows.Forms.Label lblUpdateContactTitle;
        private System.Windows.Forms.Label lblUpdateContactName;
        private System.Windows.Forms.Label lblUpdateCompanyName;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.TextBox txtUpdateFax;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdatePostalCode;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateRegion;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateContactName;
        private System.Windows.Forms.TextBox txtUpdateContactTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateClear;
        private System.Windows.Forms.MaskedTextBox mtxtCustID;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}