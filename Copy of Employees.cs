using System;

/// <summary>
/// class based on Employees
/// from database C:\Users\Tania\Dropbox\Algonquin\CST2335-Graphical_Interface_Programming_C#\Lab_Exercise_Week9\Northwind\Northwind\Northwind.mdb
/// </summary>
public class Employees
{
   private Int32 employeeID;
   private String lastName;
   private String firstName;
   private String title;
   private String titleOfCourtesy;
   private DateTime birthDate;
   private DateTime hireDate;
   private String address;
   private String city;
   private String region;
   private String postalCode;
   private String country;
   private String homePhone;
   private String extension;
   private String photo;
   private String notes;
   private Int32 reportsTo;

   public Employees()
   {
       // no Body
   } // end no argument constructor

   public Employees( Int32 _employeeID, String _lastName, String _firstName, String _title, String _titleOfCourtesy, DateTime _birthDate, DateTime _hireDate, String _address, String _city, String _region, String _postalCode, String _country, String _homePhone, String _extension, String _photo, String _notes, Int32 _reportsTo)
   {
      employeeID = _employeeID;
      lastName = _lastName;
      firstName = _firstName;
      title = _title;
      titleOfCourtesy = _titleOfCourtesy;
      birthDate = _birthDate;
      hireDate = _hireDate;
      address = _address;
      city = _city;
      region = _region;
      postalCode = _postalCode;
      country = _country;
      homePhone = _homePhone;
      extension = _extension;
      photo = _photo;
      notes = _notes;
      reportsTo = _reportsTo;
   } // end all argument constructor

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

   public String LastName
   {
      get
      {
         return lastName;
      }
      set
      {
         lastName = value;
      }
   } //end of property LastName

   public String FirstName
   {
      get
      {
         return firstName;
      }
      set
      {
         firstName = value;
      }
   } //end of property FirstName

   public String Title
   {
      get
      {
         return title;
      }
      set
      {
         title = value;
      }
   } //end of property Title

   public String TitleOfCourtesy
   {
      get
      {
         return titleOfCourtesy;
      }
      set
      {
         titleOfCourtesy = value;
      }
   } //end of property TitleOfCourtesy

   public DateTime BirthDate
   {
      get
      {
         return birthDate;
      }
      set
      {
         birthDate = value;
      }
   } //end of property BirthDate

   public DateTime HireDate
   {
      get
      {
         return hireDate;
      }
      set
      {
         hireDate = value;
      }
   } //end of property HireDate

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

   public String HomePhone
   {
      get
      {
         return homePhone;
      }
      set
      {
         homePhone = value;
      }
   } //end of property HomePhone

   public String Extension
   {
      get
      {
         return extension;
      }
      set
      {
         extension = value;
      }
   } //end of property Extension

   public String Photo
   {
      get
      {
         return photo;
      }
      set
      {
         photo = value;
      }
   } //end of property Photo

   public String Notes
   {
      get
      {
         return notes;
      }
      set
      {
         notes = value;
      }
   } //end of property Notes

   public Int32 ReportsTo
   {
      get
      {
         return reportsTo;
      }
      set
      {
         reportsTo = value;
      }
   } //end of property ReportsTo
} // end of class

