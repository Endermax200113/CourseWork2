using CourseWork2.UI.Controls;

namespace CourseWork2.UI.Forms.Main
{
	partial class FormMenuGame
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
			this.pnlCompPower = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgPower = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompPower = new System.Windows.Forms.PictureBox();
			this.cbCompPower = new System.Windows.Forms.ComboBox();
			this.pnlCompHDD = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgHDD = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompHDD = new System.Windows.Forms.PictureBox();
			this.cbCompHDD = new System.Windows.Forms.ComboBox();
			this.pnlCompGPU = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgGPU = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompGPU = new System.Windows.Forms.PictureBox();
			this.cbCompGPU = new System.Windows.Forms.ComboBox();
			this.pnlCompRAM = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgRAM = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompRAM = new System.Windows.Forms.PictureBox();
			this.cbCompRAM = new System.Windows.Forms.ComboBox();
			this.pnlCompCPU = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgCPU = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompCPU = new System.Windows.Forms.PictureBox();
			this.cbCompCPU = new System.Windows.Forms.ComboBox();
			this.pnlCompMothercard = new CourseWork2.UI.Controls.FlatPanel();
			this.pnlCompImgMothercard = new CourseWork2.UI.Controls.FlatPanel();
			this.imgCompMothercard = new System.Windows.Forms.PictureBox();
			this.cbCompMothercard = new System.Windows.Forms.ComboBox();
			this.btnSimulationStart = new CourseWork2.UI.Controls.FlatButton();
			this.btnSimulationStop = new CourseWork2.UI.Controls.FlatButton();
			this.lblSimulationInfo = new CourseWork2.UI.Controls.FlatLabel();
			this.btnOrder = new System.Windows.Forms.Button();
			this.pnlComponents.SuspendLayout();
			this.pnlCompPower.SuspendLayout();
			this.pnlCompImgPower.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompPower)).BeginInit();
			this.pnlCompHDD.SuspendLayout();
			this.pnlCompImgHDD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompHDD)).BeginInit();
			this.pnlCompGPU.SuspendLayout();
			this.pnlCompImgGPU.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompGPU)).BeginInit();
			this.pnlCompRAM.SuspendLayout();
			this.pnlCompImgRAM.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompRAM)).BeginInit();
			this.pnlCompCPU.SuspendLayout();
			this.pnlCompImgCPU.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompCPU)).BeginInit();
			this.pnlCompMothercard.SuspendLayout();
			this.pnlCompImgMothercard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgCompMothercard)).BeginInit();
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
			this.lblPointer.Text = "Выберите компоненты";
			this.lblPointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlComponents
			// 
			this.pnlComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComponents.Controls.Add(this.pnlCompPower);
			this.pnlComponents.Controls.Add(this.pnlCompHDD);
			this.pnlComponents.Controls.Add(this.pnlCompGPU);
			this.pnlComponents.Controls.Add(this.pnlCompRAM);
			this.pnlComponents.Controls.Add(this.pnlCompCPU);
			this.pnlComponents.Controls.Add(this.pnlCompMothercard);
			this.pnlComponents.Location = new System.Drawing.Point(0, 80);
			this.pnlComponents.Margin = new System.Windows.Forms.Padding(0);
			this.pnlComponents.Name = "pnlComponents";
			this.pnlComponents.Size = new System.Drawing.Size(550, 265);
			this.pnlComponents.TabIndex = 1;
			// 
			// pnlCompPower
			// 
			this.pnlCompPower.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompPower.Controls.Add(this.pnlCompImgPower);
			this.pnlCompPower.Controls.Add(this.cbCompPower);
			this.pnlCompPower.Location = new System.Drawing.Point(372, 142);
			this.pnlCompPower.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompPower.Name = "pnlCompPower";
			this.pnlCompPower.Size = new System.Drawing.Size(156, 122);
			this.pnlCompPower.TabIndex = 5;
			// 
			// pnlCompImgPower
			// 
			this.pnlCompImgPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgPower.Controls.Add(this.imgCompPower);
			this.pnlCompImgPower.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgPower.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgPower.Name = "pnlCompImgPower";
			this.pnlCompImgPower.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgPower.TabIndex = 1;
			// 
			// imgCompPower
			// 
			this.imgCompPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompPower.Image = global::CourseWork2.Properties.Resources.img_game_power;
			this.imgCompPower.Location = new System.Drawing.Point(0, 0);
			this.imgCompPower.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompPower.Name = "imgCompPower";
			this.imgCompPower.Size = new System.Drawing.Size(156, 101);
			this.imgCompPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompPower.TabIndex = 0;
			this.imgCompPower.TabStop = false;
			// 
			// cbCompPower
			// 
			this.cbCompPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompPower.FormattingEnabled = true;
			this.cbCompPower.Items.AddRange(new object[] {
            "Блок питания"});
			this.cbCompPower.Location = new System.Drawing.Point(0, 0);
			this.cbCompPower.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompPower.Name = "cbCompPower";
			this.cbCompPower.Size = new System.Drawing.Size(156, 21);
			this.cbCompPower.TabIndex = 0;
			this.cbCompPower.SelectedIndexChanged += new System.EventHandler(this.CbCompPower_OnSelectedIndexChanged);
			// 
			// pnlCompHDD
			// 
			this.pnlCompHDD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompHDD.Controls.Add(this.pnlCompImgHDD);
			this.pnlCompHDD.Controls.Add(this.cbCompHDD);
			this.pnlCompHDD.Location = new System.Drawing.Point(196, 142);
			this.pnlCompHDD.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompHDD.Name = "pnlCompHDD";
			this.pnlCompHDD.Size = new System.Drawing.Size(156, 122);
			this.pnlCompHDD.TabIndex = 4;
			// 
			// pnlCompImgHDD
			// 
			this.pnlCompImgHDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgHDD.Controls.Add(this.imgCompHDD);
			this.pnlCompImgHDD.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgHDD.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgHDD.Name = "pnlCompImgHDD";
			this.pnlCompImgHDD.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgHDD.TabIndex = 1;
			// 
			// imgCompHDD
			// 
			this.imgCompHDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompHDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompHDD.Image = global::CourseWork2.Properties.Resources.img_game_HDD;
			this.imgCompHDD.Location = new System.Drawing.Point(0, 0);
			this.imgCompHDD.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompHDD.Name = "imgCompHDD";
			this.imgCompHDD.Size = new System.Drawing.Size(156, 101);
			this.imgCompHDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompHDD.TabIndex = 0;
			this.imgCompHDD.TabStop = false;
			// 
			// cbCompHDD
			// 
			this.cbCompHDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompHDD.FormattingEnabled = true;
			this.cbCompHDD.Items.AddRange(new object[] {
            "Жёсткий диск"});
			this.cbCompHDD.Location = new System.Drawing.Point(0, 0);
			this.cbCompHDD.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompHDD.Name = "cbCompHDD";
			this.cbCompHDD.Size = new System.Drawing.Size(156, 21);
			this.cbCompHDD.TabIndex = 0;
			this.cbCompHDD.SelectedIndexChanged += new System.EventHandler(this.CbCompHDD_OnSelectedIndexChanged);
			// 
			// pnlCompGPU
			// 
			this.pnlCompGPU.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompGPU.Controls.Add(this.pnlCompImgGPU);
			this.pnlCompGPU.Controls.Add(this.cbCompGPU);
			this.pnlCompGPU.Location = new System.Drawing.Point(20, 142);
			this.pnlCompGPU.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompGPU.Name = "pnlCompGPU";
			this.pnlCompGPU.Size = new System.Drawing.Size(156, 122);
			this.pnlCompGPU.TabIndex = 3;
			// 
			// pnlCompImgGPU
			// 
			this.pnlCompImgGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgGPU.Controls.Add(this.imgCompGPU);
			this.pnlCompImgGPU.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgGPU.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgGPU.Name = "pnlCompImgGPU";
			this.pnlCompImgGPU.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgGPU.TabIndex = 1;
			// 
			// imgCompGPU
			// 
			this.imgCompGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompGPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompGPU.Image = global::CourseWork2.Properties.Resources.img_game_GPU;
			this.imgCompGPU.Location = new System.Drawing.Point(0, 0);
			this.imgCompGPU.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompGPU.Name = "imgCompGPU";
			this.imgCompGPU.Size = new System.Drawing.Size(156, 101);
			this.imgCompGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompGPU.TabIndex = 0;
			this.imgCompGPU.TabStop = false;
			// 
			// cbCompGPU
			// 
			this.cbCompGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompGPU.FormattingEnabled = true;
			this.cbCompGPU.Items.AddRange(new object[] {
            "Видеокарта"});
			this.cbCompGPU.Location = new System.Drawing.Point(0, 0);
			this.cbCompGPU.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompGPU.Name = "cbCompGPU";
			this.cbCompGPU.Size = new System.Drawing.Size(156, 21);
			this.cbCompGPU.TabIndex = 0;
			this.cbCompGPU.SelectedIndexChanged += new System.EventHandler(this.CbCompGPU_OnSelectedIndexChanged);
			// 
			// pnlCompRAM
			// 
			this.pnlCompRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompRAM.Controls.Add(this.pnlCompImgRAM);
			this.pnlCompRAM.Controls.Add(this.cbCompRAM);
			this.pnlCompRAM.Location = new System.Drawing.Point(372, 0);
			this.pnlCompRAM.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompRAM.Name = "pnlCompRAM";
			this.pnlCompRAM.Size = new System.Drawing.Size(156, 122);
			this.pnlCompRAM.TabIndex = 2;
			// 
			// pnlCompImgRAM
			// 
			this.pnlCompImgRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgRAM.Controls.Add(this.imgCompRAM);
			this.pnlCompImgRAM.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgRAM.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgRAM.Name = "pnlCompImgRAM";
			this.pnlCompImgRAM.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgRAM.TabIndex = 1;
			// 
			// imgCompRAM
			// 
			this.imgCompRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompRAM.Image = global::CourseWork2.Properties.Resources.img_game_RAM;
			this.imgCompRAM.Location = new System.Drawing.Point(0, 0);
			this.imgCompRAM.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompRAM.Name = "imgCompRAM";
			this.imgCompRAM.Size = new System.Drawing.Size(156, 101);
			this.imgCompRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompRAM.TabIndex = 0;
			this.imgCompRAM.TabStop = false;
			// 
			// cbCompRAM
			// 
			this.cbCompRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompRAM.FormattingEnabled = true;
			this.cbCompRAM.Items.AddRange(new object[] {
            "Оперативная память"});
			this.cbCompRAM.Location = new System.Drawing.Point(0, 0);
			this.cbCompRAM.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompRAM.Name = "cbCompRAM";
			this.cbCompRAM.Size = new System.Drawing.Size(156, 21);
			this.cbCompRAM.TabIndex = 0;
			this.cbCompRAM.SelectedIndexChanged += new System.EventHandler(this.CbCompRAM_OnSelectedIndexChanged);
			// 
			// pnlCompCPU
			// 
			this.pnlCompCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompCPU.Controls.Add(this.pnlCompImgCPU);
			this.pnlCompCPU.Controls.Add(this.cbCompCPU);
			this.pnlCompCPU.Location = new System.Drawing.Point(196, 0);
			this.pnlCompCPU.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompCPU.Name = "pnlCompCPU";
			this.pnlCompCPU.Size = new System.Drawing.Size(156, 122);
			this.pnlCompCPU.TabIndex = 1;
			// 
			// pnlCompImgCPU
			// 
			this.pnlCompImgCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgCPU.Controls.Add(this.imgCompCPU);
			this.pnlCompImgCPU.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgCPU.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgCPU.Name = "pnlCompImgCPU";
			this.pnlCompImgCPU.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgCPU.TabIndex = 1;
			// 
			// imgCompCPU
			// 
			this.imgCompCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompCPU.Image = global::CourseWork2.Properties.Resources.img_game_CPU;
			this.imgCompCPU.Location = new System.Drawing.Point(0, 0);
			this.imgCompCPU.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompCPU.Name = "imgCompCPU";
			this.imgCompCPU.Size = new System.Drawing.Size(156, 101);
			this.imgCompCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompCPU.TabIndex = 0;
			this.imgCompCPU.TabStop = false;
			// 
			// cbCompCPU
			// 
			this.cbCompCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompCPU.FormattingEnabled = true;
			this.cbCompCPU.Items.AddRange(new object[] {
            "Процессор"});
			this.cbCompCPU.Location = new System.Drawing.Point(0, 0);
			this.cbCompCPU.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompCPU.Name = "cbCompCPU";
			this.cbCompCPU.Size = new System.Drawing.Size(156, 21);
			this.cbCompCPU.TabIndex = 0;
			this.cbCompCPU.SelectedIndexChanged += new System.EventHandler(this.CbCompCPU_OnSelectedIndexChanged);
			// 
			// pnlCompMothercard
			// 
			this.pnlCompMothercard.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlCompMothercard.Controls.Add(this.pnlCompImgMothercard);
			this.pnlCompMothercard.Controls.Add(this.cbCompMothercard);
			this.pnlCompMothercard.Location = new System.Drawing.Point(20, 0);
			this.pnlCompMothercard.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompMothercard.Name = "pnlCompMothercard";
			this.pnlCompMothercard.Size = new System.Drawing.Size(156, 122);
			this.pnlCompMothercard.TabIndex = 0;
			// 
			// pnlCompImgMothercard
			// 
			this.pnlCompImgMothercard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCompImgMothercard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pnlCompImgMothercard.Controls.Add(this.imgCompMothercard);
			this.pnlCompImgMothercard.Location = new System.Drawing.Point(0, 21);
			this.pnlCompImgMothercard.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCompImgMothercard.Name = "pnlCompImgMothercard";
			this.pnlCompImgMothercard.Size = new System.Drawing.Size(156, 101);
			this.pnlCompImgMothercard.TabIndex = 1;
			// 
			// imgCompMothercard
			// 
			this.imgCompMothercard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgCompMothercard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgCompMothercard.Image = global::CourseWork2.Properties.Resources.img_game_mothercard;
			this.imgCompMothercard.Location = new System.Drawing.Point(0, 0);
			this.imgCompMothercard.Margin = new System.Windows.Forms.Padding(0);
			this.imgCompMothercard.Name = "imgCompMothercard";
			this.imgCompMothercard.Size = new System.Drawing.Size(156, 101);
			this.imgCompMothercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompMothercard.TabIndex = 0;
			this.imgCompMothercard.TabStop = false;
			// 
			// cbCompMothercard
			// 
			this.cbCompMothercard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCompMothercard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCompMothercard.FormattingEnabled = true;
			this.cbCompMothercard.Items.AddRange(new object[] {
            "Материнская плата"});
			this.cbCompMothercard.Location = new System.Drawing.Point(0, 0);
			this.cbCompMothercard.Margin = new System.Windows.Forms.Padding(0);
			this.cbCompMothercard.Name = "cbCompMothercard";
			this.cbCompMothercard.Size = new System.Drawing.Size(156, 21);
			this.cbCompMothercard.TabIndex = 0;
			this.cbCompMothercard.Tag = "";
			this.cbCompMothercard.SelectedIndexChanged += new System.EventHandler(this.CbCompMothercard_OnSelectedIndexChanged);
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
			this.lblSimulationInfo.Size = new System.Drawing.Size(170, 40);
			this.lblSimulationInfo.TabIndex = 4;
			this.lblSimulationInfo.Text = "Симуляция отключена";
			this.lblSimulationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOrder
			// 
			this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.BorderSize = 0;
			this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOrder.ForeColor = System.Drawing.Color.White;
			this.btnOrder.Location = new System.Drawing.Point(398, 365);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(130, 40);
			this.btnOrder.TabIndex = 5;
			this.btnOrder.Text = "0 р.";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.BtnOrder_OnClick);
			this.btnOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnOrder_OnPaint);
			this.btnOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnOrder_OnMouseDown);
			this.btnOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnOrder_OnMouseUp);
			// 
			// FormMenuGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
			this.ClientSize = new System.Drawing.Size(550, 425);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.lblSimulationInfo);
			this.Controls.Add(this.btnSimulationStop);
			this.Controls.Add(this.btnSimulationStart);
			this.Controls.Add(this.pnlComponents);
			this.Controls.Add(this.lblPointer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(550, 425);
			this.Name = "FormMenuGame";
			this.Text = "Для игр";
			this.Load += new System.EventHandler(this.FormMenuGame_OnLoad);
			this.Shown += new System.EventHandler(this.FormMenuGame_OnShown);
			this.Resize += new System.EventHandler(this.FormMenuGame_OnResize);
			this.pnlComponents.ResumeLayout(false);
			this.pnlCompPower.ResumeLayout(false);
			this.pnlCompImgPower.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompPower)).EndInit();
			this.pnlCompHDD.ResumeLayout(false);
			this.pnlCompImgHDD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompHDD)).EndInit();
			this.pnlCompGPU.ResumeLayout(false);
			this.pnlCompImgGPU.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompGPU)).EndInit();
			this.pnlCompRAM.ResumeLayout(false);
			this.pnlCompImgRAM.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompRAM)).EndInit();
			this.pnlCompCPU.ResumeLayout(false);
			this.pnlCompImgCPU.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompCPU)).EndInit();
			this.pnlCompMothercard.ResumeLayout(false);
			this.pnlCompImgMothercard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgCompMothercard)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private FlatLabel lblPointer;
		private FlatPanel pnlComponents;
		private FlatButton btnSimulationStart;
		private FlatButton btnSimulationStop;
		private FlatPanel pnlCompMothercard;
		private FlatPanel pnlCompCPU;
		private FlatPanel pnlCompRAM;
		private FlatPanel pnlCompGPU;
		private FlatPanel pnlCompHDD;
		private FlatPanel pnlCompPower;
		private FlatPanel pnlCompImgMothercard;
		private System.Windows.Forms.PictureBox imgCompMothercard;
		private FlatPanel pnlCompImgCPU;
		private FlatPanel pnlCompImgRAM;
		private System.Windows.Forms.PictureBox imgCompCPU;
		private FlatPanel pnlCompImgGPU;
		private System.Windows.Forms.PictureBox imgCompGPU;
		private System.Windows.Forms.PictureBox imgCompRAM;
		private FlatPanel pnlCompImgHDD;
		private System.Windows.Forms.PictureBox imgCompHDD;
		private FlatPanel pnlCompImgPower;
		private System.Windows.Forms.PictureBox imgCompPower;
		private System.Windows.Forms.Button btnOrder;
		public System.Windows.Forms.ComboBox cbCompMothercard;
		public System.Windows.Forms.ComboBox cbCompCPU;
		public System.Windows.Forms.ComboBox cbCompRAM;
		public System.Windows.Forms.ComboBox cbCompGPU;
		public System.Windows.Forms.ComboBox cbCompHDD;
		public System.Windows.Forms.ComboBox cbCompPower;
		public FlatLabel lblSimulationInfo;
	}
}