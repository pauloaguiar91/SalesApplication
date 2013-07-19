/***************************************************************************************************/
/**                                                                                               **/
/**                                                                                               **/
/**    Student Name                :  Paulo Aguiar, Shengwei He, Greg Nikitin, Tania Rossi        **/
/**    EMail Address               :                                                              **/
/**    Student Number              :  Group 01                                                    **/
/**    Course Number               :  CST2335                                                     **/
/**    Lab Section Number          :  410-411                                                     **/
/**    Professor Name              :  John Tappin                                                 **/
/**    Assignment Name/Number/Date :  Project 1/01/November 19, 2012                              **/
/**    Optional Comments           :                                                              **/
/**                                                                                               **/
/**                                                                                               **/
/***************************************************************************************************/
using System;
namespace NorthWind
{
    /// <summary>
    /// Class based on Orders
    /// from database C:\Northwind\Northwind\Northwind.mdb
    /// </summary>

    public class Order
    {
        private Int32 orderID;
        private String customerID;
        private Int32 employeeID;
        private DateTime orderDate;
        private DateTime requiredDate;
        private DateTime shippedDate;
        private Int32 shipVia;
        private Decimal freight;
        private String shipName;
        private String shipAddress;
        private String shipCity;
        private String shipRegion;
        private String shipPostalCode;
        private String shipCountry;

        public Order()
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

        public String CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        } //end of property CustomerID

        public Int32 EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        } //end of property EmployeeID

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        } //end of property OrderDate

        public DateTime RequiredDate
        {
            get
            {
                return requiredDate;
            }
            set
            {
                requiredDate = value;
            }
        } //end of property RequiredDate

        public DateTime ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                shippedDate = value;
            }
        } //end of property ShippedDate

        public Int32 ShipVia
        {
            get
            {
                return shipVia;
            }
            set
            {
                shipVia = value;
            }
        } //end of property ShipVia

        public Decimal Freight
        {
            get
            {
                return freight;
            }
            set
            {
                freight = value;
            }
        } //end of property Freight

        public String ShipName
        {
            get
            {
                return shipName;
            }
            set
            {
                shipName = value;
            }
        } //end of property ShipName

        public String ShipAddress
        {
            get
            {
                return shipAddress;
            }
            set
            {
                shipAddress = value;
            }
        } //end of property ShipAddress

        public String ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
            }
        } //end of property ShipCity

        public String ShipRegion
        {
            get
            {
                return shipRegion;
            }
            set
            {
                shipRegion = value;
            }
        } //end of property ShipRegion

        public String ShipPostalCode
        {
            get
            {
                return shipPostalCode;
            }
            set
            {
                shipPostalCode = value;
            }
        } //end of property ShipPostalCode

        public String ShipCountry
        {
            get
            {
                return shipCountry;
            }
            set
            {
                shipCountry = value;
            }
        } //end of property ShipCountry
    } // end of class
}

