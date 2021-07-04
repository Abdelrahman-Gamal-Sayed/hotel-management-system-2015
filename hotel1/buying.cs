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
    public partial class buying : Form
    {
        public buying()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(bb.path);


        bb z = new bb(); 
       private void fill()
        {
            custno.DataSource = z.select("select comno,comname from comp");
            custno.DisplayMember = "comname";
            custno.ValueMember = "comno";
        }
       private void ggill()
       {
           itemno.DataSource = z.select("select itemno,itemnames from item");
           itemno.DisplayMember = "itemnames";
           itemno.ValueMember = "itemno";
       }
       /* private void setday()
        {
            string str = DateTime.Now.Date.DayOfWeek.ToString();
            if(str=="Saturday")
                daynon=0;
             if(str=="Sunday")
                 daynon=1;
 if(str=="Monday")
     daynon=2;
 if(str=="Tuesday")
     daynon=3;
             if(str=="Wednesday")
                 daynon=4;
             if (str == "Thursday")
                 daynon = 5;
             else

                 daynon = 6;
        }*/
          private void buying_Load(object sender, EventArgs e)
        {
            //fill();
            //ggill();
           // dayno.SelectedIndex = 0;
          //  setday();
           // autnum();
          
              
           

        }
           
        
           private void qty_ValueChanged(object sender, EventArgs e)
           {
           }

           private void price_ValueChanged(object sender, EventArgs e)
           {

           }

           private void label7_Click(object sender, EventArgs e)
           {

           }

           private void button1_Click(object sender, EventArgs e)
           {
               bb z = new bb();
               z.insert_update_delete("INSERT INTO buying VALUES(" + buyno.Text + ","+ custno.SelectedValue + ",'" + itemno.SelectedValue + "','" + qty.Value + "','" + price.Value + "')");
               MessageBox.Show("saved successfully");
               cleardata();
           }
           DataTable data = new DataTable();
           DataTable maro = new DataTable();
           private void amin(string s = "SELECT * FROM buying")
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
               //min("select buyno from buying order by buyno desc");
              amin("select max(buyno) from buying");
              if (data.Rows[0][0].ToString() == DBNull.Value.ToString())
                  buyno.Text = "1";
              else

               buyno.Text = (Convert.ToInt32(data.Rows[0][0].ToString()) + 1).ToString();
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
           private void cleardata()
           {

               autnum();
               update.Enabled = false;
               delete.Enabled = false;
               add.Enabled = true;
          
               custno.Enabled = true;
               itemno.Enabled = true;
           }
           private void empty_Click(object sender, EventArgs e)
           {
               cleardata();
           }

           private void update_Click(object sender, EventArgs e)
           {
               bb z = new bb();
               z.insert_update_delete("update buying set  qty='" + qty.Value + "',price='" + price.Value + "' where  buyno=" + buyno.Text + " and comno =" + custno.SelectedValue + " and itemno='" + itemno.SelectedValue + "'");
               MessageBox.Show("update successfully");
            cleardata();
           }

           private void delete_Click(object sender, EventArgs e)
           {
               bb z = new bb();
               z.insert_update_delete("delete from buying  where buyno=" + buyno.Text + " ");
               MessageBox.Show("delete successfully");
               cleardata();

           }

           private void timer1_Tick(object sender, EventArgs e)
           {
             
           }

           private void button3_Click(object sender, EventArgs e)
           {
               MessageBox.Show(DateTime.Now.Date.DayOfWeek.ToString());
           }

           private void d_Click(object sender, EventArgs e)
           {
               z.select("create view cc as  select buying.custno ,buying.itemno,itemname,buying.dayno,daynamee,custname,buydate,buying.qty,buying.price,buying.details from buying ,customer,item,dayno  where buying.custno=customer.custno  and buying.dayno=dayno.dayno and buying.itemno=item.itemno");
               MessageBox.Show("ujuijui");
           }

           private void button1_Click_1(object sender, EventArgs e)
           {
               string str = "         ";
               if (rbuyno.Checked == true)

                   str = "buyno";
               else if (compname.Checked == true)

                   str = "compname";
              
               else if (ritemname.Checked == true)

                   str = "itemnames";
              
               else if (rqty.Checked == true)

                   str = "qty";

               else if (rprice.Checked == true)

                   str = "price";

               if (str == null)
               {
                   MessageBox.Show("enter the items  choose(item number) or (item name)or (symbol)or (price) ");
                   return;
               }
               vsearch.DataSource = z.select("select  buyno,comname,sizeb,priceb,itemnames from comp ,item ,buying   where  buying.comno=comp.comno  and  buying.itemno=item.itemno and " + str + " like'%" + search.Text + "%'");
           }

           private void button2_Click(object sender, EventArgs e)
           {
               panel1.Visible = true;
               panel3.Visible = false;
           }

           private void button4_Click(object sender, EventArgs e)
           {
                panel1.Visible = false;
            panel3.Location = panel1.Location;
            panel3.Visible = true;
        }

           private void rbuyingdate_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void ritemname_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void rcustno_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void rcustname_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void ritemno_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void rqty_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void rprice_CheckedChanged(object sender, EventArgs e)
           {
           }

           private void g_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
           {
           }

           private void g_ValueChanged(object sender, EventArgs e)
           {

           }

           private void totall_TextChanged(object sender, EventArgs e)
           {

           }

           private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
           {

           }

           private void custno_SelectedIndexChanged(object sender, EventArgs e)
           {

           }

           private void itemno_SelectedIndexChanged(object sender, EventArgs e)
           {

           }
           private void calctotall()
           {
               totall.Text = (qty.Value * price.Value).ToString();
           }
           private void qty_ValueChanged_1(object sender, EventArgs e)
           {
               calctotall();

           }

           private void price_ValueChanged_1(object sender, EventArgs e)
           {
               calctotall();

           }

           private void button3_Click_1(object sender, EventArgs e)
           {
         
           }

           private void label3_Click(object sender, EventArgs e)
           {

           }
           }

    }
    

