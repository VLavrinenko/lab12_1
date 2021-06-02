using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
     public partial class Form1 : Form
    {
        private int hM = 0, dM = 0, o1M = 0, fM = 0, bM = 0;
        private bool exeptionO1M = false, exeptionF = false, exeptionB = false;
        public Form1()
        {
            InitializeComponent();
            QFunction();
        }
        public void QFunction()
        {
            if (!exeptionB && !exeptionF && !exeptionO1M)
            {
                double Q = Convert.ToSingle(Math.Sin(hM + dM / (Math.Pow(Math.E, o1M))) - o1M + Math.Abs(Math.Sin(fM) + Math.Sqrt(Math.Abs(Math.Sin(bM)))));
                Text = string.Format("Q = {0}", Q);
            }
            else
                Text = "ERROR";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            h.Text = Convert.ToString(e.X);
            d .Text= Convert.ToString(e.Y);
            hM = e.X;
            dM = e.Y;
            QFunction();
        }
        private void o1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                o1M = Convert.ToInt32(o1.Text);
                exeptionO1M = false;
            }
            catch {
                exeptionO1M = true;
            }
            QFunction();
        }
        private void f_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fM = Convert.ToInt32(f.Text);
                exeptionF = false;
            }
            catch
            {
                exeptionF = true;
            }
            QFunction();
        }
        private void b_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bM = Convert.ToInt32(b.Text);
                exeptionB = false;
            }
            catch
            {
                exeptionB = true;
            }
            QFunction();
        }
    }

}
