namespace New
{
    partial class A_queryCourseSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_queryCourseSecretary));
            this.label1_queryCourse_title = new System.Windows.Forms.Label();
            this.label1_insttructions_title = new System.Windows.Forms.Label();
            this.label1_IDcourse_title = new System.Windows.Forms.Label();
            this.button1_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Backtpp = new System.Windows.Forms.Button();
            this.seeAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_queryCourse_title
            // 
            this.label1_queryCourse_title.AutoSize = true;
            this.label1_queryCourse_title.BackColor = System.Drawing.Color.Transparent;
            this.label1_queryCourse_title.Font = new System.Drawing.Font("AR JULIAN", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_queryCourse_title.ForeColor = System.Drawing.Color.Transparent;
            this.label1_queryCourse_title.Location = new System.Drawing.Point(12, 9);
            this.label1_queryCourse_title.Name = "label1_queryCourse_title";
            this.label1_queryCourse_title.Size = new System.Drawing.Size(470, 74);
            this.label1_queryCourse_title.TabIndex = 0;
            this.label1_queryCourse_title.Text = "Course Query ";
            // 
            // label1_insttructions_title
            // 
            this.label1_insttructions_title.AutoSize = true;
            this.label1_insttructions_title.BackColor = System.Drawing.Color.Transparent;
            this.label1_insttructions_title.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_insttructions_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_insttructions_title.Location = new System.Drawing.Point(43, 98);
            this.label1_insttructions_title.Name = "label1_insttructions_title";
            this.label1_insttructions_title.Size = new System.Drawing.Size(417, 25);
            this.label1_insttructions_title.TabIndex = 1;
            this.label1_insttructions_title.Text = "Please choose the following information:";
            // 
            // label1_IDcourse_title
            // 
            this.label1_IDcourse_title.AutoSize = true;
            this.label1_IDcourse_title.BackColor = System.Drawing.Color.Transparent;
            this.label1_IDcourse_title.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_IDcourse_title.Location = new System.Drawing.Point(71, 148);
            this.label1_IDcourse_title.Name = "label1_IDcourse_title";
            this.label1_IDcourse_title.Size = new System.Drawing.Size(126, 23);
            this.label1_IDcourse_title.TabIndex = 2;
            this.label1_IDcourse_title.Text = "Course ID : *";
            // 
            // button1_search
            // 
            this.button1_search.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1_search.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_search.Location = new System.Drawing.Point(225, 186);
            this.button1_search.Name = "button1_search";
            this.button1_search.Size = new System.Drawing.Size(72, 28);
            this.button1_search.TabIndex = 5;
            this.button1_search.Text = "search";
            this.button1_search.UseVisualStyleBackColor = false;
            this.button1_search.Click += new System.EventHandler(this.button1_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 108);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Backtpp
            // 
            this.Backtpp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Backtpp.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backtpp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Backtpp.Location = new System.Drawing.Point(145, 369);
            this.Backtpp.Name = "Backtpp";
            this.Backtpp.Size = new System.Drawing.Size(177, 28);
            this.Backtpp.TabIndex = 7;
            this.Backtpp.Text = "back to previous page";
            this.Backtpp.UseVisualStyleBackColor = false;
            this.Backtpp.Click += new System.EventHandler(this.Backtpp_Click);
            // 
            // seeAll
            // 
            this.seeAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.seeAll.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAll.Location = new System.Drawing.Point(384, 187);
            this.seeAll.Name = "seeAll";
            this.seeAll.Size = new System.Drawing.Size(75, 27);
            this.seeAll.TabIndex = 8;
            this.seeAll.Text = "see all";
            this.seeAll.UseVisualStyleBackColor = false;
            this.seeAll.Click += new System.EventHandler(this.seeAll_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // A_queryCourseSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.seeAll);
            this.Controls.Add(this.Backtpp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_search);
            this.Controls.Add(this.label1_IDcourse_title);
            this.Controls.Add(this.label1_insttructions_title);
            this.Controls.Add(this.label1_queryCourse_title);
            this.Name = "A_queryCourseSecretary";
            this.Text = "A_queryCourseSecretary";
            this.Load += new System.EventHandler(this.A_queryCourseSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_queryCourse_title;
        private System.Windows.Forms.Label label1_insttructions_title;
        private System.Windows.Forms.Label label1_IDcourse_title;
        private System.Windows.Forms.Button button1_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backtpp;
        private System.Windows.Forms.Button seeAll;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}