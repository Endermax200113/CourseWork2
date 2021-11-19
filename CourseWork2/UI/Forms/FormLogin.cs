using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CourseWork2.UI.Forms
{
    public partial class FormLogin : Form
    {
        #region [Переменные]
        #region -> Общие
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        #endregion
        #endregion

        public FormLogin()
        {
            InitializeComponent();
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

            lblTitle.Font = new Font(_pfc.Families[0], 25);
            tbLogin.Font = new Font(_pfc.Families[0], 13);
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
        #endregion

        #endregion
    }
}
