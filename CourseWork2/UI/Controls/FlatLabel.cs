using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.UI.Controls
{
    public class FlatLabel : Label
    {
        public FlatLabel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}
