
namespace lab1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.h_logo = new System.Windows.Forms.Label();
            this.d_logo = new System.Windows.Forms.Label();
            this.o1_logo = new System.Windows.Forms.Label();
            this.f_logo = new System.Windows.Forms.Label();
            this.b_logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.h = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.o1 = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // h_logo
            // 
            this.h_logo.AutoSize = true;
            this.h_logo.Location = new System.Drawing.Point(24, 21);
            this.h_logo.Name = "h_logo";
            this.h_logo.Size = new System.Drawing.Size(31, 20);
            this.h_logo.TabIndex = 0;
            this.h_logo.Text = "h =";
            // 
            // d_logo
            // 
            this.d_logo.AutoSize = true;
            this.d_logo.Location = new System.Drawing.Point(24, 54);
            this.d_logo.Name = "d_logo";
            this.d_logo.Size = new System.Drawing.Size(32, 20);
            this.d_logo.TabIndex = 2;
            this.d_logo.Text = "d =";
            // 
            // o1_logo
            // 
            this.o1_logo.AutoSize = true;
            this.o1_logo.Location = new System.Drawing.Point(15, 87);
            this.o1_logo.Name = "o1_logo";
            this.o1_logo.Size = new System.Drawing.Size(40, 20);
            this.o1_logo.TabIndex = 6;
            this.o1_logo.Text = "o1 =";
            // 
            // f_logo
            // 
            this.f_logo.AutoSize = true;
            this.f_logo.Location = new System.Drawing.Point(27, 120);
            this.f_logo.Name = "f_logo";
            this.f_logo.Size = new System.Drawing.Size(28, 20);
            this.f_logo.TabIndex = 7;
            this.f_logo.Text = "f =";
            // 
            // b_logo
            // 
            this.b_logo.AutoSize = true;
            this.b_logo.Location = new System.Drawing.Point(24, 153);
            this.b_logo.Name = "b_logo";
            this.b_logo.Size = new System.Drawing.Size(32, 20);
            this.b_logo.TabIndex = 9;
            this.b_logo.Text = "b =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 53);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(62, 21);
            this.h.Name = "h";
            this.h.ReadOnly = true;
            this.h.Size = new System.Drawing.Size(172, 27);
            this.h.TabIndex = 11;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(62, 54);
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Size = new System.Drawing.Size(172, 27);
            this.d.TabIndex = 12;
            // 
            // o1
            // 
            this.o1.Location = new System.Drawing.Point(62, 87);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(172, 27);
            this.o1.TabIndex = 13;
            this.o1.TextChanged += new System.EventHandler(this.o1_TextChanged);
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(62, 120);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(172, 27);
            this.f.TabIndex = 14;
            this.f.TextChanged += new System.EventHandler(this.f_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(62, 153);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(172, 27);
            this.b.TabIndex = 15;
            this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 252);
            this.Controls.Add(this.b);
            this.Controls.Add(this.f);
            this.Controls.Add(this.o1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.h);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_logo);
            this.Controls.Add(this.f_logo);
            this.Controls.Add(this.o1_logo);
            this.Controls.Add(this.d_logo);
            this.Controls.Add(this.h_logo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h_logo;
        private System.Windows.Forms.Label d_logo;
        private System.Windows.Forms.Label o1_logo;
        private System.Windows.Forms.Label f_logo;
        private System.Windows.Forms.Label b_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox o1;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.TextBox b;
    }
}

