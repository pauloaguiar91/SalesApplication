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
    public partial class FrmAddProduct : Form
    {

        #region Member Variables

        private Business business;//used to reference the Business object that owns this order/transaction
        private List<Category> categories;
        private List<Supplier> suppliers;
        private Product selectedProduct;
        private Product newProduct;
        private Product updatedProduct;
        #endregion


        #region Constructor
        /// <summary>
        /// FrmAddProduct()
        /// Form Constructor
        /// </summary>
        /// <param name="businessArg"></param>
        public FrmAddProduct(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
            categories = business.Categories;
            suppliers = business.Suppliers;
            newProduct = new Product();//represents product to be added to database
            updatedProduct = new Product();//represents product to be updated in database

        }
        #endregion


        #region Form Load

        /// <summary>
        /// FrmAddProduct_Load
        /// Loads form datat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            #region ToolTips
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.btnCatalog, "Current list of products");
            toolTip.SetToolTip(this.btnCategoryFrm, "Takes you to Add Category form");
            toolTip.SetToolTip(this.btnUpdateCategoryFrm, "Takes you to Add Category form");
            toolTip.SetToolTip(this.btnSupplierFrm, "Takes you to Add Supplier form");
            toolTip.SetToolTip(this.btnUpdateSupplierFrm, "Takes you to Add Supplier form");

            toolTip.SetToolTip(this.tbxProductName, "Please choose a unique name for product");
            toolTip.SetToolTip(this.tbxUpdateProductName, "Please choose a unique name for product");
            toolTip.SetToolTip(this.cmbSupplier, "Choose a supplier");
            toolTip.SetToolTip(this.cmbUpdateSupplier, "Choose a supplier");
            toolTip.SetToolTip(this.cmbCategory, "Choose a category");
            toolTip.SetToolTip(this.cmbUpdateCategory, "Choose a category");
            toolTip.SetToolTip(this.tbxQtyPerUnit, "Quantity per unit e.g. 12 - 550 ml bottles");
            toolTip.SetToolTip(this.tbxUpdateQtyPerUnit, "Quantity per unit e.g. 12 - 550 ml bottles");
            toolTip.SetToolTip(this.tbxUnitPrice, "Price per unit as described above");
            toolTip.SetToolTip(this.tbxUpdateUnitPrice, "Price per unit as described above");
            toolTip.SetToolTip(this.tbxUnitsInStock, "Current number of units in stock");
            toolTip.SetToolTip(this.tbxUpdateUnitsInStock, "Current number of units in stock");
            toolTip.SetToolTip(this.tbxUnitsOnOrder, "Units currently on order");
            toolTip.SetToolTip(this.tbxUpdateUnitsOnOrder, "Units currently on order");
            toolTip.SetToolTip(this.tbxReorderLevel, "Level at which stock is to be reordered");
            toolTip.SetToolTip(this.tbxUpdateReorderLevel, "Level at which stock is to be reordered");

            toolTip.SetToolTip(this.chkBoxDiscontinued, "Check box if item is discontinued");

            toolTip.SetToolTip(this.btnClear, "Clears all fields on form");
            toolTip.SetToolTip(this.btnUpdateClear, "Clears all fields on form");
            toolTip.SetToolTip(this.btnAdd, "Adds product to database");
            toolTip.SetToolTip(this.btnUpdate, "Updates product in database");
            toolTip.SetToolTip(this.btnCancel, "Cancel order and closes form");
            toolTip.SetToolTip(this.btnUpdateCancel, "Cancel order and closes form");
            #endregion

            //load comboboxes
            foreach (Category c in categories)
            {
                cmbUpdateCategory.Items.Add(c);
                cmbCategory.Items.Add(c);
            }

            foreach (Supplier s in suppliers)
            {
                cmbUpdateSupplier.Items.Add(s);
                cmbSupplier.Items.Add(s);
            }

            toggleInput(false);

        }

        #endregion


        #region Add Product control methods

        /// <summary>
        /// tabAddProduct_Enter()
        /// Sets focus to first control on New Product Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabAddProduct_Enter(object sender, EventArgs e)
        {
            ActiveControl = tbxProductName;

        }


        /// <summary>
        /// btnOpenCategoryFrm_Click
        /// Opens an instance of FrmAddCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCategoryFrm_Click(object sender, EventArgs e)
        {
            FrmAddCategory categoryForm = new FrmAddCategory(business);
            categoryForm.MdiParent = this.MdiParent;
            categoryForm.Show();
        }


        /// <summary>
        /// btnOpenSupplierFrm_Click
        /// Opens an instance of FrmAddSupplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSupplierFrm_Click(object sender, EventArgs e)
        {
            FrmAddSupplier supplierForm = new FrmAddSupplier(business);
            supplierForm.MdiParent = this.MdiParent;
            supplierForm.Show();

        }


        /// <summary>
        /// btnClear_Click()
        /// Calls resetControls and resets focus to first interactive control on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetControls(this.tabAddProduct);
            tbxProductName.Focus();

        }


        /// <summary>
        /// btnCancel_Click
        /// method Close() is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// btnAdd_Click()
        /// When user chooses Add button on the Add Product tab, the product is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!frmValidated())
                return;

            string confirmation = business.addProduct(newProduct);

            MessageBox.Show(confirmation);

            btnClear_Click(sender, e);
        }
        #endregion


        #region Update Product control methods

        /// <summary>
        /// tabUpdateProduct_Enter()
        /// Sets focus to first control on Update Product Tab Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabUpdateProduct_Enter(object sender, EventArgs e)
        {
            ActiveControl = btnCatalog;

        }


        /// <summary>
        /// btnCatalog_Click()
        /// Shows a catalog in which users can select a product from in order to get details and update if desired.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatalog_Click(object sender, EventArgs e)
        {
            FrmCatalog catalog = new FrmCatalog(business);//create catalog object
            catalog.MdiParent = this.MdiParent;//set parent
            catalog.Text = this.Text;
            catalog.eventProductChosen += new FrmCatalog.ProductChosen(productChosen);//register handler with delegate for event
            catalog.Show();
        }


        /// <summary>
        /// btnUpdateClear_Click()
        /// Calls resetControls and resets focus to first interactive control on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            resetControls(this.tabUpdateProduct);
            toggleInput(false);
            btnCatalog.Focus();
        }


        /// <summary>
        /// btnUpdateCancel_Click()
        /// Clears and Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region Update Product
        /// <summary>
        /// btnUpdate_Click()
        /// When user chooses Submit button on the Update Product tab, the product is added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!updateFrmValidated())
                return;

            updatedProduct.ProductID = selectedProduct.ProductID;

            string confirmation = business.updateProduct(updatedProduct);

            MessageBox.Show(confirmation);

            btnUpdateClear_Click(sender, e);

        }


        #endregion


        #region Chosen Product
        /// <summary>
        /// productChosen()
        /// Handles "eventProductChosen" on FrmCatalog
        /// Gets a product from delegate and fills the Update form with its property values.
        /// <param name="Product">Object of type Product></param>
        private void productChosen(Product product)
        {
            Enabled = true;//enable this form

            selectedProduct = product;

            if (selectedProduct == null)//return if there aren't any selected products
                return;

            errorProvider.SetError(btnCatalog, "");

            foreach (Category c in categories)
            {
                if (selectedProduct.CategoryID == c.CategoryID)
                    cmbUpdateCategory.SelectedItem = c;

            }

            foreach (Supplier s in suppliers)
            {
                if (selectedProduct.CompanyName == s.CompanyName)
                    cmbUpdateSupplier.SelectedItem = s;

            }

            toggleInput(true);

            tbxUpdateProductName.Text = selectedProduct.ProductName;
            tbxUpdateQtyPerUnit.Text = selectedProduct.QuantityPerUnit;
            tbxUpdateUnitPrice.Text = selectedProduct.UnitPrice.ToString("F");
            tbxUpdateUnitsInStock.Text = selectedProduct.UnitsInStock.ToString();
            tbxUpdateUnitsOnOrder.Text = selectedProduct.UnitsOnOrder.ToString();
            tbxUpdateReorderLevel.Text = selectedProduct.ReorderLevel.ToString();
            chkBoxDiscontinued.Checked = selectedProduct.Discontinued;

        }

        #endregion

        #endregion


        #region Reset Controls
        /// <summary>
        /// resetControls()
        /// takes a Control object as a parameter and resets controls as specified
        /// </summary>
        /// <param name="product_Form">Object of Type Control</param>
        private void resetControls(Control product_Form)
        {
            foreach (Control c in product_Form.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }


            chkBoxDiscontinued.Checked = false;

        }
        #endregion


        #region Toggle Controls
        /// <summary>
        /// toggleInput()
        /// Used to enable controls on update form when a product is chosen from catalog.
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleInput(bool enabled)
        {

            tbxUpdateProductName.Enabled = enabled;
            tbxUpdateQtyPerUnit.Enabled = enabled;
            tbxUpdateUnitPrice.Enabled = enabled;
            tbxUpdateUnitsInStock.Enabled = enabled;
            tbxUpdateUnitsOnOrder.Enabled = enabled;
            tbxUpdateReorderLevel.Enabled = enabled;
            chkBoxDiscontinued.Enabled = enabled;

        }
        #endregion


        #region Validate Add Product Form
        /// <summary>
        /// frmValidated()
        /// contains logic to validate form controls that user modifies on Add Product form
        /// </summary>
        /// <returns>bool</returns>
        private bool frmValidated()
        {
            bool result = true;
            errorProvider.Clear();

            if (tbxProductName.Text == null || tbxProductName.Text == "")
            {
                errorProvider.SetError(tbxProductName, "Please choose a product name");
                result = false;
            }

            else
            {
                newProduct.ProductName = tbxProductName.Text;
            }


            if (cmbCategory.SelectedIndex != -1)
                newProduct.CategoryID = ((Category)cmbCategory.SelectedItem).CategoryID;

            else
            {
                errorProvider.SetError(cmbCategory, "Please select a Category");
                result = false;
            }



            if (cmbSupplier.SelectedIndex != -1)
                newProduct.SupplierID = ((Supplier)cmbSupplier.SelectedItem).SupplierID;

            else
            {
                errorProvider.SetError(cmbSupplier, "Please select a Supplier");
                result = false;
            }


            if (tbxUnitPrice.Text != null)
            {
                decimal t;

                if (decimal.TryParse(tbxUnitPrice.Text, out t))
                {

                    if (t >= 0)
                        newProduct.UnitPrice = t;

                    else
                    {
                        errorProvider.SetError(tbxUnitPrice, "Please choose a valid number to represent Price per Unit");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUnitPrice, "Please choose a valid number to represent Price per Unit");
                    result = false;
                }
            }


            if (tbxUnitsInStock.Text != null)
            {
                short t;
                if (short.TryParse(tbxUnitsInStock.Text, out t))
                {
                    if (t >= 0)
                        newProduct.UnitsInStock = t;

                    else
                    {
                        errorProvider.SetError(tbxUnitsInStock, "Please choose a valid number to represent Units In Stock");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUnitsInStock, "Please choose a valid number to represent Units In Stock");
                    result = false;
                }
            }


            if (tbxUnitsOnOrder.Text != null)
            {
                short t;
                if (short.TryParse(tbxUnitsOnOrder.Text, out t))
                {
                    if (t >= 0)
                        newProduct.UnitsOnOrder = t;

                    else
                    {
                        errorProvider.SetError(tbxUnitsOnOrder, "Please choose a valid number to represent Units on Order");
                        result = false;
                    }

                }
                else
                {
                    errorProvider.SetError(tbxUnitsOnOrder, "Please choose a valid number to represent Units on Order");
                    result = false;
                }
            }


            if (tbxReorderLevel.Text != null)
            {
                short t;

                if (short.TryParse(tbxReorderLevel.Text, out t))
                {
                    if (t >= 0)
                        newProduct.ReorderLevel = t;

                    else
                    {
                        errorProvider.SetError(tbxReorderLevel, "Please choose a valid number to represent the Reorder Level");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxReorderLevel, "Please choose a valid number to represent the Reorder Level");
                    result = false;
                }

            }

            newProduct.QuantityPerUnit = tbxQtyPerUnit.Text;

            return result;
        }
        #endregion


        #region Validate Update Form
        /// <summary>
        /// updateFrmValidated()
        /// contains logic to validate form controls that user modifies on update form
        /// </summary>
        /// <returns></returns>
        private bool updateFrmValidated()
        {
            bool result = true;
            errorProvider.Clear();

            if (selectedProduct == null)
            {
                errorProvider.SetError(btnCatalog, "Please choose a product to update");
                return false;
            }

            
            if (tbxUpdateProductName.Text == null || tbxUpdateProductName.Text == "")
            {
                errorProvider.SetError(tbxUpdateProductName, "Please choose a product name");
                result = false;
            }
            else
            {
                updatedProduct.ProductName = tbxUpdateProductName.Text;
            }


            if (cmbUpdateCategory.SelectedIndex != -1)
                updatedProduct.CategoryID = ((Category)cmbUpdateCategory.SelectedItem).CategoryID;
            else
            {
                errorProvider.SetError(cmbUpdateCategory, "Please select a Category");
                result = false;
            }


            if (cmbUpdateSupplier.SelectedIndex != -1)
                updatedProduct.SupplierID = ((Supplier)cmbUpdateSupplier.SelectedItem).SupplierID;
            else
            {
                errorProvider.SetError(cmbUpdateSupplier, "Please select a Supplier");
                result = false;
            }


            if (tbxUpdateUnitPrice.Text != null)
            {
                decimal t;
                if (decimal.TryParse(tbxUpdateUnitPrice.Text, out t))
                {
                    if (t >= 0)
                        updatedProduct.UnitPrice = t;
                    else
                    {
                        errorProvider.SetError(tbxUpdateUnitPrice, "Please choose a valid number to represent Price per Unit");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUpdateUnitPrice, "Please choose a valid number to represent Price per Unit");
                    result = false;
                }
            }


            if (tbxUpdateUnitsInStock.Text != null)
            {
                short t;
                if (short.TryParse(tbxUpdateUnitsInStock.Text, out t))
                {
                    if (t >= 0)
                        updatedProduct.UnitsInStock = t;
                    else
                    {
                        errorProvider.SetError(tbxUpdateUnitsInStock, "Please choose a valid number to represent Units In Stock");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUpdateUnitsInStock, "Please choose a valid number to represent Units In Stock");
                    result = false;
                }
            }


            if (tbxUpdateUnitsOnOrder.Text != null)
            {
                short t;
                if (short.TryParse(tbxUpdateUnitsOnOrder.Text, out t))
                {
                    if (t >= 0)
                        updatedProduct.UnitsOnOrder = t;
                    else
                    {
                        errorProvider.SetError(tbxUpdateUnitsOnOrder, "Please choose a valid number to represent Units on Order");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUpdateUnitsOnOrder, "Please choose a valid number to represent Units on Order");
                    result = false;
                }
            }


            if (tbxUpdateReorderLevel.Text != null)
            {
                short t;
                if (short.TryParse(tbxUpdateReorderLevel.Text, out t))
                {
                    if (t >= 0)
                        updatedProduct.ReorderLevel = t;
                    else
                    {
                        errorProvider.SetError(tbxUpdateReorderLevel, "Please choose a valid number to represent the Reorder Level");
                        result = false;
                    }
                }
                else
                {
                    errorProvider.SetError(tbxUpdateReorderLevel, "Please choose a valid number to represent the Reorder Level");
                    result = false;
                }
            }


            if (chkBoxDiscontinued.Checked)
               updatedProduct.Discontinued = true;
            else
               updatedProduct.Discontinued = false;
          

            updatedProduct.QuantityPerUnit = tbxUpdateQtyPerUnit.Text;

            return result;
        }
        #endregion
       

    }
}


    




    

