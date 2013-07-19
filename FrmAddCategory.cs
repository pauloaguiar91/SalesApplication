/***************************************************************************************************/
/**                                                                                               **/
/**                                                                                               **/
/**    Student Name                :  Paulo Aguiar, Shengwei He, Greg Nikitin, Tania Rossi        **/
/**    EMail Address               :                                                              **/
/**    Student Number              :  Group 01                                                    **/
/**    Course Number               :  CST2335                                                     **/
/**    Lab Section Number          :  410-411                                                     **/
/**    Professor Name              :  John Tappin                                                 **/
/**    Assignment Name/Number/Date :  Project 02/02/December 7, 2012                              **/
/**    Optional Comments           :                                                              **/
/**                                                                                               **/
/**                                                                                               **/
/***************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NorthWind
{
    public partial class FrmAddCategory : Form
    {
        private Business business;//used to reference the Business object that owns this order/transaction
        private Category newCategory;
        private Category updatedCategory;
        private Image newImg; //cache currently selected image on add category tab page
        private Image updatedImg; //cache currently selected image on update category tab page

        public FrmAddCategory(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
            newCategory = new Category();
            updatedCategory = new Category();
        }

        #region helper methods
        /* toggles whether the rest of the controls other than id combo box in the update tab accept input*/
        private void toggleInput(bool enabled)
        {
            tbxUpdateName.Enabled = enabled;
            rtbxUpdateDescription.Enabled = enabled;
            btnUpdateChooseImg.Enabled = enabled;
            btnSubmitUpdate.Enabled = enabled;
            btnCancelUpdate.Enabled = enabled;
        }

        //resets add category tab page
        private void clearAddTabPage()
        {
            tbxAddName.Text = "";
            rtbxAddDescription.Text = "";
            pbxAddImg.Image = null;
            newCategory = new Category();
            newImg = null;
            tbxAddName.Focus();
        }

        //resets update category tab page
        private void clearUpdateTabPage()
        {
            tbxUpdateName.Text = "";
            rtbxUpdateDescription.Text = "";
            pbxUpdateImg.Image = null;
            updatedCategory = new Category();
            updatedImg = null;
            cbxUpdateId.SelectedIndex = -1;
            toggleInput(false);
            cbxUpdateId.Focus();
        }


        /* use an open file dialog to choose an image file
         * store the chosen file in a category object and display thumbnail in picture box
         * reusable for either of the 2 tabs*/
        private void chooseImage(PictureBox pbx, ref Image picture)
        {
            string chosenFile = "";
            openImageFileDialog.Title = "Choose an Image";
            openImageFileDialog.FileName = "";
            openImageFileDialog.Filter = "BITMAPS|*.bmp";
            //openImageFileDialog.ShowDialog();
            if (openImageFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                chosenFile = openImageFileDialog.FileName;
                picture = Image.FromFile(chosenFile);
                pbx.Image = Image.FromFile(chosenFile);

                //add picture to picture box representing the category of the product
                const int ThumbnailSize = 100;//create thumbnail size
                int ImageHeight = pbx.Image.Height;//get image height
                int ImageWidth = pbx.Image.Width;//get image width
                if (ImageHeight > ImageWidth)//if height is greater than width
                {
                    ImageWidth = ImageWidth * ThumbnailSize / ImageHeight;//scale width
                    ImageHeight = ThumbnailSize;//set to image height to thumbnail height
                }
                else
                {
                    ImageHeight = ImageHeight * ThumbnailSize / ImageWidth;//scale height
                    ImageWidth = ThumbnailSize;//set image width to thumbnail width
                }

                // Make thumbnail of image and put in picture box
                Image img = pbx.Image.GetThumbnailImage(ImageWidth, ImageHeight, null, System.IntPtr.Zero);
                pbx.Image = img;


            }
        }

        //always load the combobox items parallel to the Categories list in business layer
        private void loadIdCbx()
        {
            string[] id = new string[business.Categories.Count];
            for (int i = 0; i < business.Categories.Count; i++) 
            { //concatinate id with name for display purpose
                id[i] = business.Categories[i].CategoryID.ToString() + ": " + business.Categories[i].CategoryName;
            }
            cbxUpdateId.Items.Clear();
            cbxUpdateId.Items.AddRange(id);
        }

        //populate the update tab page based on category selected
        private void populateUpdateTabPage()
        {
            tbxUpdateName.Text = updatedCategory.CategoryName;
            rtbxUpdateDescription.Text = updatedCategory.Description;

            if (updatedCategory.Picture != null)
            {
                pbxUpdateImg.Image = updatedCategory.Picture;

                //add picture to picture box representing the category of the product
                const int ThumbnailSize = 100;//create thumbnail size
                int ImageHeight = pbxUpdateImg.Image.Height;//get image height
                int ImageWidth = pbxUpdateImg.Image.Width;//get image width
                if (ImageHeight > ImageWidth)//if height is greater than width
                {
                    ImageWidth = ImageWidth * ThumbnailSize / ImageHeight;//scale width
                    ImageHeight = ThumbnailSize;//set to image height to thumbnail height
                }
                else
                {
                    ImageHeight = ImageHeight * ThumbnailSize / ImageWidth;//scale height
                    ImageWidth = ThumbnailSize;//set image width to thumbnail width
                }

                // Make thumbnail of image and put in picture box
                Image img = pbxUpdateImg.Image.GetThumbnailImage(ImageWidth, ImageHeight, null, System.IntPtr.Zero);
                pbxUpdateImg.Image = img;
            }
            else
            {
                pbxUpdateImg.Image = null;
            }
        }

        //validates that a category name textbox is not empty. reusable for either tab pages
        private bool CategoryNameIsValid(TextBox tbx)
        {
            if (tbx.Text.Length == 0)
            {
                MessageBox.Show("Category Name can not be blank");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        #region control event handlers

       
        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.tbxAddName, "Enter a name for the category.");
            toolTip.SetToolTip(this.rtbxAddDescription, "Enter a description for the category.");
            toolTip.SetToolTip(this.btnAddClear, "Clears description.");
            toolTip.SetToolTip(this.btnAddRemoveImg, "Clears current image.");
            toolTip.SetToolTip(this.btnAddChooseImg, "Pick a bitmap image to represent the category.");
            toolTip.SetToolTip(this.btnClearAdd, "Clears Add Form.");
            toolTip.SetToolTip(this.btnSubmitAdd, "Add Category to Database.");
            toolTip.SetToolTip(this.btnCancelAdd, "Cancel - all information will be lost!");

            toolTip.SetToolTip(this.cbxUpdateId, "Select the category to update.");
            toolTip.SetToolTip(this.tbxUpdateName, "Edit the name for the category.");
            toolTip.SetToolTip(this.rtbxUpdateDescription, "Edit the description for the category.");
            toolTip.SetToolTip(this.btnUpdateClear, "Clears description.");
            toolTip.SetToolTip(this.btnUpdateRemoveImg, "Clears current image.");
            toolTip.SetToolTip(this.btnUpdateChooseImg, "Pick a bitmap image to replace the current picture.");
            toolTip.SetToolTip(this.btnClearUpdate, "Clears Update Form.");
            toolTip.SetToolTip(this.btnSubmitUpdate, "Update the Database with these changes.");
            toolTip.SetToolTip(this.btnCancelUpdate, "Cancel - no changes will be made and all data is lost.");
            #endregion
            loadIdCbx();
            toggleInput(false);
           

        }

        //set focus to first input control when Add New Category tab chosen
        private void tbpgAdd_Enter(object sender, EventArgs e)
        {
            ActiveControl = tbxAddName;
        }

        //set focus to first input control when Update Category tab chosen
        private void tbpgUpdate_Enter(object sender, EventArgs e)
        {
            ActiveControl = cbxUpdateId;
        }


        private void btnAddChooseImg_Click(object sender, EventArgs e)
        {
            chooseImage(pbxAddImg, ref newImg);
        }

        private void btnAddRemoveImg_Click(object sender, EventArgs e)
        {
            pbxAddImg.Image = null;
            newImg = null;
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            rtbxAddDescription.Clear();
            rtbxAddDescription.Focus();
        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            clearAddTabPage();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            clearAddTabPage();
            Close();
        }

        private void btnSubmitAdd_Click(object sender, EventArgs e)
        {
            if (!CategoryNameIsValid(tbxAddName))
                return;

            newCategory.CategoryName = tbxAddName.Text;
            newCategory.Description = rtbxAddDescription.Text;
            if (newImg != null)
                newCategory.Picture = newImg;

            MessageBox.Show(business.addNewCategory(newCategory));
            clearAddTabPage();
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            rtbxUpdateDescription.Clear();
            rtbxUpdateDescription.Focus();
        }

        private void btnUpdateChooseImg_Click(object sender, EventArgs e)
        {
            chooseImage(pbxUpdateImg, ref updatedImg);
        }

        private void btnUpdateRemoveImg_Click(object sender, EventArgs e)
        {
            pbxUpdateImg.Image = null;
            updatedImg = null;
        }

        private void cbxUpdateId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                //business.removeCategoryListener(loadIdCbx); //stop listening for changes after a selection is made
                business.reloadCategoryData();
                //listening = false;
                updatedCategory = business.Categories[((ComboBox)sender).SelectedIndex];
                populateUpdateTabPage();
                toggleInput(true); //allow input to remaining fields
            }
        }

        private void btnClearUpdate_Click(object sender, EventArgs e)
        {
            clearUpdateTabPage();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            clearUpdateTabPage();
            Close();
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (!CategoryNameIsValid(tbxUpdateName))
                return;

            updatedCategory.CategoryName = tbxUpdateName.Text;
            updatedCategory.Description = rtbxUpdateDescription.Text;
            updatedCategory.Picture = updatedImg;

            MessageBox.Show(business.updateCategory(updatedCategory));
            clearUpdateTabPage();
        }
        #endregion

         
    }
}
