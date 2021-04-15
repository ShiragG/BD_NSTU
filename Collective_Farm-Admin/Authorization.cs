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
    public partial class Authorization : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Authorization()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_admin.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Init();
        }

        private void Init()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from пар_лог";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count++;
                }

                if (count == 0)
                {
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    Table table = new Table();
                    table.ShowDialog();


                    Application.Exit();
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
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

        private void butEnter_Click(object sender, EventArgs e)
        {
            if ((textLog.Text != " ") && (textPas.Text != " ")&& (textLog.Text[0] != ' ') && (textPas.Text[0] != ' '))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string query = "select * from пар_лог where логин ='" + textLog.Text + "'" +
                        " and пароль='" + HashPas(textPas.Text) + "' and статус='Администратор'";

                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();

                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        connection.Close();
                        connection.Dispose();
                        this.Hide();
                        Table table = new Table();
                        table.ShowDialog();
                        Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("Данные введены неверно!");

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми или начинаться с пустого символа!");
            }
        }
    }
}
