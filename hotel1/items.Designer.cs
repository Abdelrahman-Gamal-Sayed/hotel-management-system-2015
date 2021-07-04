namespace hotel1
{
    partial class items
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
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.totall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.symbol = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.itemno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.vsearch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rprice = new System.Windows.Forms.RadioButton();
            this.rsymbol = new System.Windows.Forms.RadioButton();
            this.ritemname = new System.Windows.Forms.RadioButton();
            this.ritemno = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ud = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cu = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.totall);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.symbol);
            this.panel1.Controls.Add(this.itemname);
            this.panel1.Controls.Add(this.itemno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.panel1.Location = new System.Drawing.Point(53, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 305);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // qty
            // 
            this.qty.DecimalPlaces = 2;
            this.qty.Location = new System.Drawing.Point(695, 136);
            this.qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qty.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(248, 34);
            this.qty.TabIndex = 38;
            this.qty.ValueChanged += new System.EventHandler(this.qty_ValueChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 50);
            this.button3.TabIndex = 37;
            this.button3.Text = "update and delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totall
            // 
            this.totall.Location = new System.Drawing.Point(455, 174);
            this.totall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totall.Name = "totall";
            this.totall.ReadOnly = true;
            this.totall.Size = new System.Drawing.Size(126, 34);
            this.totall.TabIndex = 36;
            this.totall.TextChanged += new System.EventHandler(this.totall_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "total";
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(676, 93);
            this.enddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(268, 34);
            this.enddate.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "end date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "qty";
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(62, 229);
            this.l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(94, 40);
            this.l.TabIndex = 30;
            this.l.Text = "search";
            this.l.UseVisualStyleBackColor = true;
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 229);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "empty";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(296, 229);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 40);
            this.delete.TabIndex = 27;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(401, 229);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(103, 40);
            this.update.TabIndex = 26;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(517, 229);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 40);
            this.add.TabIndex = 25;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(200, 139);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(234, 34);
            this.price.TabIndex = 7;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged);
            // 
            // symbol
            // 
            this.symbol.Location = new System.Drawing.Point(695, 38);
            this.symbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(248, 34);
            this.symbol.TabIndex = 6;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(198, 93);
            this.itemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(236, 34);
            this.itemname.TabIndex = 5;
            // 
            // itemno
            // 
            this.itemno.Location = new System.Drawing.Point(198, 45);
            this.itemno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemno.Name = "itemno";
            this.itemno.ReadOnly = true;
            this.itemno.Size = new System.Drawing.Size(236, 34);
            this.itemno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "symbol";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "item name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "item number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.vsearch);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(53, 398);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 247);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 11);
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
            this.vsearch.Location = new System.Drawing.Point(21, 156);
            this.vsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vsearch.Name = "vsearch";
            this.vsearch.RowTemplate.Height = 26;
            this.vsearch.Size = new System.Drawing.Size(1305, 322);
            this.vsearch.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rprice);
            this.groupBox1.Controls.Add(this.rsymbol);
            this.groupBox1.Controls.Add(this.ritemname);
            this.groupBox1.Controls.Add(this.ritemno);
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1311, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search by";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(172, 76);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(209, 31);
            this.search.TabIndex = 19;
            this.search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.search_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "search";
            // 
            // rprice
            // 
            this.rprice.AutoSize = true;
            this.rprice.Location = new System.Drawing.Point(748, 36);
            this.rprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rprice.Name = "rprice";
            this.rprice.Size = new System.Drawing.Size(74, 27);
            this.rprice.TabIndex = 3;
            this.rprice.TabStop = true;
            this.rprice.Text = "price";
            this.rprice.UseVisualStyleBackColor = true;
            // 
            // rsymbol
            // 
            this.rsymbol.AutoSize = true;
            this.rsymbol.Location = new System.Drawing.Point(572, 36);
            this.rsymbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rsymbol.Name = "rsymbol";
            this.rsymbol.Size = new System.Drawing.Size(92, 27);
            this.rsymbol.TabIndex = 2;
            this.rsymbol.TabStop = true;
            this.rsymbol.Text = "symbol";
            this.rsymbol.UseVisualStyleBackColor = true;
            // 
            // ritemname
            // 
            this.ritemname.AutoSize = true;
            this.ritemname.Location = new System.Drawing.Point(362, 36);
            this.ritemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ritemname.Name = "ritemname";
            this.ritemname.Size = new System.Drawing.Size(124, 27);
            this.ritemname.TabIndex = 1;
            this.ritemname.TabStop = true;
            this.ritemname.Text = "item name";
            this.ritemname.UseVisualStyleBackColor = true;
            // 
            // ritemno
            // 
            this.ritemno.AutoSize = true;
            this.ritemno.Location = new System.Drawing.Point(75, 36);
            this.ritemno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ritemno.Name = "ritemno";
            this.ritemno.Size = new System.Drawing.Size(151, 27);
            this.ritemno.TabIndex = 0;
            this.ritemno.TabStop = true;
            this.ritemno.Text = "item  number";
            this.ritemno.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "item screen";
            // 
            // ud
            // 
            this.ud.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ud.Location = new System.Drawing.Point(184, 23);
            this.ud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ud.Name = "ud";
            this.ud.Size = new System.Drawing.Size(266, 35);
            this.ud.TabIndex = 136;
            this.ud.Visible = false;
            this.ud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ud_MouseDown);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ok.Location = new System.Drawing.Point(483, 22);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(107, 34);
            this.ok.TabIndex = 135;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cu
            // 
            this.cu.AutoSize = true;
            this.cu.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.cu.Location = new System.Drawing.Point(17, 31);
            this.cu.Name = "cu";
            this.cu.Size = new System.Drawing.Size(149, 27);
            this.cu.TabIndex = 134;
            this.cu.Text = "item number";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(695, 90);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 37);
            this.date.TabIndex = 39;
            this.date.Visible = false;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1107, 644);
            this.Controls.Add(this.ud);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "items";
            this.Text = "items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.items_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox itemno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.RadioButton rsymbol;
        private System.Windows.Forms.RadioButton ritemname;
        private System.Windows.Forms.RadioButton ritemno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.TextBox totall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ud;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label cu;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.TextBox date;
    }
}