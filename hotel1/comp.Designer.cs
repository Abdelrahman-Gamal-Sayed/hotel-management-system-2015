namespace hotel1
{
    partial class comp
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
            this.ud = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.vsearch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ritemname = new System.Windows.Forms.RadioButton();
            this.rprice = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rqty = new System.Windows.Forms.RadioButton();
            this.rcompphone = new System.Windows.Forms.RadioButton();
            this.rcomaddress = new System.Windows.Forms.RadioButton();
            this.rcomname = new System.Windows.Forms.RadioButton();
            this.rcustno = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comaddress = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.compphone = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.comname = new System.Windows.Forms.TextBox();
            this.comno = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.SuspendLayout();
            // 
            // ud
            // 
            this.ud.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ud.Location = new System.Drawing.Point(212, 26);
            this.ud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ud.Name = "ud";
            this.ud.Size = new System.Drawing.Size(268, 35);
            this.ud.TabIndex = 138;
            this.ud.Visible = false;
            this.ud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ud_MouseDown);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ok.Location = new System.Drawing.Point(495, 23);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(107, 38);
            this.ok.TabIndex = 137;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cu
            // 
            this.cu.AutoSize = true;
            this.cu.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.cu.Location = new System.Drawing.Point(50, 29);
            this.cu.Name = "cu";
            this.cu.Size = new System.Drawing.Size(157, 27);
            this.cu.TabIndex = 136;
            this.cu.Text = "comr number";
            this.cu.Visible = false;
            this.cu.Click += new System.EventHandler(this.cu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.vsearch);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(32, 402);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 274);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 2);
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
            this.groupBox1.Controls.Add(this.ritemname);
            this.groupBox1.Controls.Add(this.rprice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rqty);
            this.groupBox1.Controls.Add(this.rcompphone);
            this.groupBox1.Controls.Add(this.rcomaddress);
            this.groupBox1.Controls.Add(this.rcomname);
            this.groupBox1.Controls.Add(this.rcustno);
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
            this.ritemname.Location = new System.Drawing.Point(850, 36);
            this.ritemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ritemname.Name = "ritemname";
            this.ritemname.Size = new System.Drawing.Size(122, 32);
            this.ritemname.TabIndex = 22;
            this.ritemname.TabStop = true;
            this.ritemname.Text = "item name";
            this.ritemname.UseVisualStyleBackColor = true;
            // 
            // rprice
            // 
            this.rprice.AutoSize = true;
            this.rprice.Location = new System.Drawing.Point(760, 36);
            this.rprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rprice.Name = "rprice";
            this.rprice.Size = new System.Drawing.Size(73, 32);
            this.rprice.TabIndex = 21;
            this.rprice.TabStop = true;
            this.rprice.Text = "price";
            this.rprice.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(108, 72);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(183, 35);
            this.search.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "search";
            // 
            // rqty
            // 
            this.rqty.AutoSize = true;
            this.rqty.Location = new System.Drawing.Point(665, 36);
            this.rqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rqty.Name = "rqty";
            this.rqty.Size = new System.Drawing.Size(57, 32);
            this.rqty.TabIndex = 4;
            this.rqty.TabStop = true;
            this.rqty.Text = "qty";
            this.rqty.UseVisualStyleBackColor = true;
            // 
            // rcompphone
            // 
            this.rcompphone.AutoSize = true;
            this.rcompphone.Location = new System.Drawing.Point(517, 36);
            this.rcompphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcompphone.Name = "rcompphone";
            this.rcompphone.Size = new System.Drawing.Size(137, 32);
            this.rcompphone.TabIndex = 3;
            this.rcompphone.TabStop = true;
            this.rcompphone.Text = "comp phone";
            this.rcompphone.UseVisualStyleBackColor = true;
            // 
            // rcomaddress
            // 
            this.rcomaddress.AutoSize = true;
            this.rcomaddress.Location = new System.Drawing.Point(354, 36);
            this.rcomaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcomaddress.Name = "rcomaddress";
            this.rcomaddress.Size = new System.Drawing.Size(149, 32);
            this.rcomaddress.TabIndex = 2;
            this.rcomaddress.TabStop = true;
            this.rcomaddress.Text = "comp address";
            this.rcomaddress.UseVisualStyleBackColor = true;
            // 
            // rcomname
            // 
            this.rcomname.AutoSize = true;
            this.rcomname.Location = new System.Drawing.Point(184, 36);
            this.rcomname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcomname.Name = "rcomname";
            this.rcomname.Size = new System.Drawing.Size(131, 32);
            this.rcomname.TabIndex = 1;
            this.rcomname.TabStop = true;
            this.rcomname.Text = "comp name";
            this.rcomname.UseVisualStyleBackColor = true;
            // 
            // rcustno
            // 
            this.rcustno.AutoSize = true;
            this.rcustno.Location = new System.Drawing.Point(17, 36);
            this.rcustno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rcustno.Name = "rcustno";
            this.rcustno.Size = new System.Drawing.Size(151, 32);
            this.rcustno.TabIndex = 0;
            this.rcustno.TabStop = true;
            this.rcustno.Text = "comp number";
            this.rcustno.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "comp  screen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.qty);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comaddress);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.compphone);
            this.panel1.Controls.Add(this.itemname);
            this.panel1.Controls.Add(this.comname);
            this.panel1.Controls.Add(this.comno);
            this.panel1.Controls.Add(this.em);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(32, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 319);
            this.panel1.TabIndex = 134;
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(180, 156);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(191, 34);
            this.price.TabIndex = 37;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(634, 109);
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
            this.qty.Size = new System.Drawing.Size(190, 34);
            this.qty.TabIndex = 36;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.ValueChanged += new System.EventHandler(this.qty_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "qty";
            // 
            // comaddress
            // 
            this.comaddress.Location = new System.Drawing.Point(634, 12);
            this.comaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comaddress.Name = "comaddress";
            this.comaddress.Size = new System.Drawing.Size(190, 34);
            this.comaddress.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 71);
            this.button3.TabIndex = 26;
            this.button3.Text = "update and delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(75, 239);
            this.l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(99, 35);
            this.l.TabIndex = 24;
            this.l.Text = "search";
            this.l.UseVisualStyleBackColor = true;
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // compphone
            // 
            this.compphone.Location = new System.Drawing.Point(634, 63);
            this.compphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compphone.Name = "compphone";
            this.compphone.Size = new System.Drawing.Size(190, 34);
            this.compphone.TabIndex = 17;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(180, 109);
            this.itemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(191, 34);
            this.itemname.TabIndex = 16;
            // 
            // comname
            // 
            this.comname.Location = new System.Drawing.Point(180, 59);
            this.comname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comname.Name = "comname";
            this.comname.Size = new System.Drawing.Size(191, 34);
            this.comname.TabIndex = 15;
            // 
            // comno
            // 
            this.comno.Location = new System.Drawing.Point(180, 16);
            this.comno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comno.Name = "comno";
            this.comno.ReadOnly = true;
            this.comno.Size = new System.Drawing.Size(191, 34);
            this.comno.TabIndex = 12;
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(215, 240);
            this.em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(102, 35);
            this.em.TabIndex = 10;
            this.em.Text = "empty";
            this.em.UseVisualStyleBackColor = true;
            this.em.Click += new System.EventHandler(this.em_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(354, 240);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 35);
            this.delete.TabIndex = 9;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(492, 240);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 35);
            this.update.TabIndex = 8;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(634, 240);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 32);
            this.add.TabIndex = 7;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "item name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "comp  name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "comp number";
            // 
            // comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1117, 797);
            this.Controls.Add(this.ud);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "comp";
            this.Text = "comp";
            this.Load += new System.EventHandler(this.comp_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ud;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label cu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView vsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rqty;
        private System.Windows.Forms.RadioButton rcompphone;
        private System.Windows.Forms.RadioButton rcomaddress;
        private System.Windows.Forms.RadioButton rcomname;
        private System.Windows.Forms.RadioButton rcustno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox comaddress;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.TextBox compphone;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox comname;
        private System.Windows.Forms.TextBox comno;
        private System.Windows.Forms.Button em;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rprice;
        private System.Windows.Forms.RadioButton ritemname;

    }
}