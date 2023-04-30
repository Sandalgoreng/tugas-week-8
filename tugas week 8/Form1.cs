using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace tugas_week_8
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=premier_league";
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string bapakkao;
        DataTable qq = new DataTable();
        DataTable ww = new DataTable();
        DataTable ee = new DataTable();
        DataTable rr = new DataTable();
        string team_id = "";
        string player = "";
        string team = "";
        string player_id = "";
        int kartuk=0;
        int kartum =0;
        int gooal= 0;
        int owngol =0;
        int penalti = 0;
        int gamasok = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbok1.Visible = true;
            SqlConnection = new MySqlConnection(connection); 
            SqlConnection.Open(); 
            bapakkao = "SELECT team_name as `team`,team_id as`id_team`FROM team;"; 
            SqlCommand = new MySqlCommand(bapakkao, SqlConnection); 
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand); 
            SqlDataAdapter.Fill(qq);
            cbok1.DataSource=qq;
            cbok1.DisplayMember = "team";
            cbok1.ValueMember = "id_team";
        }

        private void cbok1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            team_id = cbok1.SelectedValue.ToString();
            ww=new DataTable();
            bapakkao = "SELECT player_name as `player` , player_id as `id` from player p where p.team_id = \""+team_id+"\";";
            SqlCommand = new MySqlCommand(bapakkao, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(ww);
            cbok2.DataSource=ww;
            cbok2.DisplayMember = "player";
            cbok2.ValueMember = "id";
            cbok2.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbok2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            team = cbok1.GetItemText(cbok1.SelectedItem);
            player = cbok2.GetItemText(cbok2.SelectedItem);
            ee=new DataTable();
            bapakkao = "SELECT player_name as `name`, team_name as `team`, playing_pos as `pos`, nation as `national`, team_number as `number` from player p, nationality n, team t where p.player_name = \""+player+"\" and t.team_name =\""+team+"\" and p.nationality_id = n.nationality_id;\r\n";
            SqlCommand = new MySqlCommand(bapakkao, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(ee);

            nama.Visible = true;
            tteam.Visible = true;
            posisi.Visible = true;
            negara.Visible = true;
            nomorp.Visible = true;
            kkuning.Visible = true;
            kmerah.Visible = true;
            goal.Visible = true;
            owngoal.Visible = true;
            pinalti.Visible = true;
            gakgol.Visible = true;

            nama.Text = ee.Rows[0][0].ToString();
            tteam.Text = ee.Rows[0][1].ToString();
            posisi.Text = ee.Rows[0][2].ToString();
            negara.Text = ee.Rows[0][3].ToString();
            nomorp.Text = ee.Rows[0][4].ToString();
            
            player_id = cbok2.SelectedValue.ToString();
            rr = new DataTable();
            bapakkao = "SELECT `type` as `kartu` from dmatch d where d.player_id = \"" + player_id + "\";";
            SqlCommand = new MySqlCommand(bapakkao, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(rr);
            kartuk = 0;
            kartum = 0;
            gooal = 0;
            owngol = 0;
            gamasok = 0;
            penalti = 0;
            for(int i = 0; i < rr.Rows.Count; i++)
            {
                if (rr.Rows[i][0].ToString() =="CY")
                {
                    kartuk++;
                }
                if (rr.Rows[i][0].ToString() == "CR")
                {
                    kartum++;
                }
                if (rr.Rows[i][0].ToString() == "GO")
                {
                    gooal++;
                }
                if (rr.Rows[i][0].ToString() == "GW")
                {
                    owngol++;
                }
                if (rr.Rows[i][0].ToString() == "PM")
                {
                    gamasok++;
                }
                if (rr.Rows[i][0].ToString() == "GP")
                {
                    penalti++;
                }
            }
            kkuning.Text= kartuk.ToString();
            kmerah.Text= kartum.ToString();
            goal.Text = gooal.ToString();
            owngoal.Text= owngol.ToString();
            pinalti.Text = penalti.ToString();
            gakgol.Text= gamasok.ToString();
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ahay = new Form2();
            ahay.Show();
        }
    }
}
