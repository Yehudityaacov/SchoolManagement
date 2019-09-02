namespace New
{
    partial class A_DepartmentHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_DepartmentHead));
            this.label1 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.REMOVE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.DETERMINATION = new System.Windows.Forms.Button();
            this.SCHEDUALING = new System.Windows.Forms.Button();
            this.ALLOCATION = new System.Windows.Forms.Button();
            this.VIEWREPORTS = new System.Windows.Forms.Button();
            this.BACKtpp = new System.Windows.Forms.Button();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(546, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Gainsboro;
            this.ADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADD.BackgroundImage")));
            this.ADD.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(12, 61);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(331, 44);
            this.ADD.TabIndex = 8;
            this.ADD.Text = "Add to the system";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // REMOVE
            // 
            this.REMOVE.BackColor = System.Drawing.Color.Gainsboro;
            this.REMOVE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("REMOVE.BackgroundImage")));
            this.REMOVE.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVE.Location = new System.Drawing.Point(12, 140);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(331, 44);
            this.REMOVE.TabIndex = 9;
            this.REMOVE.Text = "Remove from the system";
            this.REMOVE.UseVisualStyleBackColor = false;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.Gainsboro;
            this.EDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EDIT.BackgroundImage")));
            this.EDIT.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.Location = new System.Drawing.Point(12, 217);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(331, 44);
            this.EDIT.TabIndex = 10;
            this.EDIT.Text = "Edit";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DETERMINATION
            // 
            this.DETERMINATION.BackColor = System.Drawing.Color.Gainsboro;
            this.DETERMINATION.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DETERMINATION.BackgroundImage")));
            this.DETERMINATION.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETERMINATION.Location = new System.Drawing.Point(12, 294);
            this.DETERMINATION.Name = "DETERMINATION";
            this.DETERMINATION.Size = new System.Drawing.Size(331, 44);
            this.DETERMINATION.TabIndex = 11;
            this.DETERMINATION.Text = "Determination of credits course";
            this.DETERMINATION.UseVisualStyleBackColor = false;
            this.DETERMINATION.Click += new System.EventHandler(this.DETERMINATION_Click);
            // 
            // SCHEDUALING
            // 
            this.SCHEDUALING.BackColor = System.Drawing.Color.Gainsboro;
            this.SCHEDUALING.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SCHEDUALING.BackgroundImage")));
            this.SCHEDUALING.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCHEDUALING.Location = new System.Drawing.Point(12, 373);
            this.SCHEDUALING.Name = "SCHEDUALING";
            this.SCHEDUALING.Size = new System.Drawing.Size(331, 44);
            this.SCHEDUALING.TabIndex = 12;
            this.SCHEDUALING.Text = "Schedualing";
            this.SCHEDUALING.UseVisualStyleBackColor = false;
            this.SCHEDUALING.Click += new System.EventHandler(this.SCHEDUALING_Click);
            // 
            // ALLOCATION
            // 
            this.ALLOCATION.BackColor = System.Drawing.Color.Gainsboro;
            this.ALLOCATION.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ALLOCATION.BackgroundImage")));
            this.ALLOCATION.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALLOCATION.Location = new System.Drawing.Point(433, 109);
            this.ALLOCATION.Name = "ALLOCATION";
            this.ALLOCATION.Size = new System.Drawing.Size(331, 59);
            this.ALLOCATION.TabIndex = 13;
            this.ALLOCATION.Text = "Allocation capacity of students for course";
            this.ALLOCATION.UseVisualStyleBackColor = false;
            this.ALLOCATION.Click += new System.EventHandler(this.ALLOCATION_Click);
            // 
            // VIEWREPORTS
            // 
            this.VIEWREPORTS.BackColor = System.Drawing.Color.Gainsboro;
            this.VIEWREPORTS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VIEWREPORTS.BackgroundImage")));
            this.VIEWREPORTS.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIEWREPORTS.Location = new System.Drawing.Point(433, 217);
            this.VIEWREPORTS.Name = "VIEWREPORTS";
            this.VIEWREPORTS.Size = new System.Drawing.Size(331, 44);
            this.VIEWREPORTS.TabIndex = 14;
            this.VIEWREPORTS.Text = "View reports";
            this.VIEWREPORTS.UseVisualStyleBackColor = false;
            this.VIEWREPORTS.Click += new System.EventHandler(this.VIEWREPORTS_Click);
            // 
            // BACKtpp
            // 
            this.BACKtpp.BackColor = System.Drawing.Color.Gainsboro;
            this.BACKtpp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BACKtpp.BackgroundImage")));
            this.BACKtpp.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKtpp.Location = new System.Drawing.Point(433, 294);
            this.BACKtpp.Name = "BACKtpp";
            this.BACKtpp.Size = new System.Drawing.Size(331, 44);
            this.BACKtpp.TabIndex = 15;
            this.BACKtpp.Text = "Back to previous page";
            this.BACKtpp.UseVisualStyleBackColor = false;
            this.BACKtpp.Click += new System.EventHandler(this.BACKtpp_Click);
            // 
            // LOGOUT
            // 
            this.LOGOUT.BackColor = System.Drawing.Color.Gainsboro;
            this.LOGOUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LOGOUT.BackgroundImage")));
            this.LOGOUT.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUT.Location = new System.Drawing.Point(433, 373);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(331, 44);
            this.LOGOUT.TabIndex = 16;
            this.LOGOUT.Text = "Logout";
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(606, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Department Head menu";
            // 
            // A_DepartmentHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.BACKtpp);
            this.Controls.Add(this.VIEWREPORTS);
            this.Controls.Add(this.ALLOCATION);
            this.Controls.Add(this.SCHEDUALING);
            this.Controls.Add(this.DETERMINATION);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label1);
            this.Name = "A_DepartmentHead";
            this.Text = "Department Head menu";
            this.Load += new System.EventHandler(this.A_DepartmentHead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button DETERMINATION;
        private System.Windows.Forms.Button SCHEDUALING;
        private System.Windows.Forms.Button ALLOCATION;
        private System.Windows.Forms.Button VIEWREPORTS;
        private System.Windows.Forms.Button BACKtpp;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Label label2;
    }
}