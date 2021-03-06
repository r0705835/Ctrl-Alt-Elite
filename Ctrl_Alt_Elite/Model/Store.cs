﻿using System.Collections.Generic;
using System.Linq;

namespace Model
{
    class Store
    {
        private string name;
        private string adress;
        private List<Product> products;
        private int rating;


        public Store(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
            this.products = new List<Product>();
            this.rating = 0;
        }



        public void add(Product product)
        {
            if (product == null) { throw new System.ArgumentException("Product is null"); }
            if (products.Contains(product)) { throw new System.ArgumentException("Product already exists"); }

            products.Add(product);
            this.updateRating();

        }


        public void remove(Product product)
        {
            if (product == null) { throw new System.ArgumentException("Product is null"); }
            if (!products.Contains(product)) { throw new System.ArgumentException("Product does not exist"); }

            products.Remove(product);
            this.updateRating();

        }

        public string getName() { return this.name; }

        public string getAdress() { return this.adress; }


        public int getRating() { return this.rating; }

        public List<Product> getProducts() { return this.products; }




        public int CompareTo(Store store)
        {
            if (store == null) { throw new System.ArgumentException("Store is null"); }

            return (this.getRating()).CompareTo(store.getRating());

        }


        public int calcRating(List<Product> products)
        {
            if (products == null) { throw new System.ArgumentException("Products is null"); }
            if (!products.Any()) { throw new System.ArgumentException("no products in list"); }
            int count = 0;
            int avg = 0;
            foreach (Product product in products)
            {
                avg += product.getRating();
                count++;
            }

            return avg / count;
        }

        public void updateRating()
        {
            this.rating = calcRating(products);
        }





























    }
}
