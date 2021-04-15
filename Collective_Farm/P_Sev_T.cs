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
    public partial class P_Sev_T : Form
    {
        string EID = null;

        private OleDbConnection connectBD_user = new OleDbConnection();
        public P_Sev_T(string str = null)
        {
            InitializeComponent();
            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Load_ID_Kult();
            Load_ID_Sit();

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

                string query = "select * from Севооборот where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBKult.Text = SearchName("название", reader["id_культуры"].ToString(), "Культура");
                    comBSit.Text = SearchName("номер_участка", reader["id_участка"].ToString(), "Участок");
                    texBOjidUr.Text = reader["ожидаемый_урожай"].ToString();
                    texBFactU.Text = reader["фактический_урожай"].ToString();
                    textBAge1.Text = reader["год"].ToString();
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Kult()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Культура ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBKult.Items.Add(reader["название"].ToString());
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Sit()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Участок ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["статус"].ToString() != "под паром")
                    {
                        comBSit.Items.Add(reader["номер_участка"].ToString());
                    }
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
            if ((comBSit.Text!="")
                && (comBKult.Text!="")
                && (texBOjidUr.Text != "")
                && (textBAge1.Text != "")
                && (texBFactU.Text != ""))
            {
                if ((comBSit.Text[0] != ' ')
                && (comBKult.Text[0] != ' ')
                && (texBOjidUr.Text[0] != ' ')
                && (textBAge1.Text[0] != ' ')
                && (texBFactU.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"insert into Севооборот(id_участка,id_культуры,ожидаемый_урожай,фактический_урожай,
                                    год) 
                                values(" + SearchID("номер_участка", comBSit.Text, "Участок") + "," +
                                        SearchID("название", comBKult.Text, "Культура") +
                                        ",'" + texBOjidUr.Text +
                                        "','" + texBFactU.Text +
                                        "','" + textBAge1.Text + "')";

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
                    MessageBox.Show("Значения не могут начинаться с пустого символа");
                }
            }
            else
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
        }
        private void Upd()
        {
            if ((comBSit.Text != "")
                && (comBKult.Text != "")
                && (texBOjidUr.Text != "")
                && (textBAge1.Text != "")
                && (texBFactU.Text != ""))
            {
                if ((comBSit.Text[0] != ' ')
                && (comBKult.Text[0] != ' ')
                && (texBOjidUr.Text[0] != ' ')
                && (textBAge1.Text[0] != ' ')
                && (texBFactU.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"update Севооборот set id_участка =" + SearchID("номер_участка", comBSit.Text, "Участок") + "," +
                            " id_культуры = " + SearchID("название", comBKult.Text, "Культура") + "," +
                            "ожидаемый_урожай = '" + texBOjidUr.Text + "'," +
                            "фактический_урожай = '" + texBFactU.Text + "'," +
                            "год = '" + textBAge1.Text + "' " +
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
                    MessageBox.Show("Значения не могут начинаться с пустого символа");
                }
            }
            else
            {
                MessageBox.Show("Поля должны быть заполнены");
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
                connectBD_user.Close();

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
                connectBD_user.Close();

            }
            return "";
        }
        private void butOK_Click(object sender, EventArgs e)
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
