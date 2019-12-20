using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueAutologin.Library
{
    public class Account
    {
        public string Username { get; private set; }
        public byte[] Password { get; private set; }
        public byte[] Salt { get; private set; }
        public string Nickname { get; private set; }
        public string Region { get; private set; }

        public Account(string username, byte[] password, byte[] salt, string nickname, string region)
        {
            Username = username;
            Password = password;
            Nickname = nickname;
            Region = region;
            Salt = salt;
        }
    }
}
