// Chris Lund Schober

using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Business_under_control
{
    /*
     * Statistics Screen - The Statistics window.
     */
    public partial class StatisticsScreen : Form
    {
        StatisticsFunctionality statisticsFunctionality;

        public StatisticsScreen()
        {
            InitializeComponent();
            statisticsFunctionality = new StatisticsFunctionality();
        }

        private void CloseWindow(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void StatisticsScreen_Load(object sender, System.EventArgs e)
        {
            // Loads suppliers into dropdown
            for (int suppNum = 0; suppNum < SupplierList.GetLength(); suppNum++)
            {
                Supplier supplier = SupplierList.GetSupplierAt(suppNum);

                cbSupplier.Items.Add(supplier.Name);
            }

            // Loads the Products statistics
            foreach (string line in statisticsFunctionality.GetAmountSoldEachProd())
            {
                lbAmountSold.Items.Add(line);
            }

            /*/ Load graph with the last 3 weeks by default
            Hashtable graphData = statisticsFunctionality.GetGraphData(3);

            // Data arrays.
            string[] seriesArray = { "Outcome", "Income" };
            int[] pointsArray = { 5, 10, 7, 2, 1 };

            this.chrtIncomeOutcome.Series.Clear();

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chrtIncomeOutcome.Series.Add(seriesArray[i]);

                for (int j = 0; j < pointsArray.Length; j++)
                {
                    // Add point.
                    series.Points.Add(pointsArray[j]);
                }
            }*/
        }

        private void btnSeeSupplier_Click(object sender, System.EventArgs e)
        {
            if (cbSupplier.SelectedIndex != -1)
            {
                // Gives dgvSupplier the supplier data
                dgvSupplier.DataSource = 
                    statisticsFunctionality.GetSupplierTable(cbSupplier.Text);
                dgvSupplier.Visible = true;

                // Gives dgvProducts the products data
                dgvProductsSupp.DataSource =
                    statisticsFunctionality.GetSupplierSellPrice(cbSupplier.Text);
                dgvProductsSupp.Visible = true;
                lblProducts.Visible = true;
            }
            else
            {
                MessageBox.Show("Select a supplier");
            }
        }
    }
}
