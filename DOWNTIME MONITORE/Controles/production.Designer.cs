namespace DOWNTIME_MONITORE.Controles
{
    partial class production
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
            this.label3 = new System.Windows.Forms.Label();
            this.ligne_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matricule_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.probleme_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.station_combo = new System.Windows.Forms.ComboBox();
            this.shift_combo = new System.Windows.Forms.ComboBox();
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
            this.declare_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ligne :";
            // 
            // ligne_combo
            // 
            this.ligne_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ligne_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ligne_combo.FormattingEnabled = true;
            this.ligne_combo.Location = new System.Drawing.Point(312, 134);
            this.ligne_combo.Name = "ligne_combo";
            this.ligne_combo.Size = new System.Drawing.Size(169, 29);
            this.ligne_combo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matricule :";
            // 
            // matricule_text
            // 
            this.matricule_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matricule_text.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricule_text.Location = new System.Drawing.Point(127, 137);
            this.matricule_text.Name = "matricule_text";
            this.matricule_text.Size = new System.Drawing.Size(169, 26);
            this.matricule_text.TabIndex = 7;
            this.matricule_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matricule_text_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Shift :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Probleme :";
            // 
            // probleme_combo
            // 
            this.probleme_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.probleme_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probleme_combo.FormattingEnabled = true;
            this.probleme_combo.Location = new System.Drawing.Point(685, 134);
            this.probleme_combo.Name = "probleme_combo";
            this.probleme_combo.Size = new System.Drawing.Size(169, 29);
            this.probleme_combo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Station :";
            // 
            // station_combo
            // 
            this.station_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.station_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station_combo.FormattingEnabled = true;
            this.station_combo.Location = new System.Drawing.Point(497, 134);
            this.station_combo.Name = "station_combo";
            this.station_combo.Size = new System.Drawing.Size(169, 29);
            this.station_combo.TabIndex = 15;
            // 
            // shift_combo
            // 
            this.shift_combo.Enabled = false;
            this.shift_combo.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_combo.FormattingEnabled = true;
            this.shift_combo.Location = new System.Drawing.Point(870, 134);
            this.shift_combo.Name = "shift_combo";
            this.shift_combo.Size = new System.Drawing.Size(169, 29);
            this.shift_combo.TabIndex = 11;
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
            this.data_production.Location = new System.Drawing.Point(127, 191);
            this.data_production.Name = "data_production";
            this.data_production.ReadOnly = true;
            this.data_production.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_production.Size = new System.Drawing.Size(1065, 458);
            this.data_production.TabIndex = 17;
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
            // declare_btn
            // 
            this.declare_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.declare_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.declare_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.declare_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declare_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.declare_btn.Location = new System.Drawing.Point(1045, 134);
            this.declare_btn.Name = "declare_btn";
            this.declare_btn.Size = new System.Drawing.Size(147, 29);
            this.declare_btn.TabIndex = 18;
            this.declare_btn.Text = "déclare";
            this.declare_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.declare_btn.UseVisualStyleBackColor = false;
            this.declare_btn.Click += new System.EventHandler(this.declare_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::DOWNTIME_MONITORE.Properties.Resources.Capture_d_écran_2023_08_22_041302;
            this.pictureBox3.Location = new System.Drawing.Point(1135, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 179);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DOWNTIME_MONITORE.Properties.Resources.Capture_d_écran_2023_08_22_041249;
            this.pictureBox2.Location = new System.Drawing.Point(1185, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOWNTIME_MONITORE.Properties.Resources.Capture_d_écran_2023_08_22_041238;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.declare_btn);
            this.Controls.Add(this.data_production);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.station_combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.probleme_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shift_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ligne_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricule_text);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "production";
            this.Size = new System.Drawing.Size(1370, 672);
            this.Load += new System.EventHandler(this.production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_production)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ligne_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matricule_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox probleme_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox station_combo;
        private System.Windows.Forms.ComboBox shift_combo;
        private System.Windows.Forms.DataGridView data_production;
        private System.Windows.Forms.Button declare_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_probleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_donne;
    }
}
