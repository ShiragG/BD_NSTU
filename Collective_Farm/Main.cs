using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collective_Farm
{

    public partial class Main : Form
    {
        string access = null;
        string EID = null;
        public Main()
        {
            InitializeComponent();
            Authoriz();

        }
        private void Authoriz()
        {
            Authorization aut = new Authorization();
            aut.ShowDialog();
            access = aut.prava;
            EID = aut.eid;

            if (access == null)
            {
                labelPlanHoz.Enabled = false;
                labelDoc.Enabled = false;
                labelUser.Enabled = false;
            }
            else
            {
                labelPlanHoz.Enabled = true;
                labelDoc.Enabled = true;
                labelUser.Enabled = true;
            }
        }
        private void labelPlanHoz_Click(object sender, EventArgs e)
        {  
            this.Hide();
            PlanHoz planhoz = new PlanHoz(access);
            planhoz.ShowDialog();
            this.Show();        
            
        }
        private void labelDoc_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            Document document = new Document(access);
            document.ShowDialog();
            this.Show();            
            
        }     

        private void labelUser_Click(object sender, EventArgs e)
        {            
   
            User_Data user_data = new User_Data(EID);
            user_data.ShowDialog();     
            
        }
        private void butAuthoriz_Click(object sender, EventArgs e)
        {
            Authoriz();
        }


    }
}
