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
    
    public partial class Organiz_T : Form
    {
        private OleDbConnection connectBD_user = new OleDbConnection();
        string EID = null;
        public Organiz_T(string str =  null)
        {
            InitializeComponent();

            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Load_ID_Bank();
            Load_ID_City();


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

                string query = "select * from Организация where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    comBBank.Text = SearchName("название", reader["id_банка"].ToString(), "Банк");
                    comBCity.Text = SearchName("название", reader["id_города"].ToString(), "город");
                    texBName.Text = reader["наименование"].ToString();
                    texBUlica.Text = reader["имя_улицы"].ToString();
                    texBHouse.Text = reader["имя_дома"].ToString();
                   
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Bank()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Банк";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBBank.Items.Add(reader["название"].ToString());
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_City()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from город ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBCity.Items.Add(reader["название"].ToString());
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
            if ((comBBank.Text != "") && (comBCity.Text != "") &&
                (texBHouse.Text != "") && (texBName.Text != "")
                && (texBUlica.Text != ""))
            {
                if ((comBBank.Text[0] != ' ') && (comBCity.Text[0] != ' ') &&
                (texBHouse.Text[0] != ' ') && (texBName.Text[0] != ' ')
                && (texBUlica.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"insert into Организация (id_банка,
                                                            id_города,
                                                            наименование,
                                                            имя_улицы,
                                                            имя_дома) 
                                        values(" + SearchID("название", comBBank.Text, "Банк") + "," +
                                        SearchID("название", comBCity.Text, "город") + ",'" +
                                        texBName.Text + "','" +
                                        texBUlica.Text + "','" +
                                        texBHouse.Text + "')";
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
            if ((comBBank.Text != "") && (comBCity.Text != "") &&
                (texBHouse.Text != "") && (texBName.Text != "")
                && (texBUlica.Text != ""))
            {
                if ((comBBank.Text[0] != ' ') && (comBCity.Text[0] != ' ') &&
                (texBHouse.Text[0] != ' ') && (texBName.Text[0] != ' ')
                && (texBUlica.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"update Организация set id_банка =" + SearchID("название", comBBank.Text, "Банк") + "," +
                            " id_города = " + SearchID("название", comBCity.Text, "город") + "," +
                            "наименование = '" +texBName.Text+ "'," +
                            "имя_улицы = '" +texBUlica.Text+ "'," +
                            "имя_дома = '" + texBHouse.Text + "' " +
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
