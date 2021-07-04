namespace hotel1
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maro = new System.Windows.Forms.PictureBox();
            this.amin = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::hotel1.Properties.Resources.vvv1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.maro);
            this.panel1.Controls.Add(this.amin);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1527, 629);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maro
            // 
            this.maro.Image = global::hotel1.Properties.Resources.images;
            this.maro.Location = new System.Drawing.Point(819, 71);
            this.maro.Name = "maro";
            this.maro.Size = new System.Drawing.Size(350, 407);
            this.maro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maro.TabIndex = 1;
            this.maro.TabStop = false;
            // 
            // amin
            // 
            this.amin.Image = global::hotel1.Properties.Resources.ZCR_BEM_100116loungers_06;
            this.amin.Location = new System.Drawing.Point(65, 71);
            this.amin.Name = "amin";
            this.amin.Size = new System.Drawing.Size(350, 407);
            this.amin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amin.TabIndex = 0;
            this.amin.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 623);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "home";
            this.Text = "home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox maro;
        private System.Windows.Forms.PictureBox amin;

    }
}