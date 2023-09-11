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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOWNTIME_MONITORE.admin
{
    public partial class modification : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        public modification()
        {
            InitializeComponent();
        }
        private void modification_Load(object sender, EventArgs e)
        {
           
        }
        
        private void vider_text()
        {
            matricule_text.Text = "";
            password_text.Text = "";
            nom_text.Text = "";
        }
        private void ligne_btn_Click(object sender, EventArgs e)
        {
            titre_label.Text = "Ligne";
            afficherinputs_tech();
            afficher_ligne();
            vider_text();
        }

        private void station_btn_Click(object sender, EventArgs e)
        {
            titre_label.Text = "Station";
            afficherinputs_tech();
            afficher_station();
            vider_text();
        }
        private void user_btn_Click(object sender, EventArgs e)
        {
            afficher_user();
            titre_label.Text = "Utilisateur";
            afficherinputs_tech();
            vider_text();
        }
        private void probleme_btn_Click(object sender, EventArgs e)
        {
            titre_label.Text = "Probleme";
            afficherinputs_tech();
            afficher_probleme();
            vider_text();
        }

        private void technicien_btn_Click(object sender, EventArgs e)
        {
            titre_label.Text = "Technicien";
            afficherinputs_tech();
            afficher_technicien();
            vider_text();
        }
        private void afficherinputs_tech()
        {
            if (titre_label.Text == "Technicien" || titre_label.Text == "Utilisateur")
            {
                visible_tech_inputs();
            }
            else
            {
                invisible_tech_inputs();
            }
        }
        private void visible_tech_inputs()
        {
            matricule_label.Visible = true;
            matricule_text.Visible = true;
            password_label.Visible = true;
            password_text.Visible = true;
        }
        private void invisible_tech_inputs()
        {
            matricule_label.Visible = false;
            matricule_text.Visible = false;
            password_label.Visible = false;
            password_text.Visible = false;
        }
        private void afficher_ligne()
        {
            string query = "SELECT [nom_ligne] FROM [dbo].[nom_ligne]";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            //ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);
            
            
            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data.DataSource = dt;
        }
        private void afficher_station()
        {
            string query = "SELECT [nom_station]\r\n  FROM [dbo].[nom_station]";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            //ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);


            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data.DataSource = dt;

        }
        private void afficher_probleme()
        {
            string query = "SELECT [nom_probleme]\r\n  FROM [dbo].[nom_probleme]";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            //ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);


            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data.DataSource = dt;

        }
        private void afficher_technicien()
        {
            string query = "SELECT [matricule_technicien]\r\n      ,[nom_technicien]\r\n      ,[password]\r\n  FROM [dbo].[technicien]";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            //ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);


            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data.DataSource = dt;

        }
        private void afficher_user()
        {
            string query = "SELECT [id_admin]\r\n      ,[nom_admin]\r\n      ,[password]\r\n  FROM [dbo].[admin]\r\n ";

            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            //ad.SelectCommand.Parameters.AddWithValue("@date1", date1.Value);


            System.Data.DataTable dt = new System.Data.DataTable();
            ad.Fill(dt);

            data.DataSource = dt;

        }
        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (titre_label.Text == "Ligne")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = data.Rows[e.RowIndex];
                    // Assuming you have three columns: Column1, Column2, and Column3
                    string value1 = selectedRow.Cells[0].Value.ToString();

                    // Display the values in TextBoxes or Labels
                    nom_text.Text = value1;
                }
            }
            else if (titre_label.Text == "Station")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = data.Rows[e.RowIndex];
                    // Assuming you have three columns: Column1, Column2, and Column3
                    string value1 = selectedRow.Cells[0].Value.ToString();

                    // Display the values in TextBoxes or Labels
                    nom_text.Text = value1;
                }
            }
            else if (titre_label.Text == "Probleme")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = data.Rows[e.RowIndex];
                    // Assuming you have three columns: Column1, Column2, and Column3
                    string value1 = selectedRow.Cells[0].Value.ToString();

                    // Display the values in TextBoxes or Labels
                    nom_text.Text = value1;
                }
            }
            else if (titre_label.Text == "Technicien")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = data.Rows[e.RowIndex];
                    // Assuming you have three columns: Column1, Column2, and Column3
                    string value1 = selectedRow.Cells[0].Value.ToString();
                    string value2 = selectedRow.Cells[1].Value.ToString();
                    string value3 = selectedRow.Cells[2].Value.ToString();
                    // Display the values in TextBoxes or Labels
                    nom_text.Text = value2;
                    matricule_text.Text = value1;
                    password_text.Text = value3;
                }
            }else if(titre_label.Text == "Utilisateur")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = data.Rows[e.RowIndex];
                    // Assuming you have three columns: Column1, Column2, and Column3
                    string value1 = selectedRow.Cells[0].Value.ToString();
                    string value2 = selectedRow.Cells[1].Value.ToString();
                    string value3 = selectedRow.Cells[2].Value.ToString();
                    // Display the values in TextBoxes or Labels
                    nom_text.Text = value2;
                    matricule_text.Text = value1;
                    password_text.Text = value3;
                }
            }
        }
        private void insert_data()
        {
            if (titre_label.Text == "Ligne")
            {
                try
                {
                    if (nom_text.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[nom_ligne] ([nom_ligne]) VALUES (@nom)", con);
                        cmd.Parameters.AddWithValue("@nom", nom_text.Text);

                        cmd.ExecuteNonQuery();
                        afficher_ligne();
                    }
                    else
                    {
                        MessageBox.Show("Remplir touts les information ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally { 
                    con.Close(); 
                }
            }
            else if (titre_label.Text == "Station")
            {
                try
                {
                    if (nom_text.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[nom_station] ([nom_station]) VALUES (@nom)", con);
                        cmd.Parameters.AddWithValue("@nom", nom_text.Text);

                        cmd.ExecuteNonQuery();
                        afficher_station();
                    }
                    else
                    {
                        MessageBox.Show("Remplir touts les information ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }
            else if (titre_label.Text == "Probleme")
            {
                try
                {
                    if (nom_text.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[nom_probleme] ([nom_probleme]) VALUES (@nom)", con);
                        cmd.Parameters.AddWithValue("@nom", nom_text.Text);

                        cmd.ExecuteNonQuery();
                        afficher_probleme();
                    }
                    else
                    {
                        MessageBox.Show("Remplir touts les information ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }
            else if (titre_label.Text == "Technicien")
            {
                try
                {
                    if (nom_text.Text != "" && matricule_text.Text != "" && password_text.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[technicien] ([matricule_technicien] ,[nom_technicien],[password]) VALUES (@matricule,@nom,@password)", con);
                        cmd.Parameters.AddWithValue("@matricule", matricule_text.Text);
                        cmd.Parameters.AddWithValue("@nom", nom_text.Text);
                        cmd.Parameters.AddWithValue("@password", password_text.Text);
                        cmd.ExecuteNonQuery();
                        afficher_technicien();
                    }
                    else
                    {
                        MessageBox.Show("Remplir touts les information ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }else if(titre_label.Text == "Utilisateur")
            {
                try
                {
                    if (nom_text.Text != "" && matricule_text.Text != "" && password_text.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[admin]\r\n           ([id_admin]\r\n           ,[nom_admin]\r\n           ,[password])\r\n  VALUES (@matricule,@nom,@password)", con);
                        cmd.Parameters.AddWithValue("@matricule", matricule_text.Text);
                        cmd.Parameters.AddWithValue("@nom", nom_text.Text);
                        cmd.Parameters.AddWithValue("@password", password_text.Text);
                        cmd.ExecuteNonQuery();
                        afficher_user();
                    }
                    else
                    {
                        MessageBox.Show("Remplir touts les information ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ajouter_btn_Click(object sender, EventArgs e)
        {
            insert_data();
            vider_text();
        }
        private void delete_data()
        {
            if (titre_label.Text == "Ligne")
            {
                if (nom_text.Text != "")
                {
                    try
                    {
                        con.Open();

                        string condition = "nom_ligne = @nomLigne";
                        // Copier les données dans la deuxième table
                        using (SqlCommand copyCommand = new SqlCommand(
                                "INSERT INTO intervention_archive (id_probleme, date, temps, matricule, shift, nom_ligne, nom_probleme, nom_station, nom_technicien, matricule_technicien, temps_debut, temps_fin, date_intervention, description, contre_partie, occupation) " +
                                "SELECT p.id_probleme, p.date, p.temps, p.matricule, p.shift, p.nom_ligne, p.nom_probleme, p.nom_station, t.nom_technicien, t.matricule_technicien, i.temps_debut, i.temps_fin, i.date_intervention, i.description, i.contre_partie, i.occupation " +
                                "FROM intervention i " +
                                "JOIN probleme p ON i.id_probleme = p.id_probleme " +
                                "JOIN technicien t ON t.matricule_technicien = i.matricule_technicien " +
                                "WHERE " + condition, con))
                            {
                                copyCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                                copyCommand.ExecuteNonQuery();
                            MessageBox.Show("Archiver les données ...!!");
                        }

                            // Supprimer les données de la première table
                            using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM intervention\r\nWHERE id_probleme IN (SELECT i.id_probleme FROM intervention i\r\n                     JOIN probleme p ON i.id_probleme = p.id_probleme\r\n                     WHERE p.nom_ligne = @nomLigne);", con))
                            {
                                deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                                deleteCommand.ExecuteNonQuery();
                        }
                            using (SqlCommand deleteCommand = new SqlCommand("DELETE a\r\nFROM attend AS a\r\nINNER JOIN probleme AS p ON a.id_probleme = p.id_probleme\r\nWHERE p.nom_ligne = @nomLigne;\r\n ", con))
                            {
                                deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                                deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from probleme  where nom_ligne = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from nom_ligne where nom_ligne = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("La ligne " + nom_text.Text + " est supprémer");
                        afficher_ligne();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else if (titre_label.Text == "Station")
            {
                if (nom_text.Text != "")
                {
                    try
                    {
                        con.Open();

                        string condition = "nom_station = @nomLigne";
                        // Copier les données dans la deuxième table
                        using (SqlCommand copyCommand = new SqlCommand(
                                "INSERT INTO intervention_archive (id_probleme, date, temps, matricule, shift, nom_ligne, nom_probleme, nom_station, nom_technicien, matricule_technicien, temps_debut, temps_fin, date_intervention, description, contre_partie, occupation) " +
                                "SELECT p.id_probleme, p.date, p.temps, p.matricule, p.shift, p.nom_ligne, p.nom_probleme, p.nom_station, t.nom_technicien, t.matricule_technicien, i.temps_debut, i.temps_fin, i.date_intervention, i.description, i.contre_partie, i.occupation " +
                                "FROM intervention i " +
                                "JOIN probleme p ON i.id_probleme = p.id_probleme " +
                                "JOIN technicien t ON t.matricule_technicien = i.matricule_technicien " +
                                "WHERE " + condition, con))
                        {
                            copyCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            copyCommand.ExecuteNonQuery();
                            MessageBox.Show("Archiver les données ...!!");
                        }

                        // Supprimer les données de la première table
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM intervention\r\nWHERE id_probleme IN (SELECT i.id_probleme FROM intervention i\r\n                     JOIN probleme p ON i.id_probleme = p.id_probleme\r\n                     WHERE p.nom_station = @nomLigne);", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE a\r\nFROM attend AS a\r\nINNER JOIN probleme AS p ON a.id_probleme = p.id_probleme\r\nWHERE p.nom_station = @nomLigne;\r\n ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from probleme  where nom_station = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from nom_station where nom_station = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("La station " + nom_text.Text + " est supprémer");
                        afficher_station();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else if (titre_label.Text == "Probleme")
            {
                if (nom_text.Text != "")
                {
                    try
                    {
                        con.Open();

                        string condition = "p.nom_probleme = @nomLigne";
                        // Copier les données dans la deuxième table
                        using (SqlCommand copyCommand = new SqlCommand(
                                "INSERT INTO intervention_archive (id_probleme, date, temps, matricule, shift, nom_ligne, nom_probleme, nom_station, nom_technicien, matricule_technicien, temps_debut, temps_fin, date_intervention, description, contre_partie, occupation) " +
                                "SELECT p.id_probleme, p.date, p.temps, p.matricule, p.shift, p.nom_ligne, p.nom_probleme, p.nom_station, t.nom_technicien, t.matricule_technicien, i.temps_debut, i.temps_fin, i.date_intervention, i.description, i.contre_partie, i.occupation " +
                                "FROM intervention i " +
                                "JOIN probleme p ON i.id_probleme = p.id_probleme " +
                                "JOIN technicien t ON t.matricule_technicien = i.matricule_technicien " +
                                "WHERE " + condition, con))
                        {
                            copyCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            copyCommand.ExecuteNonQuery();
                            MessageBox.Show("Archiver les données ...!!");
                        }

                        // Supprimer les données de la première table
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM intervention\r\nWHERE id_probleme IN (SELECT i.id_probleme FROM intervention i\r\n                     JOIN probleme p ON i.id_probleme = p.id_probleme\r\n                     WHERE p.nom_probleme = @nomLigne);", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE a\r\nFROM attend AS a\r\nINNER JOIN probleme AS p ON a.id_probleme = p.id_probleme\r\nWHERE p.nom_probleme = @nomLigne;\r\n ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from probleme  where nom_probleme = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from nom_probleme where nom_probleme = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", nom_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Le probleme " + nom_text.Text + " est supprémer");
                        afficher_probleme();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else if (titre_label.Text == "Technicien")
            {
                if (nom_text.Text != "")
                {
                    try
                    {
                        con.Open();

                        string condition = "i.matricule_technicien = @nomLigne";
                        // Copier les données dans la deuxième table
                        using (SqlCommand copyCommand = new SqlCommand(
                                "INSERT INTO intervention_archive (id_probleme, date, temps, matricule, shift, nom_ligne, nom_probleme, nom_station, nom_technicien, matricule_technicien, temps_debut, temps_fin, date_intervention, description, contre_partie, occupation) " +
                                "SELECT p.id_probleme, p.date, p.temps, p.matricule, p.shift, p.nom_ligne, p.nom_probleme, p.nom_station, t.nom_technicien, t.matricule_technicien, i.temps_debut, i.temps_fin, i.date_intervention, i.description, i.contre_partie, i.occupation " +
                                "FROM intervention i " +
                                "JOIN probleme p ON i.id_probleme = p.id_probleme " +
                                "JOIN technicien t ON t.matricule_technicien = i.matricule_technicien " +
                                "WHERE " + condition, con))
                        {
                            copyCommand.Parameters.AddWithValue("@nomLigne", matricule_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            copyCommand.ExecuteNonQuery();
                            MessageBox.Show("Archiver les données ...!!");
                        }

                        // Supprimer les données de la première table
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM intervention\r\nWHERE matricule_technicien IN (SELECT i.matricule_technicien FROM intervention i\r\n                     WHERE i.matricule_technicien = @nomLigne);", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", matricule_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE a\r\nFROM attend AS a\r\nINNER JOIN technicien AS t ON a.matricule_technicien = t.matricule_technicien\r\nWHERE t.matricule_technicien = @nomLigne;\r\n ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", matricule_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("delete from technicien  where matricule_technicien = @nomLigne ", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@nomLigne", matricule_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                            deleteCommand.ExecuteNonQuery();
                        }


                        MessageBox.Show("Le probleme " + nom_text.Text + " est supprémer");
                        afficher_technicien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }else if (titre_label.Text == "Utilisateur")
            {
                try
                {
                    con.Open();

                    using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM [dbo].[admin] WHERE [id_admin] = @nomLigne ", con))
                    {
                        deleteCommand.Parameters.AddWithValue("@nomLigne", matricule_text.Text); // Remplacez "VotreValeurTextBox" par la valeur de votre TextBox
                        deleteCommand.ExecuteNonQuery();
                    }


                    MessageBox.Show("L'utisateur " + nom_text.Text + " est supprémer");
                    afficher_user();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void suppreme_btn_Click(object sender, EventArgs e)
        {
            delete_data();
            vider_text();
        }

        
    }
}
