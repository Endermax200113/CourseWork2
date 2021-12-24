using CourseWork2.UI.Controls;

namespace CourseWork2.UI.Forms.Main
{
	partial class FormMenuMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMain));
			this.lblPointer = new CourseWork2.UI.Controls.FlatLabel();
			this.btnWork = new CourseWork2.UI.Controls.FlatButton();
			this.pnlWork = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlWorkImg = new CourseWork2.UI.Controls.FlatPanel();
			this.imgWork = new System.Windows.Forms.PictureBox();
			this.pnlGame = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlGameImg = new CourseWork2.UI.Controls.FlatPanel();
			this.imgGame = new System.Windows.Forms.PictureBox();
			this.btnGame = new CourseWork2.UI.Controls.FlatButton();
			this.pnlServer = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlServerImg = new CourseWork2.UI.Controls.FlatPanel();
			this.imgServer = new System.Windows.Forms.PictureBox();
			this.btnServer = new CourseWork2.UI.Controls.FlatButton();
			this.pnlWork.SuspendLayout();
			this.pnlWorkImg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgWork)).BeginInit();
			this.pnlGame.SuspendLayout();
			this.pnlGameImg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgGame)).BeginInit();
			this.pnlServer.SuspendLayout();
			this.pnlServerImg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgServer)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPointer
			// 
			this.lblPointer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPointer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPointer.ForeColor = System.Drawing.Color.White;
			this.lblPointer.Location = new System.Drawing.Point(0, 20);
			this.lblPointer.Margin = new System.Windows.Forms.Padding(0);
			this.lblPointer.Name = "lblPointer";
			this.lblPointer.Size = new System.Drawing.Size(550, 40);
			this.lblPointer.TabIndex = 3;
			this.lblPointer.Text = "Выберите категорию, которую Вам нужно собрать";
			this.lblPointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnWork
			// 
			this.btnWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnWork.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnWork.FlatAppearance.BorderSize = 0;
			this.btnWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWork.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnWork.ForeColor = System.Drawing.Color.White;
			this.btnWork.Location = new System.Drawing.Point(0, 0);
			this.btnWork.Name = "btnWork";
			this.btnWork.Size = new System.Drawing.Size(510, 40);
			this.btnWork.TabIndex = 4;
			this.btnWork.Text = "Нужен компьютер для работы";
			this.btnWork.UseVisualStyleBackColor = false;
			this.btnWork.Click += new System.EventHandler(this.BtnWork_OnClick);
			this.btnWork.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnWork_OnPaint);
			this.btnWork.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnWork_OnMouseDown);
			this.btnWork.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnWork_OnMouseUp);
			// 
			// pnlWork
			// 
			this.pnlWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlWork.Controls.Add(this.pnlWorkImg);
			this.pnlWork.Controls.Add(this.btnWork);
			this.pnlWork.Location = new System.Drawing.Point(20, 80);
			this.pnlWork.Margin = new System.Windows.Forms.Padding(0);
			this.pnlWork.Name = "pnlWork";
			this.pnlWork.Size = new System.Drawing.Size(510, 152);
			this.pnlWork.TabIndex = 5;
			// 
			// pnlWorkImg
			// 
			this.pnlWorkImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlWorkImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlWorkImg.Controls.Add(this.imgWork);
			this.pnlWorkImg.Location = new System.Drawing.Point(0, 40);
			this.pnlWorkImg.Margin = new System.Windows.Forms.Padding(0);
			this.pnlWorkImg.Name = "pnlWorkImg";
			this.pnlWorkImg.Size = new System.Drawing.Size(510, 112);
			this.pnlWorkImg.TabIndex = 5;
			// 
			// imgWork
			// 
			this.imgWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.imgWork.Image = ((System.Drawing.Image)(resources.GetObject("imgWork.Image")));
			this.imgWork.InitialImage = null;
			this.imgWork.Location = new System.Drawing.Point(0, 0);
			this.imgWork.Margin = new System.Windows.Forms.Padding(0);
			this.imgWork.Name = "imgWork";
			this.imgWork.Size = new System.Drawing.Size(510, 112);
			this.imgWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgWork.TabIndex = 0;
			this.imgWork.TabStop = false;
			// 
			// pnlGame
			// 
			this.pnlGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlGame.Controls.Add(this.pnlGameImg);
			this.pnlGame.Controls.Add(this.btnGame);
			this.pnlGame.Location = new System.Drawing.Point(20, 253);
			this.pnlGame.Margin = new System.Windows.Forms.Padding(0);
			this.pnlGame.Name = "pnlGame";
			this.pnlGame.Size = new System.Drawing.Size(245, 152);
			this.pnlGame.TabIndex = 6;
			// 
			// pnlGameImg
			// 
			this.pnlGameImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlGameImg.Controls.Add(this.imgGame);
			this.pnlGameImg.Location = new System.Drawing.Point(0, 40);
			this.pnlGameImg.Margin = new System.Windows.Forms.Padding(0);
			this.pnlGameImg.Name = "pnlGameImg";
			this.pnlGameImg.Size = new System.Drawing.Size(245, 112);
			this.pnlGameImg.TabIndex = 1;
			// 
			// imgGame
			// 
			this.imgGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgGame.Image = global::CourseWork2.Properties.Resources.img_game;
			this.imgGame.Location = new System.Drawing.Point(0, 0);
			this.imgGame.Margin = new System.Windows.Forms.Padding(0);
			this.imgGame.Name = "imgGame";
			this.imgGame.Size = new System.Drawing.Size(245, 112);
			this.imgGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgGame.TabIndex = 0;
			this.imgGame.TabStop = false;
			// 
			// btnGame
			// 
			this.btnGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnGame.FlatAppearance.BorderSize = 0;
			this.btnGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGame.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGame.ForeColor = System.Drawing.Color.White;
			this.btnGame.Location = new System.Drawing.Point(0, 0);
			this.btnGame.Margin = new System.Windows.Forms.Padding(0);
			this.btnGame.Name = "btnGame";
			this.btnGame.Size = new System.Drawing.Size(245, 40);
			this.btnGame.TabIndex = 0;
			this.btnGame.Text = "Нужен компьютер для игр";
			this.btnGame.UseVisualStyleBackColor = false;
			this.btnGame.Click += new System.EventHandler(this.BtnGame_OnClick);
			this.btnGame.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnGame_OnPaint);
			this.btnGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnGame_OnMouseDown);
			this.btnGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGame_OnMouseUp);
			// 
			// pnlServer
			// 
			this.pnlServer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlServer.Controls.Add(this.pnlServerImg);
			this.pnlServer.Controls.Add(this.btnServer);
			this.pnlServer.Location = new System.Drawing.Point(285, 253);
			this.pnlServer.Margin = new System.Windows.Forms.Padding(0);
			this.pnlServer.Name = "pnlServer";
			this.pnlServer.Size = new System.Drawing.Size(245, 152);
			this.pnlServer.TabIndex = 7;
			// 
			// pnlServerImg
			// 
			this.pnlServerImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlServerImg.Controls.Add(this.imgServer);
			this.pnlServerImg.Location = new System.Drawing.Point(0, 40);
			this.pnlServerImg.Margin = new System.Windows.Forms.Padding(0);
			this.pnlServerImg.Name = "pnlServerImg";
			this.pnlServerImg.Size = new System.Drawing.Size(245, 112);
			this.pnlServerImg.TabIndex = 1;
			// 
			// imgServer
			// 
			this.imgServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgServer.Image = global::CourseWork2.Properties.Resources.img_server;
			this.imgServer.Location = new System.Drawing.Point(0, 0);
			this.imgServer.Margin = new System.Windows.Forms.Padding(0);
			this.imgServer.Name = "imgServer";
			this.imgServer.Size = new System.Drawing.Size(245, 112);
			this.imgServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgServer.TabIndex = 0;
			this.imgServer.TabStop = false;
			// 
			// btnServer
			// 
			this.btnServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnServer.FlatAppearance.BorderSize = 0;
			this.btnServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnServer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnServer.ForeColor = System.Drawing.Color.White;
			this.btnServer.Location = new System.Drawing.Point(0, 0);
			this.btnServer.Margin = new System.Windows.Forms.Padding(0);
			this.btnServer.Name = "btnServer";
			this.btnServer.Size = new System.Drawing.Size(245, 40);
			this.btnServer.TabIndex = 0;
			this.btnServer.Text = "Нужен компьютер для сервера";
			this.btnServer.UseVisualStyleBackColor = false;
			this.btnServer.Click += new System.EventHandler(this.BtnServer_OnClick);
			this.btnServer.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnServer_OnPaint);
			this.btnServer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnServer_OnMouseDown);
			this.btnServer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnServer_OnMouseUp);
			// 
			// FormMenuMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(550, 425);
			this.Controls.Add(this.pnlServer);
			this.Controls.Add(this.pnlGame);
			this.Controls.Add(this.pnlWork);
			this.Controls.Add(this.lblPointer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(550, 425);
			this.Name = "FormMenuMain";
			this.Text = "Главная";
			this.Load += new System.EventHandler(this.FormMenuMain_OnLoad);
			this.Resize += new System.EventHandler(this.FormMenuMain_OnResize);
			this.pnlWork.ResumeLayout(false);
			this.pnlWorkImg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgWork)).EndInit();
			this.pnlGame.ResumeLayout(false);
			this.pnlGameImg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgGame)).EndInit();
			this.pnlServer.ResumeLayout(false);
			this.pnlServerImg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgServer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private FlatLabel lblPointer;
		private FlatButton btnWork;
		private FlatPanel pnlWork;
		private FlatPanel pnlWorkImg;
		private FlatPanel pnlGame;
		private FlatPanel pnlServer;
		private FlatButton btnGame;
		private FlatButton btnServer;
		private FlatPanel pnlGameImg;
		private FlatPanel pnlServerImg;
		private System.Windows.Forms.PictureBox imgWork;
		private System.Windows.Forms.PictureBox imgGame;
		private System.Windows.Forms.PictureBox imgServer;
	}
}