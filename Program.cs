using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDOGAMM
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Connexion.GetInstance();//verifie connexion SQL
            //Application.Run(new Administration());
            //Application.Run(new Accueil());
            //Application.Run(new Adherents());
            Application.Run(new Accueil());
            //Application.Run(new MenuView());
        }
    }
}
