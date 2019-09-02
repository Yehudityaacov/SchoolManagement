namespace New
{
    partial class ALoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALoginScreen));
            this.labelID = new System.Windows.Forms.Label();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelID.Location = new System.Drawing.Point(81, 73);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(35, 24);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.labelPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPASSWORD.Location = new System.Drawing.Point(56, 144);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(132, 24);
            this.labelPASSWORD.TabIndex = 1;
            this.labelPASSWORD.Text = "PASSWORD:";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(221, 73);
            this.id_text.Multiline = true;
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(218, 24);
            this.id_text.TabIndex = 2;
            this.id_text.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(223, 139);
            this.password_text.Multiline = true;
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(215, 29);
            this.password_text.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(303, 252);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(298, 61);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ALoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(710, 364);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.labelPASSWORD);
            this.Controls.Add(this.labelID);
            this.Name = "ALoginScreen";
            this.Text = "ALoginScreen";
            this.Load += new System.EventHandler(this.ALoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button buttonLogin;
    }
}