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
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace NorthWind
{
    
    /// <summary>
    /// delegate TablesChanged()
    /// a zero parameter delegate used to notify event handlers of changes to database
    /// </summary>
    public delegate void TablesChanged();
    
    
    /// <summary>
    /// DataAccess Class contains the methods that directly access the database
    /// </summary>
    class DataAccess
    {
        #region Member Variables
        private OleDbConnection con;
        private OleDbDataAdapter da;

        //event that sends notification to handlers that a entity has been added or changed in its respective table
        public event TablesChanged productAdded_Changed; 
        public event TablesChanged categoryAdded_Changed; 
        public event TablesChanged customerAdded_Changed; 
        public event TablesChanged employeeAdded_Changed; 
        public event TablesChanged supplierAdded_Changed;
        public event TablesChanged shipperAdded_Changed; 
        #endregion


        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccess()
        {
            con = new OleDbConnection();
            con.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;"
                + @"Data Source=..\..\Northwind.mdb;Persist Security Info=False ";
            da = new OleDbDataAdapter();
        }
        #endregion


        #region Fetch Records
        /// <summary>
        /// FetchProducts()
        /// Connects to Database and requests data from Products, Suppliers and Categories tables, 
        /// stores data as Product objects and returns them in a List. 
        /// </summary>
        /// <returns>List of Type Product</returns>
        public List<Product> FetchProducts()
        {
            String selectQuery = "SELECT ProductID, ProductName, p.SupplierID, p.CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, "
            + "ReorderLevel, CompanyName, Discontinued, C.Picture FROM (Products P LEFT JOIN Suppliers S ON P.SupplierID = S.SupplierID)"
                + "LEFT JOIN Categories C ON P.CategoryID = C.CategoryID WHERE Discontinued = false ORDER BY ProductName";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Product> prod = new List<Product>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                prod.Add(new Product());
                prod[i].ProductID = (int)(dt.Rows[i]["ProductID"]);
                prod[i].ProductName = dt.Rows[i]["ProductName"].ToString();
                if ((dt.Rows[i]["SupplierID"]) != DBNull.Value)
                {
                    prod[i].SupplierID = (int)(dt.Rows[i]["SupplierID"]);
                }
                if ((dt.Rows[i]["CategoryID"]) != DBNull.Value)
                {
                    prod[i].CategoryID = (int)(dt.Rows[i]["CategoryID"]);
                }
                prod[i].QuantityPerUnit = dt.Rows[i]["QuantityPerUnit"].ToString();
                prod[i].UnitPrice = (decimal)(dt.Rows[i]["UnitPrice"]);
                prod[i].UnitsInStock = (short)(dt.Rows[i]["UnitsInStock"]);
                prod[i].UnitsOnOrder = (short)(dt.Rows[i]["UnitsOnOrder"]);
                prod[i].ReorderLevel = (short)(dt.Rows[i]["ReorderLevel"]);
                prod[i].CompanyName = dt.Rows[i]["CompanyName"].ToString();
                prod[i].Discontinued = (bool)dt.Rows[i]["Discontinued"];

                //Retrieve the byte array that contains the picture and convert it to an image object
                byte[] picArray = (byte[])dt.Rows[i]["Picture"];
                ImageConverter ic = new ImageConverter();
                prod[i].Picture = (Image)ic.ConvertFrom(picArray);

            }

            return prod;
        }


        /// <summary>
        /// FetchCategories()
        /// Connects to Database and requests data from Categories Table, stores data as Category objects,
        /// and puts the objects in a List. 
        /// Returns the List.
        /// </summary>
        /// <returns>List of Type Category</returns>
        public List<Category> FetchCategories()
        {
            String selectQuery = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories ORDER BY CategoryName";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Category> cat = new List<Category>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cat.Add(new Category());
                cat[i].CategoryID = (int)dt.Rows[i]["CategoryID"];
                cat[i].CategoryName = dt.Rows[i]["CategoryName"].ToString();
                cat[i].Description = dt.Rows[i]["Description"].ToString();
                if (dt.Rows[i]["Picture"] != DBNull.Value)
                {
                    //Retrieve the byte array that contains the picture and convert it to an image object
                    byte[] picArray = (byte[])dt.Rows[i]["Picture"];
                    ImageConverter ic = new ImageConverter();
                    cat[i].Picture = (Image)ic.ConvertFrom(picArray);
                }
            }
              return cat;
        }

        /// <summary>
        /// FetchCustomers()
        /// Connects to Database and requests data from Customer Table, stores data as Customer objects,
        /// and puts the objects in a List. 
        /// Returns the List.
        /// </summary>
        /// <returns>List of Type Customer</returns>
        public List<Customer> FetchCustomers()
        {
            String selectQuery = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, "
            + "Country, Phone, Fax FROM Customers ORDER BY CustomerID";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Customer> cust = new List<Customer>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cust.Add(new Customer());
                cust[i].CustomerID = dt.Rows[i]["CustomerID"].ToString();
                cust[i].CompanyName = dt.Rows[i]["CompanyName"].ToString();
                cust[i].ContactName = dt.Rows[i]["ContactName"].ToString();
                cust[i].ContactTitle = dt.Rows[i]["ContactTitle"].ToString();
                cust[i].Address = dt.Rows[i]["Address"].ToString();
                cust[i].City = dt.Rows[i]["City"].ToString();
                cust[i].Region = dt.Rows[i]["Region"].ToString();
                cust[i].PostalCode = dt.Rows[i]["PostalCode"].ToString();
                cust[i].Country = dt.Rows[i]["Country"].ToString();
                cust[i].Phone = dt.Rows[i]["Phone"].ToString();
                cust[i].Fax = dt.Rows[i]["Fax"].ToString();
            }
            return cust;
        }

        /// <summary>
        /// FetchEmployees()
        /// Connects to Database and requests data from Employee Table, stores data as Employee objects,
        /// and puts the objects in a List. 
        /// Returns the List.
        /// </summary>
        /// <returns>List of Type Employee</returns>
        public List<Employee> FetchEmployees()
        {
            String selectQuery = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate,"
            + " Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees ORDER BY LastName";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Employee> emp = new List<Employee>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                emp.Add(new Employee());
                emp[i].EmployeeID = (int)(dt.Rows[i]["EmployeeID"]);
                emp[i].LastName = dt.Rows[i]["LastName"].ToString();
                emp[i].FirstName = dt.Rows[i]["FirstName"].ToString();
                emp[i].Title = dt.Rows[i]["Title"].ToString();
                emp[i].TitleOfCourtesy = dt.Rows[i]["TitleOfCourtesy"].ToString();
                if ((dt.Rows[i]["BirthDate"]) != DBNull.Value)
                {
                    emp[i].BirthDate = (DateTime)dt.Rows[i]["BirthDate"];
                }
                if ((dt.Rows[i]["HireDate"]) != DBNull.Value)
                {
                    emp[i].HireDate = (DateTime)dt.Rows[i]["HireDate"];
                }
                emp[i].Address = dt.Rows[i]["Address"].ToString();
                emp[i].City = dt.Rows[i]["City"].ToString();
                emp[i].Region = dt.Rows[i]["Region"].ToString();
                emp[i].PostalCode = dt.Rows[i]["PostalCode"].ToString();
                emp[i].Country = dt.Rows[i]["Country"].ToString();
                emp[i].HomePhone = dt.Rows[i]["HomePhone"].ToString();
                emp[i].Extension = dt.Rows[i]["Extension"].ToString();
                emp[i].Photo = dt.Rows[i]["Photo"].ToString();
                emp[i].Notes = dt.Rows[i]["Notes"].ToString();
                if ((dt.Rows[i]["ReportsTo"]) != DBNull.Value)
                {
                    emp[i].ReportsTo = (int)(dt.Rows[i]["ReportsTo"]);
                }
                else
                {
                    emp[i].ReportsTo = 0;
                }
            }
            return emp;
        }

 
        /// <summary>
        /// FetchSuppliers()
        /// Connects to Database and requests data from Suplliers Table, stores data as Supplier objects,
        /// and puts the objects in a List. 
        /// Returns the List.
        /// </summary>
        /// <returns>List of Type Supplier</returns>
        public List<Supplier> FetchSuppliers()
        {
            String selectQuery = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, "
            + "Fax, HomePage FROM Suppliers ORDER BY CompanyName";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Supplier> sup = new List<Supplier>(dt.Rows.Count);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sup.Add(new Supplier());
                sup[i].SupplierID = (int)dt.Rows[i]["SupplierID"];
                sup[i].CompanyName = dt.Rows[i]["CompanyName"].ToString();
                sup[i].ContactName = dt.Rows[i]["ContactName"].ToString();
                sup[i].ContactTitle = dt.Rows[i]["ContactTitle"].ToString();
                sup[i].Address = dt.Rows[i]["Address"].ToString();
                sup[i].City = dt.Rows[i]["City"].ToString();
                sup[i].Region = dt.Rows[i]["Region"].ToString();
                sup[i].PostalCode = dt.Rows[i]["PostalCode"].ToString();
                sup[i].Country = dt.Rows[i]["Country"].ToString();
                sup[i].Phone = dt.Rows[i]["Phone"].ToString();
                sup[i].Fax = dt.Rows[i]["Fax"].ToString();
                sup[i].Fax = dt.Rows[i]["HomePage"].ToString();

            }
            return sup;
        }

        /// <summary>
        /// FetchShippers()
        /// Connects to Database and requests data from Shippers Table, stores data as Shipper objects,
        /// and puts the objects in a List. 
        /// Returns the List.
        /// </summary>
        /// <returns>List of Type Shipper</returns>
        public List<Shipper> FetchShippers()
        {
            String selectQuery = "SELECT ShipperID, CompanyName, Phone FROM Shippers ORDER BY CompanyName";
            da.SelectCommand = new OleDbCommand(selectQuery, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                //debug code
            }
            finally
            {
                con.Close();
            }
            //replaceDBNull(dt);

            List<Shipper> ship = new List<Shipper>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ship.Add(new Shipper());
                ship[i].ShipperID = (int)dt.Rows[i]["ShipperID"];
                ship[i].CompanyName = dt.Rows[i]["CompanyName"].ToString();
                ship[i].Phone = dt.Rows[i]["Phone"].ToString();
            }
            return ship;
        }

        #endregion


        #region Add Records
        /// <summary>
        /// InsertProduct()
        /// Takes a product object and adds a new record to the database table Products
        /// </summary>
        /// <param name="p">Object of type Product</param>
        public string InsertProduct(Product prod) //add product to DB and call delegate
        {
            String insertQuery = "INSERT INTO Products (ProductName, SupplierID, CategoryID, "
                + "QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES ("
                + ((String.IsNullOrEmpty(prod.ProductName)) ? "null" : "\"" + prod.ProductName + "\"") + ","
                + ((prod.SupplierID == 0) ? "null" : prod.SupplierID.ToString()) + ","
                + ((prod.CategoryID == 0) ? "null" : prod.CategoryID.ToString()) + ","
                + ((String.IsNullOrEmpty(prod.QuantityPerUnit)) ? "null" : "'" + prod.QuantityPerUnit + "'") + ","
                + prod.UnitPrice + ","
                + prod.UnitsInStock + ","
                + prod.UnitsOnOrder + ","
                + prod.ReorderLevel + ","
                + prod.Discontinued + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);

            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Product Added Failed";
            }
            finally
            {
                con.Close();
                
            }

            //raise event
            if (productAdded_Changed != null)//check to makes sure at least one handler registered
            {
                productAdded_Changed();
            }

            return "Product Added";
        }


        /// <summary>
        /// InsertCategory()
        /// Takes a Category object and adds a new record to the database table Categories
        ///         /// </summary>
        /// <param name="p">Object of type Category</param>
        public string InsertCategory(Category cat) //add category to DB and call delegate
        {
            String insertQuery = "INSERT INTO Categories (CategoryName, Description, Picture) VALUES ("
                + ((String.IsNullOrEmpty(cat.CategoryName)) ? "null" : "\"" + cat.CategoryName + "\"") + ","
                + ((String.IsNullOrEmpty(cat.Description)) ? "null" : "\"" + cat.Description + "\"") + ","
                + "@picture" + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            if (cat.Picture == null)
            {
                cmInsert.Parameters.AddWithValue("@picture",DBNull.Value);
            }
            else
            {
                ImageConverter ic = new ImageConverter();
                byte[] picArray = (byte[])ic.ConvertTo(cat.Picture, typeof(byte[]));
                cmInsert.Parameters.AddWithValue("@picture", picArray);
            }
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Category Added Failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (categoryAdded_Changed != null)//check to makes sure at least one handler registered
            {
                categoryAdded_Changed();
            }
            return "Category Added";
        }

        /// <summary>
        /// InsertCustomer()
        /// Takes a Customer object and adds a new record to the database table Customer
        /// </summary>
        /// <param name="p">Object of type Customer</param>
        public string InsertCustomer(Customer cust) //add customer to DB and call delegate
        {
            String insertQuery = "INSERT INTO Customers VALUES ("
                + "'" + cust.CustomerID  + "'" + ","
                + ((String.IsNullOrEmpty(cust.CompanyName)) ? "null" : "\"" + cust.CompanyName + "\"") + ","
                + ((String.IsNullOrEmpty(cust.ContactName)) ? "null" : "\"" + cust.ContactName + "\"") + ","
                + ((String.IsNullOrEmpty(cust.ContactTitle)) ? "null" : "\"" + cust.ContactTitle + "\"") + ","
                + ((String.IsNullOrEmpty(cust.Address)) ? "null" : "\"" + cust.Address + "\"") + ","
                + ((String.IsNullOrEmpty(cust.City)) ? "null" : "\"" + cust.City + "\"") + ","
                + ((String.IsNullOrEmpty(cust.Region)) ? "null" : "\"" + cust.Region + "\"") + ","
                + ((String.IsNullOrEmpty(cust.PostalCode)) ? "null" : "'" + cust.PostalCode + "'") + ","
                + ((String.IsNullOrEmpty(cust.Country)) ? "null" : "\"" + cust.Country + "\"") + ","
                + ((String.IsNullOrEmpty(cust.Phone)) ? "null" : "'" + cust.Phone + "'") + ","
                + ((String.IsNullOrEmpty(cust.Fax)) ? "null" : "'" + cust.Fax + "'") + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Customer Added Failed";
            }
            finally
            {
                con.Close();
            }
        
            //raise event
            if (customerAdded_Changed != null)//check to makes sure at least one handler registered
            {
                customerAdded_Changed();
            }
            return "Customer Added";
        }


        /// <summary>
        /// InsertEmployee()
        /// Takes a Employee object and adds a new record to the database table Employees
        /// </summary>
        /// <param name="p">Object of type Employee</param>
        public string InsertEmployee(Employee emp) //add employee to DB and call delegate
        {
            String insertQuery = "INSERT INTO Employees (LastName, FirstName, Title, TitleOfCourtesy, "
                + "BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, "
                + "Photo, Notes, ReportsTo) VALUES ("
                + ((String.IsNullOrEmpty(emp.LastName)) ? "null" : "\"" + emp.LastName + "\"") + ","
                + ((String.IsNullOrEmpty(emp.FirstName)) ? "null" : "\"" + emp.FirstName + "\"") + ","
                + ((String.IsNullOrEmpty(emp.Title)) ? "null" : "'" + emp.Title + "'") + ","
                + ((String.IsNullOrEmpty(emp.TitleOfCourtesy)) ? "null" : "\"" + emp.TitleOfCourtesy + "\"") + ","
                + ((emp.BirthDate == null) ? "null" : "#" + emp.BirthDate.ToShortDateString()) + "#" + ","
                + ((emp.HireDate == null) ? "null" : "#" + emp.HireDate.ToShortDateString()) + "#" + ","
                + ((String.IsNullOrEmpty(emp.Address)) ? "null" : "\"" + emp.Address + "\"") + ","
                + ((String.IsNullOrEmpty(emp.City)) ? "null" : "\"" + emp.City + "\"") + ","
                + ((String.IsNullOrEmpty(emp.Region)) ? "null" : "\"" + emp.Region + "\"") + ","
                + ((String.IsNullOrEmpty(emp.PostalCode)) ? "null" : "'" + emp.PostalCode + "'") + ","
                + ((String.IsNullOrEmpty(emp.Country)) ? "null" : "\"" + emp.Country + "\"") + ","
                + ((String.IsNullOrEmpty(emp.HomePhone)) ? "null" : "'" + emp.HomePhone + "'") + ","
                + ((String.IsNullOrEmpty(emp.Extension)) ? "null" : "'" + emp.Extension + "'") + ","
                + ((String.IsNullOrEmpty(emp.Photo)) ? "null" : "'" + emp.Photo + "'") + ","
                + ((String.IsNullOrEmpty(emp.Notes)) ? "null" : "\"" + emp.Notes + "\"") + ","
                + ((emp.ReportsTo == 0) ? "null" : emp.ReportsTo.ToString()) + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //can't display any error feedback in data access layer
                MessageBox.Show(e.Message);
                return "Employee Added Failed";
               
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (employeeAdded_Changed != null)//check to makes sure at least one handler registered
            {
                employeeAdded_Changed();
            }
            return "Employee Added";
        }

        /// <summary>
        /// InsertSupplier()
        /// Takes a Supplier object and adds a new record to the database table Suppliers
        /// </summary>
        /// <param name="p">Object of type Supplier</param>
        public string InsertSupplier(Supplier supp) //add supplier to DB and call delegate
        {
            String insertQuery = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, "
                + "Country, Phone, Fax, HomePage) VALUES ("
                + ((String.IsNullOrEmpty(supp.CompanyName)) ? "null" : "\"" + supp.CompanyName + "\"") + ","
                + ((String.IsNullOrEmpty(supp.ContactName)) ? "null" : "\"" + supp.ContactName + "\"") + ","
                + ((String.IsNullOrEmpty(supp.ContactTitle)) ? "null" : "\"" + supp.ContactTitle + "\"") + ","
                + ((String.IsNullOrEmpty(supp.Address)) ? "null" : "\"" + supp.Address + "\"") + ","
                + ((String.IsNullOrEmpty(supp.City)) ? "null" : "\"" + supp.City + "\"") + ","
                + ((String.IsNullOrEmpty(supp.Region)) ? "null" : "\"" + supp.Region + "\"") + ","
                + ((String.IsNullOrEmpty(supp.PostalCode)) ? "null" : "'" + supp.PostalCode + "'") + ","
                + ((String.IsNullOrEmpty(supp.Country)) ? "null" : "\"" + supp.Country + "\"") + ","
                + ((String.IsNullOrEmpty(supp.Phone)) ? "null" : "'" + supp.Phone + "'") + ","
                + ((String.IsNullOrEmpty(supp.Fax)) ? "null" : "'" + supp.Fax + "'") + ","
                + ((String.IsNullOrEmpty(supp.HomePage)) ? "null" : "'" + supp.HomePage + "'") + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Supplier Added Failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (supplierAdded_Changed != null)//check to makes sure at least one handler registered
            {
                supplierAdded_Changed();
            }

            return "Supplier Added";
        }


        /// <summary>
        /// InsertShipper()
        /// Takes a Shipper object and adds a new record to the database table Shippers
        /// </summary>
        /// <param name="p">Object of type Shipper</param>
        public string InsertShipper(Shipper shpr) //add shipper to DB and call delegate
        {
            String insertQuery = "INSERT INTO Shippers (CompanyName, Phone) VALUES ("
                + ((String.IsNullOrEmpty(shpr.CompanyName)) ? "null" : "\"" + shpr.CompanyName + "\"") + ","
                + ((String.IsNullOrEmpty(shpr.Phone)) ? "null" : "'" + shpr.Phone + "'") + ")";

            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Shipper Added Failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (shipperAdded_Changed != null)//check to makes sure at least one handler registered
            {
                shipperAdded_Changed();
            }
            return "Shipper Added";
        }

        /// <summary>
        /// InsertOrder()
        /// Takes an Order Object and inserts Order properties into Order Table.
        /// Returns OrderID as int.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>int represents OrderID of Order just placed</returns>
        public int InsertOrder(Order order)
        {
            String insertQuery = "INSERT INTO Orders(CustomerID, EmployeeID, OrderDate) VALUES (\""
                + order.CustomerID.ToString() + "\",\"" + order.EmployeeID.ToString() + "\",\""
                + order.OrderDate.ToShortDateString() + "\")";
            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);

            String selectQuery = "SELECT MAX(OrderID) FROM Orders";
            OleDbCommand cmSelect = new OleDbCommand(selectQuery, con);

            int lastOrderId = 0;
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
                lastOrderId = (int)(cmSelect.ExecuteScalar());
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                
            }
            finally
            {
                con.Close();
            }
            return lastOrderId;
        }

        /// <summary>
        /// InsertOrderDetails()
        /// Takes an OrderDetail object and inserts its properties into the Order Details Table.
        /// </summary>
        /// <param name="orderDetail"></param>
        public void InsertOrderDetails(OrderDetail orderDetail)
        {
            String insertQuery = "INSERT INTO [Order Details](OrderID, ProductID, UnitPrice, Quantity) VALUES ("
                + orderDetail.OrderID.ToString() + "," + orderDetail.ProductID.ToString() + ","
                + orderDetail.UnitPrice.ToString() + "," + orderDetail.Quantity.ToString() + ")";
            OleDbCommand cmInsert = new OleDbCommand(insertQuery, con);
            try
            {
                con.Open();
                cmInsert.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #region Update Records
        /// <summary>
        /// UpdateProduct(Product prod)
        /// Update product passed to Products table based on the product ID
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public string UpdateProduct(Product prod) //add product to DB and call delegate
        {
            String updateQuery = "UPDATE Products "
                + "SET ProductName = " + ((String.IsNullOrEmpty(prod.ProductName)) ? "null" : "\"" + prod.ProductName + "\"")
                + ", SupplierID = " + ((prod.SupplierID == 0) ? "null" : prod.SupplierID.ToString())
                + ", CategoryID = " + ((prod.CategoryID == 0) ? "null" : prod.CategoryID.ToString())
                + ", QuantityPerUnit = " + ((String.IsNullOrEmpty(prod.QuantityPerUnit)) ? "null" : "'" + prod.QuantityPerUnit + "'")
                + ", UnitPrice = " + prod.UnitPrice
                + ", UnitsInStock = " + prod.UnitsInStock
                + ", UnitsOnOrder = " + prod.UnitsOnOrder
                + ", ReorderLevel = " + prod.ReorderLevel
                + ", Discontinued = " + prod.Discontinued
                + " WHERE ProductID = " + prod.ProductID;

            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Product Updated Failed";
            }
            finally
            {
                con.Close();
            }
                        
        
            //raise event
            if (productAdded_Changed != null)//check to makes sure at least one handler registered
            {
                productAdded_Changed();
            }

            return "Product Updated";
        }

 

        public string UpdateCategory(Category cat) //add category to DB and call delegate
        {
            String updateQuery = "UPDATE Categories "
                + "SET CategoryName = " + "\"" + cat.CategoryName + "\""
                + ", Description = " + ((String.IsNullOrEmpty(cat.Description)) ? "null" : "\"" + cat.Description + "\"")
                + ", Picture = @picture"
                + " WHERE CategoryID = " + cat.CategoryID;

            //String updateQuery = "Update Categories Set CategoryName = \"as\", Description = \"df\", Picture = @picture WHERE CategoryID = 0";
            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            if (cat.Picture == null)
            {
                cmUpdate.Parameters.AddWithValue("@picture", DBNull.Value);
            }
            else
            {
                ImageConverter ic = new ImageConverter();
                byte[] picArray = (byte[])ic.ConvertTo(cat.Picture, typeof(byte[]));
                cmUpdate.Parameters.AddWithValue("@picture", picArray);
            }
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Category Updated Failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (categoryAdded_Changed != null)//check to makes sure at least one handler registered
            {
                categoryAdded_Changed();
            }

            return "Category Updated";
        }


        public string UpdateCustomer(Customer cust) //add customer to DB and call delegate
        {
            String updateQuery = "UPDATE Customers "
                + "SET CustomerID = " + ((String.IsNullOrEmpty(cust.CustomerID)) ? "null" : "\"" + cust.CustomerID + "\"")
                + ", CompanyName = " + ((String.IsNullOrEmpty(cust.CompanyName)) ? "null" : "\"" + cust.CompanyName + "\"")
                + ", ContactName = " + ((String.IsNullOrEmpty(cust.ContactName)) ? "null" : "\"" + cust.ContactName + "\"")
                + ", ContactTitle = " + ((String.IsNullOrEmpty(cust.ContactTitle)) ? "null" : "'" + cust.ContactTitle + "'")
                + ", Address = " + ((String.IsNullOrEmpty(cust.Address)) ? "null" : "\"" + cust.Address + "\"")
                + ", City = " + ((String.IsNullOrEmpty(cust.City)) ? "null" : "'" + cust.City + "'")
                + ", Region = " + ((String.IsNullOrEmpty(cust.Region)) ? "null" : "\"" + cust.Region + "\"")
                + ", PostalCode = " + ((String.IsNullOrEmpty(cust.PostalCode)) ? "null" : "'" + cust.PostalCode + "'")
                + ", Country = " + ((String.IsNullOrEmpty(cust.Country)) ? "null" : "\"" + cust.Country + "\"")
                + ", Phone = " + ((String.IsNullOrEmpty(cust.Phone)) ? "null" : "'" + cust.Phone + "'")
                + ", Fax = " + ((String.IsNullOrEmpty(cust.Fax)) ? "null" : "'" + cust.Fax + "'")
                + " WHERE CustomerID = '" + cust.CustomerID + "'";

            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //can't display any error feedback in data access layer
                return "Customer Updated Failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (customerAdded_Changed != null)//check to makes sure at least one handler registered
            {
                customerAdded_Changed();
            }

            return "Customer Updated";
        }


        public string UpdateEmployee(Employee emp) //add employee to DB and call delegate
        {
            String updateQuery = "UPDATE Employees "
                + "SET LastName = " + ((String.IsNullOrEmpty(emp.LastName)) ? "null" : "\"" + emp.LastName + "\"")
                + ", FirstName = " + ((String.IsNullOrEmpty(emp.FirstName)) ? "null" : "\"" + emp.FirstName + "\"")
                + ", Title = " + ((String.IsNullOrEmpty(emp.Title)) ? "null" : "'" + emp.Title + "'")
                + ", TitleOfCourtesy = " + ((String.IsNullOrEmpty(emp.TitleOfCourtesy)) ? "null" : "\"" + emp.TitleOfCourtesy + "\"")
                + ", BirthDate = " + ((emp.BirthDate == null) ? "null" :  "#" + emp.BirthDate.ToShortDateString()) + "#"
                + ", HireDate = " + ((emp.HireDate == null) ? "null" :  "#" + emp.HireDate.ToShortDateString()) + "#"
                + ", Address = " + ((String.IsNullOrEmpty(emp.Address)) ? "null" : "'" + emp.Address + "'")
                + ", City = " + ((String.IsNullOrEmpty(emp.City)) ? "null" : "\"" + emp.City + "\"")
                + ", Region = " + ((String.IsNullOrEmpty(emp.Region)) ? "null" : "\"" + emp.Region + "\"")
                + ", PostalCode = " + ((String.IsNullOrEmpty(emp.PostalCode)) ? "null" : "'" + emp.PostalCode + "'")
                + ", Country = " + ((String.IsNullOrEmpty(emp.Country)) ? "null" : "\"" + emp.Country + "\"")
                + ", HomePhone = " + ((String.IsNullOrEmpty(emp.HomePhone)) ? "null" : "'" + emp.HomePhone + "'")
                + ", Extension = " + ((String.IsNullOrEmpty(emp.Extension)) ? "null" : "'" + emp.Extension + "'")
                + ", Photo = " + ((String.IsNullOrEmpty(emp.Photo)) ? "null" : "'" + emp.Photo + "'")
                + ", Notes = " + ((String.IsNullOrEmpty(emp.Notes)) ? "null" : "\"" + emp.Notes + "\"")
                + ", ReportsTo = " + ((emp.ReportsTo == 0) ? "null" : emp.ReportsTo.ToString())
                + " WHERE EmployeeID = " + emp.EmployeeID;

            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Employee Updated failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (employeeAdded_Changed != null)//check to makes sure at least one handler registered
            {
                employeeAdded_Changed();
            }

            return "Employee Updated";
        }


        public string UpdateSupplier(Supplier supp) //add supplier to DB and call delegate
        {
            String updateQuery = "UPDATE Suppliers "
                + "SET CompanyName = " + ((String.IsNullOrEmpty(supp.CompanyName)) ? "null" : "\"" + supp.CompanyName + "\"")
                + ", ContactName = " + ((String.IsNullOrEmpty(supp.ContactName)) ? "null" : "\"" + supp.ContactName + "\"")
                + ", ContactTitle = " + ((String.IsNullOrEmpty(supp.ContactTitle)) ? "null" : "\"" + supp.ContactTitle + "\"")
                + ", Address = " + ((String.IsNullOrEmpty(supp.Address)) ? "null" : "\"" + supp.Address + "\"")
                + ", City = " + ((String.IsNullOrEmpty(supp.City)) ? "null" : "'" + supp.City + "'")
                + ", Region = " + ((String.IsNullOrEmpty(supp.Region)) ? "null" : "\"" + supp.Region + "\"")
                + ", PostalCode = " + ((String.IsNullOrEmpty(supp.PostalCode)) ? "null" : "'" + supp.PostalCode + "'")
                + ", Country = " + ((String.IsNullOrEmpty(supp.Country)) ? "null" : "\"" + supp.Country + "\"")
                + ", Phone = " + ((String.IsNullOrEmpty(supp.Phone)) ? "null" : "'" + supp.Phone + "'")
                + ", Fax = " + ((String.IsNullOrEmpty(supp.Fax)) ? "null" : "'" + supp.Fax + "'")
                + ", HomePage = " + ((String.IsNullOrEmpty(supp.HomePage)) ? "null" : "'" + supp.HomePage + "'")
                + " WHERE SupplierID = " + supp.SupplierID;
            
            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //can't display any error feedback in data access layer
                return "Supplier Updated failed";
                
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (supplierAdded_Changed != null)//check to makes sure at least one handler registered
            {
                supplierAdded_Changed();
            }

            return "Supplier Updated";
        }


        public string UpdateShipper(Shipper shpr) //add shipper to DB and call delegate
        {
            String updateQuery = "UPDATE Shippers "
                + "SET CompanyName = " + ((String.IsNullOrEmpty(shpr.CompanyName)) ? "null" : "\"" + shpr.CompanyName + "\"")
                + ", Phone = " + ((String.IsNullOrEmpty(shpr.Phone)) ? "null" : "'" + shpr.Phone + "'")
                + " WHERE ShipperID = " + shpr.ShipperID;

            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
                return "Shipper Updated failed";
            }
            finally
            {
                con.Close();
            }

            //raise event
            if (shipperAdded_Changed != null)//check to makes sure at least one handler registered
            {
                shipperAdded_Changed();
            }

            return "Shipper Updated";
        }


        /// <summary>
        /// RemoveUnitsFromStock()
        /// Takes a ProductID and number of items sold to update the Units In Stock for that 
        /// product in Products Table.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="itemsSold"></param>
        public void RemoveUnitsFromStock(int ProductID, int itemsSold)
        {
            String updateQuery = "UPDATE Products SET UnitsInStock = UnitsInStock - " + itemsSold + " WHERE ProductID = "
            + ProductID;
            OleDbCommand cmUpdate = new OleDbCommand(updateQuery, con);
            try
            {
                con.Open();
                cmUpdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //can't display any error feedback in data access layer
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        
    }
}
