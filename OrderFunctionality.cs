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
    class OrderFunctionality : DataFunction
    {
        // TODO: Complete functions
        OrderFunctionality(string name) : base(name)
        {
        }
        List<object> CompareSuppliers()
        {
            return new List<object>();
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
        public static void createSpreadsheet(/*TODO: List of products 
            & Supplier & Sheetname*/)
        {
            IWorkbook workB = new XSSFWorkbook();

            ISheet order = workB.CreateSheet("Order");
            order.CreateRow(0).CreateCell(0).SetCellValue("Establishment: " + Establishment.GetName());

            FileStream outFile = File.Create("Order" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx");

            workB.Write(outFile);
            outFile.Close();
        }

        // Creates txt file
        public static void createTextFile(string path, List<string> lines)
        {
            lines.Insert(0, Establishment.GetName());

            Utilities.SendLinesToTextFile(path + "Order" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", lines);
        }
    }
}