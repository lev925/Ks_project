using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatedWindow;

namespace Lab1
{
    public partial class WinAnim : Form
    {
        public WinAnim()
        {
            InitializeComponent();
        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию
            // второй параметр в скобках время анимации
            // в милисекундах
            WinApiClass.AnimateWindow(this, 1000, WinApiClass.AnimateWindowFlags.AW_ACTIVATE | WinApiClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кномпки после анимации
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinApiClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {

            this.Hide();
            WinApiClass.AnimateWindow(this, 3000,
            WinApiClass.AnimateWindowFlags.AW_CENTER |
            WinApiClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }
    }
}
