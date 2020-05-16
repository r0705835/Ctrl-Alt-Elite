using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Database
    {





        public List<Store> stores;
        public Store store1;
        public Store store2;
        public Store store3;
        public Store store4;
        public Store store5;
        public Store store6;
        public Store store7;


        public List<Product> products;
        public Product product1;
        public Product product2;
        public Product product3;
        public Product product4;
        public Product product5;
        public Product product6;
        public Product product7;
        public Product product8;
        public Product product9;
        public Product product10;
        public Product product11;
        public Product product12;
        public Product product13;
        public Product product14;
        public Product product15;




        public Database()
        {
            stores = new List<Store>();

            store1 = new Store("Colruyt", "Graystraat 102, 1040 Brussel");
            store2 = new Store("Amazon", "Online Road 1, 1 Online");
            store3 = new Store("Walmart", "Walmart Supercenter #664 4301, Vine St");
            store4 = new Store("Spar", "Edingensesteenweg 196, 1500 Halle");
            store5 = new Store("Aldi", "Casterstraat 31A, 3500 Hasselt");
            store6 = new Store("H&M", "Diestsestraat 210, 3000 Leuven");

            stores.Add(store1);
            stores.Add(store2);
            stores.Add(store3);
            stores.Add(store4);
            stores.Add(store5);
            stores.Add(store6);




            products = new List<Product>();

            product1 = new Product(1,"Granny", 1);
            product2 = new Product(2, "Dove", 2);
            product3 = new Product(3, "Centwafel", 3);
            product4 = new Product(4, "Cola", 4);
            product5 = new Product(5, "7up", 5);
            product6 = new Product(6, "KitKat", 4);
            product7 = new Product(7, "Nescaffee", 3);
            product8 = new Product(8, "Lays", 2);
            product9 = new Product(9, "Oreo", 1);



            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);
            products.Add(product9);
 






        }













    }
}
