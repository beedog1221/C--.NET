﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinner_party_fixed
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, checkBox3.Checked, textBox1.Text);
            DisplayBirthdayPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            label2.Text = Cost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox3.Checked;
            DisplayBirthdayPartyCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            label5.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            cakeCostLabel.Text = cost.ToString("c");
        }
    }
}
