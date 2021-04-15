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
    public partial class Authorization : Form
    {
        public string prava;
        public string eid;
        private OleDbConnection connection = new OleDbConnection();
        public Authorization()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_admin.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
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
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "select * from пар_лог where логин ='" + textLog.Text + "'" +
                    " and пароль='" + HashPas(textPas.Text) + "' and статус='Пользователь'";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count++;
                    prava = reader["права_доступа"].ToString();
                    eid = reader["Код"].ToString();
                }

                if (count == 1)
                {
                    connection.Close();
                    connection.Dispose();
                    this.Close();                  
                }
                else
                {
                    connection.Close();
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
    }
}
