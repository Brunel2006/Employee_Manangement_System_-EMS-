namespace StaffPro_V1._0
{
    partial class Connexion
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
            this.components = new System.ComponentModel.Container();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.MotDePasseConnexion = new System.Windows.Forms.TextBox();
            this.NomUtilisateurConnexion = new System.Windows.Forms.TextBox();
            this.ValiderConnexion = new System.Windows.Forms.Button();
            this.chkAfficherMotDePasseConnexion = new System.Windows.Forms.CheckBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.QuitterConnexion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageConnexion = new System.Windows.Forms.PictureBox();
            this.panelInscription = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnInscription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageConnexion)).BeginInit();
            this.panelInscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexion.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(285, 112);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(316, 38);
            this.lblConnexion.TabIndex = 12;
            this.lblConnexion.Text = "AUTHENTIFICATION";
            this.lblConnexion.Click += new System.EventHandler(this.lblConnexion_Click);
            // 
            // MotDePasseConnexion
            // 
            this.MotDePasseConnexion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotDePasseConnexion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MotDePasseConnexion.Location = new System.Drawing.Point(375, 281);
            this.MotDePasseConnexion.Name = "MotDePasseConnexion";
            this.MotDePasseConnexion.PasswordChar = '*';
            this.MotDePasseConnexion.Size = new System.Drawing.Size(180, 34);
            this.MotDePasseConnexion.TabIndex = 24;
            this.MotDePasseConnexion.Text = "Mot de Passe";
            this.MotDePasseConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MotDePasseConnexion.Click += new System.EventHandler(this.MotDePasseConnexion_Click);
            this.MotDePasseConnexion.TextChanged += new System.EventHandler(this.MotDePasseConnexion_TextChanged);
            // 
            // NomUtilisateurConnexion
            // 
            this.NomUtilisateurConnexion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUtilisateurConnexion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NomUtilisateurConnexion.Location = new System.Drawing.Point(376, 211);
            this.NomUtilisateurConnexion.Name = "NomUtilisateurConnexion";
            this.NomUtilisateurConnexion.Size = new System.Drawing.Size(180, 34);
            this.NomUtilisateurConnexion.TabIndex = 25;
            this.NomUtilisateurConnexion.Text = "Nom Utilisateur";
            this.NomUtilisateurConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomUtilisateurConnexion.Click += new System.EventHandler(this.NomUtilisateurConnexion_Click);
            this.NomUtilisateurConnexion.TextChanged += new System.EventHandler(this.NomUtilisateurConnexion_TextChanged);
            // 
            // ValiderConnexion
            // 
            this.ValiderConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ValiderConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValiderConnexion.FlatAppearance.BorderSize = 0;
            this.ValiderConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ValiderConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ValiderConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValiderConnexion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderConnexion.ForeColor = System.Drawing.Color.White;
            this.ValiderConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValiderConnexion.Location = new System.Drawing.Point(308, 373);
            this.ValiderConnexion.Name = "ValiderConnexion";
            this.ValiderConnexion.Size = new System.Drawing.Size(247, 40);
            this.ValiderConnexion.TabIndex = 23;
            this.ValiderConnexion.Text = "VALIDER";
            this.ValiderConnexion.UseVisualStyleBackColor = false;
            this.ValiderConnexion.Click += new System.EventHandler(this.ValiderConnexion_Click);
            // 
            // chkAfficherMotDePasseConnexion
            // 
            this.chkAfficherMotDePasseConnexion.AutoSize = true;
            this.chkAfficherMotDePasseConnexion.BackColor = System.Drawing.Color.Transparent;
            this.chkAfficherMotDePasseConnexion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAfficherMotDePasseConnexion.Location = new System.Drawing.Point(416, 317);
            this.chkAfficherMotDePasseConnexion.Name = "chkAfficherMotDePasseConnexion";
            this.chkAfficherMotDePasseConnexion.Size = new System.Drawing.Size(140, 19);
            this.chkAfficherMotDePasseConnexion.TabIndex = 22;
            this.chkAfficherMotDePasseConnexion.Text = "Afficher mot de passe";
            this.chkAfficherMotDePasseConnexion.UseVisualStyleBackColor = false;
            this.chkAfficherMotDePasseConnexion.CheckedChanged += new System.EventHandler(this.chkAfficherMotDePasseConnexion_CheckedChanged);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Cambria Math", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(326, 158);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 50);
            this.lblErreur.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(292, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 25);
            this.progressBar1.TabIndex = 27;
            // 
            // QuitterConnexion
            // 
            this.QuitterConnexion.BackColor = System.Drawing.SystemColors.Highlight;
            this.QuitterConnexion.FlatAppearance.BorderSize = 0;
            this.QuitterConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.QuitterConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.QuitterConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitterConnexion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitterConnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuitterConnexion.Location = new System.Drawing.Point(579, 6);
            this.QuitterConnexion.Name = "QuitterConnexion";
            this.QuitterConnexion.Size = new System.Drawing.Size(34, 32);
            this.QuitterConnexion.TabIndex = 28;
            this.QuitterConnexion.Text = "X";
            this.QuitterConnexion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.QuitterConnexion.UseVisualStyleBackColor = false;
            this.QuitterConnexion.Click += new System.EventHandler(this.QuitterConnexion_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StaffPro_V1._0.Properties.Resources.bloquer;
            this.pictureBox2.Location = new System.Drawing.Point(306, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StaffPro_V1._0.Properties.Resources.icons8_utilisateur_30;
            this.pictureBox1.Location = new System.Drawing.Point(308, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // ImageConnexion
            // 
            this.ImageConnexion.BackColor = System.Drawing.Color.Transparent;
            this.ImageConnexion.Image = global::StaffPro_V1._0.Properties.Resources.icons8_connexion_50;
            this.ImageConnexion.Location = new System.Drawing.Point(398, 33);
            this.ImageConnexion.Name = "ImageConnexion";
            this.ImageConnexion.Size = new System.Drawing.Size(87, 76);
            this.ImageConnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageConnexion.TabIndex = 13;
            this.ImageConnexion.TabStop = false;
            // 
            // panelInscription
            // 
            this.panelInscription.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelInscription.Controls.Add(this.pictureBox4);
            this.panelInscription.Controls.Add(this.btnInscription);
            this.panelInscription.Controls.Add(this.label1);
            this.panelInscription.Controls.Add(this.label2);
            this.panelInscription.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInscription.Location = new System.Drawing.Point(0, 0);
            this.panelInscription.Name = "panelInscription";
            this.panelInscription.Size = new System.Drawing.Size(261, 441);
            this.panelInscription.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::StaffPro_V1._0.Properties.Resources.icons8_employé_100;
            this.pictureBox4.Location = new System.Drawing.Point(80, 89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(8)))), ((int)(((byte)(158)))));
            this.btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInscription.FlatAppearance.BorderSize = 0;
            this.btnInscription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInscription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInscription.Location = new System.Drawing.Point(72, 380);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(113, 36);
            this.btnInscription.TabIndex = 9;
            this.btnInscription.Text = "S\'INSCRIRE";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Visible = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(177, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "V1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "StaffPro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 441);
            this.Controls.Add(this.QuitterConnexion);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.MotDePasseConnexion);
            this.Controls.Add(this.NomUtilisateurConnexion);
            this.Controls.Add(this.ValiderConnexion);
            this.Controls.Add(this.chkAfficherMotDePasseConnexion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImageConnexion);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.panelInscription);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageConnexion)).EndInit();
            this.panelInscription.ResumeLayout(false);
            this.panelInscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInscription;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.PictureBox ImageConnexion;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TextBox MotDePasseConnexion;
        private System.Windows.Forms.TextBox NomUtilisateurConnexion;
        private System.Windows.Forms.Button ValiderConnexion;
        private System.Windows.Forms.CheckBox chkAfficherMotDePasseConnexion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button QuitterConnexion;

    }
}