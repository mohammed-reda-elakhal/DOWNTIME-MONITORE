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
    public partial class accueil : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public accueil()
        {
            InitializeComponent();
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            afficher_nbr_probeleme();
            afficher_nbr_intervention();
            afficher_nbr_occupation();
        }
        private void afficher_nbr_probeleme()
        {
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM probleme WHERE date = @date";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@date", DateTime.Now.Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupérer les données de la ligne
                            int probleme = reader.GetInt32(0);

                            // Affecter les données aux labels
                            probleme_label.Text = probleme.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void afficher_nbr_occupation()
        {
            try
            {
                con.Open();
                string query = "select COUNT(a.id_probleme) from attend a join probleme p on p.id_probleme = a.id_probleme where p.date=@date ";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@date", DateTime.Now.Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupérer les données de la ligne
                            int occupation = reader.GetInt32(0);

                            // Affecter les données aux labels
                            occupation_label.Text = occupation.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void afficher_nbr_intervention()
        {
            try
            {
                con.Open();
                string query = "select COUNT(*) from intervention where date_intervention=@date";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@date", DateTime.Now.Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupérer les données de la ligne
                            int intervention = reader.GetInt32(0);

                            // Affecter les données aux labels
                            intervention_label.Text = intervention.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void accueil_btn_Click(object sender, EventArgs e)
        {
            problemes p = new problemes();
            p.Visible = true;
        }

        private void occupation_btn_Click(object sender, EventArgs e)
        {
            problemes p = new problemes();
            p.Visible = true;
        }

        private void interv_btn_Click(object sender, EventArgs e)
        {
            problemes p = new problemes();
            p.Visible = true;
        }
    }
}
