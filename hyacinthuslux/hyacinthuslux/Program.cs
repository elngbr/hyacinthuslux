using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyacinthuslux
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add your condition here to decide which form to display
            bool showClientsForm = false; // Change this condition as needed

            if (showClientsForm)
            {
                Application.Run(new ClientsForm());
            }
            else
            {
                Application.Run(new ProductsForm());
            }
        }
    }
}