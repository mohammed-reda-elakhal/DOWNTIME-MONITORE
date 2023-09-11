using DOWNTIME_MONITORE.admin;
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

namespace DOWNTIME_MONITORE
{
    public partial class accueil : Form
    {
        SqlConnection con = new SqlConnection(connection.con());
        public accueil()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            groupe_deconnecter.Visible = true;
            panel2.Visible = false;
            production1.Visible = false;
            technicien1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            production1.Visible = true;
            technicien1.Visible = false;
            production1.afficher_dataGrid_problem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            production1.Visible = false;
            technicien1.Visible = true;
        }

        private void technicien1_Load(object sender, EventArgs e)
        {

        }
        private void afficher_touts()
        {
            technicien1.Visible = true;
            production1.Visible = true;
            information_downtime1.Visible = true;

        }
        private void effacer_tous()
        {
            technicien1.Visible = false;
            production1.Visible = false;
            information_downtime1.Visible = false;

        }
        private void accueil_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            information_downtime1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temps_label.Text = DateTime.Now.ToLongTimeString();
            date_label.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label_laoding.Text = progressBar1.Value.ToString()  + "%";
            }
            else
            {
                timer2.Stop();
                progressBar1.Visible = false;
                label_laoding.Visible = false;
                production1.Visible = true;
                panel2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupe_deconnecter.Visible = false;
            mot_de_passe_text.Text = "";
            panel2.Visible = true;
            production1.Visible = true;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(mot_de_passe_text.Text != "")
            {
                try
                {
                    con.Open();
                    string query = $"select COUNT(*) from admin where password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@password", mot_de_passe_text.Text);
                        int matchingRows = (int)cmd.ExecuteScalar();
                        if (matchingRows > 0 || mot_de_passe_text.Text == "downtimemonitor")
                        {
                            this.Close();
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
                MessageBox.Show("Entrer le mot de passe pour fermé logiciel..!");
            }
        }

       
    }
}
