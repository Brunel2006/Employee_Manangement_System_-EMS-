namespace StaffPro_V1._0
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNbreEmployeInactif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNbreEmployeActif = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNbreEmploye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvListEmploye = new System.Windows.Forms.DataGridView();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 174);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.lblNbreEmployeInactif);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(481, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 146);
            this.panel5.TabIndex = 0;
            // 
            // lblNbreEmployeInactif
            // 
            this.lblNbreEmployeInactif.AutoSize = true;
            this.lblNbreEmployeInactif.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreEmployeInactif.Location = new System.Drawing.Point(178, 66);
            this.lblNbreEmployeInactif.Name = "lblNbreEmployeInactif";
            this.lblNbreEmployeInactif.Size = new System.Drawing.Size(30, 35);
            this.lblNbreEmployeInactif.TabIndex = 1;
            this.lblNbreEmployeInactif.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employé(s) Inactif(s)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.lblNbreEmployeActif);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(246, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 146);
            this.panel4.TabIndex = 0;
            // 
            // lblNbreEmployeActif
            // 
            this.lblNbreEmployeActif.AutoSize = true;
            this.lblNbreEmployeActif.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreEmployeActif.Location = new System.Drawing.Point(182, 66);
            this.lblNbreEmployeActif.Name = "lblNbreEmployeActif";
            this.lblNbreEmployeActif.Size = new System.Drawing.Size(30, 35);
            this.lblNbreEmployeActif.TabIndex = 1;
            this.lblNbreEmployeActif.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(70, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employé(s) Actif(s)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblNbreEmploye);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(11, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 146);
            this.panel3.TabIndex = 0;
            // 
            // lblNbreEmploye
            // 
            this.lblNbreEmploye.AutoSize = true;
            this.lblNbreEmploye.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreEmploye.Location = new System.Drawing.Point(175, 66);
            this.lblNbreEmploye.Name = "lblNbreEmploye";
            this.lblNbreEmploye.Size = new System.Drawing.Size(30, 35);
            this.lblNbreEmploye.TabIndex = 1;
            this.lblNbreEmploye.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label1.Location = new System.Drawing.Point(69, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Employé(s)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChart);
            this.panel2.Controls.Add(this.btnPdf);
            this.panel2.Controls.Add(this.btnRecherche);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.stats);
            this.panel2.Location = new System.Drawing.Point(14, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 292);
            this.panel2.TabIndex = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPdf.Location = new System.Drawing.Point(258, 43);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(159, 32);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "Exporter PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Visible = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRecherche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(481, 46);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(159, 32);
            this.btnRecherche.TabIndex = 4;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dgvListEmploye);
            this.panel6.Location = new System.Drawing.Point(334, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 194);
            this.panel6.TabIndex = 3;
            // 
            // dgvListEmploye
            // 
            this.dgvListEmploye.AllowUserToAddRows = false;
            this.dgvListEmploye.AllowUserToDeleteRows = false;
            this.dgvListEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListEmploye.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListEmploye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListEmploye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListEmploye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListEmploye.ColumnHeadersHeight = 40;
            this.dgvListEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmploye.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListEmploye.EnableHeadersVisualStyles = false;
            this.dgvListEmploye.Location = new System.Drawing.Point(-1, -1);
            this.dgvListEmploye.Name = "dgvListEmploye";
            this.dgvListEmploye.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListEmploye.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListEmploye.RowHeadersVisible = false;
            this.dgvListEmploye.RowHeadersWidth = 40;
            this.dgvListEmploye.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = "0";
            this.dgvListEmploye.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListEmploye.Size = new System.Drawing.Size(371, 194);
            this.dgvListEmploye.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd MMM yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(560, 16);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd MMM yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(356, 17);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // stats
            // 
            this.stats.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.stats.ChartAreas.Add(chartArea3);
            legendItem3.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Marker;
            legend3.CustomItems.Add(legendItem3);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            legend3.IsDockedInsideChartArea = false;
            legend3.IsEquallySpacedItems = true;
            legend3.IsTextAutoFit = false;
            legend3.MaximumAutoSize = 60F;
            legend3.Name = "Legend1";
            this.stats.Legends.Add(legend3);
            this.stats.Location = new System.Drawing.Point(11, 16);
            this.stats.Name = "stats";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "series1";
            this.stats.Series.Add(series3);
            this.stats.Size = new System.Drawing.Size(316, 263);
            this.stats.TabIndex = 0;
            this.stats.Text = "chart1";
            // 
            // btnChart
            // 
            this.btnChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChart.Image = global::StaffPro_V1._0.Properties.Resources.Print_icon_icons_com_55835;
            this.btnChart.Location = new System.Drawing.Point(11, 234);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(51, 44);
            this.btnChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChart.TabIndex = 5;
            this.btnChart.TabStop = false;
            this.btnChart.Visible = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StaffPro_V1._0.Properties.Resources.supprimer_lutilisateur__1_;
            this.pictureBox3.Location = new System.Drawing.Point(11, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StaffPro_V1._0.Properties.Resources.ouvrier;
            this.pictureBox2.Location = new System.Drawing.Point(12, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaffPro_V1._0.Properties.Resources.icons8_employé_64;
            this.pictureBox1.Location = new System.Drawing.Point(9, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(746, 514);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNbreEmployeInactif;
        private System.Windows.Forms.Label lblNbreEmployeActif;
        private System.Windows.Forms.Label lblNbreEmploye;
        private System.Windows.Forms.DataVisualization.Charting.Chart stats;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvListEmploye;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.PictureBox btnChart;
    }
}
