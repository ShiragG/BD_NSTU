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
    public partial class Dogovor : Form
    {
        string EID = null;
        string access = null;

        private OleDbConnection connectBD_user = new OleDbConnection();
        public Dogovor(string acs)
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

            switch (prava[5])
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

                string query = @"select s.Код,
bo.наименование as id_организации,
busd.название as id_условия_доставки,
buso.название as id_условия_оплаты,
bk.название as id_культуры,
s.объём, 
s.цена_за_ед_тов, 
s.дата_доставки,
s.номер_договора

from((((Договор as s left outer join Организация as bo on s.id_организации = bo.Код)
left outer join Условия_доставки as busd on s.id_условия_доставки = busd.Код)
left outer join Условия_оплаты as buso on s.id_условия_оплаты = buso.Код)
left outer join Культура as bk on s.id_культуры = bk.Код)";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGView.DataSource = dt;

                dGView.Columns[1].HeaderCell.Value = "Организация";
                dGView.Columns[2].HeaderCell.Value = "Условие доставки";
                dGView.Columns[3].HeaderCell.Value = "Условие оплаты";
                dGView.Columns[4].HeaderCell.Value = "Культура";
                dGView.Columns[5].HeaderCell.Value = "Объём";
                dGView.Columns[6].HeaderCell.Value = "Цен. за ед. тов.";
                dGView.Columns[7].HeaderCell.Value = "Дата доставки";
                dGView.Columns[8].HeaderCell.Value = "Номер договора";                

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

            Dogovor_T dogovor = new Dogovor_T();
            dogovor.ShowDialog();
            Init();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                connectBD_user.Close();
                Dogovor_T dogovor = new Dogovor_T(EID);
                dogovor.ShowDialog();

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

                    string query = "delete from Договор where Код=" + EID + " ";

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
