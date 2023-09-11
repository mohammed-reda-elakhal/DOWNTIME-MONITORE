namespace DOWNTIME_MONITORE.Controles
{
    partial class intervention
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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.data_intervention)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(487, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervention";
            // 
            // data_intervention
            // 
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
            this.data_intervention.Location = new System.Drawing.Point(3, 74);
            this.data_intervention.Name = "data_intervention";
            this.data_intervention.ReadOnly = true;
            this.data_intervention.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_intervention.Size = new System.Drawing.Size(1149, 587);
            this.data_intervention.TabIndex = 31;
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
            // intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.data_intervention);
            this.Controls.Add(this.label1);
            this.Name = "intervention";
            this.Size = new System.Drawing.Size(1155, 664);
            this.Load += new System.EventHandler(this.intervention_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_intervention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}
