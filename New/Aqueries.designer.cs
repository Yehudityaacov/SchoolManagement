namespace New
{
    partial class Aqueries
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
            this.queries_labal = new System.Windows.Forms.Label();
            this.button_student_query = new System.Windows.Forms.Button();
            this.button_lecturer_query = new System.Windows.Forms.Button();
            this.butoon_TA_query = new System.Windows.Forms.Button();
            this.button_course_query = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queries_labal
            // 
            this.queries_labal.AutoSize = true;
            this.queries_labal.BackColor = System.Drawing.Color.Transparent;
            this.queries_labal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queries_labal.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.queries_labal.Location = new System.Drawing.Point(210, 25);
            this.queries_labal.Name = "queries_labal";
            this.queries_labal.Size = new System.Drawing.Size(146, 39);
            this.queries_labal.TabIndex = 0;
            this.queries_labal.Text = "Queries";
            // 
            // button_student_query
            // 
            this.button_student_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_student_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_student_query.Location = new System.Drawing.Point(42, 90);
            this.button_student_query.Name = "button_student_query";
            this.button_student_query.Size = new System.Drawing.Size(162, 34);
            this.button_student_query.TabIndex = 1;
            this.button_student_query.Text = "Student Query";
            this.button_student_query.UseVisualStyleBackColor = false;
            this.button_student_query.Click += new System.EventHandler(this.button_student_query_Click);
            // 
            // button_lecturer_query
            // 
            this.button_lecturer_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_lecturer_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_lecturer_query.Location = new System.Drawing.Point(42, 148);
            this.button_lecturer_query.Name = "button_lecturer_query";
            this.button_lecturer_query.Size = new System.Drawing.Size(162, 35);
            this.button_lecturer_query.TabIndex = 2;
            this.button_lecturer_query.Text = "Lecturer Query";
            this.button_lecturer_query.UseVisualStyleBackColor = false;
            this.button_lecturer_query.Click += new System.EventHandler(this.button_lecturer_query_Click);
            // 
            // butoon_TA_query
            // 
            this.butoon_TA_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.butoon_TA_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.butoon_TA_query.Location = new System.Drawing.Point(250, 90);
            this.butoon_TA_query.Name = "butoon_TA_query";
            this.butoon_TA_query.Size = new System.Drawing.Size(236, 34);
            this.butoon_TA_query.TabIndex = 3;
            this.butoon_TA_query.Text = "Teaching Assitant Query";
            this.butoon_TA_query.UseVisualStyleBackColor = false;
            this.butoon_TA_query.Click += new System.EventHandler(this.butoon_TA_query_Click);
            // 
            // button_course_query
            // 
            this.button_course_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_course_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_course_query.Location = new System.Drawing.Point(42, 203);
            this.button_course_query.Name = "button_course_query";
            this.button_course_query.Size = new System.Drawing.Size(201, 35);
            this.button_course_query.TabIndex = 4;
            this.button_course_query.Text = "Course Query";
            this.button_course_query.UseVisualStyleBackColor = false;
            this.button_course_query.Click += new System.EventHandler(this.button_course_query_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Silver;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_back.Location = new System.Drawing.Point(291, 148);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(130, 57);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back to previous page";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXIT.Location = new System.Drawing.Point(442, 218);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(112, 42);
            this.buttonEXIT.TabIndex = 6;
            this.buttonEXIT.Text = "LOGOUT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // Aqueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New.Properties.Resources.OS_X_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 272);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_course_query);
            this.Controls.Add(this.butoon_TA_query);
            this.Controls.Add(this.button_lecturer_query);
            this.Controls.Add(this.button_student_query);
            this.Controls.Add(this.queries_labal);
            this.DoubleBuffered = true;
            this.Name = "Aqueries";
            this.Text = "Aqueries";
            this.Load += new System.EventHandler(this.Aqueries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queries_labal;
        private System.Windows.Forms.Button button_student_query;
        private System.Windows.Forms.Button button_lecturer_query;
        private System.Windows.Forms.Button butoon_TA_query;
        private System.Windows.Forms.Button button_course_query;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button buttonEXIT;
    }
}