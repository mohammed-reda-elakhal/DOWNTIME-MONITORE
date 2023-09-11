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
    public partial class probleme_ad : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public probleme_ad()
        {
            InitializeComponent();
        }

        private void probleme_ad_Load(object sender, EventArgs e)
        {
            afficher_dataGrid_problem();
            designe_dataGrid();
        }
        private void designe_dataGrid()
        {
            data_production.DefaultCellStyle.ForeColor = Color.Black;
            // Changer la taille de la police des cellules
            data_production.DefaultCellStyle.Font = new Font("Cascadia Code", 10, FontStyle.Regular);
            data_production.ColumnHeadersDefaultCellStyle.Font = new Font("Cascadia Code", 10, FontStyle.Regular);
            data_production.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

        }
        public void afficher_dataGrid_problem()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT [date],[temps],[shift],[id_probleme],[matricule],[nom_ligne],[nom_probleme],[nom_station],[is_donne] from probleme where is_donne = 0 ORDER BY date DESC, temps DESC", con);
            DataTable dt = new DataTable();
            dt = new DataTable();
            ad.Fill(dt);
            data_production.DataSource = dt;
            data_production.Enabled = false;

        }
    }
}
