namespace CourseWork2
{
    partial class FormAuth
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlHeaderForm = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeaderAuth = new System.Windows.Forms.Panel();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.pnlBackStrip = new System.Windows.Forms.Panel();
            this.pnlStrip = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeaderForm.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlHeaderAuth.SuspendLayout();
            this.pnlReg.SuspendLayout();
            this.pnlBackStrip.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.pnlMain.Controls.Add(this.pnlForm);
            this.pnlMain.Controls.Add(this.pnlHeaderForm);
            this.pnlMain.Controls.Add(this.pnlHeaderAuth);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(354, 431);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Location = new System.Drawing.Point(0, 78);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(354, 353);
            this.pnlForm.TabIndex = 2;
            // 
            // pnlHeaderForm
            // 
            this.pnlHeaderForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeaderForm.Controls.Add(this.pnlControl);
            this.pnlHeaderForm.Controls.Add(this.pnlTitle);
            this.pnlHeaderForm.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderForm.Name = "pnlHeaderForm";
            this.pnlHeaderForm.Size = new System.Drawing.Size(354, 25);
            this.pnlHeaderForm.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlControl.Controls.Add(this.btnClose);
            this.pnlControl.Location = new System.Drawing.Point(329, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(25, 25);
            this.pnlControl.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_OnClick);
            this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnClose_OnPaint);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnClose_OnDown);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_OnEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_OnLeave);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(329, 25);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(329, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Авторизация";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseCompatibleTextRendering = true;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitle_OnDown);
            // 
            // pnlHeaderAuth
            // 
            this.pnlHeaderAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeaderAuth.Controls.Add(this.pnlReg);
            this.pnlHeaderAuth.Controls.Add(this.pnlBackStrip);
            this.pnlHeaderAuth.Controls.Add(this.pnlLogin);
            this.pnlHeaderAuth.Location = new System.Drawing.Point(0, 25);
            this.pnlHeaderAuth.Name = "pnlHeaderAuth";
            this.pnlHeaderAuth.Size = new System.Drawing.Size(354, 53);
            this.pnlHeaderAuth.TabIndex = 0;
            // 
            // pnlReg
            // 
            this.pnlReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlReg.Controls.Add(this.btnReg);
            this.pnlReg.Location = new System.Drawing.Point(177, 0);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(177, 50);
            this.pnlReg.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(0, 0);
            this.btnReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(177, 50);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_OnClick);
            this.btnReg.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnReg_OnPaint);
            this.btnReg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnReg_OnDown);
            this.btnReg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnReg_OnUp);
            // 
            // pnlBackStrip
            // 
            this.pnlBackStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBackStrip.Controls.Add(this.pnlStrip);
            this.pnlBackStrip.Location = new System.Drawing.Point(0, 50);
            this.pnlBackStrip.Name = "pnlBackStrip";
            this.pnlBackStrip.Size = new System.Drawing.Size(354, 3);
            this.pnlBackStrip.TabIndex = 1;
            // 
            // pnlStrip
            // 
            this.pnlStrip.BackColor = System.Drawing.Color.White;
            this.pnlStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlStrip.Name = "pnlStrip";
            this.pnlStrip.Size = new System.Drawing.Size(177, 3);
            this.pnlStrip.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(177, 50);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(177, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Логин";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_OnClick);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnLogin_OnPaint);
            this.btnLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_OnDown);
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_OnUp);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 431);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuth";
            this.Load += new System.EventHandler(this.FormAuth_OnLoad);
            this.Shown += new System.EventHandler(this.FormAuth_OnShown);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeaderForm.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlHeaderAuth.ResumeLayout(false);
            this.pnlReg.ResumeLayout(false);
            this.pnlBackStrip.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeaderForm;
        private System.Windows.Forms.Panel pnlHeaderAuth;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Panel pnlBackStrip;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Panel pnlStrip;
        private System.Windows.Forms.Panel pnlForm;
    }
}