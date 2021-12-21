using CourseWork2.Properties;
using CourseWork2.UI;
using CourseWork2.UI.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Animations;

namespace CourseWork2
{
    public partial class FormMain : ShadowForm
    {
        #region [Переменные]
        #region -> Общие
        private bool _mousePressed = false;
        private Form _activeForm;
        private TypeForm _typeForm = TypeForm.Main;
        private StringFormat _sfMenu = new StringFormat();
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        #endregion

        #region -> Кнопки
        #region -[Закрыть окно]-
        private Animation _animBtnCloseA = new Animation();
        private Animation _animBtnCloseR = new Animation();
        private Animation _animBtnCloseG = new Animation();
        private Animation _animBtnCloseB = new Animation();
        #endregion

        #region -[Развернуть окно/свернуть в окно]-
        private Animation _animBtnMaxMinA = new Animation();
        private Animation _animBtnMaxMinR = new Animation();
        private Animation _animBtnMaxMinG = new Animation();
        private Animation _animBtnMaxMinB = new Animation();
        #endregion

        #region -[Свернуть]-
        private Animation _animBtnMinimazeA = new Animation();
        private Animation _animBtnMinimazeR = new Animation();
        private Animation _animBtnMinimazeG = new Animation();
        private Animation _animBtnMinimazeB = new Animation();
        #endregion

        #region -[Главная]-
        private Point _clLocationMain = new Point();
        private Animation _animWavePressMain = new Animation();
        #endregion

        #region -[Для работы]-
        private Point _clLocationWork = new Point();
        private Animation _animWavePressWork = new Animation();
        #endregion

        #region -[Для игр]-
        private Point _clLocationGame = new Point();
        private Animation _animWavePressGame = new Animation();
        #endregion

        #region -[Для сервера]-
        private Point _clLocationServer = new Point();
        private Animation _animWavePressServer = new Animation();
        #endregion

        #region -[Настройки]-
        private Point _clLocationSettings = new Point();
        private Animation _animWavePressSettings = new Animation();
        #endregion
        #endregion

        #region -> Окно
        private Point _locCursor = new Point();
        private Size _sizeForm = new Size();
        private Point _locPrevForm = new Point();
        private bool _formMaximazed = false;
		#endregion
		#endregion

		#region [Свойства]
		#region -> Окно
		public Form ActiveFormTabs
		{
            get => _activeForm;
            set
			{
                if (_activeForm != value)
				{
                    if (value is FormMenuMain)
					{
                        MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 1, btnMenuMain.Width / 2, btnMenuMain.Height / 2, 0);
                        BtnMenuMain_OnMouseDown(btnMenuMain, e);
                        BtnMenuMain_OnMouseUp(btnMenuMain, e);
                    }
                    else if (value is FormMenuWork)
                    {
                        MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 1, btnMenuWork.Width / 2, btnMenuWork.Height / 2, 0);
                        BtnMenuWork_OnMouseDown(btnMenuWork, e);
                        BtnMenuWork_OnMouseUp(btnMenuWork, e);
                    }
                    else if (value is FormMenuGame)
                    {
                        MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 1, btnMenuGame.Width / 2, btnMenuGame.Height / 2, 0);
                        BtnMenuGame_OnMouseDown(btnMenuGame, e);
                        BtnMenuGame_OnMouseUp(btnMenuGame, e);
                    }
                    else if (value is FormMenuServer)
                    {
                        MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 1, btnMenuServer.Width / 2, btnMenuServer.Height / 2, 0);
                        BtnMenuServer_OnMouseDown(btnMenuServer, e);
                        BtnMenuServer_OnMouseUp(btnMenuServer, e);
                    }
                    else if (value is FormMenuSettings)
                    {
                        MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 1, btnMenuSettings.Width / 2, btnMenuSettings.Height / 2, 0);
                        BtnMenuSettings_OnMouseDown(btnMenuSettings, e);
                        BtnMenuSettings_OnMouseUp(btnMenuSettings, e);
                    }

                    OpenChildForm(value);
                }
			}
		}
		#endregion
		#endregion

		private enum TypeForm
		{
            Main, Work, Game, Server, Settings
		}

        public FormMain()
        {
            InitializeComponent();
            SetDoubleBuffered(this);

            _animBtnCloseA.Value = 255;
            _animBtnCloseR.Value = 26;
            _animBtnCloseG.Value = 28;
            _animBtnCloseB.Value = 41;

            _animBtnMaxMinA.Value = 255;
            _animBtnMaxMinR.Value = 26;
            _animBtnMaxMinG.Value = 28;
            _animBtnMaxMinB.Value = 41;

            _animBtnMinimazeA.Value = 255;
            _animBtnMinimazeR.Value = 26;
            _animBtnMinimazeG.Value = 28;
            _animBtnMinimazeB.Value = 41;

            _sfMenu.Alignment = StringAlignment.Near;
            _sfMenu.LineAlignment = StringAlignment.Center;

            _activeForm = new FormMenuMain(this);
        }

		#region [Слушатели]
		#region -> Окно
        private void FormMain_OnLoad(object sender, EventArgs e)
		{
            using (MemoryStream fontStream = new MemoryStream(Resources.Montserrat_Regular))
            {
                IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontData = new byte[fontStream.Length];

                fontStream.Read(fontData, 0, (int)fontStream.Length);
                Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
                _pfc.AddMemoryFont(data, (int)fontStream.Length);
                fontStream.Close();
                Marshal.FreeCoTaskMem(data);
            }

            lblTitle.Font = new Font(_pfc.Families[0], 10);
            btnMenuMain.Font = new Font(_pfc.Families[0], 12);
            btnMenuWork.Font = new Font(_pfc.Families[0], 12);
            btnMenuGame.Font = new Font(_pfc.Families[0], 12);
            btnMenuServer.Font = new Font(_pfc.Families[0], 12);
            btnMenuSettings.Font = new Font(_pfc.Families[0], 12);
        }

        private void FormMain_OnShown(object sender, EventArgs e)
		{
            OpenChildForm(new FormMenuMain(this));
		}
		#endregion

		#region -> Кнопки
		#region -[Закрыть окно]-
		private void BtnClose_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(26, 28, 41));

            Rectangle rect = new Rectangle(5, 5, btnClose.Width - 10, btnClose.Height - 10);
            Rectangle rectFill = new Rectangle(6, 6, btnClose.Width - 12, btnClose.Height - 12);
            Pen p = new Pen(Color.White, 2);

            g.FillEllipse(new SolidBrush(Color.FromArgb((int)_animBtnCloseA.Value, (int)_animBtnCloseR.Value, (int)_animBtnCloseG.Value, (int)_animBtnCloseB.Value)), rectFill);
            g.DrawEllipse(p, rect);
        }

        private void BtnClose_OnMouseDown(object sender, MouseEventArgs e)
        {
            _animBtnCloseA = new Animation("btnCloseA_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseA.Value, 200);

            _animBtnCloseA.StepDivider = 5;
            Animator.Request(_animBtnCloseA, true);
        }

        private void BtnClose_OnMouseEnter(object sender, EventArgs e)
        {
            _animBtnCloseR = new Animation("btnCloseR_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseR.Value, FlatColor.Red.R);
            _animBtnCloseG = new Animation("btnCloseG_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseG.Value, FlatColor.Red.G);
            _animBtnCloseB = new Animation("btnCloseB_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseB.Value, FlatColor.Red.B);

            _animBtnCloseR.StepDivider = 5;
            _animBtnCloseG.StepDivider = 5;
            _animBtnCloseB.StepDivider = 5;
            Animator.Request(_animBtnCloseR, true);
            Animator.Request(_animBtnCloseG, true);
            Animator.Request(_animBtnCloseB, true);
        }

        private void BtnClose_OnMouseLeave(object sender, EventArgs e)
        {
            _animBtnCloseR = new Animation("btnCloseR_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseR.Value, 26);
            _animBtnCloseG = new Animation("btnCloseG_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseG.Value, 28);
            _animBtnCloseB = new Animation("btnCloseB_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseB.Value, 41);

            _animBtnCloseR.StepDivider = 5;
            _animBtnCloseG.StepDivider = 5;
            _animBtnCloseB.StepDivider = 5;
            Animator.Request(_animBtnCloseR, true);
            Animator.Request(_animBtnCloseG, true);
            Animator.Request(_animBtnCloseB, true);
        }

        private void BtnClose_OnMouseUp(object sender, MouseEventArgs e)
		{
            _animBtnCloseA = new Animation("btnCloseA_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseA.Value, 255);

            _animBtnCloseA.StepDivider = 5;
            Animator.Request(_animBtnCloseA, true);
        }

        private void BtnClose_OnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region -[Развернуть окно/свернуть в окно]-
        private void BtnMaxMin_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(26, 28, 41));

            Rectangle rect = new Rectangle(5, 5, btnMaxMin.Width - 10, btnMaxMin.Height - 10);
            Rectangle rectFill = new Rectangle(6, 6, btnMaxMin.Width - 12, btnMaxMin.Height - 12);
            Pen p = new Pen(Color.White, 2);

            g.FillEllipse(new SolidBrush(Color.FromArgb((int)_animBtnMaxMinA.Value, (int)_animBtnMaxMinR.Value, (int)_animBtnMaxMinG.Value, (int)_animBtnMaxMinB.Value)), rectFill);
            g.DrawEllipse(p, rect);
        }

        private void BtnMaxMin_OnMouseDown(object sender, MouseEventArgs e)
        {
            _animBtnMaxMinA = new Animation("btnMaxMinA_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinA.Value, 200);

            _animBtnMaxMinA.StepDivider = 5;
            Animator.Request(_animBtnMaxMinA, true);
        }

        private void BtnMaxMin_OnMouseEnter(object sender, EventArgs e)
        {
            _animBtnMaxMinR = new Animation("btnMaxMinR_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinR.Value, FlatColor.Light.Yellow.R);
            _animBtnMaxMinG = new Animation("btnMaxMinG_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinG.Value, FlatColor.Light.Yellow.G);
            _animBtnMaxMinB = new Animation("btnMaxMinB_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinB.Value, FlatColor.Light.Yellow.B);

            _animBtnMaxMinR.StepDivider = 5;
            _animBtnMaxMinG.StepDivider = 5;
            _animBtnMaxMinB.StepDivider = 5;
            Animator.Request(_animBtnMaxMinR, true);
            Animator.Request(_animBtnMaxMinG, true);
            Animator.Request(_animBtnMaxMinB, true);
        }

        private void BtnMaxMin_OnMouseLeave(object sender, EventArgs e)
        {
            _animBtnMaxMinR = new Animation("btnMaxMinR_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinR.Value, 26);
            _animBtnMaxMinG = new Animation("btnMaxMinG_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinG.Value, 28);
            _animBtnMaxMinB = new Animation("btnMaxMinB_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinB.Value, 41);

            _animBtnMaxMinR.StepDivider = 5;
            _animBtnMaxMinG.StepDivider = 5;
            _animBtnMaxMinB.StepDivider = 5;
            Animator.Request(_animBtnMaxMinR, true);
            Animator.Request(_animBtnMaxMinG, true);
            Animator.Request(_animBtnMaxMinB, true);
        }

        private void BtnMaxMin_OnMouseUp(object sender, MouseEventArgs e)
		{
            _animBtnMaxMinA = new Animation("btnMaxMinA_" + btnMaxMin.Handle, btnMaxMin.Invalidate, _animBtnMaxMinA.Value, 255);

            _animBtnMaxMinA.StepDivider = 5;
            Animator.Request(_animBtnMaxMinA, true);
        }

        private void BtnMaxMin_OnClick(object sender, EventArgs e)
		{
            if (!_formMaximazed)
                Maximaze();
            else
                Minimaze();
		}
        #endregion

        #region -[Свернуть]-
        private void BtnMinimaze_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(26, 28, 41));

            Rectangle rect = new Rectangle(5, 5, btnMinimaze.Width - 10, btnMinimaze.Height - 10);
            Rectangle rectFill = new Rectangle(6, 6, btnMinimaze.Width - 12, btnMinimaze.Height - 12);
            Pen p = new Pen(Color.White, 2);

            g.FillEllipse(new SolidBrush(Color.FromArgb((int)_animBtnMinimazeA.Value, (int)_animBtnMinimazeR.Value, (int)_animBtnMinimazeG.Value, (int)_animBtnMinimazeB.Value)), rectFill);
            g.DrawEllipse(p, rect);
        }

        private void BtnMinimaze_OnMouseDown(object sender, MouseEventArgs e)
        {
            _animBtnMinimazeA = new Animation("btnMinimazeA_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeA.Value, 200);

            _animBtnMinimazeA.StepDivider = 5;
            Animator.Request(_animBtnMinimazeA, true);
        }

        private void BtnMinimaze_OnMouseEnter(object sender, EventArgs e)
        {
            _animBtnMinimazeR = new Animation("btnMinimazeR_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeR.Value, FlatColor.Green.R);
            _animBtnMinimazeG = new Animation("btnMinimazeG_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeG.Value, FlatColor.Green.G);
            _animBtnMinimazeB = new Animation("btnMinimazeB_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeB.Value, FlatColor.Green.B);

            _animBtnMinimazeR.StepDivider = 5;
            _animBtnMinimazeG.StepDivider = 5;
            _animBtnMinimazeB.StepDivider = 5;
            Animator.Request(_animBtnMinimazeR, true);
            Animator.Request(_animBtnMinimazeG, true);
            Animator.Request(_animBtnMinimazeB, true);
        }

        private void BtnMinimaze_OnMouseLeave(object sender, EventArgs e)
        {
            _animBtnMinimazeR = new Animation("btnMinimazeR_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeR.Value, 26);
            _animBtnMinimazeG = new Animation("btnMinimazeG_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeG.Value, 28);
            _animBtnMinimazeB = new Animation("btnMinimazeB_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeB.Value, 41);

            _animBtnMinimazeR.StepDivider = 5;
            _animBtnMinimazeG.StepDivider = 5;
            _animBtnMinimazeB.StepDivider = 5;
            Animator.Request(_animBtnMinimazeR, true);
            Animator.Request(_animBtnMinimazeG, true);
            Animator.Request(_animBtnMinimazeB, true);
        }

        private void BtnMinimaze_OnMouseUp(object sender, MouseEventArgs e)
		{
            _animBtnMinimazeA = new Animation("btnMinimazeA_" + btnMinimaze.Handle, btnMinimaze.Invalidate, _animBtnMinimazeA.Value, 255);

            _animBtnMinimazeA.StepDivider = 5;
            Animator.Request(_animBtnMinimazeA, true);
        }

        private void BtnMinimaze_OnClick(object sender, EventArgs e)
		{
            WindowState = FormWindowState.Minimized;
		}
		#endregion

		#region -[Главная]-
        private void BtnMenuMain_OnPaint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Main)
			{
                rectWave = new Rectangle(
                   _clLocationMain.X - (int)_animWavePressMain.Value / 2,
                   _clLocationMain.Y - (int)_animWavePressMain.Value / 2,
                   (int)_animWavePressMain.Value,
                   (int)_animWavePressMain.Value
               );
			}
            else
			{
                rectWave = new Rectangle(
                    btnMenuMain.Width / 2 - (int)_animWavePressMain.Value / 2,
                    btnMenuMain.Height / 2 - (int)_animWavePressMain.Value / 2,
                    (int)_animWavePressMain.Value,
                    (int)_animWavePressMain.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuMain.Width, btnMenuMain.Height);

            if (_typeForm == TypeForm.Main)
			{
                if (_animWavePressMain.Value > 0 && _animWavePressMain.Value < _animWavePressMain.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressMain.Value == _animWavePressMain.TargetValue)
                {
                    _animWavePressMain.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
			{
                if (_animWavePressMain.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressMain.Value == _animWavePressMain.TargetValue)
                    _animWavePressMain.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            Rectangle rectImg = new Rectangle(8, 6, 24, 24);
            Rectangle rectText = new Rectangle(36, 0, btnMenuMain.Width - 36, btnMenuMain.Height);

            g.DrawImage(btnMenuMain.Image, rectImg);
            g.DrawString(btnMenuMain.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rectText, _sfMenu);
        }

        private void BtnMenuMain_OnMouseDown(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm != TypeForm.Main)
            {
                _typeForm = TypeForm.Main;
                _clLocationMain = e.Location;

                _animWavePressMain = new Animation("btnMenuMainPress_" + btnMenuMain.Handle, Wave, 0, btnMenuMain.Width * 2);
                Animator.Request(_animWavePressMain, true);

                void Wave()
				{
                    btnMenuMain.Invalidate();
                    pnlBorderLeft2.Invalidate();
                }
            }
        }

        private void BtnMenuMain_OnMouseUp(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm == TypeForm.Main)
                OffButtonAnimate(_typeForm);
        }

        private void BtnMenuMain_OnClick(object sender, EventArgs e)
		{
            if (_typeForm == TypeForm.Main)
                OpenChildForm(new FormMenuMain(this));
		}
        #endregion

        #region -[Для работы]-
        private void BtnMenuWork_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Work)
            {
                rectWave = new Rectangle(
                   _clLocationWork.X - (int)_animWavePressWork.Value / 2,
                   _clLocationWork.Y - (int)_animWavePressWork.Value / 2,
                   (int)_animWavePressWork.Value,
                   (int)_animWavePressWork.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuWork.Width / 2 - (int)_animWavePressWork.Value / 2,
                    btnMenuWork.Height / 2 - (int)_animWavePressWork.Value / 2,
                    (int)_animWavePressWork.Value,
                    (int)_animWavePressWork.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuWork.Width, btnMenuWork.Height);

            if (_typeForm == TypeForm.Work)
            {
                if (_animWavePressWork.Value > 0 && _animWavePressWork.Value < _animWavePressWork.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressWork.Value == _animWavePressWork.TargetValue)
                {
                    _animWavePressWork.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressWork.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressWork.Value == _animWavePressWork.TargetValue)
                    _animWavePressWork.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            Rectangle rectImg = new Rectangle(8, 6, 24, 24);
            Rectangle rectText = new Rectangle(36, 0, btnMenuWork.Width - 36, btnMenuWork.Height);

            g.DrawImage(btnMenuWork.Image, rectImg);
            g.DrawString(btnMenuWork.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rectText, _sfMenu);
        }

        private void BtnMenuWork_OnMouseDown(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm != TypeForm.Work)
            {
                _typeForm = TypeForm.Work;
                _clLocationWork = e.Location;

                _animWavePressWork = new Animation("btnMenuWorkPress_" + btnMenuWork.Handle, Wave, 0, btnMenuWork.Width * 2);
                Animator.Request(_animWavePressWork, true);

                void Wave()
                {
                    btnMenuWork.Invalidate();
                    pnlBorderLeft3.Invalidate();
                }
            }
        }

        private void BtnMenuWork_OnMouseUp(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm == TypeForm.Work)
                OffButtonAnimate(_typeForm);
        }

        private void BtnMenuWork_OnClick(object sender, EventArgs e)
        {
            if (_typeForm == TypeForm.Work)
                OpenChildForm(new FormMenuWork(this));
        }
        #endregion

        #region -[Для игр]-
        private void BtnMenuGame_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Game)
            {
                rectWave = new Rectangle(
                   _clLocationGame.X - (int)_animWavePressGame.Value / 2,
                   _clLocationGame.Y - (int)_animWavePressGame.Value / 2,
                   (int)_animWavePressGame.Value,
                   (int)_animWavePressGame.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuGame.Width / 2 - (int)_animWavePressGame.Value / 2,
                    btnMenuGame.Height / 2 - (int)_animWavePressGame.Value / 2,
                    (int)_animWavePressGame.Value,
                    (int)_animWavePressGame.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuGame.Width, btnMenuGame.Height);

            if (_typeForm == TypeForm.Game)
            {
                if (_animWavePressGame.Value > 0 && _animWavePressGame.Value < _animWavePressGame.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressGame.Value == _animWavePressGame.TargetValue)
                {
                    _animWavePressGame.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressGame.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressGame.Value == _animWavePressGame.TargetValue)
                    _animWavePressGame.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            Rectangle rectImg = new Rectangle(8, 6, 24, 24);
            Rectangle rectText = new Rectangle(36, 0, btnMenuGame.Width - 36, btnMenuGame.Height);

            g.DrawImage(btnMenuGame.Image, rectImg);
            g.DrawString(btnMenuGame.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rectText, _sfMenu);
        }

        private void BtnMenuGame_OnMouseDown(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm != TypeForm.Game)
            {
                _typeForm = TypeForm.Game;
                _clLocationGame = e.Location;

                _animWavePressGame = new Animation("btnMenuGamePress_" + btnMenuGame.Handle, Wave, 0, btnMenuGame.Width * 2);
                Animator.Request(_animWavePressGame, true);

                void Wave()
                {
                    btnMenuGame.Invalidate();
                    pnlBorderLeft4.Invalidate();
                }
            }
        }

        private void BtnMenuGame_OnMouseUp(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm == TypeForm.Game)
                OffButtonAnimate(_typeForm);
        }

        private void BtnMenuGame_OnClick(object senderm, EventArgs e)
        {
            if (_typeForm == TypeForm.Game)
                OpenChildForm(new FormMenuGame(this));
        }
        #endregion

        #region -[Для сервера]-
        private void BtnMenuServer_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Server)
            {
                rectWave = new Rectangle(
                   _clLocationServer.X - (int)_animWavePressServer.Value / 2,
                   _clLocationServer.Y - (int)_animWavePressServer.Value / 2,
                   (int)_animWavePressServer.Value,
                   (int)_animWavePressServer.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuServer.Width / 2 - (int)_animWavePressServer.Value / 2,
                    btnMenuServer.Height / 2 - (int)_animWavePressServer.Value / 2,
                    (int)_animWavePressServer.Value,
                    (int)_animWavePressServer.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuServer.Width, btnMenuServer.Height);

            if (_typeForm == TypeForm.Server)
            {
                if (_animWavePressServer.Value > 0 && _animWavePressServer.Value < _animWavePressServer.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressServer.Value == _animWavePressServer.TargetValue)
                {
                    _animWavePressServer.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressServer.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressServer.Value == _animWavePressServer.TargetValue)
                    _animWavePressServer.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            Rectangle rectImg = new Rectangle(8, 6, 24, 24);
            Rectangle rectText = new Rectangle(36, 0, btnMenuServer.Width - 36, btnMenuServer.Height);

            g.DrawImage(btnMenuServer.Image, rectImg);
            g.DrawString(btnMenuServer.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rectText, _sfMenu);
        }

        private void BtnMenuServer_OnMouseDown(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm != TypeForm.Server)
            {
                _typeForm = TypeForm.Server;
                _clLocationServer = e.Location;

                _animWavePressServer = new Animation("btnMenuServerPress_" + btnMenuServer.Handle, Wave, 0, btnMenuServer.Width * 2);
                Animator.Request(_animWavePressServer, true);

                void Wave()
                {
                    btnMenuServer.Invalidate();
                    pnlBorderLeft5.Invalidate();
                }
            }
        }

        private void BtnMenuServer_OnMouseUp(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm == TypeForm.Server)
                OffButtonAnimate(_typeForm);
        }

        private void BtnMenuServer_OnClick(object sender, EventArgs e)
        {
            if (_typeForm == TypeForm.Server)
                OpenChildForm(new FormMenuServer(this));
        }
        #endregion

        #region -[Настройки]-
        private void BtnMenuSettings_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Settings)
            {
                rectWave = new Rectangle(
                   _clLocationSettings.X - (int)_animWavePressSettings.Value / 2,
                   _clLocationSettings.Y - (int)_animWavePressSettings.Value / 2,
                   (int)_animWavePressSettings.Value,
                   (int)_animWavePressSettings.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuSettings.Width / 2 - (int)_animWavePressSettings.Value / 2,
                    btnMenuSettings.Height / 2 - (int)_animWavePressSettings.Value / 2,
                    (int)_animWavePressSettings.Value,
                    (int)_animWavePressSettings.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuSettings.Width, btnMenuSettings.Height);

            if (_typeForm == TypeForm.Settings)
            {
                if (_animWavePressSettings.Value > 0 && _animWavePressSettings.Value < _animWavePressSettings.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressSettings.Value == _animWavePressSettings.TargetValue)
                {
                    _animWavePressSettings.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressSettings.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressSettings.Value == _animWavePressSettings.TargetValue)
                    _animWavePressSettings.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            Rectangle rectImg = new Rectangle(8, 6, 24, 24);
            Rectangle rectText = new Rectangle(36, 0, btnMenuSettings.Width - 36, btnMenuSettings.Height);

            g.DrawImage(btnMenuSettings.Image, rectImg);
            g.DrawString(btnMenuSettings.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rectText, _sfMenu);
        }

        private void BtnMenuSettings_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _typeForm != TypeForm.Settings)
            {
                _typeForm = TypeForm.Settings;
                _clLocationSettings = e.Location;

                _animWavePressSettings = new Animation("btnMenuSettingsPress_" + btnMenuSettings.Handle, Wave, 0, btnMenuSettings.Width * 2);
                Animator.Request(_animWavePressSettings, true);

                void Wave()
                {
                    btnMenuSettings.Invalidate();
                    pnlBorderLeft6.Invalidate();
                }
            }
        }

        private void BtnMenuSettings_OnMouseUp(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left && _typeForm == TypeForm.Settings)
                OffButtonAnimate(_typeForm);
        }

        private void BtnMenuSettings_OnClick(object sender, EventArgs e)
        {
            if (_typeForm == TypeForm.Settings)
                OpenChildForm(new FormMenuSettings());
        }
        #endregion
        #endregion

        #region -> Тексты
        #region -[Заголовок]-
        private void LblTitle_OnDown(object sender, MouseEventArgs e)
        {
            if (_formMaximazed)
			{
                Minimaze();

                if (Cursor.Position.X < Location.X)
                    Location = new Point(Cursor.Position.X - 15, Location.Y);
                if (Cursor.Position.X > Location.X + 5 + lblTitle.Width)
                    Location = new Point(Cursor.Position.X - 5 - lblTitle.Width + 10, Location.Y);
                if (Cursor.Position.Y < Location.Y)
                    Location = new Point(Location.X, Cursor.Position.Y - 15);
                if (Cursor.Position.Y > Location.Y + 30)
                    Location = new Point(Location.X, Cursor.Position.Y - 15);
            }

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }
        #endregion
        #endregion

        #region -> Панели
        #region -[Границы]-
        #region {Верхний левый}
        private void PnlBorderTopLeft_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width + (_locCursor.X - Cursor.Position.X);
                    int h = _sizeForm.Height + (_locCursor.Y - Cursor.Position.Y);
                    int minX = _sizeForm.Width - MinimumSize.Width + _locCursor.X;
                    int minY = _sizeForm.Height - MinimumSize.Height + _locCursor.Y;

                    if (w <= MinimumSize.Width && h <= MinimumSize.Height)
                        MoveWindow(Handle, minX, minY, MinimumSize.Width, MinimumSize.Height, true);
                    else if (w <= MinimumSize.Width)
                        MoveWindow(Handle, minX, Cursor.Position.Y, MinimumSize.Width, h, true);
                    else if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Cursor.Position.X, minY, w, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Cursor.Position.X, Cursor.Position.Y, w, h, true);

                    MakeChangesOfForm();
                }
			}
        }

        private void PnlBorderTopLeft_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderTopLeft_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Верхний}
        private void PnlBorderTop_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int h = _sizeForm.Height + (_locCursor.Y - Cursor.Position.Y);

                    if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, _locCursor.Y, _sizeForm.Width, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Left, Cursor.Position.Y, _sizeForm.Width, h, true);

                    MakeChangesOfForm();
                }
			}
        }

        private void PnlBorderTop_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderTop_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Верхний правый}
        private void PnlBorderTopRight_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width - (_locCursor.X - Cursor.Position.X);
                    int h = _sizeForm.Height + (_locCursor.Y - Cursor.Position.Y);

                    if (w <= MinimumSize.Width && h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, _locCursor.Y, MinimumSize.Width, MinimumSize.Height, true);
                    else if (w <= MinimumSize.Width)
                        MoveWindow(Handle, Left, Cursor.Position.Y, MinimumSize.Width, h, true);
                    else if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, _locCursor.Y, w, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Left, Cursor.Position.Y, w, h, true);

                    MakeChangesOfForm();
                }
			}
        }

        private void PnlBorderTopRight_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderTopRight_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Правый}
        private void PnlBorderRight_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width - (_locCursor.X - Cursor.Position.X);

                    if (w <= MinimumSize.Width)
                        MoveWindow(Handle, Left, Top, MinimumSize.Width, _sizeForm.Height, true);
                    else
                        MoveWindow(Handle, Left, Top, w, _sizeForm.Height, true);

                    MakeChangesOfForm();
                }
			}
        }

        private void PnlBorderRight_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderRight_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Нижний правый}
        private void PnlBorderBottomRight_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width - (_locCursor.X - Cursor.Position.X);
                    int h = _sizeForm.Height - (_locCursor.Y - Cursor.Position.Y);

                    if (w <= MinimumSize.Width && h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, Top, MinimumSize.Width, MinimumSize.Height, true);
                    else if (w <= MinimumSize.Width)
                        MoveWindow(Handle, Left, Top, MinimumSize.Width, h, true);
                    else if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, Top, w, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Left, Top, w, h, true);

                    MakeChangesOfForm();
                }
            }
        }

        private void PnlBorderBottomRight_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderBottomRight_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Нижний}
        private void PnlBorderBottom_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
            {
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int h = _sizeForm.Height - (_locCursor.Y - Cursor.Position.Y);

                    if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Left, Top, _sizeForm.Width, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Left, Top, _sizeForm.Width, h, true);

                    MakeChangesOfForm();
                }
            }
        }

        private void PnlBorderBottom_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        } 

        private void PnlBorderBottom_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Нижний левый}
        private void PnlBorderBottomLeft_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width + (_locCursor.X - Cursor.Position.X);
                    int h = _sizeForm.Height - (_locCursor.Y - Cursor.Position.Y);

                    if (w <= MinimumSize.Height && h <= MinimumSize.Height)
                        MoveWindow(Handle, _locCursor.X, Top, MinimumSize.Width, MinimumSize.Height, true);
                    else if (w <= MinimumSize.Width)
                        MoveWindow(Handle, _locCursor.X, Top, MinimumSize.Width, h, true);
                    else if (h <= MinimumSize.Height)
                        MoveWindow(Handle, Cursor.Position.X, Top, w, MinimumSize.Height, true);
                    else
                        MoveWindow(Handle, Cursor.Position.X, Top, w, h, true);

                    MakeChangesOfForm();
                }
			}
        }

        private void PnlBorderBottomLeft_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBorderBottomLeft_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }
        #endregion
        #region {Левый}
        private void PnlBorderLeft_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_formMaximazed)
			{
                if (!_mousePressed)
                {
                    _locCursor = Cursor.Position;
                    _sizeForm = Size;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int w = _sizeForm.Width + (_locCursor.X - Cursor.Position.X);

                    if (w <= MinimumSize.Width)
                        MoveWindow(Handle, _locCursor.X, Top, MinimumSize.Width, _sizeForm.Height, true);
                    else
                        MoveWindow(Handle, Cursor.Position.X, Top, w, _sizeForm.Height, true);

                    MakeChangesOfForm();
                }
            }
        }

        private void PnlBorderLeft_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = true;
        }

        private void PnlBoderLeft_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressed = false;
        }

        private void PnlBorderLeft1_OnPaint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave = new Rectangle();

            if (_typeForm == TypeForm.Main)
            {
                rectWave = new Rectangle(
                   _clLocationMain.X - (int)_animWavePressMain.Value / 2,
                   _clLocationMain.Y - (int)_animWavePressMain.Value / 2,
                   (int)_animWavePressMain.Value,
                   (int)_animWavePressMain.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuMain.Width / 2 - (int)_animWavePressMain.Value / 2,
                    btnMenuMain.Height / 2 - (int)_animWavePressMain.Value / 2,
                    (int)_animWavePressMain.Value,
                    (int)_animWavePressMain.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuMain.Width, btnMenuMain.Height);

            if (_typeForm == TypeForm.Main)
            {
                if (_animWavePressMain.Value > 0 && _animWavePressMain.Value < _animWavePressMain.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressMain.Value == _animWavePressMain.TargetValue)
                {
                    _animWavePressMain.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressMain.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressMain.Value == _animWavePressMain.TargetValue)
                    _animWavePressMain.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }
        }

        private void PnlBorderLeft2_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Work)
            {
                rectWave = new Rectangle(
                   _clLocationWork.X - (int)_animWavePressWork.Value / 2,
                   _clLocationWork.Y - (int)_animWavePressWork.Value / 2,
                   (int)_animWavePressWork.Value,
                   (int)_animWavePressWork.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuWork.Width / 2 - (int)_animWavePressWork.Value / 2,
                    btnMenuWork.Height / 2 - (int)_animWavePressWork.Value / 2,
                    (int)_animWavePressWork.Value,
                    (int)_animWavePressWork.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuWork.Width, btnMenuWork.Height);

            if (_typeForm == TypeForm.Work)
            {
                if (_animWavePressWork.Value > 0 && _animWavePressWork.Value < _animWavePressWork.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressWork.Value == _animWavePressWork.TargetValue)
                {
                    _animWavePressWork.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressWork.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressWork.Value == _animWavePressWork.TargetValue)
                    _animWavePressWork.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }
        }

        private void PnlBorderLeft3_OnPaint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Game)
            {
                rectWave = new Rectangle(
                   _clLocationGame.X - (int)_animWavePressGame.Value / 2,
                   _clLocationGame.Y - (int)_animWavePressGame.Value / 2,
                   (int)_animWavePressGame.Value,
                   (int)_animWavePressGame.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuGame.Width / 2 - (int)_animWavePressGame.Value / 2,
                    btnMenuGame.Height / 2 - (int)_animWavePressGame.Value / 2,
                    (int)_animWavePressGame.Value,
                    (int)_animWavePressGame.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuGame.Width, btnMenuGame.Height);

            if (_typeForm == TypeForm.Game)
            {
                if (_animWavePressGame.Value > 0 && _animWavePressGame.Value < _animWavePressGame.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressGame.Value == _animWavePressGame.TargetValue)
                {
                    _animWavePressGame.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressGame.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressGame.Value == _animWavePressGame.TargetValue)
                    _animWavePressGame.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }
        }

        private void PnlBorderLeft4_OnPaint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Server)
            {
                rectWave = new Rectangle(
                   _clLocationServer.X - (int)_animWavePressServer.Value / 2,
                   _clLocationServer.Y - (int)_animWavePressServer.Value / 2,
                   (int)_animWavePressServer.Value,
                   (int)_animWavePressServer.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuServer.Width / 2 - (int)_animWavePressServer.Value / 2,
                    btnMenuServer.Height / 2 - (int)_animWavePressServer.Value / 2,
                    (int)_animWavePressServer.Value,
                    (int)_animWavePressServer.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuServer.Width, btnMenuServer.Height);

            if (_typeForm == TypeForm.Server)
            {
                if (_animWavePressServer.Value > 0 && _animWavePressServer.Value < _animWavePressServer.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressServer.Value == _animWavePressServer.TargetValue)
                {
                    _animWavePressServer.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressServer.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressServer.Value == _animWavePressServer.TargetValue)
                    _animWavePressServer.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }
        }

        private void PnlBorderLeft5_OnPaint(object sender, PaintEventArgs e)
		{
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;

            if (_typeForm == TypeForm.Settings)
            {
                rectWave = new Rectangle(
                   _clLocationSettings.X - (int)_animWavePressSettings.Value / 2,
                   _clLocationSettings.Y - (int)_animWavePressSettings.Value / 2,
                   (int)_animWavePressSettings.Value,
                   (int)_animWavePressSettings.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnMenuSettings.Width / 2 - (int)_animWavePressSettings.Value / 2,
                    btnMenuSettings.Height / 2 - (int)_animWavePressSettings.Value / 2,
                    (int)_animWavePressSettings.Value,
                    (int)_animWavePressSettings.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnMenuSettings.Width, btnMenuSettings.Height);

            if (_typeForm == TypeForm.Settings)
            {
                if (_animWavePressSettings.Value > 0 && _animWavePressSettings.Value < _animWavePressSettings.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressSettings.Value == _animWavePressSettings.TargetValue)
                {
                    _animWavePressSettings.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressSettings.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressSettings.Value == _animWavePressSettings.TargetValue)
                    _animWavePressSettings.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }
        }
        #endregion
        #endregion
        #endregion
        #endregion

        #region [Методы]
        private void MakeChangesOfForm()
		{
            foreach (Control ctrl in Controls)
                ctrl.Refresh();
        }

        private void Maximaze()
		{
            _sizeForm = Size;
            _locPrevForm = Location;

            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int taskbarW = Screen.PrimaryScreen.Bounds.Width - w;
            int taskbarH = Screen.PrimaryScreen.Bounds.Height - h;

            if (LocationOfTaskBar == TaskBarLocation.Bottom || LocationOfTaskBar == TaskBarLocation.Right)
                MoveWindow(Handle, 0, 0, w, h, true);
            else if (LocationOfTaskBar == TaskBarLocation.Top)
                MoveWindow(Handle, 0, taskbarH, w, h, true);
            else if (LocationOfTaskBar == TaskBarLocation.Left)
                MoveWindow(Handle, taskbarW, 0, w, h, true);

            pnlBorderTopLeft.Cursor = Cursors.Default;
            pnlBorderTop.Cursor = Cursors.Default;
            pnlBorderTopRight.Cursor = Cursors.Default;
            pnlBorderRight1.Cursor = Cursors.Default;
            pnlBorderRight2.Cursor = Cursors.Default;
            pnlBorderBottomRight.Cursor = Cursors.Default;
            pnlBorderBottom.Cursor = Cursors.Default;
            pnlBorderBottom1.Cursor = Cursors.Default;
            pnlBorderBottomLeft.Cursor = Cursors.Default;
            pnlBorderLeft1.Cursor = Cursors.Default;
            pnlBorderLeft2.Cursor = Cursors.Default;

            _formMaximazed = true;
		}

        private void Minimaze()
        {
            MoveWindow(Handle, _locPrevForm.X, _locPrevForm.Y, _sizeForm.Width, _sizeForm.Height, true);

            pnlBorderTopLeft.Cursor = Cursors.SizeNWSE;
            pnlBorderTop.Cursor = Cursors.SizeNS;
            pnlBorderTopRight.Cursor = Cursors.SizeNESW;
            pnlBorderRight1.Cursor = Cursors.SizeWE;
            pnlBorderRight2.Cursor = Cursors.SizeWE;
            pnlBorderBottomRight.Cursor = Cursors.SizeNWSE;
            pnlBorderBottom.Cursor = Cursors.SizeNS;
            pnlBorderBottom1.Cursor = Cursors.SizeNS;
            pnlBorderBottomLeft.Cursor = Cursors.SizeNESW;
            pnlBorderLeft1.Cursor = Cursors.SizeWE;
            pnlBorderLeft2.Cursor = Cursors.SizeWE;

            _formMaximazed = false;
		}

        private void OffButtonAnimate(TypeForm typeForm)
		{
            if (_animWavePressMain.Value != 0 && typeForm != TypeForm.Main)
            {
                _animWavePressMain = new Animation("btnMenuMainUp_" + btnMenuMain.Handle, Wave, btnMenuMain.Width * 2, 0);
                Animator.Request(_animWavePressMain, true);
                btnMenuMain.Invalidate();

                void Wave()
				{
                    btnMenuMain.Invalidate();
                    pnlBorderLeft2.Invalidate();
                }
            }
            else if (_animWavePressWork.Value != 0 && typeForm != TypeForm.Work)
			{
                _animWavePressWork = new Animation("btnMenuWorkUp_" + btnMenuWork.Handle, Wave, btnMenuWork.Width * 2, 0);
                Animator.Request(_animWavePressWork, true);
                btnMenuWork.Invalidate();

                void Wave()
                {
                    btnMenuWork.Invalidate();
                    pnlBorderLeft3.Invalidate();
                }
            }
            else if (_animWavePressGame.Value != 0 && typeForm != TypeForm.Game)
			{
                _animWavePressGame = new Animation("btnMenuGameUp_" + btnMenuGame.Handle, Wave, btnMenuGame.Width * 2, 0);
                Animator.Request(_animWavePressGame, true);
                btnMenuGame.Invalidate();

                void Wave()
                {
                    btnMenuGame.Invalidate();
                    pnlBorderLeft4.Invalidate();
                }
            }
            else if (_animWavePressServer.Value != 0 && typeForm != TypeForm.Server)
			{
                _animWavePressServer = new Animation("btnMenuServerUp_" + btnMenuServer.Handle, Wave, btnMenuServer.Width * 2, 0);
                Animator.Request(_animWavePressServer, true);
                btnMenuServer.Invalidate();

                void Wave()
                {
                    btnMenuServer.Invalidate();
                    pnlBorderLeft5.Invalidate();
                }
            }
            else if (_animWavePressSettings.Value != 0 && typeForm != TypeForm.Settings)
			{
                _animWavePressSettings = new Animation("btnMenuSettingsUp_" + btnMenuSettings.Handle, Wave, btnMenuSettings.Width * 2, 0);
                Animator.Request(_animWavePressSettings, true);
                btnMenuSettings.Invalidate();

                void Wave()
                {
                    btnMenuSettings.Invalidate();
                    pnlBorderLeft6.Invalidate();
                }
            }
        }

        private void OpenChildForm(Form childForm)
		{
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
		#endregion
	}
}
