namespace hotel1
{
    partial class buying
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buyno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.itemno = new System.Windows.Forms.ComboBox();
            this.custno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.custnot = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.empty = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.vsearch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ritemname = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rprice = new System.Windows.Forms.RadioButton();
            this.rqty = new System.Windows.Forms.RadioButton();
            this.compname = new System.Windows.Forms.RadioButton();
            this.rbuyno = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buyno);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.totall);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.itemno);
            this.panel1.Controls.Add(this.custno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.custnot);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.empty);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buyno
            // 
            this.buyno.Location = new System.Drawing.Point(253, 32);
            this.buyno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyno.Name = "buyno";
            this.buyno.Size = new System.Drawing.Size(259, 34);
            this.buyno.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 27);
            this.label8.TabIndex = 76;
            this.label8.Text = "buying number";
            // 
            // totall
            // 
            this.totall.Location = new System.Drawing.Point(488, 248);
            this.totall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totall.Name = "totall";
            this.totall.ReadOnly = true;
            this.totall.Size = new System.Drawing.Size(126, 34);
            this.totall.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 74;
            this.label1.Text = "total";
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(781, 142);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(230, 34);
            this.price.TabIndex = 73;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged_1);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(253, 149);
            this.qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(259, 34);
            this.qty.TabIndex = 72;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.ValueChanged += new System.EventHandler(this.qty_ValueChanged_1);
            // 
            // itemno
            // 
            this.itemno.FormattingEnabled = true;
            this.itemno.Location = new System.Drawing.Point(781, 29);
            this.itemno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemno.Name = "itemno";
            this.itemno.Size = new System.Drawing.Size(238, 35);
            this.itemno.TabIndex = 71;
            this.itemno.SelectedIndexChanged += new System.EventHandler(this.itemno_SelectedIndexChanged);
            // 
            // custno
            // 
            this.custno.FormattingEnabled = true;
            this.custno.Location = new System.Drawing.Point(253, 86);
            this.custno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custno.Name = "custno";
            this.custno.Size = new System.Drawing.Size(259, 35);
            this.custno.TabIndex = 70;
            this.custno.SelectedIndexChanged += new System.EventHandler(this.custno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 69;
            this.label3.Text = "price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 68;
            this.label4.Text = "qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 27);
            this.label11.TabIndex = 67;
            this.label11.Text = "item number";
            // 
            // custnot
            // 
            this.custnot.AutoSize = true;
            this.custnot.Location = new System.Drawing.Point(31, 89);
            this.custnot.Name = "custnot";
            this.custnot.Size = new System.Drawing.Size(136, 27);
            this.custnot.TabIndex = 66;
            this.custnot.Text = "comp name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 386);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 41);
            this.button4.TabIndex = 31;
            this.button4.Text = "search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empty
            // 
            this.empty.Location = new System.Drawing.Point(239, 386);
            this.empty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(108, 41);
            this.empty.TabIndex = 19;
            this.empty.Text = "empty";
            this.empty.UseVisualStyleBackColor = true;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(400, 386);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 41);
            this.delete.TabIndex = 18;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(564, 386);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 41);
            this.update.TabIndex = 17;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(744, 386);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 41);
            this.add.TabIndex = 16;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(26, 505);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 295);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vsearch
            // 
            this.vsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vsearch.Location = new System.Drawing.Point(5, 111);
            this.vsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vsearch.Name = "vsearch";
            this.vsearch.RowTemplate.Height = 26;
            this.vsearch.Size = new System.Drawing.Size(1305, 322);
            this.vsearch.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ritemname);
            this.groupBox1.Controls.Add(this.vsearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rprice);
            this.groupBox1.Controls.Add(this.rqty);
            this.groupBox1.Controls.Add(this.compname);
            this.groupBox1.Controls.Add(this.rbuyno);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1311, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search by";
            // 
            // ritemname
            // 
            this.ritemname.AutoSize = true;
            this.ritemname.Location = new System.Drawing.Point(453, 32);
            this.ritemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ritemname.Name = "ritemname";
            this.ritemname.Size = new System.Drawing.Size(158, 31);
            this.ritemname.TabIndex = 22;
            this.ritemname.TabStop = true;
            this.ritemname.Text = "item name";
            this.ritemname.UseVisualStyleBackColor = true;
            this.ritemname.CheckedChanged += new System.EventHandler(this.ritemname_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(141, 71);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(177, 36);
            this.search.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "search";
            // 
            // rprice
            // 
            this.rprice.AutoSize = true;
            this.rprice.Location = new System.Drawing.Point(925, 32);
            this.rprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rprice.Name = "rprice";
            this.rprice.Size = new System.Drawing.Size(89, 31);
            this.rprice.TabIndex = 4;
            this.rprice.TabStop = true;
            this.rprice.Text = "price";
            this.rprice.UseVisualStyleBackColor = true;
            this.rprice.CheckedChanged += new System.EventHandler(this.rprice_CheckedChanged);
            // 
            // rqty
            // 
            this.rqty.AutoSize = true;
            this.rqty.Location = new System.Drawing.Point(690, 32);
            this.rqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rqty.Name = "rqty";
            this.rqty.Size = new System.Drawing.Size(67, 31);
            this.rqty.TabIndex = 3;
            this.rqty.TabStop = true;
            this.rqty.Text = "qty";
            this.rqty.UseVisualStyleBackColor = true;
            this.rqty.CheckedChanged += new System.EventHandler(this.rqty_CheckedChanged);
            // 
            // compname
            // 
            this.compname.AutoSize = true;
            this.compname.Location = new System.Drawing.Point(223, 32);
            this.compname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compname.Name = "compname";
            this.compname.Size = new System.Drawing.Size(215, 31);
            this.compname.TabIndex = 1;
            this.compname.TabStop = true;
            this.compname.Text = "customer name";
            this.compname.UseVisualStyleBackColor = true;
            this.compname.CheckedChanged += new System.EventHandler(this.rcustname_CheckedChanged);
            // 
            // rbuyno
            // 
            this.rbuyno.AutoSize = true;
            this.rbuyno.Location = new System.Drawing.Point(5, 32);
            this.rbuyno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbuyno.Name = "rbuyno";
            this.rbuyno.Size = new System.Drawing.Size(222, 31);
            this.rbuyno.TabIndex = 0;
            this.rbuyno.TabStop = true;
            this.rbuyno.Text = "buying number ";
            this.rbuyno.UseVisualStyleBackColor = true;
            this.rbuyno.CheckedChanged += new System.EventHandler(this.rcustno_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "buying screen";
            // 
            // buying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1196, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "buying";
            this.Text = "1";
            this.Load += new System.EventHandler(this.buying_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button empty;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView vsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rprice;
        private System.Windows.Forms.RadioButton rqty;
        private System.Windows.Forms.RadioButton compname;
        private System.Windows.Forms.RadioButton rbuyno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton ritemname;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox buyno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.ComboBox itemno;
        private System.Windows.Forms.ComboBox custno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label custnot;
    }
}