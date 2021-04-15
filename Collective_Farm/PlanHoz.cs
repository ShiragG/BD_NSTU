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
    public partial class PlanHoz : Form
    {
        
        public PlanHoz(string acs)
        {
            InitializeComponent();
            access = acs;
            InitAccess();
        }
        string access = null;
        private void InitAccess()
        {
            string[] prava = access.Split(':');

            if(prava[0] == "5")
            {
                labelGrWork.Enabled = false;
            }
            if (prava[1] == "5")
            {
                labelAutoP.Enabled = false;
            }
            if (prava[2] == "5")
            {
                labelPSev.Enabled = false;
            }
            if (prava[3] == "5")
            {
                labelC.Enabled = false;
            }
            if (prava[4] == "5")
            {
                labelUch.Enabled = false;
            }
        }

        private void labelGrWork_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Graf_Work grafW = new Graf_Work(access);
            grafW.ShowDialog();
            this.Show();

        }

        private void labelAutoP_Click(object sender, EventArgs e)
        {


            this.Hide();
            Auto auto = new Auto(access);
            auto.ShowDialog();
            this.Show();

        }

        private void labelC_Click(object sender, EventArgs e)
        {


            this.Hide();
            Kult kult = new Kult(access);
            kult.ShowDialog();
            this.Show();

        }

        private void labelUch_Click(object sender, EventArgs e)
        {

    
            this.Hide();
            Sites sites = new Sites(access);
            sites.ShowDialog();
            this.Show();
   
        }

        private void labelPSev_Click(object sender, EventArgs e)
        {


            this.Hide();
            P_Sev psev = new P_Sev(access);
            psev.ShowDialog();
            this.Show();

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
