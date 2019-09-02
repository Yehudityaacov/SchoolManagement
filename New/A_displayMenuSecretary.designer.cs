namespace New
{
    partial class A_displayMenuSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_displayMenuSecretary));
            this.label_displayTitle = new System.Windows.Forms.Label();
            this.button_displayClasses = new System.Windows.Forms.Button();
            this.button_filterClass_to_seats = new System.Windows.Forms.Button();
            this.button_filter_students = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_displayTitle
            // 
            this.label_displayTitle.AutoSize = true;
            this.label_displayTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_displayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayTitle.ForeColor = System.Drawing.Color.Salmon;
            this.label_displayTitle.Location = new System.Drawing.Point(87, 32);
            this.label_displayTitle.Name = "label_displayTitle";
            this.label_displayTitle.Size = new System.Drawing.Size(516, 42);
            this.label_displayTitle.TabIndex = 0;
            this.label_displayTitle.Text = "Display and Filtering options";
            // 
            // button_displayClasses
            // 
            this.button_displayClasses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_displayClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_displayClasses.Location = new System.Drawing.Point(45, 144);
            this.button_displayClasses.Name = "button_displayClasses";
            this.button_displayClasses.Size = new System.Drawing.Size(276, 48);
            this.button_displayClasses.TabIndex = 1;
            this.button_displayClasses.Text = "Display list of vacant and occupied classes";
            this.button_displayClasses.UseVisualStyleBackColor = false;
            this.button_displayClasses.Click += new System.EventHandler(this.button_displayClasses_Click);
            // 
            // button_filterClass_to_seats
            // 
            this.button_filterClass_to_seats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_filterClass_to_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filterClass_to_seats.Location = new System.Drawing.Point(50, 214);
            this.button_filterClass_to_seats.Name = "button_filterClass_to_seats";
            this.button_filterClass_to_seats.Size = new System.Drawing.Size(270, 63);
            this.button_filterClass_to_seats.TabIndex = 2;
            this.button_filterClass_to_seats.Text = "Filtering classes according to seats in class";
            this.button_filterClass_to_seats.UseVisualStyleBackColor = false;
            this.button_filterClass_to_seats.Click += new System.EventHandler(this.button_filterClass_to_seats_Click);
            // 
            // button_filter_students
            // 
            this.button_filter_students.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_filter_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filter_students.Location = new System.Drawing.Point(50, 304);
            this.button_filter_students.Name = "button_filter_students";
            this.button_filter_students.Size = new System.Drawing.Size(267, 70);
            this.button_filter_students.TabIndex = 3;
            this.button_filter_students.Text = "Filtering students according to conditional terms of course";
            this.button_filter_students.UseVisualStyleBackColor = false;
            this.button_filter_students.Click += new System.EventHandler(this.button_filter_students_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(425, 166);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(183, 59);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back to previous page";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXIT.Location = new System.Drawing.Point(531, 358);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(168, 53);
            this.buttonEXIT.TabIndex = 5;
            this.buttonEXIT.Text = "LOGOUT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // A_displayMenuSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button_filter_students);
            this.Controls.Add(this.button_filterClass_to_seats);
            this.Controls.Add(this.button_displayClasses);
            this.Controls.Add(this.label_displayTitle);
            this.Name = "A_displayMenuSecretary";
            this.Text = "A_displayMenuSecretary";
            this.Load += new System.EventHandler(this.A_displayMenuSecretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_displayTitle;
        private System.Windows.Forms.Button button_displayClasses;
        private System.Windows.Forms.Button button_filterClass_to_seats;
        private System.Windows.Forms.Button button_filter_students;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEXIT;
    }
}