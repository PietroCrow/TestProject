﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "WHHYYYYY !!!";
            label2.Text = "WHHYYYYY !!!";
            checkBox1.Checked = true;
            checkBox1.Text = "WHHYYYYY !!!";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            checkBox1.Checked = false;
            checkBox1.Text = "";
            // it wasnt possible to return to the fist look of textBoxes
        }
    }
}
