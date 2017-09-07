using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Card
/// </summary>
public class Card
{
    string paymentID; //null, only used as primary key, generated in DAL class
    string cardNo;
    double balance;
    string cardType;
    string expiryDate;
    string securityCode;
    string email;
    Dictionary<string, Card> customerCards = new Dictionary<string, Card>();

    //getters
    public string getCardNo() { return cardNo; }
    public double getBalance() { return balance; }
    public string getCardType() { return cardType; }
    public string getExpiryDate() { return expiryDate; }
    public string getSecurityCode() { return securityCode; }
    public Dictionary<string, Card> getCard() { return customerCards; }

    //setters
    public void setCardNo(string cardNo) { this.cardNo = cardNo; }
    public void setBalance(double balance) { this.balance = balance; }
    public void setCardType(string cardType) { this.cardType = cardType; }
    public void setExpiryDate(string expiryDate) { this.expiryDate = expiryDate; }
    public void setSecurityCode(string securityCode) { this.securityCode = securityCode; }
    

    public Card() //empty constructor
    {
        paymentID = "";
        cardNo = "";
        balance = 1000;
        cardType = "";
        expiryDate = "";
        securityCode = "";
        email = "";
            
    }

    public Card(string paymentID, string cardNo, double balance, string cardType, string expiryDate, string securityCode, string email) //filled constructor
    {
        this.paymentID = paymentID;
        this.cardNo = cardNo;
        this.balance = balance;
        this.cardType = cardType;
        this.expiryDate = expiryDate;
        this.securityCode = securityCode;
        this.email = email;
    }

    public void addCardByEmail(string email, Card c) //unused??
    {
        if (!customerCards.ContainsKey(email))
        {
            customerCards.Add(email, c);
        }
        else
        {
            string ex = "There is already a card associated with that user";
        }
    }

}