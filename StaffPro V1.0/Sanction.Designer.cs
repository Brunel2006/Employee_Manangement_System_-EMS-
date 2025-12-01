namespace StaffPro_V1._0
{
    partial class Sanction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateSanction = new System.Windows.Forms.DateTimePicker();
            this.btnModifierSanction = new System.Windows.Forms.Button();
            this.btnAnnulerSanction = new System.Windows.Forms.Button();
            this.btnImprimerSanction = new System.Windows.Forms.Button();
            this.btnAjouterSanction = new System.Windows.Forms.Button();
            this.NomEmployeSanction = new System.Windows.Forms.ComboBox();
            this.StatutSanction = new System.Windows.Forms.ComboBox();
            this.TypeSanction = new System.Windows.Forms.ComboBox();
            this.MotifSanction = new System.Windows.Forms.TextBox();
            this.DureeSanction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.dgvListeSanction = new System.Windows.Forms.DataGridView();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSanction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DES SANCTIONS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.DateSanction);
            this.panel2.Controls.Add(this.btnModifierSanction);
            this.panel2.Controls.Add(this.btnAnnulerSanction);
            this.panel2.Controls.Add(this.btnImprimerSanction);
            this.panel2.Controls.Add(this.btnAjouterSanction);
            this.panel2.Controls.Add(this.NomEmployeSanction);
            this.panel2.Controls.Add(this.StatutSanction);
            this.panel2.Controls.Add(this.TypeSanction);
            this.panel2.Controls.Add(this.MotifSanction);
            this.panel2.Controls.Add(this.DureeSanction);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 208);
            this.panel2.TabIndex = 3;
            // 
            // DateSanction
            // 
            this.DateSanction.CustomFormat = "dd/MM/yyyy";
            this.DateSanction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSanction.Location = new System.Drawing.Point(243, 41);
            this.DateSanction.Name = "DateSanction";
            this.DateSanction.Size = new System.Drawing.Size(200, 20);
            this.DateSanction.TabIndex = 25;
            // 
            // btnModifierSanction
            // 
            this.btnModifierSanction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnModifierSanction.FlatAppearance.BorderSize = 0;
            this.btnModifierSanction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierSanction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSanction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifierSanction.Location = new System.Drawing.Point(601, 123);
            this.btnModifierSanction.Name = "btnModifierSanction";
            this.btnModifierSanction.Size = new System.Drawing.Size(104, 40);
            this.btnModifierSanction.TabIndex = 21;
            this.btnModifierSanction.Text = "Modifier";
            this.btnModifierSanction.UseVisualStyleBackColor = false;
            this.btnModifierSanction.Click += new System.EventHandler(this.btnModifierSanction_Click);
            // 
            // btnAnnulerSanction
            // 
            this.btnAnnulerSanction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAnnulerSanction.FlatAppearance.BorderSize = 0;
            this.btnAnnulerSanction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerSanction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerSanction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerSanction.Location = new System.Drawing.Point(482, 123);
            this.btnAnnulerSanction.Name = "btnAnnulerSanction";
            this.btnAnnulerSanction.Size = new System.Drawing.Size(94, 40);
            this.btnAnnulerSanction.TabIndex = 22;
            this.btnAnnulerSanction.Text = "Annuler";
            this.btnAnnulerSanction.UseVisualStyleBackColor = false;
            this.btnAnnulerSanction.Click += new System.EventHandler(this.btnAnnulerSanction_Click);
            // 
            // btnImprimerSanction
            // 
            this.btnImprimerSanction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnImprimerSanction.FlatAppearance.BorderSize = 0;
            this.btnImprimerSanction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerSanction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSanction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimerSanction.Location = new System.Drawing.Point(601, 61);
            this.btnImprimerSanction.Name = "btnImprimerSanction";
            this.btnImprimerSanction.Size = new System.Drawing.Size(104, 40);
            this.btnImprimerSanction.TabIndex = 23;
            this.btnImprimerSanction.Text = "Imprimer";
            this.btnImprimerSanction.UseVisualStyleBackColor = false;
            this.btnImprimerSanction.Click += new System.EventHandler(this.btnImprimerSanction_Click);
            // 
            // btnAjouterSanction
            // 
            this.btnAjouterSanction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAjouterSanction.FlatAppearance.BorderSize = 0;
            this.btnAjouterSanction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterSanction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterSanction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSanction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterSanction.Location = new System.Drawing.Point(482, 61);
            this.btnAjouterSanction.Name = "btnAjouterSanction";
            this.btnAjouterSanction.Size = new System.Drawing.Size(94, 40);
            this.btnAjouterSanction.TabIndex = 24;
            this.btnAjouterSanction.Text = "Ajouter";
            this.btnAjouterSanction.UseVisualStyleBackColor = false;
            this.btnAjouterSanction.Click += new System.EventHandler(this.btnAjouterSanction_Click);
            // 
            // NomEmployeSanction
            // 
            this.NomEmployeSanction.FormattingEnabled = true;
            this.NomEmployeSanction.Items.AddRange(new object[] {
            "Observation",
            "Demande d\'explication ",
            "Affectation disciplinaire",
            "Mise à pied",
            "Licencement"});
            this.NomEmployeSanction.Location = new System.Drawing.Point(31, 41);
            this.NomEmployeSanction.Name = "NomEmployeSanction";
            this.NomEmployeSanction.Size = new System.Drawing.Size(189, 21);
            this.NomEmployeSanction.TabIndex = 20;
            // 
            // StatutSanction
            // 
            this.StatutSanction.FormattingEnabled = true;
            this.StatutSanction.Items.AddRange(new object[] {
            "En cours",
            "Terminée",
            "Annulée"});
            this.StatutSanction.Location = new System.Drawing.Point(31, 160);
            this.StatutSanction.Name = "StatutSanction";
            this.StatutSanction.Size = new System.Drawing.Size(189, 21);
            this.StatutSanction.TabIndex = 20;
            // 
            // TypeSanction
            // 
            this.TypeSanction.FormattingEnabled = true;
            this.TypeSanction.Items.AddRange(new object[] {
            "Avertissement",
            "Suspension"});
            this.TypeSanction.Location = new System.Drawing.Point(31, 98);
            this.TypeSanction.Name = "TypeSanction";
            this.TypeSanction.Size = new System.Drawing.Size(189, 21);
            this.TypeSanction.TabIndex = 20;
            // 
            // MotifSanction
            // 
            this.MotifSanction.Location = new System.Drawing.Point(243, 156);
            this.MotifSanction.Multiline = true;
            this.MotifSanction.Name = "MotifSanction";
            this.MotifSanction.Size = new System.Drawing.Size(218, 38);
            this.MotifSanction.TabIndex = 17;
            // 
            // DureeSanction
            // 
            this.DureeSanction.Location = new System.Drawing.Point(243, 94);
            this.DureeSanction.Multiline = true;
            this.DureeSanction.Name = "DureeSanction";
            this.DureeSanction.Size = new System.Drawing.Size(218, 25);
            this.DureeSanction.TabIndex = 17;
            this.DureeSanction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DureeSanction_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motif de la sanction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Durée de la sanction :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Statut de la sanction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date de la sanction :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type de sanction :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom de l\'employé :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.dgvListeSanction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 282);
            this.panel1.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.Image = global::StaffPro_V1._0.Properties.Resources.refreshing;
            this.refresh.Location = new System.Drawing.Point(673, 14);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 5;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dgvListeSanction
            // 
            this.dgvListeSanction.AllowUserToAddRows = false;
            this.dgvListeSanction.AllowUserToDeleteRows = false;
            this.dgvListeSanction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListeSanction.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListeSanction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeSanction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListeSanction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeSanction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListeSanction.ColumnHeadersHeight = 40;
            this.dgvListeSanction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListeSanction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListeSanction.EnableHeadersVisualStyles = false;
            this.dgvListeSanction.Location = new System.Drawing.Point(16, 58);
            this.dgvListeSanction.Name = "dgvListeSanction";
            this.dgvListeSanction.ReadOnly = true;
            this.dgvListeSanction.RowHeadersVisible = false;
            this.dgvListeSanction.RowHeadersWidth = 40;
            this.dgvListeSanction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = "0";
            this.dgvListeSanction.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListeSanction.Size = new System.Drawing.Size(689, 201);
            this.dgvListeSanction.TabIndex = 4;
            this.dgvListeSanction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeSanction_CellContentClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // Sanction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sanction";
            this.Size = new System.Drawing.Size(746, 514);
            this.Load += new System.EventHandler(this.Sanction_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeSanction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModifierSanction;
        private System.Windows.Forms.Button btnAnnulerSanction;
        private System.Windows.Forms.Button btnImprimerSanction;
        private System.Windows.Forms.Button btnAjouterSanction;
        private System.Windows.Forms.ComboBox TypeSanction;
        private System.Windows.Forms.TextBox DureeSanction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListeSanction;
        private System.Windows.Forms.DateTimePicker DateSanction;
        private System.Windows.Forms.ComboBox NomEmployeSanction;
        private System.Windows.Forms.ComboBox StatutSanction;
        private System.Windows.Forms.TextBox MotifSanction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Timer timer1;
    }
}
