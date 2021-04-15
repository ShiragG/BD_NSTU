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
    public partial class P_Sev : Form
    {
        string access = null;
        string EID = null;
        private OleDbConnection connectBD_user = new OleDbConnection();
        public P_Sev(string acs)
        {
            access = acs;
            InitializeComponent();
            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            Init();
            InitAccess();
        }
        private void InitAccess()
        {
            string[] prava = access.Split(':');

            switch (prava[2])
            {
                case "1":
                    return;
                case "2":
                    butAdd.Enabled = false;
                    butDel.Enabled = false;
                    butEdit.Enabled = false;
                    break;
                case "3":
                    butDel.Enabled = false;
                    butEdit.Enabled = false;
                    break;
                case "4":
                    butDel.Enabled = false;
                    break;
            }

        }
        private void Init()
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select s.Код, bs.номер_участка as id_участка,
bk.название as id_культуры,
s.ожидаемый_урожай, 
s.фактический_урожай, 
s.год 
from((Севооборот as s left outer join Участок as bs on s.id_участка = bs.Код)
left outer join Культура as bk on s.id_культуры = bk.Код) ";

                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGView.DataSource = dt;

                dGView.Columns[1].HeaderCell.Value = "Участок";
                dGView.Columns[2].HeaderCell.Value = "Культура";
                dGView.Columns[3].HeaderCell.Value = "Ожид. урожай";
                dGView.Columns[4].HeaderCell.Value = "Факт. урожай";
                dGView.Columns[5].HeaderCell.Value = "Год";


                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {

            connectBD_user.Close();

            P_Sev_T psev = new P_Sev_T();
            psev.ShowDialog();

            Init();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                connectBD_user.Close();
                P_Sev_T psev = new P_Sev_T(EID);
                psev.ShowDialog();
                Init();
                EID = null;
            }
            else
            {
                MessageBox.Show("Сначала выбирите строку");

            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (EID != null)
            {
                try
                {
                    connectBD_user.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connectBD_user;

                    string query = "delete from Севооборот where Код=" + EID + " ";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    connectBD_user.Close();
                    Init();
                    EID = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connectBD_user.Close();
                }
            }
            else
            {
                MessageBox.Show("Сначала выбирете элемент!");
                connectBD_user.Close();
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            connectBD_user.Close();
            connectBD_user.Dispose();
            this.Close();
        }

        private void dGView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            DataGridViewRow row = null;
            foreach (DataGridViewCell selectedCell in dGView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                row = cell.OwningRow;
                EID = row.Cells[0].Value.ToString();
            }
        }

        private void butExData_Click(object sender, EventArgs e)
        {
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = @"select bs.номер_участка as id_участка,
bk.название as id_культуры,
s.ожидаемый_урожай, 
s.фактический_урожай, 
s.год 
from((Севооборот as s left outer join Участок as bs on s.id_участка = bs.Код)
left outer join Культура as bk on s.id_культуры = bk.Код) ";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                //////////////////////////////////////////////////////////

                Microsoft.Office.Interop.Word.Application objWord = new Microsoft.Office.Interop.Word.Application();
                objWord.Visible = true;
                objWord.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal;

                //create the document
                Microsoft.Office.Interop.Word.Document objDoc = objWord.Documents.Add();

                //Add a paragraph
                Microsoft.Office.Interop.Word.Paragraph objPara;
                objPara = objDoc.Paragraphs.Add();
                ////////////////////////////////////////////////////////

                string str = "\t Участок    Культура    Ожидаемый урожай    Фактический урожай Год\n";
                while (reader.Read())
                {
                    if (reader["год"].ToString() == DateTime.Now.Year.ToString())
                    {
                        //Делать при выводе
                        //create the application
                        str += "\t  " + reader["id_участка"] + "\t    " + reader["id_культуры"] + "\t    " +
                            reader["ожидаемый_урожай"] + "\t\t\t   " + reader["фактический_урожай"] + "\t\t\t  " +
                            reader["год"] + "\n";
                        
                    }
                }
                
                //Вывод в файл
                objPara.Range.Text = str;
                

                connectBD_user.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connectBD_user.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GraficUrojai graf = new GraficUrojai();
            graf.ShowDialog();
            
        }
    }
}

