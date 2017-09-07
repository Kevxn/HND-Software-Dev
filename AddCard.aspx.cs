using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCard : System.Web.UI.Page
{
    string paymentID; //should be null, primary key for payment in database

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerSession"] != null || Session["StaffSession"] != null) //redirects user if not logged in
        {
           if (Session["StaffSession"] != null)//shows manager home button only if a member of staff is using the system
            {
                lnkbtnHomepage.Visible = true;
            }
            else
            {
                //normal page load 
                lnkbtnHomepage.Visible = false;
            }
        }
        else
        {
            Response.Redirect("Homepage.aspx");//if customer or manager not logged in
        }
    }

    protected void btnAddCard_Click(object sender, EventArgs e) //adding card to customer account
    {
        string email = (string)Session["emailaddress"]; //if a normal customer is adding their card details
        string staffEnteredEmail = (string)Session["checkInAddCardEmail"];//if a staff member is adding customer card details

        if (staffEnteredEmail != null)
        {
            addCard(staffEnteredEmail);//adds the card on behalf of the customer
        }
        else
        {
            addCard(email);//adds the card for the customer
        }
        
    }
    public void addCard(string email) //code for adding the card
    {
        Card card = new Card();
        string cardNo = cardNumber.Value;
        string expiryDate = expiryDateMonth.Value + "/" + expiryDateYear.Value;
        string securityCode = cvCode.Value;
        //getting inputs
        if (cardNumber.Value == "" || expiryDateMonth.Value == "" || expiryDateYear.Value == "" || cvCode.Value == "") //checks none of the fields are empty
        {
            lblCardError.InnerText = "Make sure all of the fields are filled.";
        }
        else
        {
            //add the card to the database if the fields are not empty
            card.setCardNo(cardNo);
            card.setExpiryDate(expiryDate);
            card.setSecurityCode(securityCode);
            card.setCardType("tempcardtype");

            card.addCardByEmail(email, card);
            Session["card"] = card;
            DAL access = new DAL();
            access.saveCardToDb(paymentID, cardNo, expiryDate, securityCode, card.getCardType(), card.getBalance(), email);
            Response.Redirect("ViewAccount.aspx");
        }

        
  
    }

    protected void lnkbtnHomepage_Click(object sender, EventArgs e)//only visible if staff member is logged in
    {
        Response.Redirect("Manager.aspx");
    }
}