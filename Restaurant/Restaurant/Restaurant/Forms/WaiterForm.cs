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
    public partial class WaiterForm : Form
    {
        int[] counter=new int[12];
        int waiterID;
        List<Button> Buttonlist = new List<Button>();
        public void getInfo(int id)
        {
            waiterID= id;
            
        }

        public WaiterForm()
        {
            InitializeComponent();
        }
        SqlConnection waiterconnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurants;Integrated Security=True");

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            // Initialize counter array
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0; // Reset counters for all menu items
            }

            // Initialize the button list with table buttons
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

            // Reset all button states to their default values
            foreach (var button in Buttonlist)
            {
                button.BackColor = Color.Green; // Default color for available tables
                button.Enabled = true;         // Enable all buttons
            }

            try
            {
                waiterconnection.Open();

                // Query to fetch tables with active or completed orders
                SqlCommand cmd1 = new SqlCommand("SELECT OrderTable, TableStatus, OrderStatus FROM Orders WHERE TableStatus = @p1", waiterconnection);
                cmd1.Parameters.AddWithValue("@p1", 1); // Use 1 for true (bit value for active tables)

                SqlDataReader dr1 = cmd1.ExecuteReader();

                // Update table button states based on the query result
                while (dr1.Read())
                {
                    foreach (var button in Buttonlist)
                    {
                        if (dr1["OrderTable"].ToString() == button.Text)
                        {
                            if (dr1["OrderStatus"].ToString() == "True")
                            {
                                button.BackColor = Color.Yellow; // Mark the table as completed (ready to be served)
                                button.Enabled = false;     // Enable the button for the waiter to serve
                            }
                            else if (dr1["OrderStatus"].ToString() == "False")
                            {
                                button.BackColor = Color.Red; // Mark the table as occupied (order in progress)
                                button.Enabled = false;      // Disable the button until order is ready
                            }
                        }
                    }
                }

                dr1.Close(); // Close the reader after use
            }
            catch (Exception ex)
            {
                // Handle errors that occur during the database connection or query execution
                MessageBox.Show("An error occurred while loading table data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed, even if an error occurs
                waiterconnection.Close();
            }
        }


        private void tableButtonClick(string buttonText)
        {
            LblChoosedTable.Text = buttonText;
            groupBox5.Visible = true;
        }

        private void BtnTable1_Click(object sender, EventArgs e)
        {
           tableButtonClick(BtnTable1.Text);

        }

        private void BtnTable2_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable2.Text);
        }

        private void BtnTable3_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable3.Text);
        }

        private void BtnTable4_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable4.Text);
        }

        private void BtnTable5_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable5.Text);
        }

        private void BtnTable6_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable6.Text);
        }

        private void BtnTable7_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable7.Text);
        }

        private void BtnTable8_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable8.Text);
        }

        private void BtnTable9_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable9.Text);
        }

        private void BtnTable10_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable10.Text);
        }

        private void BtnCola_Click(object sender, EventArgs e)//cola button
        {
            counter[0]++;
            LblColaCart.Text = "x" + counter[0];
            LblCartTotalValue.Text=(Convert.ToInt32(LblCartTotalValue.Text)+10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)//cart cola button
        {
            
            if (counter[0] > 0)//for not showing the negative numbers on number
            {
                counter[0]--;
                LblColaCart.Text = "x" + counter[0];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
           
            
        }

        private void BtnAyran_Click(object sender, EventArgs e)//ayran
        {
            counter[1]++;
            LblTraDaCart.Text = "x" + counter[1];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter[1] > 0)//for not showing the negative numbers on number
            {
                counter[1]--;
                LblTraDaCart.Text = "x" + counter[1];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 5).ToString();
            }
           
        }

        private void BtnGazoz_Click(object sender, EventArgs e)//gazoz
        {
            counter[2]++;
            LblChanhDayCart.Text = "x" + counter[2];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 10).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (counter[2] > 0)//for not showing the negative numbers on number
            {
                counter[2]--;
                LblChanhDayCart.Text = "x" + counter[2];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
            
        }

        private void BtnFanta_Click(object sender, EventArgs e)//fanta
        {
            counter[3]++;
            LblNuocCamCart.Text = "x" + counter[3];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 10).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counter[3] > 0)//for not showing the negative numbers on number
            {
                counter[3]--;
                LblNuocCamCart.Text = "x" + counter[3];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
            
        }

        private void BtnDoner_Click(object sender, EventArgs e)//doner
        {
            counter[4]++;
            LblPhoBoCart.Text = "x" + counter[4];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 60).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (counter[4] > 0)//for not showing the negative numbers on number
            {
                counter[4]--;
                LblPhoBoCart.Text = "x" + counter[4];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 60).ToString();
            }
            
        }

        private void BtnLahmacun_Click(object sender, EventArgs e)//lahmacun
        {
            counter[5]++;
            LblBanhXeoCart.Text = "x" + counter[5];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 60).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (counter[5] > 0)//for not showing the negative numbers on number
            {
                counter[5]--;
                LblBanhXeoCart.Text = "x" + counter[5];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 60).ToString();
            }
            
        }

        private void BtnHamburger_Click(object sender, EventArgs e)//hamburger
        {
            counter[6]++;
            LblBanhMiCart.Text = "x" + counter[6];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 40).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (counter[6] > 0)//for not showing the negative numbers on number
            {
                counter[6]--;
                LblBanhMiCart.Text = "x" + counter[6];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 40).ToString();
            }
            
        }


        private void BtnPizza_Click(object sender, EventArgs e)//pizza
        {
            counter[7]++;
            LblBunBoCart.Text = "x" + counter[7];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 70).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (counter[7] > 0)//for not showing the negative numbers on number
            {
                counter[7]--;
                LblBunBoCart.Text = "x" + counter[7];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 70).ToString();
            }
            
        }

        private void BtnBaklava_Click(object sender, EventArgs e)//baklava
        {
            counter[8]++;
            LblCheThapCamCart.Text = "x" + counter[8];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 30).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (counter[8] > 0)//for not showing the negative numbers on number
            {
                counter[8]--;
                LblCheThapCamCart.Text = "x" + counter[8];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 30).ToString();
            }
            
        }

        private void BtnTulumba_Click(object sender, EventArgs e)//tulumba
        {
            counter[9]++;
            LblBanhChuoiCart.Text = "x" + counter[9];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 25).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (counter[9] > 0)//for not showing the negative numbers on number
            {
                counter[9]--;
                LblBanhChuoiCart.Text = "x" + counter[9];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 25).ToString();
            }
            
        }

        private void BtnKunefe_Click(object sender, EventArgs e)//kunefe
        {
            counter[10]++;
            LblBanhKhoaiCart.Text = "x" + counter[10];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 30).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (counter[10] > 0)//for not showing the negative numbers on number
            {
                counter[10]--;
                LblBanhKhoaiCart.Text = "x" + counter[10];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 30).ToString();
            }
            
        }

        private void BtnCheesecake_Click(object sender, EventArgs e)//cheesecake
        {
            counter[11]++;
            LblBanhFlanCart.Text = "x" + counter[11];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 50).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (counter[11] > 0)//for not showing the negative numbers on number
            {
                counter[11]--;
                LblBanhFlanCart.Text = "x" + counter[11];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 50).ToString();
            }
            
        }
        //button




        private void BtnConfirmCart_Click(object sender, EventArgs e) // Confirm cart
        {
            // Create the order content summary
            string orderContents = LblColaMenu.Text + LblColaCart.Text + "\n" +
                LblTraDaMenu.Text + LblTraDaCart.Text + "\n" +
                LblChanhDayMenu.Text + LblChanhDayCart.Text + "\n" +
                LblNuocCamMenu.Text + LblNuocCamCart.Text + "\n" +
                LblPhoBoMenu.Text + LblPhoBoCart.Text + "\n" +
                LblBanhXeoMenu.Text + LblBanhXeoCart.Text + "\n" +
                LblBanhMiMenu.Text + LblBanhMiCart.Text + "\n" +
                LblBunBoMenu.Text + LblBunBoCart.Text + "\n" +
                LblCheThapCamMenu.Text + LblCheThapCamCart.Text + "\n" +
                LblBanhChuoiMenu.Text + LblBanhChuoiCart.Text + "\n" +
                LblBanhKhoaiMenu.Text + LblBanhKhoaiCart.Text + "\n" +
                LblBanhFlanMenu.Text + LblBanhFlanCart.Text;

            DateTime currentDateTime = DateTime.Now;

            try
            {
                waiterconnection.Open();

                // Insert the order into the database
                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO Orders (WaiterID, OrderAmount, OrderStatus, OrderTable, TableStatus, OrderContents, OrderDate) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)",
                    waiterconnection);
                cmd2.Parameters.AddWithValue("@p1", waiterID);
                cmd2.Parameters.AddWithValue("@p2", LblCartTotalValue.Text);
                cmd2.Parameters.AddWithValue("@p3", false); // Order status: not ready
                cmd2.Parameters.AddWithValue("@p4", LblChoosedTable.Text);
                cmd2.Parameters.AddWithValue("@p5", true); // Table status: occupied
                cmd2.Parameters.AddWithValue("@p6", orderContents);
                cmd2.Parameters.AddWithValue("@p7", currentDateTime);
                cmd2.ExecuteNonQuery();

                // Show confirmation message
                MessageBox.Show("Order placed successfully for Table " + LblChoosedTable.Text + ".\n\nOrder Summary:\n" + orderContents,
                    "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle potential errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                waiterconnection.Close();
            }

            // Update table button status
            foreach (var item in Buttonlist)
            {
                if (item.Text == LblChoosedTable.Text)
                {
                    item.BackColor = Color.Red;
                    item.Enabled = false;
                }
            }
        }

        private void LblColaMenu_Click(object sender, EventArgs e)
        {

        }

        private void GrpBoxMenu_Enter(object sender, EventArgs e)
        {

        }
    }


}
