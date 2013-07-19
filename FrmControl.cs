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
using System.Text;
using System.Windows.Forms;

namespace NorthWind
{
    /// <summary>
    /// FrmControl handles form behaviour for Parent form and its Child forms
    /// </summary>
    public partial class FrmControl : Form
    {
        private Business business;//used to reference the Business object started this transaction
        private int childFormNumber = 0;

        #region Constructor
        /// <summary>
        /// FrmControl()
        /// Constructor which takes a business object and sets a reference to it.
        /// </summary>
        /// <param name="businessArg"></param>
        public FrmControl(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
        }
        #endregion

        #region Form Load
        /// <summary>
        /// ControlForm_Load()
        /// On form load an Order form is instantiated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlForm_Load(object sender, EventArgs e)
        {
            FrmOrder childForm = new FrmOrder(business);
            childForm.MdiParent = this;
            childForm.Text = "Order Form " + +childFormNumber++;
            childForm.Show();
                        
        }
        #endregion

        #region File Menu Options
        /// <summary>
        /// ShowNewForm()
        /// When New is chose from File Menu, a new Order form is instantiated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmOrder childForm = new FrmOrder(business);
            childForm.MdiParent = this;
            childForm.Text = "Order Form " + childFormNumber++; ;
            childForm.Show();
        }

        
        /// <summary>
        /// ExitToolsStripMenuItem_Click()
        /// When Exit is chosen from File menu, close FrmControl and all child forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// closeToolStripMenuItem_Click()
        /// When Close is chosen from File menu, the current active child form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }


        /// <summary>
        /// fileMenu_DropDownOpening()
        /// When dropping down File menu, Close and Close All are disabled if no child forms are active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileMenu_DropDownOpening(object sender, EventArgs e)
        {
            closeToolStripMenuItem.Enabled = (ActiveMdiChild != null);
            closeAllToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }
        #endregion


        private void closeAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            } 
        }


        #region Windows Menu Options

        /// <summary>
        /// CascadeToolStripMenuItem_Click
        /// When Window/Cascade is pick, Windows are rearranged into a cascade for a different view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// TileVerticalToolStripMenuItem_Click()
        /// When Tile Vertical is chosend from Windows menu item, all child forms are tiled vertically for a different view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        
        /// <summary>
        /// TileHorizontalToolStripMenuItem_Click()
        /// When Tile Horizontal is chosend from Windows menu item, all child forms are tiled horizontally for a different view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// ArrangeIconsToolStripMenuItem_Click()
        /// When Arrange Icons is chosend from Windows menu item, all child forms are arranged for a different view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        /// <summary>
        /// CloseAllToolStripMenuItem_Click()
        /// When Close All is chosend from Windows menu item, all child forms are closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region Add/Update
       

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddProduct childForm = new FrmAddProduct(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update a Product " + childFormNumber++; ;
            childForm.Show();
        }

        public void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCategory childForm = new FrmAddCategory(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update a Category "+ childFormNumber++;
            childForm.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCustomer childForm = new FrmAddCustomer(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update a Customer "  + childFormNumber++;
            childForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee childForm = new FrmAddEmployee(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update an Employee " + childFormNumber++;
            childForm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSupplier childForm = new FrmAddSupplier(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update a Supplier "  + childFormNumber++;
            childForm.Show();
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddShipper childForm = new FrmAddShipper(business);
            childForm.MdiParent = this;
            childForm.Text = "Add or Update a Shipper "  + childFormNumber++;
            childForm.Show();
        }

        #endregion

       
    }
}
