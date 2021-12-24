using CourseWork2.UI.Controls;

namespace CourseWork2.UI.Forms.Main
{
	partial class FormMenuServer
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
			this.lblPointer = new CourseWork2.UI.Controls.FlatLabel();
			this.pnlComponents = new CourseWork2.UI.Controls.FlatPanel();
			this.btnSimulationStart = new CourseWork2.UI.Controls.FlatButton();
			this.btnSimulationStop = new CourseWork2.UI.Controls.FlatButton();
			this.lblSimulationInfo = new CourseWork2.UI.Controls.FlatLabel();
			this.SuspendLayout();
			// 
			// lblPointer
			// 
			this.lblPointer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPointer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPointer.ForeColor = System.Drawing.Color.White;
			this.lblPointer.Location = new System.Drawing.Point(0, 20);
			this.lblPointer.Margin = new System.Windows.Forms.Padding(0);
			this.lblPointer.Name = "lblPointer";
			this.lblPointer.Size = new System.Drawing.Size(550, 40);
			this.lblPointer.TabIndex = 0;
			this.lblPointer.Text = "Выберите серверный компьютер";
			this.lblPointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlComponents
			// 
			this.pnlComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComponents.AutoScroll = true;
			this.pnlComponents.Location = new System.Drawing.Point(0, 80);
			this.pnlComponents.Margin = new System.Windows.Forms.Padding(0);
			this.pnlComponents.Name = "pnlComponents";
			this.pnlComponents.Size = new System.Drawing.Size(550, 265);
			this.pnlComponents.TabIndex = 1;
			// 
			// btnSimulationStart
			// 
			this.btnSimulationStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSimulationStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStart.FlatAppearance.BorderSize = 0;
			this.btnSimulationStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimulationStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSimulationStart.ForeColor = System.Drawing.Color.White;
			this.btnSimulationStart.Location = new System.Drawing.Point(20, 365);
			this.btnSimulationStart.Margin = new System.Windows.Forms.Padding(0);
			this.btnSimulationStart.Name = "btnSimulationStart";
			this.btnSimulationStart.Size = new System.Drawing.Size(75, 40);
			this.btnSimulationStart.TabIndex = 2;
			this.btnSimulationStart.Text = "Старт";
			this.btnSimulationStart.UseVisualStyleBackColor = false;
			this.btnSimulationStart.Click += new System.EventHandler(this.BtnSimulationStart_OnClick);
			this.btnSimulationStart.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSimulationStart_OnPaint);
			this.btnSimulationStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSimulationStart_OnMouseDown);
			this.btnSimulationStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSimulationStart_OnMouseUp);
			// 
			// btnSimulationStop
			// 
			this.btnSimulationStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSimulationStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStop.FlatAppearance.BorderSize = 0;
			this.btnSimulationStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimulationStop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSimulationStop.ForeColor = System.Drawing.Color.White;
			this.btnSimulationStop.Location = new System.Drawing.Point(115, 365);
			this.btnSimulationStop.Margin = new System.Windows.Forms.Padding(0);
			this.btnSimulationStop.Name = "btnSimulationStop";
			this.btnSimulationStop.Size = new System.Drawing.Size(75, 40);
			this.btnSimulationStop.TabIndex = 3;
			this.btnSimulationStop.Text = "Стоп";
			this.btnSimulationStop.UseVisualStyleBackColor = false;
			this.btnSimulationStop.Click += new System.EventHandler(this.BtnSimulationStop_OnClick);
			this.btnSimulationStop.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnSimulationStop_OnPaint);
			this.btnSimulationStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSimulationStop_OnMouseDown);
			this.btnSimulationStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSimulationStop_OnMouseUp);
			// 
			// lblSimulationInfo
			// 
			this.lblSimulationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSimulationInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSimulationInfo.ForeColor = System.Drawing.Color.White;
			this.lblSimulationInfo.Location = new System.Drawing.Point(210, 365);
			this.lblSimulationInfo.Margin = new System.Windows.Forms.Padding(0);
			this.lblSimulationInfo.Name = "lblSimulationInfo";
			this.lblSimulationInfo.Size = new System.Drawing.Size(320, 40);
			this.lblSimulationInfo.TabIndex = 4;
			this.lblSimulationInfo.Text = "Симуляция отключена";
			this.lblSimulationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormMenuServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(550, 425);
			this.Controls.Add(this.lblSimulationInfo);
			this.Controls.Add(this.btnSimulationStop);
			this.Controls.Add(this.btnSimulationStart);
			this.Controls.Add(this.pnlComponents);
			this.Controls.Add(this.lblPointer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(550, 425);
			this.Name = "FormMenuServer";
			this.Text = "Для сервера";
			this.Load += new System.EventHandler(this.FormMenuWork_OnLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private FlatLabel lblPointer;
		public FlatPanel pnlComponents;
		private FlatButton btnSimulationStart;
		private FlatButton btnSimulationStop;
		public FlatLabel lblSimulationInfo;
	}
}