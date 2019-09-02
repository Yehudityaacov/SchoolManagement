namespace New
{
    partial class Add_User_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User_B));
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Last_Name_Box = new System.Windows.Forms.TextBox();
            this.First_Name_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Type_list = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Year_list = new System.Windows.Forms.ListBox();
            this.DepartmentList = new System.Windows.Forms.ListBox();
            this.SemesterBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(133, 16);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(156, 20);
            this.ID_Box.TabIndex = 0;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // Last_Name_Box
            // 
            this.Last_Name_Box.Location = new System.Drawing.Point(133, 55);
            this.Last_Name_Box.Name = "Last_Name_Box";
            this.Last_Name_Box.Size = new System.Drawing.Size(156, 20);
            this.Last_Name_Box.TabIndex = 1;
            this.Last_Name_Box.TextChanged += new System.EventHandler(this.Last_Name_Box_TextChanged);
            // 
            // First_Name_Box
            // 
            this.First_Name_Box.Location = new System.Drawing.Point(133, 96);
            this.First_Name_Box.Name = "First_Name_Box";
            this.First_Name_Box.Size = new System.Drawing.Size(156, 20);
            this.First_Name_Box.TabIndex = 2;
            this.First_Name_Box.TextChanged += new System.EventHandler(this.First_Name_Box_TextChanged);
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(133, 138);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(156, 20);
            this.Password_Box.TabIndex = 3;
            this.Password_Box.TextChanged += new System.EventHandler(this.Password_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // Type_list
            // 
            this.Type_list.FormattingEnabled = true;
            this.Type_list.Items.AddRange(new object[] {
            "Student",
            "Secretary",
            "Tech"});
            this.Type_list.Location = new System.Drawing.Point(311, 16);
            this.Type_list.Name = "Type_list";
            this.Type_list.Size = new System.Drawing.Size(96, 43);
            this.Type_list.TabIndex = 15;
            this.Type_list.SelectedIndexChanged += new System.EventHandler(this.Type_list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(105, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_User_click_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Yellow1_Click);
            // 
            // Year_list
            // 
            this.Year_list.FormattingEnabled = true;
            this.Year_list.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3",
            "Year 4"});
            this.Year_list.Location = new System.Drawing.Point(311, 166);
            this.Year_list.Name = "Year_list";
            this.Year_list.Size = new System.Drawing.Size(64, 56);
            this.Year_list.TabIndex = 19;
            this.Year_list.Visible = false;
            this.Year_list.SelectedIndexChanged += new System.EventHandler(this.Year_list_SelectedIndexChanged);
            // 
            // DepartmentList
            // 
            this.DepartmentList.FormattingEnabled = true;
            this.DepartmentList.Items.AddRange(new object[] {
            "Software Engineering",
            "Electrical Engineering",
            "Structural Engineering",
            "Mechanical Engineering",
            "Mathematics",
            "Chemistry",
            "Physics"});
            this.DepartmentList.Location = new System.Drawing.Point(311, 65);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(142, 95);
            this.DepartmentList.TabIndex = 20;
            this.DepartmentList.Visible = false;
            this.DepartmentList.SelectedIndexChanged += new System.EventHandler(this.DepartmentList_SelectedIndexChanged);
            // 
            // SemesterBox
            // 
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Items.AddRange(new object[] {
            "Semester a",
            "Semester b",
            "Summer"});
            this.SemesterBox.Location = new System.Drawing.Point(381, 166);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(72, 43);
            this.SemesterBox.TabIndex = 21;
            this.SemesterBox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 284);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Add_User_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 254);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.DepartmentList);
            this.Controls.Add(this.Year_list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Type_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.First_Name_Box);
            this.Controls.Add(this.Last_Name_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(1000, 400);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_User_B";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add_User_B";
            this.Load += new System.EventHandler(this.Add_User_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Last_Name_Box;
        private System.Windows.Forms.TextBox First_Name_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Type_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Year_list;
        private System.Windows.Forms.ListBox DepartmentList;
        private System.Windows.Forms.ListBox SemesterBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}