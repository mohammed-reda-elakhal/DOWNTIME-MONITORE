namespace DOWNTIME_MONITORE.admin
{
    partial class modification
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.technicien_btn = new System.Windows.Forms.Button();
            this.probleme_btn = new System.Windows.Forms.Button();
            this.station_btn = new System.Windows.Forms.Button();
            this.ligne_btn = new System.Windows.Forms.Button();
            this.nom_label = new System.Windows.Forms.Label();
            this.nom_text = new System.Windows.Forms.TextBox();
            this.matricule_label = new System.Windows.Forms.Label();
            this.matricule_text = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.ajouter_btn = new System.Windows.Forms.Button();
            this.suppreme_btn = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.user_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.titre_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 40);
            this.panel1.TabIndex = 3;
            // 
            // titre_label
            // 
            this.titre_label.AutoSize = true;
            this.titre_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_label.ForeColor = System.Drawing.Color.Gray;
            this.titre_label.Location = new System.Drawing.Point(631, 9);
            this.titre_label.Name = "titre_label";
            this.titre_label.Size = new System.Drawing.Size(0, 21);
            this.titre_label.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modification";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.user_btn);
            this.panel2.Controls.Add(this.technicien_btn);
            this.panel2.Controls.Add(this.probleme_btn);
            this.panel2.Controls.Add(this.station_btn);
            this.panel2.Controls.Add(this.ligne_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 35);
            this.panel2.TabIndex = 4;
            // 
            // technicien_btn
            // 
            this.technicien_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.technicien_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.technicien_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.technicien_btn.FlatAppearance.BorderSize = 0;
            this.technicien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.technicien_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicien_btn.ForeColor = System.Drawing.Color.White;
            this.technicien_btn.Location = new System.Drawing.Point(549, 0);
            this.technicien_btn.Name = "technicien_btn";
            this.technicien_btn.Size = new System.Drawing.Size(183, 34);
            this.technicien_btn.TabIndex = 5;
            this.technicien_btn.Text = "Technicien";
            this.technicien_btn.UseVisualStyleBackColor = false;
            this.technicien_btn.Click += new System.EventHandler(this.technicien_btn_Click);
            // 
            // probleme_btn
            // 
            this.probleme_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.probleme_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.probleme_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.probleme_btn.FlatAppearance.BorderSize = 0;
            this.probleme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.probleme_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probleme_btn.ForeColor = System.Drawing.Color.White;
            this.probleme_btn.Location = new System.Drawing.Point(366, 0);
            this.probleme_btn.Name = "probleme_btn";
            this.probleme_btn.Size = new System.Drawing.Size(183, 34);
            this.probleme_btn.TabIndex = 4;
            this.probleme_btn.Text = "Problemes";
            this.probleme_btn.UseVisualStyleBackColor = false;
            this.probleme_btn.Click += new System.EventHandler(this.probleme_btn_Click);
            // 
            // station_btn
            // 
            this.station_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.station_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.station_btn.FlatAppearance.BorderSize = 0;
            this.station_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.station_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_btn.ForeColor = System.Drawing.Color.White;
            this.station_btn.Location = new System.Drawing.Point(183, 0);
            this.station_btn.Name = "station_btn";
            this.station_btn.Size = new System.Drawing.Size(183, 34);
            this.station_btn.TabIndex = 3;
            this.station_btn.Text = "Station";
            this.station_btn.UseVisualStyleBackColor = false;
            this.station_btn.Click += new System.EventHandler(this.station_btn_Click);
            // 
            // ligne_btn
            // 
            this.ligne_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.ligne_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ligne_btn.FlatAppearance.BorderSize = 0;
            this.ligne_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ligne_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ligne_btn.ForeColor = System.Drawing.Color.White;
            this.ligne_btn.Location = new System.Drawing.Point(0, 0);
            this.ligne_btn.Name = "ligne_btn";
            this.ligne_btn.Size = new System.Drawing.Size(183, 34);
            this.ligne_btn.TabIndex = 2;
            this.ligne_btn.Text = "Ligne";
            this.ligne_btn.UseVisualStyleBackColor = false;
            this.ligne_btn.Click += new System.EventHandler(this.ligne_btn_Click);
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(12, 88);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(55, 21);
            this.nom_label.TabIndex = 10;
            this.nom_label.Text = "Nom :";
            // 
            // nom_text
            // 
            this.nom_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_text.Location = new System.Drawing.Point(16, 112);
            this.nom_text.Name = "nom_text";
            this.nom_text.Size = new System.Drawing.Size(221, 26);
            this.nom_text.TabIndex = 9;
            // 
            // matricule_label
            // 
            this.matricule_label.AutoSize = true;
            this.matricule_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_label.Location = new System.Drawing.Point(246, 88);
            this.matricule_label.Name = "matricule_label";
            this.matricule_label.Size = new System.Drawing.Size(109, 21);
            this.matricule_label.TabIndex = 12;
            this.matricule_label.Text = "Matricule :";
            this.matricule_label.Visible = false;
            // 
            // matricule_text
            // 
            this.matricule_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matricule_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_text.Location = new System.Drawing.Point(250, 112);
            this.matricule_text.Name = "matricule_text";
            this.matricule_text.Size = new System.Drawing.Size(221, 26);
            this.matricule_text.TabIndex = 11;
            this.matricule_text.Visible = false;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(480, 88);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(136, 21);
            this.password_label.TabIndex = 14;
            this.password_label.Text = "Mot de passe :";
            this.password_label.Visible = false;
            // 
            // password_text
            // 
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(484, 112);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(221, 26);
            this.password_text.TabIndex = 13;
            this.password_text.Visible = false;
            // 
            // ajouter_btn
            // 
            this.ajouter_btn.BackColor = System.Drawing.Color.Navy;
            this.ajouter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouter_btn.FlatAppearance.BorderSize = 0;
            this.ajouter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter_btn.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_btn.ForeColor = System.Drawing.Color.Silver;
            this.ajouter_btn.Location = new System.Drawing.Point(16, 144);
            this.ajouter_btn.Name = "ajouter_btn";
            this.ajouter_btn.Size = new System.Drawing.Size(106, 36);
            this.ajouter_btn.TabIndex = 40;
            this.ajouter_btn.Text = "Ajouter";
            this.ajouter_btn.UseVisualStyleBackColor = false;
            this.ajouter_btn.Click += new System.EventHandler(this.ajouter_btn_Click);
            // 
            // suppreme_btn
            // 
            this.suppreme_btn.BackColor = System.Drawing.Color.DarkRed;
            this.suppreme_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppreme_btn.FlatAppearance.BorderSize = 0;
            this.suppreme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppreme_btn.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppreme_btn.ForeColor = System.Drawing.Color.Silver;
            this.suppreme_btn.Location = new System.Drawing.Point(131, 144);
            this.suppreme_btn.Name = "suppreme_btn";
            this.suppreme_btn.Size = new System.Drawing.Size(106, 36);
            this.suppreme_btn.TabIndex = 41;
            this.suppreme_btn.Text = "Supp";
            this.suppreme_btn.UseVisualStyleBackColor = false;
            this.suppreme_btn.Click += new System.EventHandler(this.suppreme_btn_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(16, 186);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data.Size = new System.Drawing.Size(689, 541);
            this.data.TabIndex = 43;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.user_btn.FlatAppearance.BorderSize = 0;
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.user_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.ForeColor = System.Drawing.Color.White;
            this.user_btn.Location = new System.Drawing.Point(732, 0);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(183, 34);
            this.user_btn.TabIndex = 6;
            this.user_btn.Text = "Utilisateur";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.data);
            this.Controls.Add(this.suppreme_btn);
            this.Controls.Add(this.ajouter_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.matricule_label);
            this.Controls.Add(this.matricule_text);
            this.Controls.Add(this.nom_label);
            this.Controls.Add(this.nom_text);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "modification";
            this.Size = new System.Drawing.Size(1181, 748);
            this.Load += new System.EventHandler(this.modification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button technicien_btn;
        private System.Windows.Forms.Button probleme_btn;
        private System.Windows.Forms.Button station_btn;
        private System.Windows.Forms.Button ligne_btn;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox nom_text;
        private System.Windows.Forms.Label matricule_label;
        private System.Windows.Forms.TextBox matricule_text;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label titre_label;
        private System.Windows.Forms.Button ajouter_btn;
        private System.Windows.Forms.Button suppreme_btn;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button user_btn;
    }
}
