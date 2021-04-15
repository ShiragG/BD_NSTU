using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Collective_Farm
{
    public partial class Document : Form
    {

        string access = null;
        public Document(string acs)
        {
            InitializeComponent();
            access = acs;
            InitAccess();
        }
        
        private void InitAccess()
        {
            string[] prava = access.Split(':');

            if (prava[5] == "5")
            {                
                labelDogov.Enabled = false;
            }
            if (prava[6] == "5")
            {                
                labelOrgan.Enabled = false;
            }
            if (prava[7] == "5")
            {
                labelAvans.Enabled = false;
            }        
        }

        private void labelDogov_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dogovor dogovor = new Dogovor(access);
            dogovor.ShowDialog();
            this.Show();

        }

        private void labelOrgan_Click(object sender, EventArgs e)
        {

            this.Hide();
            Organization organization = new Organization(access);
            organization.ShowDialog();
            this.Show();
        }

        private void labelAvans_Click(object sender, EventArgs e)
        {
            this.Hide();
            Avans_Pay avans = new Avans_Pay(access);
            avans.ShowDialog();
            this.Show();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
