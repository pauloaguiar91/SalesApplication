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
using System.IO;


namespace NorthWind
{
    /// <summary>
    /// FrmCatalog displays a list of products to choose from
    /// </summary>
    public partial class FrmCatalog : Form
       
    {
        #region class variables
        private Business business;//used to reference the Business object that owns this order/transaction
        private Product selectedProduct;//member variable to pass back selected list of product objects to control form
        #endregion


        #region delegates and events
        /// <summary>
        /// delegate ProductChosen()
        /// Is a delegate that returns a products
        /// </summary>
        /// <param name="chosenProducts" List of type Product></param>
        public delegate void ProductChosen(Product chosenProduct); //delegate declaration

        public event ProductChosen eventProductChosen;//event declaration, this event gets raised on form close

        #endregion


        #region constructor
        /// <summary>
        /// FrmCatalog()
        /// constructor for the Catalog form
        /// </summary>
        /// <param name="b"></param>
        public FrmCatalog(Business businessArg)
        {
            InitializeComponent();
            business = businessArg;
           
        }
        #endregion


        #region form load
        /// <summary>
        /// FrmCatalog_Load
        /// loads the product data and fills the datagridview control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void FrmCatalog_Load(object sender, EventArgs e)
        {
            FillGridBox(); //adds Products to Catalog Window
        }
        #endregion


        #region control events

        /// <summary>
        /// gridProducts_DoubleClick
        /// calls event handler btn_OK_Click()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridProducts_DoubleClick(object sender, EventArgs e)
        {
            btn_OK_Click(sender, e);
        }


        /// <summary>
        /// btn_OK_Click()
        /// Get the product object for each selected item in order to send back to Order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in gridProducts.SelectedRows)//loop through selected items in gridProducts window
            {

                selectedProduct = (Product)row.Tag; //for each item, capture product associated with the tag
               
            }

            Close();
        }
       

        /// <summary>
        /// btn_Cancel_Click()
        /// closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
          
            this.Close(); 
        }

        #endregion

             
        #region control methods

        /// <summary>
        /// fillListBox()
        /// Adds the products returned from Database to the ListView control
        /// </summary>
        private void FillGridBox()
        {
            List<Product> productData = business.Products;  //gets a List of Product objects from Business Layer
            for (int productIndex = 0; productIndex < productData.Count; productIndex++) //loop through items in the Product list
            {
               
                int rowIndex = gridProducts.Rows.Add(1);
                DataGridViewRow row = gridProducts.Rows[rowIndex];

                row.Cells[colProduct.Name].Value = productData[productIndex].ProductName;
                row.Cells[colSupplier.Name].Value = productData[productIndex].CompanyName;
                row.Cells[colQuantity.Name].Value = productData[productIndex].QuantityPerUnit;
                row.Cells[colUnitPrice.Name].Value = productData[productIndex].UnitPrice.ToString("F");

                //add picture to Image column representing the category of the product
                const int ThumbnailSize = 64;//create thumbnail size for our image
                int ImageHeight = productData[productIndex].Picture.Height;//get height
                int ImageWidth = productData[productIndex].Picture.Width;//get width
                if (ImageHeight > ImageWidth)//if height is greater than width
                {
                    ImageWidth = ImageWidth * ThumbnailSize / ImageHeight;//scale width
                    ImageHeight = ThumbnailSize;//set image height to thumbnail height
                }
                else
                {
                    ImageHeight = ImageHeight * ThumbnailSize / ImageWidth;//scale height
                    ImageWidth = ThumbnailSize;//set image width to thumbnail width
                }

                // Make thumbnail of full image and put that in Image column
                Image img = productData[productIndex].Picture.GetThumbnailImage(ImageWidth, ImageHeight, null, System.IntPtr.Zero);            
                row.Cells[colImage.Name].Value = img;

                // Set row height to match thumbnail size
                row.Height = ImageHeight;
                row.Tag = productData[productIndex];

            }

        }


        /// <summary>
        /// FrmCatalog_FormClosed()
        /// raises and event that sends a product back to all handlers, then clears handlers from delegate list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCatalog_FormClosed(object sender, FormClosedEventArgs e) /// on form closed
        {

            if (eventProductChosen != null) //check if any handlers registered for this event
                eventProductChosen(selectedProduct);//if there is one or more handlers, pass the selected catalog product to them
            
            
            eventProductChosen = null;//remove all handlers

        }
        #endregion
        
    }
       
}
 
    