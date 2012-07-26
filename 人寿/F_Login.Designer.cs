namespace 人寿
{
    partial class F_Login
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
            this.labToolName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labToolName
            // 
            this.labToolName.AutoSize = true;
            this.labToolName.Font = new System.Drawing.Font("STKaiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labToolName.Location = new System.Drawing.Point(157, 9);
            this.labToolName.Name = "labToolName";
            this.labToolName.Size = new System.Drawing.Size(94, 23);
            this.labToolName.TabIndex = 0;
            this.labToolName.Text = "工具名称";
            this.labToolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(151, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(158, 21);
            this.textName.TabIndex = 1;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(80, 63);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(56, 14);
            this.labName.TabIndex = 2;
            this.labName.Text = "用户名:";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPass.Location = new System.Drawing.Point(80, 90);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(56, 14);
            this.labPass.TabIndex = 4;
            this.labPass.Text = "密  码:";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(151, 87);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(158, 21);
            this.textPass.TabIndex = 3;
            this.textPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPass_KeyPress);
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(112, 130);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(71, 24);
            this.butLogin.TabIndex = 5;
            this.butLogin.Text = "登  陆";
            this.butLogin.UseVisualStyleBackColor = true;
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(220, 130);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(71, 24);
            this.butClose.TabIndex = 6;
            this.butClose.Text = "取  消";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 183);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labToolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labToolName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butClose;
    }
}

