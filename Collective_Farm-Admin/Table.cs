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

namespace Collective_Farm_Admin
{
    public partial class Table : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        string EID = null;
        public Table()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_admin.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Init();
        }

        void Init()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = @"select Код,фамилия,имя,отчество,логин,статус from пар_лог";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
                dataGridView1.Columns[2].HeaderCell.Value = "Имя";
                dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
                dataGridView1.Columns[4].HeaderCell.Value = "Логин";
                dataGridView1.Columns[5].HeaderCell.Value = "Статус";

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            connection.Close();

            AddUser dogovor = new AddUser();
            dogovor.ShowDialog();
            Init();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                connection.Close();
                AddUser addUser = new AddUser(EID);
                addUser.ShowDialog();

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
                DialogResult dialogResult = MessageBox.Show("Данные этого пользователя будут полностью удалены, продолжить?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        string query = "delete from пар_лог where Код=" + EID + " ";

                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        connection.Close();
                        Init();
                        EID = null;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connection.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }              

            }
            else
            {
                MessageBox.Show("Сначала выбирете элемент!");
            }
        }

        private void butEditAccess_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                connection.Close();
                AddUser addUser = new AddUser(EID, true);
                addUser.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Сначала выбирите строку");

            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            DataGridViewRow row = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
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
