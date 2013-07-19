/***************************************************************************************************/
/**                                                                                               **/
/**                                                                                               **/
/**    Student Name                :  Paulo Aguiar, Shengwei He, Greg Nikitin, Tania Rossi        **/
/**    EMail Address               :                                                              **/
/**    Student Number              :  Group 01                                                    **/
/**    Course Number               :  CST2335                                                     **/
/**    Lab Section Number          :  410-411                                                     **/
/**    Professor Name              :  John Tappin                                                 **/
/**    Assignment Name/Number/Date :  Project 2                                                   **/
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

namespace NorthWind
{
    public partial class FrmAddShipper : Form
    {

        #region member variables
        private Business business;
        private List<Shipper> shippers;
        private Shipper newShipper;
        private Shipper updatedShipper;
        #endregion


        #region constructor
        /// <summary>
        /// FrmAddShipper()
        /// Form Constructor
        /// </summary>
        /// <param name="businessArg"></param>
        public FrmAddShipper(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
            newShipper = new Shipper();
            updatedShipper = new Shipper();

        }
        #endregion


        #region form load
        /// <summary>
        /// FrmAddShipper_Load
        /// Event handler for when the form loads. calls the fill shippers method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddShipper_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip toolTip = new ToolTip();

            //Add New Shipper Tab ToolTips
            toolTip.SetToolTip(txtCompanyName, "Name of Shipping Company");
            toolTip.SetToolTip(txtPhone, "Phone number includes country code or area code");


            toolTip.SetToolTip(btnClear, "Clears all fields on form");
            toolTip.SetToolTip(btnAdd, "Add new products to database");
            toolTip.SetToolTip(btnCancel, "Cancels order and closes form");

            //Update Shipper Tab ToolTips
            toolTip.SetToolTip(this.cmbShippers, "Select an Shipper to Update");

            toolTip.SetToolTip(txtUpdateCompanyName, "Name of Shipping Company");
            toolTip.SetToolTip(txtUpdatePhone, "Phone number includes country code or area code");


            toolTip.SetToolTip(btnClearUpdate, "Clears all fields on form");
            toolTip.SetToolTip(btnUpdate, "Updates product in database");
            toolTip.SetToolTip(btnCancelUpdate, "Cancels order and closes form");

            #endregion

            fillShippers();

            toggleInput(false);//disable controls on Update form
        }
        #endregion


        #region form helper methods
        /// <summary>
        /// fillShippers()
        /// This method is used for loading the company names into the combobox
        /// </summary>
        private void fillShippers()
        {
            cmbShippers.Items.Clear();
            shippers = business.Shippers; //get most recent copy of shippers from business layer
            foreach (Shipper s in shippers)
            {
               cmbShippers.Items.Add(s);
            }
        }
        #endregion


        #region control methods

        /// <summary>
        /// tabPageAddShipper_Enter()
        /// Sets focus to first control on New Shipper Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageAddShipper_Enter(object sender, EventArgs e)
        {
            ActiveControl = txtCompanyName;
        }

        /// <summary>
        /// tabPageUpdateShipper_Enter()
        /// Sets focus to first control on Add Shipper Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageUpdateShipper_Enter(object sender, EventArgs e)
        {
            ActiveControl = cmbShippers;
        }


        /// <summary>
        /// cmbShippers_SelectedIndexChanged()
        /// Event handler for when the combobox field has been changed. Sets the appropriate values to the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbShippers, "");

            Shipper s = (Shipper)cmbShippers.SelectedItem;

            toggleInput(true);//enable controls on Update Page

            if (cmbShippers.SelectedIndex != -1)
            {
                txtUpdateCompanyName.Text = s.CompanyName.ToString();
                txtUpdatePhone.Text = s.Phone.ToString();
            }
        }


        /// <summary>
        /// btnClear_Click()
        /// Event handler for the clear button on the add shipper tab. Clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtPhone.Text = "";
            cmbShippers.SelectedIndex = -1;
        }

        /// <summary>
        /// btnClearUpdate_Click()
        /// Event handler for the clear button on the update shipper tab. Clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearUpdate_Click(object sender, EventArgs e)
        {
            cmbShippers.SelectedIndex = -1;
            txtUpdateCompanyName.Text = "";
            txtUpdatePhone.Text = "";
            toggleInput(false);//disable controls on Update form
        }

        /// <summary>
        /// btnAdd_Click()
        /// Event handler for when user chooses Add button on the Add Shippers tab, the shipper information is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!frmValidated())
                return;

            string confirmation = business.addShipper(newShipper);

            MessageBox.Show(confirmation);

            btnClear_Click(sender, e);

            fillShippers();
        }

        /// <summary>
        /// btnUpdate_Click()
        /// Event handler for when user chooses Update button on the Update Shippers tab, the shipper information is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!updateFrmValidated())
                return;
            
            string confirmation = business.updateShipper(updatedShipper);

            MessageBox.Show(confirmation);

            btnClearUpdate_Click(sender, e);

            fillShippers();
        }

        /// <summary>
        /// btnCancel_Click()
        /// Event handler for when the cancel button is clicked on the add shipper form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btnCancelUpdate_Click()
        /// Event handler for when the cancel button is clicked on the update shipper form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region toggle xontrols
        /// <summary>
        /// toggleInput()
        /// Used to enable controls on update form when an Employee is chosen from dropdown menu.
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleInput(bool enabled)
        {
            txtUpdateCompanyName.Enabled = enabled;
            txtUpdatePhone.Enabled = enabled;

        }

        #endregion


        #region form validation
        /// <summary>
        /// frmValidated()
        /// contains logic to validate form controls that user modifies on Add Shipper form
        /// </summary>
        /// <returns></returns>
        private bool frmValidated()
        {
            bool result = true;
            errorProvider.Clear();

            if (txtCompanyName.Text == null || txtCompanyName.Text == "")
            {
                errorProvider.SetError(txtCompanyName, "Please enter a Company Name");
                result = false;
            }

            else
            {
                newShipper.CompanyName = txtCompanyName.Text;
            }


            //set properties
            newShipper.Phone = txtPhone.Text;
            

            return result;
        }
            
        /// <summary>
        /// updateFrmValidated()
        /// contains logic to validate form controls that user modifies on update form
        /// </summary>
        /// <returns></returns>
            private bool updateFrmValidated() 
            {
            bool result = true;
            errorProvider.Clear();

            if (cmbShippers.SelectedIndex != -1)
                updatedShipper.ShipperID = ((Shipper)cmbShippers.SelectedItem).ShipperID;
            else 
            {
                errorProvider.SetError(cmbShippers, "Please choose a shipper to update");
                return false;
            }

            if(txtUpdateCompanyName.Text == null || txtUpdateCompanyName.Text == "") 
            {
                 errorProvider.SetError(txtUpdateCompanyName, "Please enter a Company Name");
                 result = false;
            }

            else
            {
                updatedShipper.CompanyName = txtUpdateCompanyName.Text;
            }
    
            
            //set properties
            updatedShipper.Phone = txtUpdatePhone.Text;
            

           return result;
        }

        #endregion



    }
}
