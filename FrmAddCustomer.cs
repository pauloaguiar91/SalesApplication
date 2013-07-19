using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthWind
{
    public partial class FrmAddCustomer : Form
    {
        #region Member Variables
        private Business business;
        private List<Customer> customers;
        private Customer newCustomer;
        private Customer updatedCustomer;
        #endregion


        #region Constructor
        public FrmAddCustomer(Business bus)
        {
            InitializeComponent();
            business = bus;
            newCustomer = new Customer();
            updatedCustomer = new Customer();
        }
        #endregion


        #region Load Form
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
          
            #region toolTips
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.mtxtCustID, "Customers I.D.");
            toolTip.SetToolTip(this.txtAddress, "Customer address");
            toolTip.SetToolTip(this.txtCity, "Customer city");
            toolTip.SetToolTip(this.txtCompanyName, "Customers company name");
            toolTip.SetToolTip(this.txtContactName, "Customer contact name");
            toolTip.SetToolTip(this.txtCountry, "Customers country");
            toolTip.SetToolTip(this.txtFax, "Customers fax number");
            toolTip.SetToolTip(this.txtPhone, "Customer phone number");
            toolTip.SetToolTip(this.txtPostalCode, "Customers postal code");
            toolTip.SetToolTip(this.txtRegion, "Customers region");
            toolTip.SetToolTip(this.txtContactTitle, "Customers title");

            toolTip.SetToolTip(this.mtxtCustID, "Customers I.D.");
            toolTip.SetToolTip(this.txtUpdateAddress, "Customer address");
            toolTip.SetToolTip(this.txtUpdateCity, "Customer city");
            toolTip.SetToolTip(this.cmbCompanyName, "Customers company name");
            toolTip.SetToolTip(this.txtUpdateContactName, "Customer contact name");
            toolTip.SetToolTip(this.txtUpdateCountry, "Customers country");
            toolTip.SetToolTip(this.txtUpdateFax, "Customers fax number");
            toolTip.SetToolTip(this.txtUpdatePhone, "Customer phone number");
            toolTip.SetToolTip(this.txtUpdatePostalCode, "Customers postal code");
            toolTip.SetToolTip(this.txtUpdateRegion, "Customers region");
            toolTip.SetToolTip(this.txtUpdateContactTitle, "Customers title");

            toolTip.SetToolTip(this.btnCancel, "Cancel button");
            toolTip.SetToolTip(this.btnClear, "Press to clear table");
            toolTip.SetToolTip(this.btnSubmit, "Press to submit form");
            toolTip.SetToolTip(this.btnUpdateCancel, "Press to cancel update");
            toolTip.SetToolTip(this.btnUpdateClear, "Press to clear update");
            toolTip.SetToolTip(this.btnUpdateSubmit, "Press to sumbit update");

            #endregion

            fillCustomers();//fill combobox

            toggleInput(false); //disable controls on Update form

        }
        #endregion


        #region Control Methods

        /// <summary>
        /// tabPageNewCustomer_Enter()
        /// Sets focus to first control on New Customer Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageNewCustomer_Enter(object sender, EventArgs e)
        {
            ActiveControl = mtxtCustID;

        }


        /// <summary>
        /// tabPageUpdateCustomer_Enter()
        /// Sets focus to first control on Update Customer Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageUpdateCustomer_Enter(object sender, EventArgs e)
        {
            ActiveControl = cmbCustomerID;
        }


        /// <summary>
        /// cmbCustomerId_SelectedIndexChanged()
        /// If Index of Customer ID changes, match Company Name index to be the sam
        /// Fill form with properties of selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCustomerId_SelectedIndexChanged(object sender, EventArgs e)

            
        {
            if(cmbCustomerID.SelectedIndex != -1)
            {
                //set index of Company Name to be the same as Customer ID
                cmbCompanyName.SelectedIndex = cmbCustomerID.SelectedIndex; 
                
                //clear errors
                errorProvider.SetError(cmbCustomerID, "");
                errorProvider.SetError(cmbCompanyName, "");

                //fill update form with data
                Customer cust = (Customer)cmbCompanyName.SelectedItem; //get the customer object selected
                toggleInput(true); //disable controls on Update form
                txtUpdateContactName.Text = cust.ContactName;
                txtUpdateContactTitle.Text = cust.ContactTitle;
                txtUpdateAddress.Text = cust.Address;
                txtUpdateCity.Text = cust.City;
                txtUpdateRegion.Text = cust.Region;
                txtUpdatePostalCode.Text = cust.PostalCode;
                txtUpdateCountry.Text = cust.Country;
                txtUpdatePhone.Text = cust.Phone.ToString();
                txtUpdateFax.Text = cust.Fax.ToString();
            }
        }              

        /// <summary>
        /// cmbUpdateCompanyName_SelectedIndexChanged()
        /// If Index of Company Name changes, match Index of CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUpdateCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCompanyName.SelectedIndex != -1)
            {
                //set index of Custoemr ID to be the same as CompanyName
                cmbCustomerID.SelectedIndex = cmbCompanyName.SelectedIndex;

                //clear errors
                errorProvider.SetError(cmbCustomerID, "");
                errorProvider.SetError(cmbCompanyName, "");
                
            }
            
        }


        /// <summary>
        /// mtxtCustID_Validated()
        /// Changes text entered to uppercase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtCustID_Validated(object sender, EventArgs e)
        {
            this.mtxtCustID.Text = this.mtxtCustID.Text.ToUpper();
        }

        /// <summary>
        /// btnClear_Click
        /// Clears all data in Add Customer form
        /// </summary>
        ///<param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        /// <summary>
        /// btnSubmit_Click()
        /// On submit of Add Customer form, methods are called to validate, adds new Customer in DB and shows a confirmation;
        /// Once completed, the form is cleared and the comboboxes are reloaded with the new data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!validateCustomer())
               return;

            string confirmation = business.addCustomer(newCustomer);

            MessageBox.Show(confirmation);

            btnClear_Click(sender, e);

            fillCustomers();
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// btnUpdateClear_Click
        /// Clears all data in Update form
        /// </summary>
        ///<param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            updateClear();
        }

        /// <summary>
        /// btnUpdateSubmit_Click()
        /// On submit of Update form, methods are called to validate, update Customer in DB and show a confirmation;
        /// Once completed, the form is cleared and the comboboxes are reloaded with the new data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            if (!validateUpdateForm())
               return;

            string confirmation = business.updateCustomer(updatedCustomer);

            MessageBox.Show(confirmation);

            btnUpdateClear_Click(sender, e);

            fillCustomers();
           
        }

        /// <summary>
        /// btnUpdateCancel_Click()
        /// Closes Update Customers form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
   

        #region Form methods

        #region Fill Customer comboboxes
        /// <summary>
        /// fillCustomers()
        /// Clears current customers and customer ID's comboboxes, gets an updated list of customers from
        /// the database and loads the comboboxes
        /// </summary>
        private void fillCustomers()
        {
            cmbCompanyName.Items.Clear();
            cmbCustomerID.Items.Clear();

            customers = business.Customers;
            foreach (Customer c in customers)
            {
                cmbCustomerID.Items.Add(c.CustomerID.ToString());
                cmbCompanyName.Items.Add(c);
            }
        }
        #endregion


        #region Toggle Controls
        /// <summary>
        /// toggleInput()
        /// Used to enable controls on update form when a Customer is chosen from dropdown menu.
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleInput(bool enabled)
        {
            txtUpdateContactName.Enabled = enabled;
            txtUpdateContactTitle.Enabled = enabled;
            txtUpdateAddress.Enabled = enabled;
            txtUpdateCity.Enabled = enabled;
            txtUpdateRegion.Enabled = enabled;
            txtUpdatePostalCode.Enabled = enabled;
            txtUpdateCountry.Enabled = enabled;
            txtUpdatePhone.Enabled = enabled;
            txtUpdateFax.Enabled = enabled;

        }

        #endregion


        #region Clear add customer
        public void clear()
        {
            errorProvider.Clear();
            mtxtCustID.Clear();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtCountry.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtFax.Clear();
            txtPhone.Clear();
            txtPostalCode.Clear();
            txtRegion.Clear();
            txtContactTitle.Clear();

            mtxtCustID.Focus();
        }
        #endregion


        #region Clear update customer
        public void updateClear()
        {
            errorProvider.Clear();
            cmbCustomerID.SelectedIndex = -1;
            cmbCompanyName.SelectedIndex = -1;
            txtUpdateContactName.Clear();
            txtUpdateCountry.Clear();
            txtUpdateAddress.Clear();
            txtUpdateCity.Clear();
            txtUpdateFax.Clear();
            txtUpdatePhone.Clear();
            txtUpdatePostalCode.Clear();
            txtUpdateRegion.Clear();
            txtUpdateContactTitle.Clear();
            toggleInput(false); //disable controls on Update form

            cmbCustomerID.Focus();
        }
        #endregion

        
        #region Validate Add Form
        public bool validateCustomer()
        {
            bool result = true;
            errorProvider.Clear();

            if (mtxtCustID.Text != null && mtxtCustID.Text != "")
                newCustomer.CustomerID = mtxtCustID.Text;//set property

            else
            {
                errorProvider.SetError(mtxtCustID, "Please enter a Unique Customer Identifier base on Company Name");
                mtxtCustID.Focus();
                return false;

            }


            if (txtCompanyName.Text != null && txtCompanyName.Text !="")
                newCustomer.CompanyName =txtCompanyName.Text;//set property
            
            else 
            {
                errorProvider.SetError(txtCompanyName, "Please add the Company Name");
                txtCompanyName.Focus();
                result = false;
            }


            //set the rest of the properties for the new Customer object
            newCustomer.ContactName = txtContactName.Text;
            newCustomer.ContactTitle = txtCompanyName.Text;
            newCustomer.Address = txtAddress.Text;
            newCustomer.City = txtCity.Text;
            newCustomer.Region = txtRegion.Text;
            newCustomer.PostalCode = txtPostalCode.Text;
            newCustomer.Country = txtCountry.Text;
            newCustomer.Phone = txtPhone.Text;
            newCustomer.Fax = txtFax.Text;
          
            return result;
        }
        #endregion


        #region Validate Update Form
        private bool validateUpdateForm()
        {
            bool result = true;
            errorProvider.Clear();

            if (cmbCustomerID.SelectedIndex != -1)
               updatedCustomer.CustomerID = ((Customer)cmbCompanyName.SelectedItem).CustomerID;
            
            else
            {
                errorProvider.SetError(cmbCustomerID, "Please select a customer i.d. or Company Name");
                errorProvider.SetError(cmbCompanyName, "Please select a customer i.d. or Company Name");
                cmbCustomerID.Focus();
                return false;

            }

            //set the rest of the properties for updated Customer object
            updatedCustomer.CompanyName = ((Customer)cmbCompanyName.SelectedItem).CompanyName;
            updatedCustomer.ContactName = txtUpdateContactName.Text;
            updatedCustomer.ContactTitle = txtUpdateContactTitle.Text;
            updatedCustomer.Address = txtUpdateAddress.Text;
            updatedCustomer.City = txtUpdateCity.Text;
            updatedCustomer.Region = txtUpdateRegion.Text;
            updatedCustomer.PostalCode = txtUpdatePostalCode.Text;
            updatedCustomer.Country = txtUpdateCountry.Text;
            updatedCustomer.Phone = txtUpdatePhone.Text;
            updatedCustomer.Fax = txtUpdateFax.Text;
          

            return result;
        }
        #endregion

        #endregion

       

        

       
    }
}
