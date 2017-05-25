// Chris Lund Schober

using System.Collections.Generic;
using System.Collections;
using System;
using System.Data;

namespace Business_under_control
{
    /*
     * Statistics Functionlity - Contains the functions about statistics.
     */
    class StatisticsFunctionality
    {
        Database database;

        public StatisticsFunctionality()
        {
            database = new Database();
        }

        public Hashtable GetGraphData(int weeks)
        {
            Hashtable graphData = new Hashtable();
            string nowDateString = DateTime.Now.ToString("yyyy-MM-dd");
            string sinceDateString =
                DateTime.Now.AddDays(-7 * weeks).ToString("yyyy-MM-dd");

            // Stock data - We need this data to see what we have bought
            string stockQuery = @"select product, " +
                                    "orderNum, " +
                                    "quantity " +
                                    "from stock " +
                                    "where " +
                                    "moment >= '" + sinceDateString +
                                    "' and moment < '" + nowDateString + "';";
            //DataTable stockTable = CALL DB

            // TODO: Add values for each week
            // graphData.Add(MondayDate, string[] = {outcome, income}

            return graphData;
        }

        public DataTable GetSupplierTable(string supplier)
        {
            string subQryQuantityProds
                = @"(select count(*) from supplierProducts" +
                " where supplier = '" + supplier + "')";
            string subQryQuantityOrders =
                @"(select count(*) from orders where supplier = '" +
                supplier + "')";
            string suppDataQry =
                @"select name, telephone, shippingDays, " +
                subQryQuantityProds + " 'Amount of products', " +
                subQryQuantityOrders + " 'Times ordered' from suppliers " +
                "where name = '" + supplier + "';";

            DataTable suppTable = database.Fetch(suppDataQry);

            return suppTable;
        }

        // Gets supplier products and prices
        public DataTable GetSupplierSellPrice(string supplier)
        {
            string selectBuyPricesQry =
                @"select product, buyPrice from supplierProducts where supplier = '"
                + supplier + "';";

            DataTable priceTable = database.Fetch(selectBuyPricesQry);

            return priceTable;
        }

        // Get amount sold of products
        public List<string> GetAmountSoldEachProd()
        {
            List<string> soldData = new List<string>();
            int actualQuant;
            int bought;

            for (int prod = 0; prod < ProductList.GetLength(); prod++)
            {
                string prodName = ProductList.GetProductAt(prod).Name;

                try
                {
                    bought = Convert.ToInt32(database.Fetch(
                            @"select sum(quantity) as quantity from stock where product = '" +
                            prodName + "' and moment < now();").
                            Rows[0]["quantity"]);
                    actualQuant = Convert.ToInt32(
                    database.Fetch(@"select quantity from productInTime where name = '" +
                    prodName + "' and moment < now() order by moment desc limit 1")
                    .Rows[0]["quantity"]);
                }
                catch (Exception)
                {
                    bought = 0;
                    actualQuant = 0;
                }

                soldData.Add(prodName + " - Sold: " + (bought - actualQuant));
            }

            return soldData;
        }
    }
}
