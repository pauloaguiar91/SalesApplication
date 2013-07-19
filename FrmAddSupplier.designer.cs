namespace NorthWind
{
    partial class FrmAddSupplier
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddSupplier = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddSupplier = new System.Windows.Forms.Label();
            this.tabPageUpdateSupplier = new System.Windows.Forms.TabPage();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePostalCode = new System.Windows.Forms.TextBox();
            this.txtUpdateRegion = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateContactTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateContactName = new System.Windows.Forms.TextBox();
            this.txtUpdateCompanyName = new System.Windows.Forms.TextBox();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostalCode = new System.Windows.Forms.Label();
            this.lblUpdateRegion = new System.Windows.Forms.Label();
            this.lblContactAddress2 = new System.Windows.Forms.Label();
            this.lblUpdateContact = new System.Windows.Forms.Label();
            this.lblUpdateContactName = new System.Windows.Forms.Label();
            this.lblUpdateCompanyName = new System.Windows.Forms.Label();
            this.lblUpdateSupplier = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageAddSupplier.SuspendLayout();
            this.tabPageUpdateSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddSupplier);
            this.tabControl.Controls.Add(this.tabPageUpdateSupplier);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 441);
            this.tabControl.TabIndex = 22;
            // 
            // tabPageAddSupplier
            // 
            this.tabPageAddSupplier.Controls.Add(this.btnCancel);
            this.tabPageAddSupplier.Controls.Add(this.btnAdd);
            this.tabPageAddSupplier.Controls.Add(this.btnClear);
            this.tabPageAddSupplier.Controls.Add(this.txtPhone);
            this.tabPageAddSupplier.Controls.Add(this.txtCountry);
            this.tabPageAddSupplier.Controls.Add(this.txtPostalCode);
            this.tabPageAddSupplier.Controls.Add(this.txtRegion);
            this.tabPageAddSupplier.Controls.Add(this.txtCity);
            this.tabPageAddSupplier.Controls.Add(this.txtAddress);
            this.tabPageAddSupplier.Controls.Add(this.txtContactTitle);
            this.tabPageAddSupplier.Controls.Add(this.txtContactName);
            this.tabPageAddSupplier.Controls.Add(this.txtCompanyName);
            this.tabPageAddSupplier.Controls.Add(this.lblPhone);
            this.tabPageAddSupplier.Controls.Add(this.lblCountry);
            this.tabPageAddSupplier.Controls.Add(this.lblPostalCode);
            this.tabPageAddSupplier.Controls.Add(this.lblRegion);
            this.tabPageAddSupplier.Controls.Add(this.lblCity);
            this.tabPageAddSupplier.Controls.Add(this.lblAddress);
            this.tabPageAddSupplier.Controls.Add(this.lblContactTitle);
            this.tabPageAddSupplier.Controls.Add(this.lblContactName);
            this.tabPageAddSupplier.Controls.Add(this.lblCompanyName);
            this.tabPageAddSupplier.Controls.Add(this.lblAddSupplier);
            this.tabPageAddSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddSupplier.Name = "tabPageAddSupplier";
            this.tabPageAddSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddSupplier.Size = new System.Drawing.Size(616, 415);
            this.tabPageAddSupplier.TabIndex = 0;
            this.tabPageAddSupplier.Text = "Add Supplier";
            this.tabPageAddSupplier.UseVisualStyleBackColor = true;
            this.tabPageAddSupplier.Enter += new System.EventHandler(this.tabPageAddSupplier_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(306, 163);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(306, 117);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(306, 71);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 6;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(110, 271);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(110, 231);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(110, 151);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txtContactTitle.TabIndex = 2;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(110, 111);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(110, 71);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(233, 161);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 31;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(233, 116);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Country:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(233, 71);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 29;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(19, 269);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 28;
            this.lblRegion.Text = "Region:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(19, 230);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address:";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(19, 152);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(70, 13);
            this.lblContactTitle.TabIndex = 25;
            this.lblContactTitle.Text = "Contact Title:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(19, 113);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 24;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(19, 74);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 23;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplier.Location = new System.Drawing.Point(19, 19);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(148, 20);
            this.lblAddSupplier.TabIndex = 22;
            this.lblAddSupplier.Text = "Add a New Supplier";
            // 
            // tabPageUpdateSupplier
            // 
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateCity);
            this.tabPageUpdateSupplier.Controls.Add(this.btnCancelUpdate);
            this.tabPageUpdateSupplier.Controls.Add(this.btnUpdate);
            this.tabPageUpdateSupplier.Controls.Add(this.btnClearUpdate);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdatePhone);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateCountry);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdatePostalCode);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateRegion);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateCity);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateAddress);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateContactTitle);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateContactName);
            this.tabPageUpdateSupplier.Controls.Add(this.txtUpdateCompanyName);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdatePhone);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateCountry);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdatePostalCode);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateRegion);
            this.tabPageUpdateSupplier.Controls.Add(this.lblContactAddress2);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateContact);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateContactName);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateCompanyName);
            this.tabPageUpdateSupplier.Controls.Add(this.lblUpdateSupplier);
            this.tabPageUpdateSupplier.Controls.Add(this.cmbSuppliers);
            this.tabPageUpdateSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateSupplier.Name = "tabPageUpdateSupplier";
            this.tabPageUpdateSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateSupplier.Size = new System.Drawing.Size(616, 415);
            this.tabPageUpdateSupplier.TabIndex = 1;
            this.tabPageUpdateSupplier.Text = "Update Supplier";
            this.tabPageUpdateSupplier.UseVisualStyleBackColor = true;
            this.tabPageUpdateSupplier.Enter += new System.EventHandler(this.tabPageUpdateSupplier_Enter);
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(27, 260);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(27, 13);
            this.lblUpdateCity.TabIndex = 64;
            this.lblUpdateCity.Text = "City:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(523, 374);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnCancelUpdate.TabIndex = 13;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(436, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Location = new System.Drawing.Point(349, 374);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnClearUpdate.TabIndex = 11;
            this.btnClearUpdate.Text = "Clear";
            this.btnClearUpdate.UseVisualStyleBackColor = true;
            this.btnClearUpdate.Click += new System.EventHandler(this.btnClearUpdate_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(314, 187);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePhone.TabIndex = 10;
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(314, 144);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCountry.TabIndex = 9;
            // 
            // txtUpdatePostalCode
            // 
            this.txtUpdatePostalCode.Location = new System.Drawing.Point(314, 101);
            this.txtUpdatePostalCode.Name = "txtUpdatePostalCode";
            this.txtUpdatePostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePostalCode.TabIndex = 8;
            // 
            // txtUpdateRegion
            // 
            this.txtUpdateRegion.Location = new System.Drawing.Point(118, 296);
            this.txtUpdateRegion.Name = "txtUpdateRegion";
            this.txtUpdateRegion.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateRegion.TabIndex = 7;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(118, 257);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCity.TabIndex = 6;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(118, 218);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAddress.TabIndex = 5;
            // 
            // txtUpdateContactTitle
            // 
            this.txtUpdateContactTitle.Location = new System.Drawing.Point(118, 179);
            this.txtUpdateContactTitle.Name = "txtUpdateContactTitle";
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateContactTitle.TabIndex = 4;
            // 
            // txtUpdateContactName
            // 
            this.txtUpdateContactName.Location = new System.Drawing.Point(118, 140);
            this.txtUpdateContactName.Name = "txtUpdateContactName";
            this.txtUpdateContactName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateContactName.TabIndex = 3;
            // 
            // txtUpdateCompanyName
            // 
            this.txtUpdateCompanyName.Location = new System.Drawing.Point(118, 101);
            this.txtUpdateCompanyName.Name = "txtUpdateCompanyName";
            this.txtUpdateCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCompanyName.TabIndex = 2;
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Location = new System.Drawing.Point(241, 190);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(41, 13);
            this.lblUpdatePhone.TabIndex = 51;
            this.lblUpdatePhone.Text = "Phone:";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(241, 147);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateCountry.TabIndex = 50;
            this.lblUpdateCountry.Text = "Country:";
            // 
            // lblUpdatePostalCode
            // 
            this.lblUpdatePostalCode.AutoSize = true;
            this.lblUpdatePostalCode.Location = new System.Drawing.Point(241, 104);
            this.lblUpdatePostalCode.Name = "lblUpdatePostalCode";
            this.lblUpdatePostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblUpdatePostalCode.TabIndex = 49;
            this.lblUpdatePostalCode.Text = "Postal Code:";
            // 
            // lblUpdateRegion
            // 
            this.lblUpdateRegion.AutoSize = true;
            this.lblUpdateRegion.Location = new System.Drawing.Point(27, 299);
            this.lblUpdateRegion.Name = "lblUpdateRegion";
            this.lblUpdateRegion.Size = new System.Drawing.Size(44, 13);
            this.lblUpdateRegion.TabIndex = 48;
            this.lblUpdateRegion.Text = "Region:";
            // 
            // lblContactAddress2
            // 
            this.lblContactAddress2.AutoSize = true;
            this.lblContactAddress2.Location = new System.Drawing.Point(27, 221);
            this.lblContactAddress2.Name = "lblContactAddress2";
            this.lblContactAddress2.Size = new System.Drawing.Size(48, 13);
            this.lblContactAddress2.TabIndex = 47;
            this.lblContactAddress2.Text = "Address:";
            // 
            // lblUpdateContact
            // 
            this.lblUpdateContact.AutoSize = true;
            this.lblUpdateContact.Location = new System.Drawing.Point(27, 182);
            this.lblUpdateContact.Name = "lblUpdateContact";
            this.lblUpdateContact.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateContact.TabIndex = 46;
            this.lblUpdateContact.Text = "Contact Title:";
            // 
            // lblUpdateContactName
            // 
            this.lblUpdateContactName.AutoSize = true;
            this.lblUpdateContactName.Location = new System.Drawing.Point(27, 143);
            this.lblUpdateContactName.Name = "lblUpdateContactName";
            this.lblUpdateContactName.Size = new System.Drawing.Size(78, 13);
            this.lblUpdateContactName.TabIndex = 45;
            this.lblUpdateContactName.Text = "Contact Name:";
            // 
            // lblUpdateCompanyName
            // 
            this.lblUpdateCompanyName.AutoSize = true;
            this.lblUpdateCompanyName.Location = new System.Drawing.Point(27, 104);
            this.lblUpdateCompanyName.Name = "lblUpdateCompanyName";
            this.lblUpdateCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblUpdateCompanyName.TabIndex = 44;
            this.lblUpdateCompanyName.Text = "Company Name:";
            // 
            // lblUpdateSupplier
            // 
            this.lblUpdateSupplier.AutoSize = true;
            this.lblUpdateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateSupplier.Location = new System.Drawing.Point(23, 20);
            this.lblUpdateSupplier.Name = "lblUpdateSupplier";
            this.lblUpdateSupplier.Size = new System.Drawing.Size(205, 20);
            this.lblUpdateSupplier.TabIndex = 1;
            this.lblUpdateSupplier.Text = "Update an Existing Supplier";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(27, 53);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cmbSuppliers.TabIndex = 0;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "FrmAddSupplier";
            this.Text = "FrmAddSupplier";
            this.Load += new System.EventHandler(this.FrmAddSupplier_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddSupplier.ResumeLayout(false);
            this.tabPageAddSupplier.PerformLayout();
            this.tabPageUpdateSupplier.ResumeLayout(false);
            this.tabPageUpdateSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddSupplier;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddSupplier;
        private System.Windows.Forms.TabPage tabPageUpdateSupplier;
        private System.Windows.Forms.Label lblUpdateSupplier;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClearUpdate;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdatePostalCode;
        private System.Windows.Forms.TextBox txtUpdateRegion;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateContactTitle;
        private System.Windows.Forms.TextBox txtUpdateContactName;
        private System.Windows.Forms.TextBox txtUpdateCompanyName;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostalCode;
        private System.Windows.Forms.Label lblUpdateRegion;
        private System.Windows.Forms.Label lblContactAddress2;
        private System.Windows.Forms.Label lblUpdateContact;
        private System.Windows.Forms.Label lblUpdateContactName;
        private System.Windows.Forms.Label lblUpdateCompanyName;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.ErrorProvider errorProvider;


    }
}