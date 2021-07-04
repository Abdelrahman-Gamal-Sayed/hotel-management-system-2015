using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hotel1
{
    public partial class comp : Form
    {
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);


        public comp()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        DataTable maro = new DataTable();
        bb z = new bb();
        int introw = 0;

        private void add_Click(object sender, EventArgs e)
        {

            if (comname.Text == "")
            {
                MessageBox.Show("enter the name ");
                return;
            }
      

            bb z = new bb();
            z.insert_update_delete("INSERT INTO comp VALUES(" + comno.Text + ",'" + comname.Text + "','" + comaddress.Text + "','" + compphone.Text + "','" + itemname.Text + "','" + price.Value + "','" + qty.Text + "')");



            MessageBox.Show("saved successful");
            cleardata();
        }
        private void cleardata()
        {
            autnum();
            comname.Clear();
            comaddress.Clear();
            itemname.Clear();
            compphone.Clear();
            price.Value = 0;
            qty.Value = 1;

            update.Visible = false;
            delete.Visible = false;
            add.Visible = true;
            cu.Visible = false;
            ud.Visible = false;
            ok.Visible = false;

        }

        private void amin(string s = "SELECT * FROM comp")
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
        private void autnum()
        {
            amin("select max(comno) from comp");
            if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
                comno.Text = "1";
            else
                comno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();




        }
        private void comp_Load(object sender, EventArgs e)
        {
            ok.Visible = false;
            cu.Visible = false;
            ud.Visible = false;
         //   autnum();
        }

        private void em_Click(object sender, EventArgs e)
        {
            cleardata();

        }

        private void update_Click(object sender, EventArgs e)
        {

            bb z = new bb();
            z.insert_update_delete("update comp set comname='" + comname.Text + "',comaddress='" + comaddress.Text + "',compphone='" + compphone.Text + "',itemname='" + itemname.Text + "',price='" + price.Value + "',size='" + qty.Value + "'  where comno=" + comno.Text + "");



            MessageBox.Show("update successful");
            cleardata();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bb z = new bb();

            z.insert_update_delete("delete from comp where comno=" + comno.Text + " ");
            MessageBox.Show("delete successful");
            cleardata();
        }

        private void l_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Location = panel1.Location;
            panel3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "         ";
            if (rcustno.Checked == true)

                str = "comno";
            else if (rcomname.Checked == true)

                str = "comname";
            else if (rcomaddress.Checked == true)

                str = "comaddress";
            else if (rcompphone.Checked == true)

                str = "compphone";
            else if (rqty.Checked == true)
                str = "size";
            else if (rprice.Checked == true)
                str = "price";
            else if (ritemname.Checked == true)
                str = "itemname";
            if (str == null)
            {
                MessageBox.Show("enter the items  choose(comp number) or (comp  name)or (address)or (phone) or (qty) or(price) or (item name)");
                return;
            }
            amin("select * from comp where " + str + " like'%" + search.Text + "%'");
            vsearch.DataSource = data;
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
                SqlDataAdapter da = new SqlDataAdapter("select * from comp  where  comno='" + ud.Text + "'", conn);
                da.Fill(d);
                comname.Text = d.Rows[0][1].ToString();
                comaddress.Text = d.Rows[0][2].ToString();
                compphone.Text = d.Rows[0][3].ToString();
                itemname.Text = d.Rows[0][4].ToString();
                price.Text = d.Rows[0][5].ToString();
                qty.Text = d.Rows[0][5].ToString();

                conn.Close();
                update.Visible = true;
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
            comno.Text = ud.Text;
        }

        private void ud_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            autnum();
            SqlDataAdapter com = new SqlDataAdapter("select comno from comp", conn);
            DataTable data = new DataTable();
            com.Fill(data);
            ud.DataSource = data;
            ud.DisplayMember = "comno";
        }

        private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cu_Click(object sender, EventArgs e)
        {

        }
    }
}
