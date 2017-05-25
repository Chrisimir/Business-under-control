// Chris Lund Schober

using System;
using System.Collections.Generic;
using System.Data;

namespace Business_under_control
{
    static class SupplierList
    {
        private static List<Supplier> supplierList;

        static SupplierList()
        {
            supplierList = new List<Supplier>();
        }

        // Returns length of SupplierList
        public static int GetLength()
        {
            return supplierList.Count;
        }

        // Adds Supplier to list
        public static void Add(DataTable supplierTable)
        {
            foreach (DataRow row in supplierTable.Rows)
            {
                Add(row);
            };
        }
        public static void Add(DataRow supplierRow)
        {
            Supplier newSupplier = new Supplier(supplierRow["name"].ToString(), Convert.ToInt32(supplierRow["shippingDays"]), supplierRow["telephone"].ToString());

            Add(newSupplier);
        }
        public static void Add(Supplier supplier)
        {
            supplierList.Add(supplier);
        }

        // Gets Supplier at indicated possition
        public static Supplier GetSupplierAt(int pos)
        {
            return supplierList[pos];
        }
    }
}
