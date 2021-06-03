﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnFormAll_Click(object sender, EventArgs e)
        {
           
            Form frm = new Film();
            frm.Show();
            this.Hide();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            Form frm = new Genre();
            frm.Show();
            this.Hide();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
