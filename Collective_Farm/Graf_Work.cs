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
    public partial class Graf_Work : Form
    {
        string access = null;
        string EID = null;
        private OleDbConnection connectBD_user = new OleDbConnection();
        public Graf_Work(string acs)
        {
            access = acs;
            InitializeComponent();
            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Init();
            InitAccess();
        }
        
        private void InitAccess()
        {
            string[] prava = access.Split(':');

            switch (prava[0])
            {
                case "1":
                    return;                    
                case "2":
                    butAdd.Enabled = false;
                    butDel.Enabled = false;
                    butEdit.Enabled = false;                    
                    break;
                case "3":
                    butDel.Enabled = false;
                    butEdit.Enabled = false;
                    break;
                case "4":
                    butDel.Enabled = false;
                    break;                
            }
            
        }
        private void Init()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                //string query = @"select * from Наряд ";
                string query = @"select s.Код, bt.название as id_техники,
bs.номер_участка as id_участка,
s.начало_работы, 
s.конец_работы, 
s.норма 
from((Наряд as s left outer join Техника as bt on s.id_техники = bt.Код)
left outer join Участок as bs on s.id_участка = bs.Код)";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGView1.DataSource = dt;

                dGView1.Columns[1].HeaderCell.Value = "Техника";
                dGView1.Columns[2].HeaderCell.Value = "Участок";
                dGView1.Columns[3].HeaderCell.Value = "Начало работы";
                dGView1.Columns[4].HeaderCell.Value = "Окончание работы";
                dGView1.Columns[5].HeaderCell.Value = "Норма";
                
                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
   
            Graf_Work_T graf = new Graf_Work_T();
            graf.ShowDialog();

            Init();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                connectBD_user.Close();
                Graf_Work_T graf = new Graf_Work_T(EID);
                graf.ShowDialog();
                
                Init();
            }
            else
            {
                MessageBox.Show("Сначала выбирите строку");

            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = "delete from Наряд where Код=" + EID + " ";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connectBD_user.Close();
                    Init();
                    EID = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                }

            }
            else
            {
                MessageBox.Show("Сначала выбирете элемент!");
            }
        }

        private void dGView1_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            DataGridViewRow row = null;
            foreach (DataGridViewCell selectedCell in dGView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                row = cell.OwningRow;
                EID = row.Cells[0].Value.ToString();
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
            connectBD_user.Dispose();
            this.Close();
        }
    }
}
