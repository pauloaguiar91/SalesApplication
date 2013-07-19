namespace NorthWind
{
    partial class FrmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Catalog = new System.Windows.Forms.Button();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.cmbCustID = new System.Windows.Forms.ComboBox();
            this.cmbClerks = new System.Windows.Forms.ComboBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblClerk = new System.Windows.Forms.Label();
            this.gridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Catalog
            // 
            this.btn_Catalog.Location = new System.Drawing.Point(524, 135);
            this.btn_Catalog.Name = "btn_Catalog";
            this.btn_Catalog.Size = new System.Drawing.Size(81, 22);
            this.btn_Catalog.TabIndex = 3;
            this.btn_Catalog.Text = "Catalog";
            this.btn_Catalog.Click += new System.EventHandler(this.btn_Catalog_Click);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RemoveItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RemoveItem.Location = new System.Drawing.Point(524, 163);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(81, 22);
            this.btn_RemoveItem.TabIndex = 4;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = false;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // cmbCustName
            // 
            this.cmbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.ItemHeight = 13;
            this.cmbCustName.Location = new System.Drawing.Point(20, 46);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(225, 21);
            this.cmbCustName.TabIndex = 0;
            this.cmbCustName.SelectedIndexChanged += new System.EventHandler(this.cmbCustName_SelectedIndexChanged);
            // 
            // cmbCustID
            // 
            this.cmbCustID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustID.FormattingEnabled = true;
            this.cmbCustID.Location = new System.Drawing.Point(20, 95);
            this.cmbCustID.Name = "cmbCustID";
            this.cmbCustID.Size = new System.Drawing.Size(121, 21);
            this.cmbCustID.TabIndex = 1;
            this.cmbCustID.SelectedIndexChanged += new System.EventHandler(this.cmbCustID_SelectedIndexChanged);
            // 
            // cmbClerks
            // 
            this.cmbClerks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClerks.FormattingEnabled = true;
            this.cmbClerks.Location = new System.Drawing.Point(483, 46);
            this.cmbClerks.Name = "cmbClerks";
            this.cmbClerks.Size = new System.Drawing.Size(121, 21);
            this.cmbClerks.TabIndex = 2;
            this.cmbClerks.SelectedIndexChanged += new System.EventHandler(this.cmbClerks_SelectedIndexChanged);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(20, 29);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(82, 13);
            this.lblCustName.TabIndex = 17;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(20, 79);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 18;
            this.lblCustID.Text = "Customer ID";
            // 
            // lblClerk
            // 
            this.lblClerk.AutoSize = true;
            this.lblClerk.Location = new System.Drawing.Point(480, 29);
            this.lblClerk.Name = "lblClerk";
            this.lblClerk.Size = new System.Drawing.Size(62, 13);
            this.lblClerk.TabIndex = 19;
            this.lblClerk.Text = "Clerk Name";
            // 
            // gridViewOrderDetails
            // 
            this.gridViewOrderDetails.AllowUserToAddRows = false;
            this.gridViewOrderDetails.AllowUserToDeleteRows = false;
            this.gridViewOrderDetails.AllowUserToResizeColumns = false;
            this.gridViewOrderDetails.AllowUserToResizeRows = false;
            this.gridViewOrderDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colProductID,
            this.colUnitPrice,
            this.colQuantity});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewOrderDetails.Location = new System.Drawing.Point(20, 135);
            this.gridViewOrderDetails.Name = "gridViewOrderDetails";
            this.gridViewOrderDetails.RowHeadersVisible = false;
            this.gridViewOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewOrderDetails.Size = new System.Drawing.Size(498, 264);
            this.gridViewOrderDetails.TabIndex = 20;
            this.gridViewOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewOrderDetails_CellEndEdit);
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Width = 130;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 85;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQuantity.HeaderText = "Choose Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ToolTipText = "Please Select Quantity";
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 60000;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(480, 7);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(59, 13);
            this.lblDateTime.TabIndex = 21;
            this.lblDateTime.Text = "Date & Time";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(524, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 22);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(544, 407);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(68, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(470, 407);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(68, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.lblClerk);
            this.Controls.Add(this.gridViewOrderDetails);
            this.Controls.Add(this.cmbCustID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.cmbClerks);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btn_RemoveItem);
            this.Controls.Add(this.cmbCustName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Catalog);
            this.Name = "FrmOrder";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Catalog;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.ComboBox cmbCustID;
        private System.Windows.Forms.ComboBox cmbClerks;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblClerk;
        private System.Windows.Forms.DataGridView gridViewOrderDetails;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;

    }
}