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
    public partial class selling : Form
    {
        public selling()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);

        DataTable maro = new DataTable();
        DataTable data= new DataTable();
        int introw = 0;
        bb z = new bb(); 

        private void fill()
        {
            custno.DataSource = z.select("select custno,custname from customer");
            custno.DisplayMember = "custname";
            custno.ValueMember = "custno";
        }
        private void gill()
        {
            itemno.DataSource = z.select("select itemno,itemnames from item");
            itemno.DisplayMember = "itemnames";
            itemno.ValueMember = "itemno";
        }
        int daynon;
       
        private void amin(string s = "SELECT * FROM selling")
        {
            conn.Open();
            data.Clear();
            data.Columns.Clear();

            SqlDataAdapter com = new SqlDataAdapter(s, conn);
            com.Fill(data);
          
            conn.Close();
        }
      
        private void autnum()
        {
            //min("select buyno from buying order by buyno desc");
            amin("select max(sellno) from selling");
            if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
               sellno.Text = "1";
            else

               sellno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();
        }
        private void selling_Load(object sender, EventArgs e)
        {
          //  fill();
           // gill();
            // dayno.SelectedIndex = 0;
          //  autnum();

          
        }
       
        private void qty_ValueChanged(object sender, EventArgs e)
        {
            totall.Text = (qty.Value * price.Value).ToString();
        }

        private void cleardata()
        {

            autnum();
          
            add.Enabled = true;
         
            custno.Enabled = true;
            itemno.Enabled = true;
        }
  
        private void add_Click(object sender, EventArgs e)
        {
           
            bb z = new bb();
            z.insert_update_delete("INSERT INTO selling  VALUES(" + sellno.Text + "," + custno.SelectedValue + ",'" + itemno.SelectedValue + "','" + qty.Value + "','" + price.Value + "')");
            MessageBox.Show("saved successfully");
            cleardata();
   
    }

        

        private void update_Click(object sender, EventArgs e)
        {
            
         
            bb z = new bb();
            z.insert_update_delete("update selling set sizes='" + qty.Value + "',prices='" + price.Value + "' where  sellno=" +sellno.Text + " and custno =" + custno.SelectedValue + " and itemno='" + itemno.SelectedValue + "'");
            MessageBox.Show("update successfully");
            cleardata();
          
          
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bb z = new bb();
            z.insert_update_delete("delete from  selling  where sellno=" + sellno.Text + " and custno =" + custno.SelectedValue + " and itemno='" + itemno.SelectedValue + "' ");
            MessageBox.Show("delete successfully");
            cleardata();
        }

        private void empty_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void end_Click(object sender, EventArgs e)
        {
           
        }

        private void previous_Click(object sender, EventArgs e)
        {
           
        }

        private void next_Click(object sender, EventArgs e)
        {
           
        }

        private void first_Click(object sender, EventArgs e)
        {
           
        }

        private void price_ValueChanged(object sender, EventArgs e)
        {
            totall.Text = (qty.Value * price.Value).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Location = panel1.Location;
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "         ";
         
           if (rcustname.Checked == true)

                str = "custname";
          
            else if (ritemname.Checked == true)

                str = "itemname";
         
            else if (rqty.Checked == true)

                str = "sizes";

            else if (rprice.Checked == true)

                str = "prices";
           else if (rsellno.Checked == true)

                str = "sellno";

            if (str == null)
            {
                MessageBox.Show("enter the items  choose(item number) or (item name)or (symbol)or (price) ");
                return;
            }
            vsearch.DataSource = z.select(" select sellno,custname,sizes,prices,itemnames  from customer , selling ,item   where   selling.custno=customer.custno  and  selling.itemno=item.itemno and " + str + " like'%" + search.Text + "%'");
        }

        private void d_Click(object sender, EventArgs e)
        {
            z.select("create view ccc as  select selling.custno ,selling.itemno,itemname,selling.dayno,daynamee,custname,selling.saldate,selling.qty,selling.price,selling.details from selling ,customer,item,dayno  where selling.custno=customer.custno  and selling.dayno=dayno.dayno and selling.itemno=item.itemno");
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }
    }
}
