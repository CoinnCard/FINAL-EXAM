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

namespace Restaurant
{
    public partial class CashierForm : Form
    {
        List<Button> Buttonlist = new List<Button>();
        public CashierForm()
        {
            InitializeComponent();
        }
        SqlConnection cashierConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurants;Integrated Security=True");

        private void CashierForm_Load(object sender, EventArgs e)
        {
            // Add all table buttons to the list
            Buttonlist.Add(BtnTable1);
            Buttonlist.Add(BtnTable2);
            Buttonlist.Add(BtnTable3);
            Buttonlist.Add(BtnTable4);
            Buttonlist.Add(BtnTable5);
            Buttonlist.Add(BtnTable6);
            Buttonlist.Add(BtnTable7);
            Buttonlist.Add(BtnTable8);
            Buttonlist.Add(BtnTable9);
            Buttonlist.Add(BtnTable10);

            try
            {
                cashierConnection.Open();

                // Fetch all orders where TableStatus is true
                SqlCommand cmd1 = new SqlCommand(@"SELECT DISTINCT OrderTable, OrderStatus 
                                           FROM Orders 
                                           WHERE TableStatus = @p1", cashierConnection);
                cmd1.Parameters.AddWithValue("@p1", true); // Use 1 for true (bit value)

                SqlDataReader dr1 = cmd1.ExecuteReader();

                // Update button states based on the result
                while (dr1.Read())
                {
                    foreach (var button in Buttonlist)
                    {
                        if (dr1["OrderTable"].ToString() == button.Text)
                        {
                            if (dr1["OrderStatus"].ToString() == "False")
                            {
                                button.BackColor = Color.Red; // Order not ready for payment
                                button.Enabled = false;
                            }
                            else if (dr1["OrderStatus"].ToString() == "True")
                            {
                                button.BackColor = Color.Yellow; // Order ready for payment
                                button.Enabled = true;
                            }
                        }
                    }
                }

                dr1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cashierConnection.Close();
            }
        }

        private void buttonFunction(string buttonText)
        {
            LblTable.Text = buttonText;
            try
            {
                cashierConnection.Open();

                // Fetch the most recent order for the selected table
                SqlCommand cmd2 = new SqlCommand(@"SELECT TOP 1 OrderContents, OrderAmount 
                                           FROM Orders 
                                           WHERE OrderTable = @p1 
                                           AND OrderStatus = 1 
                                           ORDER BY ID DESC", cashierConnection);
                cmd2.Parameters.AddWithValue("@p1", buttonText);

                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    LblCart.Text = dr2["OrderContents"].ToString();
                    LblTotal.Text = dr2["OrderAmount"].ToString();
                }

                dr2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cashierConnection.Close();
            }

            GrpBoxCartItems.Visible = true;
        }


        private void BtnTable1_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable1.Text);
        }

        private void BtnTable2_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable2.Text);

        }

        private void BtnTable3_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable3.Text);

        }

        private void BtnTable4_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable4.Text);

        }

        private void BtnTable5_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable5.Text);

        }

        private void BtnTable6_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable6.Text);

        }

        private void BtnTable7_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable7.Text);

        }

        private void BtnTable8_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable8.Text);

        }

        private void BtnTable9_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable9.Text);

        }

        private void BtnTable10_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable10.Text);

        }

        private void BtnOrderPaid_Click(object sender, EventArgs e)
        {
            try
            {
                cashierConnection.Open();
                SqlCommand cmd3 = new SqlCommand(@"UPDATE Orders 
                                               SET TableStatus = @p1 
                                               WHERE ID = (SELECT MAX(ID) 
                                                           FROM Orders 
                                                           WHERE OrderTable = @p2)", cashierConnection);
                cmd3.Parameters.AddWithValue("@p1", false);
                cmd3.Parameters.AddWithValue("@p2", LblTable.Text);
                cmd3.ExecuteNonQuery();

                foreach (var item in Buttonlist)
                {
                    if (item.Text == LblTable.Text)
                    {
                        item.BackColor = Color.LawnGreen;
                        item.Enabled = false;
                    }
                }

                MessageBox.Show("The order for table " + LblTable.Text + " has been marked as paid.", "Order Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cashierConnection.Close();
            }
        }
    }
}
