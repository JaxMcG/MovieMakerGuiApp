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
    public partial class SnackBar : Form
    {
        TicketManager tm;
        public SnackBar(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Store the Snacks Ordered in an int List
            List<int> sItems = new List<int>();
            List<int> sQuantities = new List<int>();

            //Check if Snack Has Been Ordered
            int indexCounter = 0;
            foreach (var item in snackQuantities)
            {
                if(item.Value > 0)
                {
                    //It Has Been Ordered Add the Index to the sItems List
                    sItems.Add(indexCounter);
                    sQuantities.Add((int)item.Value);
                }

                indexCounter++;
            }

            //Store the Drinks Ordered in an int List
            List<int> dItems = new List<int>();
            List<int> dQuantities = new List<int>();

            //Check if Drink Has Been Ordered
            indexCounter = 0;
            foreach (var item in drinkQuanitities)
            {
                if(item.Value > 0)
                {
                    //It Has Been Ordered Add the Index Value to the dItems List
                    dItems.Add(indexCounter);
                    dQuantities.Add((int)item.Value);
                }

                indexCounter++;
            }

            //Store the Ordered Snacks and Drink For the Ticket Holder
            tm.AddSnacksDrinksOrder(sItems, sQuantities, dItems, dQuantities);

            //Display Reciept Via a Message Box
            string message = tm.GenerateRecentReciept();
            string title = "Reciept";
            MessageBox.Show(message, title);
            
            //Close Snack Bar Form and Return to Home Form
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
