namespace CourseWork2.UI.Forms
{
    partial class FormLogin
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordFalse = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbLoginFalse = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 25);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(354, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Логин";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.tbPassword);
            this.pnlMain.Controls.Add(this.tbPasswordFalse);
            this.pnlMain.Controls.Add(this.tbLogin);
            this.pnlMain.Controls.Add(this.tbLoginFalse);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(354, 278);
            this.pnlMain.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.tbPassword.Location = new System.Drawing.Point(72, 129);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(210, 20);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "Пароль";
            this.tbPassword.Enter += new System.EventHandler(this.TbPassword_OnFocusEnter);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_OnKeyDown);
            this.tbPassword.Leave += new System.EventHandler(this.TbPassword_OnFocusLeave);
            // 
            // tbPasswordFalse
            // 
            this.tbPasswordFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPasswordFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordFalse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordFalse.ForeColor = System.Drawing.Color.White;
            this.tbPasswordFalse.Location = new System.Drawing.Point(67, 121);
            this.tbPasswordFalse.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordFalse.Multiline = true;
            this.tbPasswordFalse.Name = "tbPasswordFalse";
            this.tbPasswordFalse.ReadOnly = true;
            this.tbPasswordFalse.Size = new System.Drawing.Size(220, 35);
            this.tbPasswordFalse.TabIndex = 5;
            this.tbPasswordFalse.Enter += new System.EventHandler(this.TbPasswordFalse_OnFocusEnter);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.tbLogin.Location = new System.Drawing.Point(72, 51);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(210, 20);
            this.tbLogin.TabIndex = 4;
            this.tbLogin.Text = "Логин";
            this.tbLogin.Enter += new System.EventHandler(this.TbLogin_OnFocusEnter);
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbLogin_OnKeyDown);
            this.tbLogin.Leave += new System.EventHandler(this.TbLogin_OnFocusLeave);
            // 
            // tbLoginFalse
            // 
            this.tbLoginFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbLoginFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginFalse.CausesValidation = false;
            this.tbLoginFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginFalse.ForeColor = System.Drawing.Color.White;
            this.tbLoginFalse.Location = new System.Drawing.Point(67, 43);
            this.tbLoginFalse.Margin = new System.Windows.Forms.Padding(0);
            this.tbLoginFalse.Multiline = true;
            this.tbLoginFalse.Name = "tbLoginFalse";
            this.tbLoginFalse.ReadOnly = true;
            this.tbLoginFalse.Size = new System.Drawing.Size(220, 35);
            this.tbLoginFalse.TabIndex = 3;
            this.tbLoginFalse.Enter += new System.EventHandler(this.TbLoginFalse_OnFocusEnter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(116, 199);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_OnClick);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnLogin_OnPaint);
            this.btnLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_OnMouseDown);
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_OnMouseUp);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_OnLoad);
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginFalse;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPasswordFalse;
        private System.Windows.Forms.TextBox tbPassword;
    }
}