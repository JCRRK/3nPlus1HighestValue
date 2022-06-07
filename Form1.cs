﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3x_1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long start;
            long result = 0;
            long low = Convert.ToInt64(textBoxLow.Text);
            long high = Convert.ToInt64(textBoxHigh.Text);
            result = low;
            for (long i = low; i <= high; i++)
            { 
                calculate(i);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStarting_Click(object sender, EventArgs e)
        {
            long result = calculate(Convert.ToInt64(textBoxStarting.Text));
            labelResult.Text = result.ToString();
        }
        static long calculate(long x)
        {
            long highest = 0;
            do
            {
                if (x % 2 != 0) x = x * 3 + 1;
                else x = x / 2;
                if (x > highest) highest = x;
            } while (x != 1);
            return highest;
        }

        private void textBoxStarting_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
