namespace StaffPro_V1._0
{
    partial class Recrutement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.dataRecrutement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatutEmployeRecrutement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContratEmployeRecrutement = new System.Windows.Forms.TextBox();
            this.DepartementEmployeRecrutement = new System.Windows.Forms.ComboBox();
            this.btnFiche = new System.Windows.Forms.Button();
            this.btnModifierRecrutement = new System.Windows.Forms.Button();
            this.btnAnnulerRecrutement = new System.Windows.Forms.Button();
            this.btnAjouterRecrutement = new System.Windows.Forms.Button();
            this.SexeEmployeRecrutement = new System.Windows.Forms.ComboBox();
            this.TelEmployeRecrutement = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PosteEmployeRecrutement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrenomEmployeRecrutement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomEmployeRecrutement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecrutement)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.dataRecrutement);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPdf);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 277);
            this.panel1.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Image = global::StaffPro_V1._0.Properties.Resources.refreshing;
            this.refresh.Location = new System.Drawing.Point(655, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 4;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataRecrutement
            // 
            this.dataRecrutement.AllowUserToAddRows = false;
            this.dataRecrutement.AllowUserToDeleteRows = false;
            this.dataRecrutement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataRecrutement.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataRecrutement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRecrutement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataRecrutement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRecrutement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRecrutement.ColumnHeadersHeight = 40;
            this.dataRecrutement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRecrutement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRecrutement.EnableHeadersVisualStyles = false;
            this.dataRecrutement.Location = new System.Drawing.Point(17, 64);
            this.dataRecrutement.Name = "dataRecrutement";
            this.dataRecrutement.ReadOnly = true;
            this.dataRecrutement.RowHeadersVisible = false;
            this.dataRecrutement.RowHeadersWidth = 40;
            this.dataRecrutement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "0";
            this.dataRecrutement.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataRecrutement.Size = new System.Drawing.Size(680, 195);
            this.dataRecrutement.TabIndex = 3;
            this.dataRecrutement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRecrutement_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES RECRUTEMENTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.StatutEmployeRecrutement);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ContratEmployeRecrutement);
            this.panel2.Controls.Add(this.DepartementEmployeRecrutement);
            this.panel2.Controls.Add(this.btnFiche);
            this.panel2.Controls.Add(this.btnModifierRecrutement);
            this.panel2.Controls.Add(this.btnAnnulerRecrutement);
            this.panel2.Controls.Add(this.btnAjouterRecrutement);
            this.panel2.Controls.Add(this.SexeEmployeRecrutement);
            this.panel2.Controls.Add(this.TelEmployeRecrutement);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PosteEmployeRecrutement);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PrenomEmployeRecrutement);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NomEmployeRecrutement);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(14, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 200);
            this.panel2.TabIndex = 0;
            // 
            // StatutEmployeRecrutement
            // 
            this.StatutEmployeRecrutement.Enabled = false;
            this.StatutEmployeRecrutement.FormattingEnabled = true;
            this.StatutEmployeRecrutement.Items.AddRange(new object[] {
            "EN SERVICE",
            "HORS SERVICE"});
            this.StatutEmployeRecrutement.Location = new System.Drawing.Point(217, 142);
            this.StatutEmployeRecrutement.Name = "StatutEmployeRecrutement";
            this.StatutEmployeRecrutement.Size = new System.Drawing.Size(139, 21);
            this.StatutEmployeRecrutement.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(213, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Statut :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(105, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "mois";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Durée du contrat :";
            // 
            // ContratEmployeRecrutement
            // 
            this.ContratEmployeRecrutement.Location = new System.Drawing.Point(26, 143);
            this.ContratEmployeRecrutement.Name = "ContratEmployeRecrutement";
            this.ContratEmployeRecrutement.Size = new System.Drawing.Size(73, 20);
            this.ContratEmployeRecrutement.TabIndex = 7;
            this.ContratEmployeRecrutement.TextChanged += new System.EventHandler(this.ContratEmployeRecrutement_TextChanged);
            this.ContratEmployeRecrutement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContratEmployeRecrutement_KeyPress);
            this.ContratEmployeRecrutement.Validating += new System.ComponentModel.CancelEventHandler(this.ContratEmployeRecrutement_Validating);
            // 
            // DepartementEmployeRecrutement
            // 
            this.DepartementEmployeRecrutement.FormattingEnabled = true;
            this.DepartementEmployeRecrutement.Location = new System.Drawing.Point(402, 88);
            this.DepartementEmployeRecrutement.Name = "DepartementEmployeRecrutement";
            this.DepartementEmployeRecrutement.Size = new System.Drawing.Size(139, 21);
            this.DepartementEmployeRecrutement.TabIndex = 6;
            // 
            // btnFiche
            // 
            this.btnFiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(90)))));
            this.btnFiche.FlatAppearance.BorderSize = 0;
            this.btnFiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnFiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnFiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiche.Location = new System.Drawing.Point(466, 133);
            this.btnFiche.Name = "btnFiche";
            this.btnFiche.Size = new System.Drawing.Size(101, 40);
            this.btnFiche.TabIndex = 4;
            this.btnFiche.Text = "Données personnelles";
            this.btnFiche.UseVisualStyleBackColor = false;
            this.btnFiche.Visible = false;
            this.btnFiche.Click += new System.EventHandler(this.btnFiche_Click_1);
            // 
            // btnModifierRecrutement
            // 
            this.btnModifierRecrutement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnModifierRecrutement.FlatAppearance.BorderSize = 0;
            this.btnModifierRecrutement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierRecrutement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierRecrutement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierRecrutement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierRecrutement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifierRecrutement.Location = new System.Drawing.Point(603, 133);
            this.btnModifierRecrutement.Name = "btnModifierRecrutement";
            this.btnModifierRecrutement.Size = new System.Drawing.Size(94, 40);
            this.btnModifierRecrutement.TabIndex = 4;
            this.btnModifierRecrutement.Text = "Modifier";
            this.btnModifierRecrutement.UseVisualStyleBackColor = false;
            this.btnModifierRecrutement.Click += new System.EventHandler(this.btnModifierRecrutement_Click);
            // 
            // btnAnnulerRecrutement
            // 
            this.btnAnnulerRecrutement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAnnulerRecrutement.FlatAppearance.BorderSize = 0;
            this.btnAnnulerRecrutement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerRecrutement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerRecrutement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerRecrutement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerRecrutement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerRecrutement.Location = new System.Drawing.Point(603, 74);
            this.btnAnnulerRecrutement.Name = "btnAnnulerRecrutement";
            this.btnAnnulerRecrutement.Size = new System.Drawing.Size(94, 40);
            this.btnAnnulerRecrutement.TabIndex = 4;
            this.btnAnnulerRecrutement.Text = "Annuler";
            this.btnAnnulerRecrutement.UseVisualStyleBackColor = false;
            this.btnAnnulerRecrutement.Click += new System.EventHandler(this.btnAnnulerRecrutement_Click);
            // 
            // btnAjouterRecrutement
            // 
            this.btnAjouterRecrutement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAjouterRecrutement.FlatAppearance.BorderSize = 0;
            this.btnAjouterRecrutement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterRecrutement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterRecrutement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterRecrutement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterRecrutement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterRecrutement.Location = new System.Drawing.Point(603, 11);
            this.btnAjouterRecrutement.Name = "btnAjouterRecrutement";
            this.btnAjouterRecrutement.Size = new System.Drawing.Size(94, 40);
            this.btnAjouterRecrutement.TabIndex = 4;
            this.btnAjouterRecrutement.Text = "Ajouter";
            this.btnAjouterRecrutement.UseVisualStyleBackColor = false;
            this.btnAjouterRecrutement.Click += new System.EventHandler(this.btnAjouterRecrutement_Click_1);
            // 
            // SexeEmployeRecrutement
            // 
            this.SexeEmployeRecrutement.FormattingEnabled = true;
            this.SexeEmployeRecrutement.Items.AddRange(new object[] {
            "MASCULIN",
            "FEMININ"});
            this.SexeEmployeRecrutement.Location = new System.Drawing.Point(27, 88);
            this.SexeEmployeRecrutement.Name = "SexeEmployeRecrutement";
            this.SexeEmployeRecrutement.Size = new System.Drawing.Size(148, 21);
            this.SexeEmployeRecrutement.TabIndex = 2;
            // 
            // TelEmployeRecrutement
            // 
            this.TelEmployeRecrutement.Location = new System.Drawing.Point(399, 30);
            this.TelEmployeRecrutement.Name = "TelEmployeRecrutement";
            this.TelEmployeRecrutement.Size = new System.Drawing.Size(142, 20);
            this.TelEmployeRecrutement.TabIndex = 1;
            this.TelEmployeRecrutement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelEmployeRecrutement_KeyPress);
            this.TelEmployeRecrutement.Validating += new System.ComponentModel.CancelEventHandler(this.TelEmployeRecrutement_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "N° Telephone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Departement :";
            // 
            // PosteEmployeRecrutement
            // 
            this.PosteEmployeRecrutement.Location = new System.Drawing.Point(217, 87);
            this.PosteEmployeRecrutement.Name = "PosteEmployeRecrutement";
            this.PosteEmployeRecrutement.Size = new System.Drawing.Size(139, 20);
            this.PosteEmployeRecrutement.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Poste :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sexe :";
            // 
            // PrenomEmployeRecrutement
            // 
            this.PrenomEmployeRecrutement.Location = new System.Drawing.Point(217, 31);
            this.PrenomEmployeRecrutement.Name = "PrenomEmployeRecrutement";
            this.PrenomEmployeRecrutement.Size = new System.Drawing.Size(139, 20);
            this.PrenomEmployeRecrutement.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prenom Employé :";
            // 
            // NomEmployeRecrutement
            // 
            this.NomEmployeRecrutement.Location = new System.Drawing.Point(27, 31);
            this.NomEmployeRecrutement.Name = "NomEmployeRecrutement";
            this.NomEmployeRecrutement.Size = new System.Drawing.Size(148, 20);
            this.NomEmployeRecrutement.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom Employé :";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(447, 15);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(120, 40);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "Exporter PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Recrutement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Recrutement";
            this.Size = new System.Drawing.Size(750, 520);
            this.Load += new System.EventHandler(this.Recrutement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecrutement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox SexeEmployeRecrutement;
        private System.Windows.Forms.TextBox TelEmployeRecrutement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PosteEmployeRecrutement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrenomEmployeRecrutement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifierRecrutement;
        private System.Windows.Forms.Button btnAnnulerRecrutement;
        private System.Windows.Forms.ComboBox DepartementEmployeRecrutement;
        private System.Windows.Forms.DataGridView dataRecrutement;
        private System.Windows.Forms.Button btnAjouterRecrutement;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContratEmployeRecrutement;
        private System.Windows.Forms.TextBox NomEmployeRecrutement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiche;
        private System.Windows.Forms.ComboBox StatutEmployeRecrutement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPdf;
    }
}
