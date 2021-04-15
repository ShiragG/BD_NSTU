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

namespace Collective_Farm_Admin
{
    public partial class AddUser : Form
    {
        string EID = null;
        bool FLAG = false;
        bool flPas = false;
        private OleDbConnection connection = new OleDbConnection();
        public AddUser(string str = null, bool flag = false)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_admin.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            if (str != null)
            {
                EID = str;
                Loading();
            }
            if (flag)
            {
                FLAG = flag;
                textFN.Enabled = false;
                textSN.Enabled = false;
                textPN.Enabled = false;
                textLog.Enabled = false;
                textPas.Enabled = false;
                comBStatus.Enabled = false;
            }
        }

        private string FuncPravName(string prav)
        {
            switch (prav)
            {
                case "1":
                    return "Полный доступ";
                case "2":
                    return "Чтение";

                case "3":
                    return "Чтение и добавление";

                case "4":
                    return "Чтение, добавление, редактирование";

                case "5":
                    return "Запрет";

                default:
                    break;
            }
            return "";
        }
        
        private string FuncNamePrav(string name)
        {
            switch(name)
            {
                case "Полный доступ":   
                    return "1";
                case "Чтение": 
                    return "2";
                    
                case "Чтение и добавление": 
                    return "3";
                    
                case "Чтение, добавление, редактирование":
                    return "4";
                    
                case "Запрет":
                    return "5";
                    
                default:
                    break;
            }
            return "";
        }
        private void Loading()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from пар_лог where Код = " + EID + "";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    textFN.Text = reader["фамилия"].ToString();
                    textSN.Text = reader["имя"].ToString();
                    textPN.Text = reader["отчество"].ToString();
                    textLog.Text = reader["логин"].ToString();
                    comBStatus.Text = reader["статус"].ToString();

                    string strRead = reader["права_доступа"].ToString();
                    string[] pars = strRead.Split(':');

                    comBGRab.Text = FuncPravName(pars[0]);
                    comBAuto.Text = FuncPravName(pars[1]);
                    comBPlan.Text = FuncPravName(pars[2]);
                    comBKult.Text = FuncPravName(pars[3]);
                    comBSit.Text = FuncPravName(pars[4]);
                    comBDogov.Text = FuncPravName(pars[5]);
                    comBOrg.Text = FuncPravName(pars[6]);
                    comBAvPay.Text = FuncPravName(pars[7]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
        private string HashPas(string input)
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

        private void Add()
        {
            if ((textFN.Text != "") && (textSN.Text != "") && (textPN.Text != "") &&
                (textLog.Text != "") && (textPas.Text != "") && (comBStatus.Text != "") &&
                (comBGRab.Text != "") && (comBAuto.Text != "") && (comBPlan.Text != "") &&
                (comBKult.Text != "") && (comBSit.Text != "") && (comBDogov.Text != "") &&
                (comBOrg.Text != "") && (comBAvPay.Text != ""))
            {
                if ((textFN.Text[0] != ' ') && (textSN.Text[0] != ' ') && (textPN.Text[0] != ' ') &&
                (textLog.Text[0] != ' ') && (textPas.Text[0] != ' '))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        string query = @"insert into пар_лог(фамилия,
                                                     имя,
                                                     отчество,
                                                     логин,
                                                     пароль,
                                                     статус,
                                                     права_доступа) " +
                                        "values('" +
                                            textFN.Text + "','" +
                                            textSN.Text + "','" +
                                            textPN.Text + "','" +
                                            textLog.Text + "','" +
                                            HashPas(textPas.Text) + "','" +
                                            comBStatus.Text + "','" +
                                            CreatePrav() +
                                         "')";

                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Пользователь добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }

                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поле не может начинаться с пустого элемента!");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        private void Upd()
        {
            if ((textFN.Text != "") && (textSN.Text != "") && (textPN.Text != "") &&
                (textLog.Text != "") && (textPas.Text != "") && (comBStatus.Text != "") &&
                (comBGRab.Text != "") && (comBAuto.Text != "") && (comBPlan.Text != "") &&
                (comBKult.Text != "") && (comBSit.Text != "") && (comBDogov.Text != "") &&
                (comBOrg.Text != "") && (comBAvPay.Text != ""))
            {
                if ((textFN.Text[0] != ' ') && (textSN.Text[0] != ' ') && (textPN.Text[0] != ' ') &&
                (textLog.Text[0] != ' ') && (textPas.Text[0] != ' '))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;

                        string query = @"update пар_лог set 
                                         фамилия ='" + textFN.Text + "'," +
                                        "имя = '" + textSN.Text + "'," +
                                        "отчество = '" + textPN.Text + "'," +
                                        "логин = '" + textLog.Text + "'," +
                                        "пароль = '" + HashPas(textPas.Text) + "', " +
                                        "статус = '" + comBStatus.Text + "', " +
                                        "права_доступа = '" + CreatePrav() + "' " +
                                        "where Код = " + EID + "";

                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        
                        connection.Close();
                        MessageBox.Show("Данные пользователя изменены");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connection.Close();
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

        private void UpdAccess()
        {
            if ((comBGRab.Text != "") && (comBAuto.Text != "") && (comBPlan.Text != "") &&
              (comBKult.Text != "") && (comBSit.Text != "") && (comBDogov.Text != "") &&
              (comBOrg.Text != "") && (comBAvPay.Text != ""))
            {

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string query = @"update пар_лог set права_доступа = '" + CreatePrav() + "' " +
                                    "where Код = " + EID + "";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Данные пользователя изменены");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
        }
        private string CreatePrav()
        {
            string str = "";

            str = FuncNamePrav(comBGRab.Text) + ":" +
                FuncNamePrav(comBAuto.Text) + ":" +
                FuncNamePrav(comBPlan.Text) + ":" +
                FuncNamePrav(comBKult.Text) + ":" +
                FuncNamePrav(comBSit.Text) + ":" +
                FuncNamePrav(comBDogov.Text) + ":" +
                FuncNamePrav(comBOrg.Text) + ":" +
                FuncNamePrav(comBAvPay.Text);

            return str;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (FLAG)
            {
                UpdAccess();
            }
            else
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
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBStatus.Text == "Администратор")
            {
                comBGRab.Text = "Запрет";
                comBAuto.Text = "Запрет";
                comBPlan.Text = "Запрет";
                comBKult.Text = "Запрет";
                comBSit.Text = "Запрет";
                comBDogov.Text = "Запрет";
                comBOrg.Text = "Запрет";
                comBAvPay.Text = "Запрет";

                comBGRab.Enabled = false;
                comBAuto.Enabled = false;
                comBPlan.Enabled = false;
                comBKult.Enabled = false;
                comBSit.Enabled = false;
                comBDogov.Enabled = false;
                comBOrg.Enabled = false;
                comBAvPay.Enabled = false;
            }
            else
            {
                comBGRab.Text = "Полный доступ";
                comBAuto.Text = "Полный доступ";
                comBPlan.Text = "Полный доступ";
                comBKult.Text = "Полный доступ";
                comBSit.Text = "Полный доступ";
                comBDogov.Text = "Полный доступ";
                comBOrg.Text = "Полный доступ";
                comBAvPay.Text = "Полный доступ";

                comBGRab.Enabled = true;
                comBAuto.Enabled = true;
                comBPlan.Enabled = true;
                comBKult.Enabled = true;
                comBSit.Enabled = true;
                comBDogov.Enabled = true;
                comBOrg.Enabled = true;
                comBAvPay.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPas.UseSystemPasswordChar = flPas;
                flPas = (!flPas);    
        }
    }
}
