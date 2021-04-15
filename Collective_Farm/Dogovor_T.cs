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
    public partial class Dogovor_T : Form
    {
        private OleDbConnection connectBD_user = new OleDbConnection();
        string EID = null;
        public Dogovor_T(string str = null)
        {
            InitializeComponent();
            
            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Load_ID_Org();
            Load_ID_UsP();
            Load_ID_UsOp();
            Load_ID_Kult();

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

                string query = "select * from Договор where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBOrg.Text = SearchName("наименование", reader["id_организации"].ToString(), "Организация");
                    comBUsP.Text = SearchName("название", reader["id_условия_доставки"].ToString(), "Условия_доставки");
                    comBUsOpl.Text = SearchName("название", reader["id_условия_оплаты"].ToString(), "Условия_оплаты");
                    comBKult.Text = SearchName("название", reader["id_культуры"].ToString(), "Культура");
                    texBObjem.Text = reader["объём"].ToString();
                    texBPayforEd.Text = reader["цена_за_ед_тов"].ToString();
                    dataBData.Text = reader["дата_доставки"].ToString();
                    textBND.Text = reader["номер_договора"].ToString();
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Org()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Организация";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBOrg.Items.Add(reader["наименование"].ToString());
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_UsP()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Условия_доставки ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBUsP.Items.Add(reader["название"].ToString());
                }

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_UsOp()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Условия_оплаты ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBUsOpl.Items.Add(reader["название"].ToString());
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
        private void Add()
        {
            if ((comBOrg.Text != "") && (comBUsOpl.Text != "") &&
                (comBUsP.Text != null) && (dataBData.Text != "") &&
                (texBObjem.Text != "") && (texBPayforEd.Text != "")
                && (comBKult.Text != "") && (textBND.Text!=""))
            {
                if ((comBOrg.Text[0] != ' ') && (comBUsOpl.Text[0] != ' ') &&
                (comBUsP.Text[0] != ' ') && (dataBData.Text[0] != ' ') &&
                (texBObjem.Text[0] != ' ') && (texBPayforEd.Text[0] != ' ')
                && (comBKult.Text[0] != ' ') && (textBND.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"insert into Договор(id_организации,
                                                            id_условия_доставки,
                                                            id_условия_оплаты,
                                                            id_культуры,
                                                            объём,
                                                            цена_за_ед_тов,
                                                            дата_доставки,
                                                            номер_договора) 
                                        values(" + SearchID("наименование", comBOrg.Text, "Организация") + "," +
                                        SearchID("название", comBUsP.Text, "Условия_доставки") + "," +
                                        SearchID("название", comBUsOpl.Text, "Условия_оплаты") + "," +
                                        SearchID("название", comBKult.Text, "Культура") + ",'" +
                                        texBObjem.Text + "','" +
                                        texBPayforEd.Text + "','" +
                                         dataBData.Text + "','"+
                                        textBND.Text+"')";
                                               

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
            if ((comBOrg.Text != "") && (comBUsOpl.Text != "") &&
               (comBUsP.Text != null) && (dataBData.Text != "") &&
               (texBObjem.Text != "") && (texBPayforEd.Text != "")
               && (comBKult.Text != "") && (textBND.Text != ""))
            {
                if ((comBOrg.Text[0] != ' ') && (comBUsOpl.Text[0] != ' ') &&
                (comBUsP.Text[0] != ' ') && (dataBData.Text[0] != ' ') &&
                (texBObjem.Text[0] != ' ') && (texBPayforEd.Text[0] != ' ')
                && (comBKult.Text[0] != ' ') && (textBND.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"update Договор set id_организации =" + SearchID("наименование", comBOrg.Text, "Организация") + "," +
                            " id_условия_доставки = " + SearchID("название", comBUsP.Text, "Условия_доставки") + "," +
                            "id_условия_оплаты = '" + SearchID("название", comBUsOpl.Text, "Условия_оплаты") + "'," +
                            "id_культуры = '" + SearchID("название", comBKult.Text, "Культура") + "'," +
                            "объём = '" + texBObjem.Text + "', " +
                            "цена_за_ед_тов = '" + texBPayforEd.Text + "', " +
                            "дата_доставки = '" + dataBData.Text + "'," +
                            "номер_договора = '" +textBND.Text +"' " +
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
