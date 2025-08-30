using SsRecorder.View;
using SsRecorder.Service;

namespace SsRecorder {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var ssRecorder = new SsRecorderService();
            Application.Run(new SsRecorderForm(ssRecorder));
        }
    }
}