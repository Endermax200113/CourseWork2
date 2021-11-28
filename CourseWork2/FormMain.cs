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
    public partial class FormMain : Form
    {
        #region [Переменные]
        #region -> Кнопки
        #region -[Закрыть окно]-
        private Animation _animBtnCloseA = new Animation();
        private Animation _animBtnCloseR = new Animation();
        private Animation _animBtnCloseG = new Animation();
        private Animation _animBtnCloseB = new Animation();
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
            Close();
        }
        #endregion
        #endregion
        #endregion
    }
}
