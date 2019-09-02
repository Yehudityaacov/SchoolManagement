namespace New
{
    partial class A_addDepartment_secretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_addDepartment_secretary));
            this.label_addDept_Title = new System.Windows.Forms.Label();
            this.label_for_instructions = new System.Windows.Forms.Label();
            this.label_IDdept = new System.Windows.Forms.Label();
            this.label_deptName = new System.Windows.Forms.Label();
            this.textBox_IDdept = new System.Windows.Forms.TextBox();
            this.textBox_deptName = new System.Windows.Forms.TextBox();
            this.button_SUBMIT = new System.Windows.Forms.Button();
            this.buttonBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_addDept_Title
            // 
            this.label_addDept_Title.AutoSize = true;
            this.label_addDept_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_addDept_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addDept_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_addDept_Title.Location = new System.Drawing.Point(66, 32);
            this.label_addDept_Title.Name = "label_addDept_Title";
            this.label_addDept_Title.Size = new System.Drawing.Size(532, 33);
            this.label_addDept_Title.TabIndex = 0;
            this.label_addDept_Title.Text = "Add new department to the system ...";
            // 
            // label_for_instructions
            // 
            this.label_for_instructions.AutoSize = true;
            this.label_for_instructions.BackColor = System.Drawing.Color.Transparent;
            this.label_for_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_for_instructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_for_instructions.Location = new System.Drawing.Point(67, 88);
            this.label_for_instructions.Name = "label_for_instructions";
            this.label_for_instructions.Size = new System.Drawing.Size(412, 29);
            this.label_for_instructions.TabIndex = 1;
            this.label_for_instructions.Text = "Please submit the following fields:";
            // 
            // label_IDdept
            // 
            this.label_IDdept.AutoSize = true;
            this.label_IDdept.BackColor = System.Drawing.Color.Transparent;
            this.label_IDdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_IDdept.Location = new System.Drawing.Point(69, 169);
            this.label_IDdept.Name = "label_IDdept";
            this.label_IDdept.Size = new System.Drawing.Size(140, 20);
            this.label_IDdept.TabIndex = 2;
            this.label_IDdept.Text = "Department ID *";
            // 
            // label_deptName
            // 
            this.label_deptName.AutoSize = true;
            this.label_deptName.BackColor = System.Drawing.Color.Transparent;
            this.label_deptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_deptName.Location = new System.Drawing.Point(361, 169);
            this.label_deptName.Name = "label_deptName";
            this.label_deptName.Size = new System.Drawing.Size(165, 20);
            this.label_deptName.TabIndex = 3;
            this.label_deptName.Text = "Department name *";
            // 
            // textBox_IDdept
            // 
            this.textBox_IDdept.Location = new System.Drawing.Point(72, 204);
            this.textBox_IDdept.Multiline = true;
            this.textBox_IDdept.Name = "textBox_IDdept";
            this.textBox_IDdept.Size = new System.Drawing.Size(221, 29);
            this.textBox_IDdept.TabIndex = 4;
            // 
            // textBox_deptName
            // 
            this.textBox_deptName.Location = new System.Drawing.Point(342, 204);
            this.textBox_deptName.Multiline = true;
            this.textBox_deptName.Name = "textBox_deptName";
            this.textBox_deptName.Size = new System.Drawing.Size(217, 29);
            this.textBox_deptName.TabIndex = 5;
            // 
            // button_SUBMIT
            // 
            this.button_SUBMIT.BackColor = System.Drawing.Color.DarkCyan;
            this.button_SUBMIT.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_SUBMIT.Location = new System.Drawing.Point(227, 272);
            this.button_SUBMIT.Name = "button_SUBMIT";
            this.button_SUBMIT.Size = new System.Drawing.Size(177, 42);
            this.button_SUBMIT.TabIndex = 6;
            this.button_SUBMIT.Text = "SUBMIT";
            this.button_SUBMIT.UseVisualStyleBackColor = false;
            this.button_SUBMIT.Click += new System.EventHandler(this.button_SUBMIT_Click);
            // 
            // buttonBACK
            // 
            this.buttonBACK.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBACK.Location = new System.Drawing.Point(508, 320);
            this.buttonBACK.Name = "buttonBACK";
            this.buttonBACK.Size = new System.Drawing.Size(147, 62);
            this.buttonBACK.TabIndex = 7;
            this.buttonBACK.Text = "Back to previous page";
            this.buttonBACK.UseVisualStyleBackColor = false;
            this.buttonBACK.Click += new System.EventHandler(this.buttonBACK_Click);
            // 
            // A_addDepartment_secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 395);
            this.Controls.Add(this.buttonBACK);
            this.Controls.Add(this.button_SUBMIT);
            this.Controls.Add(this.textBox_deptName);
            this.Controls.Add(this.textBox_IDdept);
            this.Controls.Add(this.label_deptName);
            this.Controls.Add(this.label_IDdept);
            this.Controls.Add(this.label_for_instructions);
            this.Controls.Add(this.label_addDept_Title);
            this.Name = "A_addDepartment_secretary";
            this.Text = "A_addDepartment_secretary";
            this.Load += new System.EventHandler(this.A_addDepartment_secretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addDept_Title;
        private System.Windows.Forms.Label label_for_instructions;
        private System.Windows.Forms.Label label_IDdept;
        private System.Windows.Forms.Label label_deptName;
        private System.Windows.Forms.TextBox textBox_IDdept;
        private System.Windows.Forms.TextBox textBox_deptName;
        private System.Windows.Forms.Button button_SUBMIT;
        private System.Windows.Forms.Button buttonBACK;
    }
}