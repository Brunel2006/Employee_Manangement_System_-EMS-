namespace StaffPro_V1._0
{
    partial class Acceuil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitterAcceuil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitreAcceuil = new System.Windows.Forms.Label();
            this.DetailAcceuil = new System.Windows.Forms.Label();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkConnexion = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuitterAcceuil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.QuitterAcceuil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 30);
            this.panel1.TabIndex = 0;
            // 
            // QuitterAcceuil
            // 
            this.QuitterAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.QuitterAcceuil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitterAcceuil.Image = global::StaffPro_V1._0.Properties.Resources.croix_cercle;
            this.QuitterAcceuil.Location = new System.Drawing.Point(475, 0);
            this.QuitterAcceuil.Name = "QuitterAcceuil";
            this.QuitterAcceuil.Size = new System.Drawing.Size(43, 30);
            this.QuitterAcceuil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuitterAcceuil.TabIndex = 1;
            this.QuitterAcceuil.TabStop = false;
            this.QuitterAcceuil.Click += new System.EventHandler(this.QuitterAcceuil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffPro - Acceuil";
            // 
            // TitreAcceuil
            // 
            this.TitreAcceuil.AutoSize = true;
            this.TitreAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.TitreAcceuil.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAcceuil.Location = new System.Drawing.Point(120, 137);
            this.TitreAcceuil.Name = "TitreAcceuil";
            this.TitreAcceuil.Size = new System.Drawing.Size(284, 51);
            this.TitreAcceuil.TabIndex = 1;
            this.TitreAcceuil.Text = "StaffPro V1.0";
            // 
            // DetailAcceuil
            // 
            this.DetailAcceuil.AutoSize = true;
            this.DetailAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.DetailAcceuil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailAcceuil.Location = new System.Drawing.Point(5, 203);
            this.DetailAcceuil.Name = "DetailAcceuil";
            this.DetailAcceuil.Size = new System.Drawing.Size(506, 57);
            this.DetailAcceuil.TabIndex = 4;
            this.DetailAcceuil.Text = "StaffPro est un systeme de gestion des employés qui offre\r\nune sécurité, une fiab" +
    "ilité et un contrôle total des données de vos \r\nemployés.";
            this.DetailAcceuil.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCommencer
            // 
            this.btnCommencer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(75)))));
            this.btnCommencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommencer.FlatAppearance.BorderSize = 0;
            this.btnCommencer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.btnCommencer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(138)))));
            this.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommencer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommencer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCommencer.Location = new System.Drawing.Point(129, 291);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(275, 47);
            this.btnCommencer.TabIndex = 5;
            this.btnCommencer.Text = "Commencer maintenant !!";
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "deja un compte ?";
            // 
            // lnkConnexion
            // 
            this.lnkConnexion.AutoSize = true;
            this.lnkConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lnkConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkConnexion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConnexion.Location = new System.Drawing.Point(136, 385);
            this.lnkConnexion.Name = "lnkConnexion";
            this.lnkConnexion.Size = new System.Drawing.Size(99, 19);
            this.lnkConnexion.TabIndex = 7;
            this.lnkConnexion.TabStop = true;
            this.lnkConnexion.Text = "Se Connecter";
            this.lnkConnexion.Click += new System.EventHandler(this.lnkConnexion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::StaffPro_V1._0.Properties.Resources.icons8_employé_100;
            this.pictureBox4.Location = new System.Drawing.Point(207, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 411);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lnkConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.DetailAcceuil);
            this.Controls.Add(this.TitreAcceuil);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPro V1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuitterAcceuil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox QuitterAcceuil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitreAcceuil;
        private System.Windows.Forms.Label DetailAcceuil;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkConnexion;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

