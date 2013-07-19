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

/// <summary>
/// Class based on Suppliers
/// from database C:\Northwind\Northwind\Northwind.mdb
/// </summary>
public class Supplier
{
   private Int32 supplierID;
   private String companyName;
   private String contactName;
   private String contactTitle;
   private String address;
   private String city;
   private String region;
   private String postalCode;
   private String country;
   private String phone;
   private String fax;
   private String homePage;

    public Supplier()
    {
        // no Body
    } // end no argument constructor

    public override string ToString()
    {
        return CompanyName;
    }

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
    } //end of property CompanyName

    public String ContactName
    {
        get
        {
            return contactName;
        }
        set
        {
            contactName = value;
        }
    } //end of property ContactName

    public String ContactTitle
    {
        get
        {
            return contactTitle;
        }
        set
        {
            contactTitle = value;
        }
    } //end of property ContactTitle

    public String Address
    {
        get
        {
            return address;
        }
        set
        {
            address = value;
        }
    } //end of property Address

    public String City
    {
        get
        {
            return city;
        }
        set
        {
            city = value;
        }
    } //end of property City

    public String Region
    {
        get
        {
            return region;
        }
        set
        {
            region = value;
        }
    } //end of property Region

    public String PostalCode
    {
        get
        {
            return postalCode;
        }
        set
        {
            postalCode = value;
        }
    } //end of property PostalCode

    public String Country
    {
        get
        {
            return country;
        }
        set
        {
            country = value;
        }
    } //end of property Country

    public String Phone
    {
        get
        {
            return phone;
        }
        set
        {
            phone = value;
        }
    } //end of property Phone

    public String Fax
    {
        get
        {
            return fax;
        }
        set
        {
            fax = value;
        }
    } //end of property Fax

    public String HomePage
    {
        get
        {
            return homePage;
        }
        set
        {
            homePage = value;
        }
   } //end of property HomePage
} // end of class

