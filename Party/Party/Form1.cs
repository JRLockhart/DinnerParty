using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party
{
   
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, Healthy.Checked, Fancy.Checked);         
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void Fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = Fancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void Healthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealtyOptions = Healthy.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
