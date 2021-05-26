using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentForm());
            Application.Run(new WinQuestioncs());
            Application.Run(new TestList());
            Application.Run(new WinContainer());
            Application.Run(new WinLinkLabel());
            Application.Run(new RegistrationForm());
            Application.Run(new TestStandartDialog());

        }
    }
}
