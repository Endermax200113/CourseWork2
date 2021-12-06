using CourseWork2.Database;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using UI.Animations;

namespace CourseWork2.UI.Forms
{
    public partial class FormLogin : Form
    {
        #region [Переменные]
        #region -> Общие
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        private StringFormat _sf = new StringFormat();
        #endregion

        #region -> Кнопки
        #region -[Войти]-
        private Point _clLocationLogin = new Point();
        private Animation _animWavePressLogin = new Animation();
        private bool _mousePressedLogin = false;
        #endregion
        #endregion
        #endregion

        public FormLogin()
        {
            InitializeComponent();

            _sf.Alignment = StringAlignment.Center;
            _sf.LineAlignment = StringAlignment.Center;
        }

        #region [Слушатели]
        #region -> Окно
        private void FormLogin_OnLoad(object sender, EventArgs e)
        {
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.Montserrat_Regular))
            {
                IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontData = new byte[fontStream.Length];

                fontStream.Read(fontData, 0, (int)fontStream.Length);
                Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
                _pfc.AddMemoryFont(data, (int)fontStream.Length);
                fontStream.Close();
                Marshal.FreeCoTaskMem(data);
            }

            lblTitle.Font = new Font(_pfc.Families[0], 25, FontStyle.Regular);
            tbLogin.Font = new Font("Montserrat", 12, FontStyle.Regular);
            tbPassword.Font = new Font("Montserrat", 12, FontStyle.Regular);
            btnLogin.Font = new Font(_pfc.Families[0], 13, FontStyle.Regular);
        }
        #endregion

        #region -> Кнопки
        #region -[Войти]-
        private void BtnLogin_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(32, 34, 50));

            Rectangle rectWave = new Rectangle(
                _clLocationLogin.X - (int)_animWavePressLogin.Value / 2,
                _clLocationLogin.Y - (int)_animWavePressLogin.Value / 2,
                (int)_animWavePressLogin.Value,
                (int)_animWavePressLogin.Value
            );
            Rectangle rect = new Rectangle(0, 0, btnLogin.Width, btnLogin.Height);

            if (_animWavePressLogin.Value > 0 && _animWavePressLogin.Value < _animWavePressLogin.TargetValue)
                g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
            else if (_animWavePressLogin.Value == _animWavePressLogin.TargetValue)
            {
                _animWavePressLogin.Value = -1;

                if (_mousePressedLogin)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }

            g.DrawString(btnLogin.Text, new Font(_pfc.Families[0], 13), new SolidBrush(Color.White), rect, _sf);
        }

        private void BtnLogin_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mousePressedLogin = true;
                _clLocationLogin = e.Location;

                _animWavePressLogin = new Animation("btnLoginPress_" + btnLogin.Handle, btnLogin.Invalidate, 0, btnLogin.Width * 2);
                Animator.Request(_animWavePressLogin, true);
            }
        }

        private void BtnLogin_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressedLogin = false;
        }

        private void BtnLogin_OnClick(object sender, EventArgs e)
        {
            if (!Auth())
                return;

            FormMain form = new FormMain();
            form.Show();
            FormAuth.SelfForm.Hide();
        }
        #endregion
        #endregion

        #region -> Поля
        #region -[Логин]-
        private void TbLoginFalse_OnFocusEnter(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }

        private void TbLogin_OnFocusEnter(object sender, EventArgs e)
        {
            if (tbLogin.ForeColor == Color.FromArgb(154, 154, 154))
            {
                tbLogin.Text = "";
                tbLogin.ForeColor = Color.White;
            }
        }

        private void TbLogin_OnFocusLeave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Логин";
                tbLogin.ForeColor = Color.FromArgb(154, 154, 154);
            }
        }
        #endregion

        #region -[Регистрация]-
        private void TbPasswordFalse_OnFocusEnter(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void TbPassword_OnFocusEnter(object sender, EventArgs e)
        {
            if (tbPassword.ForeColor == Color.FromArgb(154, 154, 154))
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.White;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void TbPassword_OnFocusLeave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Пароль";
                tbPassword.ForeColor = Color.FromArgb(154, 154, 154);
                tbPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #endregion

        #endregion

        #region [Методы]
        private bool Auth()
        {
            DB db = new DB();

            if (!db.Connect("coursework"))
                return false;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `Login` = @Login AND `Password` = @Password");
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = EncodeString(tbLogin.Text);
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = EncodeString(tbPassword.Text);
            var table = db.Select(cmd);

            if (table.Rows.Count > 0)
                return true;
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль", "Неправильный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string EncodeString(string original)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(original));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    sb.Append(bytes[i].ToString("x2"));

                return sb.ToString();
            }
        }
        #endregion
    }
}
