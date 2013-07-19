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
    /// Class based on Employees
    /// from database C:\Northwind\Northwind\Northwind.mdb
    /// </summary>
    public class Employee
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

        public Employee()
        {
            // no Body
        } // end no argument constructor

        
        public override string ToString()
        {
            return lastName + ", " + firstName;
        }

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

}