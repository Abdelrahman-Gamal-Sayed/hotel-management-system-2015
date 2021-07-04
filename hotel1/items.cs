using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hotel1
{
    public partial class items : Form
    {
        public items()
        {

            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);


        DataTable data = new DataTable();
        DataTable maro = new DataTable();

        int introw = 0;
        private void add_Click(object sender, EventArgs e)
        {
            if (itemname.Text == "")
            {
                MessageBox.Show("enter the name ");
                return;
            }
            if (itemname.Text.Length > 15)
            {
                MessageBox.Show("release the words item name");
                return;
            }
            if (symbol.Text == "")
            {
                MessageBox.Show("enter the symbol ");
                return;
            }
            if (symbol.Text.Length > 20)
            {
                MessageBox.Show("release the words symbol");
                return;
            }
            if (price.Value ==0)
            {
                MessageBox.Show("enter the price ");
                return;
            }
            bb z = new bb();
            z.insert_update_delete("INSERT INTO item VALUES(" + itemno.Text + ",'" + itemname.Text + "','" + symbol.Text + "','" + price.Value + "','" + qty.Text + "','" + enddate.Text + "')");
            MessageBox.Show("saved successful");
            cleardata();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bb z = new bb();
            z.insert_update_delete("delete from item  where itemno=" + itemno.Text + " ");
            MessageBox.Show("delete successfully");

        }
        private void amin(string s = "SELECT * FROM item")
        {
            conn.Open();
            data.Clear();
            data.Columns.Clear();
            //SqlCommand maro = new SqlCommand();

            SqlDataAdapter com = new SqlDataAdapter(s, conn);
            com.Fill(data);
            // maro.Connection = conn;
            // maro.CommandText = "SELECT * FROM customer";
            //data.Load(maro.ExecuteReader());
            conn.Close();
        }
        private void ShowData()
        {

            itemno.Text = data.Rows[introw][0].ToString();
            itemname.Text = data.Rows[introw][1].ToString();
            symbol.Text = data.Rows[introw][2].ToString();
            price.Text = data.Rows[introw][3].ToString();
            maro.Clear();
            update.Enabled = true;
            delete.Enabled = true;
            add.Enabled = false;
         

        }
        private void autnum()
        {

            amin("select max(itemno) from item");
            if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
               itemno.Text = "1";
            else
            itemno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();
        }
        private void cleardata()
        {
            autnum();
        
            itemname.Clear();
            symbol.Clear();
            price.Value = 0;
            qty.Value = 0;
            enddate.Text = DateTime.Now.ToShortDateString();
                        symbol.Clear();
            update.Visible = false;
            delete.Visible = false;
            add.Visible = true;
            date.Visible = false;
                         }

        private void end_Click(object sender, EventArgs e)
        {
            
            try
            {
                amin();

                introw = data.Rows.Count - 1;

                ShowData();
            }
            catch(Exception ex)
            {

                MessageBox.Show("no records");
            }finally
            {
                conn.Close();
            }
        
        }

        private void previous_Click(object sender, EventArgs e)
        {
            
            if (introw == 0)
            {
                MessageBox.Show("the first record");
            }
            else
            {
                introw -= 1;
                ShowData();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            
            if (introw >= data.Rows.Count - 1)
            {
                MessageBox.Show("the end record");
            }
            else
            {
                introw += 1;
                ShowData();
            }
        }

        private void first_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void items_Load(object sender, EventArgs e)
        {
            ok.Visible = false;
            cu.Visible = false;
            ud.Visible = false;
           // autnum();
        }

        private void update_Click(object sender, EventArgs e)
        {

            bb z = new bb();
            z.insert_update_delete("update item set itemnames='" + itemname.Text + "',symbol='" + symbol.Text + "',price='" + price.Value + "',size='" + qty.Value + "',dateend='" + enddate.Text + "' where itemno=" + itemno.Text + "");
            MessageBox.Show("update successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "         ";
            if (ritemno.Checked == true)

                str = "itemno";
            else if (ritemname.Checked == true)

                str = "itemname";
            else if (rsymbol.Checked == true)

                str = "symbol";
            else if (rprice.Checked == true)

                str = "price";
           
            if (str == null)
            {
                MessageBox.Show("enter the items  choose(item number) or (item name)or (symbol)or (price) ");
                return;
            }
            amin("select * from item  where " + str + " like'%" + search.Text + "%'");
            vsearch.DataSource = data;
        }

        private void l_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Location = panel1.Location;
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }
        private void calctotal()
        {
            totall.Text = (qty.Value * price.Value).ToString();
        }
        private void price_ValueChanged(object sender, EventArgs e)
        {
            calctotal();

        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {
            calctotal();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            cu.Visible = true;
            ud.Visible = true;
            ok.Visible = true;
        }

        private void ok_Click(object sender, EventArgs e)
        {
             try
            {
                DataTable d = new DataTable();
                date.Visible=true;
                d.Clear();
                            SqlDataAdapter da = new SqlDataAdapter("select * from item where  itemno='" + ud.Text + "'", conn);
                da.Fill(d);
              itemname.Text = d.Rows[0][1].ToString();
                symbol.Text = d.Rows[0][2].ToString();
                 
                price.Text = d.Rows[0][3].ToString();
               qty.Text = d.Rows[0][4].ToString();
               date.Text = d.Rows[0][5].ToString();

              //  phoner.Text = d.Rows[0][5].ToString();
                conn.Close();
                  update.Visible = true;

                  enddate.Visible = false;
                delete.Visible = true;
                add.Visible = false;
                ud.Visible = false;
                cu.Visible = false;
                ok.Visible = false;

                panel1.Visible = true;
              //  em.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("number is error");
            }
            finally
            {
                conn.Close();
            }
            itemno.Text = ud.Text;
            }

        private void ud_MouseDown(object sender, MouseEventArgs e)
        {
            autnum();
            SqlDataAdapter com = new SqlDataAdapter("select itemno from item", conn);
            DataTable data = new DataTable();
            com.Fill(data);
            ud.DataSource = data;
            ud.DisplayMember = "itemno";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totall_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qty_ValueChanged_1(object sender, EventArgs e)
        {
            calctotal();

        }
        }
        }
    

