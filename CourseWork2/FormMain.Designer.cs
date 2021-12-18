
using CourseWork2.UI.Controls;

namespace CourseWork2
{
    partial class FormMain
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
			this.pnlMain = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlHeaderForm = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlTitle = new CourseWork2.UI.Controls.FlatPanel();
			this.lblTitle = new CourseWork2.UI.Controls.FlatLabel();
			this.pnlControl = new CourseWork2.UI.Controls.FlatPanel();
			this.btnMinimaze = new CourseWork2.UI.Controls.FlatButton();
			this.btnMaxMin = new CourseWork2.UI.Controls.FlatButton();
			this.btnClose = new CourseWork2.UI.Controls.FlatButton();
			this.pnlBorderTopLeft = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderTop = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderTopRight = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderLeft1 = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderRight1 = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderBottomLeft = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderBottom = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderBottomRight = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderLeft2 = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlBorderRight2 = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlMain.SuspendLayout();
			this.pnlHeaderForm.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.pnlMain.Controls.Add(this.pnlHeaderForm);
			this.pnlMain.Location = new System.Drawing.Point(5, 5);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(800, 450);
			this.pnlMain.TabIndex = 0;
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
			this.pnlHeaderForm.Size = new System.Drawing.Size(800, 25);
			this.pnlHeaderForm.TabIndex = 0;
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(725, 25);
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
			this.lblTitle.Size = new System.Drawing.Size(725, 25);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Сборка компьютеров AvgElbrusEnjoyer";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblTitle_OnDown);
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlControl.Controls.Add(this.btnMinimaze);
			this.pnlControl.Controls.Add(this.btnMaxMin);
			this.pnlControl.Controls.Add(this.btnClose);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlControl.Location = new System.Drawing.Point(725, 0);
			this.pnlControl.Margin = new System.Windows.Forms.Padding(0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(75, 25);
			this.pnlControl.TabIndex = 0;
			// 
			// btnMinimaze
			// 
			this.btnMinimaze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMinimaze.FlatAppearance.BorderSize = 0;
			this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimaze.Location = new System.Drawing.Point(0, 0);
			this.btnMinimaze.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimaze.Name = "btnMinimaze";
			this.btnMinimaze.Size = new System.Drawing.Size(25, 25);
			this.btnMinimaze.TabIndex = 2;
			this.btnMinimaze.UseVisualStyleBackColor = true;
			this.btnMinimaze.Click += new System.EventHandler(this.BtnMinimaze_OnClick);
			this.btnMinimaze.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMinimaze_OnPaint);
			this.btnMinimaze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMinimaze_OnMouseDown);
			this.btnMinimaze.MouseEnter += new System.EventHandler(this.BtnMinimaze_OnMouseEnter);
			this.btnMinimaze.MouseLeave += new System.EventHandler(this.BtnMinimaze_OnMouseLeave);
			this.btnMinimaze.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMinimaze_OnMouseUp);
			// 
			// btnMaxMin
			// 
			this.btnMaxMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMaxMin.FlatAppearance.BorderSize = 0;
			this.btnMaxMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaxMin.Location = new System.Drawing.Point(25, 0);
			this.btnMaxMin.Margin = new System.Windows.Forms.Padding(0);
			this.btnMaxMin.Name = "btnMaxMin";
			this.btnMaxMin.Size = new System.Drawing.Size(25, 25);
			this.btnMaxMin.TabIndex = 1;
			this.btnMaxMin.UseVisualStyleBackColor = true;
			this.btnMaxMin.Click += new System.EventHandler(this.BtnMaxMin_OnClick);
			this.btnMaxMin.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnMaxMin_OnPaint);
			this.btnMaxMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMaxMin_OnMouseDown);
			this.btnMaxMin.MouseEnter += new System.EventHandler(this.BtnMaxMin_OnMouseEnter);
			this.btnMaxMin.MouseLeave += new System.EventHandler(this.BtnMaxMin_OnMouseLeave);
			this.btnMaxMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMaxMin_OnMouseUp);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(50, 0);
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
			// pnlBorderTopLeft
			// 
			this.pnlBorderTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderTopLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.pnlBorderTopLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlBorderTopLeft.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderTopLeft.Name = "pnlBorderTopLeft";
			this.pnlBorderTopLeft.Size = new System.Drawing.Size(5, 5);
			this.pnlBorderTopLeft.TabIndex = 1;
			this.pnlBorderTopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopLeft_OnMouseDown);
			this.pnlBorderTopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopLeft_OnMouseMove);
			this.pnlBorderTopLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopLeft_OnMouseUp);
			// 
			// pnlBorderTop
			// 
			this.pnlBorderTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.pnlBorderTop.Location = new System.Drawing.Point(5, 0);
			this.pnlBorderTop.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderTop.Name = "pnlBorderTop";
			this.pnlBorderTop.Size = new System.Drawing.Size(800, 5);
			this.pnlBorderTop.TabIndex = 2;
			this.pnlBorderTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTop_OnMouseDown);
			this.pnlBorderTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTop_OnMouseMove);
			this.pnlBorderTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTop_OnMouseUp);
			// 
			// pnlBorderTopRight
			// 
			this.pnlBorderTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderTopRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.pnlBorderTopRight.Location = new System.Drawing.Point(805, 0);
			this.pnlBorderTopRight.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderTopRight.Name = "pnlBorderTopRight";
			this.pnlBorderTopRight.Size = new System.Drawing.Size(5, 5);
			this.pnlBorderTopRight.TabIndex = 3;
			this.pnlBorderTopRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopRight_OnMouseDown);
			this.pnlBorderTopRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopRight_OnMouseMove);
			this.pnlBorderTopRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderTopRight_OnMouseUp);
			// 
			// pnlBorderLeft1
			// 
			this.pnlBorderLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderLeft1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.pnlBorderLeft1.Location = new System.Drawing.Point(0, 5);
			this.pnlBorderLeft1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderLeft1.Name = "pnlBorderLeft1";
			this.pnlBorderLeft1.Size = new System.Drawing.Size(5, 25);
			this.pnlBorderLeft1.TabIndex = 4;
			this.pnlBorderLeft1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderLeft_OnMouseDown);
			this.pnlBorderLeft1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderLeft_OnMouseMove);
			this.pnlBorderLeft1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBoderLeft_OnMouseUp);
			// 
			// pnlBorderRight1
			// 
			this.pnlBorderRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderRight1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.pnlBorderRight1.Location = new System.Drawing.Point(805, 5);
			this.pnlBorderRight1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderRight1.Name = "pnlBorderRight1";
			this.pnlBorderRight1.Size = new System.Drawing.Size(5, 25);
			this.pnlBorderRight1.TabIndex = 5;
			this.pnlBorderRight1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseDown);
			this.pnlBorderRight1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseMove);
			this.pnlBorderRight1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseUp);
			// 
			// pnlBorderBottomLeft
			// 
			this.pnlBorderBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlBorderBottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderBottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.pnlBorderBottomLeft.Location = new System.Drawing.Point(0, 455);
			this.pnlBorderBottomLeft.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderBottomLeft.Name = "pnlBorderBottomLeft";
			this.pnlBorderBottomLeft.Size = new System.Drawing.Size(5, 5);
			this.pnlBorderBottomLeft.TabIndex = 6;
			this.pnlBorderBottomLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomLeft_OnMouseDown);
			this.pnlBorderBottomLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomLeft_OnMouseMove);
			this.pnlBorderBottomLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomLeft_OnMouseUp);
			// 
			// pnlBorderBottom
			// 
			this.pnlBorderBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.pnlBorderBottom.Location = new System.Drawing.Point(5, 455);
			this.pnlBorderBottom.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderBottom.Name = "pnlBorderBottom";
			this.pnlBorderBottom.Size = new System.Drawing.Size(800, 5);
			this.pnlBorderBottom.TabIndex = 7;
			this.pnlBorderBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottom_OnMouseDown);
			this.pnlBorderBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottom_OnMouseMove);
			this.pnlBorderBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottom_OnMouseUp);
			// 
			// pnlBorderBottomRight
			// 
			this.pnlBorderBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderBottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderBottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.pnlBorderBottomRight.Location = new System.Drawing.Point(805, 455);
			this.pnlBorderBottomRight.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderBottomRight.Name = "pnlBorderBottomRight";
			this.pnlBorderBottomRight.Size = new System.Drawing.Size(5, 5);
			this.pnlBorderBottomRight.TabIndex = 8;
			this.pnlBorderBottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomRight_OnMouseDown);
			this.pnlBorderBottomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomRight_OnMouseMove);
			this.pnlBorderBottomRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderBottomRight_OnMouseUp);
			// 
			// pnlBorderLeft2
			// 
			this.pnlBorderLeft2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlBorderLeft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderLeft2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.pnlBorderLeft2.Location = new System.Drawing.Point(0, 30);
			this.pnlBorderLeft2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderLeft2.Name = "pnlBorderLeft2";
			this.pnlBorderLeft2.Size = new System.Drawing.Size(5, 425);
			this.pnlBorderLeft2.TabIndex = 9;
			this.pnlBorderLeft2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderLeft_OnMouseDown);
			this.pnlBorderLeft2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderLeft_OnMouseMove);
			this.pnlBorderLeft2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBoderLeft_OnMouseUp);
			// 
			// pnlBorderRight2
			// 
			this.pnlBorderRight2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBorderRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlBorderRight2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.pnlBorderRight2.Location = new System.Drawing.Point(805, 30);
			this.pnlBorderRight2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBorderRight2.Name = "pnlBorderRight2";
			this.pnlBorderRight2.Size = new System.Drawing.Size(5, 425);
			this.pnlBorderRight2.TabIndex = 10;
			this.pnlBorderRight2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseDown);
			this.pnlBorderRight2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseMove);
			this.pnlBorderRight2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBorderRight_OnMouseUp);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(810, 460);
			this.Controls.Add(this.pnlBorderRight2);
			this.Controls.Add(this.pnlBorderLeft2);
			this.Controls.Add(this.pnlBorderBottomRight);
			this.Controls.Add(this.pnlBorderBottom);
			this.Controls.Add(this.pnlBorderBottomLeft);
			this.Controls.Add(this.pnlBorderRight1);
			this.Controls.Add(this.pnlBorderLeft1);
			this.Controls.Add(this.pnlBorderTopRight);
			this.Controls.Add(this.pnlBorderTop);
			this.Controls.Add(this.pnlBorderTopLeft);
			this.Controls.Add(this.pnlMain);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(810, 460);
			this.Name = "FormMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
			this.pnlMain.ResumeLayout(false);
			this.pnlHeaderForm.ResumeLayout(false);
			this.pnlTitle.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private FlatPanel pnlMain;
        private FlatPanel pnlHeaderForm;
        private FlatPanel pnlControl;
        private FlatButton btnClose;
        private FlatButton btnMaxMin;
        private FlatButton btnMinimaze;
        private FlatPanel pnlTitle;
        private FlatLabel lblTitle;
        private FlatPanel pnlBorderTopLeft;
        private FlatPanel pnlBorderTop;
        private FlatPanel pnlBorderTopRight;
        private FlatPanel pnlBorderLeft1;
        private FlatPanel pnlBorderRight1;
        private FlatPanel pnlBorderBottomLeft;
        private FlatPanel pnlBorderBottom;
        private FlatPanel pnlBorderBottomRight;
        private FlatPanel pnlBorderLeft2;
        private FlatPanel pnlBorderRight2;
    }
}