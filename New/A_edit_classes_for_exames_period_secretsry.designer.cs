namespace New
{
    partial class A_edit_classes_for_exames_period_secretsry
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
            this.label_TITLE = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TITLE
            // 
            this.label_TITLE.AutoSize = true;
            this.label_TITLE.BackColor = System.Drawing.Color.Transparent;
            this.label_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TITLE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TITLE.Location = new System.Drawing.Point(51, 27);
            this.label_TITLE.Name = "label_TITLE";
            this.label_TITLE.Size = new System.Drawing.Size(554, 31);
            this.label_TITLE.TabIndex = 11;
            this.label_TITLE.Text = "Edit list of vacant classes for exams priod";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.description.Location = new System.Drawing.Point(56, 68);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(479, 80);
            this.description.TabIndex = 12;
            this.description.Text = "for each class enter V in the \"examsPeriod\" column\r\n if this class is available i" +
    "n exames priod , else left it empty.\r\nto edit the row press \"update row\" button." +
    "\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 245);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(472, 395);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(133, 35);
            this.button_back.TabIndex = 29;
            this.button_back.Text = "back to previous page";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(457, 136);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(133, 35);
            this.ok_button.TabIndex = 30;
            this.ok_button.Text = "update row";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // A_edit_classes_for_exames_period_secretsry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New.Properties.Resources.OS_X_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 442);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label_TITLE);
            this.Name = "A_edit_classes_for_exames_period_secretsry";
            this.Text = "A_edit_classes_for_exames_period_secretsry";
            this.Load += new System.EventHandler(this.A_edit_classes_for_exames_period_secretsry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TITLE;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button ok_button;
    }
}