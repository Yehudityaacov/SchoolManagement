namespace New
{
    partial class A_HD_ExamList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_HD_ExamList));
            this.ExamNum = new System.Windows.Forms.TextBox();
            this.ExamName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ExamNumber = new System.Windows.Forms.Label();
            this.ExamName1 = new System.Windows.Forms.Label();
            this.ExamDate = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2headtitle = new System.Windows.Forms.Label();
            this.label2inserttitle = new System.Windows.Forms.Label();
            this.button1Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1delet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamNum
            // 
            this.ExamNum.Location = new System.Drawing.Point(187, 155);
            this.ExamNum.Multiline = true;
            this.ExamNum.Name = "ExamNum";
            this.ExamNum.Size = new System.Drawing.Size(143, 28);
            this.ExamNum.TabIndex = 0;
            // 
            // ExamName
            // 
            this.ExamName.Location = new System.Drawing.Point(187, 214);
            this.ExamName.Multiline = true;
            this.ExamName.Name = "ExamName";
            this.ExamName.Size = new System.Drawing.Size(143, 28);
            this.ExamName.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // ExamNumber
            // 
            this.ExamNumber.AutoSize = true;
            this.ExamNumber.BackColor = System.Drawing.Color.Transparent;
            this.ExamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExamNumber.Location = new System.Drawing.Point(47, 161);
            this.ExamNumber.Name = "ExamNumber";
            this.ExamNumber.Size = new System.Drawing.Size(113, 20);
            this.ExamNumber.TabIndex = 3;
            this.ExamNumber.Text = "Exam Number:";
            // 
            // ExamName1
            // 
            this.ExamName1.AutoSize = true;
            this.ExamName1.BackColor = System.Drawing.Color.Transparent;
            this.ExamName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExamName1.Location = new System.Drawing.Point(47, 222);
            this.ExamName1.Name = "ExamName1";
            this.ExamName1.Size = new System.Drawing.Size(99, 20);
            this.ExamName1.TabIndex = 4;
            this.ExamName1.Text = "Exam Name:";
            // 
            // ExamDate
            // 
            this.ExamDate.AutoSize = true;
            this.ExamDate.BackColor = System.Drawing.Color.Transparent;
            this.ExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExamDate.Location = new System.Drawing.Point(47, 283);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(92, 20);
            this.ExamDate.TabIndex = 5;
            this.ExamDate.Text = "Exam Date:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SaveButton.ForeColor = System.Drawing.Color.Teal;
            this.SaveButton.Location = new System.Drawing.Point(25, 352);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 47);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonback.ForeColor = System.Drawing.Color.Teal;
            this.buttonback.Location = new System.Drawing.Point(304, 418);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(136, 46);
            this.buttonback.TabIndex = 8;
            this.buttonback.Text = "Back to previous page";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExit.ForeColor = System.Drawing.Color.Teal;
            this.buttonExit.Location = new System.Drawing.Point(460, 418);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(137, 46);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2headtitle
            // 
            this.label2headtitle.AutoSize = true;
            this.label2headtitle.BackColor = System.Drawing.Color.Transparent;
            this.label2headtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2headtitle.ForeColor = System.Drawing.Color.White;
            this.label2headtitle.Location = new System.Drawing.Point(45, 27);
            this.label2headtitle.Name = "label2headtitle";
            this.label2headtitle.Size = new System.Drawing.Size(428, 31);
            this.label2headtitle.TabIndex = 10;
            this.label2headtitle.Text = "Editing list of Exams and Dates:";
            this.label2headtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2inserttitle
            // 
            this.label2inserttitle.AutoSize = true;
            this.label2inserttitle.BackColor = System.Drawing.Color.Transparent;
            this.label2inserttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2inserttitle.ForeColor = System.Drawing.Color.White;
            this.label2inserttitle.Location = new System.Drawing.Point(53, 88);
            this.label2inserttitle.Name = "label2inserttitle";
            this.label2inserttitle.Size = new System.Drawing.Size(324, 24);
            this.label2inserttitle.TabIndex = 11;
            this.label2inserttitle.Text = "Insert the data into the following fields:";
            // 
            // button1Update
            // 
            this.button1Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1Update.ForeColor = System.Drawing.Color.Teal;
            this.button1Update.Location = new System.Drawing.Point(163, 416);
            this.button1Update.Name = "button1Update";
            this.button1Update.Size = new System.Drawing.Size(121, 46);
            this.button1Update.TabIndex = 12;
            this.button1Update.Text = "Update Data";
            this.button1Update.UseVisualStyleBackColor = true;
            this.button1Update.Click += new System.EventHandler(this.button1Update_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(390, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(331, 201);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // button1delet
            // 
            this.button1delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1delet.ForeColor = System.Drawing.Color.Teal;
            this.button1delet.Location = new System.Drawing.Point(25, 416);
            this.button1delet.Name = "button1delet";
            this.button1delet.Size = new System.Drawing.Size(121, 47);
            this.button1delet.TabIndex = 14;
            this.button1delet.Text = "Delete Data";
            this.button1delet.UseVisualStyleBackColor = true;
            this.button1delet.Click += new System.EventHandler(this.button1delet_Click);
            // 
            // A_HD_ExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 476);
            this.Controls.Add(this.button1delet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1Update);
            this.Controls.Add(this.label2inserttitle);
            this.Controls.Add(this.label2headtitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExamDate);
            this.Controls.Add(this.ExamName1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ExamName);
            this.Controls.Add(this.ExamNum);
            this.Controls.Add(this.ExamNumber);
            this.Name = "A_HD_ExamList";
            this.Text = "A_HD_ExamList";
            this.Load += new System.EventHandler(this.A_HD_ExamList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExamNum;
        private System.Windows.Forms.TextBox ExamName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ExamNumber;
        private System.Windows.Forms.Label ExamName1;
        private System.Windows.Forms.Label ExamDate;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2headtitle;
        private System.Windows.Forms.Label label2inserttitle;
        private System.Windows.Forms.Button button1Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1delet;
    }
}