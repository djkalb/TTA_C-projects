using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Start with a base of $50 / month.

//If the user is 18 and under, add $100 to the monthly total.

//If the user is between 19 and 25, add $50 to the monthly total.

//If the user is over 25, add $25 to the monthly total.

//If the car's year is before 2000, add $25 to the monthly total.

//If the car's year is after 2015, add $25 to the monthly total.

//If the car's Make is a Porsche, add $25 to the price.

//If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

//Add $10 to the monthly total for every speeding ticket the user has.

//If the user has ever had a DUI, add 25% to the total.

//If it's full coverage, add 50% to the total.
namespace CarInsurance.Models
{
    public partial class Insuree
    {
        
        public void CalculateQuote()
        {
            decimal quote = 50m;
            int age;
            // makes sure the age is correct accounts for 
            if((DateTime.Now.Month == this.DateOfBirth.Month && DateTime.Now.Day > 
                this.DateOfBirth.Day) || DateTime.Now.Month > this.DateOfBirth.Month)
            {
                age = DateTime.Now.Year - this.DateOfBirth.Year;
            }
            // if they were born in a later month than the current date they are not as old as their years would make them seem -- i think
            else { age = DateTime.Now.Year - this.DateOfBirth.Year - 1; }
            //adds to the quote based on user age
            if (age <= 18) { quote += 100; }
            else if (age <= 25) { quote += 50;  }
            else { quote += 25;  }
            // adds based on car year
            if (this.CarYear < 2000 || this.CarYear > 2015 ) { quote += 25;  }
            // if car is porsche
            if (this.CarMake.ToLower() == "porsche") { quote += 25; }
            if (this.CarMake.ToLower() == "porsche" && this.CarModel.ToLower() == "911 carrera") { quote += 25; }
            //speeding tickets
            quote += this.SpeeedingTickets * 10;
            // DUI
            if (this.DUI)  { quote = (quote * .25m) + quote; }
            if (this.CoverageType) { quote = (quote * 0.5m) + quote;  }

            // sets the quote to the value we just laboriously calculated
            this.Quote = quote;



        }
    }
}