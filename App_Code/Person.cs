using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
     string customerID;
     string firstname;
     string surname;
     string password;
     string telephoneNo;
     string mobileNo;
     string postcode;
     string email;
     string addressLine1;
     string addressLine2;
     string addressLine3;
     DateTime joinDate;
  
    


    //getters and setters
    public string getPassword()
    {
        return password;
    }

    public string getCustomerID()
    {
        return customerID;
    }

    public string getFirstname()
    {
        return firstname;
    }

     public string getSurname()
    {
        return surname;
    }
    public string getTelephoneNo()
    {
        return telephoneNo;
    }

    public string getMobileNo()
    {
        return mobileNo;
    }
    public string getPostcode()
    {
        return postcode;
    }

    public string getEmail()
    {
        return email;
    }
    public string getAddress1()
    {
        return addressLine1;
    }
    public string getAddress2()
    {
        return addressLine2;
    }
    public string getAddress3()
    {
        return addressLine3;
    }

    public DateTime getJoinDate()
    {
        return joinDate;
    }


    //end of getters
    //start of setters

    public void setPassword(string password)
    {

        this.password = password;
    }

    public void setFirstname(string firstname)
    {
        this.firstname = firstname;
    }

    public void setSurname(string surname)
    {
        this.surname = surname;
    }

    public void setTelephoneNo(string telephoneNo)
    {
        this.telephoneNo = telephoneNo;
    }

    public void setMobileNo(string mobileNo)
    {
        this.mobileNo = mobileNo;
    }   

    public void setPostcode(string postcode)
    {
        this.postcode = postcode;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public void setAddress1(string addressLine1)
    {
        this.addressLine1 = addressLine1;

    }
    public void setAddress2(string addressLine2)
    {
        this.addressLine2 = addressLine2;

    }
    public void setAddress3(string addressLine3)
    {
        this.addressLine3 = addressLine3;

    }

    public void setJoinDate(DateTime joinDate)
    {
        this.joinDate = joinDate;

    }
    public void setCustomerID()
    {

    }
    public void setCustomerID(string customerID)
    {
        this.customerID = generateCustomerID();

    }
    //end of setters
    private string generateCustomerID() //couldnt get this to work in customer class so use here, doesnt get used for staff
    {
        string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder b = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 9; i++)//looping through 10 times
        {
            ch = input[r.Next(0, input.Length)];
            b.Append(ch);//writes a random letter (from above) and adds to the random string
        }

        return "C" + b.ToString();
    }


    public Person() // empty constructor
    {
        customerID = getCustomerID();
        firstname = "";
        surname = "";
        telephoneNo = "";
        mobileNo = "";
        postcode = "";
        email = "";
        addressLine1 = "";
        addressLine2 = "";
        addressLine3 = "";
        password = "";
        joinDate = DateTime.Now;

    }

    // overloaded constructor
    public Person(string customerID, string firstname, string surname, string telephoneNo, string mobileNo, string postcode, string email, string addressLine1, string addressLine2, string addressLine3, string password, DateTime joinDate)
    {
        this.customerID = customerID;
        this.firstname = firstname;
        this.surname = surname;
        this.telephoneNo = telephoneNo;
        this.mobileNo = mobileNo;
        this.postcode = postcode;
        this.email = email;
        this.addressLine1 = addressLine1;
        this.addressLine2 = addressLine2;
        this.addressLine3 = addressLine3;
        this.password = password;
        this.joinDate = joinDate;

    }
    //second constructor
    public Person (string firstname, string surname, string email, string postcode, string addressLine1, string addressLine2, string addressLine3, string telephoneNo, string mobileNo, string password)
    {
        this.firstname = firstname;
        this.surname = surname;
        this.telephoneNo = telephoneNo;
        this.mobileNo = mobileNo;
        this.postcode = postcode;
        this.email = email;
        this.addressLine1 = addressLine1;
        this.addressLine2 = addressLine2;
        this.addressLine3 = addressLine3;
        this.password = password;
        
    }
   
}