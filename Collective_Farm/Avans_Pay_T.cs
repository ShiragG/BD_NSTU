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
    public partial class Avans_Pay_T : Form
    {
        string EID = null;
        private OleDbConnection connectBD_user = new OleDbConnection();
        public Avans_Pay_T(string str = null)
        {
            InitializeComponent();

            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Load_ID_Doc();

            if (str != null)
            {
                EID = str;
                Loading();
            }
        }

        private void Loading()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select * from Авансовые_платежи where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBDogovor.Text = SearchName("Код", reader["id_договора"].ToString(), "Договор");
                    texBZnach.Text = reader["значение"].ToString();
                    dataBData.Text = reader["дата"].ToString();
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Doc()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Договор";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBDogovor.Items.Add(reader["номер_договора"].ToString());
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Add()
        {
            if ((comBDogovor.Text != "") && (texBZnach.Text != "") &&
                (dataBData.Text != null))
            {
                if ((comBDogovor.Text[0] != ' ') && (texBZnach.Text[0] != ' ') &&
                (dataBData.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"insert into Авансовые_платежи(id_договора,
                                                            значение,
                                                            дата) 
                                        values(" + SearchID("номер_договора", comBDogovor.Text, "Договор") + ",'" +
                                        texBZnach.Text + "','" +
                                        dataBData.Text + "')";

                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        connectBD_user.Close();
                        connectBD_user.Dispose();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connectBD_user.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Поля не должны начинаться с пустого символа!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private void Upd()
        {
            if ((comBDogovor.Text != "") && (texBZnach.Text != "") &&
                (dataBData.Text != null))
            {
                if ((comBDogovor.Text[0] != ' ') && (texBZnach.Text[0] != ' ') &&
                (dataBData.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"update Авансовые_платежи set id_договора =" + SearchID("номер_договора", comBDogovor.Text, "Договор") + "," +                            
                            "значение = '" + texBZnach.Text + "'," +
                            "дата = '" + dataBData.Text + "' " +
                            "where Код = " + EID + "";

                        command.CommandText = query;
                        command.ExecuteNonQuery();


                        connectBD_user.Close();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connectBD_user.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Поля не должны начинаться с пустого символа!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private string SearchID(string NameT, string Name, string Table)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select Код from " + Table + " where " + NameT + "  = '" + Name + "'";

                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader["Код"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                
                

            }
            return "";
        }
        private string SearchName(string NameT, string ID, string Table)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select " + NameT + " from " + Table + " where Код  = " + ID + "";

                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader[NameT].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                
                

            }
            return "";
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (EID == null)
            {
                Add();
            }
            else
            {
                Upd();
            }
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
            connectBD_user.Dispose();
            this.Close();
        }
    }
}
