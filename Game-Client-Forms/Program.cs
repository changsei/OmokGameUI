using System.Runtime.InteropServices;

namespace Game_Client_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Form _loginForm;
            // 콘솔창 실행
            AllocConsole();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(_loginForm = LoginForm.Instance);
        }

        // 콘솔 창 할당을 위한 Win32 API 함수 선언
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
    }
}