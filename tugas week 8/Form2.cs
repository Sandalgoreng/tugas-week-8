using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_week_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlconnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlcommand;
        public MySqlDataAdapter sqladapter;
        public string sqlQuery;
        DataTable tabel1 = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dtable1 = new DataTable();
            sqlQuery = "SELECT team_name as 'nama team' , team_id as 'id team ' FROM team ;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtable1);
            cbok1.DataSource = dtable1;
            cbok1.DisplayMember = "nama team";
            cbok1.ValueMember = "id team ";
            DataTable hometeam = new DataTable();
            sqlQuery = "SELECT t.team_name as 'nama team' ,t.team_id, m.match_id FROM team t,`match` m WHERE t.team_id = m.team_home;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(hometeam);
            DataTable awayteam = new DataTable();
            sqlQuery = "SELECT t.team_name as 'nama team' ,t.team_id, m.match_id FROM team t,`match` m WHERE t.team_id = m.team_away;";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(awayteam);

            tabel1.Columns.Add("Match id");
            tabel1.Columns.Add("Home Team");
            tabel1.Columns.Add("Home Team id");
            tabel1.Columns.Add("Away Team");
            tabel1.Columns.Add("Away Team id");
            tabel1.Columns.Add("Judul");
            for (int i = 0; i < awayteam.Rows.Count; i++)
            {

                string matchid = hometeam.Rows[i][2].ToString();
                string home = hometeam.Rows[i][0].ToString();
                string homeid = hometeam.Rows[i][1].ToString();
                string away = awayteam.Rows[i][0].ToString();
                string awayid = awayteam.Rows[i][1].ToString();
                string judul = home + " VS " + away;

                tabel1.Rows.Add(matchid, home, homeid, away, awayid, judul);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void cbok2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string pepek = cbok2.GetItemText(cbok2.SelectedItem);
            string kontol = "";
            string pusing = "";
            string nyerah = "";
            for (int i = 0; i < tabel1.Rows.Count; i++)
            {
                if (pepek == tabel1.Rows[i][5].ToString())
                {
                    kontol = tabel1.Rows[i][0].ToString();
                    p1.Text = tabel1.Rows[i][1].ToString();
                    p2.Text = tabel1.Rows[i][3].ToString();
                    pusing = tabel1.Rows[i][2].ToString();
                    nyerah = tabel1.Rows[i][4].ToString();
                    break;
                }
            }
            DataTable stress = new DataTable();
            sqlQuery = "select m.match_date, m.goal_home, m.goal_away, r.referee_name from `match` m, referee r where r.referee_id = m.referee_id and m.match_id = '" + kontol + "';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(stress);
            lab1.Text = stress.Rows[0][1].ToString();
            lab2.Text = stress.Rows[0][2].ToString();
            label12.Text = stress.Rows[0][3].ToString();
            lab4.Text = stress.Rows[0][0].ToString();


            DataTable blublu = new DataTable();
            sqlQuery = "select p.player_name from player p, team t where t.team_id = p.team_id and t.team_id ='" + pusing + "';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(blublu);
            dataGridView1.DataSource = blublu;


            DataTable blibli = new DataTable();
            sqlQuery = "select p.player_name from player p, team t where t.team_id = p.team_id and t.team_id ='" + nyerah + "';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(blibli);
            dataGridView2.DataSource = blibli;
            DataTable blabla = new DataTable();
            sqlQuery = "select t.team_name, p.player_name, if(d.`type`='GO','Goal',if(d.`type`='GW','Own Goal',if(d.`type`='GP','Penalty Goal',if(d.`type`='PM','Penalty Missed',if(d.`type`='CY','Yellow Card','Red Card'))))) as 'Type', d.`minute` from dmatch d, player p, team t where t.team_id = d.team_id and d.player_id = p.player_id and d.match_id = '" + kontol + "';";
            sqlcommand = new MySqlCommand(sqlQuery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(blabla);
            dataGridView3.DataSource = blabla;
        }
        private void cbok1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbok2.Items.Clear();
            for (int i = 0; i < tabel1.Rows.Count; i++)
            {              
                if (cbok1.GetItemText(cbok1.SelectedItem) == tabel1.Rows[i][1].ToString() || cbok1.GetItemText(cbok1.SelectedItem) == tabel1.Rows[i][3].ToString())
                {
                    cbok2.Items.Add(tabel1.Rows[i][5].ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
