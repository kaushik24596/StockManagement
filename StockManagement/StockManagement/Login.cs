using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Copywrite_Enter(object sender, EventArgs e)
		{

		}


		private void clear_Click(object sender, EventArgs e)
		{
			textBox1.Text= "";
			textBox2.Clear();
			textBox1.Focus();
		}

		private void Login_Click(object sender, EventArgs e)
		{
			//Procedure for DBconeection
			SqlConnection con = new SqlConnection("Data Source = DESKTOP-0G0868J; Initial Catalog = Stock; Integrated Security = True");
			SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Login] where UserName='"+textBox1.Text+ "' and Password='"+textBox2.Text+"'", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows.Count == 1)
			{
				this.Hide(); //to hide loginForm
				StockMain main = new StockMain();
				main.Show();//shows Stocks form
			}
			else
			{
				MessageBox.Show("Invalid Username & Password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				clear_Click(sender, e); //to clear the feilds after pressing OK
			}


		}
	}
}
