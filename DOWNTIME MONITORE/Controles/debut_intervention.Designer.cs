namespace DOWNTIME_MONITORE.Controles
{
    partial class debut_intervention
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
            this.label2 = new System.Windows.Forms.Label();
            this.matricule_text = new System.Windows.Forms.TextBox();
            this.debut_intervention_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmr_probleme_text = new System.Windows.Forms.Label();
            this.ligne_text = new System.Windows.Forms.Label();
            this.station_text = new System.Windows.Forms.Label();
            this.probleme_text = new System.Windows.Forms.Label();
            this.id_combo = new System.Windows.Forms.ComboBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.mot_passe_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(518, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debut d\'intervention";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matricule :";
            // 
            // matricule_text
            // 
            this.matricule_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matricule_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_text.Location = new System.Drawing.Point(45, 260);
            this.matricule_text.Name = "matricule_text";
            this.matricule_text.Size = new System.Drawing.Size(169, 26);
            this.matricule_text.TabIndex = 9;
            // 
            // debut_intervention_btn
            // 
            this.debut_intervention_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.debut_intervention_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debut_intervention_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.debut_intervention_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debut_intervention_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.debut_intervention_btn.Location = new System.Drawing.Point(417, 260);
            this.debut_intervention_btn.Name = "debut_intervention_btn";
            this.debut_intervention_btn.Size = new System.Drawing.Size(169, 27);
            this.debut_intervention_btn.TabIndex = 19;
            this.debut_intervention_btn.Text = "Début";
            this.debut_intervention_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.debut_intervention_btn.UseVisualStyleBackColor = false;
            this.debut_intervention_btn.Click += new System.EventHandler(this.debut_intervention_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "N° :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Station : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ligne :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Probleme :";
            // 
            // nmr_probleme_text
            // 
            this.nmr_probleme_text.AutoSize = true;
            this.nmr_probleme_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmr_probleme_text.Location = new System.Drawing.Point(101, 88);
            this.nmr_probleme_text.Name = "nmr_probleme_text";
            this.nmr_probleme_text.Size = new System.Drawing.Size(0, 21);
            this.nmr_probleme_text.TabIndex = 24;
            // 
            // ligne_text
            // 
            this.ligne_text.AutoSize = true;
            this.ligne_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ligne_text.Location = new System.Drawing.Point(117, 122);
            this.ligne_text.Name = "ligne_text";
            this.ligne_text.Size = new System.Drawing.Size(0, 21);
            this.ligne_text.TabIndex = 25;
            // 
            // station_text
            // 
            this.station_text.AutoSize = true;
            this.station_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_text.Location = new System.Drawing.Point(128, 157);
            this.station_text.Name = "station_text";
            this.station_text.Size = new System.Drawing.Size(0, 21);
            this.station_text.TabIndex = 26;
            // 
            // probleme_text
            // 
            this.probleme_text.AutoSize = true;
            this.probleme_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probleme_text.Location = new System.Drawing.Point(147, 194);
            this.probleme_text.Name = "probleme_text";
            this.probleme_text.Size = new System.Drawing.Size(0, 21);
            this.probleme_text.TabIndex = 27;
            // 
            // id_combo
            // 
            this.id_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_combo.FormattingEnabled = true;
            this.id_combo.Location = new System.Drawing.Point(42, 46);
            this.id_combo.Name = "id_combo";
            this.id_combo.Size = new System.Drawing.Size(169, 29);
            this.id_combo.TabIndex = 29;
            this.id_combo.SelectedIndexChanged += new System.EventHandler(this.id_combo_SelectedIndexChanged);
            // 
            // data_production
            // 
            this.data_production.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.data_production.Location = new System.Drawing.Point(45, 305);
            this.data_production.Name = "data_production";
            this.data_production.ReadOnly = true;
            this.data_production.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_production.Size = new System.Drawing.Size(1065, 283);
            this.data_production.TabIndex = 30;
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
            // is_donne
            // 
            this.is_donne.DataPropertyName = "is_donne";
            this.is_donne.HeaderText = "Interv";
            this.is_donne.Name = "is_donne";
            this.is_donne.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mots de passe :";
            // 
            // mot_passe_text
            // 
            this.mot_passe_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mot_passe_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mot_passe_text.Location = new System.Drawing.Point(233, 260);
            this.mot_passe_text.Name = "mot_passe_text";
            this.mot_passe_text.Size = new System.Drawing.Size(169, 26);
            this.mot_passe_text.TabIndex = 31;
            this.mot_passe_text.UseSystemPasswordChar = true;
            // 
            // debut_intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mot_passe_text);
            this.Controls.Add(this.data_production);
            this.Controls.Add(this.id_combo);
            this.Controls.Add(this.probleme_text);
            this.Controls.Add(this.station_text);
            this.Controls.Add(this.ligne_text);
            this.Controls.Add(this.nmr_probleme_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debut_intervention_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricule_text);
            this.Controls.Add(this.label1);
            this.Name = "debut_intervention";
            this.Size = new System.Drawing.Size(1155, 591);
            this.Load += new System.EventHandler(this.debut_intervention_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matricule_text;
        private System.Windows.Forms.Button debut_intervention_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nmr_probleme_text;
        private System.Windows.Forms.Label ligne_text;
        private System.Windows.Forms.Label station_text;
        private System.Windows.Forms.Label probleme_text;
        private System.Windows.Forms.ComboBox id_combo;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mot_passe_text;
    }
}
