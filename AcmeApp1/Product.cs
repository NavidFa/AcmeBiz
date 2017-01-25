using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeApp1
{/// <summary>
/// 
/// </summary>
    public class Product
    {
        private string productNamw;

        public string ProductName
        {
            get { return productNamw; }
            set { productNamw = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string SayHello()
        {
            return "Hello" + ProductName + "(" + ProductId + "):" + Description;
        }

    }
}
