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
using System.Drawing;
namespace NorthWind
{
    /// <summary>
    /// class based on Products
    /// from database C:\Northwind\Northwind\Northwind.mdb
    /// </summary>
   public class Product
    {
        private Int32 productID;
        private String productName;
        private Int32 supplierID;
        private Int32 categoryID;
        private String quantityPerUnit;
        private Decimal unitPrice;
        private Int16 unitsInStock;
        private Int16 unitsOnOrder;
        private Int16 reorderLevel;
        private Boolean discontinued;
        private String companyName;
        private Image picture;
        private Int32 quantity;
        

        public Product()
        {
            // no Body
        } // end no argument constructor

       
        public Int32 ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        } //end of property ProductID


        public String ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        } //end of property ProductName


        public Int32 SupplierID
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
            }
        } //end of property SupplierID


        public Int32 CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        } //end of property CategoryID


        public String QuantityPerUnit
        {
            get
            {
                return quantityPerUnit;
            }
            set
            {
                quantityPerUnit = value;
            }
        } //end of property QuantityPerUnit


        public Decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        } //end of property UnitPrice


        public Int16 UnitsInStock
        {
            get
            {
                return unitsInStock;
            }
            set
            {
                unitsInStock = value;
            }
        } //end of property UnitsInStock


        public Int16 UnitsOnOrder
        {
            get
            {
                return unitsOnOrder;
            }
            set
            {
                unitsOnOrder = value;
            }
        } //end of property UnitsOnOrder


        public Int16 ReorderLevel
        {
            get
            {
                return reorderLevel;
            }
            set
            {
                reorderLevel = value;
            }
        } //end of property ReorderLevel


        public Boolean Discontinued
        {
            get
            {
                return discontinued;
            }
            set
            {
                discontinued = value;
            }
        } //end of property Discontinued


        public String CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }//end of property SupplierName


        public Image Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }//end of property Picture


        public Int32 Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }//end of property Quantity
    }
}
