using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthWind
{
    public partial class FrmAddEmployee : Form
    {
        
        #region Member Variables
        private Employee newEmployee;
        private Employee updateEmployee;
        private Business business;
        private List<Employee> clerks;
        #endregion


        #region Constructor
        /// <summary>
        /// FrmAddEmployee()
        /// Constructor
        /// </summary>
        /// <param name="bus"></param>
        public FrmAddEmployee(Business bus)
        {
            InitializeComponent();
            business = bus;
            newEmployee = new Employee();
            updateEmployee = new Employee();
            clerks = business.Employees;
        }
        #endregion


        #region Form Load
        /// <summary>
        /// FrmAddEmployee_Load
        /// Loads form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip toolTip = new ToolTip();

            //Add New Employee Tab ToolTips
            toolTip.SetToolTip(this.txtFirstName, "Employee First Name");
            toolTip.SetToolTip(this.txtLastName, "Employee Last Name");
            toolTip.SetToolTip(this.txtTitle, "Employee's title");
            toolTip.SetToolTip(this.txtTitleOfCourtesy, "Title used in salutations");
            toolTip.SetToolTip(this.dtpBirthDate, "Employee date of birth");
            toolTip.SetToolTip(this.dtpHireDate, "Date Employee hired");
            toolTip.SetToolTip(this.txtAddress, "Street or post-office box");
            toolTip.SetToolTip(this.txtCity, "City where Employee lives");
            toolTip.SetToolTip(this.txtRegion, "State or province");
            toolTip.SetToolTip(this.txtPostalCode, "Postal code or zip code");
            toolTip.SetToolTip(this.txtCountry, "Country where Employee lives");
            toolTip.SetToolTip(this.txtHomePhone, "Phone number includes country code or area code");
            toolTip.SetToolTip(this.txtExtension, "Internal telephone extension number");
            toolTip.SetToolTip(this.rtbNotes, "General information about employee's background");
            toolTip.SetToolTip(this.cmbReportsTo, "Employee's supervisor");

            toolTip.SetToolTip(this.btnClear, "Clears all fields on form");
            toolTip.SetToolTip(this.btnSubmit, "Updates product in database");
            toolTip.SetToolTip(this.btnCancel, "Cancels order and closes form");

            //Update Employee Tab ToolTips
            toolTip.SetToolTip(this.cmbEmployees, "Select an Employee to Update");

            toolTip.SetToolTip(this.txtUpdateFName, "Employee First Name");
            toolTip.SetToolTip(this.txtUpdateLName, "Employee Last Name");
            toolTip.SetToolTip(this.txtUpdateTitle, "Employee's title");
            toolTip.SetToolTip(this.txtUpdateTitleOfCourtesy, "Title used in salutations");
            toolTip.SetToolTip(this.txtUpdateBirthDate, "Employee date of birth");
            toolTip.SetToolTip(this.txtUpdateHireDate, "Date Employee hired");
            toolTip.SetToolTip(this.txtUpdateAddress, "Street or post-office box");
            toolTip.SetToolTip(this.txtUpdateCity, "City where Employee lives");
            toolTip.SetToolTip(this.txtUpdateRegion, "State or province");
            toolTip.SetToolTip(this.txtUpdatePostalCode, "Postal Code or Zip code");
            toolTip.SetToolTip(this.txtUpdateCountry, "Country where Employee lives");
            toolTip.SetToolTip(this.txtUpdateHomePhone, "Phone number includes country code or area code");
            toolTip.SetToolTip(this.txtUpdateExtension, "Internal telephone extension number");
            toolTip.SetToolTip(this.rtbUpdateNote, "General information about employee's background");
            toolTip.SetToolTip(this.cmbUpdateReportsTo, "Employee's supervisor");


            toolTip.SetToolTip(this.btnUpdateClear, "Clears all fields on form");
            toolTip.SetToolTip(this.btnUpdateSubmit, "Updates product in database");
            toolTip.SetToolTip(this.btnUpdateCancel, "Cancels order and closes form");
            #endregion

            loadComboboxes();
            toggleInput(false); //disable controls on Update form
        }
        #endregion


        #region Control Methods
   
        /// <summary>
        /// tabControlAddEmployee_Enter()
        /// Sets focus to first control on New Employee Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageAddEmployee_Enter(object sender, EventArgs e)
        {
            ActiveControl = txtFirstName;

        }
 

        /// <summary>
        /// tabPageUpdateEmployee_Enter()
        /// Sets focus to first control on New Employee Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPageUpdateEmployee_Enter(object sender, EventArgs e)
        {
            ActiveControl = cmbEmployees;
        }


        /// <summary>
        /// cmbEmployees_SelectedIndexChanged()
        /// captures current employee chosed for update and populates control forms with the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

            Employee emp;
            errorProvider.SetError(cmbEmployees, "");//remove error message

            if (cmbEmployees.SelectedIndex != -1)
            {
                emp = (Employee)cmbEmployees.SelectedItem;//capture current employee object

                toggleInput(true);

                //populate the update form controls
                txtUpdateFName.Text = emp.FirstName;
                txtUpdateLName.Text = emp.LastName;
                txtUpdateTitle.Text = emp.Title;
                txtUpdateTitleOfCourtesy.Text = emp.TitleOfCourtesy;
                txtUpdateBirthDate.Text = emp.BirthDate.ToString("dd/MMM/yyyy");
                txtUpdateHireDate.Text = emp.HireDate.ToString("dd/MMM/yyyy");
                txtUpdateAddress.Text = emp.Address;
                txtUpdateCity.Text = emp.City;
                txtUpdateRegion.Text = emp.Region;
                txtUpdatePostalCode.Text = emp.PostalCode;
                txtUpdateCountry.Text = emp.Country;
                txtUpdateHomePhone.Text = emp.HomePhone;
                txtUpdateExtension.Text = emp.Extension;
                rtbUpdateNote.Text = emp.Notes;

                //display manager of current employee
                foreach (Employee em in cmbUpdateReportsTo.Items)
                {
                    if (em.EmployeeID == emp.ReportsTo)//find the manager
                    {
                       cmbUpdateReportsTo.SelectedItem = em;//set selected item to the manager
                        break;
                    }
                    cmbUpdateReportsTo.SelectedIndex = -1;//if no manager found don't display anything           
                }

            }
        }


        /// <summary>
        /// btnClear_Click()
        /// Calls resetControls and resets focus to first interactive control on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetControls(this.tabPageAddEmployee);
            txtFirstName.Focus();
        }


        /// <summary>
        /// btnUpdateClear_Click()
        /// Calls resetControls and resets focus to first interactive control on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            resetControls(this.tabPageUpdateEmployee);
            txtUpdateFName.Focus();
        }


        /// <summary>
        /// btnSubmit_Click()
        /// Adds current employee record to database and shows confirmation.
        /// Also, calls methods that validate/create new employee object, clears the form and reloads the comboboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (!validateAddEmployee())
                return;

            string confirmation = business.addEmployee(newEmployee);
            MessageBox.Show(confirmation);
            btnClear_Click(sender, e);

            loadComboboxes();
        }


        /// <summary>
        /// btnUpdateSubmit_Click()
        /// Updates current employee record in database and shows confirmation.
        /// Also, calls methods that validate/create new employee object, clears the form and reloads the comboboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            if (!validateUpdateEmployee())
                return;

            string confirmation = business.updateEmployee(updateEmployee);//update database
            MessageBox.Show(confirmation);
            btnUpdateClear_Click(sender, e);

            loadComboboxes();

        }

        /// <summary>
        /// btnCancel_Click()
        /// calls form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// btnUpdateCancel_Click()
        /// calls form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Load Comboboxes
        private void loadComboboxes()
        {
            //get new data from business
            clerks = business.Employees;

            //clear out current comboboxes
            cmbReportsTo.Items.Clear();
            cmbUpdateReportsTo.Items.Clear();
            cmbEmployees.Items.Clear();

            foreach (Employee clerk in clerks)
            {
                cmbEmployees.Items.Add(clerk);
            }

            foreach (Employee clerk in clerks)
            {
                cmbReportsTo.Items.Add(clerk);

            }

            foreach (Employee clerk in clerks)
            {
                cmbUpdateReportsTo.Items.Add(clerk);

            }
           
        }
        #endregion


        #region Reset Form
        /// <summary>
        /// resetControls()
        /// takes a Control object as a parameter and resets controls as specified
        /// </summary>
        /// <param name="product_Form">Object of Type Control</param>
        private void resetControls(Control product_Form)
        {

            toggleInput(false); //reset controls on update form

            foreach (Control c in product_Form.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                dtpBirthDate.Text = "01-01-2000";
                dtpHireDate.Text = DateTime.Now.ToString();

                if (c is RichTextBox)
                    c.ResetText();
            }
        }
        #endregion


        #region Toggle Controls
        /// <summary>
        /// toggleInput()
        /// Used to enable controls on update form when an Employee is chosen from dropdown menu.
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleInput(bool enabled)
        {
            txtUpdateFName.Enabled = enabled;
            txtUpdateLName.Enabled = enabled;
            txtUpdateTitle.Enabled = enabled;
            txtUpdateTitleOfCourtesy.Enabled = enabled;
            txtUpdateBirthDate.Enabled = enabled;
            txtUpdateHireDate.Enabled = enabled;
            txtUpdateAddress.Enabled = enabled;
            txtUpdateCity.Enabled = enabled;
            txtUpdateRegion.Enabled = enabled;
            txtUpdatePostalCode.Enabled = enabled;
            txtUpdateCountry.Enabled = enabled;
            txtUpdateHomePhone.Enabled = enabled;
            txtUpdateExtension.Enabled = enabled;
            rtbUpdateNote.Enabled = enabled;
            cmbUpdateReportsTo.Enabled = enabled;

        }

        #endregion

        
        #region Validation Methods
        /// <summary>
        /// validateAddEmployee()
        /// Validates data and sets properties of Employee object that is passed back to business for addition to database
        /// </summary>
        /// <returns>bool</returns>
        private bool validateAddEmployee()
        {
            bool result = true;
            errorProvider.Clear();

            //make sure First and Last names are entered
            if (txtFirstName.Text != null && txtFirstName.Text != "")
                newEmployee.FirstName = txtFirstName.Text;//set property

            else
            {
                errorProvider.SetError(txtFirstName, "Please enter First Name");
                result = false;

            }

            if (txtLastName.Text != null && txtLastName.Text != "")
                newEmployee.LastName = txtLastName.Text;//set property
            else
            {
                errorProvider.SetError(txtLastName, "Please enter Last Name");
                result = false;
            }

            //ensure birthdate is in the past
            if ((DateTime)dtpBirthDate.Value < DateTime.Now)

                newEmployee.BirthDate = (DateTime)dtpBirthDate.Value;
            else
            {
                errorProvider.SetError(dtpBirthDate, "Birthdate must be in the past");
                result = false;
            }

            //ensure the "reports to" property does not equal null
            if (cmbReportsTo.SelectedIndex != -1)
                newEmployee.ReportsTo = ((Employee)cmbReportsTo.SelectedItem).EmployeeID;//set property
            else
                newEmployee.ReportsTo = 0;

            //set the rest of the properties in new Employee object
            newEmployee.Title = txtTitle.Text;
            newEmployee.TitleOfCourtesy = txtTitleOfCourtesy.Text;
            newEmployee.HireDate = (DateTime)dtpHireDate.Value;
            newEmployee.Address = txtAddress.Text;
            newEmployee.City = txtCity.Text;
            newEmployee.Region = txtRegion.Text;
            newEmployee.PostalCode = txtPostalCode.Text;
            newEmployee.Country = txtCountry.Text;
            newEmployee.HomePhone = txtHomePhone.Text;
            newEmployee.Extension = txtExtension.Text;
            newEmployee.Notes = rtbNotes.Text;


            return result;

        }

        /// <summary>
        /// validateUpdateEmployee()
        /// Validates data and sets properties of Employee object that is passed back to business for update in database
        /// </summary>
        /// <returns>bool</returns>
        private bool validateUpdateEmployee()
        {
            bool result = true;
            errorProvider.Clear();

            //verify an employee has been selected
            if (cmbEmployees.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbEmployees, "Please choose an employee to update");
                return false;

            }

            //make sure First and Last names are entered
            if (txtUpdateFName.Text != null && txtUpdateFName.Text != "")
                updateEmployee.FirstName = txtUpdateFName.Text; //set property

            else
            {
                errorProvider.SetError(txtUpdateFName, "Please enter First Name");
                result = false;
            }

            if (txtUpdateLName.Text != null && txtUpdateLName.Text != "")
                updateEmployee.LastName = txtUpdateLName.Text;//set property
            else
            {
                errorProvider.SetError(txtUpdateLName, "Please enter Last Name");
                result = false;
            }

            //validate dates entered
            DateTime t;
            if (DateTime.TryParse(txtUpdateBirthDate.Text, out t)) //parse data to see if it is in correct format
            {
                if (t < DateTime.Now) //birthdate must be in the past
                    updateEmployee.BirthDate = t;//set property
                else
                {
                    errorProvider.SetError(txtUpdateBirthDate, "Birthdate must be in the past");
                    result = false;
                }
            }

            if (DateTime.TryParse(txtUpdateHireDate.Text, out t)) //parse data to see if it is in correct format
            {
                updateEmployee.HireDate = t;//set property
            }

            //ensure the "reports to" property does not equal null or else we get an error when adding to database
            if (cmbUpdateReportsTo.SelectedIndex != -1)
                updateEmployee.ReportsTo = ((Employee)cmbUpdateReportsTo.SelectedItem).EmployeeID; //set property
            else
                updateEmployee.ReportsTo = 0;


            //set the rest of the properties in new Employee object
            updateEmployee.Title = txtUpdateTitle.Text;
            updateEmployee.TitleOfCourtesy = txtUpdateTitleOfCourtesy.Text;
            updateEmployee.Address = txtUpdateAddress.Text;
            updateEmployee.City = txtUpdateCity.Text;
            updateEmployee.Region = txtUpdateRegion.Text;
            updateEmployee.PostalCode = txtUpdatePostalCode.Text;
            updateEmployee.Country = txtUpdateCountry.Text;
            updateEmployee.HomePhone = txtUpdateHomePhone.Text;
            updateEmployee.Extension = txtUpdateExtension.Text;
            updateEmployee.Notes = rtbUpdateNote.Text;
            updateEmployee.EmployeeID = ((Employee)cmbEmployees.SelectedItem).EmployeeID;//need this to know which record to update in database

            return result;
        }
        #endregion

       
    }  
}
