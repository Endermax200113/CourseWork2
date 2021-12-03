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
        #endregion

        public FormMain()
        {
            InitializeComponent();

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
        #endregion
        #endregion

        #region -> Тексты
        #region -[Заголовок]-
        private void LblTitle_OnDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }
        #endregion

        #endregion

        #endregion
    }
}
