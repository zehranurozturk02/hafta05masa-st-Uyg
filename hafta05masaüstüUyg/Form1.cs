﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta05masaüstüUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked)
            {
                toplam += 100;
            }if (checkBox2.Checked)
            {
                toplam += 200;
            }
            if (checkBox3.Checked)
            { 
                toplam += 500;
            }
            label2.Text = Convert.ToString(toplam);
        }
        

    }
}
