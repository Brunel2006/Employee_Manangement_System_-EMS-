namespace StaffPro_V1._0
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitterMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.PictureBox();
            this.btnDepartement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnSanction = new System.Windows.Forms.Button();
            this.btnSalaire = new System.Windows.Forms.Button();
            this.btnRecrutement = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashBoard1 = new StaffPro_V1._0.DashBoard();
            this.recrutement1 = new StaffPro_V1._0.Recrutement();
            this.salaire1 = new StaffPro_V1._0.Salaire();
            this.sanction1 = new StaffPro_V1._0.Sanction();
            this.departement1 = new StaffPro_V1._0.Departement();
            this.recrutement2 = new StaffPro_V1._0.Recrutement();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeconnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuitterMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 47);
            this.panel1.TabIndex = 0;
            // 
            // QuitterMenu
            // 
            this.QuitterMenu.BackColor = System.Drawing.Color.Transparent;
            this.QuitterMenu.FlatAppearance.BorderSize = 0;
            this.QuitterMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.QuitterMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.QuitterMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitterMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitterMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuitterMenu.Location = new System.Drawing.Point(939, 7);
            this.QuitterMenu.Name = "QuitterMenu";
            this.QuitterMenu.Size = new System.Drawing.Size(34, 32);
            this.QuitterMenu.TabIndex = 3;
            this.QuitterMenu.Text = "X";
            this.QuitterMenu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.QuitterMenu.UseVisualStyleBackColor = false;
            this.QuitterMenu.Click += new System.EventHandler(this.QuitterMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(172, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "V1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "StaffPro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnDeconnexion);
            this.panel2.Controls.Add(this.btnDepartement);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnParametre);
            this.panel2.Controls.Add(this.btnSanction);
            this.panel2.Controls.Add(this.btnSalaire);
            this.panel2.Controls.Add(this.btnRecrutement);
            this.panel2.Controls.Add(this.btnTableauDeBord);
            this.panel2.Controls.Add(this.lblBienvenue);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 514);
            this.panel2.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.Image = global::StaffPro_V1._0.Properties.Resources.icons8_déconnexion_50;
            this.btnDeconnexion.Location = new System.Drawing.Point(11, 462);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(36, 37);
            this.btnDeconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.TabStop = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnDepartement
            // 
            this.btnDepartement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDepartement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnDepartement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDepartement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartement.ForeColor = System.Drawing.Color.Black;
            this.btnDepartement.Image = global::StaffPro_V1._0.Properties.Resources.icons8_département_50;
            this.btnDepartement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartement.Location = new System.Drawing.Point(12, 359);
            this.btnDepartement.Name = "btnDepartement";
            this.btnDepartement.Size = new System.Drawing.Size(220, 49);
            this.btnDepartement.TabIndex = 4;
            this.btnDepartement.Text = "            DEPARTEMENT";
            this.btnDepartement.UseVisualStyleBackColor = false;
            this.btnDepartement.Click += new System.EventHandler(this.btnDepartement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(51, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "DECONNEXION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.BackColor = System.Drawing.Color.Transparent;
            this.btnParametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParametre.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnParametre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnParametre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.Image = global::StaffPro_V1._0.Properties.Resources.icons8_settings_501;
            this.btnParametre.Location = new System.Drawing.Point(177, 414);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(51, 49);
            this.btnParametre.TabIndex = 5;
            this.btnParametre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnParametre.UseVisualStyleBackColor = false;
            // 
            // btnSanction
            // 
            this.btnSanction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSanction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSanction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSanction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanction.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSanction.Image = global::StaffPro_V1._0.Properties.Resources.icons8_interdit_50;
            this.btnSanction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanction.Location = new System.Drawing.Point(12, 304);
            this.btnSanction.Name = "btnSanction";
            this.btnSanction.Size = new System.Drawing.Size(220, 49);
            this.btnSanction.TabIndex = 4;
            this.btnSanction.Text = "       SANCTION";
            this.btnSanction.UseVisualStyleBackColor = false;
            this.btnSanction.Click += new System.EventHandler(this.btnSanction_Click);
            // 
            // btnSalaire
            // 
            this.btnSalaire.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSalaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalaire.Image = global::StaffPro_V1._0.Properties.Resources.icons8_argent_30;
            this.btnSalaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaire.Location = new System.Drawing.Point(12, 249);
            this.btnSalaire.Name = "btnSalaire";
            this.btnSalaire.Size = new System.Drawing.Size(220, 49);
            this.btnSalaire.TabIndex = 4;
            this.btnSalaire.Text = "     SALAIRE";
            this.btnSalaire.UseVisualStyleBackColor = false;
            this.btnSalaire.Click += new System.EventHandler(this.btnSalaire_Click);
            // 
            // btnRecrutement
            // 
            this.btnRecrutement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecrutement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecrutement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnRecrutement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRecrutement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRecrutement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecrutement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecrutement.ForeColor = System.Drawing.Color.Black;
            this.btnRecrutement.Image = global::StaffPro_V1._0.Properties.Resources.icons8_ajouter_un_utilisateur_homme_50;
            this.btnRecrutement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecrutement.Location = new System.Drawing.Point(12, 194);
            this.btnRecrutement.Name = "btnRecrutement";
            this.btnRecrutement.Size = new System.Drawing.Size(220, 49);
            this.btnRecrutement.TabIndex = 4;
            this.btnRecrutement.Text = "            RECRUTEMENT";
            this.btnRecrutement.UseVisualStyleBackColor = false;
            this.btnRecrutement.Click += new System.EventHandler(this.btnRecrutement_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTableauDeBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauDeBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnTableauDeBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTableauDeBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTableauDeBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableauDeBord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.ForeColor = System.Drawing.Color.Black;
            this.btnTableauDeBord.Image = global::StaffPro_V1._0.Properties.Resources.icons8_macbook_de_performance_50;
            this.btnTableauDeBord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableauDeBord.Location = new System.Drawing.Point(12, 139);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(220, 49);
            this.btnTableauDeBord.TabIndex = 4;
            this.btnTableauDeBord.Text = "  TABLEAU DE BORD";
            this.btnTableauDeBord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBienvenue.Location = new System.Drawing.Point(36, 93);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(170, 23);
            this.lblBienvenue.TabIndex = 3;
            this.lblBienvenue.Text = "Bienvenue, Utilisateur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaffPro_V1._0.Properties.Resources.icons8_employé_100;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashBoard1);
            this.panel3.Controls.Add(this.recrutement1);
            this.panel3.Controls.Add(this.salaire1);
            this.panel3.Controls.Add(this.sanction1);
            this.panel3.Controls.Add(this.departement1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(238, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 514);
            this.panel3.TabIndex = 2;
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dashBoard1.Location = new System.Drawing.Point(0, 0);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(746, 514);
            this.dashBoard1.TabIndex = 4;
            // 
            // recrutement1
            // 
            this.recrutement1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.recrutement1.Location = new System.Drawing.Point(0, 0);
            this.recrutement1.Name = "recrutement1";
            this.recrutement1.Size = new System.Drawing.Size(750, 520);
            this.recrutement1.TabIndex = 3;
            // 
            // salaire1
            // 
            this.salaire1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.salaire1.Location = new System.Drawing.Point(0, 0);
            this.salaire1.Name = "salaire1";
            this.salaire1.Size = new System.Drawing.Size(746, 514);
            this.salaire1.TabIndex = 2;
            // 
            // sanction1
            // 
            this.sanction1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sanction1.Location = new System.Drawing.Point(0, 0);
            this.sanction1.Name = "sanction1";
            this.sanction1.Size = new System.Drawing.Size(746, 514);
            this.sanction1.TabIndex = 1;
            // 
            // departement1
            // 
            this.departement1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.departement1.Location = new System.Drawing.Point(0, -1);
            this.departement1.Name = "departement1";
            this.departement1.Size = new System.Drawing.Size(746, 514);
            this.departement1.TabIndex = 0;
            // 
            // recrutement2
            // 
            this.recrutement2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.recrutement2.Location = new System.Drawing.Point(-4, 0);
            this.recrutement2.Name = "recrutement2";
            this.recrutement2.Size = new System.Drawing.Size(750, 520);
            this.recrutement2.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeconnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnSanction;
        private System.Windows.Forms.Button btnSalaire;
        private System.Windows.Forms.Button btnRecrutement;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepartement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button QuitterMenu;
        private System.Windows.Forms.PictureBox btnDeconnexion;
        private Recrutement recrutement2;
        private System.Windows.Forms.Button btnParametre;
        private Departement departement1;
        private Salaire salaire1;
        private Sanction sanction1;
        private Recrutement recrutement1;
        private DashBoard dashBoard1;
    }
}