namespace CourseWork2.UI.Forms
{
    partial class FormReg
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbLoginFalse = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordFalse = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordRepeatFalse = new System.Windows.Forms.TextBox();
            this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
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
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnReg);
            this.pnlMain.Controls.Add(this.tbPasswordRepeat);
            this.pnlMain.Controls.Add(this.tbPasswordRepeatFalse);
            this.pnlMain.Controls.Add(this.tbPassword);
            this.pnlMain.Controls.Add(this.tbPasswordFalse);
            this.pnlMain.Controls.Add(this.tbLogin);
            this.pnlMain.Controls.Add(this.tbLoginFalse);
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(354, 278);
            this.pnlMain.TabIndex = 1;
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
            this.lblTitle.Text = "Регистрация";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // tbLoginFalse
            // 
            this.tbLoginFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbLoginFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginFalse.ForeColor = System.Drawing.Color.White;
            this.tbLoginFalse.Location = new System.Drawing.Point(67, 27);
            this.tbLoginFalse.Margin = new System.Windows.Forms.Padding(0);
            this.tbLoginFalse.Multiline = true;
            this.tbLoginFalse.Name = "tbLoginFalse";
            this.tbLoginFalse.ReadOnly = true;
            this.tbLoginFalse.Size = new System.Drawing.Size(220, 35);
            this.tbLoginFalse.TabIndex = 0;
            this.tbLoginFalse.Enter += new System.EventHandler(this.TbLoginFalse_OnFocusEnter);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.tbLogin.Location = new System.Drawing.Point(72, 35);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(210, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Логин";
            this.tbLogin.Enter += new System.EventHandler(this.TbLogin_OnFocusEnter);
            this.tbLogin.Leave += new System.EventHandler(this.TbLogin_OnFocusLeave);
            // 
            // tbPasswordFalse
            // 
            this.tbPasswordFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPasswordFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordFalse.ForeColor = System.Drawing.Color.White;
            this.tbPasswordFalse.Location = new System.Drawing.Point(67, 89);
            this.tbPasswordFalse.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordFalse.Multiline = true;
            this.tbPasswordFalse.Name = "tbPasswordFalse";
            this.tbPasswordFalse.ReadOnly = true;
            this.tbPasswordFalse.Size = new System.Drawing.Size(220, 35);
            this.tbPasswordFalse.TabIndex = 2;
            this.tbPasswordFalse.Enter += new System.EventHandler(this.TbPasswordFalse_OnFocusEnter);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.tbPassword.Location = new System.Drawing.Point(72, 97);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(210, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Пароль";
            this.tbPassword.Enter += new System.EventHandler(this.TbPassword_OnFocusEnter);
            this.tbPassword.Leave += new System.EventHandler(this.TbPassword_OnFocusLeave);
            // 
            // tbPasswordRepeatFalse
            // 
            this.tbPasswordRepeatFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPasswordRepeatFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordRepeatFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordRepeatFalse.ForeColor = System.Drawing.Color.White;
            this.tbPasswordRepeatFalse.Location = new System.Drawing.Point(67, 151);
            this.tbPasswordRepeatFalse.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordRepeatFalse.Multiline = true;
            this.tbPasswordRepeatFalse.Name = "tbPasswordRepeatFalse";
            this.tbPasswordRepeatFalse.ReadOnly = true;
            this.tbPasswordRepeatFalse.Size = new System.Drawing.Size(220, 35);
            this.tbPasswordRepeatFalse.TabIndex = 4;
            this.tbPasswordRepeatFalse.Enter += new System.EventHandler(this.TbPasswordRepeatFalse_OnFocusEnter);
            // 
            // tbPasswordRepeat
            // 
            this.tbPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tbPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordRepeat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.tbPasswordRepeat.Location = new System.Drawing.Point(72, 159);
            this.tbPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordRepeat.Name = "tbPasswordRepeat";
            this.tbPasswordRepeat.Size = new System.Drawing.Size(210, 20);
            this.tbPasswordRepeat.TabIndex = 5;
            this.tbPasswordRepeat.Text = "Повторный пароль";
            this.tbPasswordRepeat.Enter += new System.EventHandler(this.TbPasswordRepeat_OnFocusEnter);
            this.tbPasswordRepeat.Leave += new System.EventHandler(this.TbPasswordRepeat_OnFocusLeave);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(67, 213);
            this.btnReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(220, 35);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseCompatibleTextRendering = true;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnReg_OnPaint);
            this.btnReg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnReg_OnMouseDown);
            this.btnReg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnReg_OnMouseUp);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.Load += new System.EventHandler(this.FormReg_OnLoad);
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbLoginFalse;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPasswordFalse;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordRepeat;
        private System.Windows.Forms.TextBox tbPasswordRepeatFalse;
        private System.Windows.Forms.Button btnReg;
    }
}