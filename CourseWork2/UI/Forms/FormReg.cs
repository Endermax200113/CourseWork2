using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UI.Animations;
using CourseWork2.Database;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CourseWork2.UI.Forms
{
    public partial class FormReg : Form
    {
        #region [Переменные]
        #region -> Общие
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        private StringFormat _sf = new StringFormat();
        #endregion

        #region ->Кнопки
        #region -[Зарегистрироваться]-
        private Point _clLocationReg = new Point();
        private Animation _animWavePressReg = new Animation();
        private bool _mousePressedReg = false;
        #endregion
        #endregion
        #endregion

        public FormReg()
        {
            InitializeComponent();

            _sf.Alignment = StringAlignment.Center;
            _sf.LineAlignment = StringAlignment.Center;
        }

        #region [Слушатели]
        #region -> Окно
        private void FormReg_OnLoad(object sender, EventArgs e)
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
            tbPasswordRepeat.Font = new Font("Montserrat", 12, FontStyle.Regular);
            btnReg.Font = new Font(_pfc.Families[0], 13, FontStyle.Regular);
        }
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

        #region -[Пароль]-
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

        #region -[Повторный пароль]-
        private void TbPasswordRepeatFalse_OnFocusEnter(object sender, EventArgs e)
        {
            tbPasswordRepeat.Focus();
        }

        private void TbPasswordRepeat_OnFocusEnter(object sender, EventArgs e)
        {
            if (tbPasswordRepeat.ForeColor == Color.FromArgb(154, 154, 154))
            {
                tbPasswordRepeat.Text = "";
                tbPasswordRepeat.ForeColor = Color.White;
                tbPasswordRepeat.UseSystemPasswordChar = true;
            }
        }

        private void TbPasswordRepeat_OnFocusLeave(object sender, EventArgs e)
        {
            if (tbPasswordRepeat.Text == "")
            {
                tbPasswordRepeat.Text = "Повторный пароль";
                tbPasswordRepeat.ForeColor = Color.FromArgb(154, 154, 154);
                tbPasswordRepeat.UseSystemPasswordChar = false;
            }
        }
        #endregion
        #endregion

        #region -> Кнопки
        #region -[Зарегистрироваться]-
        private void BtnReg_OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.FromArgb(32, 34, 50));

            Rectangle rectWave = new Rectangle(
                _clLocationReg.X - (int)_animWavePressReg.Value / 2,
                _clLocationReg.Y - (int)_animWavePressReg.Value / 2,
                (int)_animWavePressReg.Value,
                (int)_animWavePressReg.Value
            );
            Rectangle rect = new Rectangle(0, 0, btnReg.Width, btnReg.Height);

            if (_animWavePressReg.Value > 0 && _animWavePressReg.Value < _animWavePressReg.TargetValue)
                g.FillEllipse(new SolidBrush(Color.FromArgb(25, Color.Black)), rectWave);
            else if (_animWavePressReg.Value == _animWavePressReg.TargetValue)
            {
                _animWavePressReg.Value = -1;

                if (_mousePressedReg)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 0, 0, 0)), rect);
            }

            g.DrawString(btnReg.Text, new Font(_pfc.Families[0], 13), new SolidBrush(Color.White), rect, _sf);
        }

        private void BtnReg_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mousePressedReg = true;
                _clLocationReg = e.Location;

                _animWavePressReg = new Animation("btnRegPress_" + btnReg.Handle, btnReg.Invalidate, 0, btnReg.Width * 2);
                Animator.Request(_animWavePressReg, true);
            }
        }

        private void BtnReg_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _mousePressedReg = false;
        }

        private void BtnReg_OnClick(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length < 8)
            {
                MessageBox.Show("Вы ввели менее 8 символов логина", "Слишком мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbLogin.Text.Length > 16)
            {
                MessageBox.Show("Вы ввели более 16 символов логина", "Слишком много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string pattern = @"^[\w-[\d_А-Яа-я]][\w-[_]]{2,16}$";

                if (!Regex.IsMatch(tbLogin.Text, pattern))
                {
                    MessageBox.Show("У вас введены некорректные символы. Пожалуйста, введите только английские буквы и цифры", "Некорректные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (tbPassword.Text.Length < 8)
            {
                MessageBox.Show("Вы ввели менее 8 символов пароля", "Слишком мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbPassword.Text.Length > 64)
            {
                MessageBox.Show("Вы ввели более 64 сиволов пароля", "Слишком много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbPassword.Text != tbPasswordRepeat.Text)
            {
                MessageBox.Show("Пароли, которые Вы ввели, не совпадают. Пожалуйста, проверьте, правильно ли Вы ввели пароль", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Register())
                return;

            FormMain form = new FormMain();
            form.Show();
            FormAuth.SelfForm.Hide();
        }
        #endregion
        #endregion
        #endregion

        #region [Методы]
        private bool Register()
        {
            DB db = new DB();

            if (!db.Connect("coursework"))
                return false;

            if (ExistLogin(db))
            {
                MessageBox.Show("Логин уже занят. Пожалуйста, введите другой логин", "Логин уже занят", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MySqlCommand cmd = new MySqlCommand("INSERT INTO `accounts`(`login`, `password`) VALUES(@login, @password)");
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = EncodeString(tbLogin.Text);
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = EncodeString(tbPassword.Text);

            db.ExecuteCommand(cmd);
            db.Disconnect();

            return true;
        }

        private bool ExistLogin(DB db)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `Login` = @Login");
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = tbLogin.Text;
            var table = db.Select(cmd);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
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
