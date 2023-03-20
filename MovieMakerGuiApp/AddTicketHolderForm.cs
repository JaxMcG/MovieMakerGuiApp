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
    public partial class AddTicketHolderForm : Form
    {
        TicketManager tm;
        public AddTicketHolderForm(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();
        }

        private void btnSnackBar_Click(object sender, EventArgs e)
        {
            //Add New Ticket Holder To tm
            tm.AddTicketHolder(new TicketHolder(tbxName.Text, (int)nudAge.Value, (int)nudNoTickets.Value, rbnPaymentCard.Checked));

            this.Hide();
            SnackBar myNewForm = new SnackBar(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
