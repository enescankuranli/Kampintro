using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        internal static string ProductName;

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Productname { get; set; }
        public double Unitprice { get; set; }
        public int UnitsInStock { get; set; }

        internal class productName
        {
        }
    }
}
