using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.UI.Forms
{
    public partial class FormReg : Form
    {
        #region [Переменные]
        #region -> Общие
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        #endregion
        #endregion

        public FormReg()
        {
            InitializeComponent();
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
        #endregion
    }
}
