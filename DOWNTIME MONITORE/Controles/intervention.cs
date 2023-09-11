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
    public partial class intervention : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public intervention()
        {
            InitializeComponent();
        }

        private void intervention_Load(object sender, EventArgs e)
        {
            afficher_intervention();
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
    }
}
