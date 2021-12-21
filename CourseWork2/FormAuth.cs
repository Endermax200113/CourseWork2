using CourseWork2.Properties;
using CourseWork2.UI;
using CourseWork2.UI.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI.Animations;

namespace CourseWork2
{
    public partial class FormAuth : ShadowForm
    {
        #region [Переменные]
        #region -> Общие
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        private bool _isFormLogin = true;
        private StringFormat _sf = new StringFormat();
        private Form _activeForm;
        #endregion

        #region -> Кнопки
        #region -[Регистрация]-
        private Point _clLocationReg = new Point();
        private Animation _animWavePressReg = new Animation();
        #endregion

        #region -[Логин]-
        private Point _clLocationLogin = new Point();
        private Animation _animWavePressLogin = new Animation();
        #endregion

        #region -[Закрыть окно]-
        private Animation _animBtnCloseA = new Animation();
        private Animation _animBtnCloseR = new Animation();
        private Animation _animBtnCloseG = new Animation();
        private Animation _animBtnCloseB = new Animation();
        #endregion
        #endregion
        
        #region -> Панели
        #region -[Полоса авторизации]-
        private Animation _animStrip = new Animation();
        #endregion
        #endregion
        #endregion

        #region [Свойства]
        #region -> Окно
        public static Form SelfForm { get; set; }
        #endregion
        #endregion

        public FormAuth()
        {
            InitializeComponent();

            _animBtnCloseA.Value = 255;
            _animBtnCloseR.Value = 26;
            _animBtnCloseG.Value = 28;
            _animBtnCloseB.Value = 41;
            _animWavePressLogin.Value = btnLogin.Width * 2;
            _animWavePressReg.Value = 0;
            _animStrip.Value = 0;
            _sf.Alignment = StringAlignment.Center;
            _sf.LineAlignment = StringAlignment.Center;
            SelfForm = this;
        }

        #region [Слушатели]
        #region -> Окно
        private void FormAuth_OnLoad(object sender, EventArgs e)
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
            btnLogin.Font = new Font(_pfc.Families[0], 12);
            btnReg.Font = new Font(_pfc.Families[0], 12);
        }

        private void FormAuth_OnShown(object sender, EventArgs e)
        {
            OpenChildForm(new FormLogin());
        }
        #endregion

        #region -> Кнопки
        #region -[Логин]-
        private void BtnLogin_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;
            
            if (_isFormLogin)
            {
                rectWave = new Rectangle(
                   _clLocationLogin.X - (int)_animWavePressLogin.Value / 2,
                   _clLocationLogin.Y - (int)_animWavePressLogin.Value / 2,
                   (int)_animWavePressLogin.Value,
                   (int)_animWavePressLogin.Value
               );
            }
            else
            {
                rectWave = new Rectangle(
                    btnLogin.Width / 2 - (int)_animWavePressLogin.Value / 2,
                    btnLogin.Height / 2 -(int)_animWavePressLogin.Value / 2,
                    (int)_animWavePressLogin.Value,
                    (int)_animWavePressLogin.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnLogin.Width, btnLogin.Height);

            if (_isFormLogin)
            {
                if (_animWavePressLogin.Value > 0 && _animWavePressLogin.Value < _animWavePressLogin.TargetValue)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressLogin.Value == _animWavePressLogin.TargetValue)
                {
                    _animWavePressLogin.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }
            else
            {
                if (_animWavePressLogin.Value > 0)
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                else if (_animWavePressLogin.Value == _animWavePressLogin.TargetValue)
                    _animWavePressLogin.Value = 0;
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
            }

            g.DrawString(btnLogin.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
        }

        private void BtnLogin_OnClick(object sender, EventArgs e)
        {
            if (_isFormLogin && _animStrip.Value != 0)
            {
                _animStrip = new Animation("stripMove_" + pnlStrip.Handle, Move, 177, 0);
                Animator.Request(_animStrip, true);

                void Move()
                {
                    Action act = () => {
                        pnlStrip.Left = (int)_animStrip.Value;
                    };

                    if (pnlStrip.InvokeRequired)
                    {
                        pnlStrip.Invoke(act);
                    }
                    else
                    {
                        act();
                    }
                }

                OpenChildForm(new FormLogin());
            }
        }

        private void BtnLogin_OnDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isFormLogin)
            {
                _isFormLogin = true;
                _clLocationLogin = e.Location;

                _animWavePressLogin = new Animation("btnLoginPress_" + btnLogin.Handle, btnLogin.Invalidate, 0, btnLogin.Width * 2);
                Animator.Request(_animWavePressLogin, true);
            }
        }

        private void BtnLogin_OnUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _isFormLogin)
            {
                if (_animWavePressReg.Value != 0)
                {
                    _animWavePressReg = new Animation("btnRegUp_" + btnReg.Handle, btnReg.Invalidate, btnReg.Width * 2, 0);
                    Animator.Request(_animWavePressReg, true);
                    btnLogin.Invalidate();
                }
            }
        }
        #endregion

        #region -[Регистрация]-
        private void BtnReg_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(255, 32, 34, 50));

            Rectangle rectWave;
            
            if (!_isFormLogin)
            {
                rectWave = new Rectangle(
                    _clLocationReg.X - (int)_animWavePressReg.Value / 2,
                    _clLocationReg.Y - (int)_animWavePressReg.Value / 2,
                    (int)_animWavePressReg.Value,
                    (int)_animWavePressReg.Value
                );
            }
            else
            {
                rectWave = new Rectangle(
                    btnReg.Width / 2 - (int)_animWavePressReg.Value / 2,
                    btnReg.Height / 2 - (int)_animWavePressReg.Value / 2,
                    (int)_animWavePressReg.Value,
                    (int)_animWavePressReg.Value
                );
            }
            Rectangle rect = new Rectangle(0, 0, btnReg.Width, btnReg.Height);

            if (!_isFormLogin)
            {
                if (_animWavePressReg.Value > 0 && _animWavePressReg.Value < _animWavePressReg.TargetValue)
                {
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                }
                else if (_animWavePressReg.Value == _animWavePressReg.TargetValue)
                {
                    _animWavePressReg.Value = -1;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
                }
            }
            else
            {
                if (_animWavePressReg.Value > 0)
                {
                    g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
                }
                else if (_animWavePressReg.Value == _animWavePressReg.TargetValue)
                {
                    _animWavePressReg.Value = 0;
                } 
                else
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.Black)), rect);
                }
            }

            g.DrawString(btnReg.Text, new Font(_pfc.Families[0], 12), new SolidBrush(Color.White), rect, _sf);
        }

        private void BtnReg_OnClick(object sender, EventArgs e)
        {
            if (!_isFormLogin && _animStrip.Value != 177)
            {
                _animStrip = new Animation("stripMove_" + pnlStrip.Handle, Move, 0, 177);
                Animator.Request(_animStrip, true);

                void Move()
                {
                    Action act = () => {
                        pnlStrip.Left = (int)_animStrip.Value;
                    };

                    if (pnlStrip.InvokeRequired)
                    {
                        pnlStrip.Invoke(act);
                    }
                    else
                    {
                        act();
                    }
                }

                OpenChildForm(new FormReg());
            }
        }

        private void BtnReg_OnDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _isFormLogin)
            {
                _isFormLogin = false;
                _clLocationReg = e.Location;

                _animWavePressReg = new Animation("btnRegPress_" + btnReg.Handle, btnReg.Invalidate, 0, btnReg.Width * 2);
                Animator.Request(_animWavePressReg, true);
            }
        }

        private void BtnReg_OnUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isFormLogin)
            {
                if (_animWavePressLogin.Value != 0)
                {
                    _animWavePressLogin = new Animation("btnLoginUp_" + btnLogin.Handle, btnLogin.Invalidate, btnLogin.Width * 2, 0);
                    Animator.Request(_animWavePressLogin, true);
                    btnReg.Invalidate();
                }
            }
        }
        #endregion

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

        private void BtnClose_OnDown(object sender, MouseEventArgs e)
        {
            _animBtnCloseA = new Animation("btnCloseA_" + btnClose.Handle, btnClose.Invalidate, _animBtnCloseA.Value, 200);

            _animBtnCloseA.StepDivider = 5;
            Animator.Request(_animBtnCloseA, true);
        }

        private void BtnClose_OnEnter(object sender, EventArgs e)
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

        private void BtnClose_OnLeave(object sender, EventArgs e)
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

        #region [Методы]
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
