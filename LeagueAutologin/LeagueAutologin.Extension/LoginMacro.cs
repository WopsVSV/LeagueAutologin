using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Extension
{
    public class LoginMacro
    {
        public static void ExecuteMacro(PositionData pData, Rectangle window, string username, string password)
        {
            int oldX = System.Windows.Forms.Control.MousePosition.X;
            int oldY = System.Windows.Forms.Control.MousePosition.Y;

            pData = new PositionData(pData.Width, pData.Height,
                pData.UsernameX + window.X,
                pData.UsernameY + window.Y,
                pData.PasswordX + window.X,
                pData.PasswordY + window.Y,
                pData.ButtonX + window.X,
                pData.ButtonY + window.Y,
                pData.LogoX, pData.LogoY);


            // Username
            SetCursorPos(pData.UsernameX, pData.UsernameY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.UsernameX, pData.UsernameY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.UsernameX, pData.UsernameY, 0, 0);
            System.Threading.Thread.Sleep(75);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.UsernameX, pData.UsernameY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.UsernameX, pData.UsernameY, 0, 0);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(25);
            SendKeys.Send(username);

            System.Threading.Thread.Sleep(25);

            // Password
            SetCursorPos(pData.PasswordX, pData.PasswordY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.PasswordX, pData.PasswordY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.PasswordX, pData.PasswordY, 0, 0);
            System.Threading.Thread.Sleep(75);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.PasswordX, pData.PasswordY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.PasswordX, pData.PasswordY, 0, 0);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(25);
            SendKeys.Send(password);

            System.Threading.Thread.Sleep(25);

            SetCursorPos(pData.ButtonX, pData.ButtonY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.ButtonX, pData.ButtonY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.ButtonX, pData.ButtonY, 0, 0);

            SetCursorPos(oldX, oldY);

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

    }
}
