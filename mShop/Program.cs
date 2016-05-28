using mShop.Models;
using mShop.Presenters;
using System;
using System.Windows.Forms;

namespace mShop
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

            Model model = new Model();
            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(model, view);

            Application.Run(view);
        }
    }
}
