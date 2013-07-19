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
using System.Text;
using System.Windows.Forms;

namespace NorthWind
{
    /// <summary>
    /// Business class to takes care of all business logic
    /// </summary>
    public class Business : IDisposable
    {

        #region Member Variables

        private DataAccess database;//Database Access Layer

        private List<Product> products;
        private List<Category> categories;
        private List<Customer> customers;
        private List<Employee> employees;
        private List<Supplier> suppliers;
        private List<Shipper> shippers;
               
        #endregion


        #region Constructor

        /// <summary>
        /// Business()
        /// Class constructor
        /// </summary>
        public Business()
        {

            database = new DataAccess();
            
            //get and copy data
            loadProductData();
            loadCategoryData();
            loadCustomerData();
            loadEmployeeData();
            loadSupplierData();
            loadShipperData();

            //register event handlers
            database.productAdded_Changed += new TablesChanged(loadProductData);
            database.categoryAdded_Changed += new TablesChanged(loadCategoryData);
            database.customerAdded_Changed += new TablesChanged(loadCustomerData);
            database.employeeAdded_Changed += new TablesChanged(loadEmployeeData);
            database.supplierAdded_Changed += new TablesChanged(loadSupplierData);
            database.shipperAdded_Changed += new TablesChanged(loadShipperData);

            //start control form
            Application.Run(new FrmControl(this));
                        
        }

        #endregion

   
        #region Properties

        public List<Product> Products
        {
            get
            {
                return products;
            }
            
        } //end of property Products;


        public List<Category> Categories
        {
            get
            {
                return categories;
            }

        } //end of property Categories;


        public List<Customer> Customers        {
            get
            {
                return customers;
            }

        } //end of property Customers;


        public List<Employee> Employees
        {
            get
            {
                return employees;
            }

        } //end of property employees;


        public List<Supplier> Suppliers
        {
            get
            {
                return suppliers;
            }

        } //end of property Suppliers;


        public List<Shipper> Shippers
        {
            get
            {
                return shippers;
            }

        } //end of property Shippers;
        #endregion


        #region Event Handlers

        /// <summary>
        /// reloadProductData()
        /// Handler to fetch new product information when Products Table is changed.
        /// </summary>
        public void reloadProductData()
        {
            loadProductData();
        }


        /// <summary>
        /// reloadCategoryData()
        /// Handler to fetch new product information when Categories Table is changed.
        /// </summary>
        public void reloadCategoryData()
        {

            loadCategoryData();                                       
                                                     
        }


        /// <summary>
        /// reloadCustomerData()
        /// Handler to fetch new customer information when Customers Table is changed.
        /// </summaryto update all >
        public void reloadCustomerData()
        {
            loadCustomerData();
        }


        /// <summary>
        /// reloadEmployeeData()
        /// Handler to fetch new Employee information when Employees Table is changed.
        /// </summaryto update all >
        public void reloadEmployeeData()
        {
            loadEmployeeData();
        }


        /// <summary>
        /// reloadSupplierData()
        /// Handler to fetch new product information when Suppliers Table is changed.
        /// </summary>
        public void reloadSupplierData()
        {
            loadSupplierData();
        }

        //
        public void addCategoryListener(TablesChanged handler)
        {
            database.categoryAdded_Changed += handler;
        }

        public void removeCategoryListener(TablesChanged handler)
        {
            database.categoryAdded_Changed -= handler;
        }

        #endregion


        #region Fetch Records
        
        /// <summary>
        /// fetchProducts()
        /// Gets product records from database and returns a copy of it
        /// </summary>
        /// <returns>List of type Product</returns>
        public void loadProductData()
        {
            products = database.FetchProducts();
            List<Product> copyProducts = new List<Product>();
            Product copy;

            foreach (Product p in products)
            {
                copy = new Product();//create new object

                //add properties
                copy.ProductID = p.ProductID;
                copy.ProductName = p.ProductName;
                copy.CategoryID = p.CategoryID;
                copy.QuantityPerUnit = p.QuantityPerUnit;
                copy.UnitPrice = p.UnitPrice;
                copy.UnitsInStock = p.UnitsInStock;
                copy.UnitsOnOrder = p.UnitsOnOrder;
                copy.ReorderLevel = p.ReorderLevel;
                copy.Discontinued = p.Discontinued;
                copy.CompanyName = p.CompanyName;
                copy.Picture = p.Picture;

                copyProducts.Add(copy);//add to new list
                products = copyProducts;

            }

          
        }


        /// <summary>
        /// fetchCategories()
        /// Gets category records from database and returns a copy of it
        /// </summary>
        /// <returns>List of type Category</returns>
        public void loadCategoryData()
        {
            categories = database.FetchCategories();
            List<Category> copyCategories = new List<Category>();
            Category copy;

            foreach (Category c in categories)
            {
                copy = new Category();//create new object

                //add properties
                copy.CategoryID = c.CategoryID;
                copy.CategoryName = c.CategoryName;
                copy.Description = c.Description;
                copy.Picture = c.Picture;
         
                copyCategories.Add(copy);//add to new list
                categories = copyCategories;
            }

        }


            /// <summary>
            /// fetchCustomers()
            /// Gets customer records from database and returns a copy of it
            /// </summary>
            /// <returns>List of type Customer</returns>
            public void loadCustomerData()
            {
                customers = database.FetchCustomers();
                            
                List<Customer> copyCustomers = new List<Customer>();
                Customer copy;

                foreach (Customer c in customers)
                {
                    copy = new Customer();//create object

                    //add properties
                    
                    copy.CustomerID = c.CustomerID;
                    copy.CompanyName = c.CompanyName;
                    copy.ContactName = c.ContactName;
                    copy.ContactTitle = c.ContactTitle;
                    copy.Address = c.Address;
                    copy.City = c.City;
                    copy.Region = c.Region;
                    copy.PostalCode = c.PostalCode;
                    copy.Country = c.Country;
                    copy.Phone = c.Phone;
                    copy.Fax = c.Fax;

                    copyCustomers.Add(copy);//add to new list
                    customers = copyCustomers;

                }
          
            }


            /// <summary>
            /// fetchEmployees()
            /// Gets Employee records from database and returns a copy of it
            /// </summary>
            /// <returns>List of type Employee</returns>
            public void loadEmployeeData()
            {
                employees = database.FetchEmployees();
                
                List<Employee> copyEmployees = new List<Employee>();
                Employee copy;

                foreach (Employee e in employees)
                {
                    copy = new Employee();//create new object

                    //add properties
                    copy.EmployeeID = e.EmployeeID;
                    copy.LastName = e.LastName;
                    copy.FirstName = e.FirstName;
                    copy.Title = e.Title;
                    copy.TitleOfCourtesy = e.TitleOfCourtesy;
                    copy.BirthDate = e.BirthDate;
                    copy.HireDate = e.HireDate;
                    copy.Address = e.Address;
                    copy.City = e.City;
                    copy.Region = e.Region;
                    copy.PostalCode = e.PostalCode;
                    copy.Country = e.Country;
                    copy.HomePhone = e.HomePhone;
                    copy.Extension = e.Extension;
                    copy.Photo = e.Photo;
                    copy.Notes = e.Notes;
                    copy.ReportsTo = e.ReportsTo;
                    
                    copyEmployees.Add(copy);//add to new list
                    employees = copyEmployees;

                }
              
            }

        
            /// <summary>
            /// fetchSuppliers()
            /// Gets Supplier records from database and returns a copy of it
            /// </summary>
            /// <returns>List of type Supplier</returns>
            public void loadSupplierData()
            {
                    suppliers = database.FetchSuppliers();
                         
                    List<Supplier> copySuppliers = new List<Supplier>();
                    Supplier copy;

                    foreach (Supplier s in suppliers)
                    {
                       copy = new Supplier();//create new object

                       //add properties
                       copy.SupplierID = s.SupplierID;
                       copy.CompanyName = s.CompanyName;
                       copy.ContactName = s.ContactName;
                       copy.ContactTitle = s.ContactTitle;
                       copy.Address = s.Address;
                       copy.City = s.City;
                       copy.Region =s.Region; 
                       copy.PostalCode =  s.PostalCode;
                       copy.Country =  s.Country;
                       copy.Phone = s.Phone;

                       copySuppliers.Add(copy);//add to new list
                       suppliers = copySuppliers;

                    }

            }


            /// <summary>
            /// fetchShippers()
            /// Gets shipper records from database and returns a copy of it
            /// </summary>
            /// <returns>List of type Shipper</returns>
            public void loadShipperData()
            {
                    shippers = database.FetchShippers();  
                    List<Shipper> copyShippers = new List<Shipper>();
                    Shipper copy;

                    foreach (Shipper s in shippers)
                    {
                        copy = new Shipper();//create new object
                       
                        //add properties
                        copy.ShipperID = s.ShipperID;
                        copy.CompanyName = s.CompanyName;
                        copy.Phone = s.Phone;

                        copyShippers.Add(copy);//add to new list
                        shippers = copyShippers;
                    }

            }


            /// <summary>
            /// fetchProductByID
            /// Takes productID as parameter and returns a Product Object
            /// </summary>
            /// <param name="productId">of Type int</param>
            /// <returns>Product Object</returns>

            public Product fetchProductByID(int productId)
            {
                Product copy;
                foreach (Product product in products)
                {
                    if (product.ProductID == productId)
                    {
                        copy = new Product();//create new object
                        copy = product;
                        return copy;
                    }
                }
                return null;
            }


            /// <summary>
            /// fetchUnitsInStock()
            /// Takes a ProductID and returns the Units In Stock value for that product
            /// </summary>
            /// <param name="productId"> of Type int</param>
            /// <returns>int</returns>
            public int fetchUnitsInStock(int productId)
            {                
                Product p = fetchProductByID(productId);
                return p.UnitsInStock;

            }

            #endregion

              
        #region Add/Update Records
               
        /// <summary>
        /// addOrder()
        /// Takes an Order object and a list of Order Detail as parameters;
        /// Inserts the order into database, returns Order Id and adds it to each Order Detail object;
        /// Inserts all Order Details into Database;
        /// Updates Units In Stock in Products Table
        /// </summary>
        /// <param name="order"> Of Type Order</param>
        /// <param name="orderDetails"> of Type List<OrderDetail></param>
        public void addOrder(Order order, List<OrderDetail> orderDetails)
        {
            
            int newOrderId = database.InsertOrder(order);//AddOrder() adds Order record to database and returns its OrderID
            order.OrderID = newOrderId;//set the newOrderID in the Order Object

            foreach (OrderDetail od in orderDetails)
            {
                od.OrderID = newOrderId;//add newOrderID to each OrderDetail Object
                database.InsertOrderDetails(od);//add Order Detail records to Database
                database.RemoveUnitsFromStock(od.ProductID, od.Quantity);//Update the # of Units In Stock
            }

        }

        
        /// <summary>
        /// addProduct()
        /// Adds new record to Products Table
        /// </summary>
        /// <param name="_product">takes and object of type Product</param>
        public string addProduct(Product _product)
        {
            string confirmation = database.InsertProduct(_product);
            return confirmation;
  
        }


        /// <summary>
        /// updateProduct()
        /// Updates a record in Products Table
        /// </summary>
        /// <param name="_product">takes and object of type Product</param>
        public string updateProduct(Product _product)
        {
            string confirmation = database.UpdateProduct(_product);
            return confirmation;

        }


        /// <summary>
        /// addCategory()
        /// Adds new record to Categories Table
        /// </summary>
        /// <param name="_product">takes and object of type Category</param>
        public string addNewCategory(Category _category)
        {
            string confirmation = database.InsertCategory(_category);
            return confirmation;
        }


        /// <summary>
        /// updateCategory()
        /// Updates a record in Categories Table
        /// </summary>
        /// <param name="_product">takes and object of type Category</param>
        public string updateCategory(Category _category)
        {
            string confirmation = database.UpdateCategory(_category);
            return confirmation;
        }
        

        /// <summary>
        /// addCustomer()
        /// Adds new record to Customers Table
        /// </summary>
        /// <param name="_product">takes and object of type Customer</param>
        public string addCustomer(Customer _customer)
        {
            string confirmation = database.InsertCustomer(_customer);
            return confirmation;
        }
           
    
        /// <summary>
        /// updateCustomer()
        /// Updates a record in Customers Table
        /// </summary>
        /// <param name="_product">takes and object of type Customer</param>
        public string updateCustomer(Customer _customer)
        {
            string confirmation = database.UpdateCustomer(_customer);
            return confirmation;
        }
        

        /// <summary>
        /// addEmployee()
        /// Adds new record to Employees Table
        /// </summary>
        /// <param name="_product">takes and object of type Employee</param>
        public string addEmployee(Employee _employee)
        {
            string confirmation = database.InsertEmployee(_employee);
            return confirmation;
        }
        

        /// <summary>
        /// updateEmployee()
        /// Updates a record in Employees Table
        /// </summary>
        /// <param name="_product">takes and object of type Employee</param>
        public string updateEmployee(Employee _employee)
        {
            string confirmation = database.UpdateEmployee(_employee);
            return confirmation;

        }


        /// <summary>
        /// adSupplier()
        /// Adds new record to Suppliers Table
        /// </summary>
        /// <param name="_product">takes and object of type Supplier</param>
        public string addSupplier(Supplier _supplier)
        {
            string confirmation = database.InsertSupplier(_supplier);
            return confirmation;
        }


        /// <summary>
        /// updateProduct()
        /// Updates a record in Suppliers Table
        /// </summary>
        /// <param name="_product">takes and object of type Supplier</param>
        public string updateSupplier(Supplier _supplier)
        {
            string confirmation = database.UpdateSupplier(_supplier);
            return confirmation;
        }

        
        /// <summary>
        /// addShipper()
        /// Adds new record to Shippers Table
        /// </summary>
        /// <param name="_product">takes and object of type Shipper</param>
        public string addShipper(Shipper _shipper)
        {
            string confirmation = database.InsertShipper(_shipper);
            return confirmation;

        }


        /// <summary>
        /// updateShipper()
        /// Updates a record in Shippers Table
        /// </summary>
        /// <param name="_product">takes and object of type Shipper</param>
        public string updateShipper(Shipper _shipper)
        {
            string confirmation = database.UpdateShipper(_shipper);
            return confirmation;

        }

        #endregion


        #region Dispose method
        /// <summary>
        /// Dispose()
        /// unregisters event handlers - called in program.cs
        /// </summary>
        public void Dispose()
        {
            database.productAdded_Changed -= new TablesChanged(loadProductData);
            database.categoryAdded_Changed -= new TablesChanged(loadCategoryData);
            database.customerAdded_Changed -= new TablesChanged(loadCustomerData);
            database.employeeAdded_Changed -= new TablesChanged(loadEmployeeData);
            database.supplierAdded_Changed -= new TablesChanged(loadSupplierData);
            database.shipperAdded_Changed -= new TablesChanged(loadShipperData);

        }

        #endregion

    }
}
