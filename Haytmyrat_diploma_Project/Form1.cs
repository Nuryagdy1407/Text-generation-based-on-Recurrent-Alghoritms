﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haytmyrat_diploma_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DodgerBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightSeaGreen;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Search();
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Visible = true;
        }

        private void Search()
        {
            throw new NotImplementedException();
        }
    }
}
