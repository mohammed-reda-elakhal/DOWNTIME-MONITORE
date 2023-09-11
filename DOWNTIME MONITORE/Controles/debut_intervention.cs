using DOWNTIME_MONITORE.classe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOWNTIME_MONITORE.Controles
{
    public partial class debut_intervention : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public debut_intervention()
        {
            InitializeComponent();
        }

        private void debut_intervention_Load(object sender, EventArgs e)
        {
            afficher_dataGrid_problem();
            designe_dataGrid();
            afficher_id_probleme();

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
        private void afficher_id_probleme()
        {
            try
            {
                con.Open();
                string query = "SELECT id_probleme from probleme where is_donne = 0 ORDER BY date DESC, temps DESC";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Récupérer l'ID
                            int id = reader.GetInt32(0);


                            // Ajouter l'ID au ComboBox
                            id_combo.Items.Add(id);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void afficher_data_info()
        {
            try
            {
                con.Open();
                string query = $"SELECT id_probleme , nom_ligne , nom_station , nom_probleme from probleme where id_probleme = {id_combo.Text} and is_donne = 0 ORDER BY date DESC, temps DESC";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupérer les données de la ligne
                            int id_probleme = reader.GetInt32(0);
                            string ligne = reader.GetString(1);
                            string station = reader.GetString(2);
                            string probleme = reader.GetString(3);

                            // Affecter les données aux labels
                            nmr_probleme_text.Text = id_probleme.ToString();
                            station_text.Text = station;
                            ligne_text.Text = ligne;
                            probleme_text.Text = probleme;
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

        private void id_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(id_combo.Text != "")
            {
                afficher_data_info();
            }
        }

        private void insert_attend()
        {
            if(matricule_text.Text !="" && mot_passe_text.Text != "" && id_combo.Text != "")
            {
                try
                {
                    con.Open();
                    string queryInsert = $"insert into attend (id_probleme , matricule_technicien , temps_debut) " +
                        $"values (@id_probleme , @matricule, @temps_debut )";
                    string queryUpdate = $"update probleme SET is_donne = {1} where id_probleme = {id_combo.Text}";

                    string queryTech = $"SELECT COUNT(*) FROM technicien WHERE matricule_technicien =@Matricule  AND password =@Password";
                    string queryTech_Verifier = $"SELECT COUNT(*) FROM attend WHERE matricule_technicien =@Matricule";
                    using (SqlCommand commandTech_verifier = new SqlCommand(queryTech_Verifier, con))
                    {
                        commandTech_verifier.Parameters.AddWithValue("@Matricule", matricule_text.Text);
                        int matchingRows = (int)commandTech_verifier.ExecuteScalar();
                        if (matchingRows == 0)
                        {
                            using (SqlCommand commandTech = new SqlCommand(queryTech, con))
                            {

                                commandTech.Parameters.AddWithValue("@Matricule", matricule_text.Text);
                                commandTech.Parameters.AddWithValue("@Password", mot_passe_text.Text);
                                matchingRows = (int)commandTech.ExecuteScalar();

                                if (matchingRows > 0)
                                {
                                    using (SqlCommand command = new SqlCommand(queryInsert, con))
                                    {
                                        command.Parameters.AddWithValue("@temps_debut", DateTime.Now.ToString("HH:mm:ss"));
                                        command.Parameters.AddWithValue("@matricule", matricule_text.Text);
                                        command.Parameters.AddWithValue("@id_probleme", id_combo.Text);
                                        int rowsAffected = command.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            using (SqlCommand command2 = new SqlCommand(queryUpdate, con))
                                            {
                                                command2.ExecuteNonQuery();
                                                vider_inputs_data();
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
                        else
                        {
                            MessageBox.Show("cette technicien déja occuper");
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
                MessageBox.Show("Veuillez choisir le numero de probleme ou remplair tous les données");
            }

        }

        private void debut_intervention_btn_Click(object sender, EventArgs e)
        {
            insert_attend();
            afficher_dataGrid_problem();
            id_combo.Items.Clear();
            afficher_id_probleme();
        }
        private void vider_inputs_data()
        {
            id_combo.SelectedIndex = -1;
            matricule_text.Text = "";
            mot_passe_text.Text = "";
            ligne_text.Text = "";
            station_text.Text = "";
            probleme_text.Text = "";
            nmr_probleme_text.Text = "";
        }
    }

}
