namespace StaffPro_V1._0
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblPosteEmploye = new System.Windows.Forms.Label();
            this.lblPoste = new System.Windows.Forms.Label();
            this.btnAjouterPhoto = new System.Windows.Forms.Button();
            this.btnImprimerFiche = new System.Windows.Forms.Button();
            this.pbAfficherPhoto = new System.Windows.Forms.PictureBox();
            this.lblDerniereModificationEmploye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDureeContratEmploye = new System.Windows.Forms.Label();
            this.lblStatutEmploye = new System.Windows.Forms.Label();
            this.lblSexeEmploye = new System.Windows.Forms.Label();
            this.lblDateInsertionEmploye = new System.Windows.Forms.Label();
            this.lblNumTelEmploye = new System.Windows.Forms.Label();
            this.lblDepartementEmploye = new System.Windows.Forms.Label();
            this.lblPrenomEmploye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalaireEmploye = new System.Windows.Forms.Label();
            this.lblNomEmploye = new System.Windows.Forms.Label();
            this.lblIdentifiantEmploye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDerniereModification = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblDateInsertion = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfficherPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaffPro_V1._0.Properties.Resources.icons8_employé_100;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiche de renseignement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.lblPosteEmploye);
            this.panel.Controls.Add(this.lblPoste);
            this.panel.Controls.Add(this.btnAjouterPhoto);
            this.panel.Controls.Add(this.btnImprimerFiche);
            this.panel.Controls.Add(this.pbAfficherPhoto);
            this.panel.Controls.Add(this.lblDerniereModificationEmploye);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lblDureeContratEmploye);
            this.panel.Controls.Add(this.lblStatutEmploye);
            this.panel.Controls.Add(this.lblSexeEmploye);
            this.panel.Controls.Add(this.lblDateInsertionEmploye);
            this.panel.Controls.Add(this.lblNumTelEmploye);
            this.panel.Controls.Add(this.lblDepartementEmploye);
            this.panel.Controls.Add(this.lblPrenomEmploye);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.lblSalaireEmploye);
            this.panel.Controls.Add(this.lblNomEmploye);
            this.panel.Controls.Add(this.lblIdentifiantEmploye);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.lblDerniereModification);
            this.panel.Controls.Add(this.lblSexe);
            this.panel.Controls.Add(this.lblDateInsertion);
            this.panel.Controls.Add(this.lblNumTel);
            this.panel.Controls.Add(this.lblDepartement);
            this.panel.Controls.Add(this.lblSalaire);
            this.panel.Controls.Add(this.lblPrenom);
            this.panel.Controls.Add(this.lblNom);
            this.panel.Controls.Add(this.lblIdentifiant);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 66);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(790, 462);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // lblPosteEmploye
            // 
            this.lblPosteEmploye.AutoSize = true;
            this.lblPosteEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPosteEmploye.Location = new System.Drawing.Point(446, 337);
            this.lblPosteEmploye.Name = "lblPosteEmploye";
            this.lblPosteEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblPosteEmploye.TabIndex = 9;
            this.lblPosteEmploye.Text = "label7";
            this.lblPosteEmploye.Click += new System.EventHandler(this.lblPosteEmploye_Click);
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPoste.Location = new System.Drawing.Point(338, 333);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(86, 25);
            this.lblPoste.TabIndex = 8;
            this.lblPoste.Text = "Poste :";
            this.lblPoste.Click += new System.EventHandler(this.lblPoste_Click);
            // 
            // btnAjouterPhoto
            // 
            this.btnAjouterPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAjouterPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPhoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterPhoto.Location = new System.Drawing.Point(400, 133);
            this.btnAjouterPhoto.Name = "btnAjouterPhoto";
            this.btnAjouterPhoto.Size = new System.Drawing.Size(142, 27);
            this.btnAjouterPhoto.TabIndex = 7;
            this.btnAjouterPhoto.Text = "Inserer une photo";
            this.btnAjouterPhoto.UseVisualStyleBackColor = false;
            this.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click);
            // 
            // btnImprimerFiche
            // 
            this.btnImprimerFiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnImprimerFiche.FlatAppearance.BorderSize = 0;
            this.btnImprimerFiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerFiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerFiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerFiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimerFiche.Location = new System.Drawing.Point(327, 399);
            this.btnImprimerFiche.Name = "btnImprimerFiche";
            this.btnImprimerFiche.Size = new System.Drawing.Size(135, 40);
            this.btnImprimerFiche.TabIndex = 5;
            this.btnImprimerFiche.Text = "Imprimer";
            this.btnImprimerFiche.UseVisualStyleBackColor = false;
            this.btnImprimerFiche.Click += new System.EventHandler(this.btnImprimerFiche_Click);
            // 
            // pbAfficherPhoto
            // 
            this.pbAfficherPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAfficherPhoto.Location = new System.Drawing.Point(400, 11);
            this.pbAfficherPhoto.Name = "pbAfficherPhoto";
            this.pbAfficherPhoto.Size = new System.Drawing.Size(142, 110);
            this.pbAfficherPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAfficherPhoto.TabIndex = 2;
            this.pbAfficherPhoto.TabStop = false;
            // 
            // lblDerniereModificationEmploye
            // 
            this.lblDerniereModificationEmploye.AutoSize = true;
            this.lblDerniereModificationEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDerniereModificationEmploye.Location = new System.Drawing.Point(599, 302);
            this.lblDerniereModificationEmploye.Name = "lblDerniereModificationEmploye";
            this.lblDerniereModificationEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblDerniereModificationEmploye.TabIndex = 1;
            this.lblDerniereModificationEmploye.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(601, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mois";
            // 
            // lblDureeContratEmploye
            // 
            this.lblDureeContratEmploye.AutoSize = true;
            this.lblDureeContratEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDureeContratEmploye.Location = new System.Drawing.Point(552, 229);
            this.lblDureeContratEmploye.Name = "lblDureeContratEmploye";
            this.lblDureeContratEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblDureeContratEmploye.TabIndex = 1;
            this.lblDureeContratEmploye.Text = "label7";
            // 
            // lblStatutEmploye
            // 
            this.lblStatutEmploye.AutoSize = true;
            this.lblStatutEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblStatutEmploye.Location = new System.Drawing.Point(126, 354);
            this.lblStatutEmploye.Name = "lblStatutEmploye";
            this.lblStatutEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblStatutEmploye.TabIndex = 1;
            this.lblStatutEmploye.Text = "label7";
            this.lblStatutEmploye.Click += new System.EventHandler(this.lblStatutEmploye_Click);
            // 
            // lblSexeEmploye
            // 
            this.lblSexeEmploye.AutoSize = true;
            this.lblSexeEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSexeEmploye.Location = new System.Drawing.Point(114, 316);
            this.lblSexeEmploye.Name = "lblSexeEmploye";
            this.lblSexeEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblSexeEmploye.TabIndex = 1;
            this.lblSexeEmploye.Text = "label7";
            // 
            // lblDateInsertionEmploye
            // 
            this.lblDateInsertionEmploye.AutoSize = true;
            this.lblDateInsertionEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDateInsertionEmploye.Location = new System.Drawing.Point(531, 272);
            this.lblDateInsertionEmploye.Name = "lblDateInsertionEmploye";
            this.lblDateInsertionEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblDateInsertionEmploye.TabIndex = 1;
            this.lblDateInsertionEmploye.Text = "label7";
            // 
            // lblNumTelEmploye
            // 
            this.lblNumTelEmploye.AutoSize = true;
            this.lblNumTelEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblNumTelEmploye.Location = new System.Drawing.Point(202, 269);
            this.lblNumTelEmploye.Name = "lblNumTelEmploye";
            this.lblNumTelEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblNumTelEmploye.TabIndex = 1;
            this.lblNumTelEmploye.Text = "label7";
            // 
            // lblDepartementEmploye
            // 
            this.lblDepartementEmploye.AutoSize = true;
            this.lblDepartementEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDepartementEmploye.Location = new System.Drawing.Point(514, 195);
            this.lblDepartementEmploye.Name = "lblDepartementEmploye";
            this.lblDepartementEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblDepartementEmploye.TabIndex = 1;
            this.lblDepartementEmploye.Text = "label7";
            // 
            // lblPrenomEmploye
            // 
            this.lblPrenomEmploye.AutoSize = true;
            this.lblPrenomEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPrenomEmploye.Location = new System.Drawing.Point(144, 229);
            this.lblPrenomEmploye.Name = "lblPrenomEmploye";
            this.lblPrenomEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblPrenomEmploye.TabIndex = 1;
            this.lblPrenomEmploye.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "FCFA";
            this.label3.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSalaireEmploye
            // 
            this.lblSalaireEmploye.AutoSize = true;
            this.lblSalaireEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSalaireEmploye.Location = new System.Drawing.Point(651, 69);
            this.lblSalaireEmploye.Name = "lblSalaireEmploye";
            this.lblSalaireEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblSalaireEmploye.TabIndex = 1;
            this.lblSalaireEmploye.Text = "label7";
            this.lblSalaireEmploye.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblNomEmploye
            // 
            this.lblNomEmploye.AutoSize = true;
            this.lblNomEmploye.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblNomEmploye.Location = new System.Drawing.Point(114, 190);
            this.lblNomEmploye.Name = "lblNomEmploye";
            this.lblNomEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblNomEmploye.TabIndex = 1;
            this.lblNomEmploye.Text = "label7";
            this.lblNomEmploye.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblIdentifiantEmploye
            // 
            this.lblIdentifiantEmploye.AutoSize = true;
            this.lblIdentifiantEmploye.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiantEmploye.Location = new System.Drawing.Point(176, 40);
            this.lblIdentifiantEmploye.Name = "lblIdentifiantEmploye";
            this.lblIdentifiantEmploye.Size = new System.Drawing.Size(51, 19);
            this.lblIdentifiantEmploye.TabIndex = 1;
            this.lblIdentifiantEmploye.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durée du contrat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Statut :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDerniereModification
            // 
            this.lblDerniereModification.AutoSize = true;
            this.lblDerniereModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDerniereModification.Location = new System.Drawing.Point(337, 298);
            this.lblDerniereModification.Name = "lblDerniereModification";
            this.lblDerniereModification.Size = new System.Drawing.Size(250, 25);
            this.lblDerniereModification.TabIndex = 0;
            this.lblDerniereModification.Text = "Dernière modification :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSexe.Location = new System.Drawing.Point(12, 310);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(79, 25);
            this.lblSexe.TabIndex = 0;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblDateInsertion
            // 
            this.lblDateInsertion.AutoSize = true;
            this.lblDateInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateInsertion.Location = new System.Drawing.Point(337, 266);
            this.lblDateInsertion.Name = "lblDateInsertion";
            this.lblDateInsertion.Size = new System.Drawing.Size(173, 25);
            this.lblDateInsertion.TabIndex = 0;
            this.lblDateInsertion.Text = "Date insertion :";
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNumTel.Location = new System.Drawing.Point(12, 265);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(169, 25);
            this.lblNumTel.TabIndex = 0;
            this.lblNumTel.Text = "N° Telephone :";
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDepartement.Location = new System.Drawing.Point(337, 191);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(160, 25);
            this.lblDepartement.TabIndex = 0;
            this.lblDepartement.Text = "Departement :";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSalaire.Location = new System.Drawing.Point(549, 64);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(100, 25);
            this.lblSalaire.TabIndex = 0;
            this.lblSalaire.Text = "Salaire :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.Location = new System.Drawing.Point(12, 223);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(106, 25);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(12, 186);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(73, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(47, 36);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(130, 25);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 528);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Personnelle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfficherPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblDerniereModificationEmploye;
        private System.Windows.Forms.Label lblSexeEmploye;
        private System.Windows.Forms.Label lblDateInsertionEmploye;
        private System.Windows.Forms.Label lblNumTelEmploye;
        private System.Windows.Forms.Label lblDepartementEmploye;
        private System.Windows.Forms.Label lblPrenomEmploye;
        private System.Windows.Forms.Label lblNomEmploye;
        private System.Windows.Forms.Label lblIdentifiantEmploye;
        private System.Windows.Forms.Label lblDerniereModification;
        private System.Windows.Forms.Label lblDateInsertion;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.PictureBox pbAfficherPhoto;
        private System.Windows.Forms.Button btnImprimerFiche;
        private System.Windows.Forms.Button btnAjouterPhoto;
        private System.Windows.Forms.Label lblPosteEmploye;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDureeContratEmploye;
        private System.Windows.Forms.Label lblStatutEmploye;
        private System.Windows.Forms.Label lblSalaireEmploye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}