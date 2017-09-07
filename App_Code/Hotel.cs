using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hotel
/// </summary>
public class Hotel
{
    Dictionary<string, Customer> customersFromDB = new Dictionary<string, Customer>();
    Dictionary<string, string> customerAccounts = new Dictionary<string, string>();
    Dictionary<string, Staff> staffFromDB = new Dictionary<string, Staff>();
    string hotelName;
    Customer cust = new Customer();
    public Dictionary<string, Customer> getCustomersFromDB() { return customersFromDB; }
    public void setCustomers(Dictionary<string, Customer> c) { customersFromDB = c; }
    public Dictionary<string, Staff> getStaffFromDB() { return staffFromDB; }


    public Hotel()
    {
        hotelName = "Drovers Lodge";
        customersFromDB = new Dictionary<string, Customer>();
        DAL dbAccess = new DAL();
        dbAccess.createCustomers();
        
        customerAccounts = new Dictionary<string, string>();
        customersFromDB = new Dictionary<string, Customer>();
        dbAccess.createStaff();
        staffFromDB = new Dictionary<string, Staff>();

        customersFromDB = dbAccess.getHotelCustomers();
        customerAccounts = dbAccess.getHotelAccounts();
        staffFromDB = dbAccess.getHotelStaff();
        
        //should read in data from database
                   
    //customersFromDB.Values.
       
    }


    public Hotel(string hotelName)
    {
        
    }



    public bool isValidCustomerLogin(string emailaddress, string password)
    {
        bool isValidLogin = false;
      //  DAL d = new DAL();
        
        
        foreach (KeyValuePair<string, Customer> currentCustomer in customersFromDB) //loads customers dictionary from database
        { 
            if (currentCustomer.Value.getEmail() == emailaddress && currentCustomer.Value.getPassword() == password) //checks if the values match
            {
                isValidLogin = true;//returns true if the user can login
            }
        }//else will return false
        return isValidLogin;

    }

    public bool isValidManagerLogin(string emailaddress, string pass)//same as the customer login except staff are loaded into a seperate dictionary
    {
        bool isValidManager = false;
        foreach (KeyValuePair<string, Staff> currentStaff in staffFromDB) //looping through the staff records
        {
            if (currentStaff.Value.getEmail() == emailaddress && currentStaff.Value.getPassword() == pass)//if the values match
            {
                isValidManager = true;
            }
        }
        return isValidManager;
    }

   

}