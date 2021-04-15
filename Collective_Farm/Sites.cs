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
    public partial class Sites : Form
    {
        string EID = null;
        string access = null;
        private OleDbConnection connectBD_user = new OleDbConnection();


        public Sites(string acs)
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

            switch (prava[4])
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

                string query = @"select * from Участок ";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGView.DataSource = dt;

                dGView.Columns[1].HeaderCell.Value = "Участок №";
                dGView.Columns[2].HeaderCell.Value = "Площадь";
                dGView.Columns[3].HeaderCell.Value = "Статус";

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
            if ((texBPlosh.Text != "") && (texBNomer.Text != ""))
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = @"insert into Участок(номер_участка,площадь_участка,статус) 
                                values('" + texBNomer.Text + "'," +
                                "'" + texBPlosh.Text + "'," +
                                "'"+ comBStatus.Text+"')";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connectBD_user.Close();

                    texBPlosh.Clear();
                    texBNomer.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                    
                }

                Init();
            }
            else
            {
                MessageBox.Show("Нельзя добавлять пустые строки!");
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if ((EID != null) && (texBNomer.Text!="") && (texBPlosh.Text!=""))
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = @"update Участок set номер_участка ='" + texBNomer.Text + "'," +
                        " площадь_участка = '" + texBPlosh.Text + "'," +
                        " статус = '"+ comBStatus.Text+"' where Код = " + EID + "";

                    command.CommandText = query;
                    command.ExecuteNonQuery();


                    connectBD_user.Close();

                    texBPlosh.Clear();
                    texBNomer.Clear();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                }

                Init();
            }
            else
            {
                MessageBox.Show("Сначала заполните пустые строки или выбирете элемент из таблицы");
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

                    string query = "delete from Участок where Код=" + EID + " ";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connectBD_user.Close();
                    
                    EID = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                }
                Init();
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

        private void LoadChange()
        {
            try
            {
                connectBD_user.Close();
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Участок where Код = "+EID+" ";

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    texBNomer.Text = reader["номер_участка"].ToString();
                    texBPlosh.Text = reader["площадь_участка"].ToString();
                    comBStatus.Text = reader["статус"].ToString();
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void dGView_SelectionChanged_1(object sender, EventArgs e)
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
                LoadChange();
            }

        }

    }
}
