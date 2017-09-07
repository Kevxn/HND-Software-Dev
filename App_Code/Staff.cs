using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Staff
/// </summary>
public class Staff : Person
{
    //variables
    string staffID;
    string role;
    DateTime startDate;
    float salary;
    string sortCode;
    string accountNumber;
    

    //getters

    public string getStaffID()
    {
        return staffID;
    }

    public string getRole()
    {
        return role;
    }

    public DateTime getStartDate()
    {
        return startDate;
    }

    public float getSalary()
    {
        return salary;
    }
    public string getSortCode()
    {
        return sortCode;
    }
    public string getAccountNumber()
    {
        return accountNumber;
    }

    //end of getters 
    //setters

    public void setStaffID(string staffID)
    {
        this.staffID = staffID;
    }

    public void setRole(string role)
    {
        this.role = role;
    }

    public void setStartDate(DateTime startDate)
    {
        this.startDate = DateTime.Now; //possibly wrong
    }

    public void setSalary(float salary)
    {
        this.salary = salary;
    }
    public void setSortCode(string sortCode)
    {
        this.sortCode = sortCode;
    }
    public void setAccountNumber(string accountNumber)
    {
        this.accountNumber = accountNumber;
    }
    //end of setters

        //some of the values are not used in the object but are used in the databsase, i.e. customerID which is NOT used
    public Staff(/*not used*/string customerID, string staffID, string role, float salary,string sortCode, string accountNumber, DateTime startDate, string firstname, string surname, string telephoneNo, string mobileNo, string postcode, string email, string add1, string add2, string add3, string pass, /*not used*/DateTime joinDate)
       : base (customerID, firstname, surname, telephoneNo, mobileNo, postcode, email, add1, add2, add3, pass, joinDate)
       
    {
        this.staffID = staffID;
        this.role = role;
        this.salary = salary;
        this.startDate = startDate;
        this.sortCode = sortCode;
        this.accountNumber = accountNumber;
        
        
    }
    public Staff (string staffID, string role, string firstname, string surname, string email, string postcode, string addressLine1, string addressLine2, string addressLine3, string telephoneNo, string mobileNo, string password, string bankAccNo, string bankSortCode, float salary, DateTime startDate)
        : base(firstname, surname, email, postcode, addressLine1, addressLine2, addressLine3, telephoneNo, mobileNo, password)
    {
        //if logging in with ID make this.id = id and same woith pass
        this.staffID = staffID;
        this.role = role;
        this.salary = salary;
        this.startDate = startDate;
        this.sortCode = sortCode;
        this.accountNumber = accountNumber; 

    }
    private string generateStaffID() //generates a random ID and adds "S" for staff to the front 
    {
        string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder b = new StringBuilder();
        Random r = new Random();
        char ch;
        for (int i = 0; i < 9; i++)
        {
            ch = input[r.Next(0, input.Length)];
            b.Append(ch);
        }

        return "S" + b.ToString();
    }
}