// Chris Lund Schober
using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;

namespace Business_under_control
{
    /*
     * Order Functionality - Contains the functions regarding the orders.
     */
    class OrderFunctionality
    {
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
                "where name = '" + supplier + "';" ;

            Database database = new Database();
            DataTable suppTable = database.Fetch(suppDataQry);

            return suppTable;
        }

        // Gets data for order
        public List<string> GetProductsOfOrder(int id)
        {
            Database database = new Database();
            List<string> productLines = new List<string>();

            // Stock query
            string prodQuantQry =
                @"select product, quantity from stock where orderNum = " + id + ";";
            DataTable prodQuantTable = database.Fetch(prodQuantQry);

            foreach (DataRow row in prodQuantTable.Rows)
            {
                // SupplierProducts query
                string priceProdQry =
                @"select buyPrice from supplierProducts where product = '" +
                row["product"] + "' and supplier = (select supplier from orders " +
                "where id = " + id + ");";

                string price = database.Fetch(priceProdQry).Rows[0]["buyPrice"].ToString();

                productLines.Add(row["product"].ToString() + " - " + price + " x" +
                    row["quantity"].ToString());
            }

            return productLines;
        }

        // Gets supplier product seller price
        public DataTable GetSupplierSellPrice(string product)
        {
            string selectBuyPricesQry = @"select supplier 'Supplier', buyPrice 'Price' from supplierProducts where
            product = '" + product + "' order by buyPrice;";

            Database database = new Database();
            DataTable priceTable = database.Fetch(selectBuyPricesQry);

            return priceTable;
        }

        // Creates spreadsheet
        public static void createSpreadsheet(string path, List<string> lines)
        {
            try
            {
                IWorkbook workB = new XSSFWorkbook();

                ISheet order = workB.CreateSheet("Order");

                order.CreateRow(0).CreateCell(0).SetCellValue(
                    "Establishment: " + Establishment.GetName());

                foreach (string line in lines)
                {
                    order.CreateRow(order.LastRowNum + 1).CreateCell(0).
                        SetCellValue(line.Split('x')[0].Trim());
                    IRow lastRow = order.GetRow(order.LastRowNum);
                    lastRow.CreateCell(1).SetCellValue(line.Split('x')[1].Trim());
                }

                // Adds numbers at the end of the name if the file already exists
                FileStream outFile;
                if (!File.Exists(path))
                {
                    outFile =
                        File.Create(path +
                        "\\Order" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx");
                }
                else
                {
                    int extraName = 1;
                    while (File.Exists(path + extraName))
                    {
                        extraName++;
                    }
                    outFile =
                        File.Create(path +
                        "\\Order" + DateTime.Now.ToString("dd-MM-yyyy") + extraName + ".xlsx");
                }

                workB.Write(outFile);
                outFile.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Creates txt file
        public static void createTextFile(string path, List<string> lines)
        {
            lines.Insert(0, "------------------------------------------------------");
            lines.Insert(0, Establishment.GetMail());
            lines.Insert(0, Establishment.GetTelephone());
            lines.Insert(0, Establishment.GetWebsite());
            lines.Insert(0, Establishment.GetName());

            Utilities.SendLinesToTextFile(path + "\\Order" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", lines);
        }
    }
}