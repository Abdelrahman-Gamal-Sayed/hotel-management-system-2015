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
    public partial class employee : Form
    {
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);


        public employee()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        DataTable maro = new DataTable();
        bb z = new bb();
        int introw = 0;
        private void amin(string s = "SELECT * FROM employee")
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
            empno.Text = data.Rows[introw][0].ToString();
            id.Text = data.Rows[introw][1].ToString();
            empname.Text = data.Rows[introw][2].ToString();
            address.Text = data.Rows[introw][3].ToString();
            job.Text = data.Rows[introw][4].ToString();
            salary.Text = data.Rows[introw][4].ToString();
            phoner.Text = data.Rows[introw][4].ToString();
            maro.Clear();
            conn.Open();
            // maro.Connection = conn;
            // maro.CommandText = "SELECT * FROM customer";

            //data.Load(maro.ExecuteReader());

            conn.Close();
        }
        private void autnum()
        {
            amin("select max(empno) from employee");
            if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
                empno.Text = "1";
            else
                empno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();




        }
        private void cleardata()
        {
            autnum();
            empname.Clear();
            address.Clear();
            job.Clear();
            salary.Clear();
            id.Clear();
            update.Visible = false;
            delete.Visible = false;
            add.Visible = true;
            cu.Visible = false;
            ud.Visible = false;
            ok.Visible = false;
            phoner.Clear();

        }
        private void employee_Load(object sender, EventArgs e)
        {
            ok.Visible = false;
            cu.Visible = false;
            ud.Visible = false;
           // autnum();
        }

        private void em_Click(object sender, EventArgs e)
        {
            cleardata();

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

        private void add_Click(object sender, EventArgs e)
        {
            if (empname.Text == "")
            {
                MessageBox.Show("enter the name ");
                return;
            }
          
          

            bb z = new bb();
            z.insert_update_delete("INSERT INTO employee(empno,id,empname,address,job,salary,phone)VALUES(" + empno.Text + ",'" + id.Text + "','" + empname.Text + "','" + address.Text + "','" + job.Text + "','" + salary.Text + "','" + phoner.Text + "')");



            MessageBox.Show("saved successful");
            cleardata();

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
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where  empno='" + ud.Text + "'", conn);
                da.Fill(d);
                id.Text = d.Rows[0][1].ToString();
                empname.Text = d.Rows[0][2].ToString();
                address.Text = d.Rows[0][3].ToString();
                job.Text = d.Rows[0][4].ToString();
                salary.Text = d.Rows[0][5].ToString();
                phoner.Text = d.Rows[0][6].ToString();

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
            empno.Text = ud.Text;
        }

        private void ud_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            autnum();
            SqlDataAdapter com = new SqlDataAdapter("select empno from employee", conn);
            DataTable data = new DataTable();
            com.Fill(data);
            ud.DataSource = data;
            ud.DisplayMember = "empno";
        }

        private void update_Click(object sender, EventArgs e)
        {

            bb z = new bb();
            z.insert_update_delete("update employee set empname='" + empname.Text + "',id='" + id.Text + "',address='" + address.Text + "',job='" + job.Text + "',salary='" + salary.Text + "',phone='" + phoner.Text + "'  where empno=" + empno.Text + "");
            MessageBox.Show("update successful");
            cleardata();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            bb z = new bb();
            z.insert_update_delete("delete from employee where empno=" + empno.Text + " ");

            MessageBox.Show("delete successful");
            cleardata();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = "         ";
            if (rempno.Checked == true)

                str = "empno";
            else if (rsalary.Checked == true)
                str = "salary";
            else if (rempname.Checked == true)

                str = "empname";
            else if (ridd.Checked == true)

                str = "id";
            else if (raddress.Checked == true)

                str = "job";
            else if (rjob.Checked == true)
                str = "job";
            else if (rphone.Checked == true)
                str = "phone";
            if (str == null)
            {
                MessageBox.Show("enter the items  choose(employee number) or (employee name)or (address)or (phone) or (salary)");
                return;
            }
            amin("select * from employee where " + str + " like'%" + search.Text + "%'");
            vsearch.DataSource = data;
        }
    }
}
