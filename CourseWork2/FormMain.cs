using CourseWork2.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
        #endregion

        #region -> Окно
        private Point _locCursor = new Point();
        private Size _sizeForm = new Size();
        private Point _locPrevForm = new Point();
        private bool _formMaximazed = false;
        #endregion
        #endregion

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
        }

        #region [Слушатели]
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
            pnlBorderBottomLeft.Cursor = Cursors.SizeNESW;
            pnlBorderLeft1.Cursor = Cursors.SizeWE;
            pnlBorderLeft2.Cursor = Cursors.SizeWE;

            _formMaximazed = false;
		}

        private void Somehere()
		{

		}
		#endregion
	}
}
