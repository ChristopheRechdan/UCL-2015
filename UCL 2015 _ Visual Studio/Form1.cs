using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace UCL_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Leagues", Properties.Settings.Default.connsettings);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            this.Leagues_disp.DataSource = dataSet.Tables[0];
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            String txt = "'" + this.Leagues_text.Text + "'";
            String txt1 = "SELECT Teams.Team_ID, Teams.Team_Name,Teams.Clean_Sheets, Teams.Standing\r\nFROM Leagues INNER JOIN League_Teams\r\nON Leagues.League_ID = League_Teams.League_ID\r\nINNER JOIN Teams\r\nON Teams.Team_ID = League_Teams.Team_ID\r\nWHERE Leagues.League =" + txt;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(txt1, Properties.Settings.Default.connsettings);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            this.dataGridView2.DataSource = dataSet.Tables[0];
        }


        private void SP_button_Click(object sender, EventArgs e)
        {
            String txt = "SELECT Player_Stats.FirstName, Player_Stats.LastName, Player_Stats.Nationality, Player_Stats.Nb_goals, Position.Position, Position.Stance\r\nFROM Teams INNER JOIN Player_Stats\r\nON Teams.Team_ID = Player_Stats.Player_ID\r\nINNER JOIN Position\r\nON Player_Stats.Position = Position.Number\r\nWhere Teams.Team_Name = '" + this.SP_text.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(txt, Properties.Settings.Default.connsettings);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            this.SP_disp.DataSource = dataSet.Tables[0];
        }

        private void SP_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SP_disp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }       

    }
}