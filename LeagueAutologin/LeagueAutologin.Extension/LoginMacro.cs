using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeagueAutologin.Extension
{
    /// <summary>
    /// Used to execute the login macro.
    /// </summary>
    public class LoginMacro
    {
        public static void ExecuteMacro(PositionData pData, Rectangle window, string username, string password)
        {
            // Remember old mouse position to return to it afterwards.
            int oldX = Control.MousePosition.X;
            int oldY = Control.MousePosition.Y;

            // Generates relative position data to the client.
            pData = new PositionData(pData.Width, pData.Height,
                pData.UsernameX + window.X,
                pData.UsernameY + window.Y,
                pData.PasswordX + window.X,
                pData.PasswordY + window.Y,
                pData.ButtonX + window.X,
                pData.ButtonY + window.Y,
                pData.LogoX, pData.LogoY);

            // Avoiding a problem: { and } are special characters for SendKeys. We have to escape them.
            password = password.Replace("{", "^^{^^");
            password = password.Replace("}", "^^}^^");
            password = password.Replace("^^{^^", "{{}");
            password = password.Replace("^^}^^", "{}}");
            // Easy, but inefficient method. In the grand scheme of things, this doesn't make any difference.


            // Input username
            SetCursorPos(pData.UsernameX, pData.UsernameY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.UsernameX, pData.UsernameY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.UsernameX, pData.UsernameY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.UsernameX, pData.UsernameY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.UsernameX, pData.UsernameY, 0, 0);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(10);
            SendKeys.Send(username);

            System.Threading.Thread.Sleep(5);

            // Input password
            SetCursorPos(pData.PasswordX, pData.PasswordY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.PasswordX, pData.PasswordY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.PasswordX, pData.PasswordY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.PasswordX, pData.PasswordY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.PasswordX, pData.PasswordY, 0, 0);
            SendKeys.Send("{BACKSPACE}");
            System.Threading.Thread.Sleep(10);

            SendKeys.Send(password);

            System.Threading.Thread.Sleep(5);

            // Click login
            SetCursorPos(pData.ButtonX, pData.ButtonY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, pData.ButtonX, pData.ButtonY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, pData.ButtonX, pData.ButtonY, 0, 0);

            // Reset position
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
