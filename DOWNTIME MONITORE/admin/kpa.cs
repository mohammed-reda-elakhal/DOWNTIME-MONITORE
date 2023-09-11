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
using System.Windows.Forms.DataVisualization.Charting;

namespace DOWNTIME_MONITORE.admin
{
    public partial class kpa : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public kpa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kpa_Load(object sender, EventArgs e)
        {
            afficher_mttr();
            afficher_mtbf();
        }
        private void afficher_mttr()
        {
            string query = "select p.nom_ligne ,(SUM(DATEDIFF(MINUTE,p.temps, i.temps_fin))/COUNT(p.nom_probleme)+1) AS mttr  " +
                "from intervention i join probleme p on p.id_probleme = i.id_probleme " +
                "where i.date_intervention between @date1 and @date2 " +
                "group by p.nom_ligne ";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);

            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data_mttr.DataSource = dt;
            data_mttr.Enabled = false;
        }
        private void afficher_mtbf()
        {
            string query = "select p.nom_ligne ,(SUM(DATEDIFF(MINUTE,i.temps_debut, i.temps_fin))/COUNT(p.nom_probleme)+1) AS mtbf  " +
              "from intervention i join probleme p on p.id_probleme = i.id_probleme " +
              "where i.date_intervention between @date1 and @date2 " +
              "group by p.nom_ligne ";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);

            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data_mtbf.DataSource = dt;
            data_mtbf.Enabled = false;
        }

        private void accueil_btn_Click(object sender, EventArgs e)
        {
            afficher_mttr();
            afficher_mtbf();
            Afficher_chart_mttr();
            Afficher_chart_mtbf();
        }
        private void Afficher_chart_mttr()
        {
            string query = "select p.nom_ligne ,(SUM(DATEDIFF(MINUTE,p.temps, i.temps_fin))/COUNT(p.nom_probleme)+1) AS mttr  " +
                "from intervention i join probleme p on p.id_probleme = i.id_probleme " +
                "where i.date_intervention between @date1 and @date2 " +
                "group by p.nom_ligne ";



            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date1", date1.Value);
            cmd.Parameters.AddWithValue("@date2", date2.Value);


            chart_mttr.Series.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nomLigne = reader["nom_ligne"].ToString();
                    decimal MTTR = Convert.ToDecimal(reader["mttr"]);

                    System.Windows.Forms.DataVisualization.Charting.Series serie = new System.Windows.Forms.DataVisualization.Charting.Series(nomLigne);
                    serie.Points.AddXY(nomLigne, MTTR);

                    chart_mttr.Series.Add(serie);
                }
                con.Close();
            }

            chart_mttr.ChartAreas[0].AxisX.Title = "Ligne";
            chart_mttr.ChartAreas[0].AxisY.Title = "MTTR (min)";


        }
        private void Afficher_chart_mtbf()
        {
            string query = "select p.nom_ligne ,(SUM(DATEDIFF(MINUTE,i.temps_debut, i.temps_fin))/COUNT(p.nom_probleme)+1) AS mtbf  " +
              "from intervention i join probleme p on p.id_probleme = i.id_probleme " +
              "where i.date_intervention between @date1 and @date2 " +
              "group by p.nom_ligne ";



            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date1", date1.Value);
            cmd.Parameters.AddWithValue("@date2", date2.Value);


            chart_mtbf.Series.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nomLigne = reader["nom_ligne"].ToString();
                    decimal MTBF = Convert.ToDecimal(reader["mtbf"]);

                    System.Windows.Forms.DataVisualization.Charting.Series serie = new System.Windows.Forms.DataVisualization.Charting.Series(nomLigne);
                    serie.Points.AddXY(nomLigne, MTBF);

                    chart_mtbf.Series.Add(serie);
                }
                con.Close();
            }

            chart_mtbf.ChartAreas[0].AxisX.Title = "Ligne";
            chart_mtbf.ChartAreas[0].AxisY.Title = "MTBF (min)";


        }
    }
}
