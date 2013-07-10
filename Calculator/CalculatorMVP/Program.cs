using System;
using System.Windows.Forms;

namespace CalculatorMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var calculatorPresenter = new CalculatorPresenter();
            Application.Run(calculatorPresenter.View);
        }
    }
}
