﻿// Thurman Ward  9/9/14
// Exercise 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trwCh10Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
    }
}
