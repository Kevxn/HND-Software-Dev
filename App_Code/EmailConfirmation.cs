using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmailConfirmation
/// </summary>
public class EmailConfirmation
{
    //variables
    string email;
    string confirmationCode;
    //getters
    public string getEmail() { return email; }
    public string getConfirmatioCode() { return confirmationCode; }
    //setters
    public void setEmail(string email) { this.email = email; }
    public void setConfirmationCode(string confirmationCode) { this.confirmationCode = confirmationCode; }
    //empty constructor, proabbaly wont use
    public EmailConfirmation()
    {
        email = "";
        confirmationCode = "";
    
    }
    //overloaded constructor
    public EmailConfirmation(string email, string confirmationCode)
    {
        this.email = email;
        this.confirmationCode = confirmationCode;
    }
}