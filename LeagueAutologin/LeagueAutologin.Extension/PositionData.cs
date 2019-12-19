using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueAutologin.Extension
{
    public class PositionData
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int UsernameX { get; set; }
        public int UsernameY { get; set; }

        public int PasswordX { get; set; }
        public int PasswordY { get; set; }

        public int ButtonX { get; set; }
        public int ButtonY { get; set; }

        public int LogoX { get; set; }
        public int LogoY { get; set; }

        public PositionData(int width, int height, int usernameX, int usernameY, int passwordX, int passwordY,
            int buttonX, int buttonY, int logoX, int logoY)
        {
            Width = width;
            Height = height;
            UsernameX = usernameX;
            UsernameY = usernameY;
            PasswordX = passwordX;
            PasswordY = passwordY;
            ButtonX = buttonX;
            ButtonY = buttonY;
            LogoX = logoX;
            LogoY = logoY;
        }

    }
}
