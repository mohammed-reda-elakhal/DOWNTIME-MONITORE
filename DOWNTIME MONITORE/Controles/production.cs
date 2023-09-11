using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DOWNTIME_MONITORE.classe;

namespace DOWNTIME_MONITORE.Controles
{
    public partial class production : UserControl
    {
        SqlConnection con = new SqlConnection(connection.con());
        
        public production()
        {
            InitializeComponent();
        }

        private void production_Load(object sender, EventArgs e)
        {
            afficher_ligne();
            afficher_station();
            afficher_probleme();
            afficher_dataGrid_problem();
            afficher_shift();
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

        private void afficher_ligne()
        {
            String sql = "Select nom_ligne from nom_ligne";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ligne_combo.DataSource = dt;
            ligne_combo.DisplayMember = "nom_ligne";
            ligne_combo.ValueMember = "nom_ligne";
            ligne_combo.SelectedIndex = -1;
        }
        private void afficher_station()
        {
            string sql = "Select nom_station from nom_station";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            station_combo.DataSource = dt;
            station_combo.DisplayMember = "nom_station";
            station_combo.ValueMember = "nom_station";
            station_combo.SelectedIndex = -1;
        }
        private void afficher_probleme()
        {
            string sql = "Select nom_probleme from nom_probleme";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            probleme_combo.DataSource = dt;
            probleme_combo.DisplayMember = "nom_probleme";
            probleme_combo.ValueMember = "nom_probleme";
            probleme_combo.SelectedIndex = -1;
        }

        private void afficher_shift()
        {

            // Obtenir l'heure actuelle
            DateTime now = DateTime.Now;
            // Condition pour déterminer la valeur à sélectionner
            string shift;
            if (now.Hour >= 8 && now.Hour <= 15)
            {
                shift = "matin";
            }
            else if (now.Hour >= 16 && now.Hour <= 23)
            {
                shift = "soir";
            }
            else
            {
                shift = "nuit";
            }

            // Sélectionner la valeur dans le ComboBox
            shift_combo.Text = shift;
        }

        private void insert_data_probleme()
        {
            try
            {
                if (matricule_text.Text != "" && ligne_combo.Text != "" && probleme_combo.Text != "" && station_combo.Text != "")
                {
                    con.Open();
                    DateTime heure = DateTime.Now;
                    // Retrieve the current date
                    DateTime currentDates = DateTime.Now;

                    // Convert the date to a string format compatible with SQL Server
                    string formattedDates = currentDates.ToString("yyyy-MM-dd");
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[probleme] ([date],[temps],[matricule],[shift],[nom_ligne],[nom_probleme],[nom_station],[is_donne])" +
                        " values (@date , @temps , @matricule , @shift , @ligne , @probleme , @station , @is_donne)", con);
                    cmd.Parameters.AddWithValue("@matricule", matricule_text.Text);
                    cmd.Parameters.AddWithValue("@temps", heure.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@ligne", ligne_combo.Text);
                    cmd.Parameters.AddWithValue("@shift", shift_combo.Text);
                    cmd.Parameters.AddWithValue("@probleme", probleme_combo.Text);
                    cmd.Parameters.AddWithValue("@date", formattedDates);
                    cmd.Parameters.AddWithValue("@is_donne", 0);
                    cmd.Parameters.AddWithValue("@station", station_combo.Text);


                    cmd.ExecuteNonQuery();
                    afficher_dataGrid_problem();
                   
                    matricule_text.Text = "";
                }
                else
                {
                    MessageBox.Show("Remplir touts les information ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    

            }finally { con.Close(); }
        }

        private void declare_btn_Click(object sender, EventArgs e)
        {
            insert_data_probleme();
            afficher_ligne();
            afficher_station();
            afficher_probleme();
            afficher_dataGrid_problem();
            afficher_shift();

        }

        private void matricule_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si le caractère n'est pas un chiffre ou une touche de contrôle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorer le caractère
            }
        }
    }
}
