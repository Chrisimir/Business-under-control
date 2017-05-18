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
        string documentsPath;
        OrderFunctionality orderFunctionality;

        public OrdersScreen()
        {
            InitializeComponent();
            documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            orderFunctionality = new OrderFunctionality();
        }

        private void OrdersScreen_Load(object sender, EventArgs e)
        {
            // TODO: Load old orders in dropdown
            // TODO: Load products in dropdown
        }

        // 1 - FACTURATION SECTION

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Adds the product to the list if the fields aren't empty
            if (!(cbNewOrders.Text != "" && tbQuantity.Text != ""))
            {
                MessageBox.Show("The fields cant be empty");
            }
            else
            {
                lstNewOrder.Items.Add(cbNewOrders.Text + "   x" + tbQuantity.Text);

                // Activates the remove from list functionality
                btnProductRemove.Enabled = true;
                btnClearAll.Enabled = true;
            }
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        // Returns the screen ListBox as a string list
        private List<string> GetListBoxList()
        {
            List<string> list = new List<string>();

            foreach (string item in lstNewOrder.Items)
            {
                list.Add(item);
            }

            return list;
        }

        private void SendFileCreatedMessage()
        {

            MessageBox.Show("Text file created in " + documentsPath);
        }

        private void btnNewOrderTextFile_Click(object sender, EventArgs e)
        {
            OrderFunctionality.createTextFile(documentsPath, GetListBoxList());

            SendFileCreatedMessage();
        }

        private void btnNewOrderDatasheet_Click(object sender, EventArgs e)
        {
            OrderFunctionality.createSpreadsheet(documentsPath, GetListBoxList());

            SendFileCreatedMessage();
        }

        private void btnProductRemove_Click(object sender, EventArgs e)
        {
            if (lstNewOrder.SelectedIndex != -1) // -1 is the default value of selectedIndex
            {
                lstNewOrder.Items.RemoveAt(lstNewOrder.SelectedIndex);

                if (lstNewOrder.Items.Count == 0)
                {
                    btnProductRemove.Enabled = false;
                    btnClearAll.Enabled = false;
                }
            }
            else
                MessageBox.Show("Choose the item to remove");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstNewOrder.Items.Clear();
            btnClearAll.Enabled = false;
            btnProductRemove.Enabled = false;
        }

        // 2 - COMPARE PROVIDERS SECTION

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (cbProvider1.Text != "" && cbProvider2.Text != "")
            {
                orderFunctionality.CompareSuppliers(cbProvider1.Text, cbProvider2.Text, this);
            }
            else
                MessageBox.Show("Choose providers");
        }
        public void ShowSupplierComparison()
        {

        }

        private void btnCompareProducts_Click(object sender, EventArgs e)
        {
            if (cbProducts.Text != "")
            {
                // TODO: Compare products by provider
            }
            else
                MessageBox.Show("Choose a product");
        }

        private void tabsOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
