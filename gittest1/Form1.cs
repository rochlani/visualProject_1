﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gittest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("second save");
            MessageBox.Show("third  save");
            MessageBox.Show("fourth commit");
            if (1 == 1)
            {
                MessageBox.Show("gul");
            }

            MessageBox.Show("Master");
        }
    }
}
