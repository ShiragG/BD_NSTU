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
    public partial class Graf_Work_T : Form
    {
        string EID = null;
        
        private OleDbConnection connectBD_user = new OleDbConnection();
        public Graf_Work_T(string str = null)
        {
            InitializeComponent();

            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";

            Load_ID_Teh();
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

                string query = "select * from Наряд where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comBoxTeh.Text = SearchName("название", reader["id_техники"].ToString(),"Техника") ;
                    comBoxSit.Text = SearchName("номер_участка", reader["id_участка"].ToString(), "Участок");
                    TimeNR.Text = reader["начало_работы"].ToString();
                    TimeKR.Text = reader["конец_работы"].ToString();
                    texBoxNorma.Text = reader["норма"].ToString();
                }

                connectBD_user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void Load_ID_Teh()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select * from Техника ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["состояние"].ToString() == "исправна")
                    {
                        comBoxTeh.Items.Add(reader["название"].ToString());

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
                    comBoxSit.Items.Add(reader["номер_участка"].ToString());
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
            if ((comBoxTeh.Text != "") && (comBoxSit.Text != "") &&
                (TimeNR.Text != null) && (TimeKR.Text != "") &&
                (texBoxNorma.Text != ""))
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = @"insert into Наряд(id_техники,id_участка,начало_работы,конец_работы,
                                    норма) 
                                values(" + SearchID("название", comBoxTeh.Text, "Техника") + "," +
                                    SearchID("номер_участка", comBoxSit.Text, "Участок") + ",'" +
                                    TimeNR.Text + "','" +
                                    TimeKR.Text + "','" +
                                    texBoxNorma.Text + "')";

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
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private void Upd()
        {
            if ((comBoxTeh.Text != "") && (comBoxSit.Text != "") &&
                (TimeNR.Text != null) && (TimeKR.Text != "") &&
                (texBoxNorma.Text != ""))
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = @"update Наряд set id_техники =" + SearchID("название", comBoxTeh.Text, "Техника") + "," +
                        " id_участка = " + SearchID("номер_участка", comBoxSit.Text, "Участок") + "," +
                        "начало_работы = '" + TimeNR.Text + "'," +
                        "конец_работы = '" + TimeKR.Text + "'," +
                        "норма = '" + texBoxNorma.Text + "' " +
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
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private string SearchID(string NameT, string Name, string Table)
        {
            try
            {                
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select Код from "+Table+" where "+NameT+"  = '"+Name+"'";
                               
                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();

                while(reader.Read())
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
        private string SearchName(string NameT,string ID, string Table)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select "+NameT+" from " + Table + " where Код  = " + ID + "";

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
