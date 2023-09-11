using DOWNTIME_MONITORE.classe;
using Microsoft.Office.Interop.Excel;
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
    public partial class corbie : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public corbie()
        {
            InitializeComponent();
        }

        private void corbie_Load(object sender, EventArgs e)
        {
            afficher_intervention();
            afficher_ligne();
            afficher_station();
            afficher_technicien();
        }
        public void afficher_intervention()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT [id_probleme]\r\n      ,[date]\r\n      ,[temps]\r\n      ,[matricule]\r\n      ,[shift]\r\n      ,[nom_ligne]\r\n      ,[nom_probleme]\r\n      ,[nom_station]\r\n      ,[nom_technicien]\r\n      ,[matricule_technicien]\r\n      ,[temps_debut]\r\n      ,[temps_fin]\r\n      ,[date_intervention]\r\n      ,[description]\r\n      ,[contre_partie]\r\n      ,[occupation]\r\n  FROM [dbo].[intervention_archive]", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);
            data_intervention.DataSource = dt;
            data_intervention.Enabled = false;
        }
        private void afficher_ligne()
        {
            String sql = "Select nom_ligne from nom_ligne";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            System.Data.DataTable dt = new System.Data.DataTable();
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
            System.Data.DataTable dt = new System.Data.DataTable();
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
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            technicien_combo.DataSource = dt;
            technicien_combo.DisplayMember = "nom_technicien";
            technicien_combo.ValueMember = "nom_technicien";
            technicien_combo.SelectedIndex = -1;
        }
        private void search_intervention()
        {
            string query = " SELECT [id_probleme]\r\n      ,[date]\r\n      ,[temps]\r\n      ,[matricule]\r\n      ,[shift]\r\n      ,[nom_ligne]\r\n      ,[nom_probleme]\r\n      ,[nom_station]\r\n      ,[nom_technicien]\r\n      ,[matricule_technicien]\r\n      ,[temps_debut]\r\n      ,[temps_fin]\r\n      ,[date_intervention]\r\n      ,[description]\r\n      ,[contre_partie]\r\n      ,[occupation]\r\n  FROM [dbo].[intervention_archive]" +
                            "WHERE date_intervention BETWEEN @date1 and @date2 " +
                            "AND nom_ligne LIKE @ligne and nom_station LIKE @station " +
                            "and nom_technicien LIKE @technicien and shift LIKE @shift ";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);
            ad.SelectCommand.Parameters.AddWithValue("@shift", "%" + shift_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@ligne", "%" + ligne_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@station", "%" + station_combo.Text + "%");
            ad.SelectCommand.Parameters.AddWithValue("@technicien", "%" + technicien_combo.Text + "%");
            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data_intervention.DataSource = dt;
            data_intervention.Enabled = false;
        }
        private void vider_inputs()
        {
            ligne_combo.SelectedIndex = -1;
            station_combo.SelectedIndex = -1;
            shift_combo.SelectedIndex = -1;
            technicien_combo.SelectedIndex = -1;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_intervention();
            vider_inputs();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            afficher_intervention();
            vider_inputs();
        }
    }
}
