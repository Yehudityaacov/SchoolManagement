namespace New
{
    partial class A_addCourse_secretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_addCourse_secretary));
            this.label_addCourse_title = new System.Windows.Forms.Label();
            this.label_insttructions = new System.Windows.Forms.Label();
            this.course_name_labal = new System.Windows.Forms.Label();
            this.courseName_txt = new System.Windows.Forms.TextBox();
            this.label_courseID = new System.Windows.Forms.Label();
            this.label_deptID = new System.Windows.Forms.Label();
            this.courseID_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_submit = new System.Windows.Forms.Label();
            this.buttonBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_addCourse_title
            // 
            this.label_addCourse_title.AutoSize = true;
            this.label_addCourse_title.BackColor = System.Drawing.Color.Transparent;
            this.label_addCourse_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addCourse_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_addCourse_title.Location = new System.Drawing.Point(55, 21);
            this.label_addCourse_title.Name = "label_addCourse_title";
            this.label_addCourse_title.Size = new System.Drawing.Size(513, 37);
            this.label_addCourse_title.TabIndex = 0;
            this.label_addCourse_title.Text = "Add new course to the system ...";
            // 
            // label_insttructions
            // 
            this.label_insttructions.AutoSize = true;
            this.label_insttructions.BackColor = System.Drawing.Color.Transparent;
            this.label_insttructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_insttructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_insttructions.Location = new System.Drawing.Point(28, 81);
            this.label_insttructions.Name = "label_insttructions";
            this.label_insttructions.Size = new System.Drawing.Size(325, 24);
            this.label_insttructions.TabIndex = 1;
            this.label_insttructions.Text = "Please submit the following fields:";
            // 
            // course_name_labal
            // 
            this.course_name_labal.AutoSize = true;
            this.course_name_labal.BackColor = System.Drawing.Color.Transparent;
            this.course_name_labal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.course_name_labal.Location = new System.Drawing.Point(72, 131);
            this.course_name_labal.Name = "course_name_labal";
            this.course_name_labal.Size = new System.Drawing.Size(129, 20);
            this.course_name_labal.TabIndex = 2;
            this.course_name_labal.Text = "Course Name *";
            // 
            // courseName_txt
            // 
            this.courseName_txt.Location = new System.Drawing.Point(76, 165);
            this.courseName_txt.Multiline = true;
            this.courseName_txt.Name = "courseName_txt";
            this.courseName_txt.Size = new System.Drawing.Size(211, 28);
            this.courseName_txt.TabIndex = 3;
            // 
            // label_courseID
            // 
            this.label_courseID.AutoSize = true;
            this.label_courseID.BackColor = System.Drawing.Color.Transparent;
            this.label_courseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_courseID.Location = new System.Drawing.Point(384, 131);
            this.label_courseID.Name = "label_courseID";
            this.label_courseID.Size = new System.Drawing.Size(102, 20);
            this.label_courseID.TabIndex = 4;
            this.label_courseID.Text = "Course ID *";
            // 
            // label_deptID
            // 
            this.label_deptID.AutoSize = true;
            this.label_deptID.BackColor = System.Drawing.Color.Transparent;
            this.label_deptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_deptID.Location = new System.Drawing.Point(72, 222);
            this.label_deptID.Name = "label_deptID";
            this.label_deptID.Size = new System.Drawing.Size(360, 20);
            this.label_deptID.TabIndex = 5;
            this.label_deptID.Text = "Department ID which the course belong to *";
            // 
            // courseID_txt
            // 
            this.courseID_txt.Location = new System.Drawing.Point(354, 165);
            this.courseID_txt.Multiline = true;
            this.courseID_txt.Name = "courseID_txt";
            this.courseID_txt.Size = new System.Drawing.Size(240, 28);
            this.courseID_txt.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 266);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 32);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_submit
            // 
            this.label_submit.AutoSize = true;
            this.label_submit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label_submit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_submit.Location = new System.Drawing.Point(462, 266);
            this.label_submit.Name = "label_submit";
            this.label_submit.Size = new System.Drawing.Size(132, 35);
            this.label_submit.TabIndex = 8;
            this.label_submit.Text = "SUBMIT";
            this.label_submit.Click += new System.EventHandler(this.label_submit_Click);
            // 
            // buttonBACK
            // 
            this.buttonBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBACK.Location = new System.Drawing.Point(436, 334);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(235, 34);
            this.buttonBACK.TabIndex = 9;
            this.buttonBACK.Text = "Back to previous page";
            this.buttonBACK.UseVisualStyleBackColor = true;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // A_addCourse_secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 396);
            this.Controls.Add(this.buttonBACK);
            this.Controls.Add(this.label_submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.courseID_txt);
            this.Controls.Add(this.label_deptID);
            this.Controls.Add(this.label_courseID);
            this.Controls.Add(this.courseName_txt);
            this.Controls.Add(this.course_name_labal);
            this.Controls.Add(this.label_insttructions);
            this.Controls.Add(this.label_addCourse_title);
            this.Name = "A_addCourse_secretary";
            this.Text = "A_addCourse_secretary";
            this.Load += new System.EventHandler(this.A_addCourse_secretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addCourse_title;
        private System.Windows.Forms.Label label_insttructions;
        private System.Windows.Forms.Label course_name_labal;
        private System.Windows.Forms.TextBox courseName_txt;
        private System.Windows.Forms.Label label_courseID;
        private System.Windows.Forms.Label label_deptID;
        private System.Windows.Forms.TextBox courseID_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_submit;
        private System.Windows.Forms.Button buttonBACK;
    }
}