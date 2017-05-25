// Chris Lund Schober

using System;
using System.Collections.Generic;
using System.Data;

namespace Business_under_control
{
    /*
     * Product List - Contains the products.
     */
    static class ProductList
    {
        private static List<Product> productList;

        static ProductList()
        {
            productList = new List<Product>();
        }

        // Returns length of OrderList
        public static int GetLength()
        {
            return productList.Count;
        }

        // Adds Order to list
        public static void Add(DataTable productTable)
        {
            foreach (DataRow row in productTable.Rows)
            {
                Add(row);
            };
        }
        public static void Add(DataRow orderRow)
        {
            Product newProduct = new Product(orderRow["name"].ToString(), float.Parse(orderRow["salePrice"].ToString()));

            Add(newProduct);
        }
        public static void Add(Product product)
        {
            productList.Add(product);
        }

        // Gets order at indicated possition
        public static Product GetProductAt(int pos)
        {
            return productList[pos];
        }
    }
}
