﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Johnson
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            surfaceBox.DataSource = DesktopMaterial;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
