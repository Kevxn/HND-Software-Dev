using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         displayWeatherForecast();
         LinkButton1.Visible = false;
         Customer c = (Customer)Session["CustomerSession"];
        
        if (Session["CustomerSession"]!= null)
        { // gets customer object from the database and displays name on welcome button
            DAL access = new DAL();
            access.createCustomers();
            Dictionary<string, Customer> customers = access.getHotelCustomers();
            string email = (string)Session["emailaddress"];
            Session["CustomerSession"] = c;
         //   if (email != null)
          //  {
                c = customers[email];
                lnkbtnSignIn.InnerText = "Welcome, " + c.getFirstname() + ".";
                LinkButton1.Visible = true;
          //  }
           

           
        }
        else
        {
      
            LinkButton1.Visible = false; //disables lougout button in not logged in
        }
    }

    protected void lnkbtnSignIn_Click(object sender, EventArgs e)
    {
        if (Session["CustomerSession"]!=null)
        {
            Response.Redirect("ViewAccount.aspx");
        }
        Response.Redirect("Registration.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e) // log out button
    {
        //code to clear sessions and log customer out
        //customer cannot make a booking when logged out

        Session["CustomerSession"] = null;
        Session["BookingSession"] = null;
        Session["emailaddress"] = null;
        Response.Redirect("Homepage.aspx");
    }

    
    protected void btnBookSingleRoom_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["CustomerSession"] == null)
        {
            lblMustSignIn.Visible = true;//obsolete
            lblSignUpFree.Visible = true;//obsolete

            Response.Redirect("Registration.aspx");
            
        }else
        {
            string buttonChosen = "s";//determines what button the user clicked
            Session["buttonChosen"] = buttonChosen;
            Response.Redirect("Booking.aspx");

        }
    }

    protected void btnBookFamilyRoom_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["CustomerSession"] == null)
        {
            Response.Redirect("Registration.aspx");
        }
    else
        {
            string buttonChosen = "f";//determines what button the user clicked
            Session["buttonChosen"] = buttonChosen;
            Response.Redirect("Booking.aspx");
        }
       
    }

    protected void btnBookDoubleRoom_Click(object sender, ImageClickEventArgs e)
    {   
        if (Session["CustomerSession"] == null)
        {
            Response.Redirect("Registration.aspx");
        }
        else
        {
            string buttonChosen = "d";//determines what button the user clicked
            Session["buttonChosen"] = buttonChosen;
            Response.Redirect("Booking.aspx");
        }
       
    }

    public void displayWeatherForecast() //using openweathermap.org's API to get weather information at the location of the hotel (Dervaig, Isle of Mull)
    {
        string url = "http://api.openweathermap.org/data/2.5/weather?q=Dervaig&APPID=&units=metric"; //returns in JSON format with location dervaig and metric units

        string json = new WebClient().DownloadString(url); 

        dynamic stuff = JObject.Parse(json);

        string temp = stuff.main.temp;
        string name = stuff.name;
        string description = stuff.weather[0].description;
        long sunsetTime = stuff.sys.sunset;

        


        // string address = stuff.Address.City;

        lblWeather.Text = name;
        lblWeatherTemp.InnerText = "Temperature: " + temp + "°C";
        lblWeatherDescription.InnerText = "Description: " + description;
        lblWeatherSunsetTime.InnerText = "Sunset: " + FromUnixTime(sunsetTime); //sunset property in JSON is a UNIX timestamp, convert method below
        
    
    }

    public static DateTime FromUnixTime(long unixTime) //converts the UNIX timestamp to a readable datetime format
    {
        var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        return (epoch.AddSeconds(unixTime));
    }
}
