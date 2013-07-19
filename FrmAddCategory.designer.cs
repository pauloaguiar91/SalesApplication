namespace NorthWind
{
    partial class FrmAddCategory
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
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbctrlCat = new System.Windows.Forms.TabControl();
            this.tbpgAdd = new System.Windows.Forms.TabPage();
            this.btnClearAdd = new System.Windows.Forms.Button();
            this.lblAddImg = new System.Windows.Forms.Label();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.btnAddRemoveImg = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSubmitAdd = new System.Windows.Forms.Button();
            this.btnAddChooseImg = new System.Windows.Forms.Button();
            this.pbxAddImg = new System.Windows.Forms.PictureBox();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.rtbxAddDescription = new System.Windows.Forms.RichTextBox();
            this.lblAddDesc = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddNewCat = new System.Windows.Forms.Label();
            this.tbpgUpdate = new System.Windows.Forms.TabPage();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateId = new System.Windows.Forms.ComboBox();
            this.lblUpdateId = new System.Windows.Forms.Label();
            this.lblUpdateImg = new System.Windows.Forms.Label();
            this.btnUpdateClear = new System.Windows.Forms.Button();
            this.btnUpdateRemoveImg = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSubmitUpdate = new System.Windows.Forms.Button();
            this.btnUpdateChooseImg = new System.Windows.Forms.Button();
            this.pbxUpdateImg = new System.Windows.Forms.PictureBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.rtbxUpdateDescription = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateCat = new System.Windows.Forms.Label();
            this.tbctrlCat.SuspendLayout();
            this.tbpgAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddImg)).BeginInit();
            this.tbpgUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateImg)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.FileName = "openImageFileDialog";
            // 
            // tbctrlCat
            // 
            this.tbctrlCat.Controls.Add(this.tbpgAdd);
            this.tbctrlCat.Controls.Add(this.tbpgUpdate);
            this.tbctrlCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlCat.Location = new System.Drawing.Point(0, 0);
            this.tbctrlCat.Name = "tbctrlCat";
            this.tbctrlCat.SelectedIndex = 0;
            this.tbctrlCat.Size = new System.Drawing.Size(624, 441);
            this.tbctrlCat.TabIndex = 0;
            // 
            // tbpgAdd
            // 
            this.tbpgAdd.Controls.Add(this.btnClearAdd);
            this.tbpgAdd.Controls.Add(this.lblAddImg);
            this.tbpgAdd.Controls.Add(this.btnAddClear);
            this.tbpgAdd.Controls.Add(this.btnAddRemoveImg);
            this.tbpgAdd.Controls.Add(this.btnCancelAdd);
            this.tbpgAdd.Controls.Add(this.btnSubmitAdd);
            this.tbpgAdd.Controls.Add(this.btnAddChooseImg);
            this.tbpgAdd.Controls.Add(this.pbxAddImg);
            this.tbpgAdd.Controls.Add(this.tbxAddName);
            this.tbpgAdd.Controls.Add(this.rtbxAddDescription);
            this.tbpgAdd.Controls.Add(this.lblAddDesc);
            this.tbpgAdd.Controls.Add(this.lblAddName);
            this.tbpgAdd.Controls.Add(this.lblAddNewCat);
            this.tbpgAdd.Location = new System.Drawing.Point(4, 22);
            this.tbpgAdd.Name = "tbpgAdd";
            this.tbpgAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAdd.Size = new System.Drawing.Size(616, 415);
            this.tbpgAdd.TabIndex = 0;
            this.tbpgAdd.Text = "Add Category";
            this.tbpgAdd.UseVisualStyleBackColor = true;
            this.tbpgAdd.Enter += new System.EventHandler(this.tbpgAdd_Enter);
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.Location = new System.Drawing.Point(353, 374);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.Size = new System.Drawing.Size(81, 23);
            this.btnClearAdd.TabIndex = 24;
            this.btnClearAdd.Text = "Clear";
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
            // 
            // lblAddImg
            // 
            this.lblAddImg.AutoSize = true;
            this.lblAddImg.Location = new System.Drawing.Point(18, 240);
            this.lblAddImg.Name = "lblAddImg";
            this.lblAddImg.Size = new System.Drawing.Size(84, 13);
            this.lblAddImg.TabIndex = 23;
            this.lblAddImg.Text = "Category Image:";
            // 
            // btnAddClear
            // 
            this.btnAddClear.Location = new System.Drawing.Point(18, 123);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 3;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // btnAddRemoveImg
            // 
            this.btnAddRemoveImg.Location = new System.Drawing.Point(22, 294);
            this.btnAddRemoveImg.Name = "btnAddRemoveImg";
            this.btnAddRemoveImg.Size = new System.Drawing.Size(75, 23);
            this.btnAddRemoveImg.TabIndex = 5;
            this.btnAddRemoveImg.Text = "Remove";
            this.btnAddRemoveImg.UseVisualStyleBackColor = true;
            this.btnAddRemoveImg.Click += new System.EventHandler(this.btnAddRemoveImg_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(527, 374);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(81, 23);
            this.btnCancelAdd.TabIndex = 7;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSubmitAdd
            // 
            this.btnSubmitAdd.Location = new System.Drawing.Point(440, 374);
            this.btnSubmitAdd.Name = "btnSubmitAdd";
            this.btnSubmitAdd.Size = new System.Drawing.Size(81, 23);
            this.btnSubmitAdd.TabIndex = 6;
            this.btnSubmitAdd.Text = "Add ";
            this.btnSubmitAdd.UseVisualStyleBackColor = true;
            this.btnSubmitAdd.Click += new System.EventHandler(this.btnSubmitAdd_Click);
            // 
            // btnAddChooseImg
            // 
            this.btnAddChooseImg.Location = new System.Drawing.Point(21, 265);
            this.btnAddChooseImg.Name = "btnAddChooseImg";
            this.btnAddChooseImg.Size = new System.Drawing.Size(100, 23);
            this.btnAddChooseImg.TabIndex = 4;
            this.btnAddChooseImg.Text = "Choose Image";
            this.btnAddChooseImg.UseVisualStyleBackColor = true;
            this.btnAddChooseImg.Click += new System.EventHandler(this.btnAddChooseImg_Click);
            // 
            // pbxAddImg
            // 
            this.pbxAddImg.Location = new System.Drawing.Point(149, 265);
            this.pbxAddImg.Name = "pbxAddImg";
            this.pbxAddImg.Size = new System.Drawing.Size(100, 100);
            this.pbxAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAddImg.TabIndex = 21;
            this.pbxAddImg.TabStop = false;
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(149, 50);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(283, 20);
            this.tbxAddName.TabIndex = 1;
            // 
            // rtbxAddDescription
            // 
            this.rtbxAddDescription.Location = new System.Drawing.Point(149, 123);
            this.rtbxAddDescription.Name = "rtbxAddDescription";
            this.rtbxAddDescription.Size = new System.Drawing.Size(283, 96);
            this.rtbxAddDescription.TabIndex = 2;
            this.rtbxAddDescription.Text = "";
            // 
            // lblAddDesc
            // 
            this.lblAddDesc.AutoSize = true;
            this.lblAddDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc.Location = new System.Drawing.Point(18, 93);
            this.lblAddDesc.Name = "lblAddDesc";
            this.lblAddDesc.Size = new System.Drawing.Size(72, 15);
            this.lblAddDesc.TabIndex = 16;
            this.lblAddDesc.Text = "Description:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(18, 50);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(95, 15);
            this.lblAddName.TabIndex = 14;
            this.lblAddName.Text = "Category Name:";
            // 
            // lblAddNewCat
            // 
            this.lblAddNewCat.AutoSize = true;
            this.lblAddNewCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCat.Location = new System.Drawing.Point(18, 13);
            this.lblAddNewCat.Name = "lblAddNewCat";
            this.lblAddNewCat.Size = new System.Drawing.Size(154, 20);
            this.lblAddNewCat.TabIndex = 1;
            this.lblAddNewCat.Text = "Add a New Category";
            // 
            // tbpgUpdate
            // 
            this.tbpgUpdate.Controls.Add(this.btnClearUpdate);
            this.tbpgUpdate.Controls.Add(this.cbxUpdateId);
            this.tbpgUpdate.Controls.Add(this.lblUpdateId);
            this.tbpgUpdate.Controls.Add(this.lblUpdateImg);
            this.tbpgUpdate.Controls.Add(this.btnUpdateClear);
            this.tbpgUpdate.Controls.Add(this.btnUpdateRemoveImg);
            this.tbpgUpdate.Controls.Add(this.btnCancelUpdate);
            this.tbpgUpdate.Controls.Add(this.btnSubmitUpdate);
            this.tbpgUpdate.Controls.Add(this.btnUpdateChooseImg);
            this.tbpgUpdate.Controls.Add(this.pbxUpdateImg);
            this.tbpgUpdate.Controls.Add(this.tbxUpdateName);
            this.tbpgUpdate.Controls.Add(this.rtbxUpdateDescription);
            this.tbpgUpdate.Controls.Add(this.lblDesc);
            this.tbpgUpdate.Controls.Add(this.lblUpdateName);
            this.tbpgUpdate.Controls.Add(this.lblUpdateCat);
            this.tbpgUpdate.Location = new System.Drawing.Point(4, 22);
            this.tbpgUpdate.Name = "tbpgUpdate";
            this.tbpgUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgUpdate.Size = new System.Drawing.Size(616, 415);
            this.tbpgUpdate.TabIndex = 1;
            this.tbpgUpdate.Text = "Update Category";
            this.tbpgUpdate.UseVisualStyleBackColor = true;
            this.tbpgUpdate.Enter += new System.EventHandler(this.tbpgUpdate_Enter);
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Location = new System.Drawing.Point(351, 374);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnClearUpdate.TabIndex = 37;
            this.btnClearUpdate.Text = "Clear";
            this.btnClearUpdate.UseVisualStyleBackColor = true;
            this.btnClearUpdate.Click += new System.EventHandler(this.btnClearUpdate_Click);
            // 
            // cbxUpdateId
            // 
            this.cbxUpdateId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateId.FormattingEnabled = true;
            this.cbxUpdateId.Location = new System.Drawing.Point(150, 48);
            this.cbxUpdateId.Name = "cbxUpdateId";
            this.cbxUpdateId.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateId.TabIndex = 8;
            this.cbxUpdateId.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateId_SelectedIndexChanged);
            // 
            // lblUpdateId
            // 
            this.lblUpdateId.AutoSize = true;
            this.lblUpdateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateId.Location = new System.Drawing.Point(21, 49);
            this.lblUpdateId.Name = "lblUpdateId";
            this.lblUpdateId.Size = new System.Drawing.Size(73, 15);
            this.lblUpdateId.TabIndex = 36;
            this.lblUpdateId.Text = "Category ID:";
            // 
            // lblUpdateImg
            // 
            this.lblUpdateImg.AutoSize = true;
            this.lblUpdateImg.Location = new System.Drawing.Point(21, 236);
            this.lblUpdateImg.Name = "lblUpdateImg";
            this.lblUpdateImg.Size = new System.Drawing.Size(84, 13);
            this.lblUpdateImg.TabIndex = 35;
            this.lblUpdateImg.Text = "Category Image:";
            // 
            // btnUpdateClear
            // 
            this.btnUpdateClear.Location = new System.Drawing.Point(24, 151);
            this.btnUpdateClear.Name = "btnUpdateClear";
            this.btnUpdateClear.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateClear.TabIndex = 11;
            this.btnUpdateClear.Text = "Clear";
            this.btnUpdateClear.UseVisualStyleBackColor = true;
            this.btnUpdateClear.Click += new System.EventHandler(this.btnUpdateClear_Click);
            // 
            // btnUpdateRemoveImg
            // 
            this.btnUpdateRemoveImg.Location = new System.Drawing.Point(23, 292);
            this.btnUpdateRemoveImg.Name = "btnUpdateRemoveImg";
            this.btnUpdateRemoveImg.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRemoveImg.TabIndex = 13;
            this.btnUpdateRemoveImg.Text = "Remove";
            this.btnUpdateRemoveImg.UseVisualStyleBackColor = true;
            this.btnUpdateRemoveImg.Click += new System.EventHandler(this.btnUpdateRemoveImg_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(528, 374);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnCancelUpdate.TabIndex = 15;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSubmitUpdate
            // 
            this.btnSubmitUpdate.Location = new System.Drawing.Point(443, 374);
            this.btnSubmitUpdate.Name = "btnSubmitUpdate";
            this.btnSubmitUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnSubmitUpdate.TabIndex = 14;
            this.btnSubmitUpdate.Text = "Update";
            this.btnSubmitUpdate.UseVisualStyleBackColor = true;
            this.btnSubmitUpdate.Click += new System.EventHandler(this.btnSubmitUpdate_Click);
            // 
            // btnUpdateChooseImg
            // 
            this.btnUpdateChooseImg.Location = new System.Drawing.Point(21, 263);
            this.btnUpdateChooseImg.Name = "btnUpdateChooseImg";
            this.btnUpdateChooseImg.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateChooseImg.TabIndex = 12;
            this.btnUpdateChooseImg.Text = "Choose Image";
            this.btnUpdateChooseImg.UseVisualStyleBackColor = true;
            this.btnUpdateChooseImg.Click += new System.EventHandler(this.btnUpdateChooseImg_Click);
            // 
            // pbxUpdateImg
            // 
            this.pbxUpdateImg.Location = new System.Drawing.Point(150, 263);
            this.pbxUpdateImg.Name = "pbxUpdateImg";
            this.pbxUpdateImg.Size = new System.Drawing.Size(100, 100);
            this.pbxUpdateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxUpdateImg.TabIndex = 33;
            this.pbxUpdateImg.TabStop = false;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(150, 92);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(283, 20);
            this.tbxUpdateName.TabIndex = 9;
            // 
            // rtbxUpdateDescription
            // 
            this.rtbxUpdateDescription.Location = new System.Drawing.Point(150, 132);
            this.rtbxUpdateDescription.Name = "rtbxUpdateDescription";
            this.rtbxUpdateDescription.Size = new System.Drawing.Size(283, 96);
            this.rtbxUpdateDescription.TabIndex = 10;
            this.rtbxUpdateDescription.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(21, 123);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 15);
            this.lblDesc.TabIndex = 28;
            this.lblDesc.Text = "Description:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateName.Location = new System.Drawing.Point(21, 92);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(95, 15);
            this.lblUpdateName.TabIndex = 26;
            this.lblUpdateName.Text = "Category Name:";
            // 
            // lblUpdateCat
            // 
            this.lblUpdateCat.AutoSize = true;
            this.lblUpdateCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCat.Location = new System.Drawing.Point(19, 11);
            this.lblUpdateCat.Name = "lblUpdateCat";
            this.lblUpdateCat.Size = new System.Drawing.Size(143, 20);
            this.lblUpdateCat.TabIndex = 24;
            this.lblUpdateCat.Text = "Update a Category";
            // 
            // FrmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tbctrlCat);
            this.Name = "FrmAddCategory";
            this.Text = "FrmAddCategory";
            this.Load += new System.EventHandler(this.FrmAddCategory_Load);
            this.tbctrlCat.ResumeLayout(false);
            this.tbpgAdd.ResumeLayout(false);
            this.tbpgAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddImg)).EndInit();
            this.tbpgUpdate.ResumeLayout(false);
            this.tbpgUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdateImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.TabControl tbctrlCat;
        private System.Windows.Forms.TabPage tbpgAdd;
        private System.Windows.Forms.Label lblAddImg;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Button btnAddRemoveImg;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSubmitAdd;
        private System.Windows.Forms.Button btnAddChooseImg;
        private System.Windows.Forms.PictureBox pbxAddImg;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.RichTextBox rtbxAddDescription;
        private System.Windows.Forms.Label lblAddDesc;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddNewCat;
        private System.Windows.Forms.TabPage tbpgUpdate;
        private System.Windows.Forms.Label lblUpdateImg;
        private System.Windows.Forms.Button btnUpdateClear;
        private System.Windows.Forms.Button btnUpdateRemoveImg;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSubmitUpdate;
        private System.Windows.Forms.Button btnUpdateChooseImg;
        private System.Windows.Forms.PictureBox pbxUpdateImg;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.RichTextBox rtbxUpdateDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateCat;
        private System.Windows.Forms.ComboBox cbxUpdateId;
        private System.Windows.Forms.Label lblUpdateId;
        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.Button btnClearUpdate;
    }
}