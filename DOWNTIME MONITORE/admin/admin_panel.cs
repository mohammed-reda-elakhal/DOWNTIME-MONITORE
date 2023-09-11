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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            problemes1.Visible = true;
            analyse1.Visible = false;
            kpa1.Visible = false;
            modification1.Visible = false;
            corbie1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            problemes1.Visible = false;
            analyse1.Visible = true;
            kpa1.Visible = false;
            modification1.Visible = false;
            corbie1.Visible = false;
        }

        private void kpa_btn_Click(object sender, EventArgs e)
        {
            kpa1.Visible = true;
            problemes1.Visible = false;
            analyse1.Visible = false;
            modification1.Visible = false;
            corbie1.Visible = false;
        }

        private void modification_btn_Click(object sender, EventArgs e)
        {
            modification1.Visible = true;
            problemes1.Visible = false;
            analyse1.Visible = false;
            kpa1.Visible = false;
            corbie1.Visible = false;
        }

        private void corbie_btn_Click(object sender, EventArgs e)
        {
            corbie1.Visible = true;
            modification1.Visible = false;
            problemes1.Visible = false;
            analyse1.Visible = false;
            kpa1.Visible = false;
        }
    }
}
