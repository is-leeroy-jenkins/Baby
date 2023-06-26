
namespace BudgetBrowser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Licensing;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense(
                "MjIyNzQwMEAzMjMxMmUzMTJlMzMzNWJ6Ylo1L05Bcm1yT0wyenJGMWhFM21xdUJlUERvMUdOUmE3MnBJUjJFbzQ9;MjIyNzQwMUAzMjMxMmUzMTJlMzMzNUZUcGV5Y29yQkkvS0lNVWl1RTBSTTArYmFJQ3Z0NHZMK1FYYm0zOFo1OGM9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
