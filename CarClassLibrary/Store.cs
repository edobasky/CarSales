using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal CheckOut()
        {
            decimal TotalCost = 0;

            foreach(var item in ShoppingList)
            {
                TotalCost += item.Price;
            }

            ShoppingList.Clear();
            return TotalCost;
        }
    }
}
