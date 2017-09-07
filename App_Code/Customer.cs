using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer : Person
{

    //string customerID;
  //  string finalCustomerID; //test
    DateTime joinDate = DateTime.Now;
   // string password;
    Dictionary<string, string> accounts;


    public Dictionary<string, string> getAccounts() { return accounts; }
    public void setAccounts(Dictionary<string, string> customerAccounts) { accounts = customerAccounts; }
   

    public Customer()
    {
        //  customerID = getCustomerID();
        base.getCustomerID();
        base.getFirstname();
        base.getSurname();
        base.getTelephoneNo();
        base.getMobileNo();
        base.getEmail();
        base.getPostcode();
        base.getAddress1();
        base.getAddress2();
        base.getAddress3();
        base.getJoinDate();

        accounts = new Dictionary<string, string>();


    }

    public Customer(string customerID, DateTime joinDate, string password, string firstname, string surname, string telephoneNo, string mobileNo,string postcode, string email, string addressLine1, string addressLine2, string addressLine3)
        : base (customerID, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3, password, joinDate )      
    {
        accounts = new Dictionary<string, string>();
    }

    public Customer(string customerID, DateTime joinDate, string password, string firstname, string surname, string telephoneNo, string mobileNo, string postcode, string email, string addressLine1, string addressLine2, string addressLine3, Dictionary<string, Customer> accounts)
       : base(customerID, firstname, surname, telephoneNo, mobileNo, postcode, email, addressLine1, addressLine2, addressLine3, password, joinDate)
    {
      //  accounts = new Dictionary<string, string>();
    }


    public void addAccount(Customer c) 
    {
        if (!accounts.ContainsKey(c.getEmail()))
        {
            accounts.Add(c.getEmail(), c.getPassword()); //use this in the dal class??
        }
    }

   

    public bool checkPassword(string pass)//?
    {
        foreach (KeyValuePair<string, string> a in accounts)
        {
           
        ////    if (a.Value.get() == pass)
         //   {
                return true;
          //  } 
        }
        return false;
    }

}