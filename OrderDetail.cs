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

namespace NorthWind
{
    /// <summary>
    /// Class based on Order Details
    /// from database C:\Northwind\Northwind\Northwind.mdb
    /// </summary>
    public class OrderDetail
    {
        private Int32 orderID;
        private Int32 productID;
        private Decimal unitPrice;
        private Int16 quantity;
        private Single discount;
        private string productName;

        public OrderDetail()
        {
            // no Body
        } // end no argument constructor

        
        public Int32 OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        } //end of property OrderID

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

        public Int16 Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        } //end of property Quantity

        public Single Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        } //end of property Discount

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        } //end of property Discount
    } // end of class

}

