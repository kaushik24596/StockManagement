using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
	public partial class StockMain : Form
	{
		public StockMain()
		{
			InitializeComponent();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Products products = new Products();
			products.MdiParent = this;//to show product form inside stock form 
			products.Show();

		}
	}
}
