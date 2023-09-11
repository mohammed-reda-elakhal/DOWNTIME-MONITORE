namespace DOWNTIME_MONITORE.admin
{
    partial class analyse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.data_analyse = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.accueil_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nom_ligne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_travaille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heur_travailler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOWNTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_top5 = new System.Windows.Forms.DataGridView();
            this.nom_ligne_top5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downtime_top5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_analyse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_top5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analyse";
            // 
            // data_analyse
            // 
            this.data_analyse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_analyse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_analyse.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_analyse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_analyse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_analyse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_ligne,
            this.TTL,
            this.Nombre_shift,
            this.Taxes,
            this.day_travaille,
            this.heur_travailler,
            this.DOWNTIME,
            this.target,
            this.disponibilité});
            this.data_analyse.Location = new System.Drawing.Point(16, 113);
            this.data_analyse.Name = "data_analyse";
            this.data_analyse.ReadOnly = true;
            this.data_analyse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_analyse.Size = new System.Drawing.Size(688, 297);
            this.data_analyse.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date Debut :";
            // 
            // date2
            // 
            this.date2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(190, 81);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(151, 26);
            this.date2.TabIndex = 36;
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(16, 81);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 26);
            this.date1.TabIndex = 35;
            // 
            // accueil_btn
            // 
            this.accueil_btn.BackColor = System.Drawing.Color.Navy;
            this.accueil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accueil_btn.FlatAppearance.BorderSize = 0;
            this.accueil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accueil_btn.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil_btn.ForeColor = System.Drawing.Color.Silver;
            this.accueil_btn.Location = new System.Drawing.Point(433, 81);
            this.accueil_btn.Name = "accueil_btn";
            this.accueil_btn.Size = new System.Drawing.Size(131, 26);
            this.accueil_btn.TabIndex = 39;
            this.accueil_btn.Text = "Filter";
            this.accueil_btn.UseVisualStyleBackColor = false;
            this.accueil_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(573, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 26);
            this.button1.TabIndex = 40;
            this.button1.Text = "Export \"Excel\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(16, 434);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1165, 300);
            this.chart1.TabIndex = 41;
            // 
            // nom_ligne
            // 
            this.nom_ligne.DataPropertyName = "nom_ligne";
            this.nom_ligne.HeaderText = "Ligne";
            this.nom_ligne.Name = "nom_ligne";
            this.nom_ligne.ReadOnly = true;
            // 
            // TTL
            // 
            this.TTL.DataPropertyName = "TTL";
            this.TTL.HeaderText = "TTL (min)";
            this.TTL.Name = "TTL";
            this.TTL.ReadOnly = true;
            // 
            // Nombre_shift
            // 
            this.Nombre_shift.DataPropertyName = "Nombre_shift";
            this.Nombre_shift.HeaderText = "Nbr Shift";
            this.Nombre_shift.Name = "Nombre_shift";
            this.Nombre_shift.ReadOnly = true;
            // 
            // Taxes
            // 
            this.Taxes.DataPropertyName = "Taxes";
            this.Taxes.HeaderText = "Taxes";
            this.Taxes.Name = "Taxes";
            this.Taxes.ReadOnly = true;
            // 
            // day_travaille
            // 
            this.day_travaille.DataPropertyName = "day_travaille";
            this.day_travaille.HeaderText = "Jours Travaille";
            this.day_travaille.Name = "day_travaille";
            this.day_travaille.ReadOnly = true;
            // 
            // heur_travailler
            // 
            this.heur_travailler.DataPropertyName = "heur_travailler";
            this.heur_travailler.HeaderText = "Heures Travaille";
            this.heur_travailler.Name = "heur_travailler";
            this.heur_travailler.ReadOnly = true;
            // 
            // DOWNTIME
            // 
            this.DOWNTIME.DataPropertyName = "DOWNTIME";
            this.DOWNTIME.HeaderText = "DOWNTIME %";
            this.DOWNTIME.Name = "DOWNTIME";
            this.DOWNTIME.ReadOnly = true;
            // 
            // target
            // 
            this.target.DataPropertyName = "target";
            this.target.HeaderText = "Target %";
            this.target.Name = "target";
            this.target.ReadOnly = true;
            // 
            // disponibilité
            // 
            this.disponibilité.DataPropertyName = "disponibilité";
            this.disponibilité.HeaderText = "disponibilité %";
            this.disponibilité.Name = "disponibilité";
            this.disponibilité.ReadOnly = true;
            // 
            // data_top5
            // 
            this.data_top5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_top5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_top5.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_top5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_top5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_ligne_top5,
            this.downtime_top5,
            this.probleme});
            this.data_top5.Location = new System.Drawing.Point(742, 113);
            this.data_top5.Name = "data_top5";
            this.data_top5.ReadOnly = true;
            this.data_top5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_top5.Size = new System.Drawing.Size(427, 297);
            this.data_top5.TabIndex = 42;
            this.data_top5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_top5_CellContentClick);
            // 
            // nom_ligne_top5
            // 
            this.nom_ligne_top5.DataPropertyName = "nom_ligne";
            this.nom_ligne_top5.HeaderText = "Ligne";
            this.nom_ligne_top5.Name = "nom_ligne_top5";
            this.nom_ligne_top5.ReadOnly = true;
            // 
            // downtime_top5
            // 
            this.downtime_top5.DataPropertyName = "TTL";
            this.downtime_top5.HeaderText = "Downtime";
            this.downtime_top5.Name = "downtime_top5";
            this.downtime_top5.ReadOnly = true;
            // 
            // probleme
            // 
            this.probleme.DataPropertyName = "nom_probleme";
            this.probleme.HeaderText = "Probleme Majoure";
            this.probleme.Name = "probleme";
            this.probleme.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(738, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Top 5 Lignes ont grandes DOWNTIME :";
            // 
            // analyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_top5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accueil_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.data_analyse);
            this.Controls.Add(this.panel1);
            this.Name = "analyse";
            this.Size = new System.Drawing.Size(1181, 748);
            this.Load += new System.EventHandler(this.analyse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_analyse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_top5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_analyse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button accueil_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_travaille;
        private System.Windows.Forms.DataGridViewTextBoxColumn heur_travailler;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOWNTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilité;
        private System.Windows.Forms.DataGridView data_top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne_top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn downtime_top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn probleme;
        private System.Windows.Forms.Label label3;
    }
}
