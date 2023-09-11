using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOWNTIME_MONITORE.admin
{
    public partial class problemes : UserControl
    {
        public problemes()
        {
            InitializeComponent();
        }

        private void accueil_btn_Click(object sender, EventArgs e)
        {
            probleme_ad1.Visible = true;
            probleme_ad1.afficher_dataGrid_problem();
            occupation_ad1.Visible=false;
            intervention_ad1.Visible = false;
        }

        private void occupation_ad1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            occupation_ad1.Visible = true;
            occupation_ad1.afficher_data_attend();
            probleme_ad1.Visible=false;
            intervention_ad1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            probleme_ad1.Visible = false;
            occupation_ad1.Visible = false;
            intervention_ad1.Visible = true;
            intervention_ad1.afficher_intervention();
        }
    }
}
