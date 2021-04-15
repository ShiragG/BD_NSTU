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
using System.Security.Cryptography;

namespace Collective_Farm
{
    public partial class User_Data : Form
    {
        private OleDbConnection connectBD_admin = new OleDbConnection();
        string EID = null;
        public User_Data(string eid)
        {
            EID = eid;
            InitializeComponent();
            connectBD_admin.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_admin.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            if(EID != null)
            {
                Loading();
            }
        }
        private void Loading()
        {
            try
            {
                connectBD_admin.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_admin;

                string query = "select * from пар_лог where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    labelFirstN.Text = reader["фамилия"].ToString();
                    labelSecondN.Text = reader["имя"].ToString();
                    labelPartNim.Text = reader["отчество"].ToString();
                    labelLogin.Text = reader["логин"].ToString();
                    
                }

                connectBD_admin.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_admin.Close();
            }
        }
        public string HashPas(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                //указывает, что нужно преобразовать элемент в шестнадцатиричную строку длиной в два символа
                sBuilder.Append(data[i].ToString("x2"));
            }


            return sBuilder.ToString();
        }


        private void butChange_Click(object sender, EventArgs e)
        {
            string oldPas = textOldPas.Text;
            string newPas = textNewPas.Text;
            /////////////////////////////////////////////
            if ((textNewPas.Text != "") && (textOldPas.Text != ""))
            {
                if ((textNewPas.Text[0] != ' ') && (textOldPas.Text[0] != ' '))
                {
                    try
                    {
                        connectBD_admin.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connectBD_admin;

                        string query = "select * from пар_лог where логин ='" + labelLogin.Text + "'" +
                            " and пароль='" + HashPas(oldPas) + "'";

                        command.CommandText = query;
                        OleDbDataReader reader = command.ExecuteReader();

                        int count = 0;

                        while (reader.Read())
                        {
                            count++;
                        }

                        if (count == 1)
                        {
                            //////////////////////////
                            try
                            {
                                OleDbCommand command1 = new OleDbCommand();
                                command1.Connection = connectBD_admin;

                                query = @"update пар_лог set пароль = '" + HashPas(newPas) + "'";

                                command1.CommandText = query;
                                command1.ExecuteNonQuery();

                                
                                MessageBox.Show("Данные изменены");
                                

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error" + ex);
                                
                            }
                            //////////////////////////
                            connectBD_admin.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль!");
                        }

                        connectBD_admin.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connectBD_admin.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не может начинаться с пустого символа!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            connectBD_admin.Close();
            connectBD_admin.Dispose();
            this.Close();
        }

    }
}
