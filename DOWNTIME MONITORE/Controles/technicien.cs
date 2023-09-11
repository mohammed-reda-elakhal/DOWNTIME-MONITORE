using DOWNTIME_MONITORE.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOWNTIME_MONITORE.Controles
{
    public partial class technicien : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());

        public technicien()
        {
            InitializeComponent();
        }

        private void technicien_Load(object sender, EventArgs e)
        {
            afficher_dataGrid_problem();
        }
        private void afficher_dataGrid_problem()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT [date],[temps],[shift],[id_probleme],[matricule],[nom_ligne],[nom_probleme],[nom_station],[is_donne] from probleme where is_donne = 0 ORDER BY date DESC, temps DESC", con);
            DataTable dt = new DataTable();
            dt = new DataTable();
            ad.Fill(dt);
            //data_probleme.DataSource = dt;
            //data_probleme.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void probleme_btn_Click(object sender, EventArgs e)
        {
            debut_intervention1.Visible = true;
            debut_intervention1.afficher_dataGrid_problem();
            occupation1.Visible = false;
            fin_intervention1.Visible = false;

            intervention1.Visible = false;
        }

        private void fin_intervention_btn_Click(object sender, EventArgs e)
        {
            debut_intervention1.Visible = false;
            occupation1.Visible = false;
            fin_intervention1.Visible = true;

            intervention1.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void occupation_btn_Click(object sender, EventArgs e)
        {
            occupation1.Visible = true;
            debut_intervention1.Visible = false;
            occupation1.afficher_data_attend();
            fin_intervention1.Visible = false;
            intervention1.Visible = false;
        }

        private void fin_intervention1_Load(object sender, EventArgs e)
        {

        }

        private void intervention_btn_Click(object sender, EventArgs e)
        {
            intervention1.Visible = true;
            occupation1.Visible = false;
            debut_intervention1.Visible = false;
            fin_intervention1.Visible = false;
            intervention1.afficher_intervention();
        }

        private void fermer_btn_Click(object sender, EventArgs e)
        {
            intervention1.Visible = false;
            occupation1.Visible = false;
            debut_intervention1.Visible = false;
            fin_intervention1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            intervention1.Visible = false;
            occupation1.Visible = false;
            debut_intervention1.Visible = false;
            fin_intervention1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            technicien_guide1.Visible = true;
        }
    }
}
