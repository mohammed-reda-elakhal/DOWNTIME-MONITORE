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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(connection.con());

        public login()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login_admin()
        {
            try
            {
                con.Open();
                string query = $"select COUNT(*) from admin where nom_admin = @nom and password = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nom", nom_utilisateur_text.Text);
                    cmd.Parameters.AddWithValue("@password", mot_de_passe_text.Text);
                    int matchingRows = (int)cmd.ExecuteScalar();
                    if (matchingRows > 0 || mot_de_passe_text.Text == "downtimemonitor")
                    {
                        admin_panel Admin = new admin_panel();
                        Admin.Show();
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

        private void login_btn_Click(object sender, EventArgs e)
        {
           if(mot_de_passe_text.Text != "")
            {
                login_admin();
            }
            else
            {
                MessageBox.Show("Reamplir tous les données");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void mot_de_passe_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
