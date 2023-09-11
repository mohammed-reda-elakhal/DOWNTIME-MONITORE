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

namespace DOWNTIME_MONITORE.admin
{
    public partial class intervention_ad : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public intervention_ad()
        {
            InitializeComponent();
        }

        private void intervention_ad_Load(object sender, EventArgs e)
        {
            afficher_intervention();
            afficher_ligne();
            afficher_station();
            afficher_technicien();
        }
        public void afficher_intervention()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT p.id_probleme , p.shift , p.date , p.temps , p.matricule , p.nom_ligne , p.nom_station , p.nom_probleme , t.nom_technicien , t.matricule_technicien , i.date_intervention , i.temps_debut , i.temps_fin , i.occupation , i.contre_partie , i.description from intervention i join probleme p on i.id_probleme = p.id_probleme join technicien t on t.matricule_technicien = i.matricule_technicien where is_donne = 1 ORDER BY date DESC, temps DESC", con);
            DataTable dt = new DataTable();
            dt = new DataTable();
            ad.Fill(dt);
            data_intervention.DataSource = dt;
            data_intervention.Enabled = false;
        }
        private void afficher_ligne()
        {
            String sql = "Select nom_ligne from nom_ligne";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ligne_combo.DataSource = dt;
            ligne_combo.DisplayMember = "nom_ligne";
            ligne_combo.ValueMember = "nom_ligne";
            ligne_combo.SelectedIndex = -1;
        }
        private void afficher_station()
        {
            string sql = "Select nom_station from nom_station";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            station_combo.DataSource = dt;
            station_combo.DisplayMember = "nom_station";
            station_combo.ValueMember = "nom_station";
            station_combo.SelectedIndex = -1;
        }
        private void afficher_technicien()
        {
            string sql = "Select nom_technicien from technicien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            technicien_combo.DataSource = dt;
            technicien_combo.DisplayMember = "nom_technicien";
            technicien_combo.ValueMember = "nom_technicien";
            technicien_combo.SelectedIndex = -1;
        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            afficher_intervention();
            vider_inputs();
        }
        private void search_intervention()
        {
            string query = "SELECT p.id_probleme, p.shift, p.date, p.temps, p.matricule, p.nom_ligne, p.nom_station, " +
                           "p.nom_probleme, t.nom_technicien, t.matricule_technicien, i.date_intervention, " +
                           "i.temps_debut, i.temps_fin, i.occupation, i.contre_partie, i.description " +
                           "FROM intervention i " +
                           "JOIN probleme p ON i.id_probleme = p.id_probleme " +
                           "JOIN technicien t ON t.matricule_technicien = i.matricule_technicien " +
                           "WHERE i.date_intervention BETWEEN @date1 and @date2 " +
                           "AND p.nom_ligne LIKE @ligne and p.nom_station LIKE @station " +
                           "and t.nom_technicien LIKE @technicien and p.shift LIKE @shift " +
                           "AND is_donne = 1 " +
                           "ORDER BY date DESC, temps DESC";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);
            ad.SelectCommand.Parameters.AddWithValue("@shift", "%" + shift_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@ligne", "%" + ligne_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@station", "%" + station_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@technicien", "%" + technicien_combo.Text + "%");
            DataTable dt = new DataTable();
            ad.Fill(dt);

            data_intervention.DataSource = dt;
            data_intervention.Enabled = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_intervention();
            vider_inputs();
        }
        private void vider_inputs()
        {
            ligne_combo.SelectedIndex = -1;
            station_combo.SelectedIndex = -1;
            shift_combo.SelectedIndex = -1;
            technicien_combo.SelectedIndex = -1;
        }
      
    }
}
