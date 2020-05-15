using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
       class Products
    {
        public int ProduceID { get; set; }
        public string ProductName { get; set; }
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
