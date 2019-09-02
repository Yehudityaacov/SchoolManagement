namespace New
{
    partial class A_insertForSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_insertForSecretary));
            this.label_InsertionTitle = new System.Windows.Forms.Label();
            this.button_insert_termsForCourse = new System.Windows.Forms.Button();
            this.button_gradesInsert = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_InsertionTitle
            // 
            this.label_InsertionTitle.AutoSize = true;
            this.label_InsertionTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_InsertionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InsertionTitle.ForeColor = System.Drawing.Color.Salmon;
            this.label_InsertionTitle.Location = new System.Drawing.Point(122, 29);
            this.label_InsertionTitle.Name = "label_InsertionTitle";
            this.label_InsertionTitle.Size = new System.Drawing.Size(393, 55);
            this.label_InsertionTitle.TabIndex = 0;
            this.label_InsertionTitle.Text = "Insertion options";
            // 
            // button_insert_termsForCourse
            // 
            this.button_insert_termsForCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_insert_termsForCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert_termsForCourse.Location = new System.Drawing.Point(27, 136);
            this.button_insert_termsForCourse.Name = "button_insert_termsForCourse";
            this.button_insert_termsForCourse.Size = new System.Drawing.Size(272, 62);
            this.button_insert_termsForCourse.TabIndex = 1;
            this.button_insert_termsForCourse.Text = "Insert conditional terms for course";
            this.button_insert_termsForCourse.UseVisualStyleBackColor = false;
            this.button_insert_termsForCourse.Click += new System.EventHandler(this.button_insert_termsForCourse_Click);
            // 
            // button_gradesInsert
            // 
            this.button_gradesInsert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_gradesInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gradesInsert.Location = new System.Drawing.Point(35, 267);
            this.button_gradesInsert.Name = "button_gradesInsert";
            this.button_gradesInsert.Size = new System.Drawing.Size(264, 71);
            this.button_gradesInsert.TabIndex = 2;
            this.button_gradesInsert.Text = "Insert grades to database";
            this.button_gradesInsert.UseVisualStyleBackColor = false;
            this.button_gradesInsert.Click += new System.EventHandler(this.button_gradesInsert_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(391, 186);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(217, 53);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back to previous page";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXIT.Location = new System.Drawing.Point(537, 295);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(173, 74);
            this.buttonEXIT.TabIndex = 5;
            this.buttonEXIT.Text = "LOGOUT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // A_insertForSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 394);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_gradesInsert);
            this.Controls.Add(this.button_insert_termsForCourse);
            this.Controls.Add(this.label_InsertionTitle);
            this.Name = "A_insertForSecretary";
            this.Text = "A_insertForSecretary";
            this.Load += new System.EventHandler(this.A_insertForSecretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InsertionTitle;
        private System.Windows.Forms.Button button_insert_termsForCourse;
        private System.Windows.Forms.Button button_gradesInsert;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button buttonEXIT;
    }
}