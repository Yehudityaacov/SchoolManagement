namespace New
{
    partial class A_add_DH_forSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_add_DH_forSecretary));
            this.label_TITLE = new System.Windows.Forms.Label();
            this.label_instructions = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label_forUserID = new System.Windows.Forms.Label();
            this.textBox_DeptID = new System.Windows.Forms.TextBox();
            this.label_deptID = new System.Windows.Forms.Label();
            this.button_SUBMIT = new System.Windows.Forms.Button();
            this.button_BACK = new System.Windows.Forms.Button();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_PASSWORD = new System.Windows.Forms.Label();
            this.textBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_TITLE
            // 
            this.label_TITLE.AutoSize = true;
            this.label_TITLE.BackColor = System.Drawing.Color.Transparent;
            this.label_TITLE.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TITLE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TITLE.Location = new System.Drawing.Point(21, 25);
            this.label_TITLE.Name = "label_TITLE";
            this.label_TITLE.Size = new System.Drawing.Size(571, 32);
            this.label_TITLE.TabIndex = 0;
            this.label_TITLE.Text = "Add new Head Department to the system";
            // 
            // label_instructions
            // 
            this.label_instructions.AutoSize = true;
            this.label_instructions.BackColor = System.Drawing.Color.Transparent;
            this.label_instructions.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instructions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_instructions.Location = new System.Drawing.Point(47, 70);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Size = new System.Drawing.Size(389, 25);
            this.label_instructions.TabIndex = 1;
            this.label_instructions.Text = "Please submit the following fields:";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(52, 152);
            this.textBox_UserID.Multiline = true;
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(201, 30);
            this.textBox_UserID.TabIndex = 2;
            // 
            // label_forUserID
            // 
            this.label_forUserID.AutoSize = true;
            this.label_forUserID.BackColor = System.Drawing.Color.Transparent;
            this.label_forUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_forUserID.Location = new System.Drawing.Point(48, 129);
            this.label_forUserID.Name = "label_forUserID";
            this.label_forUserID.Size = new System.Drawing.Size(83, 20);
            this.label_forUserID.TabIndex = 3;
            this.label_forUserID.Text = "User ID *";
            // 
            // textBox_DeptID
            // 
            this.textBox_DeptID.Location = new System.Drawing.Point(333, 152);
            this.textBox_DeptID.Multiline = true;
            this.textBox_DeptID.Name = "textBox_DeptID";
            this.textBox_DeptID.Size = new System.Drawing.Size(217, 30);
            this.textBox_DeptID.TabIndex = 4;
            // 
            // label_deptID
            // 
            this.label_deptID.AutoSize = true;
            this.label_deptID.BackColor = System.Drawing.Color.Transparent;
            this.label_deptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_deptID.Location = new System.Drawing.Point(338, 129);
            this.label_deptID.Name = "label_deptID";
            this.label_deptID.Size = new System.Drawing.Size(140, 20);
            this.label_deptID.TabIndex = 5;
            this.label_deptID.Text = "Department ID *";
            // 
            // button_SUBMIT
            // 
            this.button_SUBMIT.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_SUBMIT.Location = new System.Drawing.Point(333, 328);
            this.button_SUBMIT.Name = "button_SUBMIT";
            this.button_SUBMIT.Size = new System.Drawing.Size(191, 42);
            this.button_SUBMIT.TabIndex = 6;
            this.button_SUBMIT.Text = "SUBMIT";
            this.button_SUBMIT.UseVisualStyleBackColor = false;
            this.button_SUBMIT.Click += new System.EventHandler(this.button_SUBMIT_Click);
            // 
            // button_BACK
            // 
            this.button_BACK.BackColor = System.Drawing.Color.FloralWhite;
            this.button_BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_BACK.Location = new System.Drawing.Point(618, 306);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(133, 64);
            this.button_BACK.TabIndex = 7;
            this.button_BACK.Text = "Back to previous page";
            this.button_BACK.UseVisualStyleBackColor = false;
            this.button_BACK.Click += new System.EventHandler(this.button_BACK_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_FirstName.Location = new System.Drawing.Point(52, 201);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(108, 20);
            this.label_FirstName.TabIndex = 8;
            this.label_FirstName.Text = "First Name *";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(52, 224);
            this.textBox_FirstName.Multiline = true;
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(207, 26);
            this.textBox_FirstName.TabIndex = 9;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_LastName.Location = new System.Drawing.Point(329, 201);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(107, 20);
            this.label_LastName.TabIndex = 10;
            this.label_LastName.Text = "Last Name *";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(333, 225);
            this.textBox_LastName.Multiline = true;
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(217, 25);
            this.textBox_LastName.TabIndex = 11;
            // 
            // label_PASSWORD
            // 
            this.label_PASSWORD.AutoSize = true;
            this.label_PASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.label_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PASSWORD.Location = new System.Drawing.Point(56, 280);
            this.label_PASSWORD.Name = "label_PASSWORD";
            this.label_PASSWORD.Size = new System.Drawing.Size(98, 20);
            this.label_PASSWORD.TabIndex = 12;
            this.label_PASSWORD.Text = "Password *";
            // 
            // textBox_PASSWORD
            // 
            this.textBox_PASSWORD.Location = new System.Drawing.Point(161, 279);
            this.textBox_PASSWORD.Multiline = true;
            this.textBox_PASSWORD.Name = "textBox_PASSWORD";
            this.textBox_PASSWORD.Size = new System.Drawing.Size(186, 21);
            this.textBox_PASSWORD.TabIndex = 13;
            // 
            // A_add_DH_forSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 382);
            this.Controls.Add(this.textBox_PASSWORD);
            this.Controls.Add(this.label_PASSWORD);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.button_BACK);
            this.Controls.Add(this.button_SUBMIT);
            this.Controls.Add(this.label_deptID);
            this.Controls.Add(this.textBox_DeptID);
            this.Controls.Add(this.label_forUserID);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_instructions);
            this.Controls.Add(this.label_TITLE);
            this.Name = "A_add_DH_forSecretary";
            this.Text = "A_add_DH_forSecretary";
            this.Load += new System.EventHandler(this.A_add_DH_forSecretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TITLE;
        private System.Windows.Forms.Label label_instructions;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label label_forUserID;
        private System.Windows.Forms.TextBox textBox_DeptID;
        private System.Windows.Forms.Label label_deptID;
        private System.Windows.Forms.Button button_SUBMIT;
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_PASSWORD;
        private System.Windows.Forms.TextBox textBox_PASSWORD;
    }
}