namespace DOWNTIME_MONITORE.admin
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.probleme_label = new System.Windows.Forms.Label();
            this.probleme_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.occupation_btn = new System.Windows.Forms.Button();
            this.occupation_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.interv_btn = new System.Windows.Forms.Button();
            this.intervention_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Text = "Accueil";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.probleme_btn);
            this.groupBox1.Controls.Add(this.probleme_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(93, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Problemes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tous les problemes \r\ndéclarer aujourd\'huit\r\n";
            // 
            // probleme_label
            // 
            this.probleme_label.AutoSize = true;
            this.probleme_label.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probleme_label.ForeColor = System.Drawing.Color.DarkRed;
            this.probleme_label.Location = new System.Drawing.Point(17, 110);
            this.probleme_label.Name = "probleme_label";
            this.probleme_label.Size = new System.Drawing.Size(34, 39);
            this.probleme_label.TabIndex = 5;
            this.probleme_label.Text = "0";
            // 
            // probleme_btn
            // 
            this.probleme_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.probleme_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.probleme_btn.FlatAppearance.BorderSize = 0;
            this.probleme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.probleme_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probleme_btn.ForeColor = System.Drawing.Color.Black;
            this.probleme_btn.Location = new System.Drawing.Point(180, 124);
            this.probleme_btn.Name = "probleme_btn";
            this.probleme_btn.Size = new System.Drawing.Size(100, 29);
            this.probleme_btn.TabIndex = 3;
            this.probleme_btn.Text = "Voir plus";
            this.probleme_btn.UseVisualStyleBackColor = false;
            this.probleme_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.occupation_btn);
            this.groupBox2.Controls.Add(this.occupation_label);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(429, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 159);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // occupation_btn
            // 
            this.occupation_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.occupation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.occupation_btn.FlatAppearance.BorderSize = 0;
            this.occupation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.occupation_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation_btn.ForeColor = System.Drawing.Color.Black;
            this.occupation_btn.Location = new System.Drawing.Point(180, 124);
            this.occupation_btn.Name = "occupation_btn";
            this.occupation_btn.Size = new System.Drawing.Size(100, 29);
            this.occupation_btn.TabIndex = 3;
            this.occupation_btn.Text = "Voir plus";
            this.occupation_btn.UseVisualStyleBackColor = false;
            this.occupation_btn.Click += new System.EventHandler(this.occupation_btn_Click);
            // 
            // occupation_label
            // 
            this.occupation_label.AutoSize = true;
            this.occupation_label.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.occupation_label.Location = new System.Drawing.Point(17, 110);
            this.occupation_label.Name = "occupation_label";
            this.occupation_label.Size = new System.Drawing.Size(34, 39);
            this.occupation_label.TabIndex = 5;
            this.occupation_label.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tous les occupations \r\nactuelles\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Occupation :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Controls.Add(this.interv_btn);
            this.groupBox3.Controls.Add(this.intervention_label);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(763, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 159);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // interv_btn
            // 
            this.interv_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.interv_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interv_btn.FlatAppearance.BorderSize = 0;
            this.interv_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interv_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interv_btn.ForeColor = System.Drawing.Color.Black;
            this.interv_btn.Location = new System.Drawing.Point(180, 124);
            this.interv_btn.Name = "interv_btn";
            this.interv_btn.Size = new System.Drawing.Size(100, 29);
            this.interv_btn.TabIndex = 3;
            this.interv_btn.Text = "Voir plus";
            this.interv_btn.UseVisualStyleBackColor = false;
            this.interv_btn.Click += new System.EventHandler(this.interv_btn_Click);
            // 
            // intervention_label
            // 
            this.intervention_label.AutoSize = true;
            this.intervention_label.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervention_label.ForeColor = System.Drawing.Color.Green;
            this.intervention_label.Location = new System.Drawing.Point(17, 110);
            this.intervention_label.Name = "intervention_label";
            this.intervention_label.Size = new System.Drawing.Size(34, 39);
            this.intervention_label.TabIndex = 5;
            this.intervention_label.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tous les interventions \r\néffectuer aujourd\'huit\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Interventions :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DOWNTIME_MONITORE.Properties.Resources.problem_solving2;
            this.pictureBox3.Location = new System.Drawing.Point(180, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DOWNTIME_MONITORE.Properties.Resources.solution1;
            this.pictureBox2.Location = new System.Drawing.Point(180, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOWNTIME_MONITORE.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(180, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "accueil";
            this.Size = new System.Drawing.Size(1181, 748);
            this.Load += new System.EventHandler(this.accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label probleme_label;
        private System.Windows.Forms.Button probleme_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button occupation_btn;
        private System.Windows.Forms.Label occupation_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button interv_btn;
        private System.Windows.Forms.Label intervention_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
