﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMakerGuiApp
{
    public partial class SaleStats : Form
    {
        TicketManager tm;
        public SaleStats(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();

            //Populate Controls With Information
            lblTotalProfit.Text += tm.CalculateTotalProfit();
            rbxSaleStats.Text += tm.TotalSnacksOrdered();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
