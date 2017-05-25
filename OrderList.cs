// Chris Lund Schober

using System.Collections.Generic;
using System.Data;

namespace Business_under_control
{
    static class OrderList
    {
        private static List<Order> orderList;

        static OrderList()
        {
            orderList = new List<Order>();
        }

        // Returns length of OrderList
        public static int GetLength()
        {
            return orderList.Count;
        }

        // Adds Order to list
        public static void Add(DataTable orderTable)
        {
            foreach (DataRow row in orderTable.Rows)
            {
                Add(row);
            };
        }
        public static void Add(DataRow orderRow)
        {
            Order newOrder = new Order(orderRow["id"].ToString(), orderRow["supplier"].ToString(), orderRow["moment"].ToString());

            Add(newOrder);
        }
        public static void Add(Order order)
        {
            orderList.Add(order);
        }

        // Gets order at indicated possition
        public static Order GetOrderAt(int pos)
        {
            return orderList[pos];
        }
    }
}
