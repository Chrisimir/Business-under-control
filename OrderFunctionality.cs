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
    }
}
