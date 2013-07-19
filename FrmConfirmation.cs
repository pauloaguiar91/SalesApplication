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
    /// <summary>
    /// Shows the Order Details confirming the Order has been placed
    /// </summary>
    public partial class FrmConfirmation : Form
    {

        #region Attributes
        private Business business;
        private Order currentOrder;
        private List<OrderDetail> orderDetails;
        private Customer currentCustomer;
        private Employee currentEmp;
        
        
        #endregion

        #region OverLoaded constuctor
        /// <summary>
        /// The constructor for the confirmation form.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="orderDetailList"></param>
        /// <param name="c"></param>
        /// <param name="emp"></param>
        public FrmConfirmation(Business businessArg, Order order, List<OrderDetail> orderDetailList, Customer cust, Employee emp)
        {
            InitializeComponent();
            currentOrder = order;
            business = businessArg;
            orderDetails = orderDetailList;
            currentCustomer = cust;
            currentEmp = emp;
        }
        #endregion

        #region Form Load
        /// <summary>
        /// On form load all the displays for Customer name, address, City, Postal code, and Clerk name (first and last) are taken from the db and displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfirmation_Load(object sender, EventArgs e)
        {
            
            #region set ToolTips
            ToolTip ttPST = new ToolTip();
            ttPST.SetToolTip(this.lblPST, "P.S.T. is 7% of total sales");

            ToolTip ttGST = new ToolTip();
            ttGST.SetToolTip(this.lblGST, "G.S.T. is 6% of total sales");
            #endregion

            #region set variables
            Product product;
            decimal productTotal;
            decimal subTotal = 0;
            double pst;
            double gst;
            double subTotalDisplay =0;
            const double PST = 0.07;
            const double GST = 0.06;
            #endregion

            #region set labels
            lblCustDisplay.Text = currentCustomer.CompanyName;
            lblAddressDisplay.Text = currentCustomer.Address;
            lblCityDisplay.Text = currentCustomer.City;
            lblPostalDisplay.Text = currentCustomer.PostalCode;
            lblClerkDisplay.Text = currentEmp.FirstName + " " + currentEmp.LastName;
            lblOrderIDDisplay.Text = currentOrder.OrderID.ToString();
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            #endregion

            #region Text align
            lblSubTotalTotal.TextAlign = ContentAlignment.MiddleRight;
            lblPSTTotal.TextAlign = ContentAlignment.MiddleRight;
            lblGSTTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotalDisplay.TextAlign = ContentAlignment.MiddleRight;
            #endregion

            #region load order details into the datagridview
            foreach (OrderDetail orderDetail in orderDetails) // Loop through OrderDetail List
            {
                product = business.fetchProductByID(orderDetail.ProductID);//get productID

                productTotal = orderDetail.UnitPrice * orderDetail.Quantity;//calculate total for each product
                subTotal += productTotal;//calculate subtotal of all products
                int rowNum = gridOrderDetails.Rows.Add(1);//creates a new row and return its index

                DataGridViewRow row = gridOrderDetails.Rows[rowNum];//set row equal to newly created row
                
                //add data to cells
                row.Cells[colProduct.Name].Value = orderDetail.ProductName;
                row.Cells[colProductID.Name].Value = orderDetail.ProductID;
                row.Cells[colUnitPrice.Name].Value = orderDetail.UnitPrice.ToString("F"); 
                row.Cells[colQuantity.Name].Value = orderDetail.Quantity;
                row.Cells[colTotal.Name].Value = productTotal.ToString("F");

            }
            #endregion

            #region display totals
            subTotalDisplay = (double)(subTotal);
            pst = subTotalDisplay * PST;
            gst = subTotalDisplay * GST;
            lblSubTotalTotal.Text = subTotal.ToString("F");
            lblPSTTotal.Text = pst.ToString("F");
            lblGSTTotal.Text = gst.ToString("F");
            double total = subTotalDisplay + pst + gst;
            lblTotalDisplay.Text = total.ToString("C");
        }
        #endregion

        #endregion

        #region Set Date and Time
        /// <summary>
        /// dateTimer_Tick()
        /// checks for current date/time each second and updates date/time label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:MM tt");
        }
        #endregion

      /// <summary>
      /// btnClose_Click
      /// closes display window
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
