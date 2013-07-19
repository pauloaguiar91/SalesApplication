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
    public partial class FrmAddSupplier : Form
    {   

        #region member variables
        private Business business;
        private List<Supplier> suppliers;
        private Supplier newSupplier;
        private Supplier updatedSupplier;
        #endregion


        #region constructor
        /// <summary>
        /// Form Constructor
        /// </summary>
        /// <param name="businessArg"></param>
        public FrmAddSupplier(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
            newSupplier = new Supplier();
            updatedSupplier = new Supplier();
        }
        #endregion


        #region form load
        /// <summary>
        /// FrmAddSupplier_Load()
        /// Event handler for when the form loads. calls the fill suppliers method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip toolTip = new ToolTip();

            //Add New Supplier Tab ToolTips
            toolTip.SetToolTip(txtCompanyName, "Name of Supplier Company");
            toolTip.SetToolTip(txtContactName, "Contact Person for Supplier Company");
            toolTip.SetToolTip(txtContactTitle, "Contact Title of Contact Person for Supplier Company");
            toolTip.SetToolTip(txtAddress, "Street or post-office box");
            toolTip.SetToolTip(txtCity, "City where Supplier lives");
            toolTip.SetToolTip(txtRegion, "State or Province");
            toolTip.SetToolTip(txtPostalCode, "Company Postal Code");
            toolTip.SetToolTip(txtCountry, "Country");
            toolTip.SetToolTip(txtPhone, "Phone number includes country code or area code");
            

            toolTip.SetToolTip(btnClear, "Clears all fields on form");
            toolTip.SetToolTip(btnAdd, "Add new products to database");
            toolTip.SetToolTip(btnCancel, "Cancels order and closes form");

            //Update Supplier Tab ToolTips
            toolTip.SetToolTip(this.cmbSuppliers, "Select an Supplier to Update");

            toolTip.SetToolTip(txtUpdateCompanyName, "Name of Supplier Company");
            toolTip.SetToolTip(txtUpdateContactName, "Contact Person for Supplier Company");
            toolTip.SetToolTip(txtUpdateContactTitle, "Contact Title of Contact Person for Supplier Company");
            toolTip.SetToolTip(txtUpdateAddress, "Street or post-office box");
            toolTip.SetToolTip(txtUpdateCity, "City where Supplier lives");
            toolTip.SetToolTip(txtUpdateRegion, "State or Province");
            toolTip.SetToolTip(txtUpdatePostalCode, "Company Postal Code");
            toolTip.SetToolTip(txtUpdateCountry, "Country");
            toolTip.SetToolTip(txtUpdatePhone, "Phone number includes country code or area code");


            toolTip.SetToolTip(btnClearUpdate, "Clears all fields on form");
            toolTip.SetToolTip(btnUpdate, "Updates product in database");
            toolTip.SetToolTip(btnCancelUpdate, "Cancels order and closes form");

            #endregion

            fillSuppliers();

            toggleInput(false);//disable controls on Update form
        }
        #endregion


        #region form helper methods
        /// <summary>
        /// fillSuppliers()
        /// This method is used for loading the supplier names into the combobox
        /// </summary>
        private void fillSuppliers()
        {
            cmbSuppliers.Items.Clear();

            suppliers = business.Suppliers;//get most recent copy of suppliers from business layer

            foreach (Supplier s in suppliers)
            {
                cmbSuppliers.Items.Add(s);//object.ShipperID
            }
        }
        #endregion


        #region control methods

        /// <summary>
        /// tabPageAddSupplier_Enter()
        /// Sets focus to first control on New Supplier Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageAddSupplier_Enter(object sender, EventArgs e)
        {
            ActiveControl = txtCompanyName;
        }

        /// <summary>
        /// tabPageUpdateSupplier_Enter()
        /// Sets focus to first control on Update Supplier Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageUpdateSupplier_Enter(object sender, EventArgs e)
        {
            ActiveControl = cmbSuppliers;
        }


        /// <summary>
        /// cmbSuppliers_SelectedIndexChanged()
        /// Event handler for when the combobox field has been changed. Sets the appropriate values to the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbSuppliers, "");

            Supplier s = (Supplier)cmbSuppliers.SelectedItem;

            toggleInput(true); //enable controls on Update form

            if (cmbSuppliers.SelectedIndex != -1)
            {
                txtUpdateCompanyName.Text = s.CompanyName;
                txtUpdateContactName.Text = s.ContactName;
                txtUpdateContactTitle.Text = s.ContactTitle;
                txtUpdateAddress.Text = s.Address;
                txtUpdateCity.Text = s.City;
                txtUpdateRegion.Text = s.Region;
                txtUpdatePostalCode.Text = s.PostalCode;
                txtUpdateCountry.Text = s.Country;
                txtUpdatePhone.Text = s.PostalCode;
            }
        }

        /// <summary>
        /// btnClear_Click()
        /// Event handler for the clear button on the add supplier tab. Clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
        }

        /// <summary>
        /// btnClearUpdate_Click()
        /// Event handler for the clear button on the update supplier tab. Clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearUpdate_Click(object sender, EventArgs e)
        {
            
            cmbSuppliers.SelectedIndex = -1;
            txtUpdateCompanyName.Text = "";
            txtUpdateContactName.Text = "";
            txtUpdateContactTitle.Text = "";
            txtUpdateAddress.Text = "";
            txtUpdateCity.Text = "";
            txtUpdateRegion.Text = "";
            txtUpdatePostalCode.Text = "";
            txtUpdateCountry.Text = "";
            txtUpdatePhone.Text = "";
            errorProvider.Clear();
            toggleInput(false);

        }


        /// <summary>
        /// btnAdd_Click()
        /// Event handler for when user chooses Add button on the Add Suppliers tab, the supplier information is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!frmValidated())
                return;

            string confirmation = business.addSupplier(newSupplier); 

            MessageBox.Show(confirmation);

            btnClear_Click(sender, e);

            fillSuppliers();
        }


        /// <summary>
        /// btnUpdate_Click()
        /// Event handler for when user chooses Update button on the Update Suppliers tab, the supplier information is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!updateFrmValidated())
                return;

            string confirmation = business.updateSupplier(updatedSupplier);

            MessageBox.Show(confirmation);

            btnClearUpdate_Click(sender, e);

            fillSuppliers();
        }


        /// <summary>
        /// btnCancel_Click()
        /// Event handler for the cancel button on the add supplier tab. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        /// <summary>
        /// btnCancelUpdate_Click()
        /// Event handler for the cancel button on the update supplier tab. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        #region toggle controls
        /// <summary>
        /// toggleInput()
        /// Used to enable controls on update form when a Supplier is chosen from dropdown menu.
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleInput(bool enabled)
        {
            txtUpdateCompanyName.Enabled = enabled;
            txtUpdateContactName.Enabled = enabled;
            txtUpdateContactTitle.Enabled = enabled;
            txtUpdateAddress.Enabled = enabled;
            txtUpdateCity.Enabled = enabled;
            txtUpdateRegion.Enabled = enabled;
            txtUpdatePostalCode.Enabled = enabled;
            txtUpdateCountry.Enabled = enabled;
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
                newSupplier.CompanyName = txtCompanyName.Text;
            }
                
                //set the rest of properties
                newSupplier.ContactName = txtContactName.Text;
                newSupplier.ContactTitle = txtContactTitle.Text;
                newSupplier.Address = txtAddress.Text;
                newSupplier.City = txtCity.Text;
                newSupplier.Region = txtRegion.Text;
                newSupplier.PostalCode = txtPostalCode.Text;
                newSupplier.Country = txtCountry.Text;
                newSupplier.Phone = txtPhone.Text;
           

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

            if (cmbSuppliers.SelectedIndex != -1)
            {
                updatedSupplier.SupplierID = ((Supplier)cmbSuppliers.SelectedItem).SupplierID;
                
            }
            else
            {
                errorProvider.SetError(cmbSuppliers, "Please choose a Supplier to update");
                return false;
            }

            if (txtUpdateCompanyName.Text == null || txtUpdateCompanyName.Text == "")
            {
                errorProvider.SetError(txtUpdateCompanyName, "Please enter a Company Name");
                result = false;
            }

            else
            {
                updatedSupplier.CompanyName = txtUpdateCompanyName.Text;
            }

            //set the rest of the properties
            
            updatedSupplier.ContactTitle = txtUpdateContactTitle.Text;
            updatedSupplier.ContactName = txtUpdateContactName.Text;
            updatedSupplier.Address = txtUpdateAddress.Text;
            updatedSupplier.Region = txtUpdateRegion.Text;
            updatedSupplier.City = txtUpdateCity.Text;
            updatedSupplier.Country = txtUpdateCountry.Text;
            updatedSupplier.PostalCode = txtUpdatePostalCode.Text;
            updatedSupplier.Phone = txtUpdatePhone.Text;
            return result;
        }
        #endregion

        
    }
}
