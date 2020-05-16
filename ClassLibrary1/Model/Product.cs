using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Model
{
       class Product
    {
        public int ProduceID { get; set; }
        public string ProductName { get; set; }
        public int Rating { get; set; }


        public Product(int  produceid, string productname, int rating ) {
            this.ProduceID = produceid;
            this.ProductName = productname;
            this.Rating = rating;
        
        }


        public int getRating() { return this.Rating; }

        public int getProduceID() { return this.ProduceID; }

        public string getProductName() { return this.ProductName; }





    }

    [Serializable]
    class InvalidProductNameException : Exception
    {
        public InvalidProductNameException()
        {

        }

        public InvalidProductNameException(string name)
            : base(String.Format("Invalid Product Name: {0}", name))
        {

        }


    

    }
}
