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
using System.Windows.Forms.DataVisualization.Charting;

namespace DOWNTIME_MONITORE.admin
{
    public partial class analyse : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public analyse()
        {
            InitializeComponent();
        }

        private void analyse_Load(object sender, EventArgs e)
        {
            afficher_analyse();
            afficher_analyse_top5();
        }
        private void afficher_analyse_top5()
        {
            string query = "WITH LigneTTL AS (\r\n    SELECT\r\n        p.nom_ligne,\r\n        p.nom_probleme,\r\n        SUM(DATEDIFF(MINUTE, p.temps, i.temps_fin)) AS TTL,\r\n        ROW_NUMBER() OVER (PARTITION BY p.nom_ligne ORDER BY SUM(DATEDIFF(MINUTE, p.temps, i.temps_fin)) DESC) AS RowNum\r\n    FROM intervention i\r\n    JOIN probleme p ON p.id_probleme = i.id_probleme\r\n\twhere i.date_intervention between @date1 and @date2\r\n    GROUP BY p.nom_ligne, p.nom_probleme\r\n)\r\nSELECT TOP 5\r\n    nom_ligne,\r\n    TTL,\r\n    nom_probleme\r\nFROM LigneTTL\r\nWHERE RowNum = 1\r\nORDER BY TTL DESC;";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            data_top5.DataSource = dt;
            data_top5.Enabled = false;

        }
        private void afficher_analyse()
        {
            string query = "SELECT p.nom_ligne, " +
                "SUM(DATEDIFF(MINUTE,p.temps, " +
                "i.temps_fin)) AS TTL , COUNT(DISTINCT p.shift) as Nombre_shift ," +
                "7.33 AS Taxes , " +
                "DATEDIFF(day,@date1, @date2) AS day_travaille ," +
                "(COUNT(DISTINCT p.shift) * 7.33 * DATEDIFF(day,@date1, @date2)) As heur_travailler," +
                "CAST((SUM(DATEDIFF(MINUTE,p.temps, i.temps_fin))/(60*(COUNT(DISTINCT p.shift) * 7.33 * 1))) * 100 AS DECIMAL(10,2)) as DOWNTIME," +
                "2.5 as target ," +
                "CAST((((7.33*60)-SUM(DATEDIFF(MINUTE,p.temps, i.temps_fin)))/(7.33*60)) * 100 as DECIMAL(10,2)) as disponibilité" +
                " FROM intervention i JOIN probleme p ON p.id_probleme = i.id_probleme " +
                "where i.date_intervention between @date1 and @date2 " +
                "GROUP BY p.nom_ligne";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            ad.SelectCommand.Parameters.AddWithValue("@date2", date2.Value);
           
            DataTable dt = new DataTable();
            ad.Fill(dt);

            data_analyse.DataSource = dt;
            data_analyse.Enabled = false;
           
        }

        private void AfficherDonneesSurChart()
        {
            string query = "SELECT p.nom_ligne, " +
                "CAST((SUM(DATEDIFF(MINUTE,p.temps, i.temps_fin))/(60*(COUNT(DISTINCT p.shift) * 7.33 * 1))) * 100 AS DECIMAL(10,2)) as DOWNTIME " +
                "FROM intervention i JOIN probleme p ON p.id_probleme = i.id_probleme " +
                "WHERE i.date_intervention BETWEEN @date1 AND @date2 " +
                "GROUP BY p.nom_ligne";

          

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date1", date1.Value);
                cmd.Parameters.AddWithValue("@date2", date2.Value);


                chart1.Series.Clear();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nomLigne = reader["nom_ligne"].ToString();
                    decimal downtime = Convert.ToDecimal(reader["DOWNTIME"]);

                    Series serie = new Series(nomLigne);
                    serie.Points.AddXY(nomLigne, downtime);

                    chart1.Series.Add(serie);

            }
                con.Close();
            }

            chart1.ChartAreas[0].AxisX.Title = "Ligne";
            chart1.ChartAreas[0].AxisY.Title = "Downtime (%)";

           
        }


        private void accueil_btn_Click(object sender, EventArgs e)
        {
            afficher_analyse();
            afficher_analyse_top5();
            AfficherDonneesSurChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (data_analyse.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i <= data_analyse.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = data_analyse.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data_analyse.Rows.Count; i++)
                {
                    for (int j = 0; j < data_analyse.Columns.Count; j++)
                    {
                        if (data_analyse.Rows[i].Cells[j].Value != null)
                        {
                            MExcel.Cells[i + 2, j + 1] = data_analyse.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            MExcel.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_top5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
