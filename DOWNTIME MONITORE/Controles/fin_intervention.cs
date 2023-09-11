using DOWNTIME_MONITORE.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOWNTIME_MONITORE.Controles
{
    public partial class fin_intervention : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public fin_intervention()
        {
            InitializeComponent();
        }

        private void fin_intervention_Load(object sender, EventArgs e)
        {
            desable_text();
        }
        private void desable_text()
        {
            nom_technicien_text.Enabled = false;
            id_probleme_text.Enabled=false;
            temp_debut_text.Enabled=false;
            contre_partie_text.Enabled=false;
            occupation_text.Enabled=false;
            description_text.Enabled=false;
            fin_interv_btn.Enabled=false;
        }
        private void enable_text()
        {
            contre_partie_text.Enabled = true;
            occupation_text.Enabled = true;
            description_text.Enabled = true;
            fin_interv_btn.Enabled = true;
        }
        private void vider_text()
        {
            nom_technicien_text.Text = "";
            id_probleme_text.Text = "";
            temp_debut_text.Text = "";
            contre_partie_text.Text = "";
            description_text.Text = "";
            occupation_text.Text = "";
            matricule_text.Text = "";
            mot_passe_text.Text = "";
        }
        private void verifier_technicien()
        {
            if(matricule_text.Text !="" && mot_passe_text.Text != "")
            {
                try
                {
                    con.Open();
                    string queryTech_Verifier = $"SELECT COUNT(*) FROM attend WHERE matricule_technicien = @Matricule";
                    string querySelct_Tech = "SELECT t.nom_technicien, p.id_probleme, a.temps_debut " +
                         "FROM attend a " +
                         "JOIN technicien t ON a.matricule_technicien = t.matricule_technicien " +
                         "JOIN probleme p ON a.id_probleme = p.id_probleme " +
                         "WHERE a.matricule_technicien = @matricule AND password = @password";


                    using (SqlCommand commandTech_verifier = new SqlCommand(queryTech_Verifier, con))
                    {
                        commandTech_verifier.Parameters.AddWithValue("@matricule", matricule_text.Text);
                        int matchingRows = (int)commandTech_verifier.ExecuteScalar();

                        if (matchingRows > 0)
                        {
                            using (SqlCommand command_select_tech = new SqlCommand(querySelct_Tech, con))
                            {
                                command_select_tech.Parameters.AddWithValue("@matricule", matricule_text.Text);
                                command_select_tech.Parameters.AddWithValue("@password", mot_passe_text.Text);

                                using (SqlDataReader reader = command_select_tech.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Récupérer les données de la ligne
                                        string nom_technicien = reader.GetString(0);
                                        int id_probleme = reader.GetInt32(1);
                                        TimeSpan tempsDebut = reader.GetTimeSpan(2); // Supposons que la colonne 2 est un TimeSpan

                                        // Formatage du TimeSpan en une chaîne au format "HH:mm:ss"
                                        string tempsDebutStr = tempsDebut.ToString(@"hh\:mm\:ss");

                                        nom_technicien_text.Text = nom_technicien;
                                        id_probleme_text.Text = id_probleme.ToString();
                                        temp_debut_text.Text = tempsDebutStr; // Format personnalisé
                                        matricule_text.Enabled = false;
                                        mot_passe_text.Enabled=false;

                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid matricule or password.");
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
            else
            {
                MessageBox.Show("Remplir votre matricule ou mot de passe");
            }
        }

        private void debut_intervention_btn_Click(object sender, EventArgs e)
        {
            verifier_technicien();
            enable_text();
        }

        private void annuler_btn_Click(object sender, EventArgs e)
        {
            vider_text();
            desable_text();
            matricule_text.Enabled = true;
            mot_passe_text.Enabled = true;
        }
        private void fini_intervention()
        {
            if (occupation_text.Text != "" && contre_partie_text.Text != "" && description_text.Text != "")
            {
                try
                {
                    con.Open();
                    DateTime heure = DateTime.Now;
                    DateTime currentDates = DateTime.Now;
                    string formattedDates = currentDates.ToString("yyyy-MM-dd");

                    string queryInsert_intervention =
                        "INSERT INTO intervention (id_probleme, matricule_technicien, temps_debut, temps_fin, date_intervention, description, contre_partie, occupation) " +
                        "VALUES (@id_probleme, @matricule_tech, @temps_debut, @temps_fin, @date_intervention, @description, @contre_partie, @occupation)";

                    string queryDelete = "DELETE FROM attend WHERE id_probleme = @id_probleme";

                    using (SqlCommand commandInsert = new SqlCommand(queryInsert_intervention, con))
                    {
                        commandInsert.Parameters.AddWithValue("@id_probleme", id_probleme_text.Text);
                        commandInsert.Parameters.AddWithValue("@matricule_tech", matricule_text.Text);
                        commandInsert.Parameters.AddWithValue("@temps_debut", temp_debut_text.Text);
                        commandInsert.Parameters.AddWithValue("@temps_fin", heure.ToString("HH:mm:ss"));
                        commandInsert.Parameters.AddWithValue("@date_intervention", formattedDates);
                        commandInsert.Parameters.AddWithValue("@description", description_text.Text);
                        commandInsert.Parameters.AddWithValue("@contre_partie", contre_partie_text.Text);
                        commandInsert.Parameters.AddWithValue("@occupation", occupation_text.Text);

                        int rowsInserted = commandInsert.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            using (SqlCommand commandDelete = new SqlCommand(queryDelete, con))
                            {
                                commandDelete.Parameters.AddWithValue("@id_probleme", id_probleme_text.Text);
                                commandDelete.ExecuteNonQuery();
                            }

                            MessageBox.Show("Intervention terminée avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement inséré.");
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
            else
            {
                MessageBox.Show("Remplir tous les champs obligatoires.");
            }
        }


        private void fin_interv_btn_Click(object sender, EventArgs e)
        {
            fini_intervention();
            vider_text();
            desable_text();
            matricule_text.Enabled = true;
            mot_passe_text.Enabled = true;
        }

        private void contre_partie_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si le caractère n'est pas un chiffre ou une touche de contrôle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorer le caractère
            }
        }

        private void occupation_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si le caractère n'est pas un chiffre ou une touche de contrôle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorer le caractère
            }
        }
    }
}
