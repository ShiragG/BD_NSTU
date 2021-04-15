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
    public partial class Avans_Pay : Form
    {
        string EID = null;
        private OleDbConnection connectBD_user = new OleDbConnection();
        string access = null;
        public Avans_Pay(string acs)
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

            switch (prava[7])
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

                string query = @"select s.Код,bd.номер_договора as id_договора,
s.значение, 
s.дата 
from(Авансовые_платежи as s left outer join Договор as bd on s.id_договора = bd.Код)";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGView.DataSource = dt;


                dGView.Columns[1].HeaderCell.Value = "Договор №";
                dGView.Columns[2].HeaderCell.Value = "Значение";
                dGView.Columns[3].HeaderCell.Value = "Дата";

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

            Avans_Pay_T avans = new Avans_Pay_T();
            avans.ShowDialog();
            Init();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();

            if (EID != null)
            {
                connectBD_user.Close();
                Avans_Pay_T avans = new Avans_Pay_T(EID);
                avans.ShowDialog();

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

                    string query = "delete from Авансовые_платежи where Код=" + EID + " ";

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

        private void butBack_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
            connectBD_user.Dispose();
            this.Close();
        }

        private void dGView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            DataGridViewRow row = null;
            foreach (DataGridViewCell selectedCell in dGView.SelectedCells)
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
    }
}
