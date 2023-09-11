namespace DOWNTIME_MONITORE.admin
{
    partial class probleme_ad
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
            this.data_production = new System.Windows.Forms.DataGridView();
            this.id_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_donne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).BeginInit();
            this.SuspendLayout();
            // 
            // data_production
            // 
            this.data_production.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_production.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_production.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_production.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_production.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_production.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_probleme,
            this.date,
            this.temps,
            this.shift,
            this.matricule,
            this.nom_ligne,
            this.nom_probleme,
            this.nom_station,
            this.is_donne});
            this.data_production.Location = new System.Drawing.Point(3, 85);
            this.data_production.Name = "data_production";
            this.data_production.ReadOnly = true;
            this.data_production.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_production.Size = new System.Drawing.Size(1174, 569);
            this.data_production.TabIndex = 18;
            // 
            // id_probleme
            // 
            this.id_probleme.DataPropertyName = "id_probleme";
            this.id_probleme.HeaderText = "N°";
            this.id_probleme.Name = "id_probleme";
            this.id_probleme.ReadOnly = true;
            this.id_probleme.Visible = false;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // temps
            // 
            this.temps.DataPropertyName = "temps";
            this.temps.HeaderText = "temps";
            this.temps.Name = "temps";
            this.temps.ReadOnly = true;
            // 
            // shift
            // 
            this.shift.DataPropertyName = "shift";
            this.shift.HeaderText = "shift";
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "matricule";
            this.matricule.HeaderText = "matricule";
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
            // is_donne
            // 
            this.is_donne.DataPropertyName = "is_donne";
            this.is_donne.HeaderText = "Interv";
            this.is_donne.Name = "is_donne";
            this.is_donne.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(514, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 1);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(522, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Problemes";
            // 
            // probleme_ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_production);
            this.Name = "probleme_ad";
            this.Size = new System.Drawing.Size(1180, 669);
            this.Load += new System.EventHandler(this.probleme_ad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_production;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_donne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
