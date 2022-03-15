using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsNew { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nun";
            Model = "nun";
            Price = 0.00M;
        }

        public Car(string a, string b,string d, bool e, decimal c)
        {
            this.Make = a;
            this.Model = b;
            this.Price = c;
            this.Color = d;
            this.IsNew = e;
            
        }

        public override string ToString()
        {
            return "Make: " + Make + " Model: " + Model + " Color: " + Color + " Is New: " + IsNew + " Price: $" + Price;
        }
    }
}
