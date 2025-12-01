namespace StaffPro_V1._0
{
    partial class Departement
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
            this.dataDepartement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnnulerDepartement = new System.Windows.Forms.Button();
            this.btnModifierDepartment = new System.Windows.Forms.Button();
            this.btnAjouterDepartement = new System.Windows.Forms.Button();
            this.NomDepartement = new System.Windows.Forms.TextBox();
            this.NumDepartement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartement)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataDepartement);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 288);
            this.panel1.TabIndex = 0;
            // 
            // dataDepartement
            // 
            this.dataDepartement.AllowUserToAddRows = false;
            this.dataDepartement.AllowUserToDeleteRows = false;
            this.dataDepartement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDepartement.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataDepartement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDepartement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataDepartement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDepartement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDepartement.ColumnHeadersHeight = 40;
            this.dataDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDepartement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDepartement.EnableHeadersVisualStyles = false;
            this.dataDepartement.Location = new System.Drawing.Point(16, 56);
            this.dataDepartement.Name = "dataDepartement";
            this.dataDepartement.ReadOnly = true;
            this.dataDepartement.RowHeadersVisible = false;
            this.dataDepartement.RowHeadersWidth = 40;
            this.dataDepartement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "0";
            this.dataDepartement.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDepartement.Size = new System.Drawing.Size(680, 219);
            this.dataDepartement.TabIndex = 4;
            this.dataDepartement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDepartement_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DES DEPARTEMENTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnAnnulerDepartement);
            this.panel2.Controls.Add(this.btnModifierDepartment);
            this.panel2.Controls.Add(this.btnAjouterDepartement);
            this.panel2.Controls.Add(this.NomDepartement);
            this.panel2.Controls.Add(this.NumDepartement);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 180);
            this.panel2.TabIndex = 1;
            // 
            // btnAnnulerDepartement
            // 
            this.btnAnnulerDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAnnulerDepartement.FlatAppearance.BorderSize = 0;
            this.btnAnnulerDepartement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerDepartement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAnnulerDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerDepartement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulerDepartement.Location = new System.Drawing.Point(525, 105);
            this.btnAnnulerDepartement.Name = "btnAnnulerDepartement";
            this.btnAnnulerDepartement.Size = new System.Drawing.Size(94, 40);
            this.btnAnnulerDepartement.TabIndex = 6;
            this.btnAnnulerDepartement.Text = "Annuler";
            this.btnAnnulerDepartement.UseVisualStyleBackColor = false;
            this.btnAnnulerDepartement.Click += new System.EventHandler(this.btnAnnulerDepartement_Click);
            // 
            // btnModifierDepartment
            // 
            this.btnModifierDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnModifierDepartment.FlatAppearance.BorderSize = 0;
            this.btnModifierDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnModifierDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifierDepartment.Location = new System.Drawing.Point(305, 105);
            this.btnModifierDepartment.Name = "btnModifierDepartment";
            this.btnModifierDepartment.Size = new System.Drawing.Size(94, 40);
            this.btnModifierDepartment.TabIndex = 8;
            this.btnModifierDepartment.Text = "Modifier";
            this.btnModifierDepartment.UseVisualStyleBackColor = false;
            this.btnModifierDepartment.Click += new System.EventHandler(this.btnModifierDepartment_Click);
            // 
            // btnAjouterDepartement
            // 
            this.btnAjouterDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAjouterDepartement.FlatAppearance.BorderSize = 0;
            this.btnAjouterDepartement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterDepartement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAjouterDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDepartement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterDepartement.Location = new System.Drawing.Point(85, 105);
            this.btnAjouterDepartement.Name = "btnAjouterDepartement";
            this.btnAjouterDepartement.Size = new System.Drawing.Size(94, 40);
            this.btnAjouterDepartement.TabIndex = 9;
            this.btnAjouterDepartement.Text = "Ajouter";
            this.btnAjouterDepartement.UseVisualStyleBackColor = false;
            this.btnAjouterDepartement.Click += new System.EventHandler(this.btnAjouterDepartement_Click);
            // 
            // NomDepartement
            // 
            this.NomDepartement.Location = new System.Drawing.Point(379, 44);
            this.NomDepartement.Multiline = true;
            this.NomDepartement.Name = "NomDepartement";
            this.NomDepartement.Size = new System.Drawing.Size(189, 25);
            this.NomDepartement.TabIndex = 5;
            // 
            // NumDepartement
            // 
            this.NumDepartement.Location = new System.Drawing.Point(126, 44);
            this.NumDepartement.Multiline = true;
            this.NumDepartement.Name = "NumDepartement";
            this.NumDepartement.Size = new System.Drawing.Size(189, 25);
            this.NumDepartement.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom du departement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Departement :";
            // 
            // Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Departement";
            this.Size = new System.Drawing.Size(746, 514);
            this.Load += new System.EventHandler(this.Departement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepartement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomDepartement;
        private System.Windows.Forms.TextBox NumDepartement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnulerDepartement;
        private System.Windows.Forms.Button btnModifierDepartment;
        private System.Windows.Forms.Button btnAjouterDepartement;
        private System.Windows.Forms.DataGridView dataDepartement;
    }
}
