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
    public partial class Auto_T : Form
    {

        string EID = null;

        private OleDbConnection connectBD_user = new OleDbConnection();
        public Auto_T(string str = null)
        {

            InitializeComponent();

            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
        
            if(str!= null)
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

                string query = "select * from Техника where Код = "+EID+"";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    texBName.Text = reader["название"].ToString();
                    comBStatus.Text = reader["состояние"].ToString();
                    dataBDataV.Text = reader["дата_выпуска"].ToString();
                    dataBDataPosTex.Text = reader["дата_последнего_ремонта"].ToString();
                    dataBDataSledTex.Text = reader["дата_следующего_ремонта"].ToString();
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
            if ((texBName.Text != "") &&
                  (dataBDataV.Text != "") &&
                  (comBStatus.Text != "") &&
                  (dataBDataPosTex.Text != "") &&
                  (dataBDataSledTex.Text != "")
                )
            {
                if ((texBName.Text[0] !=' ') && 
                    (comBStatus.Text[0] != ' ') && 
                    (dataBDataV.Text[0] != ' ') && 
                    (dataBDataPosTex.Text[0] != ' ') && 
                    (dataBDataSledTex.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"insert into Техника(название,состояние,дата_выпуска,дата_последнего_ремонта,
                                    дата_следующего_ремонта) 
                                values('" + texBName.Text + 
                                "','" + comBStatus.Text + 
                                "','" + dataBDataV.Text + 
                                "','" + dataBDataPosTex.Text + 
                                "','" + dataBDataSledTex.Text + "')";

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
                    MessageBox.Show("Поля не могут начинаться с пустого символа!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private void Upd()
        {
            if ((texBName.Text != "") &&
                  (dataBDataV.Text != "") &&
                  (comBStatus.Text != "") &&
                  (dataBDataPosTex.Text != "") &&
                  (dataBDataSledTex.Text != "")
                )
            {
                if ((texBName.Text[0] != ' ') &&
                    (comBStatus.Text[0] != ' ') &&
                    (dataBDataV.Text[0] != ' ') &&
                    (dataBDataPosTex.Text[0] != ' ') &&
                    (dataBDataSledTex.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_user.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_user;

                        string query = @"update Техника set название ='" + texBName.Text + "'," +
                            " состояние = '" + comBStatus.Text + "'," +
                            "дата_выпуска = '" + dataBDataV.Text + "'," +
                            "дата_последнего_ремонта = '" + dataBDataPosTex.Text + "'," +
                            "дата_следующего_ремонта = '" + dataBDataSledTex.Text + "'" +
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
                    MessageBox.Show("Поля не могут начинаться с пустого символа!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if(EID == null)
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
