﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playing_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards((Suits)random.Next(4), (Values)random.Next(1, 14));
            MessageBox.Show(cards.Name);
        }
    }
}
