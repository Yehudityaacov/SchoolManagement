namespace New
{
    partial class A_DHadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_DHadd));
            this.add_lecturer_button = new System.Windows.Forms.Button();
            this.add_assistant_button = new System.Windows.Forms.Button();
            this.add_flowchart_button = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_lecturer_button
            // 
            this.add_lecturer_button.BackColor = System.Drawing.Color.DimGray;
            this.add_lecturer_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_lecturer_button.BackgroundImage")));
            this.add_lecturer_button.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lecturer_button.Image = ((System.Drawing.Image)(resources.GetObject("add_lecturer_button.Image")));
            this.add_lecturer_button.Location = new System.Drawing.Point(107, 58);
            this.add_lecturer_button.Name = "add_lecturer_button";
            this.add_lecturer_button.Size = new System.Drawing.Size(489, 34);
            this.add_lecturer_button.TabIndex = 9;
            this.add_lecturer_button.Text = "Add new lecturer to the system";
            this.add_lecturer_button.UseVisualStyleBackColor = false;
            this.add_lecturer_button.Click += new System.EventHandler(this.add_lecturer_button_Click);
            // 
            // add_assistant_button
            // 
            this.add_assistant_button.BackColor = System.Drawing.Color.DimGray;
            this.add_assistant_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_assistant_button.BackgroundImage")));
            this.add_assistant_button.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_assistant_button.Image = ((System.Drawing.Image)(resources.GetObject("add_assistant_button.Image")));
            this.add_assistant_button.Location = new System.Drawing.Point(107, 135);
            this.add_assistant_button.Name = "add_assistant_button";
            this.add_assistant_button.Size = new System.Drawing.Size(489, 34);
            this.add_assistant_button.TabIndex = 10;
            this.add_assistant_button.Text = "Add new teaching assistant to the system";
            this.add_assistant_button.UseVisualStyleBackColor = false;
            this.add_assistant_button.Click += new System.EventHandler(this.add_assistant_button_Click);
            // 
            // add_flowchart_button
            // 
            this.add_flowchart_button.BackColor = System.Drawing.Color.DimGray;
            this.add_flowchart_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_flowchart_button.BackgroundImage")));
            this.add_flowchart_button.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_flowchart_button.Image = ((System.Drawing.Image)(resources.GetObject("add_flowchart_button.Image")));
            this.add_flowchart_button.Location = new System.Drawing.Point(107, 197);
            this.add_flowchart_button.Name = "add_flowchart_button";
            this.add_flowchart_button.Size = new System.Drawing.Size(489, 34);
            this.add_flowchart_button.TabIndex = 11;
            this.add_flowchart_button.Text = "Add flowchart for study program ";
            this.add_flowchart_button.UseVisualStyleBackColor = false;
            this.add_flowchart_button.Click += new System.EventHandler(this.add_flowchart_button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(107, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(489, 33);
            this.button8.TabIndex = 16;
            this.button8.Text = "Back to previous page";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(229, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "add options:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // A_DHadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.add_flowchart_button);
            this.Controls.Add(this.add_assistant_button);
            this.Controls.Add(this.add_lecturer_button);
            this.Name = "A_DHadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Head Add";
            this.Load += new System.EventHandler(this.A_DHadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_lecturer_button;
        private System.Windows.Forms.Button add_assistant_button;
        private System.Windows.Forms.Button add_flowchart_button;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}