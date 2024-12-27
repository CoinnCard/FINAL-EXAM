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
    public partial class KitchenWorkerForm : Form
    {
        List<Button> Buttonlist = new List<Button>();
        public KitchenWorkerForm()
        {
            InitializeComponent();
        }
        SqlConnection kitchenWorkerConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurants;Integrated Security=True");
        private void KitchenWorkerForm_Load(object sender, EventArgs e)
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
                kitchenWorkerConnection.Open();

                // Fetch all active orders with table status = true
                SqlCommand cmd1 = new SqlCommand(@"SELECT OrderTable, OrderStatus 
                                           FROM Orders 
                                           WHERE TableStatus = @p1", kitchenWorkerConnection);
                cmd1.Parameters.AddWithValue("@p1", 1); // Use 1 for true (bit value)

                SqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {
                    foreach (var button in Buttonlist)
                    {
                        if (dr1["OrderTable"].ToString() == button.Text)
                        {
                            if (dr1["OrderStatus"].ToString() == "False")
                            {
                                button.BackColor = Color.Red; // Order is not ready
                                button.Enabled = true;
                            }
                            else if (dr1["OrderStatus"].ToString() == "True")
                            {
                                button.BackColor = Color.Yellow; // Order is ready
                                button.Enabled = false;
                            }
                        }
                    }
                }

                dr1.Close();
            }
            catch (Exception ex)
            {
                // Handle potential errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kitchenWorkerConnection.Close();
            }
        }



        private void buttonFunction(string buttonText)
        {
            LblTable.Text = buttonText;

            try
            {
                kitchenWorkerConnection.Open();
                SqlCommand cmd2 = new SqlCommand(@"SELECT TOP 1 OrderContents 
                                           FROM Orders 
                                           WHERE OrderTable = @p1 
                                           ORDER BY ID DESC", kitchenWorkerConnection);
                cmd2.Parameters.AddWithValue("@p1", buttonText);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    LblCart.Text = dr2[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kitchenWorkerConnection.Close();
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

        private void BtnOrderReady_Click(object sender, EventArgs e)
        {
            try
            {
                kitchenWorkerConnection.Open();

                // Update the OrderStatus in the database
                SqlCommand cmd3 = new SqlCommand("Update Orders Set OrderStatus=@p1 where OrderTable=@p2", kitchenWorkerConnection);
                cmd3.Parameters.AddWithValue("@p1", true);
                cmd3.Parameters.AddWithValue("@p2", LblTable.Text);
                cmd3.ExecuteNonQuery();

                kitchenWorkerConnection.Close();

                // Update the button color and disable it
                foreach (var item in Buttonlist)
                {
                    if (item.Text == LblTable.Text)
                    {
                        item.BackColor = Color.Yellow;
                        item.Enabled = false;
                    }
                }

                // Show confirmation message
                MessageBox.Show("The order for table " + LblTable.Text + " is ready.", "Order Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle potential errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
                if (kitchenWorkerConnection.State == ConnectionState.Open)
                {
                    kitchenWorkerConnection.Close();
                }
            }
        }

    }
}
