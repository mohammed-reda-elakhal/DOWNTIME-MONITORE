namespace DOWNTIME_MONITORE.admin
{
    partial class problemes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.accueil_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.intervention_ad1 = new DOWNTIME_MONITORE.admin.intervention_ad();
            this.occupation_ad1 = new DOWNTIME_MONITORE.admin.occupation_ad();
            this.probleme_ad1 = new DOWNTIME_MONITORE.admin.probleme_ad();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problemes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.accueil_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 35);
            this.panel2.TabIndex = 2;
            // 
            // accueil_btn
            // 
            this.accueil_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.accueil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accueil_btn.FlatAppearance.BorderSize = 0;
            this.accueil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accueil_btn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil_btn.ForeColor = System.Drawing.Color.White;
            this.accueil_btn.Location = new System.Drawing.Point(0, 0);
            this.accueil_btn.Name = "accueil_btn";
            this.accueil_btn.Size = new System.Drawing.Size(183, 34);
            this.accueil_btn.TabIndex = 2;
            this.accueil_btn.Text = "Probleme";
            this.accueil_btn.UseVisualStyleBackColor = false;
            this.accueil_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(183, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Occupation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(366, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Intervention";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // intervention_ad1
            // 
            this.intervention_ad1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intervention_ad1.Location = new System.Drawing.Point(2, 75);
            this.intervention_ad1.Name = "intervention_ad1";
            this.intervention_ad1.Size = new System.Drawing.Size(1180, 669);
            this.intervention_ad1.TabIndex = 5;
            this.intervention_ad1.Visible = false;
            // 
            // occupation_ad1
            // 
            this.occupation_ad1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.occupation_ad1.BackColor = System.Drawing.Color.White;
            this.occupation_ad1.Location = new System.Drawing.Point(2, 75);
            this.occupation_ad1.Name = "occupation_ad1";
            this.occupation_ad1.Size = new System.Drawing.Size(1180, 669);
            this.occupation_ad1.TabIndex = 4;
            this.occupation_ad1.Visible = false;
            this.occupation_ad1.Load += new System.EventHandler(this.occupation_ad1_Load);
            // 
            // probleme_ad1
            // 
            this.probleme_ad1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.probleme_ad1.BackColor = System.Drawing.Color.White;
            this.probleme_ad1.Location = new System.Drawing.Point(2, 75);
            this.probleme_ad1.Name = "probleme_ad1";
            this.probleme_ad1.Size = new System.Drawing.Size(1180, 669);
            this.probleme_ad1.TabIndex = 3;
            this.probleme_ad1.Visible = false;
            // 
            // problemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.intervention_ad1);
            this.Controls.Add(this.occupation_ad1);
            this.Controls.Add(this.probleme_ad1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "problemes";
            this.Size = new System.Drawing.Size(1181, 748);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button accueil_btn;
        private probleme_ad probleme_ad1;
        private occupation_ad occupation_ad1;
        private intervention_ad intervention_ad1;
    }
}
