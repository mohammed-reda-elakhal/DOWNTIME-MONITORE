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
    public partial class occupation : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public occupation()
        {
            InitializeComponent();
        }

        private void occupation_Load(object sender, EventArgs e)
        {
            afficher_data_attend();
        }
        public void afficher_data_attend()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT  p.id_probleme, p.temps, p.date, p.matricule, p.shift, p.nom_ligne, p.nom_station, p.nom_probleme , t.nom_technicien, a.temps_debut from attend a join probleme p ON a.id_probleme = p.id_probleme JOIN technicien t ON a.matricule_technicien = t.matricule_technicien where p.is_donne = 1 ORDER BY p.date DESC, a.temps_debut DESC", con);
            DataTable dt = new DataTable();
            dt = new DataTable();
            ad.Fill(dt);
            data_attend.DataSource = dt;
            data_attend.Enabled = false;
        }
    }
}
