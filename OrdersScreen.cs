using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_under_control
{
    public partial class OrdersScreen : Form
    {
        public OrdersScreen()
        {
            InitializeComponent();
        }

        private void btnNewOrderDatasheet_Click(object sender, EventArgs e)
        {
            OrderFunctionality.createSpreadsheet();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!(cbNewOrders.Text != "" && tbQuantity.Text != ""))
            {
                MessageBox.Show("The fields cant be empty");
            }
            else
            {
                lstNewOrder.Items.Add(cbNewOrders.Text + "   x" + tbQuantity.Text);
            }
        }

        private void btnExitOrders_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersEstimates_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCompare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewOrderTextFile_Click(object sender, EventArgs e)
        {
            List<string> newOrderList = new List<string>();

            foreach (string item in lstNewOrder.Items)
            {
                newOrderList.Add(item);
            }
            OrderFunctionality.createTextFile("", newOrderList);
        }
    }
}
