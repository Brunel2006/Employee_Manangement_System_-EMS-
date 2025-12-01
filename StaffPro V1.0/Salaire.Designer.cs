namespace StaffPro_V1._0
{
    partial class Salaire
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
            this.dataSalaire = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifierSalaire = new System.Windows.Forms.Button();
            this.btnAnnulerSalaire = new System.Windows.Forms.Button();
            this.btnImprimerSalaire = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaireEmployeSalaire = new System.Windows.Forms.TextBox();
            this.PosteEmployeSalaire = new System.Windows.Forms.TextBox();
            this.NomEmployeSalaire = new System.Windows.Forms.TextBox();
            this.IdEmployeSalaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalaire)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.dataSalaire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(288, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 486);
            this.panel1.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Image = global::StaffPro_V1._0.Properties.Resources.refreshing;
            this.refresh.Location = new System.Drawing.Point(404, 34);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(32, 32);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 5;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataSalaire
            // 
            this.dataSalaire.AllowUserToAddRows = false;
            this.dataSalaire.AllowUserToDeleteRows = false;
            this.dataSalaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataSalaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSalaire.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataSalaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSalaire.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataSalaire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSalaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSalaire.ColumnHeadersHeight = 40;
            this.dataSalaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSalaire.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataSalaire.EnableHeadersVisualStyles = false;
            this.dataSalaire.Location = new System.Drawing.Point(16, 72);
            this.dataSalaire.Name = "dataSalaire";
            this.dataSalaire.ReadOnly = true;
            this.dataSalaire.RowHeadersVisible = false;
            this.dataSalaire.RowHeadersWidth = 40;
            this.dataSalaire.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "0";
            this.dataSalaire.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSalaire.Size = new System.Drawing.Size(420, 400);
            this.dataSalaire.TabIndex = 2;
            this.dataSalaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalaire_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES SALAIRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnModifierSalaire);
            this.panel2.Controls.Add(this.btnAnnulerSalaire);
            this.panel2.Controls.Add(this.btnImprimerSalaire);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SalaireEmployeSalaire);
            this.panel2.Controls.Add(this.PosteEmployeSalaire);
            this.panel2.Controls.Add(this.NomEmployeSalaire);
            this.panel2.Controls.Add(this.IdEmployeSalaire);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 486);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnModifierSalaire
            // 
            this.btnModifierSalaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnModifierSalaire.FlatAppearance.BorderSize = 0;
            this.btnModifierSalaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierSalaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierSalaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierSalaire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifierSalaire.Location = new System.Drawing.Point(34, 304);
            this.btnModifierSalaire.Name = "btnModifierSalaire";
            this.btnModifierSalaire.Size = new System.Drawing.Size(94, 40);
            this.btnModifierSalaire.TabIndex = 5;
            this.btnModifierSalaire.Text = "Modifier";
            this.btnModifierSalaire.UseVisualStyleBackColor = false;
            this.btnModifierSalaire.Click += new System.EventHandler(this.btnModifierSalaire_Click);
            // 
            // btnAnnulerSalaire
            // 
            this.btnAnnulerSalaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAnnulerSalaire.FlatAppearance.BorderSize = 0;
            this.btnAnnulerSalaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerSalaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerSalaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerSalaire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerSalaire.Location = new System.Drawing.Point(147, 304);
            this.btnAnnulerSalaire.Name = "btnAnnulerSalaire";
            this.btnAnnulerSalaire.Size = new System.Drawing.Size(94, 40);
            this.btnAnnulerSalaire.TabIndex = 6;
            this.btnAnnulerSalaire.Text = "Annuler";
            this.btnAnnulerSalaire.UseVisualStyleBackColor = false;
            this.btnAnnulerSalaire.Click += new System.EventHandler(this.btnAnnulerSalaire_Click);
            // 
            // btnImprimerSalaire
            // 
            this.btnImprimerSalaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnImprimerSalaire.FlatAppearance.BorderSize = 0;
            this.btnImprimerSalaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerSalaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnImprimerSalaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSalaire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimerSalaire.Location = new System.Drawing.Point(69, 364);
            this.btnImprimerSalaire.Name = "btnImprimerSalaire";
            this.btnImprimerSalaire.Size = new System.Drawing.Size(138, 40);
            this.btnImprimerSalaire.TabIndex = 7;
            this.btnImprimerSalaire.Text = "Imprimer";
            this.btnImprimerSalaire.UseVisualStyleBackColor = false;
            this.btnImprimerSalaire.Click += new System.EventHandler(this.btnImprimerSalaire_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salaire de l\'employé :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Poste de l\'employé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de l\'employé :";
            // 
            // SalaireEmployeSalaire
            // 
            this.SalaireEmployeSalaire.Location = new System.Drawing.Point(21, 247);
            this.SalaireEmployeSalaire.Multiline = true;
            this.SalaireEmployeSalaire.Name = "SalaireEmployeSalaire";
            this.SalaireEmployeSalaire.Size = new System.Drawing.Size(225, 25);
            this.SalaireEmployeSalaire.TabIndex = 3;
            this.SalaireEmployeSalaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaireEmployeSalaire_KeyPress);
            // 
            // PosteEmployeSalaire
            // 
            this.PosteEmployeSalaire.Location = new System.Drawing.Point(21, 187);
            this.PosteEmployeSalaire.Multiline = true;
            this.PosteEmployeSalaire.Name = "PosteEmployeSalaire";
            this.PosteEmployeSalaire.Size = new System.Drawing.Size(225, 25);
            this.PosteEmployeSalaire.TabIndex = 3;
            // 
            // NomEmployeSalaire
            // 
            this.NomEmployeSalaire.Location = new System.Drawing.Point(21, 129);
            this.NomEmployeSalaire.Multiline = true;
            this.NomEmployeSalaire.Name = "NomEmployeSalaire";
            this.NomEmployeSalaire.Size = new System.Drawing.Size(225, 25);
            this.NomEmployeSalaire.TabIndex = 3;
            // 
            // IdEmployeSalaire
            // 
            this.IdEmployeSalaire.Location = new System.Drawing.Point(21, 72);
            this.IdEmployeSalaire.Multiline = true;
            this.IdEmployeSalaire.Name = "IdEmployeSalaire";
            this.IdEmployeSalaire.Size = new System.Drawing.Size(225, 25);
            this.IdEmployeSalaire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Employé :";
            // 
            // Salaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salaire";
            this.Size = new System.Drawing.Size(746, 514);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalaire)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalaireEmployeSalaire;
        private System.Windows.Forms.TextBox PosteEmployeSalaire;
        private System.Windows.Forms.TextBox NomEmployeSalaire;
        private System.Windows.Forms.TextBox IdEmployeSalaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifierSalaire;
        private System.Windows.Forms.Button btnAnnulerSalaire;
        private System.Windows.Forms.DataGridView dataSalaire;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Button btnImprimerSalaire;
    }
}
