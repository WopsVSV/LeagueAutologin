using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LeagueAutologin.Library
{
    /// <summary>
    /// Specialised class for handling XML configuration for accounts.
    /// </summary>
    public class XmlConfiguration
    {
        private readonly XDocument document;
        public readonly string path;

        /// <summary>
        /// Creates a new XDocument using the given path
        /// </summary>
        /// <param name="configPath"></param>
        public XmlConfiguration(string configPath)
        {
            // Loads the document
            document = XDocument.Load(configPath);

            // Path kept so file can be saved
            path = configPath;
        }

        /// <summary>
        /// Creates a new configuration file
        /// </summary>
        public static XmlConfiguration CreateConfiguration(string configPath)
        {

            // Create a new config document if it doesn't exist
            if (!File.Exists(configPath))
                new XDocument(new XElement("accounts")).Save(configPath);

            return new XmlConfiguration(configPath);
        }

        /// <summary>
        /// Adds an account to the XML document.
        /// </summary>
        public void AddAccount(Account account)
        {
            XElement element = new XElement("account");
            element.Add(new XElement("username", account.Username));
            element.Add(new XElement("password", Convert.ToBase64String(account.Password)));
            element.Add(new XElement("salt", Convert.ToBase64String(account.Salt)));
            element.Add(new XElement("nickname", account.Nickname));
            element.Add(new XElement("region", account.Region));
            element.Add(new XElement("rank", account.Rank));

            document.Root.Add(element);
        }

        /// <summary>
        /// Removes an account from the XML document.
        /// </summary>
        public bool RemoveAccount(Account account)
        {
            try
            {
                foreach (var elem in document.Root.Elements())
                {
                    if (elem.Element("username") == null || elem.Element("region") == null) continue;

                    if(account.Username == elem.Element("username").Value &&
                        account.Region == elem.Element("region").Value)
                    {
                        elem.Remove();
                    }
                }
            }
            catch { return false; }
            return true;
        }

        public void ChangeAccount(Account account, string rank)
        {
            try
            {
                foreach (var elem in document.Root.Elements())
                {
                    if (elem.Element("username") == null || elem.Element("region") == null) continue;

                    if (account.Username == elem.Element("username").Value &&
                        account.Region == elem.Element("region").Value)
                    {
                        elem.Element("rank").Value = rank;
                      
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Reads and returns a list of all accounts included in the XML.
        /// </summary>
        public List<Account> ReadAccounts()
        {
            List<Account> accounts = new List<Account>();
            try
            {
                foreach (var elem in document.Root.Elements())
                {
                    if (elem.Element("username") == null || 
                        elem.Element("region") == null ||
                        elem.Element("password") == null ||
                        elem.Element("nickname") == null) continue;

                    Account acc = new Account(
                        elem.Element("username").Value,
                        Convert.FromBase64String(elem.Element("password").Value),
                        Convert.FromBase64String(elem.Element("salt").Value),
                        elem.Element("nickname").Value,
                        elem.Element("region").Value,
                        elem.Element("rank").Value);
                    accounts.Add(acc);
                }
            }
            catch { return null; }
            return accounts;
        }

        /// <summary>
        /// Saves the configuration document
        /// </summary>
        public void Save()
        {
            document.Save(path);
        }
    }
}
