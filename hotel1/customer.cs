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
    public partial class customer : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);



        public customer()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();
        DataTable maro = new DataTable();
        bb z = new bb();
        int introw = 0;

        private void amin(string s = "SELECT * FROM customer")
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
            custno.Text = data.Rows[introw][0].ToString();
            custname.Text = data.Rows[introw][1].ToString();
            startdate.Text = data.Rows[introw][2].ToString();
            address.Text = data.Rows[introw][3].ToString();
            email.Text = data.Rows[introw][4].ToString();
            maro.Clear();
            conn.Open();
            // maro.Connection = conn;
            // maro.CommandText = "SELECT * FROM customer";

            //data.Load(maro.ExecuteReader());

            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (custname.Text == "")
            {
                MessageBox.Show("enter the name ");
                return;
            }
            if (custname.Text.Length > 15)
            {
                MessageBox.Show("release the words customer name");
                return;
            }

            if (address.Text.Length > 20)
            {
                MessageBox.Show("release the words address");
                return;
            }
            if (email.Text.Length > 20)
            {
                MessageBox.Show("release the words email");
                return;
            }

            bb z = new bb();
            z.insert_update_delete("INSERT INTO customer(custno,custname,startdate,address,email,phone)VALUES(" + custno.Text + ",'" + custname.Text + "','" + startdate.Text + "','" + address.Text + "','" + email.Text + "','" + phoner.Text + "')");



            MessageBox.Show("saved successful");
            cleardata();

        }
        private void autnum()
        {
            amin("select max(custno) from customer");
            if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
                custno.Text = "1";
            else
                custno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();

            


        }
        private void customer_Load(object sender, EventArgs e)
        {
            ok.Visible = false;
            cu.Visible = false;
            ud.Visible = false;
          //  autnum();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                introw = 0;
                amin();
                ShowData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no records");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                amin();

                introw = data.Rows.Count - 1;

                ShowData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no records");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button10_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
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
        private void cleardata()
        {
            autnum();
            custname.Clear();
            address.Clear();
            startdate.Text = DateTime.Now.ToShortDateString();
            email.Clear();
            update.Visible = false;
            delete.Visible = false;
            add.Visible = true;
            cu.Visible = false;
            ud.Visible = false;
            ok.Visible = false;
            phoner.Clear();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void update_Click(object sender, EventArgs e)
        {


            bb z = new bb();
            z.insert_update_delete("update customer set custname='" + custname.Text + "',startdate='" + startdate.Text + "',address='" + address.Text + "',email='" + email.Text + "',phone='" + phoner.Text + "'  where custno=" + custno.Text + "");



            MessageBox.Show("update successful");
            cleardata();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            bb z = new bb();

            z.insert_update_delete("delete from customer where custno=" + custno.Text + " ");
            MessageBox.Show("delete successful");
            cleardata();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = "         ";
            if (rcustno.Checked == true)

                str = "custno";
            else if (rstartdate.Checked == true)

                str = "startdate";
            else if (rcustname.Checked == true)

                str = "custname";
            else if (raddress.Checked == true)

                str = "address";
            else if (remail.Checked == true)
                str = "email";
            if (str == null)
            {
                MessageBox.Show("enter the items  choose(custumer number) or (customer name)or (address)or (startdate) or (email)");
                return;
            }
            amin("select * from customer where " + str + " like'%" + search.Text + "%'");
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

        private void search_MouseDown(object sender, MouseEventArgs e)
        {
           autnum();

            SqlDataAdapter com = new SqlDataAdapter("select custno from  customer", conn);
            DataTable data = new DataTable();
            com.Fill(data);
            ud.DataSource = data;
            ud.DisplayMember = "custno";

        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {





        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phonec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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
                d.Clear();
                            SqlDataAdapter da = new SqlDataAdapter("select * from customer where  custno='" + ud.Text + "'", conn);
                da.Fill(d);
               custname.Text = d.Rows[0][1].ToString();
                date.Text = d.Rows[0][2].ToString();
                address.Text = d.Rows[0][3].ToString();
               email.Text = d.Rows[0][4].ToString();
                phoner.Text = d.Rows[0][5].ToString();
                conn.Close();
                  update.Visible = true;
                  startdate.Visible = false;
                delete.Visible = true;
                add.Visible = false;
                ud.Visible = false;
                cu.Visible = false;
                ok.Visible = false;
                panel1.Visible = true;
                em.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("number is error");
            }
            finally
            {
                conn.Close();
            }
            custno.Text = ud.Text;
            }

        private void medicine_MouseDown(object sender, MouseEventArgs e)
        {
            autnum();
            SqlDataAdapter com = new SqlDataAdapter("select custno from customer", conn);
            DataTable data = new DataTable();
            com.Fill(data);
            ud.DataSource = data;
            ud.DisplayMember = "custno";
        }

        private void medicine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        }
    }



