namespace DOWNTIME_MONITORE.admin
{
    partial class occupation_ad
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
            this.data_attend = new System.Windows.Forms.DataGridView();
            this.id_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_technicien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_attend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(529, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 1);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(553, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Occupation";
            // 
            // data_attend
            // 
            this.data_attend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_attend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_attend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_attend.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_attend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_attend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_attend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_probleme,
            this.temps,
            this.date,
            this.matricule,
            this.shift,
            this.nom_ligne,
            this.nom_station,
            this.nom_probleme,
            this.nom_technicien,
            this.temps_debut});
            this.data_attend.Location = new System.Drawing.Point(15, 81);
            this.data_attend.Name = "data_attend";
            this.data_attend.ReadOnly = true;
            this.data_attend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_attend.Size = new System.Drawing.Size(1150, 585);
            this.data_attend.TabIndex = 32;
            // 
            // id_probleme
            // 
            this.id_probleme.DataPropertyName = "id_probleme";
            this.id_probleme.HeaderText = "N°";
            this.id_probleme.Name = "id_probleme";
            this.id_probleme.ReadOnly = true;
            // 
            // temps
            // 
            this.temps.DataPropertyName = "temps";
            this.temps.HeaderText = "Temps";
            this.temps.Name = "temps";
            this.temps.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "matricule";
            this.matricule.HeaderText = "Matricule";
            this.matricule.Name = "matricule";
            this.matricule.ReadOnly = true;
            // 
            // shift
            // 
            this.shift.DataPropertyName = "shift";
            this.shift.HeaderText = "Shift";
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            // 
            // nom_ligne
            // 
            this.nom_ligne.DataPropertyName = "nom_ligne";
            this.nom_ligne.HeaderText = "Ligne";
            this.nom_ligne.Name = "nom_ligne";
            this.nom_ligne.ReadOnly = true;
            // 
            // nom_station
            // 
            this.nom_station.DataPropertyName = "nom_station";
            this.nom_station.HeaderText = "Station";
            this.nom_station.Name = "nom_station";
            this.nom_station.ReadOnly = true;
            // 
            // nom_probleme
            // 
            this.nom_probleme.DataPropertyName = "nom_probleme";
            this.nom_probleme.HeaderText = "Probleme";
            this.nom_probleme.Name = "nom_probleme";
            this.nom_probleme.ReadOnly = true;
            // 
            // nom_technicien
            // 
            this.nom_technicien.DataPropertyName = "nom_technicien";
            this.nom_technicien.HeaderText = "Technicien";
            this.nom_technicien.Name = "nom_technicien";
            this.nom_technicien.ReadOnly = true;
            // 
            // temps_debut
            // 
            this.temps_debut.DataPropertyName = "temps_debut";
            this.temps_debut.HeaderText = "Temps Debut";
            this.temps_debut.Name = "temps_debut";
            this.temps_debut.ReadOnly = true;
            // 
            // occupation_ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.data_attend);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "occupation_ad";
            this.Size = new System.Drawing.Size(1180, 669);
            this.Load += new System.EventHandler(this.occupation_ad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_attend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_attend;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_technicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps_debut;
    }
}
