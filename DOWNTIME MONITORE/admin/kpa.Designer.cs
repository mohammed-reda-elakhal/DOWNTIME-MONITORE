namespace DOWNTIME_MONITORE.admin
{
    partial class kpa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data_mttr = new System.Windows.Forms.DataGridView();
            this.nom_ligne_top5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mttr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_mtbf = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.accueil_btn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart_mttr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_mtbf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mttr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_mtbf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mttr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mtbf)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Performance Indicator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(490, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 708);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MTTR - Temps moyen de réparation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(498, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "MTBF - Délai moyen entre pannes";
            // 
            // data_mttr
            // 
            this.data_mttr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_mttr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_mttr.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_mttr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_mttr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mttr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_ligne_top5,
            this.mttr});
            this.data_mttr.Location = new System.Drawing.Point(16, 84);
            this.data_mttr.Name = "data_mttr";
            this.data_mttr.ReadOnly = true;
            this.data_mttr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_mttr.Size = new System.Drawing.Size(452, 273);
            this.data_mttr.TabIndex = 43;
            // 
            // nom_ligne_top5
            // 
            this.nom_ligne_top5.DataPropertyName = "nom_ligne";
            this.nom_ligne_top5.HeaderText = "Ligne";
            this.nom_ligne_top5.Name = "nom_ligne_top5";
            this.nom_ligne_top5.ReadOnly = true;
            // 
            // mttr
            // 
            this.mttr.DataPropertyName = "mttr";
            this.mttr.HeaderText = "MTTR";
            this.mttr.Name = "mttr";
            this.mttr.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(980, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 708);
            this.panel3.TabIndex = 5;
            // 
            // data_mtbf
            // 
            this.data_mtbf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_mtbf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_mtbf.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.data_mtbf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_mtbf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mtbf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.mtbf});
            this.data_mtbf.Location = new System.Drawing.Point(503, 84);
            this.data_mtbf.Name = "data_mtbf";
            this.data_mtbf.ReadOnly = true;
            this.data_mtbf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_mtbf.Size = new System.Drawing.Size(452, 273);
            this.data_mtbf.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(984, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Date Fin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(984, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Date Debut :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // date2
            // 
            this.date2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(988, 140);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(151, 26);
            this.date2.TabIndex = 47;
            // 
            // date1
            // 
            this.date1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(988, 75);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 26);
            this.date1.TabIndex = 46;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // accueil_btn
            // 
            this.accueil_btn.BackColor = System.Drawing.Color.Navy;
            this.accueil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accueil_btn.FlatAppearance.BorderSize = 0;
            this.accueil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accueil_btn.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil_btn.ForeColor = System.Drawing.Color.Silver;
            this.accueil_btn.Location = new System.Drawing.Point(988, 183);
            this.accueil_btn.Name = "accueil_btn";
            this.accueil_btn.Size = new System.Drawing.Size(131, 26);
            this.accueil_btn.TabIndex = 50;
            this.accueil_btn.Text = "Filter";
            this.accueil_btn.UseVisualStyleBackColor = false;
            this.accueil_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nom_ligne";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ligne";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mtbf
            // 
            this.mtbf.DataPropertyName = "mtbf";
            this.mtbf.HeaderText = "MTBF";
            this.mtbf.Name = "mtbf";
            this.mtbf.ReadOnly = true;
            // 
            // chart_mttr
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_mttr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_mttr.Legends.Add(legend1);
            this.chart_mttr.Location = new System.Drawing.Point(16, 363);
            this.chart_mttr.Name = "chart_mttr";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_mttr.Series.Add(series1);
            this.chart_mttr.Size = new System.Drawing.Size(468, 382);
            this.chart_mttr.TabIndex = 51;
            this.chart_mttr.Text = "chart_mttr";
            // 
            // chart_mtbf
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_mtbf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_mtbf.Legends.Add(legend2);
            this.chart_mtbf.Location = new System.Drawing.Point(503, 363);
            this.chart_mtbf.Name = "chart_mtbf";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_mtbf.Series.Add(series2);
            this.chart_mtbf.Size = new System.Drawing.Size(471, 382);
            this.chart_mtbf.TabIndex = 52;
            this.chart_mtbf.Text = "chart_mtbf";
            // 
            // kpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_mtbf);
            this.Controls.Add(this.chart_mttr);
            this.Controls.Add(this.accueil_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.data_mtbf);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.data_mttr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "kpa";
            this.Size = new System.Drawing.Size(1181, 748);
            this.Load += new System.EventHandler(this.kpa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mttr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_mtbf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mttr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mtbf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_mttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ligne_top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn mttr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView data_mtbf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button accueil_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtbf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mttr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mtbf;
    }
}
