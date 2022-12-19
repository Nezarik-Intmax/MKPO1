using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKPO1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double var1 = Convert.ToDouble(textBox1.Text);
            double var2 = Convert.ToDouble(textBox2.Text);
            double var3 = Convert.ToDouble(textBox3.Text);
            double var4 = Convert.ToDouble(textBox4.Text);
            double var5 = Convert.ToDouble(textBox5.Text);
            double var6 = Convert.ToDouble(textBox6.Text);
            double var7 = Convert.ToDouble(textBox7.Text);
            double var8 = Convert.ToDouble(textBox8.Text);
            double var9 = Convert.ToDouble(textBox9.Text);
            double var10 = Convert.ToDouble(textBox10.Text);
            double var11 = Convert.ToDouble(textBox11.Text);
            double var12 = Convert.ToDouble(textBox12.Text);
            double var13 = Convert.ToDouble(textBox13.Text);
            double var14 = Convert.ToDouble(textBox14.Text);
            double var15 = Convert.ToDouble(textBox15.Text);

            quality.Text = Convert.ToString((var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10 + var11 + var12 + var13 + var14 + var15)/15);
        }
    }
}
