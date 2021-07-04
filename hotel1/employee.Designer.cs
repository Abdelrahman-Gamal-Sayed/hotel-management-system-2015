namespace hotel1
{
    partial class employee
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
            this.cu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.vsearch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rphone = new System.Windows.Forms.RadioButton();
            this.rsalary = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rjob = new System.Windows.Forms.RadioButton();
            this.raddress = new System.Windows.Forms.RadioButton();
            this.rempname = new System.Windows.Forms.RadioButton();
            this.ridd = new System.Windows.Forms.RadioButton();
            this.rempno = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.phoner = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.empno = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ud
            // 
            this.ud.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ud.Location = new System.Drawing.Point(259, 20);
            this.ud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ud.Name = "ud";
            this.ud.Size = new System.Drawing.Size(262, 35);
            this.ud.TabIndex = 137;
            this.ud.Visible = false;
            this.ud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ud_MouseDown);
            // 
            // cu
            // 
            this.cu.AutoSize = true;
            this.cu.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.cu.Location = new System.Drawing.Point(54, 26);
            this.cu.Name = "cu";
            this.cu.Size = new System.Drawing.Size(202, 27);
            this.cu.TabIndex = 136;
            this.cu.Text = "customer number";
            this.cu.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.vsearch);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.panel3.Location = new System.Drawing.Point(12, 363);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 390);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
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
            this.groupBox1.Controls.Add(this.rphone);
            this.groupBox1.Controls.Add(this.rsalary);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rjob);
            this.groupBox1.Controls.Add(this.raddress);
            this.groupBox1.Controls.Add(this.rempname);
            this.groupBox1.Controls.Add(this.ridd);
            this.groupBox1.Controls.Add(this.rempno);
            this.groupBox1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1311, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search by";
            // 
            // rphone
            // 
            this.rphone.AutoSize = true;
            this.rphone.Location = new System.Drawing.Point(882, 36);
            this.rphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rphone.Name = "rphone";
            this.rphone.Size = new System.Drawing.Size(84, 27);
            this.rphone.TabIndex = 22;
            this.rphone.TabStop = true;
            this.rphone.Text = "phone";
            this.rphone.UseVisualStyleBackColor = true;
            // 
            // rsalary
            // 
            this.rsalary.AutoSize = true;
            this.rsalary.Location = new System.Drawing.Point(760, 36);
            this.rsalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rsalary.Name = "rsalary";
            this.rsalary.Size = new System.Drawing.Size(84, 27);
            this.rsalary.TabIndex = 21;
            this.rsalary.TabStop = true;
            this.rsalary.Text = "salary";
            this.rsalary.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(126, 76);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(194, 31);
            this.search.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "search";
            // 
            // rjob
            // 
            this.rjob.AutoSize = true;
            this.rjob.Location = new System.Drawing.Point(660, 36);
            this.rjob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjob.Name = "rjob";
            this.rjob.Size = new System.Drawing.Size(56, 27);
            this.rjob.TabIndex = 4;
            this.rjob.TabStop = true;
            this.rjob.Text = "job";
            this.rjob.UseVisualStyleBackColor = true;
            // 
            // raddress
            // 
            this.raddress.AutoSize = true;
            this.raddress.Location = new System.Drawing.Point(520, 36);
            this.raddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.raddress.Name = "raddress";
            this.raddress.Size = new System.Drawing.Size(100, 27);
            this.raddress.TabIndex = 3;
            this.raddress.TabStop = true;
            this.raddress.Text = "address";
            this.raddress.UseVisualStyleBackColor = true;
            // 
            // rempname
            // 
            this.rempname.AutoSize = true;
            this.rempname.Location = new System.Drawing.Point(320, 36);
            this.rempname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rempname.Name = "rempname";
            this.rempname.Size = new System.Drawing.Size(168, 27);
            this.rempname.TabIndex = 2;
            this.rempname.TabStop = true;
            this.rempname.Text = "employee name";
            this.rempname.UseVisualStyleBackColor = true;
            // 
            // ridd
            // 
            this.ridd.AutoSize = true;
            this.ridd.Location = new System.Drawing.Point(231, 36);
            this.ridd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ridd.Name = "ridd";
            this.ridd.Size = new System.Drawing.Size(45, 27);
            this.ridd.TabIndex = 1;
            this.ridd.TabStop = true;
            this.ridd.Text = "id";
            this.ridd.UseVisualStyleBackColor = true;
            // 
            // rempno
            // 
            this.rempno.AutoSize = true;
            this.rempno.Location = new System.Drawing.Point(30, 36);
            this.rempno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rempno.Name = "rempno";
            this.rempno.Size = new System.Drawing.Size(195, 27);
            this.rempno.TabIndex = 0;
            this.rempno.TabStop = true;
            this.rempno.Text = "employee number ";
            this.rempno.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "customer screen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.phoner);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.job);
            this.panel1.Controls.Add(this.empname);
            this.panel1.Controls.Add(this.empno);
            this.panel1.Controls.Add(this.em);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 262);
            this.panel1.TabIndex = 134;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(228, 52);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(231, 34);
            this.id.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "id number";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(676, 98);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(221, 34);
            this.salary.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "salary";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 71);
            this.button3.TabIndex = 26;
            this.button3.Text = "update and delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // phoner
            // 
            this.phoner.Location = new System.Drawing.Point(228, 131);
            this.phoner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoner.Name = "phoner";
            this.phoner.Size = new System.Drawing.Size(231, 34);
            this.phoner.TabIndex = 25;
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(16, 188);
            this.l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(111, 34);
            this.l.TabIndex = 24;
            this.l.Text = "search";
            this.l.UseVisualStyleBackColor = true;
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(676, 60);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(221, 34);
            this.address.TabIndex = 17;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(228, 91);
            this.job.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(231, 34);
            this.job.TabIndex = 16;
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(676, 22);
            this.empname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(221, 34);
            this.empname.TabIndex = 15;
            // 
            // empno
            // 
            this.empno.Location = new System.Drawing.Point(228, 15);
            this.empno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empno.Name = "empno";
            this.empno.ReadOnly = true;
            this.empno.Size = new System.Drawing.Size(231, 34);
            this.empno.TabIndex = 12;
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(133, 188);
            this.em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(95, 34);
            this.em.TabIndex = 10;
            this.em.Text = "empty";
            this.em.UseVisualStyleBackColor = true;
            this.em.Click += new System.EventHandler(this.em_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(236, 188);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 34);
            this.delete.TabIndex = 9;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(336, 188);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 34);
            this.update.TabIndex = 8;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(448, 188);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 34);
            this.add.TabIndex = 7;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "employee name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "employee  number";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.ok.Location = new System.Drawing.Point(541, 18);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(107, 35);
            this.ok.TabIndex = 138;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1058, 689);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.ud);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ud;
        private System.Windows.Forms.Label cu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView vsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rjob;
        private System.Windows.Forms.RadioButton raddress;
        private System.Windows.Forms.RadioButton rempname;
        private System.Windows.Forms.RadioButton ridd;
        private System.Windows.Forms.RadioButton rempno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox phoner;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.TextBox empno;
        private System.Windows.Forms.Button em;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rphone;
        private System.Windows.Forms.RadioButton rsalary;

    }
}