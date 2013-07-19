namespace NorthWind
{
    partial class FrmConfirmation
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
            this.lblPostalDisplay = new System.Windows.Forms.Label();
            this.lblCityDisplay = new System.Windows.Forms.Label();
            this.lblAddressDisplay = new System.Windows.Forms.Label();
            this.lblCustDisplay = new System.Windows.Forms.Label();
            this.lblClerkDisplay = new System.Windows.Forms.Label();
            this.lblClerksName = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSubTotalTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblPSTTotal = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblGSTTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDisplay = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrderIDDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPostalDisplay
            // 
            this.lblPostalDisplay.AutoSize = true;
            this.lblPostalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalDisplay.Location = new System.Drawing.Point(132, 89);
            this.lblPostalDisplay.Name = "lblPostalDisplay";
            this.lblPostalDisplay.Size = new System.Drawing.Size(64, 13);
            this.lblPostalDisplay.TabIndex = 14;
            this.lblPostalDisplay.Text = "code here";
            // 
            // lblCityDisplay
            // 
            this.lblCityDisplay.AutoSize = true;
            this.lblCityDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityDisplay.Location = new System.Drawing.Point(28, 89);
            this.lblCityDisplay.Name = "lblCityDisplay";
            this.lblCityDisplay.Size = new System.Drawing.Size(56, 13);
            this.lblCityDisplay.TabIndex = 13;
            this.lblCityDisplay.Text = "city here";
            // 
            // lblAddressDisplay
            // 
            this.lblAddressDisplay.AutoSize = true;
            this.lblAddressDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressDisplay.Location = new System.Drawing.Point(29, 54);
            this.lblAddressDisplay.Name = "lblAddressDisplay";
            this.lblAddressDisplay.Size = new System.Drawing.Size(282, 13);
            this.lblAddressDisplay.TabIndex = 12;
            this.lblAddressDisplay.Text = "Address appears here                                      ";
            // 
            // lblCustDisplay
            // 
            this.lblCustDisplay.AutoSize = true;
            this.lblCustDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustDisplay.Location = new System.Drawing.Point(29, 23);
            this.lblCustDisplay.Name = "lblCustDisplay";
            this.lblCustDisplay.Size = new System.Drawing.Size(170, 13);
            this.lblCustDisplay.TabIndex = 11;
            this.lblCustDisplay.Text = "customer name appears here";
            // 
            // lblClerkDisplay
            // 
            this.lblClerkDisplay.AutoSize = true;
            this.lblClerkDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClerkDisplay.Location = new System.Drawing.Point(455, 23);
            this.lblClerkDisplay.Name = "lblClerkDisplay";
            this.lblClerkDisplay.Size = new System.Drawing.Size(24, 13);
            this.lblClerkDisplay.TabIndex = 10;
            this.lblClerkDisplay.Text = "NA";
            // 
            // lblClerksName
            // 
            this.lblClerksName.AutoSize = true;
            this.lblClerksName.Location = new System.Drawing.Point(455, 9);
            this.lblClerksName.Name = "lblClerksName";
            this.lblClerksName.Size = new System.Drawing.Size(70, 13);
            this.lblClerksName.TabIndex = 9;
            this.lblClerksName.Text = "Clerks Name:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(132, 76);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 3;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(29, 76);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(29, 9);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(85, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 41);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblSubTotalTotal
            // 
            this.lblSubTotalTotal.AutoSize = true;
            this.lblSubTotalTotal.Location = new System.Drawing.Point(560, 342);
            this.lblSubTotalTotal.Name = "lblSubTotalTotal";
            this.lblSubTotalTotal.Size = new System.Drawing.Size(34, 13);
            this.lblSubTotalTotal.TabIndex = 10;
            this.lblSubTotalTotal.Text = "$0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(496, 342);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Location = new System.Drawing.Point(505, 360);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(40, 13);
            this.lblPST.TabIndex = 3;
            this.lblPST.Text = "P.S.T.:";
            // 
            // lblPSTTotal
            // 
            this.lblPSTTotal.AutoSize = true;
            this.lblPSTTotal.Location = new System.Drawing.Point(560, 360);
            this.lblPSTTotal.Name = "lblPSTTotal";
            this.lblPSTTotal.Size = new System.Drawing.Size(34, 13);
            this.lblPSTTotal.TabIndex = 4;
            this.lblPSTTotal.Text = "$0.00";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(504, 378);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(41, 13);
            this.lblGST.TabIndex = 5;
            this.lblGST.Text = "G.S.T.:";
            // 
            // lblGSTTotal
            // 
            this.lblGSTTotal.AutoSize = true;
            this.lblGSTTotal.Location = new System.Drawing.Point(560, 378);
            this.lblGSTTotal.Name = "lblGSTTotal";
            this.lblGSTTotal.Size = new System.Drawing.Size(34, 13);
            this.lblGSTTotal.TabIndex = 6;
            this.lblGSTTotal.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(511, 397);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalDisplay
            // 
            this.lblTotalDisplay.AutoSize = true;
            this.lblTotalDisplay.Location = new System.Drawing.Point(560, 397);
            this.lblTotalDisplay.Name = "lblTotalDisplay";
            this.lblTotalDisplay.Size = new System.Drawing.Size(34, 13);
            this.lblTotalDisplay.TabIndex = 8;
            this.lblTotalDisplay.Text = "$0.00";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(519, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.AllowUserToAddRows = false;
            this.gridOrderDetails.AllowUserToDeleteRows = false;
            this.gridOrderDetails.AllowUserToResizeColumns = false;
            this.gridOrderDetails.AllowUserToResizeRows = false;
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colProductID,
            this.colUnitPrice,
            this.colQuantity,
            this.colTotal});
            this.gridOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOrderDetails.Location = new System.Drawing.Point(24, 114);
            this.gridOrderDetails.MultiSelect = false;
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.ReadOnly = true;
            this.gridOrderDetails.RowHeadersVisible = false;
            this.gridOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrderDetails.Size = new System.Drawing.Size(583, 225);
            this.gridOrderDetails.TabIndex = 0;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 120;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Width = 150;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 110;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // lblOrderIDDisplay
            // 
            this.lblOrderIDDisplay.AutoSize = true;
            this.lblOrderIDDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDDisplay.Location = new System.Drawing.Point(511, 89);
            this.lblOrderIDDisplay.Name = "lblOrderIDDisplay";
            this.lblOrderIDDisplay.Size = new System.Drawing.Size(24, 13);
            this.lblOrderIDDisplay.TabIndex = 16;
            this.lblOrderIDDisplay.Text = "NA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order ID:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(455, 54);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(90, 13);
            this.lblDateTime.TabIndex = 17;
            this.lblDateTime.Text = "Date and Time";
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 60000;
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // FrmConfirmation
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblOrderIDDisplay);
            this.Controls.Add(this.lblSubTotalTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridOrderDetails);
            this.Controls.Add(this.lblPostalDisplay);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblCityDisplay);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblAddressDisplay);
            this.Controls.Add(this.lblCustDisplay);
            this.Controls.Add(this.lblPSTTotal);
            this.Controls.Add(this.lblClerkDisplay);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblClerksName);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblTotalDisplay);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblGSTTotal);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAddress);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmConfirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.FrmConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblPSTTotal;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblGSTTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDisplay;
        private System.Windows.Forms.Label lblPostalDisplay;
        private System.Windows.Forms.Label lblCityDisplay;
        private System.Windows.Forms.Label lblAddressDisplay;
        private System.Windows.Forms.Label lblCustDisplay;
        private System.Windows.Forms.Label lblClerkDisplay;
        private System.Windows.Forms.Label lblClerksName;
        private System.Windows.Forms.DataGridView gridOrderDetails;
        private System.Windows.Forms.Label lblSubTotalTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblOrderIDDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;


    }
}