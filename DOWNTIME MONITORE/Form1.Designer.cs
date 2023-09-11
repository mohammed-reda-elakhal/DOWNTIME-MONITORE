namespace DOWNTIME_MONITORE
{
    partial class accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_label = new System.Windows.Forms.Label();
            this.temps_label = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_btn = new System.Windows.Forms.Button();
            this.tech_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_laoding = new System.Windows.Forms.Label();
            this.groupe_deconnecter = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.mot_de_passe_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.information_downtime1 = new DOWNTIME_MONITORE.Controles.information_downtime();
            this.production1 = new DOWNTIME_MONITORE.Controles.production();
            this.technicien1 = new DOWNTIME_MONITORE.Controles.technicien();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupe_deconnecter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.date_label);
            this.panel1.Controls.Add(this.temps_label);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 44);
            this.panel1.TabIndex = 0;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_label.Location = new System.Drawing.Point(96, 5);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(16, 17);
            this.date_label.TabIndex = 29;
            this.date_label.Text = ".";
            // 
            // temps_label
            // 
            this.temps_label.AutoSize = true;
            this.temps_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temps_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.temps_label.Location = new System.Drawing.Point(96, 22);
            this.temps_label.Name = "temps_label";
            this.temps_label.Size = new System.Drawing.Size(0, 17);
            this.temps_label.TabIndex = 28;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::DOWNTIME_MONITORE.Properties.Resources.information;
            this.pictureBox4.Location = new System.Drawing.Point(4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOWNTIME MONITOR";
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::DOWNTIME_MONITORE.Properties.Resources.error;
            this.close_btn.Location = new System.Drawing.Point(1326, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 37);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 0;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.admin_btn);
            this.panel2.Controls.Add(this.tech_btn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 33);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_btn.Location = new System.Drawing.Point(1217, 0);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(153, 33);
            this.admin_btn.TabIndex = 2;
            this.admin_btn.Text = "Admin";
            this.admin_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tech_btn
            // 
            this.tech_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.tech_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tech_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tech_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tech_btn.Location = new System.Drawing.Point(154, 0);
            this.tech_btn.Name = "tech_btn";
            this.tech_btn.Size = new System.Drawing.Size(153, 33);
            this.tech_btn.TabIndex = 1;
            this.tech_btn.Text = "Technicien";
            this.tech_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tech_btn.UseVisualStyleBackColor = false;
            this.tech_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Production";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 726);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1370, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label_laoding
            // 
            this.label_laoding.AutoSize = true;
            this.label_laoding.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_laoding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_laoding.Location = new System.Drawing.Point(670, 695);
            this.label_laoding.Name = "label_laoding";
            this.label_laoding.Size = new System.Drawing.Size(24, 28);
            this.label_laoding.TabIndex = 30;
            this.label_laoding.Text = "0\r\n";
            // 
            // groupe_deconnecter
            // 
            this.groupe_deconnecter.Controls.Add(this.button4);
            this.groupe_deconnecter.Controls.Add(this.logout_btn);
            this.groupe_deconnecter.Controls.Add(this.mot_de_passe_text);
            this.groupe_deconnecter.Controls.Add(this.label2);
            this.groupe_deconnecter.Font = new System.Drawing.Font("Cascadia Code SemiLight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupe_deconnecter.Location = new System.Drawing.Point(997, 44);
            this.groupe_deconnecter.Name = "groupe_deconnecter";
            this.groupe_deconnecter.Size = new System.Drawing.Size(373, 151);
            this.groupe_deconnecter.TabIndex = 32;
            this.groupe_deconnecter.TabStop = false;
            this.groupe_deconnecter.Text = "Deconnection";
            this.groupe_deconnecter.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(178, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Annuler";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(19, 99);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(153, 33);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Deconnecter";
            this.logout_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // mot_de_passe_text
            // 
            this.mot_de_passe_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mot_de_passe_text.Location = new System.Drawing.Point(19, 51);
            this.mot_de_passe_text.Name = "mot_de_passe_text";
            this.mot_de_passe_text.Size = new System.Drawing.Size(339, 26);
            this.mot_de_passe_text.TabIndex = 5;
            this.mot_de_passe_text.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe :";
            // 
            // information_downtime1
            // 
            this.information_downtime1.BackColor = System.Drawing.Color.Silver;
            this.information_downtime1.Location = new System.Drawing.Point(0, 42);
            this.information_downtime1.Name = "information_downtime1";
            this.information_downtime1.Size = new System.Drawing.Size(543, 285);
            this.information_downtime1.TabIndex = 4;
            this.information_downtime1.Visible = false;
            // 
            // production1
            // 
            this.production1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.production1.BackColor = System.Drawing.Color.White;
            this.production1.Location = new System.Drawing.Point(0, 78);
            this.production1.Name = "production1";
            this.production1.Size = new System.Drawing.Size(1370, 672);
            this.production1.TabIndex = 2;
            this.production1.Visible = false;
            // 
            // technicien1
            // 
            this.technicien1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.technicien1.BackColor = System.Drawing.Color.White;
            this.technicien1.Location = new System.Drawing.Point(0, 77);
            this.technicien1.Name = "technicien1";
            this.technicien1.Size = new System.Drawing.Size(1370, 672);
            this.technicien1.TabIndex = 31;
            this.technicien1.Visible = false;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupe_deconnecter);
            this.Controls.Add(this.information_downtime1);
            this.Controls.Add(this.label_laoding);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.production1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.technicien1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupe_deconnecter.ResumeLayout(false);
            this.groupe_deconnecter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tech_btn;
        private Controles.production production1;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Controles.information_downtime information_downtime1;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label temps_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_laoding;
        private Controles.technicien technicien1;
        private System.Windows.Forms.GroupBox groupe_deconnecter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TextBox mot_de_passe_text;
        private System.Windows.Forms.Label label2;
    }
}

