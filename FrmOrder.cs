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


namespace NorthWind

{
    public partial class FrmOrder : Form
    {
        /// <summary>
        /// FrmOrder allows the user to create a new Order
        /// </summary>
        #region class variables
        private Business business;//used to reference the Business object that owns this order/transaction
        private Customer customerSelected;//passed to Confirmation Window
        private Employee clerkSelected;//passed to Confirmation Window

        #endregion

        #region constructor
        /// <summary>
        /// FrmOrder()
        /// The constructor for the Order Form
        /// </summary>
        /// <param name="b"></param>
        public FrmOrder(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
           
        }
        #endregion
       
        #region form load
        /// <summary>
        /// FrmOrder_Load()
        /// On Form Load add tooltips, setup error provider control, load comboboxes, add date/time,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip ttCatalog = new ToolTip();
            ttCatalog.SetToolTip(this.btn_Catalog, "Click to access our catalogue");

            ToolTip ttRemove = new ToolTip();
            ttRemove.SetToolTip(this.btn_RemoveItem, "Highlight item to be removed before clicking this button.");

            ToolTip ttclerks = new ToolTip();
            ttclerks.SetToolTip(this.cmbClerks, "Please Choose clerk.");

            ToolTip ttCustomer = new ToolTip();
            ttCustomer.SetToolTip(this.cmbCustName, "Please Choose a customer.");

            ToolTip ttCustomerID = new ToolTip();
            ttCustomerID.SetToolTip(this.cmbCustID, "Please choose a customer I.D.");

            ToolTip ttCancel = new ToolTip();
            ttCancel.SetToolTip(this.btn_Cancel, "Cancel order.");

            ToolTip ttSubmit = new ToolTip();
            ttSubmit.SetToolTip(this.btn_Submit, "Continue to confirmation window.");
            #endregion
          
            errorProvider = new ErrorProvider();
          
            //load customer id and name Comboboxes
            fillCustomers();
       
            //load clerk ComboBox
            fillClerks();

            //load date label
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");           
        }
        #endregion
       
        #region control events

        #region set date and time
        //set date and time
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
        }
        #endregion

        #region comboboxes selected items changed methods
        /// <summary>
        /// cmbCustName_SelectedIndexChanged()
        /// If customer name changes, change customer id to match;
        /// Clear error for both customer name/custId.
        /// Set customerSelected = to the customer object selected - passed to confirmation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustName.SelectedIndex != -1)
            {
                int adjuster = cmbCustName.SelectedIndex;
                cmbCustID.SelectedIndex = adjuster;
                errorProvider.SetError(cmbCustID,"");
                errorProvider.SetError(cmbCustName, "");
                customerSelected = (Customer)cmbCustName.SelectedItem;
            }
        }

        /// <summary>
        /// cmbCustID_SelectedIndexChanged()
        /// If customer ID changes, change customer name to match;
        /// Clear error for both customer name/custId.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCustID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustID.SelectedIndex != -1)
            {
                int adjuster = cmbCustID.SelectedIndex;
                cmbCustName.SelectedIndex = adjuster;
                errorProvider.SetError(cmbCustID, "");
                errorProvider.SetError(cmbCustName, "");
            }
        }
       
        /// <summary>
        /// cmbClerks_SelectedIndexChanged()
        /// When clerk is selected clear error and set clerk equal to employee selected - passed to confirmation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClerks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClerks.SelectedIndex != -1)
            {
                errorProvider.SetError(cmbClerks, "");
                clerkSelected = (Employee)cmbClerks.SelectedItem;
            }
        }
        #endregion

        #region catalog
        /// <summary>
        /// btn_Catalog_Click()
        /// When user hits catalog button, a form opens displaying all products in database
        /// User can select products and return to order form to modify quantities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Catalog_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(btn_Catalog,"");//clear error
            this.Enabled = false;//disable order form (gets enabled when catalog form is closed)
            FrmCatalog catalog = new FrmCatalog(business);//create catalog object
            catalog.MdiParent = this.MdiParent;
            catalog.eventProductChosen += new FrmCatalog.ProductChosen(productReturned);//register with delegate for event
            catalog.Text = this.Text;
            catalog.Show();//show catalog and pass this form as parent
          
        }
        #endregion

        #region remove products
        /// <summary>
        /// btn_RemoveItem_Click()
        /// removes highlighted gridview item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if(gridViewOrderDetails.CurrentRow != null)
                gridViewOrderDetails.Rows.RemoveAt(gridViewOrderDetails.CurrentRow.Index);           
        }
        #endregion

        #region clear form
        /// <summary>
        /// btnClear_Click()
        /// Prompts user to clear all data on form
        /// Yes clears all fields No cancels dialog and returns user to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to clear the form?", "For REALLY REAL?", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                clear();
        }
        #endregion

        #region form cancel
        /// <summary>
        /// btn_Cancel_Click()
        /// clears all controls and closes current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clear();
            Close();
        }
        #endregion

        #region edit quantity
        /// <summary>
        /// gridViewOrderDetails_CellEndEdit()
        /// Used to handle changed quantities manually input by the user;
        /// It validates the input and updates the underlying objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewOrderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            const int QUANTITY_COLUMN = 3;
            OrderDetail od = (OrderDetail)gridViewOrderDetails.Rows[e.RowIndex].Tag;//get current order detail object
            if (e.ColumnIndex == QUANTITY_COLUMN)
            {
                string text = gridViewOrderDetails.Rows[e.RowIndex].Cells[colQuantity.Name].Value.ToString();//get new quantity
                Int16 s;
                if (Int16.TryParse(text, out s))//check to see if quantity is an int
                {
                    od.Quantity = s;//set the Quantity property to new value
                }
                else //otherwise leave original quantity value and prompt user to change
                {
                    gridViewOrderDetails.Rows[e.RowIndex].Cells[colQuantity.Name].Value = od.Quantity.ToString();
                    MessageBox.Show("Not a valid quantity. Please enter a number");
                }
            }
        }
        #endregion

        #region submit form
        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (!validateForm())
                return;

            if (!checkQuantities())
                return;

            //create new Order Object and set properties
            Order order = new Order();
            order.CustomerID = ((Customer)cmbCustName.SelectedItem).CustomerID;
            order.EmployeeID = ((Employee)cmbClerks.SelectedItem).EmployeeID;
            order.OrderDate = System.DateTime.Now;

            //create a list of Order Details
            List<OrderDetail> orderDetails = new List<OrderDetail>(gridViewOrderDetails.Rows.Count);
            foreach (DataGridViewRow row in gridViewOrderDetails.Rows)
            {
                orderDetails.Add((OrderDetail)row.Tag);//add each orderdetail object to the list
            }

            business.addOrder(order, orderDetails);//update Database

            //load Confirmation Form
            loadConfirmation(order, orderDetails, customerSelected, clerkSelected);

            Close();
            
        }
        #endregion

        #endregion

        #region control methods

        #region load confirmation form
        /// <summary>
        /// loadConfirmation
        /// loads confirmation form after order is placed
        /// </summary>
        /// <param name="o"></param>
        /// <param name="od"></param>
        /// <param name="c"></param>
        /// <param name="emp"></param>
        
        private void loadConfirmation(Order o, List<OrderDetail> od, Customer c, Employee emp) 
        {
            FrmConfirmation frmConfirmation = new FrmConfirmation(business, o, od, c, emp);
            frmConfirmation.Text = "Confirmation Window ";
            frmConfirmation.ShowDialog();
      
        }
        #endregion

        #region fill customers
        /// <summary>
        /// Gets a list of Customer Objects from Database and populates Comboboxes
        /// </summary>
        private void fillCustomers()
        {
            List<Customer> customers = business.Customers;//get customer data from database
        
            foreach (Customer customer in customers)//for each customer object in the collection returned...
            {
                cmbCustName.Items.Add(customer);//add the customer OBJECT to the combo box 
                cmbCustID.Items.Add(customer.CustomerID.ToString());//add the customer ID property to the combobox

            }
        }
        #endregion

        #region fill clerks
        /// <summary>
        /// Gets a list of Employee Objects from Database and populates Combobox
        /// </summary>
        private void fillClerks()
        {
            List<Employee> clerks = business.Employees;

            foreach (Employee clerk in clerks)
            {
                cmbClerks.Items.Add(clerk);
            }
        }
        #endregion

        #region product returned
        /// <summary>
        /// productReturned()
        /// An event handler used to handle events called "eventProductChosen" on FrmCatalog
        /// If product is returned, it captures its properties to create an order detail object
        /// Order detail object then added to a datagridview control
        /// </summary>
        /// <param name="product">Object of Product></param>
        private void productReturned(Product product)
        {
            this.Enabled = true;//enable this form

            if (product == null)//return if a product is not selected
                return;
                           
                //add order detail to grid
                OrderDetail orderDetail;
                const Int16 DEFAULT_QUANTITY = 1;
                foreach (DataGridViewRow currentRow in gridViewOrderDetails.Rows)//loop through gridlist
                {
                    orderDetail = (OrderDetail)currentRow.Tag;

                    //if product exists in datagridview;
                    if (orderDetail.ProductID == product.ProductID)
                    {
                        orderDetail.Quantity += 1;// increase its quantity by 1
                        currentRow.Cells[colQuantity.Name].Value = orderDetail.Quantity.ToString();//display new value in grid cell
                        return;//exit method
                    }
                }

                //if product does not exist in datagridview already, create new order detail object and set its properties
                orderDetail = new OrderDetail();
                orderDetail.ProductName = product.ProductName;
                orderDetail.ProductID = product.ProductID;
                orderDetail.Quantity = DEFAULT_QUANTITY;
                orderDetail.UnitPrice = product.UnitPrice;

                int rowNum = gridViewOrderDetails.Rows.Add(1);//adds a new row and return its index

                DataGridViewRow row = gridViewOrderDetails.Rows[rowNum];//sets row equal to newly created row

                //populate cells with order details and product name
                row.Cells[colProduct.Name].Value = orderDetail.ProductName;
                row.Cells[colProductID.Name].Value = orderDetail.ProductID;
                row.Cells[colUnitPrice.Name].Value = orderDetail.UnitPrice.ToString("F");
                row.Cells[colQuantity.Name].Value = 1;
                row.Tag = orderDetail;
           
            //set first quantity item control for edit
            gridViewOrderDetails.CurrentCell = gridViewOrderDetails.Rows[0].Cells[colQuantity.Name];
            gridViewOrderDetails.BeginEdit(true);
        }
        #endregion

        #region validate form
        /// <summary>
        /// validateForm()
        /// Validates if customer chosen, customer ID chosen, clerk chosen,
        /// or whether or not a product was selected from the Catalog.
        /// Method returns false if any of the the above conditions are not met.
        /// True returns only when all conditions are met.
        /// </summary>
        /// <returns></returns>
        private bool validateForm()
        {
            bool result = true;
            errorProvider.Clear();

            if (gridViewOrderDetails.Rows.Count == 0)
            {
                errorProvider.SetError(btn_Catalog, "Please select a product from the catalogue");
                btn_Catalog.Focus();
                result = false;
            }

            if (cmbClerks.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbClerks, "Please select a clerk.");
                cmbClerks.Focus();
                result = false;
            }

            if (cmbCustName.SelectedIndex == -1 || cmbCustID.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCustName, "Please select a customer name.");
                errorProvider.SetError(cmbCustID, "Please select a customer I.D.");
                cmbCustName.Focus();
                result = false;
            }
            return result;        
        }
        #endregion

        #region check quantities
        /// <summary>
        /// checkQuantities() 
        /// Checks database for Units on Hand, compares to quantity requested 
        /// for each ordered item, returns true if all items ordered are "in stock"
        /// otherwise, user is prompted to change the item quantity 
        /// or remove items and method returns false
        /// </summary>
        /// <returns>bool</returns>
        private bool checkQuantities()
        {
            int notEnoughCount = 0; // start off with 0 bad items
            foreach (DataGridViewRow row in gridViewOrderDetails.Rows)
            {
                OrderDetail orderDetail = (OrderDetail)row.Tag;

                int quantity = business.fetchUnitsInStock(orderDetail.ProductID);
                if (quantity < orderDetail.Quantity) // not enough quantity for this item, so it's "bad"
                {
                    // show the error text and exclamation point icon
                    row.Cells[colQuantity.Name].ErrorText =
                        "Insufficient quantities. " + quantity.ToString() + " left. Please change or remove item.";

                    if(notEnoughCount == 0) // If count is 0, then this is the first bad item we find so set focus to it
                        gridViewOrderDetails.CurrentCell = row.Cells[colQuantity.Name]; //set focus to first item that where Units in Stock are less than quantity requested

                    notEnoughCount += 1;  // increment the count of bad items
                }

                else
                {
                    row.Cells[colQuantity.Name].ErrorText = null;
                }
            }

            if (notEnoughCount == 0) // if we found 0 bad items, then they are all good so return true
                return true;
            else // we found one or more bad items, so return false, user has to correct order.
                return false; 

        }
        #endregion

        #region clear form
        /// <summary>
        /// clear()
        /// Clears all controls on form and sets focus back to Choose a Customer Field.
        /// </summary>
        public void clear()
        {
            cmbClerks.SelectedIndex = -1;
            cmbCustID.SelectedIndex = -1;
            cmbCustName.SelectedIndex = -1;
            gridViewOrderDetails.Rows.Clear();
            errorProvider.Clear();
            cmbCustName.Focus();
        }
        #endregion

        #endregion

    }
}

