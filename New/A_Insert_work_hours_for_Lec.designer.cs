namespace New
{
    partial class A_Insert_work_hours_for_Lec
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_month = new System.Windows.Forms.NumericUpDown();
            this.label_month = new System.Windows.Forms.Label();
            this.numericUpDown_year = new System.Windows.Forms.NumericUpDown();
            this.label_year = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_hoursAmount = new System.Windows.Forms.TextBox();
            this.button_SUBMIT = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert work hours";
            // 
            // numericUpDown_month
            // 
            this.numericUpDown_month.Location = new System.Drawing.Point(195, 168);
            this.numericUpDown_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_month.Name = "numericUpDown_month";
            this.numericUpDown_month.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown_month.TabIndex = 17;
            this.numericUpDown_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_month
            // 
            this.label_month.AutoSize = true;
            this.label_month.BackColor = System.Drawing.Color.Transparent;
            this.label_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_month.Location = new System.Drawing.Point(42, 168);
            this.label_month.Name = "label_month";
            this.label_month.Size = new System.Drawing.Size(76, 20);
            this.label_month.TabIndex = 16;
            this.label_month.Text = "month  *";
            // 
            // numericUpDown_year
            // 
            this.numericUpDown_year.Location = new System.Drawing.Point(196, 207);
            this.numericUpDown_year.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_year.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDown_year.Name = "numericUpDown_year";
            this.numericUpDown_year.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown_year.TabIndex = 19;
            this.numericUpDown_year.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.BackColor = System.Drawing.Color.Transparent;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_year.Location = new System.Drawing.Point(42, 207);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(55, 20);
            this.label_year.TabIndex = 18;
            this.label_year.Text = "year *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(42, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "hours amount ";
            // 
            // textBox_hoursAmount
            // 
            this.textBox_hoursAmount.Location = new System.Drawing.Point(195, 243);
            this.textBox_hoursAmount.Name = "textBox_hoursAmount";
            this.textBox_hoursAmount.Size = new System.Drawing.Size(100, 20);
            this.textBox_hoursAmount.TabIndex = 21;
            // 
            // button_SUBMIT
            // 
            this.button_SUBMIT.Location = new System.Drawing.Point(45, 306);
            this.button_SUBMIT.Name = "button_SUBMIT";
            this.button_SUBMIT.Size = new System.Drawing.Size(111, 35);
            this.button_SUBMIT.TabIndex = 22;
            this.button_SUBMIT.Text = "SUBMIT";
            this.button_SUBMIT.UseVisualStyleBackColor = true;
            this.button_SUBMIT.Click += new System.EventHandler(this.button_SUBMIT_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(195, 306);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(133, 35);
            this.button_back.TabIndex = 23;
            this.button_back.Text = "back to previous page";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name.Location = new System.Drawing.Point(41, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 20);
            this.name.TabIndex = 24;
            this.name.Text = "Hello name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "please enter your work hours for one month";
            // 
            // A_Insert_work_hours_for_Lec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New.Properties.Resources.OS_X_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_SUBMIT);
            this.Controls.Add(this.textBox_hoursAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_year);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.numericUpDown_month);
            this.Controls.Add(this.label_month);
            this.Controls.Add(this.label1);
            this.Name = "A_Insert_work_hours_for_Lec";
            this.Text = "A_Insert_work_hours_for_Lec";
            this.Load += new System.EventHandler(this.A_Insert_work_hours_for_Lec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_month;
        private System.Windows.Forms.Label label_month;
        private System.Windows.Forms.NumericUpDown numericUpDown_year;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_hoursAmount;
        private System.Windows.Forms.Button button_SUBMIT;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
    }
}