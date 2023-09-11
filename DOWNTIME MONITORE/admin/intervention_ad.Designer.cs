namespace DOWNTIME_MONITORE.admin
{
    partial class intervention_ad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.station_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shift_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ligne_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data_intervention = new System.Windows.Forms.DataGridView();
            this.id_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_technicien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule_technicien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_intervention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contre_partie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.technicien_combo = new System.Windows.Forms.ComboBox();
            this.refresh_btn = new System.Windows.Forms.PictureBox();
            this.search_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_intervention)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(498, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 1);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(507, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Interventions";
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(20, 90);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 26);
            this.date1.TabIndex = 25;
            // 
            // date2
            // 
            this.date2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(194, 90);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(151, 26);
            this.date2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Station :";
            // 
            // station_combo
            // 
            this.station_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_combo.FormattingEnabled = true;
            this.station_combo.Location = new System.Drawing.Point(542, 90);
            this.station_combo.Name = "station_combo";
            this.station_combo.Size = new System.Drawing.Size(169, 29);
            this.station_combo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(726, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Shift :";
            // 
            // shift_combo
            // 
            this.shift_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shift_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_combo.FormattingEnabled = true;
            this.shift_combo.Items.AddRange(new object[] {
            "matin",
            "soir",
            "nuit"});
            this.shift_combo.Location = new System.Drawing.Point(730, 90);
            this.shift_combo.Name = "shift_combo";
            this.shift_combo.Size = new System.Drawing.Size(169, 29);
            this.shift_combo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ligne :";
            // 
            // ligne_combo
            // 
            this.ligne_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ligne_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ligne_combo.FormattingEnabled = true;
            this.ligne_combo.Location = new System.Drawing.Point(357, 90);
            this.ligne_combo.Name = "ligne_combo";
            this.ligne_combo.Size = new System.Drawing.Size(169, 29);
            this.ligne_combo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date Debut :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date Fin :";
            // 
            // data_intervention
            // 
            this.data_intervention.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_intervention.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_intervention.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_intervention.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_intervention.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_intervention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_intervention.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_probleme,
            this.date,
            this.temps,
            this.shift,
            this.matricule,
            this.nom_ligne,
            this.nom_probleme,
            this.nom_station,
            this.nom_technicien,
            this.matricule_technicien,
            this.date_intervention,
            this.temps_debut,
            this.temps_fin,
            this.occupation,
            this.contre_partie,
            this.description});
            this.data_intervention.Location = new System.Drawing.Point(19, 128);
            this.data_intervention.Name = "data_intervention";
            this.data_intervention.ReadOnly = true;
            this.data_intervention.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_intervention.Size = new System.Drawing.Size(1158, 538);
            this.data_intervention.TabIndex = 35;
            // 
            // id_probleme
            // 
            this.id_probleme.DataPropertyName = "id_probleme";
            this.id_probleme.HeaderText = "N°";
            this.id_probleme.Name = "id_probleme";
            this.id_probleme.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // temps
            // 
            this.temps.DataPropertyName = "temps";
            this.temps.HeaderText = "Temps";
            this.temps.Name = "temps";
            this.temps.ReadOnly = true;
            // 
            // shift
            // 
            this.shift.DataPropertyName = "shift";
            this.shift.HeaderText = "Shift";
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "matricule";
            this.matricule.HeaderText = "Matricule";
            this.matricule.Name = "matricule";
            this.matricule.ReadOnly = true;
            // 
            // nom_ligne
            // 
            this.nom_ligne.DataPropertyName = "nom_ligne";
            this.nom_ligne.HeaderText = "Ligne";
            this.nom_ligne.Name = "nom_ligne";
            this.nom_ligne.ReadOnly = true;
            // 
            // nom_probleme
            // 
            this.nom_probleme.DataPropertyName = "nom_probleme";
            this.nom_probleme.HeaderText = "Probleme";
            this.nom_probleme.Name = "nom_probleme";
            this.nom_probleme.ReadOnly = true;
            // 
            // nom_station
            // 
            this.nom_station.DataPropertyName = "nom_station";
            this.nom_station.HeaderText = "Station";
            this.nom_station.Name = "nom_station";
            this.nom_station.ReadOnly = true;
            // 
            // nom_technicien
            // 
            this.nom_technicien.DataPropertyName = "nom_technicien";
            this.nom_technicien.HeaderText = "Technicien";
            this.nom_technicien.Name = "nom_technicien";
            this.nom_technicien.ReadOnly = true;
            // 
            // matricule_technicien
            // 
            this.matricule_technicien.DataPropertyName = "matricule_technicien";
            this.matricule_technicien.HeaderText = "Matricule Tech";
            this.matricule_technicien.Name = "matricule_technicien";
            this.matricule_technicien.ReadOnly = true;
            // 
            // date_intervention
            // 
            this.date_intervention.DataPropertyName = "date_intervention";
            this.date_intervention.HeaderText = "Date Interv";
            this.date_intervention.Name = "date_intervention";
            this.date_intervention.ReadOnly = true;
            // 
            // temps_debut
            // 
            this.temps_debut.DataPropertyName = "temps_debut";
            this.temps_debut.HeaderText = "Temps Début";
            this.temps_debut.Name = "temps_debut";
            this.temps_debut.ReadOnly = true;
            // 
            // temps_fin
            // 
            this.temps_fin.DataPropertyName = "temps_fin";
            this.temps_fin.HeaderText = "Temps Fin";
            this.temps_fin.Name = "temps_fin";
            this.temps_fin.ReadOnly = true;
            // 
            // occupation
            // 
            this.occupation.DataPropertyName = "occupation";
            this.occupation.HeaderText = "Occupation";
            this.occupation.Name = "occupation";
            this.occupation.ReadOnly = true;
            // 
            // contre_partie
            // 
            this.contre_partie.DataPropertyName = "contre_partie";
            this.contre_partie.HeaderText = "Contre Partie";
            this.contre_partie.Name = "contre_partie";
            this.contre_partie.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(906, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Techncien :";
            // 
            // technicien_combo
            // 
            this.technicien_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicien_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicien_combo.FormattingEnabled = true;
            this.technicien_combo.Location = new System.Drawing.Point(910, 89);
            this.technicien_combo.Name = "technicien_combo";
            this.technicien_combo.Size = new System.Drawing.Size(169, 29);
            this.technicien_combo.TabIndex = 36;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.Image = global::DOWNTIME_MONITORE.Properties.Resources.refresh_button;
            this.refresh_btn.Location = new System.Drawing.Point(1132, 89);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(38, 31);
            this.refresh_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh_btn.TabIndex = 39;
            this.refresh_btn.TabStop = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Image = global::DOWNTIME_MONITORE.Properties.Resources.search;
            this.search_btn.Location = new System.Drawing.Point(1085, 89);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(38, 31);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_btn.TabIndex = 38;
            this.search_btn.TabStop = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // intervention_ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.technicien_combo);
            this.Controls.Add(this.data_intervention);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.station_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shift_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ligne_combo);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "intervention_ad";
            this.Size = new System.Drawing.Size(1180, 669);
            this.Load += new System.EventHandler(this.intervention_ad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_intervention)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox station_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox shift_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ligne_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_intervention;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_technicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule_technicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_intervention;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn contre_partie;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox technicien_combo;
        private System.Windows.Forms.PictureBox search_btn;
        private System.Windows.Forms.PictureBox refresh_btn;
    }
}
