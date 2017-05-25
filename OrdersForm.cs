// Chris Lund Schober

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * Order Screen - Order window.
     */
    public partial class OrdersForm : Form
    {
        string documentsPath;
        OrderFunctionality orderFunctionality;

        public OrdersForm()
        {
            InitializeComponent();
            documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            orderFunctionality = new OrderFunctionality();
        }

        private void OrdersScreen_Load(object sender, EventArgs e)
        {
            // Loads suppliers into dropdowns
            for (int suppNum = 0; suppNum < SupplierList.GetLength(); suppNum++)
            {
                Supplier supplier = SupplierList.GetSupplierAt(suppNum);

                cbProvider1.Items.Add(supplier.Name);
                cbProvider2.Items.Add(supplier.Name);
            }
            // Loads old orders into dropdowns
            for (int id = 0; id < OrderList.GetLength(); id++)
            {
                Order order = OrderList.GetOrderAt(id);

                // List orders Old Orders
                cbOldOrders.Items.Add(order.Date.Split(' ')[0] + " - " + order.Supplier);
            }

            // Loads products into dropdowns
            for (int productNum = 0; productNum < ProductList.GetLength(); productNum++)
            {
                Product product = ProductList.GetProductAt(productNum);

                // List orders New Order
                cbNewOrders.Items.Add(product.Name + " - " + product.SalePrice + "€");

                // Compare Providers Product
                cbProducts.Items.Add(product.Name);
            }
        }

        // 1 - BILLING SECTION

        private void btnOldOrderSee_Click(object sender, EventArgs e)
        {
            // Adds the order information to the list
            if (cbOldOrders.SelectedIndex != -1)
            {
                lstNewOrder.Items.Clear();

                foreach (string line 
                    in orderFunctionality.GetProductsOfOrder(cbOldOrders.SelectedIndex))
                {
                    lstNewOrder.Items.Add(line);
                }
                // Activates the remove from list functionality
                btnProductRemove.Enabled = true;
                btnClearAll.Enabled = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Adds the product to the list if the fields aren't empty
            if (!(cbNewOrders.Text != "" && nudQuantity.Text != ""))
            {
                MessageBox.Show("The fields can't be empty");
            }
            else
            {
                lstNewOrder.Items.Add(cbNewOrders.Text + "   x" + nudQuantity.Text);

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
            if (cbProvider1.Text != "" && cbProvider2.Text != "" &&
                cbProvider1.Text != cbProvider2.Text)
            {
                // Hides the product label
                lblProdName.Visible = false;

                // Adds data to the dataGridViews
                dgvSupp1.DataSource =
                    orderFunctionality.GetSupplierTable(cbProvider1.Text);
                dgvSupp2.DataSource =
                    orderFunctionality.GetSupplierTable(cbProvider2.Text);

                // Set the dataGridViees visible
                dgvSupp1.Visible = true;
                dgvSupp2.Visible = true;
            }
            else
                MessageBox.Show("Choose two different providers");
        }

        private void btnCompareProducts_Click(object sender, EventArgs e)
        {
            if (cbProducts.Text != "")
            {
                // Hides the other table in case it's showing
                dgvSupp2.Visible = false;

                // Gets prices of the product
                dgvSupp1.DataSource =
                    orderFunctionality.GetSupplierSellPrice(cbProducts.Text);
                dgvSupp1.Visible = true;

                lblProdName.Text = cbProducts.Text;
                lblProdName.Visible = true;
            }
            else
                MessageBox.Show("Choose a product");
        }
    }
}
