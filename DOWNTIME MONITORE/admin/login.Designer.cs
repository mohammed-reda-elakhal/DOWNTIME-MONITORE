namespace DOWNTIME_MONITORE.admin
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.login_groupe = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.mot_de_passe_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom_utilisateur_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.login_groupe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::DOWNTIME_MONITORE.Properties.Resources.error;
            this.close_btn.Location = new System.Drawing.Point(1329, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 37);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 1;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // login_groupe
            // 
            this.login_groupe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login_groupe.Controls.Add(this.label3);
            this.login_groupe.Controls.Add(this.login_btn);
            this.login_groupe.Controls.Add(this.mot_de_passe_text);
            this.login_groupe.Controls.Add(this.label2);
            this.login_groupe.Controls.Add(this.nom_utilisateur_text);
            this.login_groupe.Controls.Add(this.label1);
            this.login_groupe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_groupe.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_groupe.Location = new System.Drawing.Point(487, 165);
            this.login_groupe.Name = "login_groupe";
            this.login_groupe.Size = new System.Drawing.Size(404, 378);
            this.login_groupe.TabIndex = 2;
            this.login_groupe.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(54, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Connection Coordinateur";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(18, 278);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(153, 33);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Connection";
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // mot_de_passe_text
            // 
            this.mot_de_passe_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mot_de_passe_text.Location = new System.Drawing.Point(18, 230);
            this.mot_de_passe_text.Name = "mot_de_passe_text";
            this.mot_de_passe_text.Size = new System.Drawing.Size(339, 26);
            this.mot_de_passe_text.TabIndex = 3;
            this.mot_de_passe_text.UseSystemPasswordChar = true;
            this.mot_de_passe_text.TextChanged += new System.EventHandler(this.mot_de_passe_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nom_utilisateur_text
            // 
            this.nom_utilisateur_text.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_utilisateur_text.Location = new System.Drawing.Point(18, 157);
            this.nom_utilisateur_text.Name = "nom_utilisateur_text";
            this.nom_utilisateur_text.Size = new System.Drawing.Size(339, 26);
            this.nom_utilisateur_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOWNTIME_MONITORE.Properties.Resources.Capture_d_écran_2023_08_22_041238;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_groupe);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.login_groupe.ResumeLayout(false);
            this.login_groupe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.GroupBox login_groupe;
        private System.Windows.Forms.TextBox nom_utilisateur_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mot_de_passe_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}