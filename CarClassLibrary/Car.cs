using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nun";
            Model = "nun";
            Price = 0.00M;
        }

        public Car(string a, string b, decimal c)
        {
            this.Make = a;
            this.Model = b;
            this.Price = c;
        }

    }
}
