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
/// Class based on Shippers
/// from database C:\Northwind\Northwind\Northwind.mdb
/// </summary>
public class Shipper
{
   private Int32 shipperID;
   private String companyName;
   private String phone;

    public Shipper()
    {
        // no Body
    } // end no argument constructor

    public override string ToString()
    {
        return CompanyName;
    }

    public Int32 ShipperID
    {
        get
        {
            return shipperID;
        }
        set
        {
            shipperID = value;
        }
    } //end of property ShipperID

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
} // end of class

