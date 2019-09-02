namespace New
{
    partial class A_AverageGradesInCoursses_HD
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
        {            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1desplyclasses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1LoadChert = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1_BACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1desplyclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1desplyclasses
            // 
            this.dataGridView1desplyclasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1desplyclasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1desplyclasses.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1desplyclasses.Name = "dataGridView1desplyclasses";
            this.dataGridView1desplyclasses.Size = new System.Drawing.Size(255, 363);
            this.dataGridView1desplyclasses.TabIndex = 0;
            this.dataGridView1desplyclasses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1desplyclasses_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // button1LoadChert
            // 
            this.button1LoadChert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1LoadChert.Location = new System.Drawing.Point(672, 404);
            this.button1LoadChert.Name = "button1LoadChert";
            this.button1LoadChert.Size = new System.Drawing.Size(167, 39);
            this.button1LoadChert.TabIndex = 11;
            this.button1LoadChert.Text = "Load Chart";
            this.button1LoadChert.UseVisualStyleBackColor = true;
            this.button1LoadChert.Click += new System.EventHandler(this.button1LoadChert_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(273, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Average ";
            series1.XValueMember = "column1";
            series1.YValueMembers = "IDcourse";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(882, 363);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // button1_BACK
            // 
            this.button1_BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1_BACK.Location = new System.Drawing.Point(388, 404);
            this.button1_BACK.Name = "button1_BACK";
            this.button1_BACK.Size = new System.Drawing.Size(214, 39);
            this.button1_BACK.TabIndex = 13;
            this.button1_BACK.Text = "Back to previous page";
            this.button1_BACK.UseVisualStyleBackColor = true;
            this.button1_BACK.Click += new System.EventHandler(this.button1_BACK_Click);
            // 
            // A_AverageGradesInCoursses_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New.Properties.Resources.OS_X_Wallpaper;
            this.ClientSize = new System.Drawing.Size(1167, 455);
            this.Controls.Add(this.button1_BACK);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1LoadChert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1desplyclasses);
            this.Name = "A_AverageGradesInCoursses_HD";
            this.Text = "AverageGradesInCoursses_HD";
            this.Load += new System.EventHandler(this.A_changeListVacant_OccupiedClasses_sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1desplyclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1desplyclasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1LoadChert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1_BACK;
    }
}