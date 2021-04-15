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
    
    public partial class Kult : Form
    {
        string access = null;
        private OleDbConnection connectBD_user = new OleDbConnection();
        public Kult(string acs)
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

            switch (prava[3])
            {
                case "1":
                    return;
                case "2":
                    butAdd.Enabled = false;
                    butDel.Enabled = false;
                    
                    break;
                case "3":
                    butDel.Enabled = false;
                    
                    break;
                case "4":
                    butDel.Enabled = false;
                    break;
            }

        }
        void Init()
        {
            listBox.Items.Clear();
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select * from Культура";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    listBox.Items.Add(reader["название"].ToString());
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
            connectBD_user.Dispose();
            this.Close();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = "delete from Культура where название='" + listBox.SelectedItem.ToString() + "'";


                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connectBD_user.Close();
                    Init();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                }
            }
            else
            {
                MessageBox.Show("Сначала выбирите элемент");
            }            
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = "insert into Культура(название) " +
                        "values('" + textBox.Text + "')";

                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    textBox.Clear();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Нельзя добавлять пустую строку!");
            }

            connectBD_user.Close();

            Init();
        }

    }
}
