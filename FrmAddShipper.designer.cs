namespace NorthWind
{
    partial class FrmAddShipper
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
            this.tabPageAddShipper = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAddShipper = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tabPageUpdateShipper = new System.Windows.Forms.TabPage();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateCompanyName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber2 = new System.Windows.Forms.Label();
            this.lblCompanyName2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAddShipper.SuspendLayout();
            this.tabPageUpdateShipper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddShipper);
            this.tabControl1.Controls.Add(this.tabPageUpdateShipper);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 262);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageAddShipper
            // 
            this.tabPageAddShipper.AccessibleName = "tabPageAddShipper";
            this.tabPageAddShipper.Controls.Add(this.btnCancel);
            this.tabPageAddShipper.Controls.Add(this.btnAdd);
            this.tabPageAddShipper.Controls.Add(this.btnClear);
            this.tabPageAddShipper.Controls.Add(this.lblAddShipper);
            this.tabPageAddShipper.Controls.Add(this.txtPhone);
            this.tabPageAddShipper.Controls.Add(this.txtCompanyName);
            this.tabPageAddShipper.Controls.Add(this.lblPhoneNumber);
            this.tabPageAddShipper.Controls.Add(this.lblCompanyName);
            this.tabPageAddShipper.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddShipper.Name = "tabPageAddShipper";
            this.tabPageAddShipper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddShipper.Size = new System.Drawing.Size(616, 236);
            this.tabPageAddShipper.TabIndex = 0;
            this.tabPageAddShipper.Text = "Add Shipper";
            this.tabPageAddShipper.UseVisualStyleBackColor = true;
            this.tabPageAddShipper.Enter += new System.EventHandler(this.tabPageAddShipper_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(444, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAddShipper
            // 
            this.lblAddShipper.AutoSize = true;
            this.lblAddShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShipper.Location = new System.Drawing.Point(23, 30);
            this.lblAddShipper.Name = "lblAddShipper";
            this.lblAddShipper.Size = new System.Drawing.Size(145, 20);
            this.lblAddShipper.TabIndex = 20;
            this.lblAddShipper.Text = "Add a New Shipper";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(132, 81);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 123);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(25, 81);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 16;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // tabPageUpdateShipper
            // 
            this.tabPageUpdateShipper.AccessibleName = "tabPageUpdateShipper";
            this.tabPageUpdateShipper.Controls.Add(this.btnCancelUpdate);
            this.tabPageUpdateShipper.Controls.Add(this.btnUpdate);
            this.tabPageUpdateShipper.Controls.Add(this.btnClearUpdate);
            this.tabPageUpdateShipper.Controls.Add(this.txtUpdatePhone);
            this.tabPageUpdateShipper.Controls.Add(this.txtUpdateCompanyName);
            this.tabPageUpdateShipper.Controls.Add(this.lblPhoneNumber2);
            this.tabPageUpdateShipper.Controls.Add(this.lblCompanyName2);
            this.tabPageUpdateShipper.Controls.Add(this.label1);
            this.tabPageUpdateShipper.Controls.Add(this.cmbShippers);
            this.tabPageUpdateShipper.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateShipper.Name = "tabPageUpdateShipper";
            this.tabPageUpdateShipper.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateShipper.Size = new System.Drawing.Size(616, 236);
            this.tabPageUpdateShipper.TabIndex = 1;
            this.tabPageUpdateShipper.Text = "UpdateShipper";
            this.tabPageUpdateShipper.UseVisualStyleBackColor = true;
            this.tabPageUpdateShipper.Enter += new System.EventHandler(this.tabPageUpdateShipper_Enter);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.AccessibleName = "btnCancel2";
            this.btnCancelUpdate.Location = new System.Drawing.Point(533, 210);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnCancelUpdate.TabIndex = 30;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(447, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Location = new System.Drawing.Point(361, 210);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnClearUpdate.TabIndex = 28;
            this.btnClearUpdate.Text = "Clear";
            this.btnClearUpdate.UseVisualStyleBackColor = true;
            this.btnClearUpdate.Click += new System.EventHandler(this.btnClearUpdate_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(131, 165);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePhone.TabIndex = 27;
            // 
            // txtUpdateCompanyName
            // 
            this.txtUpdateCompanyName.Location = new System.Drawing.Point(131, 126);
            this.txtUpdateCompanyName.Name = "txtUpdateCompanyName";
            this.txtUpdateCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCompanyName.TabIndex = 26;
            // 
            // lblPhoneNumber2
            // 
            this.lblPhoneNumber2.AutoSize = true;
            this.lblPhoneNumber2.Location = new System.Drawing.Point(24, 168);
            this.lblPhoneNumber2.Name = "lblPhoneNumber2";
            this.lblPhoneNumber2.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber2.TabIndex = 25;
            this.lblPhoneNumber2.Text = "Phone Number:";
            // 
            // lblCompanyName2
            // 
            this.lblCompanyName2.AutoSize = true;
            this.lblCompanyName2.Location = new System.Drawing.Point(24, 126);
            this.lblCompanyName2.Name = "lblCompanyName2";
            this.lblCompanyName2.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName2.TabIndex = 24;
            this.lblCompanyName2.Text = "Company Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update an Existing Shipper";
            // 
            // cmbShippers
            // 
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(27, 64);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(121, 21);
            this.cmbShippers.TabIndex = 0;
            this.cmbShippers.SelectedIndexChanged += new System.EventHandler(this.cmbShippers_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAddShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmAddShipper";
            this.Text = "FrmAddShipper";
            this.Load += new System.EventHandler(this.FrmAddShipper_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddShipper.ResumeLayout(false);
            this.tabPageAddShipper.PerformLayout();
            this.tabPageUpdateShipper.ResumeLayout(false);
            this.tabPageUpdateShipper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddShipper;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAddShipper;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TabPage tabPageUpdateShipper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShippers;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClearUpdate;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateCompanyName;
        private System.Windows.Forms.Label lblPhoneNumber2;
        private System.Windows.Forms.Label lblCompanyName2;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}