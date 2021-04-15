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
    public partial class GraficUrojai : Form
    {
        private OleDbConnection connectBD_user = new OleDbConnection();
        public GraficUrojai()
        {
            connectBD_user.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=BD_user.mdb;Persist Security Info = False;Jet OLEDB:Database Password=1";
            InitializeComponent();
            Load_ID_Kult();
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

        private bool isLeftButtonPressed = false;
        private Point mouseDown = Point.Empty;

      
        private void comBKult_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            

            string EIDKult = null;
            try
            {
                connectBD_user.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectBD_user;

                string query = "select Код from Культура where название = '"+comBKult.Text+"'";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                
                int count = 0;
                while (reader.Read())
                {
                    EIDKult = reader["Код"].ToString();
                    count++;
                }               
                
                if(EIDKult != null)
                {
                    //Если нашёл нужную культуру
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connectBD_user;

                    string query1 = "select * from Севооборот where id_культуры = "+EIDKult+"";
                    command1.CommandText = query1;
                    OleDbDataReader reader1 = command1.ExecuteReader();

                    List<double> Age = new List<double>();
                    List<double> Value = new List<double>();                    

                    
                    while (reader1.Read())
                    {
                        
                        Age.Add(Convert.ToDouble(reader1["год"].ToString()));
                        Value.Add(Convert.ToDouble(reader1["фактический_урожай"].ToString()));
                    }                    

                    for (int i = 0; i < Age.Count; i++)
                    {
                        for(int j = i + 1; j < Age.Count; j++)
                        {
                            if(Age[i] == Age[j])
                            {
                                Value[i] += Value[j];
                                Age.RemoveAt(j);
                                Value.RemoveAt(j);
                            }
                        }
                    }
                    chart1.Series.Add("Культура");
                    
                    for(int i =0; i <Age.Count; i++)
                    {
                        chart1.Series["Культура"].Points.AddXY(Age[i], Value[i]);
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

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftButtonPressed)
            {
                var result = chart1.HitTest(e.X, e.Y);

                if (result.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.PlottingArea)
                {
                    var oldXValue = result.ChartArea.AxisX.PixelPositionToValue(mouseDown.X);
                    var newXValue = result.ChartArea.AxisX.PixelPositionToValue(e.X);

                    chart1.ChartAreas[0].AxisX.ScaleView.Position += oldXValue - newXValue;
                    mouseDown.X = e.X;
                }
            }
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonPressed = true;
                mouseDown = e.Location;

            }
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                isLeftButtonPressed = false;
                mouseDown = Point.Empty;
            }
        }
    }
}
