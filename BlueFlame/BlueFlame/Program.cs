using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace BlueFlame
{
    static class Program
    {
        [ThreadStaticAttribute()]
        private static int _logCount = 0;
        public static int LogCount
        { 
            get{ return ++_logCount; }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if(Thread.CurrentThread.CurrentUICulture.Name == "en")
            MessageBox.Show("A fatal error occured! Please ask your administrator for help and tell him this: " 
                + Environment.NewLine + 
                e.ExceptionObject.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            MessageBox.Show("Ein wirklich absolut unerwarteter Fehler trat auf. Glückwunsch, Sie haben das Programm kaputt gemacht! Bitte sagen Sie ihrem Administrator bescheid und teilen Sie ihm die folgende Fehlermeldung mit: "
                + Environment.NewLine 
                + e.ExceptionObject.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            
            if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                MessageBox.Show("A fatal error occured! Please ask your administrator for help and tell him this: "
                    + Environment.NewLine +
                    e.Exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Ein wirklich absolut unerwarteter Fehler trat auf. Glückwunsch, Sie haben das Programm kaputt gemacht! Bitte sagen Sie ihrem Administrator bescheid und teilen Sie ihm die folgende Fehlermeldung mit: "
                    + Environment.NewLine +
                    e.Exception.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }       
    }
}