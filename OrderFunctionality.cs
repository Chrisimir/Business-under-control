// Chris Lund Schober
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace Business_under_control
{
    class OrderFunctionality
    {
        public OrderFunctionality()
        {
        }

        // TODO: Complete functions
        public void CompareSuppliers(
            string supplier1, string supplier2, OrdersScreen orderScreen)
        {
            // Get information of those suppliers

            orderScreen.ShowSupplierComparison();
        }
        List<object> EstimateFutureOrders()
        {
            return new List<object>();
        }
        List<object> SeeOrders()
        {
            return new List<object>();
        }
        string OrderToString()
        {
            return "";
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