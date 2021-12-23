namespace CourseWork2.UI.Forms.Main
{
	partial class FormFill
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
			this.pnlHeaderForm = new System.Windows.Forms.Panel();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnOrder = new System.Windows.Forms.Button();
			this.tbLastnameFalse = new System.Windows.Forms.TextBox();
			this.tbNameFalse = new System.Windows.Forms.TextBox();
			this.pnlHeaderForm.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeaderForm
			// 
			this.pnlHeaderForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlHeaderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlHeaderForm.Controls.Add(this.pnlTitle);
			this.pnlHeaderForm.Controls.Add(this.pnlControl);
			this.pnlHeaderForm.Location = new System.Drawing.Point(0, 0);
			this.pnlHeaderForm.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeaderForm.Name = "pnlHeaderForm";
			this.pnlHeaderForm.Size = new System.Drawing.Size(400, 25);
			this.pnlHeaderForm.TabIndex = 1;
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(375, 25);
			this.pnlTitle.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lblTitle.Size = new System.Drawing.Size(375, 25);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Оформление";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitle_OnDown);
			// 
			// pnlControl
			// 
			this.pnlControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlControl.Controls.Add(this.btnClose);
			this.pnlControl.Location = new System.Drawing.Point(375, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(25, 25);
			this.pnlControl.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(0, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(25, 25);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_OnClick);
			this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnClose_OnPaint);
			this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnClose_OnMouseDown);
			this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_OnMouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_OnMouseLeave);
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.Controls.Add(this.tbLastname);
			this.pnlMain.Controls.Add(this.tbName);
			this.pnlMain.Controls.Add(this.btnOrder);
			this.pnlMain.Controls.Add(this.tbLastnameFalse);
			this.pnlMain.Controls.Add(this.tbNameFalse);
			this.pnlMain.Location = new System.Drawing.Point(0, 25);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(400, 230);
			this.pnlMain.TabIndex = 2;
			// 
			// tbLastname
			// 
			this.tbLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
			this.tbLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLastname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.tbLastname.Location = new System.Drawing.Point(35, 103);
			this.tbLastname.Margin = new System.Windows.Forms.Padding(0);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(330, 20);
			this.tbLastname.TabIndex = 4;
			this.tbLastname.Text = "Фамилия";
			this.tbLastname.Enter += new System.EventHandler(this.TbLastname_OnFocusEnter);
			this.tbLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbLastname_OnKeyDown);
			this.tbLastname.Leave += new System.EventHandler(this.TbLastname_OnFocusLeave);
			// 
			// tbName
			// 
			this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.tbName.Location = new System.Drawing.Point(35, 38);
			this.tbName.Margin = new System.Windows.Forms.Padding(0);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(330, 20);
			this.tbName.TabIndex = 3;
			this.tbName.Text = "Имя";
			this.tbName.Enter += new System.EventHandler(this.TbName_OnFocusEnter);
			this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbName_OnKeyDown);
			this.tbName.Leave += new System.EventHandler(this.TbName_OnFocusLeave);
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.BorderSize = 0;
			this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOrder.ForeColor = System.Drawing.Color.White;
			this.btnOrder.Location = new System.Drawing.Point(112, 160);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(174, 40);
			this.btnOrder.TabIndex = 2;
			this.btnOrder.Text = "Оформить заказ";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrder_OnClick);
			this.btnOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnOrder_OnPaint);
			this.btnOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnOrder_OnMouseDown);
			this.btnOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnOrder_OnMouseUp);
			// 
			// tbLastnameFalse
			// 
			this.tbLastnameFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
			this.tbLastnameFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLastnameFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastnameFalse.ForeColor = System.Drawing.Color.White;
			this.tbLastnameFalse.Location = new System.Drawing.Point(30, 95);
			this.tbLastnameFalse.Margin = new System.Windows.Forms.Padding(0);
			this.tbLastnameFalse.Multiline = true;
			this.tbLastnameFalse.Name = "tbLastnameFalse";
			this.tbLastnameFalse.ReadOnly = true;
			this.tbLastnameFalse.Size = new System.Drawing.Size(340, 35);
			this.tbLastnameFalse.TabIndex = 1;
			this.tbLastnameFalse.Enter += new System.EventHandler(this.TbLastnameFalse_OnFocusEnter);
			// 
			// tbNameFalse
			// 
			this.tbNameFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
			this.tbNameFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNameFalse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNameFalse.ForeColor = System.Drawing.Color.White;
			this.tbNameFalse.Location = new System.Drawing.Point(30, 30);
			this.tbNameFalse.Margin = new System.Windows.Forms.Padding(0);
			this.tbNameFalse.Multiline = true;
			this.tbNameFalse.Name = "tbNameFalse";
			this.tbNameFalse.ReadOnly = true;
			this.tbNameFalse.Size = new System.Drawing.Size(340, 35);
			this.tbNameFalse.TabIndex = 0;
			this.tbNameFalse.Enter += new System.EventHandler(this.TbNameFalse_OnFocusEnter);
			// 
			// FormFill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(400, 255);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnlHeaderForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFill";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Оформление";
			this.Load += new System.EventHandler(this.FormFill_OnLoad);
			this.pnlHeaderForm.ResumeLayout(false);
			this.pnlTitle.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlHeaderForm;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.TextBox tbNameFalse;
		private System.Windows.Forms.TextBox tbLastnameFalse;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbLastname;
	}
}