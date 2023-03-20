using System;
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
    public partial class HomeForm : Form
    {
        TicketManager tm;

        public HomeForm(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();
        }

        private void btnAddTicketHolder_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTicketHolderForm myNewForm = new AddTicketHolderForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnViewSaleStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaleStats myNewForm = new SaleStats(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
