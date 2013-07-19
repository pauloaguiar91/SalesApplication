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

/// <summary>
/// Class based on Categories
/// from database C:\Northwind\Northwind\Northwind.mdb
/// </summary>
public class Category
{
   private Int32 categoryID;
   private String categoryName;
   private String description;
   private Image picture;

   public Category()
   {
       // no Body
   } // end no argument constructor


   public override string ToString()
   {
       return CategoryName;
   }
 
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

   public String CategoryName
   {
      get
      {
         return categoryName;
      }
      set
      {
         categoryName = value;
      }
   } //end of property CategoryName

   public String Description
   {
      get
      {
         return description;
      }
      set
      {
         description = value;
      }
   } //end of property Description

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
   } //end of property Picture
} // end of class

