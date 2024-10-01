using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempatCuciMobilMotor
{
    public partial class userChoice : Form
    {
        public userChoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            homepage.Show();
            this.Hide();
            MessageBox.Show("Succesfully booked.\n\nDetail order:\nCustomer: Bianca\n" +
                "No Telepon: 08212275\n" +
                "Booked date: Monday, 30 september 2024\n" +
                "Time: 14.30 WITA\n" +
                "Service: Car - Hydrolic Wash - Drop off\n" +
                "Price: Rp. 100.000\n" +
                "Payment method: Cash");
        }
    }
}
